using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PR_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Calc_B(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            {
                /* Определение количества элементов массива */
                int count = textBox1.Lines.Length;

                int[] mas = new int[count]; int i;

                /* Заполнение массива */
                for (i = 0; i < count; i++)

                    mas[i] = Convert.ToInt32(textBox1.Lines[i]); /* Поиск максимального значения */

                int max = mas[0];

                for (i = 1; i < count; i++) if (max < mas[i])

                        max = mas[i];

                /* Преобразование массива */
                for (i = 0; i < count; i++)

                    mas[i] *= max;

                /* Вывод результата */

                textBox2.Clear(); // Удаление старых строк for (i=0; i<count; i++)
                for (i = 0; i < count; i++)

                    textBox2.AppendText(mas[i] + "\r\n"); // Добавление строк
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 newForm = new Form2();
            newForm.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    
        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
    }
//BY TUSTUGASHEV