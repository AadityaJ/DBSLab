using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using System.Ma
namespace Calc
{
    public partial class Form1 : Form
    {
        string input = string.Empty;
        string op1 = string.Empty;
        string op2 = string.Empty;
        char Operator;
        double res = 0.00;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button16_Click(object sender, EventArgs e)
        {
            if (Operator == 's')
            {
                double num3;
                double.TryParse(op1, out num3);
                num3 = (num3 /  180) * Math.PI;
                res = Math.Sin(num3);
                this.textBox2.Text = res.ToString();
                this.textBox1.Text = "Sin (" + op1 + " ) = ";
            }
            else if (Operator == 'q')
            {
                double num4;
                double.TryParse(op1, out num4);
                res = Math.Sqrt(num4);
                //= num4;
                this.textBox2.Text = res.ToString();
                this.textBox1.Text = "Sqrt (" + op1 + " ) = ";
            }
            else
            {
                op2 = input;
                double num1, num2;
                double.TryParse(op1, out num1);
                double.TryParse(op2, out num2);
                if (Operator == '+')
                {
                    res = num1 + num2;
                    this.textBox2.Text = res.ToString();
                    this.textBox1.Text = op1 + " + " + op2 + "  =  ";
                }
                else if (Operator == '-')
                {
                    res = num1 - num2;
                    textBox2.Text = res.ToString();
                    this.textBox1.Text = op1 + " - " + op2 + "  =  ";
                }
                else if (Operator == '*')
                {
                    res = num1 * num2;
                    textBox2.Text = res.ToString();
                    this.textBox1.Text = op1 + " * " + op2 + "  =  ";
                }
                else if (Operator == '/')
                {
                    if (num2 != 0)
                    {
                        res = num1 / num2;
                        this.textBox1.Text = op1 + " / " + op2 + "  =  ";
                        textBox2.Text = res.ToString();
                    }
                    else
                    {
                        this.textBox2.Text = " Divide by 0";
                    }

                }
                else if (Operator == 'p')
                {
                    res = Math.Pow(num1, num2);
                    this.textBox1.Text = op1 + " ^ " + op2 + "  =  ";
                    textBox2.Text = res.ToString();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = string.Empty;
            input = input + "1";
            this.textBox1.Text += input;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = string.Empty;
            input = input + "2";
            this.textBox1.Text += input;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = string.Empty;
            input = input + "3";
            this.textBox1.Text += input;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = string.Empty;
            input = input + "4";
            this.textBox1.Text += input;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = string.Empty;
            input = input + "5";
            this.textBox1.Text += input;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = string.Empty;
            input = input + "6";
            this.textBox1.Text += input;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = string.Empty;
            input = input + "7";
            this.textBox1.Text += input;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = string.Empty;
            input = input + "8";
            this.textBox1.Text += input;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = string.Empty;
            input = input + "9";
            this.textBox1.Text += input;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = string.Empty;
            input = input + "0";
            this.textBox1.Text += input;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            op1 = input;
            Operator = '+';
            input = string.Empty;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            op1 = input;
            Operator = '-';
            input = string.Empty;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            op1 = input;
            Operator = '/';
            input = string.Empty;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            op1 = input;
            Operator = '*';
            input = string.Empty;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            op1 = input;
            Operator = 's';
            input = string.Empty;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            op1 = input;
            Operator = 'p';
            input = string.Empty;
        }

        private void button18_Click(object sender, EventArgs e)
        {
            op1 = input;
            Operator = 'q';
            input = string.Empty;
        }

        private void button19_Click(object sender, EventArgs e)
        {
            input = string.Empty;
            textBox1.Text = " ";
        }

        private void button20_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
