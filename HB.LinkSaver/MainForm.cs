using FontAwesome.Sharp;
using HB.LinkSaver.Pages;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using System.Diagnostics;
using System.Runtime.InteropServices;
using HB.LinkSaver.Helpers;


namespace HB.LinkSaver
{
    public partial class MainForm : Form
    {

        public static List<string> SelectedCategories = new List<string>();
        public string CurrentLinkId = string.Empty;
        public string CurrentLink = string.Empty;
        public bool SearchForText = false;

        private Size _tbDescriptionFirstSize;
        private Size _mainFirstSize;
        public Size SecondSize;
        public Point SecondLocation;
        public char TbDescriptionSeperator;
        int maxDashes = 0;
        
        public MainForm()
        {
            InitializeComponent();
            InitializeToolTip();
            CheckForIllegalCrossThreadCalls = false;
            _tbDescriptionFirstSize = tbDescription.Size;

            TbDescriptionSeperator = '_';
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

        ToolTip MyToolTip = new ToolTip();
        private void InitializeToolTip()
        {
            MyToolTip.AutoPopDelay = 5000;
            MyToolTip.InitialDelay = 100;
            MyToolTip.ReshowDelay = 100;
            MyToolTip.ShowAlways = true;


            MyToolTip.SetToolTip(this.BtnOpenLink, "Open With Browser");
            MyToolTip.SetToolTip(this.BtnDelete, $"Select a record before clicking to delete {Environment.NewLine} Please make a selection first (DEL)");
            MyToolTip.SetToolTip(this.BtnAdd, "Add a Link (F1)");
            MyToolTip.SetToolTip(this.BtnUpdate, $"Update the Link  {Environment.NewLine} (F2 after select a recod)");
            MyToolTip.SetToolTip(this.BtnSettings, "Settings (F4)");
            MyToolTip.SetToolTip(this.BtnCategories, "Category Add or Delete (F3)");
            MyToolTip.SetToolTip(this.resetBtn, "Clear All Filter  Refresh (F5)");
            MyToolTip.SetToolTip(this.btnStatusInfo, "Server Status For Google Extention. If you gonna use extention turn on server");


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
                Description = x.Description.GetCustomStringByLength(150, true),
                Categories =
                x.Categories.Count == 1 ?
                "* " + x.Categories.First().GetCustomStringByLength(23, true) :
                string.Join("", x.Categories.Select(s =>
                $"* {s.GetCustomStringByLength(23, true)}{Environment.NewLine}"))
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
        private void DGW_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {


            if (e.ColumnIndex == -1) return;
            if (e.RowIndex == -1) return;
            tbDescription.Clear();
            var id = DGW.Rows[e.RowIndex].Cells[0].Value.ToString()!;
            var data = LinkManager.GetById(id);
            LinkDetailForm detailForm = new LinkDetailForm();
            detailForm.Link = data;
            detailForm.ShowDialog();


        }
        private void DGW_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.ColumnIndex == -1) return;
            if (e.RowIndex == -1) return;
            tbDescription.Clear();
            var categories = "";
            CurrentLinkId = DGW.Rows[e.RowIndex].Cells[0].Value.ToString()!;
            CurrentLink = DGW.Rows[e.RowIndex].Cells[2].Value.ToString()!;
            //var description = DGW.Rows[e.RowIndex].Cells[3].Value.ToString()!;

            var description = LinkManager.GetById(CurrentLinkId).Description;

            LinkManager.GetById(CurrentLinkId).Categories.ForEach(x =>
            {
                categories += $" {x} |";
            });

            tbDescription.Text +=
                GetDash("DESCRÝPTÝON")
                + Environment.NewLine
                + Environment.NewLine
                + description
                + Environment.NewLine
                + GetDash("CATEGORÝES")
                + Environment.NewLine
                + Environment.NewLine
                + categories
                + Environment.NewLine;

        }

        private string GetDash(string header = "")
        {
            if (header != string.Empty)
            {
                var result = string.Empty;
                var dashCount = (maxDashes - header.Length) / 2;
                var halfLine = "";

                Enumerable.Range(1, dashCount - 2).ToList().ForEach(x => halfLine += TbDescriptionSeperator.ToString());

                result += halfLine;
                result += header.ToUpper();
                result += halfLine;

                return result;
            }

            var temp = string.Empty;

            Enumerable.Range(1, maxDashes).ToList().ForEach(x => temp += TbDescriptionSeperator.ToString());
            return temp;
        }


        private int CalculateDashCount(RichTextBox richTextBox, Font font, char charachter)
        {
            string dash = charachter.ToString();
            int maxDashes = 0;
            SizeF textSize;

            using (Graphics g = richTextBox.CreateGraphics())
            {

                while (true)
                {
                    textSize = g.MeasureString(new string(dash[0], maxDashes + 1), font);

                    if (textSize.Width <= richTextBox.ClientSize.Width)
                    {
                        maxDashes++;
                    }
                    else
                    {
                        break;
                    }
                }
            }

            return maxDashes;
        }


        #endregion

        #region FormLoad Actions
        private void Form1_Load(object sender, EventArgs e)
        {
            _mainFirstSize = this.Size;
            InfoCategoryLbl.Anchor = AnchorStyles.Right | AnchorStyles.Bottom;

            btnStatusInfo.IconColor = Program.GetUseServerSettingsStatus() ? Color.Green : Color.Red;
            btnStatusInfo.ForeColor = Program.GetUseServerSettingsStatus() ? Color.Green : Color.Red;


            DGW.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(45, 45, 45);
            DGW.ColumnHeadersDefaultCellStyle.SelectionForeColor = Color.White;


            this.KeyPreview = true;
            DGW.CellPainting += DGW_CellPainting!;
            tbDescription.SelectionIndent = 10;
            tbDescription.SelectionRightIndent = 10;

            LinkManager.Control();
            LoadDgw();
            LoadCategories();
            BackGroundLabel();
            maxDashes = CalculateDashCount(this.tbDescription, tbDescription.Font, TbDescriptionSeperator);
            if (DGW.Rows.Count > 0)
            {
                DGW.ClearSelection();
            }
        }

        public void LoadCategories()
        {

            Program.MainFrm.CategoryControlPanel.ClearItems();

            CategoryManager.Categories.ForEach(x =>
            {
                Program.MainFrm.CategoryControlPanel.AddItem(x);
            });
        }

        Label InfoCategoryLbl = new Label();
        public void BackGroundLabel()
        {
            InfoCategoryLbl.Text = "\u2191 Select a category for search (max : 8) \u2191";
            InfoCategoryLbl.Font = new Font("Segoe UI", 9, FontStyle.Italic);
            InfoCategoryLbl.ForeColor = Color.FromArgb(150, 150, 150);



            InfoCategoryLbl.AutoSize = true;
            InfoCategoryLbl.BackColor = Color.FromArgb(30, 30, 30);
            int x = (FlwPanel.Location.X + (FlwPanel.Width - InfoCategoryLbl.Width) / 2) - 55;
            int y = FlwPanel.Location.Y + (FlwPanel.Height - InfoCategoryLbl.Height) / 2;
            InfoCategoryLbl.TextAlign = ContentAlignment.MiddleCenter;
            InfoCategoryLbl.Location = new Point(x - 40, y);
            this.Controls.Add(InfoCategoryLbl);
            InfoCategoryLbl.BringToFront();

        }
        #endregion

        #region CategorySelect-Action



        public void AddCategoryLabel(string str)
        {

            if (SelectedCategories.Count > 0)
            {
                InfoCategoryLbl.SendToBack();
            }

            Label lb = new Label();
            lb.Name = str;
            lb.Text = str;
            lb.TextAlign = ContentAlignment.MiddleCenter;
            lb.AutoSize = false;
            lb.ForeColor = Color.White;
            lb.Font = new Font("Segoe UI", 9, FontStyle.Regular);
            lb.Size = new Size(202, 35);
            lb.FlatStyle = FlatStyle.Flat;
            lb.BackColor = Color.FromArgb(2, 117, 216);
            lb.Margin = new Padding(3);
            lb.Click += LblClick!;
            lb.MouseLeave += label1_MouseLeave!;
            lb.MouseHover += label1_MouseHover!;
            lb.Cursor = Cursors.Hand;
            MyToolTip.SetToolTip(lb, lb.Text);
            FlwPanel.Controls.Add(lb);

        }
        private void LblClick(object sender, EventArgs e)
        {
            var lbl = (System.Windows.Forms.Label)sender;

            MyToolTip.SetToolTip(lbl, null);
            if (lbl.Parent != null)
            {
                lbl.Parent.Controls.Remove(lbl);
            }

            SelectedCategories.Remove(lbl.Name);

            if (SelectedCategories.Count == 0)
            {
                InfoCategoryLbl.BringToFront();
            }
            lbl.Dispose();
            FlwPanel.Controls.Clear();
            SelectedCategories.ForEach(x => AddCategoryLabel(x));

            SearchByFilters();
        }

        private void categoryControlLb1_BtnHandler(object sender, EventArgs e)
        {
            if (SelectedCategories.Count == 8) return;
            Button btn = (sender as Button)!;


            var item = btn.Text;


            if (!SelectedCategories.Contains(item))
            {
                SelectedCategories.Add(item);
                AddCategoryLabel(item);
            }


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

            UpdateForm2 updateForm = new UpdateForm2();
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

        private void textBox2_KeyUp(object sender, KeyEventArgs e)
        {
            var data = ((TextBox)sender).Text;
            CategoryControlPanel.FilterCategory(data);
        }
        public static void SearchByFilters(bool searchWithText = false)
        {


            var list = new List<Link>();
            if (SelectedCategories.Count == 0)
                list = LinkManager.Links;
            else
                list = LinkManager.GetLinksByCategories(SelectedCategories);




            if (!string.IsNullOrEmpty(Program.MainFrm.tbLinkSearch.Text))
            {
                if (!Program.MainFrm.CbHeaderOrDescription.Checked)
                {
                    list = list.Where(x => x.Header.Contains((Program.MainFrm.tbLinkSearch.Text), StringComparison.OrdinalIgnoreCase)).ToList();
                }
                else
                {
                    list = list.Where(x => x.Description.Contains((Program.MainFrm.tbLinkSearch.Text), StringComparison.OrdinalIgnoreCase)).ToList();
                }
            }




            var data = list.Select(x => new
            {
                Id = x.Id,
                Header = x.Header,
                Context = x.Content,
                Description = x.Description.GetCustomStringByLength(150, true),
                Categories =
                x.Categories.Count == 1 ?
                "* " + x.Categories.First().GetCustomStringByLength(23, true) :
                string.Join("", x.Categories.Select(s =>
                $"* {s.GetCustomStringByLength(23, true)}{Environment.NewLine}"))
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
            if (CbHeaderOrDescription.Checked)
                lblSearchOption.Text = "Description";
            else
                lblSearchOption.Text = "Header";


            SearchByFilters();
        }

        private void resetBtn_Click(object sender, EventArgs e)
        {


            InfoCategoryLbl.BringToFront();
            tbLinkSearch.Clear();
            SelectedCategories.Clear();
            tbDescription.Clear();
            FlwPanel.Controls.Clear();
            CurrentLink = string.Empty;
            CurrentLinkId = string.Empty;
            SearchByFilters();
            if (DGW.Rows.Count > 0)
            {
                DGW.ClearSelection();
            }
        }

        #endregion

        #region Delete

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (CurrentLink == string.Empty) { return; }
            var dr = MessageBox.Show("do you want to delete this record ?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dr == DialogResult.Yes)
            {

                //richTextBox1.Clear();
                LinkManager.Remove(CurrentLinkId);
                LoadDgw();
                CurrentLinkId = string.Empty;
                CurrentLink = string.Empty;
                tbDescription.Text = string.Empty;
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



        bool isFullScreen = false;
        private void togleSizeBtn_Click(object sender, EventArgs e)
        {
            isFullScreen = !isFullScreen;

            if (isFullScreen)
            {

                this.Bounds = Screen.FromHandle(this.Handle).Bounds;
                this.WindowState = FormWindowState.Normal;
            }
            else
            {
                this.Size = _mainFirstSize;
                this.WindowState = FormWindowState.Normal;

                this.StartPosition = FormStartPosition.CenterScreen;

                Screen currentScreen = Screen.FromControl(this);
                this.Location = new Point(
                    (currentScreen.WorkingArea.Width - this.Width) / 2 + currentScreen.WorkingArea.Left,
                    (currentScreen.WorkingArea.Height - this.Height) / 2 + currentScreen.WorkingArea.Top
                );
            }

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
            //MyToolTip.SetToolTip(lb, lb.Text);



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



                e.Paint(e.CellBounds, DataGridViewPaintParts.All);


                using (Pen whitePen = new Pen(Color.White, 2))
                {

                    e.Graphics.DrawLine(whitePen, e.CellBounds.Right - 1, e.CellBounds.Top, e.CellBounds.Right - 1, e.CellBounds.Bottom);
                }


                e.Handled = true;

            }
        }
        private void MainForm_Paint(object sender, PaintEventArgs e)
        {
            //using (Pen whitePen = new Pen(Color.White, 2))
            //{

            //    e.Graphics.DrawRectangle(whitePen, DGW.Left - 1, DGW.Top - 1, DGW.Width + 1, DGW.Height + 1);
            //    e.Graphics.DrawRectangle(whitePen, CategoryControlPanel.Left - 1, CategoryControlPanel.Top - 1, CategoryControlPanel.Width + 1, CategoryControlPanel.Height + 1);
            //    e.Graphics.DrawRectangle(whitePen, FlwPanel.Left - 1, FlwPanel.Top - 1, FlwPanel.Width + 1, FlwPanel.Height + 1);
            //    //e.Graphics.DrawRectangle(whitePen, tbDescription.Left - 1, tbDescription.Top - 1, tbDescription.Width + 1, tbDescription.Height + 1);
            //}
        }


        int saðBoþluk = 10; // Sað taraftan olan boþluk
        int altBoþluk = 10; // Alt taraftan olan boþluk
        private void tbDescription_MouseHover(object sender, EventArgs e)
        {


            tbDescription.Location = new Point(
                this.ClientSize.Width - tbDescription.Width - saðBoþluk,
                this.ClientSize.Height - tbDescription.Height - altBoþluk
            );


            tbDescription.Size = new Size(_tbDescriptionFirstSize.Width, _tbDescriptionFirstSize.Height + 200);
            //tbDescription.Location = new Point(FirstLocation.X, FirstLocation.Y - 200);
            InfoCategoryLbl.SendToBack();
        }


        private void tbDescription_MouseLeave(object sender, EventArgs e)
        {
            tbDescription.Size = _tbDescriptionFirstSize;
            //tbDescription.Location = FirstLocation;

            tbDescription.Location = new Point(
               this.ClientSize.Width - tbDescription.Width - saðBoþluk,
               this.ClientSize.Height - tbDescription.Height - altBoþluk
           );

            if (SelectedCategories.Count == 0)
            {
                InfoCategoryLbl.BringToFront();
            }
            else
            {
                InfoCategoryLbl.SendToBack();
            }
        }
        #endregion

        #region KeyDown

        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                BtnAdd.PerformClick();
            }
            if (e.KeyCode == Keys.F2)
            {

                BtnUpdate.PerformClick();
            }
            if (e.KeyCode == Keys.F3)
            {
                BtnCategories.PerformClick();
                e.Handled = true;
            }
            if (e.KeyCode == Keys.F4)
            {
                BtnSettings.PerformClick();
            }
            if (e.KeyCode == Keys.F5)
            {
                resetBtn.PerformClick();
            }

            if (e.KeyCode == Keys.Delete)
            {
                BtnDelete.PerformClick();
            }


        }

        #endregion


    }
}
