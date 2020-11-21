using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PR_10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        /*       private void button1_Click(object sender, EventArgs e)
               {
                   int x = Convert.ToInt32(numericUpDown1.Value);
                   int y = Convert.ToInt32(numericUpDown2.Value);
                   int l = Convert.ToInt32(numericUpDown3.Value);
                   Risunok kv = new Risunok(x, y, l, pictureBox1);
               }*/
        private void button1_Click_2(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(numericUpDown1.Value);
            int y = Convert.ToInt32(numericUpDown2.Value);
            int l = Convert.ToInt32(numericUpDown3.Value);
            Point t = new Point(x, y);
            Pen p = new Pen(Color.Red, 2);
            SolidBrush brush = new SolidBrush(Color.LightSkyBlue);
            SolidBrush brush1 = new SolidBrush(Color.White);
            SolidBrush brush2 = new SolidBrush(Color.Green);
            Graphics g = Graphics.FromImage(pictureBox1.Image);
            g.FillRectangle(brush1, 0, 0, pictureBox1.Width, pictureBox1.Height);
            g.FillRectangle(brush, t.X, t.Y, l, l);
            g.DrawRectangle(p, t.X, t.Y, l, l);
            g.DrawLine(p, t.X + l, t.Y, t.X, t.Y + l);
            g.DrawLine(p, t.X, t.Y, t.X + l, t.Y + l);
            g.FillEllipse(brush2, t.X + l / 2 - l / 8, t.Y + l / 12, l / 4, l / 4);
            g.FillEllipse(brush2, t.X + l / 2 - l / 8, t.Y + l - l / 3, l / 4, l / 4);
            pictureBox1.Refresh();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Виталик художник. ДА");
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox1.Image = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            pictureBox1.Image = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            pictureBox1.BackColor = Color.White;
            timer1.Start();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox2.BackColor = colorDialog1.Color;
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
        private void button5_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                Risunok m = listBox1.Items[listBox1.SelectedIndex] as Risunok;
                m.Stir();
                listBox1.Items.RemoveAt(listBox1.SelectedIndex);
            }
        }
        private  void button6_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                Text = "Редактировать";
                Risunok m = listBox1.Items[listBox1.SelectedIndex] as Risunok;
                int x1 = m.x;
                numericUpDown1.Value = x1;
                numericUpDown2.Value = m.y;
                numericUpDown3.Value = m.l;
                numericUpDown4.Value = m.s;
                pictureBox1.BackColor = m.myColor;
                {
                   /* timer1.Stop();
                    m.Stir();
                    int x = Convert.ToInt32(numericUpDown1.Value);
                    int y = Convert.ToInt32(numericUpDown2.Value);
                    int l = Convert.ToInt32(numericUpDown3.Value);
                    int s = Convert.ToInt32(numericUpDown4.Value);
                    Color cl = pictureBox1.BackColor;
//                    x1 = x; m.y = y; m.l = l; m.s = s; m.myColor = cl;
                    listBox1.Items[listBox1.SelectedIndex] = m;
                    timer1.Start();*/
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(numericUpDown1.Text);
            int b = Convert.ToInt32(numericUpDown2.Text);
            int c = Convert.ToInt32(numericUpDown3.Text);
            int d = Convert.ToInt32(numericUpDown4.Text);

            Risunok x = new Risunok(a, b, c, d, pictureBox2.BackColor,pictureBox1);

            listBox1.Items.Add(x);//zapisivaem obyekt v list box

            /*           Form1 f = new Form1();
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
                           timer1.Start();*/
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            Risunok m = listBox1.Items[listBox1.SelectedIndex] as Risunok;
            timer1.Stop();
            m.Stir();
            int x = Convert.ToInt32(numericUpDown1.Value);
            int y = Convert.ToInt32(numericUpDown2.Value);
            int l = Convert.ToInt32(numericUpDown3.Value);
            int s = Convert.ToInt32(numericUpDown4.Value);
            Color cl = pictureBox1.BackColor;
            //                    x1 = x; m.y = y; m.l = l; m.s = s; m.myColor = cl;
            listBox1.Items[listBox1.SelectedIndex] = m;
            timer1.Start();
        }
    }
    }

//BY TUSTUGASHEV Y.V.
