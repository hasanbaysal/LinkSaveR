using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;

namespace HB.LinkSaver.Pages
{
    public partial class UpdateForm2 : Form
    {
        List<string> SelectedCategories = new List<string>();
        public Link OrginalLink { get; set; } = null!;
        public UpdateForm2()
        {
            InitializeComponent();
        }

        private void Update2_Load(object sender, EventArgs e)
        {
            lblResult.Visible = false;
            this.KeyPreview = true;
            LinkManager.Control();
          //  CategoryManager.GetAll().ForEach(c => { categoryControlLb1.AddItem(c); });

            var data = LinkManager.GetById(OrginalLink.Id);

            SelectedCategories.AddRange(data.Categories);
            OrginalLink.Categories.ForEach(x => AddCategoryLabel(x));
            tbDescription.Text = data.Description;
            tbHeader.Text = data.Header;
            tbLink.Text = data.Content;
        }
        public void RemoveCategory(string data)
        {
            SelectedCategories.Remove(data);
            FlwPanel.Controls.Clear();
            SelectedCategories.ForEach(x => AddCategoryLabel(x));
        }
        private void Lbl_Click(object sender, EventArgs e)
        {
            var lbl = (Label)sender;
            RemoveCategory(lbl.Text);
        }
        private bool OperationControl()
        {



            var status = true;
            var message = string.Empty;
            if ((SelectedCategories.Count == 0))
            {
                message += "You must select at least one category" + Environment.NewLine;
                status = false;

            }

            if (tbHeader.Text == string.Empty)
            {
                message += "Header cannot be empty!" + Environment.NewLine;
                status = false;
            }


            if (tbLink.Text == string.Empty)
            {
                message += "Link cannot be empty!" + Environment.NewLine;
                status = false;

            }

            if (!status)
            {
                MessageBox.Show(message);

            }
            return status;
        }
        private void AddForm_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
        // add into flowlayout
        public void AddCategoryLabel(string str)
        {
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
            lb.Cursor = System.Windows.Forms.Cursors.Hand;
            FlwPanel.Controls.Add(lb);
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
        private void LblClick(object sender, EventArgs e)
        {
            var lbl = (System.Windows.Forms.Label)sender;


            if (lbl.Parent != null)
            {
                lbl.Parent.Controls.Remove(lbl);
            }
            SelectedCategories.Remove(lbl.Name);
            lbl.Dispose();
            FlwPanel.Controls.Clear();
            SelectedCategories.ForEach(x => AddCategoryLabel(x));
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


            //SearchByFilters();
        }

        private async void btnUpdate_Click(object sender, EventArgs e)
        {
            var control =  OperationControl();

            if (control)
            {
                LinkManager.Update(new()
                {
                    Id = OrginalLink.Id,
                    Categories = SelectedCategories,
                    Content = tbLink.Text,
                    Description = tbDescription.Text,
                    Header = tbHeader.Text,
                });

                lblResult.Visible = true;
                await Task.Delay(350);
                lblResult.Visible = false;  
                Program.MainFrm.LoadDgw();
            }



        }

        private void textBox1_KeyUp(object sender, System.Windows.Forms.KeyEventArgs e)
        {         
            var data = ((TextBox)sender).Text;
            categoryControlLb1.FilterCategory(data);
        }

        private void resetBtn_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            categoryControlLb1.FilterCategory(string.Empty);
        }
    }
}
