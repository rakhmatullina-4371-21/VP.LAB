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
    public partial class FormProgressCheck : Form
    {
        DemoEntities db = new DemoEntities();
        List<progress> progList;
        FormStud stud = new FormStud();
        public FormProgressCheck()
        {
            InitializeComponent();
            progList = (from prog in db.progress
                        select prog).ToList();

            var progStud = (from pr in progList
                            join stud in db.students on pr.code_stud equals stud.code_stud
                            join sub in db.subjects on pr.code_subject equals sub.code_subject
                            join lec in db.lectors on pr.code_lector equals lec.code_lector
                            orderby stud.code_stud
                            select new { stud.code_stud,stud.surname, stud.name,lec.name_lector, sub.name_subject,pr.estimate }).ToList();
            dataGridView1.DataSource = progStud;
            dataGridView1.Columns[0].HeaderText = " № Студента ";
            dataGridView1.Columns[1].HeaderText = " Фамилия ";
            dataGridView1.Columns[2].HeaderText= " Имя ";
            dataGridView1.Columns[3].HeaderText= " Преподаватель ";
            dataGridView1.Columns[4].HeaderText = " Предмет  ";
            dataGridView1.Columns[5].HeaderText = " Оценка ";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var progStud = (from pr in progList
                            join stud in db.students on pr.code_stud equals stud.code_stud
                            join sub in db.subjects on pr.code_subject equals sub.code_subject
                            join lec in db.lectors on pr.code_lector equals lec.code_lector
                            orderby stud.code_stud
                            select new { stud.code_stud,stud.surname, stud.name, lec.name_lector, sub.name_subject, pr.estimate }).ToList();
            if (textBox1.Text != "")
            {
                switch (comboBox1.SelectedIndex) 
                {
                    case 0:
                        dataGridView1.DataSource = progStud.Where(p => p.name_subject == textBox1.Text).ToList();
                        break;
                    case 1:
                        dataGridView1.DataSource = progStud.Where(p => p.name_lector == textBox1.Text).ToList();
                        break;
                    case 2:
                        dataGridView1.DataSource = progStud.Where(p => p.code_stud.ToString() == textBox1.Text).ToList();
                        break;
                    case 3:
                        dataGridView1.DataSource = progStud.Where(p => p.surname+" "+p.name == textBox1.Text).ToList();
                        break;
                }
            }
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
