using LinkSaveR.CRUD;
using System.Diagnostics;
using System.Net.Mail;
using System.Net;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System;
using System.Windows;
using MessageBox = System.Windows.Forms.MessageBox;

namespace LinkSaveR
{
    public partial class LinkSaver : Form
    {
        private List<Link> currentLink = new List<Link>();
        public static string url = "";
        public static int deleteId =-1;
        public LinkSaver()
        {
            InitializeComponent();

           
        }

        private void LinkSaver_Load(object sender, EventArgs e)
        {


            LoadDataGridView();
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Columns[0].HeaderText = "Link ID";
            dataGridView1.Columns[1].HeaderText = "Category ID";
            dataGridView1.Columns[2].HeaderText = "Category Name";
            dataGridView1.Columns[3].HeaderText = "Link Description";
            dataGridView1.Columns[4].HeaderText = "Link Content";
            dataGridView1.Columns[0].Visible=false;
            dataGridView1.Columns[1].Visible = false;


            //ColumnHeader

            dataGridView1.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            dataGridView1.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            dataGridView1.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

        
        }

        //    Clipboard.SetData(DataFormats.StringFormat, "string data gir");


        #region drag drop


        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd,
                         int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        #endregion
        #region UI taraf iþlemleri
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);

        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        #endregion

        



        public void LoadDataGridView()
        {
            comboBox1.Items.Clear();
            comboBox2.Items.Clear();

            var data = Crud.GetLinks();
            currentLink = data;


            var filter = data.Select(x => new
            {
                Id = x.Id,
                CategoryId = x.CategoryId,
                CategoryName = x.Category.Name,
                Description = x.Description,
                LinkContent = x.LinkData

            });

            dataGridView1.DataSource = filter.ToList();

            var categories = Crud.GetCategories();

            categories.ForEach(x =>
            {

                comboBox1.Items.Add(x.Id + "_" + x.Name);
                comboBox2.Items.Add(x.Id + "_" + x.Name);
            });

        }

        private void BtnEkle_Click(object sender, EventArgs e)
        {
           
           
            if (txtLink.Text == string.Empty)
            {
                MessageBox.Show("link value may not be empty. pls enter a link");
                return;
            }
            if (comboBox1.SelectedItem != null && txtCategory.Text != string.Empty)
            {
                MessageBox.Show("choose just one. Add a new category or select an existing category");

                return;
            }
            if (comboBox1.SelectedItem == null && txtCategory.Text == string.Empty)
            {
                MessageBox.Show("pls add a category");
                return;
            }

            if (comboBox1.SelectedItem != null) 
            {

                var categoryID = comboBox1.SelectedItem.ToString().Split("_")[0];

                var link = new Link()
                {
                    CategoryId = int.Parse(categoryID),
                    LinkData = txtLink.Text,
                    Description = txtDescription.Text + ".."

                };
                Crud.LinkAdd(link);


            }
            else
            {

                if (txtCategory.Text.Contains("_"))
                {

                    MessageBox.Show("delete underscore  char pls");
                    return;
                }

                var link = new Link()
                {
                    LinkData = txtLink.Text,
                    Description = txtDescription.Text + "..",
                    Category = new() { Name = txtCategory.Text }
                };
                Crud.LinkAdd(link);

            }

            comboBox1.SelectedIndex = -1;
            comboBox2.SelectedIndex = -1;
            txtCategory.Clear();
            txtLink.Clear();
            txtDescription.Clear();

            LoadDataGridView();
            ResetDeleteBtnAndBrowserBtn();
        }

      
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            /*
               Id = x.Id,
                CategoryId = x.CategoryId,
                CategoryName = x.Category.Name,
                Description = x.Description,
                LinkContent = x.LinkData
             
             */

            url=  dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            var descrip = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            var ýd = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            var Cagegoryýd = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            deleteId = int.Parse(ýd);
            GoLink.Text = $"{ýd} id link selected";
            bntsil.Text= $"{ýd} id link Delete";


            System.Windows.Clipboard.SetData(System.Windows.DataFormats.StringFormat, url);
            lblCopy.Text = $"Copied {deleteId}.ID link to clipboard";

        }

        private void GoLink_Click(object sender, EventArgs e)
        {

            try
            {


                ProcessStartInfo sInfo = new ProcessStartInfo(url)
                {
                    UseShellExecute = true,
                    Verb = "open"
                };
                Process.Start(sInfo);

            }
            catch (Exception)
            {
                MessageBox.Show("this link cannot open with the browser");
            }


        }

        private void bntsil_Click(object sender, EventArgs e)
        {
            //silme kodu

            Crud.DeleteLink(deleteId);
            LoadDataGridView();
            ResetDeleteBtnAndBrowserBtn();
        }

        public void ResetDeleteBtnAndBrowserBtn()
        {
            GoLink.Text = "select and open with your browser";
            url = "";
            bntsil.Text = "Select and Delete";
            comboBox1.SelectedIndex = -1;
            comboBox2.SelectedIndex = -1;
            deleteId = -1;
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void txtSearch_KeyUp(object sender, KeyEventArgs e)
        {
            comboBox2.SelectedIndex = -1;
            if (!(radioButton1.Checked || radioButton2.Checked))
            {
                txtSearch.ResetText();
                MessageBox.Show("pls choose a search option");

                return;
            }


            try
            {



                if (txtSearch.Text==string.Empty)
                {
                    dataGridView1.DataSource = currentLink;
                }


                var temp = new List<Link>();

                if(radioButton2.Checked)
                 temp= currentLink.Where(x =>x.Category.Name.Contains(txtSearch.Text,StringComparison.OrdinalIgnoreCase)).ToList();

                if(radioButton1.Checked)
                    temp= currentLink.Where(x => x.Description.Contains(txtSearch.Text)).ToList();


                var data = temp.Select(x => new
                {
                    Id = x.Id,
                    CategoryId = x.CategoryId,
                    CategoryName = x.Category.Name,
                    Description = x.Description,
                    LinkContent = x.LinkData

                });

                dataGridView1.DataSource = data.ToList(); ;

            }
            catch (Exception)
            {

                

            }
            finally
            {
                dataGridView1.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dataGridView1.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CategorySettings newFrm = new CategorySettings();

            newFrm.frmMain = this;
            newFrm.Show();
            this.Hide();


            
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

          
            var ýd = int.Parse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
            var Cagegoryýd = int.Parse(dataGridView1.SelectedRows[0].Cells[1].Value.ToString());
            url = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            var descrip = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            var categoryName = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();

            Update updateFrm = new Update();

            updateFrm.CategoryID = Cagegoryýd;
            updateFrm.LinkId = ýd;
            updateFrm.Main = this;
            updateFrm.Url = url;
            updateFrm.Comment = descrip;
            updateFrm.CategoryName = categoryName;





            this.Enabled=false;

            updateFrm.Show();


        }

        private void LinkSaver_FormClosed(object sender, FormClosedEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void LinkSaver_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void txtCategory_KeyUp(object sender, KeyEventArgs e)
        {
            comboBox1.SelectedIndex = -1;
          //  comboBox1.res
        }

        private void comboBox2_SelectedValueChanged(object sender, EventArgs e)
        {
            if (comboBox2.SelectedIndex != -1)
            {

                radioButton1.Checked = false;
                radioButton2.Checked = false;
                txtSearch.Clear();





                try
                {




                    var temp = new List<Link>();

                   
                    var queryKey = comboBox2.SelectedItem.ToString().Split("_")[0];
                    temp = currentLink.Where(x => x.CategoryId == int.Parse(queryKey)).ToList();
                    var data = temp.Select(x => new
                    {
                        Id = x.Id,
                        CategoryId = x.CategoryId,
                        CategoryName = x.Category.Name,
                        Description = x.Description,
                        LinkContent = x.LinkData

                    });

                    dataGridView1.DataSource = data.ToList(); ;

                }
                catch (Exception)
                {



                }
                finally
                {
                    dataGridView1.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    dataGridView1.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                }


            }
           
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {



                DialogResult dialogResult = MessageBox.Show("Do you want to back up the system", "Sure ?", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    this.Enabled = false;

                    var path = Environment.CurrentDirectory.ToString() + @"\LinkDatabase.db";
                    string destinationFile = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\VeriTabanýKopyasý" + ".db";
                    File.Copy(path, destinationFile, true);
                    SmtpClient sc = new SmtpClient("smtp.gmail.com", 587);
                    // sc.Port = 587;
                    sc.EnableSsl = true;
                    sc.Credentials = new NetworkCredential("MAÝL", "MAÝL APP PASSWORD");

                    MailMessage mail = new MailMessage();
                    mail.From = new MailAddress("MAÝL", "LinkSaver BTech");
                    mail.To.Add("Destination Mail address");

                    mail.Subject = "LinkSaver BackUp";
                    mail.IsBodyHtml = true;
                    mail.Body = DateTime.Now.ToString() + " LinkSaver Database Backup System";

                    mail.Attachments.Add(new Attachment(destinationFile));
                    sc.Send(mail);

                    MessageBox.Show("backup successful!! you can delete the backup file after closing the program");


                }
                else if (dialogResult == DialogResult.No)
                {
                    MessageBox.Show("It is cancelled");
                    return;
                }

           
            }
            catch (Exception)
            {
                MessageBox.Show("an error has occurred");
               
            }
            finally
            {
                this.Enabled = true;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            comboBox2.SelectedIndex = -1;
            txtSearch.Clear();

            LoadDataGridView();
            ResetDeleteBtnAndBrowserBtn();
        }
    }

}