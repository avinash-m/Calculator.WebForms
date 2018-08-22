using System;
using System.Web.UI;
using MathLibrary;

namespace Calculator.WinForms
{
    public partial class CalculatorForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!Page.IsPostBack)
            {
                rbtnOperator.Items.Add("+");
                rbtnOperator.Items.Add("-");
                rbtnOperator.Items.Add("*");
                rbtnOperator.Items.Add("/");
                rbtnOperator.Items.Add("%");
            }
        }

        protected void btnCalculate_Click(object sender, EventArgs e)
        {
            double firstNumber = Convert.ToDouble(txtNumber1.Text);
            double secondNumber = Convert.ToDouble(txtNumber2.Text);

            double result = 0.0D;

            switch (rbtnOperator.Text)
            {
                case "+":
                    result = MathOperations.Addition(firstNumber, secondNumber);
                    break;
                case "-":
                    result = MathOperations.Subtraction(firstNumber, secondNumber);
                    break;
                case "*":
                    result = MathOperations.Multiplication(firstNumber, secondNumber);
                    break;
                case "/":
                    result = MathOperations.Division(firstNumber, secondNumber);
                    break;
                case "%":
                    result = MathOperations.Remainder(firstNumber, secondNumber);
                    break;
                default:
                    break;
            }

            lblResult.Text = result.ToString();
        }
    }
}