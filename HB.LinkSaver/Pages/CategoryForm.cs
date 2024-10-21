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
    public partial class CategoryForm : Form
    {
        public string SelectedCategory = string.Empty;
        public CategoryForm()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            if (tbCategoryAdd.Text == string.Empty)

            {
                MessageBox.Show("category cannot be empty!");
                return;
            }

            if (CategoryManager.Add(tbCategoryAdd.Text))//? "succesfull" : "already exist";
            {
                lblResultAdd.Visible = true;
                await Task.Delay(350);
                lblResultAdd.Visible = false;
                listBox1.Items.Add(tbCategoryAdd.Text);
                tbCategoryAdd.Clear();
                lblUpdate.Text = string.Empty;
                Program.MainFrm.LoadCategories(); // OK
            }
            else
            {
                MessageBox.Show("already exist");
            }

        }
        private void CategoryForm_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;
            lblResultAdd.Visible = false;
            lblResultUpdate.Visible = false;
            lblDeleteResult.Visible = false;
            LinkManager.Control();

            CategoryManager.Categories.ForEach(c => listBox1.Items.Add(c));
        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex == -1) return;

            var item = listBox1.SelectedItem.ToString();
            SelectedCategory = item;
            lblUpdate.Text = "old value : " + item;
        }
        private async void UpdateBtn_Click(object sender, EventArgs e)
        {
            if (tbUpdate.Text == string.Empty)
            {
                MessageBox.Show("category cannot be empty!");
                return;

            }
            if (SelectedCategory == string.Empty)
            {
                MessageBox.Show("pls select a category");
                return;

            }
            var result = CategoryManager.Update(SelectedCategory, tbUpdate.Text);

            if (result)
            {

                lblUpdate.Text = string.Empty;
                SelectedCategory = string.Empty;

                lblResultUpdate.Visible = true;
                await Task.Delay(350);
                lblResultUpdate.Visible = false;
                listBox1.Items.Clear();
                CategoryManager.Categories.ForEach(x => listBox1.Items.Add(x));
                Program.MainFrm.LoadDgw();
                Program.MainFrm.LoadCategories();
              
            }
        }
        private async void button2_Click(object sender, EventArgs e)
        {
            if (SelectedCategory == string.Empty) return;
            var result = CategoryManager.Delete(SelectedCategory);

            if (!result)
                MessageBox.Show("you cant delete this category because there are record that has it ");
            else
            {
                lblDeleteResult.Visible = true;
                await Task.Delay(350);
                lblDeleteResult.Visible = false;
                listBox1.Items.Clear();
                CategoryManager.Categories.ForEach(x => listBox1.Items.Add(x));
                SelectedCategory = string.Empty;
                lblUpdate.Text = string.Empty;
                Program.MainFrm.LoadCategories();
            }
        }

        private void CategoryForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
    }
}
