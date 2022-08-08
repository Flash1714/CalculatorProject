namespace CalculatorProject
{
    public partial class CalculatorProject : Form
    {
        string firstOp = "";
        string secondOp = "";
        char whatToDo;
        double result = 0.0;
        bool validCalc = true;
        public CalculatorProject()
        {
            InitializeComponent();
        }

        private void CalculatorProject_Load(object sender, EventArgs e)
        {
            
        }

        //For all buttons we add that chara to the CalcDisplay lable text
        private void btt1_Click(object sender, EventArgs e)
        {
            CalcDisplay.Text += "1";
        }

        private void btt2_Click(object sender, EventArgs e)
        {
            CalcDisplay.Text += "2";
        }

        private void btt3_Click(object sender, EventArgs e)
        {
            CalcDisplay.Text += "3";
        }

        private void btt4_Click(object sender, EventArgs e)
        {
            CalcDisplay.Text += "4";
        }

        private void btt5_Click(object sender, EventArgs e)
        {
            CalcDisplay.Text += "5";
        }

        private void btt6_Click(object sender, EventArgs e)
        {
            CalcDisplay.Text += "6";
        }

        private void btt7_Click(object sender, EventArgs e)
        {
            CalcDisplay.Text += "7";
        }

        private void btt8_Click(object sender, EventArgs e)
        {
            CalcDisplay.Text += "8";
        }

        private void btt9_Click(object sender, EventArgs e)
        {
            CalcDisplay.Text += "9";
        }

        private void btt0_Click(object sender, EventArgs e)
        {
            CalcDisplay.Text += "0";
        }

        private void bttDecimal_Click(object sender, EventArgs e)
        {
            CalcDisplay.Text += ".";
        }

        /*For operators when a button is clicked all data on the screen is taken as the first operand
         the WhatToDo operator is set to the button pressed and display is cleared.
         */
        private void bttPlus_Click(object sender, EventArgs e)
        {
            whatToDo = '+';
            firstOp = CalcDisplay.Text.ToString();
            CalcDisplay.Text = "";
        }

        private void bttMinus_Click(object sender, EventArgs e)
        {
            whatToDo = '-';
            firstOp = CalcDisplay.Text.ToString();
            CalcDisplay.Text = "";
        }

        private void bttMult_Click(object sender, EventArgs e)
        {
            whatToDo = '*';
            firstOp = CalcDisplay.Text.ToString();
            CalcDisplay.Text = "";
        }

        private void bttDiv_Click(object sender, EventArgs e)
        {
            whatToDo = '/';
            firstOp = CalcDisplay.Text.ToString();
            CalcDisplay.Text = "";
        }

        // Clear button just clears everything
        private void bttClear_Click(object sender, EventArgs e)
        {
            CalcDisplay.Text = "";
            firstOp = "";
            secondOp = "";
            result = 0.0;
        }

        // When equals is clicked convert both the operands to double and calculate result. Print result on
        // the text box. 

        private void bttEquals_Click(object sender, EventArgs e)
        {
            secondOp = CalcDisplay.Text.ToString();
            try
            {
                double test = Convert.ToDouble(firstOp) + Convert.ToDouble(secondOp);
            }
            catch(Exception)
            {
                CalcDisplay.Text = "You Dumb?";
                validCalc = false;
            }
            if (whatToDo == '+' && validCalc)
            {
                result = Convert.ToDouble(firstOp) + Convert.ToDouble(secondOp);
                CalcDisplay.Text = Convert.ToString(result);

            }
            else if (whatToDo == '-' && validCalc)
            {
                result = Convert.ToDouble(firstOp) - Convert.ToDouble(secondOp);
                CalcDisplay.Text = Convert.ToString(result);
            }
            else if (whatToDo == '*' && validCalc)
            {
                result = Convert.ToDouble(firstOp) * Convert.ToDouble(secondOp);
                CalcDisplay.Text = Convert.ToString(result);
            }
            else if (whatToDo == '/' && validCalc)
            {
                if (Convert.ToDouble(secondOp) == 0)
                {
                    CalcDisplay.Text = "Stop that";
                }
                else
                {
                    result = Convert.ToDouble(firstOp) / Convert.ToDouble(secondOp);
                    CalcDisplay.Text = Convert.ToString(result);
                }
                
            }
            

        }

        // removing last character of text for backspace
        private void bttBack_Click(object sender, EventArgs e)
        {
            string temp = CalcDisplay.Text.ToString();
            int length = temp.Length;
            CalcDisplay.Text = temp.Remove(length - 1);
        }
    }

}