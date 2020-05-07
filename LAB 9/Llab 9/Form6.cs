using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Llab_9
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
            //var q=bOOKSDataSet.books.row
        }

        private void booksBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.booksBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bOOKSDataSet);

        }

        private void Form6_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bOOKSDataSet.books". При необходимости она может быть перемещена или удалена.
            this.booksTableAdapter.Fill(this.bOOKSDataSet.books);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataGridViewColumn c = dataGridViewTextBoxColumn2;
            switch (listBox1.SelectedIndex) 
            {
                case 0: c = dataGridViewTextBoxColumn2; break;
                case 1: c = dataGridViewTextBoxColumn4; break;
            }
            if (radioButton1.Checked) 
            {
                booksDataGridView.Sort(c, ListSortDirection.Ascending);
            }
            else
            { booksDataGridView.Sort(c, ListSortDirection.Descending); }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            button1.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            booksBindingSource.Filter = "name_book=' "+ comboBox1.Text+ "'";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            booksBindingSource.Filter = "";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < (booksDataGridView.RowCount); i++) 
            {
                for (int j = 0; j < booksDataGridView.ColumnCount; j++)
                {
                    DataGridViewCell c = booksDataGridView.Rows[i].Cells[j];
                    c.Style.BackColor = Color.White;
                    c.Style.ForeColor = Color.Black;
                }
            }

            for (int i = 0; i < (booksDataGridView.RowCount-1); i++)
            {
                for (int j = 0; j < booksDataGridView.ColumnCount; j++)
                {
                    DataGridViewCell c = booksDataGridView.Rows[i].Cells[j];
                    if (c.Value.Equals(textBox1.Text))
                    {
                        c.Style.BackColor = Color.AliceBlue;
                        c.Style.ForeColor = Color.Blue;
                    }
                    
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
