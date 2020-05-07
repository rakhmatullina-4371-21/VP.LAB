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
    public partial class FormAddLector : Form
    {
        public FormAddLector()
        {
            InitializeComponent();
            var code = (from g in db.lectors
                        select g.post).ToList();
            foreach (var c in code)
            {
                comboBox1.Items.Add(c);
            }
        }
        DemoEntities db = new DemoEntities();

        public void proverka(TextBox a)
        {
            string str = a.Text;
            //a = a.Replace(" ", "");

            for (int i = 0; i < str.Length; i++)
            {
                if (char.IsDigit(str[i]) || char.IsPunctuation(str[i]))
                {
                    MessageBox.Show("         Введено недопустимое значение! \r\nВ этих полях не допускается ввод цифр и символов");
                    a.Text = str.Remove(i, 1);
                }
            }


        }
        private void button1_Click(object sender, EventArgs e)
        {
            proverka(textBox1);
            var q = (from s in db.lectors
                     where s.post == comboBox1.SelectedItem.ToString()
                     select s.post).ToList();
            var codde_lec = db.lectors.Max(r => r.code_lector) + 1;
            lectors lec = new lectors { code_lector = codde_lec, name_lector = textBox1.Text, post = q[0].ToString() };
            db.lectors.Add(lec);
            db.SaveChanges();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
