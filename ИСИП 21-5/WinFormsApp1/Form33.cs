using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form33 : Form
    {
        public Form33()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double
                a;
            double
                b;
            double
                c;
            a =
                Convert.ToDouble(textBox1.Text);
            b =
                Convert.ToDouble(textBox2.Text);
            c = b/((a/100) * (a/100));
            label7.Text = c.ToString("N");

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
