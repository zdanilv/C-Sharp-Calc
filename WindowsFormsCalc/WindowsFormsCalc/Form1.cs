using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsCalc
{
    delegate double BinaryOperator(double op1, double op2);
    public partial class Form1 : Form
    {
        private double x, y, result;
        private bool sign = true;

        private readonly Dictionary<char, BinaryOperator> operators = new Dictionary<char, BinaryOperator>()
        {
            { '+', Add },
            { '-', Subtract },
            { '*', Multiply },
            { '/', Divide },
            { '%', Mod },
            { '^', Square }
        };

        static double Add(double x, double y) { return x + y; }
        static double Subtract(double x, double y) { return x - y; }
        static double Multiply(double x, double y) { return x * y; }
        static double Divide(double x, double y) { return x / y; }
        static double Mod(double x, double y) { return x % y; }
        static double Square(double x, double y) { return Math.Pow(x, y); }

        public Form1()
        {
            InitializeComponent();
        }

        private void ButtonNumber0_Click(object sender, EventArgs e)
        {
            label1.Text = "0";
            textBox1.Text += "0 ";
        }

        private void ButtonNumber1_Click(object sender, EventArgs e)
        {
            label1.Text = "1";
            textBox1.Text += "1 ";
        }

        private void ButtonNumber2_Click(object sender, EventArgs e)
        {
            label1.Text = "2";
            textBox1.Text += "2 ";
        }

        private void ButtonNumber3_Click(object sender, EventArgs e)
        {
            label1.Text = "3";
            textBox1.Text += "3 ";
        }

        private void ButtonNumber4_Click(object sender, EventArgs e)
        {
            label1.Text = "4";
            textBox1.Text += "4 ";
        }

        private void ButtonNumber5_Click(object sender, EventArgs e)
        {
            label1.Text = "5";
            textBox1.Text += "5 ";
        }

        private void ButtonNumber6_Click(object sender, EventArgs e)
        {
            label1.Text = "6";
            textBox1.Text += "6 ";
        }

        private void ButtonNumber7_Click(object sender, EventArgs e)
        {
            label1.Text = "7";
            textBox1.Text += "7 ";
        }

        private void ButtonNumber8_Click(object sender, EventArgs e)
        {
            label1.Text = "8";
            textBox1.Text += "8 ";
        }

        private void ButtonNumber9_Click(object sender, EventArgs e)
        {
            label1.Text = "9";
            textBox1.Text += "9 ";
        }

        private void ButtonPlusMinus_Click(object sender, EventArgs e)
        {
            /*if(textBox1.Text.Length != 0)
            {
                if (sign)
                {
                    textBox1.Text = "-" + textBox1.Text;
                    sign = false;
                }
                else
                {
                    textBox1.Text = textBox1.Text.Remove(0, 1);
                    sign = true;
                }
            }*/
        }

        private void ButtonToFloat_Click(object sender, EventArgs e)
        {
            label1.Text += ",0 ";
            textBox1.Text += ",0 ";
        }

        private void ButtonDelete_Click(object sender, EventArgs e)
        {
            if(textBox1.Text.Length != 0)
            {
                textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1, 1);
                //if(textBox1.Text.Length < 1)
                //    label1.Text = "";
            }
        }

        private void ButtonClear_Click(object sender, EventArgs e)
        {
            label1.Text = "";
            textBox1.Text = "";
        }

        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            textBox1.Text += "+ ";
        }

        private void ButtonSubtract_Click(object sender, EventArgs e)
        {
            textBox1.Text += "- ";
        }

        private void ButtonMultiply_Click(object sender, EventArgs e)
        {
            textBox1.Text += "* ";
        }

        private void ButtonDivide_Click(object sender, EventArgs e)
        {
            textBox1.Text += "/ ";
        }

        /*private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string fsf = textBox1.Text;
            MessageBox.Show(fsf);
            if (textBox1.Text == "-" && textBox1.Text.Length == 1)
                textBox1.Text = "";
        }*/

        private void ButtonEqually_Click(object sender, EventArgs e)
        {
            label1.Text = Result().ToString();
        }



        //---------------------------------------------------------

        private double Result()
        {
            var input = textBox1.Text.Split();
            x = int.Parse(input[0]);
            BinaryOperator binaryOperator = operators[input[1][0]];
            y = int.Parse(input[2]);

            result = binaryOperator(x, y);
            return result;
        }
    }
}
