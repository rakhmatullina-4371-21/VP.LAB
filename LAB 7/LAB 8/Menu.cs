using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAB_8
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    FormProgressCheck progSelect = new FormProgressCheck();
                    progSelect.Show();
                    break;
                case 1:
                    FormStud studSelect = new FormStud();
                    studSelect.Show();
                    break;
                case 2:
                    FormSubject s = new FormSubject();
                    s.Show();
                    break;
                case 3:
                    FormLectors lectorsSelect = new FormLectors();
                    lectorsSelect.Show();
                    break;
            }
        }
    }
}
