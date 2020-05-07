using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace LAB_9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Thread thr1 = new Thread(() =>
            {
                for (int i = 0; i < 5; i++)
                    Console.Write("A");
            });
            Thread thr2 = new Thread(() =>
            {
                for (int i = 0; i < 5; i++)
                    Console.Write("B");
            });
            Thread thr3 = new Thread(() =>
            {
                for (int i = 0; i < 5; i++)
                    Console.Write("C");
            });
            thr1.Start();
            thr2.Start();
            thr1.Join();
            thr2.Join();
            thr3.Start();
        }

        

    }
}
