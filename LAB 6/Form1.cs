using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace LAB_6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
  
        private void ok_1_Click(object sender, EventArgs e)
        {
            
            User user = new User();
            user.SearchUser(textBox1_1.Text, textBox2_1.Text);
            if (user.u)
            {
                Form2 f = new Form2(this);
                f.textBox1_2.Text = user.Loginn;
                f.textBox2_2.Text = user.Passwordd;
                f.Text = user.NameUser;
                f.Show();
            }
            
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            textBox1_1.Text = null;
            textBox2_1.Text = null;
        }
    }
}
