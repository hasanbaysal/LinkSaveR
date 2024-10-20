using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using OpenFileDialog = System.Windows.Forms.OpenFileDialog;

namespace HB.LinkSaver.Pages
{
    public partial class SettingsForm : Form
    {
        public SettingsForm()
        {
            InitializeComponent();
        }

        private void SettingsForm_Load(object sender, EventArgs e)
        {
            lblMailHtmlInfo.Visible = false;
            lblInfo.Visible = false;
            var txt = Program.GetUseServerSettingsStatus() ? "server active" : "server deactivated ";

            lblStatus.ForeColor = Program.GetUseServerSettingsStatus() ? Color.Green : Color.Red;
            lblStatus.Text = txt;


            btnServer.Text = Program.GetUseServerSettingsStatus() ? "deactivate the server" : "activate the server";
        }

        private void btnServer_Click(object sender, EventArgs e)
        {
            var path = Path.Combine(Directory.GetCurrentDirectory(), "user.txt");
            var status = Program.GetUseServerSettingsStatus() ? "server:0" : "server:1";
            File.WriteAllText(path, status);
            MessageBox.Show("server status changed. Application will be restart");
            Application.Restart();
        }

        private void backupBtn_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("do you want to back up files", "back up", MessageBoxButtons.YesNo);

            if (result == DialogResult.No) return;

            string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

            var backupFolderName = "backup-" + DateTime.Now.ToString("yyyy-dd-mm-ss");

            Directory.CreateDirectory(Path.Combine(desktopPath, backupFolderName));

            File.Copy(Path.Combine(Directory.GetCurrentDirectory(), LinkManager.LinksPath), Path.Combine(desktopPath, backupFolderName, LinkManager.LinksPath));
            File.Copy(Path.Combine(Directory.GetCurrentDirectory(), LinkManager.CategoriesPath), Path.Combine(desktopPath, backupFolderName, LinkManager.CategoriesPath));

            MessageBox.Show(@"The files have been copied to the desktop. you can use these files in case you lose the files on your system. you need to add the json extension files in the backup folder to the directory where the application is running.", backupFolderName + " BACK UP FOLDER CREATED", MessageBoxButtons.OK);
        }

        string linksPath = Path.Combine(Directory.GetCurrentDirectory(), LinkManager.LinksPath);
        string CategoriesPath = Path.Combine(Directory.GetCurrentDirectory(), LinkManager.CategoriesPath);

        private void button2_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog fd = new OpenFileDialog())
            {
                fd.Filter = "JSON Files (*.json)|*.json";
                fd.Multiselect = true;

                if (fd.ShowDialog() == DialogResult.OK)
                {
                    string[] selectedFiles = fd.FileNames;
                    if (selectedFiles.Length != 2) { MessageBox.Show("select link and category file together"); return; }
                    string selectedLinkJson = null;
                    string selectedCategoryJson = null;

                    var controllink = false;
                    var controlCategory = false;

                    foreach (var file in selectedFiles)
                    {

                        if (Path.GetFileName(file).ToLower() == LinkManager.LinksPath.ToLower())
                        {
                            controllink = true;
                            selectedLinkJson = file;
                        }
                        if (Path.GetFileName(file).ToLower() == LinkManager.CategoriesPath.ToLower())
                        {
                            controlCategory = true;
                            selectedCategoryJson = file;
                        }

                    }
                    if (!(controllink && controlCategory)) { MessageBox.Show("please select links.json and categories.json backup files "); return; }
                    else
                    {
                        File.Copy(selectedLinkJson!, linksPath, true); // true, üzerine yazmayı sağlar
                        File.Copy(selectedCategoryJson!, CategoriesPath, true);
                        MessageBox.Show("back-up files uploaded. the application will be restart");
                        Application.Restart();
                    }


                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MailSettings mailSettings = new MailSettings();
            mailSettings.ShowDialog();

        }

        private async void button1_Click(object sender, EventArgs e)
        {
            var mailSettings = new MailSettingsOption();

            mailSettings = JsonSerializer.Deserialize<MailSettingsOption>(File.ReadAllText(Path.Combine(Environment.CurrentDirectory, LinkManager.MailSettingsPath)));


            if (mailSettings.MailAddress.Contains("none") ||
                mailSettings.AppPassword.Contains("none") ||
                mailSettings.RecipientMailAddress.Contains("none") ||
                mailSettings.PortNumber.ToString() == "0" ||
                mailSettings.StmpServer.Contains("none"))
            {
                MessageBox.Show("please edit your mail configurations");
            }


            SmtpClient sc = new SmtpClient(mailSettings.StmpServer, mailSettings.PortNumber);
            sc.EnableSsl = true;
            sc.Credentials = new NetworkCredential(mailSettings.MailAddress, mailSettings.AppPassword);
            sc.DeliveryMethod = SmtpDeliveryMethod.Network;
            sc.UseDefaultCredentials = false;
            MailMessage mail = new MailMessage();
            mail.Priority = MailPriority.High;
            mail.From = new MailAddress(mailSettings.MailAddress, "LinkSaver Backup System");
            mail.To.Add(mailSettings.RecipientMailAddress);
            mail.Subject = "LinkSaver Backup System";
            mail.IsBodyHtml = true;
            mail.Body = "Backup date : " + DateTime.Now.ToString();

            using (OpenFileDialog fd = new OpenFileDialog())
            {
                try
                {
                    fd.Filter = "JSON Files (*.json)|*.json";
                    fd.Multiselect = true;

                    if (fd.ShowDialog() == DialogResult.OK)
                    {

                        string[] selectedFiles = fd.FileNames;
                        if (selectedFiles.Length != 2) { MessageBox.Show("select link and category file together"); return; }
                        string selectedLinkJson = null;
                        string selectedCategoryJson = null;

                        var controllink = false;
                        var controlCategory = false;

                        foreach (var file in selectedFiles)
                        {

                            if (Path.GetFileName(file).ToLower() == LinkManager.LinksPath.ToLower())
                            {
                                controllink = true;
                                selectedLinkJson = file;
                            }
                            if (Path.GetFileName(file).ToLower() == LinkManager.CategoriesPath.ToLower())
                            {
                                controlCategory = true;
                                selectedCategoryJson = file;
                            }

                        }

                        if (!(controllink && controlCategory)) { MessageBox.Show("please select links.json and categories.json backup files "); return; }

                        mail.Attachments.Add(new Attachment(selectedCategoryJson!));
                        mail.Attachments.Add(new Attachment(selectedLinkJson!));

                        lblInfo.Visible = true;
                        await sc.SendMailAsync(mail);
                        lblInfo.Visible = false;
                        MessageBox.Show("success!");

                    }
                }
                catch (Exception)
                {

                    MessageBox.Show("please check your mail configurations or smtp server");
                }
            }
        }

        private void btnHtmlGenerator_Click(object sender, EventArgs e)
        {
            string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

            HtmlGenerator htmlGenerator = new HtmlGenerator(LinkManager.GetAll());

            var data = htmlGenerator.GenerateGtml();

            File.WriteAllText(Path.Combine(desktopPath, "data.html"), data);
            MessageBox.Show("backup created on your desktop");
        }

        private async void MailHtml_Click(object sender, EventArgs e)
        {
            var mailSettings = new MailSettingsOption();

            mailSettings = JsonSerializer.Deserialize<MailSettingsOption>(File.ReadAllText(Path.Combine(Environment.CurrentDirectory, LinkManager.MailSettingsPath)));


            if (mailSettings.MailAddress.Contains("none") ||
                mailSettings.AppPassword.Contains("none") ||
                mailSettings.RecipientMailAddress.Contains("none") ||
                mailSettings.PortNumber.ToString() == "0" ||
                mailSettings.StmpServer.Contains("none"))
            {
                MessageBox.Show("please edit your mail configurations");
            }


            SmtpClient sc = new SmtpClient(mailSettings.StmpServer, mailSettings.PortNumber);
            sc.EnableSsl = true;
            sc.Credentials = new NetworkCredential(mailSettings.MailAddress, mailSettings.AppPassword);
            sc.DeliveryMethod = SmtpDeliveryMethod.Network;
            sc.UseDefaultCredentials = false;
            MailMessage mail = new MailMessage();
            mail.Priority = MailPriority.High;
            mail.From = new MailAddress(mailSettings.MailAddress, "LinkSaver Backup System");
            mail.To.Add(mailSettings.RecipientMailAddress);
            mail.Subject = "LinkSaver Backup System";
            mail.IsBodyHtml = true;
            mail.Body = "Backup date : " + DateTime.Now.ToString();

            string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

            HtmlGenerator htmlGenerator = new HtmlGenerator(LinkManager.GetAll());

            var data = htmlGenerator.GenerateGtml();

            File.WriteAllText(Path.Combine(desktopPath, "data.html"), data);

            var filePath = Path.Combine(desktopPath, "data.html");
            mail.Attachments.Add(new Attachment( filePath));

            lblMailHtmlInfo.Visible = true;
            await sc.SendMailAsync(mail);
            lblMailHtmlInfo.Visible = false;
            MessageBox.Show("success");
        }
    }
}
