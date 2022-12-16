using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form34 : Form
    {
        public Form34()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            double
                a;
            double
                b;
            double
                c;
            double
                d;
            double
                f;
            double
                g;
            double
                h;
            double
                j;
            double
                k;

            a =
                Convert.ToDouble(textBox1.Text);
            b =
                Convert.ToDouble(textBox2.Text);
            c =
                Convert.ToDouble(textBox3.Text);

            d = 66 + (13.7 * b) + (5 * a) - (6.8 * c);
            label9.Text = d.ToString("N");
            f = 1.2 * d;
            label11.Text = f.ToString("N");
            g = 1.375 * d;
            label13.Text = g.ToString("N");
            h = 1.55 * d;
            label14.Text = h.ToString("N");
            j = 1.725 * d;
            label15.Text = j.ToString("N");
            k = 1.9 * d;
            label16.Text = k.ToString("N");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form10 fm10 = new Form10();
            fm10.Show();
            this.Hide();
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label20_Click(object sender, EventArgs e)
        {

        }
    }
}
