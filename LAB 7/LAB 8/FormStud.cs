using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using NPOI.XSSF.UserModel;

namespace LAB_8
{
    public partial class FormStud : Form
    {
        public DemoEntities db = new DemoEntities();
        public List<students> studentsheet;
        public FormStud()
        {
            InitializeComponent();
            studentsheet = (from stud in db.students
                            select stud).ToList();
            var query = (from stud in studentsheet
                         join g in db.groups on stud.code_group equals g.code_group
                         orderby stud.code_stud
                         select new { stud.code_stud,stud.surname, stud.name, g.name_group, stud.code_group }).ToList();

            dataGridView1.DataSource = query;
            dataGridView1.ReadOnly = true;
            dataGridView1.Columns[0].HeaderText = "Номер студента";
            dataGridView1.Columns[1].HeaderText = "Фамилия";
            dataGridView1.Columns[2].HeaderText = "Имя";
            dataGridView1.Columns[3].HeaderText = "Номер группы";
            dataGridView1.Columns[4].Visible = false;
            if (dataGridView1.RowCount == 0) label1.Visible = true;
            else label1.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)   //добавить
        {
            if (Application.OpenForms.Count == 2)
            {
                FormAddStudent addSt = new FormAddStudent();
                addSt.Owner = this;
                addSt.Show();
            }
            else Application.OpenForms[0].Focus();
            db.SaveChanges();
        }

        private void button2_Click(object sender, EventArgs e)   //редактировать
        {
            List<students> query = (from stud in db.students
                                    select stud).ToList();
            if (dataGridView1.SelectedCells.Count == 1)
            {
                if (Application.OpenForms.Count == 2) 
                {
                    students students = query.First(c => c.code_stud.ToString() == dataGridView1.SelectedCells[0]
                      .OwningRow.Cells[0].Value.ToString());
                    FormEditStudent formEditStudent = new FormEditStudent(students);
                    formEditStudent.Owner = this;
                    formEditStudent.Show();
                }
            }
        }
        
        private void button4_Click(object sender, EventArgs e)  //обновить
        {

            var list = (from st in studentsheet
                        join g in db.groups on st.code_group equals g.code_group
                        orderby st.code_stud
                        select new { st.code_stud, st.name, st.surname, g.name_group, st.code_group }).ToList();
            dataGridView1.DataSource = list;
           
        }

        private void button1_Click(object sender, EventArgs e)    //поиск
        {
            var query = (from stud in studentsheet
                         join g in db.groups on stud.code_group equals g.code_group
                         orderby stud.code_stud
                         select new { stud.code_stud, stud.surname, stud.name, stud.code_group }).ToList();

            if (textBox1.Text != "")
            {
                switch (comboBox1.SelectedIndex)
                {
                    case 0:
                        dataGridView1.DataSource = query.Where(p => p.code_stud.ToString() == textBox1.Text.ToString()).ToList();
                        break;
                    case 1:
                        dataGridView1.DataSource = query.Where(p => p.surname.ToString() == textBox1.Text.ToString()).ToList();
                        break;
                    case 2:
                        dataGridView1.DataSource = query.Where(p => p.name.ToString() == textBox1.Text.ToString()).ToList();
                        break;
                    case 3:
                        dataGridView1.DataSource = query.Where(p => p.code_group.ToString() == textBox1.Text.ToString()).ToList();
                        break;

                }
            }
            if (dataGridView1.RowCount == 0) label1.Visible = true;
            else label1.Visible = false;

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button8_Click(object sender, EventArgs e)    //отчет
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            dialog.DefaultExt = ".xls";
            dialog.Filter = "Таблицы Excel (*.xls)|*.xls|Все файлы (*.*)|*.*";
            dialog.FilterIndex = 1;
            dialog.FileName = "Отчет";
            var query = (from stud in db.students
                         join g in db.groups on stud.code_group equals g.code_group
                         orderby stud.code_stud
                         select new { stud.code_stud, stud.surname, stud.name, g.name_group, stud.code_group }).ToList();
            var template = new MemoryStream(Properties.Resources.t, true);

            var workbook = new XSSFWorkbook(template);
            var sheet1 = workbook.GetSheet("Лист1");

            int row = 11;

            foreach (var item in query.OrderBy(o => o.code_stud))
            {
                var rowInsert = sheet1.CreateRow(row);
                rowInsert.CreateCell(1).SetCellValue(item.code_stud);
                rowInsert.CreateCell(2).SetCellValue(item.surname);
                rowInsert.CreateCell(3).SetCellValue(item.name);
                rowInsert.CreateCell(4).SetCellValue(item.name_group);

                row++;
            }

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                var file = new FileStream(dialog.FileName, FileMode.Create, FileAccess.ReadWrite);
                workbook.Write(file);
            }
        }
    }
}
