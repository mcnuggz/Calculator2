using System;
using System.Windows.Forms;
using CalcFunctions;

namespace Calculator
{
    public partial class calcForm : Form
    {
        
        string input = string.Empty;
        string operand1 = string.Empty;
        string operand2 = string.Empty;
        char operation;
        double result = 0.0;

        public calcForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.resultsBox.Text = "";
            input += "7";
            this.resultsBox.Text += input;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.resultsBox.Text = "";
            input += "8";
            this.resultsBox.Text += input;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.resultsBox.Text = "";
            input += "9";
            this.resultsBox.Text += input;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            operand1 = input;
            operation = '/';
            input = string.Empty;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.resultsBox.Text = "";
            input += "4";
            this.resultsBox.Text += input;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.resultsBox.Text = "";
            input += "5";
            this.resultsBox.Text += input;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.resultsBox.Text = "";
            input += "6";
            this.resultsBox.Text += input;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            operand1 = input;
            operation = '*';
            input = string.Empty;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.resultsBox.Text = "";
            input += "1";
            this.resultsBox.Text += input;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.resultsBox.Text = "";
            input += "2";
            this.resultsBox.Text += input;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            this.resultsBox.Text = "";
            input += "3";
            this.resultsBox.Text += input;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            operand1 = input;
            operation = '+';
            input = string.Empty;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            this.resultsBox.Text = "";
            this.input = string.Empty;
            this.operand1 = string.Empty;
            this.operand2 = string.Empty;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            this.resultsBox.Text = "";
            input += "0";
            this.resultsBox.Text += input;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            this.resultsBox.Text = "";
            input += ".";
            this.resultsBox.Text += input;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            operand1 = input;
            operation = '-';
            input = string.Empty;
        }

        private void btn_equals_Click(object sender, EventArgs e)
        {
            operand2 = input;
            double num1, num2;
            double.TryParse(operand1, out num1);
            double.TryParse(operand2, out num2);

            if (operation == '+')
            {
                CalcFunctions.Calculator.DoSomeMath(num1, operation, num2);
                resultsBox.Text = result.ToString();
            }
            else if (operation == '-')
            {
                result = num1 - num2;
                resultsBox.Text = result.ToString();
            }
            else if (operation == '*')
            {
                result = num1 * num2;
                resultsBox.Text = result.ToString();
            }
            else if (operation == '/')
            {
                
            }
        }
    }
}
