﻿using System;
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
        public int x, y, l, s, dy;
        //посмотеть сдесь может закоментить public Color
        public Color myColor;
        PictureBox mybox;
        public Risunok(int n_x, int n_y, int n_l, int n_s, Color n_myColor, PictureBox n_mybox)
        {

            x = n_x;
            y = n_y;
            l = n_l;
            mybox = n_mybox;
            s = n_s;
            dy = s;
            Risovanie();

        }
        public void Risovanie()
        {
            Pen p = new Pen(Color.Red, 3);
            SolidBrush brush = new SolidBrush(Color.LightSkyBlue);
            //SolidBrush brush1 = new SolidBrush(Color.White);
            SolidBrush brush2 = new SolidBrush(Color.LimeGreen);
            Graphics g = Graphics.FromImage(mybox.Image);
            //g.FillRectangle(brush1, 0, 0, mybox.Width, mybox.Height);
            g.FillRectangle(brush, x, y, l, l);
            g.DrawRectangle(p, x, y, l, l);
            g.DrawLine(p, x + l, y, x, y + l);
            g.DrawLine(p, x, y, x + l, y + l);
            g.FillEllipse(brush2, x + l / 2 - l / 8, y + l / 12, l / 4, l / 4);
            g.FillEllipse(brush2, x + l / 2 - l / 8, y + l - l / 3, l / 4, l / 4);
            mybox.Refresh();
        }
            public void Stir()
            {
                Graphics g = Graphics.FromImage(mybox.Image);
                SolidBrush brush1 = new SolidBrush(Color.White);
                g.FillRectangle(brush1, 0, 0, mybox.Width, mybox.Height);
                mybox.Refresh();
            }
            public void Dviz()
            {
                Stir();

                int y1 = y + dy;
                if (y1 < 0 || y1 > (mybox.Height - l))
                {
                    dy = -dy;
                }
                y = y + dy;
                Risovanie();
            }
        /*public override string ToString()
        {
            {
                return " `" + a.ToString() + " - " + b.ToString() + "/ " + c.ToString() + "/ " + d.ToString() + "`";

            }
        }*/
        public override string ToString()
        {
            return ("Масштаб круга- " + l + " цвет-" + myColor);
        }

    }
}
//BY TUSTUGASHEV Y.V.