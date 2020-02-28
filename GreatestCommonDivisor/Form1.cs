using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GreatestCommonDivisor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void textBoxInput1_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(textBoxInput1.Text, "[^0-9]"))
            {
                textBoxInput1.Text = textBoxInput1.Text.Remove(textBoxInput1.Text.Length - 1);
            }

        }

        private void textBoxInput2_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(textBoxInput2.Text, "[^0-9]"))
            {
                textBoxInput2.Text = textBoxInput2.Text.Remove(textBoxInput2.Text.Length - 1);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBoxOut.Text = (gcd(Convert.ToInt32(textBoxInput1.Text.ToString()), Convert.ToInt32(textBoxInput2.Text.ToString()))).ToString();
        }
        private void Button2_Click(object sender, EventArgs e)
        {
            textBoxOut.Text = (Fact(Convert.ToInt32(textBoxInput1.Text.ToString())).ToString());
        }
        private void Button3_Click(object sender, EventArgs e)
        {
            textBoxOut.Text = (Fibonacci(Convert.ToInt32(textBoxInput1.Text.ToString())).ToString());
        }
        private int gcd(int a, int b)
        {
            return b == 0 ? a : gcd(b, a % b);  // method 3 recursive function

            /*   
                       // method 2         recursive function
                       if (b != 0)
                        {
                            if (a > b)
                                return gcb(b, a % b);
                            else if (a < b)
                                return gcb(a, b % a);
                        }
                        return a;
            */

            /*   

            // method 1     
            while (a != 0 && b != 0)
            {
                if (a > b)
                    a %= b;
                else
                    b %= a;
            }
            return a == 0 ? b : a;
            */
        }
        private int Fact(int a)
        {
            if (a == 0)
                return 1;
            else
                return a * Fact(a - 1);
        }
        private int Fibonacci(int a)
        {
            if (a <=1)
                return 1;
            else
                return Fibonacci(a - 2) + Fibonacci(a - 1);
        }

    }
}
