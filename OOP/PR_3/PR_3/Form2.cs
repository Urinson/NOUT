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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            {
                /* Определение количества элементов массива */
                int count = textBox1.Lines.Length;
                int[] mas = new int[count]; int i;
                //double  = Convert.ToDouble (textBox2.Text);
               double[] mas2 = new double[count];

                /* Заполнение массива */
                for (i = 0; i < count; i++)
                    mas[i] = Convert.ToInt32(textBox1.Lines[i]); /* Поиск максимального значения */
                int max = mas[0];
                for (i = 1; i < count; i++) if (max < mas[i])
                        max = mas[i];

                /* Преобразование массива */
                for (i = 0; i < count; i++)
                {
                    mas2[i] = mas[i] / Convert.ToDouble(max);
                }

                /* Вывод результата */

                textBox2.Clear(); // Удаление старых строк for (i=0; i<count; i++)
                for (i = 0; i < count; i++)

                    textBox2.AppendText(mas2[i] + "\r\n"); // Добавление строк


            }
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
//BY TUSTUGASHEV