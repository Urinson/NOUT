using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PR_4
{
    public partial class Form2 : Form
    {
        private int progress;

        public Form2()
        {
            InitializeComponent();
        }
        private void progressBar1_Click(object sender, EventArgs e)
        {
        }
        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
        }
        private void button3_Click(object sender, EventArgs e)
        {
            progress = 0;
            progressBar1.Value = progress;
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            progress += 1;
            if (progress <= 100)
            {
                progressBar1.Value = progress;
                toolStripStatusLabel1.Text = progress.ToString() + "% Вполнено";
            }
            else
                timer1.Enabled = true;
        }
        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            progressBar1.Value = progress;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
        }
        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {
        }
    }
}
//BY TUSTUGASHEV
