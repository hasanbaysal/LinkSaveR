using HB.LinkSaver.DataAcces;
using HB.LinkSaver.Helpers;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HB.LinkSaver
{
    partial class MainForm
    {
        #region Search
        public void SearchByFilters()
        {
            var list = new List<Link>();
            if (SelectedCategories.Data.Count == 0)
                list = LinkManager.GetAll().Where(x => x.Categories.Intersect(CategoryManager.GetAllCateriesByGroupName(CurrentCategoryGroup)).Any()).ToList();
            else
                list = LinkManager.GetLinksByCategories(SelectedCategories.Data);


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

            var data = list.Skip((CurrentPageNumber - 1) * CurrentPageSize).Take(CurrentPageSize).Select(x => new
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


            if (CurrentPageNumber != 1)
            {
                if (data.Count == 0)
                {
                    --CurrentPageNumber;
                    return;
                }
            }

            foreach (DataGridViewColumn column in DGW.Columns)
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;



            DGW.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            DGW.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            Program.MainFrm.DGW.DataSource = data;

            DGW.Columns[0].Visible = false;
            DGW.Columns[2].Visible = false;

            Program.MainFrm.DGW.Update();
            Program.MainFrm.DGW.Refresh();

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
        #region Dash 

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
        #region load_categories


        public void LoadCategories()
        {
            Program.MainFrm.CategoryControlPanel.ClearItems();
            CategoryManager.GetAllCateriesByGroupName(CurrentCategoryGroup).ForEach(x =>
            {
                Program.MainFrm.CategoryControlPanel.AddItem(x);
            });

        }
        public void LoadCategoriesGroup()
        {
            cbCategoryGroup.Items.Clear();

            var data = CategoryManager.GetAllCategoryGroupNames();
            data.Sort();

            cbCategoryGroup.Items.AddRange(data.ToArray());
            cbCategoryGroup.Items.Insert(0, Program.AllCategoryGroup);

        }

        #endregion
        #region category_info_lbl


        Label InfoCategoryLbl = new Label();
        public void InfoCategoryLabelLoad()
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
        #endregion
    }
}
