using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PR_10._2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.Text = "Добавление";
            if (f.ShowDialog() == DialogResult.OK)
            {
                timer1.Stop();
                int x = Convert.ToInt32(f.numericUpDown1.Value);
                int y = Convert.ToInt32(f.numericUpDown2.Value);
                int l = Convert.ToInt32(f.numericUpDown3.Value);
                int s = Convert.ToInt32(f.numericUpDown4.Value);
                Color cl = f.pictureBox1.BackColor;
                Risunok kv = new Risunok(x, y, l, s, cl, pictureBox1);
                listBox1.Items.Add(kv);
                timer1.Start();
            }
        }
        private void Form1_Load_1(object sender, EventArgs e)
        {
            pictureBox1.Image = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            pictureBox1.BackColor = Color.White;
            timer1.Start();
        }
        private void button3_Click_1(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                Risunok m = listBox1.Items[listBox1.SelectedIndex] as Risunok;
                m.Stir();
                listBox1.Items.RemoveAt(listBox1.SelectedIndex);
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                Form2 f = new Form2();
                f.Text = "Редактировать";
                Risunok m = listBox1.Items[listBox1.SelectedIndex] as Risunok;
                f.numericUpDown1.Value = m.x;
                f.numericUpDown2.Value = m.y;
                f.numericUpDown3.Value = m.l;
                f.numericUpDown4.Value = m.s;
                f.pictureBox1.BackColor = m.myColor;
                if (f.ShowDialog() == DialogResult.OK)
                {
                    timer1.Stop();
                    m.Stir();
                    int x = Convert.ToInt32(f.numericUpDown1.Value);
                    int y = Convert.ToInt32(f.numericUpDown2.Value);
                    int l = Convert.ToInt32(f.numericUpDown3.Value);
                    int s = Convert.ToInt32(f.numericUpDown4.Value);
                    Color cl = f.pictureBox1.BackColor;
                    m.x = x; m.y = y; m.l = l; m.s = s; m.myColor = cl;
                    listBox1.Items[listBox1.SelectedIndex] = m;
                    timer1.Start();
                }
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                Risunok m = listBox1.Items[i] as Risunok;
                m.Dviz();
            }

        }
    }
}
//BY TUSTUGASHEV Y.V.