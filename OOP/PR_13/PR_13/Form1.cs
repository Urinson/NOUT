using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PR_13
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                double m = Convert.ToDouble(textBox1.Text);
                double k = Convert.ToDouble(textBox2.Text);
                double n = Convert.ToDouble(textBox3.Text);
                ИЛ_76 t = new ИЛ_76(m, k, n);
                listBox1.Items.Add(t);
            }
            else if (radioButton2.Checked)
            {
                double m = Convert.ToDouble(textBox1.Text);
                double k = Convert.ToDouble(textBox2.Text);

                AN_2 t = new AN_2(m, k);
                listBox1.Items.Add(t);
            }
            else if (radioButton3.Checked)
            {
                double m = Convert.ToDouble(textBox1.Text);

                CU_34 t = new CU_34(m);
                listBox1.Items.Add(t);
            }
        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                Samolet f = listBox1.Items[listBox1.SelectedIndex] as Samolet;
                double s = f.Calc();
                textBox4.Text = s.ToString();
            }
        }
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            textBox1.Enabled = true;
            textBox2.Enabled = true;
            textBox3.Enabled = true;
        }
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            textBox1.Enabled = true;
            textBox2.Enabled = true;
            textBox3.Enabled = false;
        }
        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            textBox1.Enabled = true;
            textBox2.Enabled = false;
            textBox3.Enabled = false;
        }
    }
}
//BY TUSTUGASHEV Y.V.