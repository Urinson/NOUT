using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PR_10
{
    class Risunok
    {
        int x, y, l;
        PictureBox mybox;
        public Risunok(int n_x, int n_y, int n_l, PictureBox n_mybox)
        {
            x = n_x;
            y = n_y;
            l = n_l;
            mybox = n_mybox;
            Risovanie();
        }
        public void Risovanie()
        {
            Pen p = new Pen(Color.Red, 3);
            SolidBrush brush = new SolidBrush(Color.LightSkyBlue);
            SolidBrush brush1 = new SolidBrush(Color.White);
            SolidBrush brush2 = new SolidBrush(Color.LimeGreen);
            Graphics g = Graphics.FromImage(mybox.Image);
            g.FillRectangle(brush1, 0, 0, mybox.Width, mybox.Height);
            g.FillRectangle(brush, x, y, l, l);
            g.DrawRectangle(p, x, y, l, l);
            g.DrawLine(p, x + l, y, x, y + l);
            g.DrawLine(p, x, y, x + l, y + l);
            g.FillEllipse(brush2, x + l / 2 - l / 8, y + l / 12, l / 4, l / 4);
            g.FillEllipse(brush2, x + l / 2 - l / 8, y + l - l / 3, l / 4, l / 4);
            mybox.Refresh();
        }
    }
}
//BY TUSTUGASHEV Y.V.
