using HB.LinkSaver.DataAcces;
using HB.LinkSaver.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HB.LinkSaver
{
    partial class MainForm
    {
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
    }
}
