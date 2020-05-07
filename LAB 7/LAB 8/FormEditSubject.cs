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
    public partial class FormEditSubject : Form
    {
        public FormEditSubject()
        {
            InitializeComponent();
        }
        public DemoEntities db = new DemoEntities();
        public subjects item;
        public FormEditSubject(subjects sub)
        {
            item = sub;
            InitializeComponent();
            textBox1.Text = item.name_subject;
            maskedTextBox1.Text = item.count_hours.ToString();
        }
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
            var result = ((FormEditSubject)Owner).db.subjects.SingleOrDefault(w => w.code_subject == item.code_subject);
            proverka(textBox1);
            result.name_subject = textBox1.Text.Replace(" ","");
            result.count_hours = int.Parse(maskedTextBox1.Text);
            ((FormSubject)Owner).sub = ((FormSubject)Owner).db.subjects.OrderBy(o => o.code_subject).ToList();
            foreach (var s in db.subjects.Where(w => w.code_subject == item.code_subject))
            {
                s.name_subject = result.name_subject;
                s.count_hours = result.count_hours;
            }
            db.SaveChanges();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
