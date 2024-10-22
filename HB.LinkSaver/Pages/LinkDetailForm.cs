using FontAwesome.Sharp;
using System.Diagnostics;

namespace HB.LinkSaver.Pages
{
    public partial class LinkDetailForm : Form
    {
        public Link Link { get; set; }
        public LinkDetailForm()
        {
            InitializeComponent();
        }

        private void LinkDetailForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void LinkDetailForm_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;
            AddCategory();
            lblLİnk.Text = Link.Content;
            tbDescription.Text = Link.Description;
            lblHeader.Text = Link.Header;
            tbDescription.SelectionIndent = 10;
            tbDescription.SelectionRightIndent = 10;
            lblCopy.Visible = false;
            this.ıconButton1.Focus();
        }
        public void AddCategory()
        {
            foreach (var item in Link.Categories)
            {
                var btnTemp = new Button();
                btnTemp.BackColor = Color.FromArgb(30, 30, 30);
                btnTemp.Margin = new Padding(25, 3, 3, 25);
                btnTemp.Width = 270;
                btnTemp.Height = 35;
                btnTemp.TextAlign = ContentAlignment.TopCenter;
                btnTemp.ForeColor = Color.White;
                btnTemp.Font = new Font("Segoe UI", 12, FontStyle.Regular);
                btnTemp.FlatStyle = FlatStyle.Flat;
                btnTemp.Text = item;
                btnTemp.Name = item;
                btnTemp.TabStop = false;
                flowLayoutPanel1.Controls.Add(btnTemp);
                flowLayoutPanel1.Refresh();
            }
        }

        private void tbDescription_TextChanged(object sender, EventArgs e)
        {

        }

        private async void ıconButton1_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(lblLİnk.Text);

            lblCopy.Visible = true;
            await Task.Delay(350);
            lblCopy.Visible = false;


        }

        private void BtnOpenLink_Click(object sender, EventArgs e)
        {
            try
            {


                ProcessStartInfo sInfo = new ProcessStartInfo(Link.Content)
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

        private void BtnOpenLink_MouseHover(object sender, EventArgs e)
        {
            IconButton btn = sender as IconButton;
            btn.IconColor = Color.FromArgb(2, 117, 216);
            btn.ForeColor = Color.FromArgb(2, 117, 216);

        }

        private void BtnOpenLink_MouseLeave(object sender, EventArgs e)
        {
            IconButton btn = sender as IconButton;
            btn.IconColor = Color.White;
            btn.ForeColor = Color.White;
        }
    }
}
