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
        }
    }
}
//BY TUSTUGASHEV Y.V.
