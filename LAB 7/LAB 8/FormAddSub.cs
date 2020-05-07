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
    public partial class FormAddSub : Form
    {
        public FormAddSub()
        {
            InitializeComponent();
        }
        public DemoEntities db = new DemoEntities();
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
            var codde_sub= db.subjects.Max(r => r.code_subject) + 1;
            subjects subject = new subjects { code_subject = codde_sub, name_subject = textBox1.Text, count_hours =int.Parse(maskedTextBox1.Text) };
            db.subjects.Add(subject);
            db.SaveChanges();
            this.Close();
        }
    }
}
