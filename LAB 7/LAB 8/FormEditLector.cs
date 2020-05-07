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
    public partial class FormEditLector : Form
    {
       public DemoEntities db = new DemoEntities();
        public FormEditLector()
        {
            InitializeComponent();
        }
        public lectors lect;
        public FormEditLector(lectors lec)
        {
            lect = lec;
            InitializeComponent();
            var group_for_list = (from g in db.lectors
                                  select g.post).Distinct();
            foreach (string it in group_for_list)
            {
                comboBox1.Items.Add(it);
            }
            textBox1.Text = lect.name_lector.ToString();
           
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
            var result = ((FormStud)Owner).db.lectors.SingleOrDefault(w => w.code_lector == lect.code_lector);
            proverka(textBox1);
            result.name_lector = textBox1.Text.Replace(" ","");
            var query = (from g in db.lectors
                         where g.post == comboBox1.SelectedItem.ToString()
                         select g.post).ToList();
            result.post = query[0];
            ((FormLectors)Owner).lectors = ((FormLectors)Owner).db.lectors.OrderBy(o => o.code_lector).ToList();
            foreach (var lector in db.lectors.Where(w => w.code_lector == lect.code_lector))
            {
                lector.name_lector = result.name_lector;
                lector.post = query[0];
            }
            db.SaveChanges();
            this.Close();
        }
    }
}
