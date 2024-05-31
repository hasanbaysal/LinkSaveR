using HB.LinkSaver.Pages;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Drawing.Printing;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography.Pkcs;
using System.Security.Policy;
using System.Windows.Forms;
using System.Windows.Markup;


namespace HB.LinkSaver
{
    public partial class MainForm : Form
    {

        public static AddPage AddPageI = new();
        public static CategoryPage CategoryPage = new();
        public static List<string> SelectedCategories = new List<string>();
        public string CurrentLinkId = string.Empty;
        public string CurrentLink = string.Empty;
        public bool SearchForText = false;

        public MainForm()
        {
            InitializeComponent();
        }


        #region Drag Drop
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd,
                         int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        private void PnlTop_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
        }
        #endregion


        public void LoadDgw()
        {

            DGW.DataSource = null;
            DGW.Update();
            DGW.Refresh();

            DGW.DataSource = LinkManager.GetAll();

            DGW.Columns[0].Visible = false;
            DGW.Columns[2].Visible = false;


            foreach (DataGridViewColumn column in DGW.Columns)
            {
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }

            DGW.Update();
            DGW.Refresh();
        }


        static bool status = false;
        public static void TogleSize()
        {
            status = !status;
            if (status)
            {

                Program.MainFrm.Width = 1095;

                Program.MainFrm.DGW.Enabled = false;


            }
            else
            {
                Program.MainFrm.Width = 490;
                Program.MainFrm.PnlPage.Controls.Clear();
                Program.MainFrm.DGW.Enabled = true;


            }

        }
        private void Form1_Load(object sender, EventArgs e)
        {

            LinkManager.Control();

            LoadDgw();
            LoadCategories();


        }
        public static void LoadCategories()
        {
            Program.MainFrm.LbSelectedCategories.Items.Clear();

            CategoryManager.Categories.ForEach(x =>
            {
                Program.MainFrm.LbSelectedCategories.Items.Add(x);
            });
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            AddPageI.UpdateMode = false;
            AddSelectedPage(AddPageI);

        }

        private void AddSelectedPage(System.Windows.Forms.UserControl control)
        {
            TogleSize();
            PnlPage.Controls.Clear();
            PnlPage.Controls.Add(control);
            PnlPage.Refresh();

        }

        private void DGW_CellClick(object sender, DataGridViewCellEventArgs e)
        {


            CurrentLinkId = DGW.Rows[e.RowIndex].Cells[0].Value.ToString()!;
            CurrentLink = DGW.Rows[e.RowIndex].Cells[2].Value.ToString()!;

            richTextBox1.Clear();




            AddText(GetWhiteSpaces(41) + "HEADER", Color.DarkRed);
            var headerContext = Environment.NewLine + DGW.Rows[e.RowIndex].Cells[1].Value.ToString() + Environment.NewLine;
            AddText(headerContext, Color.Red); var header = "HEADER";




            AddText(GetWhiteSpaces(36) + "DESCRÝPTÝON", Color.DarkBlue);
            var descContext = Environment.NewLine + DGW.Rows[e.RowIndex].Cells[3].Value.ToString() + Environment.NewLine;
            AddText(descContext, Color.Blue);



            AddText(GetWhiteSpaces(37) + "CATEGORÝES", Color.DarkGreen);

            var temp = Environment.NewLine;
            LinkManager.Links.Where(x => x.Id == CurrentLinkId).FirstOrDefault()!.Categories.ForEach(x => temp += "#" + x + "#   ");
            temp += Environment.NewLine;
            AddText(temp, Color.DarkOliveGreen);



        }

        private string GetWhiteSpaces(int count)
        {
            var temp = string.Empty;
            Enumerable.Range(0, count).ToList().ForEach(x => temp += " ");
            return temp;
        }
        public void AddText(string text, Color color)
        {
            richTextBox1.SelectionColor = color;
            richTextBox1.AppendText(text);
        }
        private void LbSelectedCategories_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBox lb = sender as ListBox;

            if (lb!.SelectedIndex == -1) return;


            if (totalCount == 8)
            {
                MessageBox.Show("The maximum number of categories is set to 8, you cannot add more. To add a category, first remove an existing category.");
                return;

            }

            var item = lb.SelectedItem.ToString();
            if (!SelectedCategories.Contains(item)) { AddCategoryLabel(item); SelectedCategories.Add(item); }

            SearchByFilters();

        }

        int x = 0;
        int y = 0;
        int count = 0;
        int totalCount = 0;
        public void AddCategoryLabel(string str)
        {

            System.Windows.Forms.Label lb = new System.Windows.Forms.Label();
            lb.Name = str;
            lb.Text = str;
            lb.TextAlign = ContentAlignment.MiddleCenter;
            lb.AutoSize = false;
            lb.ForeColor = Color.White;
            lb.Font = new Font("Segoe UI", 8, FontStyle.Bold, GraphicsUnit.Point, 162);
            lb.Location = new Point(x, y);
            lb.Size = new Size(350, 22);
            lb.FlatStyle = FlatStyle.Flat;
            lb.BackColor = Color.FromArgb(2, 117, 216); //43; 51; 68 //2; 117; 216
            //lb.Padding = new Padding(3);
            lb.Margin = new Padding(3);
            lb.Click += LblClick!;
            lb.MouseLeave += label1_MouseLeave!;
            lb.MouseHover += label1_MouseHover!;
            lb.Cursor = Cursors.Hand;
            x += 183;
            ++count;
            ++totalCount;

            if (count == 2)
            {

                y += 24;
                x = 0;
                count = 0;
            }

            FlwPanel.Controls.Add(lb);

        }
        private void LblClick(object sender, EventArgs e)
        {
            var lbl = (System.Windows.Forms.Label)sender;

            SelectedCategories.Remove(lbl.Name);
            //x = 0;
            //y = 0;
            //count = 0;
            //--totalCount;
            totalCount = 0;
            FlwPanel.Controls.Clear();
            SelectedCategories.ForEach(x => AddCategoryLabel(x));

            SearchByFilters();
        }

        private void label1_MouseHover(object sender, EventArgs e)
        {
            Label lb = (Label)sender;
            lb.ForeColor = Color.FromArgb(10, 102, 194);
        }

        private void label1_MouseLeave(object sender, EventArgs e)
        {
            Label lb = (Label)sender;
            lb.ForeColor = SystemColors.ButtonFace;

        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            if (CurrentLinkId == string.Empty) return;

            var data = LinkManager.Links.Where(x => x.Id == CurrentLinkId).FirstOrDefault();

            AddPageI.UpdateMode = true;
            AddPageI.EntityForUpdate = data!;
            AddPageI.ModeSelect();
            AddSelectedPage(AddPageI);
        }

        public static void OpenLinkOnBrowser(string url)
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

        private void BtnOpenLink_Click(object sender, EventArgs e)
        {
            if (CurrentLink == string.Empty) return;
            OpenLinkOnBrowser(CurrentLink);
        }


        enum Search
        {

        }
        public static void SearchByFilters(bool searchWithText = false)
        {


            var list = new List<Link>();
            if (SelectedCategories.Count == 0)
                list = LinkManager.Links;
            else
                list = LinkManager.GetLinksByCategories(SelectedCategories);




            if (!string.IsNullOrEmpty(Program.MainFrm.textBox1.Text))
            {
                if (!Program.MainFrm.CbHeaderOrDescription.Checked)
                {
                    list = list.Where(x => x.Header.Contains((Program.MainFrm.textBox1.Text))).ToList();
                }
                else
                {
                    list = list.Where(x => x.Description.Contains((Program.MainFrm.textBox1.Text))).ToList();
                }
            }


            Program.MainFrm.DGW.DataSource = list;
            Program.MainFrm.DGW.Update();
            Program.MainFrm.DGW.Refresh();

        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            SearchByFilters();
        }

        private void BtnCategories_Click(object sender, EventArgs e)
        {
            AddSelectedPage(CategoryPage);
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {


            MessageBox.Show(@"""All filtering methods operate in a unified manner. If you do not wish to use Category filtering, clear the selected categories, or if you do not wish to filter by title/description fields, clear the relevant field. You can click the reset button for this.

If both Category and title/description fields are filled simultaneously, these two filters are combined.

Example: To find a result containing the categories ""music"" and ""youtube"" and with the title field as ""favorite music,"" select the ""music"" and ""youtube"" categories, then set your search option in the search field to search by title. Then enter ""favorite music"" in the search field. You will be able to see the desired results.""", "Filtering", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            SearchByFilters();
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            var dr = MessageBox.Show("do you want to delete this record ?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (dr == DialogResult.Yes)
            {

                richTextBox1.Clear();
                LinkManager.Remove(CurrentLinkId);
                LoadDgw();
                CurrentLinkId = string.Empty;
            }
        }

        private void BtnSettings_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            var data =  Program.WebApp.Services.GetRequiredService<IApplicationLifetime>();

            data.StopApplication(); 
        }
    }
}
