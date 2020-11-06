using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Urok_06._11._2020
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.DialogResult == DialogResult.OK)
            {
                int k = 0;
                try
                {
                    if (textBox1.Text.Trim() == "")
                    {
                        textBox1.Focus();
                        throw new Exception("Числитель не заполнен, понял !!!");
                    }
                    if (textBox2.Text.Trim() == "")
                    {
                        textBox2.Focus();
                        throw new Exception("Знаменатель не заполнен, понял !!!");
                    }
                    int a = Convert.ToInt32(textBox1.Text);
                    k++;
                    int b = Convert.ToInt32(textBox2.Text);
                }
                catch (FormatException)
                {
                    e.Cancel = true;

                    if (k == 0)
                    {
                        MessageBox.Show("Числитель должно быть числом, понял !!!");
                        textBox1.Focus();
                    }
                    else
                    {
                        MessageBox.Show("Знаменатель должен быть числом, понял !!!");
                        textBox2.Focus();
                    }
                }
                catch (Exception E)
                {
                    e.Cancel = true;

                    MessageBox.Show(E.Message);
                }
            }
        }
    }
}
//BY TUSTUGASHEV Y.V.