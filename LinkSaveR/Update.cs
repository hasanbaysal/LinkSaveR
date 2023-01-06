using LinkSaveR.CRUD;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LinkSaveR
{
    public partial class Update : Form
    {
        public Update()
        {
            InitializeComponent();
        }
        public LinkSaver Main { get; set; }
        public int LinkId { get; set; }
        public int CategoryID { get; set; }
        public string Url { get; set; }
        public string  Comment { get; set; }
        public string CategoryName { get; set; }
        int index = 0;
        private void Update_Load(object sender, EventArgs e)
        {
            using (var db = new AppDbContext())
            {
                var data = db.Categories.ToList();

                data.ForEach(x =>
                {
                    comboBox1.Items.Add(x.Id + "_" + x.Name);
                });


              index=  data.FindIndex(x => x.Id == CategoryID);


            }

            lblInfo.Text = $"current link id {LinkId} \n" +
                            $"category name {CategoryName}" +
                            $" category link id {CategoryID} \n " +
                            $"link data {Url} \n" +
                            $"comment {Comment}\n " ;

            txtLink.Text = Url;
            txtComment.Text = Comment;


            comboBox1.SelectedIndex = index;

        }

        private void Update_FormClosed(object sender, FormClosedEventArgs e)
        {
            Main.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            var categoryidx = comboBox1.SelectedItem.ToString().Split("_")[0];
            var linkVal = txtLink.Text;
            var commentVal = txtComment.Text;

            using (var db = new AppDbContext())
            {
                var item = db.Links.Find(LinkId);

                item.CategoryId = int.Parse(categoryidx);
                item.LinkData = linkVal;
                item.Description= commentVal;

                db.SaveChanges();
                
            }
            Main.ResetDeleteBtnAndBrowserBtn();
            Main.LoadDataGridView();

            Main.Enabled = true;
            this.Close();

            
        }

        private void Update_FormClosing(object sender, FormClosingEventArgs e)
        {
            Main.Enabled = true;
        }
    }
}
