namespace CalculatorProject
{
    public partial class CalculatorProject : Form
    {
        string firstOp = "";
        string secondOp = "";
        char whatToDo;
        double result = 0.0;
        public CalculatorProject()
        {
            InitializeComponent();
        }

        private void CalculatorProject_Load(object sender, EventArgs e)
        {
            
        }

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

        private void bttClear_Click(object sender, EventArgs e)
        {
            CalcDisplay.Text = "";
            firstOp = "";
            secondOp = "";
            result = 0.0;
        }

        private void bttEquals_Click(object sender, EventArgs e)
        {
            secondOp = CalcDisplay.Text.ToString();
            if (whatToDo == '+')
            {
                result = Convert.ToDouble(firstOp) + Convert.ToDouble(secondOp);

            }
            else if (whatToDo == '-')
            {
                result = Convert.ToDouble(firstOp) - Convert.ToDouble(secondOp);
            }
            else if (whatToDo == '*')
            {
                result = Convert.ToDouble(firstOp) * Convert.ToDouble(secondOp);
            }
            else if (whatToDo == '/')
            {
                result = Convert.ToDouble(firstOp) / Convert.ToDouble(secondOp);
            }
            
            CalcDisplay.Text = Convert.ToString(result);

        }
    }

}