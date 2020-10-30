using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dobavit_new_proekt
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random r = new Random();
            int x = r.Next(this.Width - button1.Width);
            int y = r.Next(this.Height - button1.Height);
            button1.Location = new Point(x , y);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("231312!");
        }
    }
}
