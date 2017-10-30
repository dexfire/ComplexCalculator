using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComplexCalculator
{
    public partial class Form1 : Form
    {
        ComplexNumber complex1,complex2;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            readvalue();
            label5.Text=(complex1 + complex2).ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            readvalue();
            label5.Text = (complex1 - complex2).ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            readvalue();
            label5.Text = (complex1 * complex2).ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            readvalue();
            label5.Text = (complex1 / complex2).ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            readvalue();
            label5.Text = (complex1 ^ int.Parse(textBox3.Text)).ToString();
        }
        private void readvalue()
        {
            complex1 = new ComplexNumber(int.Parse(textBox1.Text), int.Parse(textBox2.Text));
            complex2 = new ComplexNumber(int.Parse(textBox3.Text), int.Parse(textBox4.Text));
        }
    }
}
