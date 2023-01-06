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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (maskedTextBox1.Text != string.Empty)
            {
                if (maskedTextBox1.Text =="147258369a")
                {
                    LinkSaver linkSaver = new LinkSaver();
                    this.Hide();
                    linkSaver.Show();
                }
            }
        }
    }
}
