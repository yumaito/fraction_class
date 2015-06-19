using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using fraction;

namespace FractionTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Fraction x = new Fraction(int.Parse(textBoxXN.Text), int.Parse(textBoxXD.Text));
            Fraction y = new Fraction(int.Parse(textBoxYN.Text), int.Parse(textBoxYD.Text));
            Fraction result = new Fraction();
            if (radioButtonPlus.Checked)
            {
                result = x + y;
            }
            if (radioButtonMinus.Checked)
            {
                result = x - y;
            }
            if (radioButtonMultiple.Checked)
            {
                result = x * y;
            }
            if (radioButtonDivide.Checked)
            {
                result = x / y;
            }
            textBoxResult.Text = result.ToString();
        }
    }
}
