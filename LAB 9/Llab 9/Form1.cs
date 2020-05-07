using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Llab_9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 a2 = new Form2();
            a2.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 a3 = new Form3();
            a3.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form4 a4 = new Form4();
            a4.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form5 a5 = new Form5();
            a5.Show();
        }
    }
}
