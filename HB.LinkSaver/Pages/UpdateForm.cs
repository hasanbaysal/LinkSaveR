using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HB.LinkSaver.Pages
{
    /// <summary>
    /// Bu sınıftan instance alırken originallink'i doldur!
    /// </summary>
    public partial class UpdateForm : Form
    {
        public UpdateForm()
        {
            InitializeComponent();
        }
        public Link OrginalLink { get; set; }
        public List<string> SelectedCategories = new List<string>();
        private void UpdateForm_Load(object sender, EventArgs e)
        {
            LinkManager.Control();
            CategoryManager.GetAll().ForEach(c => { lbCategories.Items.Add(c); });
            OrginalLink.Categories.ForEach(x => AddCategory(x));
            SelectedCategories.AddRange(OrginalLink.Categories);
            tbDescription.Text = OrginalLink.Description;
            tbHeader.Text = OrginalLink.Header;
            tbLink.Text = OrginalLink.Content;
        }
        public void AddCategory(string data)
        {
            var lb = new Label();
            lb.Margin = new Padding(3, 3, 3, 3);
            lb.Width = 220;
            lb.Name = data;
            lb.Text = data;
            lb.BackColor = Color.White;
            lb.ForeColor = Color.Black;
            lb.Click += Lbl_Click;
            flowLayoutPanel1.Controls.Add(lb);
        }
        public void RemoveCategory(string data)
        {
            SelectedCategories.Remove(data);
            flowLayoutPanel1.Controls.Clear();
            SelectedCategories.ForEach(x => AddCategory(x));
        }
        private void Lbl_Click(object sender, EventArgs e)
        {
            var lbl = (Label)sender;
            RemoveCategory(lbl.Text);
        }
        public void PreLoadSelectedCategories()
        {
            SelectedCategories.ForEach(x => AddCategory(x));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var status = OperationControl();

            if (!status)
                return;

            var result = LinkManager.Update(new Link()
            {
                Categories = SelectedCategories,
                Content = tbLink.Text,
                Description = tbDescription.Text,
                Header = tbHeader.Text,
            });
            if (result)
            {
                Program.MainFrm.LoadDgw();
                MessageBox.Show("success");
                this.Close();
            }


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

        private void lbCategories_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBox lb = (sender as ListBox)!;
            if (lb.SelectedIndex == -1) { return; }
            if (SelectedCategories.Count == 8) { MessageBox.Show("you can add a maximum of eight categories"); return; }
            if (SelectedCategories.Contains(lb.SelectedItem!.ToString()!))
            {
                MessageBox.Show("The Category alerdy selected");
            }
            else
            {
                SelectedCategories.Add(lb.SelectedItem!.ToString()!);
                AddCategory(lb.SelectedItem!.ToString()!);
            }
        }
    }
}
