using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Urok_24_09_20
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            pictureBox1.Width = 100 * trackBar2.Value;
            pictureBox1.Height = 80 * trackBar2.Value;
        }
            //{
            //progress+=10;
            //}            

        private void timer1_Tick(object sender, EventArgs e)
        {
            //publick static 
        }
    }
}
