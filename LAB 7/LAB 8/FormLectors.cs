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
    public partial class FormLectors : Form
    {
        public DemoEntities db = new DemoEntities();
        public List<lectors> lectors;
        public FormLectors()
        {
            InitializeComponent();
            lectors = (from lec in db.lectors
                       select lec).ToList();

            dataGridView1.DataSource = lectors;
            dataGridView1.ReadOnly = true;
            dataGridView1.Columns[0].HeaderText = "Номер преподавателя";
            dataGridView1.Columns[1].HeaderText = "ФИО";
            dataGridView1.Columns[2].HeaderText = "Должность";
            dataGridView1.Columns[3].Visible = false;
            if (dataGridView1.RowCount == 0) label1.Visible = true;
            else label1.Visible = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var lectorsheet = (from lec in db.lectors
                               select lec).ToList();
            dataGridView1.Columns[3].Visible = false;
            dataGridView1.DataSource = lectorsheet;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.Count == 2)
            {

                FormAddLector addSt = new FormAddLector();
                addSt.Owner = this;
                addSt.Show();
            }
            else Application.OpenForms[0].Focus();
            db.SaveChanges();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            List<lectors> query = (from lect in db.lectors
                                   select lect).ToList();
            if (dataGridView1.SelectedCells.Count == 1)
            {
                if (Application.OpenForms.Count == 2)
                {
                    lectors lect = query.First(c => c.code_lector.ToString() == dataGridView1.SelectedCells[0]
                      .OwningRow.Cells[0].Value.ToString());
                    FormEditLector edLect = new FormEditLector(lect);
                    edLect.Owner = this;
                    edLect.Show();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var query = (from lect in db.lectors
                         select lect).ToList();

            if (textBox1.Text != "")
            {
                switch (comboBox1.SelectedIndex)
                {
                    case 0:
                        dataGridView1.DataSource = query.Where(p => p.code_lector.ToString() == textBox1.Text.ToString()).ToList();
                        break;
                    case 1:
                        dataGridView1.DataSource = query.Where(p => p.name_lector.ToString() == textBox1.Text.ToString()).ToList();
                        break;
                    case 2:
                        dataGridView1.DataSource = query.Where(p => p.post.ToString() == textBox1.Text.ToString()).ToList();
                        break;
                    
                }
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
