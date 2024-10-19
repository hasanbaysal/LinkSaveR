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

        public List<string> CurrentCategories = new(); 

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

        List<Button> CurrentButtons = new List<Button>();   
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
            btnTemp.Name = item;
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
            // TODO : Performans olarak biraz sorunlu çok büyük kayıtlarda!
            flowLayoutPanel1.Visible = false;
            CurrentButtons.ForEach(x => x.Visible = true);


            //alternatif arama olarak düşünülebilir
          //await  Task.Run(() =>
          //  {
          //      Parallel.ForEach(CurrentButtons, button =>
          //      {
                   
          //          this.Invoke((Action)(() => button.Visible = true));
          //      });
          //  });


            if (string.IsNullOrEmpty(filter))
            {
                CurrentButtons.ForEach(x=>x.Visible = true);
                flowLayoutPanel1.Visible = true;
                return;
            }
            
            var result = CurrentButtons.Where(x => !(x.Text.StartsWith(filter))).ToList();
            result.ForEach(x => x.Visible = false);
            flowLayoutPanel1.Visible = true;

        }
    }
}
