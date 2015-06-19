using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Fraction;

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
            Fraction.Fraction x = new Fraction.Fraction(int.Parse(textBoxXN.Text), int.Parse(textBoxXD.Text));
            Fraction.Fraction y = new Fraction.Fraction(int.Parse(textBoxYN.Text), int.Parse(textBoxYD.Text));
            Fraction.Fraction result = new Fraction.Fraction();
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
