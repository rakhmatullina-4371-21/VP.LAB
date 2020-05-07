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
    public partial class FormAddStudent : Form
    {
        public DemoEntities db = new DemoEntities();
        public FormAddStudent()
        {
            InitializeComponent();
            var code = (from g in db.groups
                        select g.code_group).ToList();
            foreach(var c in code) 
            {
                comboBox1.Items.Add(c);
            }

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
            proverka(textBox1);
            proverka(textBox2);
                    var q = (from s in db.students
                             where s.name == comboBox1.SelectedItem.ToString()
                             select s.code_group).ToList();

                    var codde_stud = db.students.Max(r => r.code_stud) + 1;
                    students studd = new students { code_stud = codde_stud, surname = textBox1.Text.Replace(" ",""), name = textBox2.Text.Replace(" ",""), code_group = q[0] };
                    db.students.Add(studd);
                    db.SaveChanges();
                    this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
