using System.ComponentModel;
using System.Data;

namespace HB.LinkSaver.Components
{
    public partial class CategoryControlLb : UserControl
    {

        public List<string> CurrentCategories = new();

        [Browsable(true)] 
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)] 
        public event EventHandler BtnHandler;
        public CategoryControlLb()
        {

            InitializeComponent();
            flowLayoutPanel1.AutoScroll = true;
        }

        private void CategoryControlLb_Load(object sender, EventArgs e)
        {


        }

        List<Button> CurrentButtons = new List<Button>();
        public void AddItem(string item)
        {

            var btnTemp = new Button();
            btnTemp.BackColor = Color.FromArgb(30, 30, 30);
            btnTemp.Margin = new Padding(30, 3, 3, 25);
            
            btnTemp.Width = 270;
            btnTemp.Height = 35;
            btnTemp.TextAlign = ContentAlignment.MiddleCenter;
            btnTemp.ForeColor = Color.White;
            btnTemp.Font = new Font("Segoe UI", 12, FontStyle.Regular);
            btnTemp.FlatStyle = FlatStyle.Flat;
            btnTemp.Text = item;
            btnTemp.Name = item;
            btnTemp.TabStop = false;
            btnTemp.Click += BtnHandler;
            flowLayoutPanel1.Controls.Add(btnTemp);
            flowLayoutPanel1.Refresh();
            CurrentButtons.Add(btnTemp);
        }
        public void ClearItems()
        {
            CurrentButtons.Clear();
            flowLayoutPanel1.Controls.Clear();
            flowLayoutPanel1.Refresh();
        }

        public void FilterCategory(string filter)
        {
            // TODO : Debounce eklemek gerek
            flowLayoutPanel1.Visible = false;
            CurrentButtons.ForEach(x => x.Visible = true);


         


            if (string.IsNullOrEmpty(filter))
            {
                CurrentButtons.ForEach(x => x.Visible = true);
                flowLayoutPanel1.Visible = true;
                return;
            }

            var result = CurrentButtons.Where(x => !(x.Text.Contains(filter,StringComparison.OrdinalIgnoreCase))).ToList();
            result.ForEach(x => x.Visible = false);
            flowLayoutPanel1.Visible = true;

        }
    }
}
