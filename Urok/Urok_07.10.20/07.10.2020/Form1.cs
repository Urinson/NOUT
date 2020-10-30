using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _07._10._2020
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(textBox1.Text);
            int b = Convert.ToInt32(textBox2.Text);

            Drobi d = new Drobi(a,b);

            listBox1.Items.Add(d);//zapisivaem obyekt v list box
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double d = 0;
            for (int  i=0; i<listBox1.Items.Count; i++)
            {
                Drobi s = listBox1.Items[i] as Drobi;// izzvlekaem obyekt iz list boxa
                d += s.Rezult();
            }
            textBox3.Text = d.ToString();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
