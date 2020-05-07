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
    public partial class FormEditStudent : Form
    {
        public DemoEntities db = new DemoEntities();
        students item;
        public FormEditStudent(students stud)
        {
            item = stud;
            InitializeComponent();
            var group_for_list = (from g in db.groups
                                  select g.name_group).Distinct();
            foreach (string it in group_for_list) 
            {
                comboBox1.Items.Add(it);
            }
            textBox1.Text = item.surname.ToString();
            textBox2.Text = item.name.ToString();
            var query = (from g in db.groups
                         where g.code_group == item.code_group
                         select g.name_group).ToList();
            comboBox1.SelectedItem = query[0];
        }


        public void proverka(TextBox a)
        {
            string str = a.Text;
            //a = a.Replace(" ", "");
           
            for(int i=0;i<str.Length;i++)
            { 
                if (char.IsDigit(str[i])|| char.IsPunctuation(str[i]))
                {
                    MessageBox.Show("         Введено недопустимое значение! \r\nВ этих полях не допускается ввод цифр и символов");
                   a.Text=str.Remove(i, 1);
                }
            }
           

        }
        private void button1_Click(object sender, EventArgs e)
        {
               
            var result = ((FormStud)Owner).db.students.SingleOrDefault(w => w.code_stud == item.code_stud);
           
           
            proverka(textBox1);
            proverka(textBox2);
            result.surname = textBox1.Text.Replace(" ","");
            result.name = textBox2.Text.Replace(" ","");
            var query = (from g in db.groups
                             where g.name_group == comboBox1.SelectedItem.ToString()
                             select g.code_group).ToList();
                result.code_group = query[0];
                ((FormStud)Owner).studentsheet = ((FormStud)Owner).db.students.OrderBy(o => o.code_stud).ToList();
            foreach (var stud in db.students.Where(w => w.code_stud==item.code_stud))
            {
                stud.name = result.name;
                stud.surname = result.surname;
                stud.code_group = query[0];
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
