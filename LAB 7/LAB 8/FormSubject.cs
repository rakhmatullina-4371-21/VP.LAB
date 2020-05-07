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
    public partial class FormSubject : Form
    {
        public DemoEntities db = new DemoEntities();
        public List<subjects> sub;
        public FormSubject()
        {
            InitializeComponent();
            sub = (from s in db.subjects
                            select s).ToList();
            dataGridView1.DataSource = sub;
            dataGridView1.ReadOnly = true;
            dataGridView1.Columns[0].HeaderText = "Номер предмета";
            dataGridView1.Columns[1].HeaderText = "Название";
            dataGridView1.Columns[2].HeaderText = "Кол-во часов";
            if (dataGridView1.RowCount == 0) label1.Visible = true;
            else label1.Visible = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var sub = (from s in db.subjects
                               select s).ToList();
            dataGridView1.DataSource = sub;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var query = (from s in db.subjects
                         select s).ToList();

            if (textBox1.Text != "")
            {
                switch (comboBox1.SelectedIndex)
                {
                    case 0:
                        dataGridView1.DataSource = query.Where(p => p.code_subject.ToString() == textBox1.Text.ToString()).ToList();
                        break;
                    case 1:
                        dataGridView1.DataSource = query.Where(p => p.name_subject.ToString() == textBox1.Text.ToString()).ToList();
                        break;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            List<subjects> query = (from s in db.subjects
                                   select s).ToList();
            if (dataGridView1.SelectedCells.Count == 1)
            {
                if (Application.OpenForms.Count == 2)
                {
                    subjects subjectt = query.First(c => c.code_subject.ToString() == dataGridView1.SelectedCells[0]
                      .OwningRow.Cells[0].Value.ToString());
                    FormEditSubject edLect = new FormEditSubject(subjectt);
                    edLect.Owner = this;
                    edLect.Show();
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.Count == 2)
            {

                FormAddSub addSt = new FormAddSub();
                addSt.Owner = this;
                addSt.Show();
            }
            else Application.OpenForms[0].Focus();
            db.SaveChanges();
        }
    }
}
