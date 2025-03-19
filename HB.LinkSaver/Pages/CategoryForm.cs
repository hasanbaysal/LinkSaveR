using HB.LinkSaver.DataAcces;
using System.Threading.Tasks;

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
            lblCateGroupNameUpdateStatus.Visible = false;
            lblGroupDeleteInfo.Visible = false;

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
            lblUpdate.Text = "current value : " + item;
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
                tbUpdate.Clear();
                CategoryManager.GetAllCateriesByGroupName(SelectedCategoryGroupName).ForEach(x => listBox1.Items.Add(x));
                Program.MainFrm.SearchByFilters();
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
                CategoryManager.GetAllCateriesByGroupName(SelectedCategoryGroupName).ForEach(x => listBox1.Items.Add(x));
                SelectedCategory = string.Empty;
                lblUpdate.Text = string.Empty;
                Program.MainFrm.LoadCategories();

                Program.MainFrm.resetBtn.PerformClick();
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

                cbCategoryGroupNames.SelectedIndex = 0;
                tbCategoryGroup.Clear();
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

            lblOldCategoryName.Text = "current group : " + SelectedCategoryGroupName;
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

        private async void btnDelGroup_Click(object sender, EventArgs e)
        {

            if (CategoryManager.GetAllCategoryGroupNames().Count == 1)
            {
                MessageBox.Show("must have at least one category group in app");
                return;
            }

            var res = CategoryManager.DeleteGroup(SelectedCategoryGroupName);
            if (!res)
            {
                MessageBox.Show("if there is a record that related with the any elements of the CategoryGroup in linkData Records you cannot delete it");
                return;
            }


            lblGroupDeleteInfo.Visible = true;
            await Task.Delay(300);
            lblGroupDeleteInfo.Visible = false;
            var groups = CategoryManager.GetAllCategoryGroupNames();
            cbCategoryGroupNames.Items.Clear();
            groups.ForEach(x => cbCategoryGroupNames.Items.Add(x));
            SelectedCategoryGroupName = CategoryManager.GetAllCategoryGroupNames().First();
            SelectedCategory = string.Empty;
            cbCategoryGroupNames.SelectedIndex = 0;

            Program.MainFrm.LoadCategoriesGroup();


        }

        private async void btnUpdateCategoryName_Click(object sender, EventArgs e)
        {
            if (tbCategoryGroupNameUpdate.Text == string.Empty)
            {
                MessageBox.Show("Group Name Cannot Be Empty");
                return;
            } 

            var res =CategoryManager.UpdateGroupName(SelectedCategoryGroupName, tbCategoryGroupNameUpdate.Text);

            if (res)
            {

                lblCateGroupNameUpdateStatus.Visible = true;
                await Task.Delay(300);
                lblCateGroupNameUpdateStatus.Visible = false;

                var groups = CategoryManager.GetAllCategoryGroupNames();
                cbCategoryGroupNames.Items.Clear();
                groups.ForEach(x => cbCategoryGroupNames.Items.Add(x));
                SelectedCategoryGroupName = CategoryManager.GetAllCategoryGroupNames().First();
                SelectedCategory = string.Empty;
                cbCategoryGroupNames.SelectedIndex = 0;
                tbCategoryGroupNameUpdate.Text = string.Empty;
                Program.MainFrm.LoadCategoriesGroup();
            }

        }
    }
}
