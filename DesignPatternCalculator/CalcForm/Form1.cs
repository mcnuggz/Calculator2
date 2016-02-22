using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CalcFunctions;

namespace CalcForm
{
    public partial class Form1 : Form
    {
        IFunction function;
        char operation;
        string input = string.Empty;
        string operand1 = string.Empty;
        string operand2 = string.Empty;
        double results = 0.0;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            this.resultsBox.Text = "";
            input += "7";
            this.resultsBox.Text += input;
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            this.resultsBox.Text = "";
            input += "8";
            this.resultsBox.Text += input;
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            this.resultsBox.Text = "";
            input += "9";
            this.resultsBox.Text += input;
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            this.resultsBox.Text = "";
            input += "4";
            this.resultsBox.Text += input;
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            this.resultsBox.Text = "";
            input += "5";
            this.resultsBox.Text += input;
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            this.resultsBox.Text = "";
            input += "6";
            this.resultsBox.Text += input;
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            this.resultsBox.Text = "";
            input += "1";
            this.resultsBox.Text += input;
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            this.resultsBox.Text = "";
            input += "2";
            this.resultsBox.Text += input;
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            this.resultsBox.Text = "";
            input += "3";
            this.resultsBox.Text += input;
        }

        private void clear_btn_Click(object sender, EventArgs e)
        {
            this.resultsBox.Text = "";
            this.input = string.Empty;
            this.operand1 = string.Empty;
            this.operand2 = string.Empty;
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            this.resultsBox.Text = "";
            input += "0";
            this.resultsBox.Text += input;
        }

        private void decimal_btn_Click(object sender, EventArgs e)
        {
            this.resultsBox.Text = "";
            input += ".";
            this.resultsBox.Text += input;
        }

        private void divide_btn_Click(object sender, EventArgs e)
        {
            operand1 = input;
            operation = '/';
            input = string.Empty;
        }

        private void mulitply_btn_Click(object sender, EventArgs e)
        {
            operand1 = input;
            operation = '*';
            input = string.Empty;
        }

        private void subtract_btn_Click(object sender, EventArgs e)
        {
            operand1 = input;
            operation = '-';
            input = string.Empty;
        }

        private void add_btn_Click(object sender, EventArgs e)
        {
            operand1 = input;
            operation = '+';
            input = string.Empty;
        }

        private void equals_btn_Click(object sender, EventArgs e)
        {
            operand2 = input;
            double num1, num2;
            double.TryParse(operand1, out num1);
            double.TryParse(operand2, out num2);

            if (operation == '+')
            {
                function = Calculator.Add(num1, num2);
                results = function.Calculate();               
                resultsBox.Text = results.ToString();
                MessageBox.Show(function.Notify());
            }
            else if (operation == '-')
            {
                function = Calculator.Subtract(num1, num2);
                results = function.Calculate();
                resultsBox.Text = results.ToString();
                MessageBox.Show(function.Notify());
            }
            else if (operation == '*')
            {
                function = Calculator.Multiply(num1, num2);
                results = function.Calculate();
                resultsBox.Text = results.ToString();
                MessageBox.Show(function.Notify());
            }
            else if (operation == '/')
            {
                if (num1 != 0 && num2 != 0)
                {
                    function = Calculator.Subtract(num1, num2);
                    results = function.Calculate();
                    resultsBox.Text = results.ToString();
                    MessageBox.Show(function.Notify());
                }
                else
                {
                    this.resultsBox.Text = "";
                    this.input = string.Empty;
                    this.operand1 = string.Empty;
                    this.operand2 = string.Empty;
                    MessageBox.Show("Cannot divide by zero");
                }

            }
        }
    }
}
