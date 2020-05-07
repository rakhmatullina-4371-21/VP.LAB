using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAB_6
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            form1 = new Form1();
        }

        public Form2(Form a)
        {
            InitializeComponent();
        }
        public Form1 form1;
        private void ok_2_Click(object sender, EventArgs e)
        {
            
            this.Close();
        }

        private void edit_Click(object sender, EventArgs e)
        {
            User user = new User();
            user.EditLogPas(textBox1_2.Text, textBox2_2.Text, this.Text);
            this.Close();

        }
    }
}
