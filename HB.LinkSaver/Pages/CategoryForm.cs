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

        private void button1_Click(object sender, EventArgs e)
        {
            if (tbCategoryAdd.Text == string.Empty)

            {
                MessageBox.Show("category cannot be empty!");
                return;
            }

            if (CategoryManager.Add(tbCategoryAdd.Text))//? "succesfull" : "already exist";
            {

                listBox1.Items.Add(tbCategoryAdd.Text);
                tbCategoryAdd.Clear();
                MessageBox.Show("succesfull");
                lblUpdate.Text = string.Empty;
            }
            else
            {
                MessageBox.Show("already exist");
            }

        }
        private void CategoryForm_Load(object sender, EventArgs e)
        {
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
        private void UpdateBtn_Click(object sender, EventArgs e)
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
                MessageBox.Show("success!");
                listBox1.Items.Clear();
                CategoryManager.Categories.ForEach(x => listBox1.Items.Add(x));
                Program.MainFrm.LoadDgw();
                Program.MainFrm.LoadCategories();
                this.Close();
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (SelectedCategory == string.Empty) return;
            var result = CategoryManager.Delete(SelectedCategory);

            if (!result)
                MessageBox.Show("you cant delete this category because there are record that has it ");
            else
            {
                listBox1.Items.Clear();
                CategoryManager.Categories.ForEach(x => listBox1.Items.Add(x));
                SelectedCategory = string.Empty;
                lblUpdate.Text = string.Empty;
            }
        }
    }
}
