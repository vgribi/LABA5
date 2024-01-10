using System;
using System.Windows.Forms;

namespace SimpleCalculator
{
    public partial class CalculatorForm : Form
    {
        public CalculatorForm()
        {
            InitializeComponent();
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            string expression = txtInput.Text;

            try
            {
                double result = EvaluateExpression(expression);
                txtInput.Text = result.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private double EvaluateExpression(string expression)
        {
            char[] operators = { '+', '-', '*', '/' };
            string[] elements = expression.Split(operators);
            char operation = expression[elements[0].Length];
            double num1 = double.Parse(elements[0]);
            double num2 = double.Parse(elements[1]);

            switch (operation)
            {
                case '+':
                    return num1 + num2;
                case '-':
                    return num1 - num2;
                case '*':
                    return num1 * num2;
                case '/':
                    if (num2 == 0)
                        throw new ArgumentException("Division by zero is not allowed");
                    return num1 / num2;
                default:
                    throw new ArgumentException("Invalid operation");
            }
        }

        private void NumberButtonClick(object sender, EventArgs e)
        {
            Button button = sender as Button;
            txtInput.Text += button.Text;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtInput.Clear();
        }
    }
}

