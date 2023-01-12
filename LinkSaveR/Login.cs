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
                    Program.currentForm = linkSaver;
                    this.Hide();
                    linkSaver.Show();
                }
                else
                {
                    MessageBox.Show("yanlış şifre");
                }
            }

        }

        private void Login_Load(object sender, EventArgs e)
        {
          
        }

        private void maskedTextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                button1_Click(this.button1, new());
            }
        }
    }
}
