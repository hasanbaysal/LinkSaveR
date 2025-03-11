using HB.LinkSaver.DataAcces;

namespace HB.LinkSaver.Pages
{
    public partial class CategoryForm : Form
    {
        public string SelectedCategory = string.Empty;
        public string SelectedCategoryGroupName = string.Empty;
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

            if (CategoryManager.AddCategoryIntoGroup(SelectedCategoryGroupName, tbCategoryAdd.Text))//? "succesfull" : "already exist";
            {
                lblResultAdd.Visible = true;
                await Task.Delay(350);
                lblResultAdd.Visible = false;
                listBox1.Items.Add(tbCategoryAdd.Text);
                tbCategoryAdd.Clear();
                lblUpdate.Text = string.Empty;
                Program.MainFrm.LoadCategories(); // OK  //TODO : HB remove comment
            }
            else
            {
                MessageBox.Show("already exist");
            }

        }


        // TODO : HB Category Empty Case !!
        private void CategoryForm_Load(object sender, EventArgs e)
        {
            LinkManager.Control();
            this.KeyPreview = true;
            lblResultAdd.Visible = false;
            lblResultUpdate.Visible = false;
            lblDeleteResult.Visible = false;
            lblCategoryGroupNameStatus.Visible = false;


            var groups = CategoryManager.GetAllCategoryGroupNames();

            groups.ForEach(x => cbCategoryGroupNames.Items.Add(x));


            var categories = CategoryManager.GetAllCateriesByGroupName(groups.FirstOrDefault()!);

            categories.ForEach(x => listBox1.Items.Add(x));

            SelectedCategoryGroupName = groups.First();
            cbCategoryGroupNames.SelectedIndex = 0;
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

        private async void btnAddCategoryGroup_Click(object sender, EventArgs e)
        {
            // TODO : maindeki category group cbbox'ı update et
            if (tbCategoryGroup.Text == string.Empty)
            {
                MessageBox.Show("category group name cannot be empty!");
                return;
            }

            if (CategoryManager.AddGroup(tbCategoryGroup.Text))
            {
                lblResultAdd.Visible = true;
                await Task.Delay(350);
                lblResultAdd.Visible = false;
                listBox1.Items.Add(tbCategoryAdd.Text);
                tbCategoryAdd.Clear();
                lblCategoryGroupNameStatus.Text = string.Empty;

                cbCategoryGroupNames.Items.Clear();
                CategoryManager.GetAllCategoryGroupNames().ForEach(x => cbCategoryGroupNames.Items.Add(x));

                listBox1.Items.Clear();
                CategoryManager.GetAllCateriesByGroupName(tbCategoryGroup.Text).ForEach(x => listBox1.Items.Add(x));


                Program.MainFrm.LoadCategoriesGroup();
            }
            else
            {
                MessageBox.Show("already exist");
            }
        }

        private void cbCategoryGroupNames_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            var cb = sender as ComboBox;
            SelectedCategoryGroupName = cb.Items[cb.SelectedIndex].ToString()!;
            listBox1.Items.Clear();
            CategoryManager.GetAllCateriesByGroupName(SelectedCategoryGroupName!).ForEach(x => listBox1.Items.Add(x));

            ResetDataAndComponents();
        }

        private void ResetDataAndComponents()
        {
            tbCategoryAdd.Text = string.Empty;
            tbCategoryGroup.Text = string.Empty;
            tbUpdate.Text = string.Empty;
            lblUpdate.Text = string.Empty;
            SelectedCategory = string.Empty;
        }

    }
}
