using FontAwesome.Sharp;
using HB.LinkSaver.Components;
using HB.LinkSaver.Pages;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;


namespace HB.LinkSaver
{
    public partial class MainForm : Form
    {

   
        public static List<string> SelectedCategories = new List<string>();
        public string CurrentLinkId = string.Empty;
        public string CurrentLink = string.Empty;
        public bool SearchForText = false;

        public MainForm()
        {
            InitializeComponent();
            InitializeToolTip();
            CheckForIllegalCrossThreadCalls = false;
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

        #region tooltip

        private void InitializeToolTip()
        {
            // ToolTip bileþeni oluþtur
            var tt = new ToolTip();

            // ToolTip'in özelliklerini ayarla (isteðe baðlý)

            tt.AutoPopDelay = 5000;
            tt.InitialDelay = 500;
            tt.ReshowDelay = 100;
            tt.ShowAlways = true;


            tt.SetToolTip(this.BtnOpenLink, "Open With Browser");
            tt.SetToolTip(this.BtnDelete, "Delete Selected Link");
            tt.SetToolTip(this.BtnAdd, "Add a Link");
            tt.SetToolTip(this.BtnUpdate, "Update the Link");
            tt.SetToolTip(this.BtnSettings, "Settings");
            tt.SetToolTip(this.BtnCategories, "Category Add or Delete");

        }


        #endregion

        #region Datagriv View Actions
        public void LoadDgw()
        {





            DGW.DataSource = null;
            DGW.Update();
            DGW.Refresh();

            var data = LinkManager.GetAll().Select(x => new
            {
                Id = x.Id,
                Header = x.Header,
                Context = x.Content,
                Description = x.Description,
                Categories = string.Join("-", x.Categories.Select(s => $" | {s} | "))
            }).ToList();

            DGW.DataSource = data;

            DGW.Columns[0].Visible = false;
            DGW.Columns[2].Visible = false;


            foreach (DataGridViewColumn column in DGW.Columns)
            {
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }

            DGW.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            DGW.DefaultCellStyle.WrapMode = DataGridViewTriState.True;

            DGW.Update();
            DGW.Refresh();
        }
        private void DGW_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.ColumnIndex == -1) return;
            if (e.RowIndex == -1) return;


            CurrentLinkId = DGW.Rows[e.RowIndex].Cells[0].Value.ToString()!;
            CurrentLink = DGW.Rows[e.RowIndex].Cells[2].Value.ToString()!;
            richTextBox1.Text = DGW.Rows[e.RowIndex].Cells[3].Value.ToString()!;

        }

        #endregion

        #region FormLoad Actions
        private void Form1_Load(object sender, EventArgs e)
        {
            DGW.CellPainting += DGW_CellPainting;
            richTextBox1.SelectionIndent = 10;
            richTextBox1.SelectionRightIndent = 10;

            LinkManager.Control();
            LoadDgw();
            LoadCategories();
        }

        public  void LoadCategories()
        {
            // TODO : Burayý Düzenle

            Program.MainFrm.categoryControlLb1.ClearItems();

            CategoryManager.Categories.ForEach(x =>
            {
                Program.MainFrm.categoryControlLb1.AddItem(x);
            });
        } 
        #endregion

        #region CategorySelect-Action
        private void LbSelectedCategories_SelectedIndexChanged(object sender, EventArgs e)
        {

            Button btn = sender as Button;

            var item = btn.Text;
            MessageBox.Show(item);
            if (!SelectedCategories.Contains(item)) { AddCategoryLabel(item); SelectedCategories.Add(item); }

            SearchByFilters();

        }


        public void AddCategoryLabel(string str)
        {

            Label lb = new Label();
            lb.Name = str;
            lb.Text = str;
            lb.TextAlign = ContentAlignment.MiddleCenter;
            lb.AutoSize = false;
            lb.ForeColor = Color.White;
            lb.Font = new Font("Segoe UI", 9, FontStyle.Regular);

            lb.Size = new Size(230, 30);
            lb.FlatStyle = FlatStyle.Flat;
            lb.BackColor = Color.FromArgb(2, 117, 216);
            lb.Margin = new Padding(3);
            lb.Click += LblClick!;
            lb.MouseLeave += label1_MouseLeave!;
            lb.MouseHover += label1_MouseHover!;
            lb.Cursor = Cursors.Hand;




            FlwPanel.Controls.Add(lb);

        }
        private void LblClick(object sender, EventArgs e)
        {
            var lbl = (System.Windows.Forms.Label)sender;


            SelectedCategories.Remove(lbl.Name);
          

            FlwPanel.Controls.Clear();
            SelectedCategories.ForEach(x => AddCategoryLabel(x));

            SearchByFilters();
        }

        private void categoryControlLb1_BtnHandler(object sender, EventArgs e)
        {
            if (SelectedCategories.Count == 8) return;
            Button btn = sender as Button;


            var item = btn.Text;

            if (!SelectedCategories.Contains(item)) { AddCategoryLabel(item); SelectedCategories.Add(item); }

            
            SearchByFilters();

        }


        #endregion

        #region pages

        private void BtnAdd_Click(object sender, EventArgs e)
        {


            AddForm addForm = new AddForm();
            addForm.ShowDialog();

        }
        private void BtnUpdate_Click(object sender, EventArgs e)
        {

            if (CurrentLinkId == string.Empty) return;
            var data = LinkManager.Links.Where(x => x.Id == CurrentLinkId).FirstOrDefault();
            UpdateForm updateForm = new UpdateForm();
            updateForm.OrginalLink = data!;
            updateForm.ShowDialog();

        }
        private void BtnCategories_Click(object sender, EventArgs e)
        {
            CategoryForm categoryForm = new CategoryForm();
            categoryForm.ShowDialog();
        }


        private void BtnSettings_Click(object sender, EventArgs e)
        {
            SettingsForm settingsForm = new SettingsForm(); 
            settingsForm.ShowDialog();
        }

        #endregion

        #region Browser Code

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

        #endregion

        #region Search Code

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




            var data = list.Select(x => new
            {
                Id = x.Id,
                Header = x.Header,
                Context = x.Content,
                Description = x.Description,
                Categories = string.Join("  /  ", x.Categories)
            }).ToList();

            Program.MainFrm.DGW.DataSource = data;

            Program.MainFrm.DGW.Update();
            Program.MainFrm.DGW.Refresh();

        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            SearchByFilters();
        }
        private void CbHeaderOrDescription_CheckedChanged(object sender, EventArgs e)
        {
            SearchByFilters();
        }

        private void resetBtn_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            SelectedCategories.Clear();
            FlwPanel.Controls.Clear();

            SearchByFilters();
        }

        #endregion

        #region Delete

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            var dr = MessageBox.Show("do you want to delete this record ?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (dr == DialogResult.Yes)
            {

                //richTextBox1.Clear();
                LinkManager.Remove(CurrentLinkId);
                LoadDgw();
                CurrentLinkId = string.Empty;
            }
        }

        #endregion

        #region mainform-actions
        public void BringToTop()
        {

            if (this.InvokeRequired)
            {
                this.Invoke(new Action(BringToTop));
            }
            else
            {
                if (this.WindowState == FormWindowState.Minimized)
                {
                    this.WindowState = FormWindowState.Normal;
                }

                bool top = TopMost;

                TopMost = true;

                TopMost = top;
            }
        }
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Program.ServerStatus)
            {
                var data = Program.WebApp.Services.GetRequiredService<IApplicationLifetime>();
                data.StopApplication();
            }

        }


        private void BtnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        #endregion

        #region display event
        private void BtnDelete_MouseHover(object sender, EventArgs e)
        {
            IconButton btn = sender as IconButton;

            btn.IconColor = Color.FromArgb(2, 117, 216);

        }

        private void BtnDelete_MouseLeave(object sender, EventArgs e)
        {
            IconButton btn = sender as IconButton;

            btn.IconColor = Color.White;

        }


        private void label1_MouseHover(object sender, EventArgs e)
        {
            Label lb = (Label)sender;
            lb.ForeColor = Color.GreenYellow;
        }

        private void label1_MouseLeave(object sender, EventArgs e)
        {
            Label lb = (Label)sender;
            lb.ForeColor = SystemColors.ButtonFace;

        }
        private void DGW_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {


                // Hücreyi çiz
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                // Sadece sað kenar çizgisini beyaz yap
                using (Pen whitePen = new Pen(Color.White, 2))
                {
                    // Sað kenar çizgisi
                    e.Graphics.DrawLine(whitePen, e.CellBounds.Right - 1, e.CellBounds.Top, e.CellBounds.Right - 1, e.CellBounds.Bottom);
                }

                // Çizim iþlemini tamamladýðýný bildir
                e.Handled = true;

            }
        }
        private void MainForm_Paint(object sender, PaintEventArgs e)
        {
            using (Pen whitePen = new Pen(Color.White, 2))
            {
                // DataGridView'in dýþ sýnýrlarýný çiz
                e.Graphics.DrawRectangle(whitePen, DGW.Left - 1, DGW.Top - 1, DGW.Width + 1, DGW.Height + 1);
                e.Graphics.DrawRectangle(whitePen, categoryControlLb1.Left - 1, categoryControlLb1.Top - 1, categoryControlLb1.Width + 1, categoryControlLb1.Height + 1);
                e.Graphics.DrawRectangle(whitePen, FlwPanel.Left - 1, FlwPanel.Top - 1, FlwPanel.Width + 1, FlwPanel.Height + 1);
            }
        }

        #endregion

    }
}
