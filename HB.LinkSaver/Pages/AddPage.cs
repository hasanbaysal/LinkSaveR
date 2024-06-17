namespace HB.LinkSaver.Pages
{
    public partial class AddPage : UserControl
    {
        List<string> SelectedCategories = new List<string>();

        public bool UpdateMode = false;
        public Link EntityForUpdate { get; set; } = null;
        public AddPage()
        {
            InitializeComponent();
        }

        public void AddPage_Load(object sender, EventArgs e)
        {


            LinkManager.Control();


            ModeSelect();

        }

        public void ModeSelect()
        {
            SelectedCategories.Clear();
            if (UpdateMode)
            {

                x = 0;
                y = 0;
                count = 0;
                totalCount = 0;
                panel1.Controls.Clear();

                BtnSave.Visible = false;
                BtnUpdate.Visible = true;


                TbHeader.Text = EntityForUpdate.Header;
                TbLink.Text = EntityForUpdate.Content;
                RtbDescription.Text = EntityForUpdate.Description;

                EntityForUpdate.Categories.ForEach(x =>
                {
                    SelectedCategories.Add(x);
                    AddCategoryLabel(x);
                });

                lblPageInfo.Text = "Update The Selected Category";
            }
            else
            {
                BtnUpdate.Visible = false;
                BtnSave.Visible = true;
                panel1.Controls.Clear();
                TbHeader.Text = string.Empty;
                TbLink.Text = string.Empty;
                RtbDescription.Text = string.Empty;
                SelectedCategories.Clear();
                lblPageInfo.Text = "Add a New Record";

            }
        }

        private void LbCategories_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBox lb = (sender as ListBox)!;

            if (lb!.SelectedIndex == -1) return;

            if (totalCount == 8)
            {
                MessageBox.Show("The maximum number of categories is set to 8, you cannot add more. To add a category, first remove an existing category.");
                return;

            }


            var item = lb.SelectedItem.ToString();

            if (!SelectedCategories.Contains(item)) { AddCategoryLabel(item); SelectedCategories.Add(item); }

        }

        int x = 0;
        int y = 0;
        int count = 0;
        int totalCount = 0;
        public void AddCategoryLabel(string str)
        {

            Label lb = new Label();
            lb.Name = str;
            lb.Text = str;
            lb.TextAlign = ContentAlignment.MiddleCenter;
            lb.AutoSize = false;
            lb.ForeColor = Color.White;
            lb.Font = new Font("Segoe UI", 8, FontStyle.Bold, GraphicsUnit.Point, 162);
            lb.Location = new Point(x, y);
            lb.Size = new Size(180, 22);
            lb.FlatStyle = FlatStyle.Flat;
            lb.BackColor = Color.FromArgb(141, 51, 68); //43; 51; 68
            lb.Click += LblClick!;
            lb.MouseLeave += label1_MouseLeave!;
            lb.MouseHover += label1_MouseHover!;
            lb.Cursor = Cursors.Hand;
            x += 183;
            ++count;
            ++totalCount;

            if (count == 2)
            {

                y += 24;
                x = 0;
                count = 0;
            }

            panel1.Controls.Add(lb);

        }
        private void LblClick(object sender, EventArgs e)
        {
            var lbl = (Label)sender;

            SelectedCategories.Remove(lbl.Name);
            x = 0;
            y = 0;
            count = 0;
            totalCount = 0;
            panel1.Controls.Clear();
            SelectedCategories.ForEach(x => AddCategoryLabel(x));
        }

        private void label1_MouseHover(object sender, EventArgs e)
        {
            Label lb = (Label)sender;
            lb.ForeColor = Color.FromArgb(10, 102, 194);
        }

        private void label1_MouseLeave(object sender, EventArgs e)
        {
            Label lb = (Label)sender;
            lb.ForeColor = SystemColors.ButtonFace;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SelectedCategories.Clear();
            x = 0;
            y = 0;
            totalCount = 0;
            count = 0;
            panel1.Controls.Clear();
            TbHeader.Text = string.Empty;
            TbLink.Text = string.Empty;
            RtbDescription.Text = string.Empty;
            MainForm.TogleSize();
        }

        private void BtnSave_Click_1(object sender, EventArgs e)
        {
            var status = OperationControl();

            if (!status)
                return;

            var result = LinkManager.Add(new Link()
            {
                Categories = SelectedCategories,
                Content = TbLink.Text,
                Description = RtbDescription.Text,
                Header = TbHeader.Text,

            });


            if (result)
            {
                MessageBox.Show("success");
                SelectedCategories.Clear();
                x = 0;
                y = 0;
                totalCount = 0;
                count = 0;
                panel1.Controls.Clear();
                TbHeader.Text = string.Empty;
                TbLink.Text = string.Empty;
                RtbDescription.Text = string.Empty;

                MainForm.TogleSize();
                Program.MainFrm.LoadDgw();
                return;
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

            if (TbHeader.Text == string.Empty)
            {
                message += "Header cannot be empty!" + Environment.NewLine;
                status = false;
            }


            if (TbLink.Text == string.Empty)
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

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            var status = OperationControl();

            if (!status)
                return;

            var result = LinkManager.Update(new Link()
            {
                Header = TbHeader.Text,
                Description = RtbDescription.Text,
                Content = TbLink.Text,
                Categories = SelectedCategories,
                Id = EntityForUpdate.Id,
            });



            if (result)
            {
                MessageBox.Show("success");
                SelectedCategories.Clear();
                x = 0;
                y = 0;
                totalCount = 0;
                count = 0;
                panel1.Controls.Clear();
                TbHeader.Text = string.Empty;
                TbLink.Text = string.Empty;
                RtbDescription.Text = string.Empty;

                MainForm.TogleSize();
                Program.MainFrm.LoadDgw();
                UpdateMode = false;
                EntityForUpdate = null;


            }

        }
    }
}
