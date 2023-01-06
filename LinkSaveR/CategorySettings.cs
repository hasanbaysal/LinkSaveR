using LinkSaveR.CRUD;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;

namespace LinkSaveR
{
    public partial class CategorySettings : Form
    {
        public CategorySettings()
        {
            InitializeComponent();
        }

        public void loadBox()
        {

            comboBox1.Items.Clear();
            var data = Crud.GetCategories();

            data.ForEach(x =>
            {

                comboBox1.Items.Add(x.Id + "_" + x.Name);

            });
        }

        public LinkSaver frmMain { get; set; }
        private void CategorySettings_Load(object sender, EventArgs e)
        {
            var data =Crud.GetCategories();


            data.ForEach(x =>
            {

                comboBox1.Items.Add(x.Id + "_" + x.Name);

            });
        }

        private void button1_Click(object sender, EventArgs e)
        {

            

            if (comboBox1.SelectedIndex == -1 || comboBox1.SelectedItem.ToString() == string.Empty  || comboBox1.SelectedItem.ToString() == null)
            {
                return;
            }



            var id = comboBox1.SelectedItem.ToString().Split("_")[0];


            int realid = int.Parse(id);



            if (Crud.GetLinkByCategoryId(realid).Count >0 )
            {
                DialogResult dialogResult = MessageBox.Show("Sure", "there are links in this category are sure \n if you delete this category you will lose your links", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {

                    Crud.DeleteCategory(realid);
                    MessageBox.Show("deleted");
                    comboBox1.SelectedIndex = -1;
                    loadBox();
                }
                else if (dialogResult == DialogResult.No)
                {
                    return;
                }
            }
            else
            {
                Crud.DeleteCategory(realid);
                MessageBox.Show("deleted");
                comboBox1.SelectedIndex = -1;
                loadBox();
            }

        }

        private void CategorySettings_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmMain.LoadDataGridView();
            frmMain.ResetDeleteBtnAndBrowserBtn();
            frmMain.Show();
        }
    }
}
