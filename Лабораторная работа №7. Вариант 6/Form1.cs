using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Лабораторная_работа__7.Вариант_6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int[] mas = new int[30];
        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            Random rnd = new Random();
            for(int i=0;i<mas.Length;i++)
            {
                mas[i] = rnd.Next(-50, 50);
                listBox1.Items.Add("mas[" + i.ToString() + "]=" + mas[i].ToString());
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int sum = 0;
            for (int i = 0;i< mas.Length;i++)
            {
                if (Math.Abs(mas[i]) % 2 == 1 && mas[i] < 0)
                    sum += mas[i];
            }
            listBox2.Items.Clear();
            listBox2.Items.Add("Сумма=" + sum.ToString());
        }
    }
}
