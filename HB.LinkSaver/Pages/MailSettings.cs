using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.Pkcs;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HB.LinkSaver.Pages
{
    public partial class MailSettings : Form
    {
        public MailSettings()
        {
            InitializeComponent();
        }

        private void MailSettings_Load(object sender, EventArgs e)
        {
            var data = (JsonSerializer.Deserialize<MailSettingsOption>(File.ReadAllText(Path.Combine(Environment.CurrentDirectory, LinkManager.MailSettingsPath))))!;

            tbAppPass.Text = data.AppPassword;
            tbSenderMail.Text = data.MailAddress;
            tbSmtpServer.Text = data.StmpServer;
            tbPortNumber.Text = data.PortNumber.ToString();
            tbReciver.Text = data.RecipientMailAddress;


        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                var control = false;


                control =
                 string.IsNullOrEmpty(tbAppPass.Text) ||
                 string.IsNullOrEmpty(tbSmtpServer.Text) ||
                 string.IsNullOrEmpty(tbSenderMail.Text) ||
                 string.IsNullOrEmpty(tbReciver.Text) ||
                 string.IsNullOrEmpty(tbPortNumber.Text);

                if (control)
                {
                    MessageBox.Show("fill in all fields");
                    return;
                }

                var settings = new MailSettingsOption();

                settings.AppPassword = tbAppPass.Text;
                settings.StmpServer = tbSmtpServer.Text;
                settings.MailAddress = tbSenderMail.Text;
                settings.RecipientMailAddress = tbReciver.Text;



                var result = int.TryParse(tbPortNumber.Text, out int port);
                if (!result) { MessageBox.Show("wrong input!"); return; }
                settings.PortNumber = port;
                var json = JsonSerializer.Serialize(settings);
                File.WriteAllText(Path.Combine(Environment.CurrentDirectory, LinkManager.MailSettingsPath), json);
                MessageBox.Show("success");
                this.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("error, pls try again");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {

            string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);


            var result = JsonSerializer.Deserialize<MailSettingsOption>(File.ReadAllText(Path.Combine(Directory.GetCurrentDirectory(), LinkManager.MailSettingsPath)));

            var text = string.Empty;
            text += "Mail Configurations" + Environment.NewLine;
            text += "Mail Address (Sender) : " + result.MailAddress + Environment.NewLine;
            text += "App Password : " + result.AppPassword + Environment.NewLine;
            text += "Mail Address (revicer) : " + result.RecipientMailAddress + Environment.NewLine;
            text += "Port Number : " + result.PortNumber.ToString() + Environment.NewLine;
            text += "Smpt Server Address : " + result.StmpServer + Environment.NewLine;

            File.WriteAllText(desktopPath+"/MailSettings.txt", text);
            MessageBox.Show("Succes");

        }
    }
}



