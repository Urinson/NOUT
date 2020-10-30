using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PR_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int w1 = Convert.ToInt32(textBox1.Text);// получение W1
            int h1 = Convert.ToInt32(textBox2.Text);// получение H1
            int w2 = Convert.ToInt32(textBox3.Text);// получение W2
            int h2 = Convert.ToInt32(textBox4.Text);// получение H1
            Double p1 = w1 * h1;                    // площадь большого экрана
            Double p2 = w2 * h2;                    // площадь малого экрана
            textBox5.Text = p1.ToString();          // вывод площади большого экрана
            textBox6.Text = p2.ToString();          // вывод площади малого экрана
            Double p3 = (p2/ p1)*100;               // расчёт %
            textBox7.Text = p3.ToString();          // Вывод
        }
        
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
// BY TUSTUGASHEV