using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HB.LinkSaver.Components
{
    public partial class CategoryControlLb : UserControl
    {
        List<Category> categories = new List<Category>();
       

        [Browsable(true)] // Tasarımcıda görünür olmasını sağlar
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)] // Serileştirilebilir yapar
        public event EventHandler BtnHandler;
        public CategoryControlLb()
        {

            InitializeComponent();
            flowLayoutPanel1.AutoScroll = true;
        }

        private void CategoryControlLb_Load(object sender, EventArgs e)
        {
    

        }

        public void AddItem(string item)
        {
            
            var btnTemp = new Button();
            btnTemp.BackColor = Color.FromArgb(30, 30, 30);
            btnTemp.Margin = new Padding(25, 3, 3, 25);
            btnTemp.Width = 270;
            btnTemp.Height = 35;
            btnTemp.TextAlign = ContentAlignment.TopCenter;
            btnTemp.ForeColor = Color.White;
            btnTemp.Font = new Font("Segoe UI", 12, FontStyle.Regular);
            btnTemp.FlatStyle = FlatStyle.Flat;
            btnTemp.Text = item;
            btnTemp.Click += BtnHandler;
            flowLayoutPanel1.Controls.Add(btnTemp);


        }
        public void ClearItems()
        {
            flowLayoutPanel1.Controls.Clear();
        }
    }
}
