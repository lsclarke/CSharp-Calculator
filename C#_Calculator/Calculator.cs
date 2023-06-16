using System;

namespace C__Calculator
{
    public partial class Calculator : Form
    {
        private decimal firstVal = 0.0m;
        private decimal secondVal = 0.0m;
        private decimal Results = 0.0m;
        private string operators = "+";

        public Calculator()
        {
            InitializeComponent();
        }

        public void InitializeInput(int Num)
        {
            if (TxtBox.Text == "0")
            {
                TxtBox.Text = "" + Num;
            }
            else
            {
                TxtBox.Text += "" + Num;
            }
        }

        private void ZeroBtn_Click(object sender, EventArgs e)
        {
            InitializeInput(0);
        }

        private void OneBtn_Click(object sender, EventArgs e)
        {
            InitializeInput(1);
        }

        private void TwoBtn_Click(object sender, EventArgs e)
        {
            InitializeInput(2);
        }

        private void ThreeBtn_Click(object sender, EventArgs e)
        {
            InitializeInput(3);
        }

        private void FourBtn_Click(object sender, EventArgs e)
        {
            InitializeInput(4);
        }

        private void FiveBtn_Click(object sender, EventArgs e)
        {
            InitializeInput(5);
        }

        private void SixBtn_Click(object sender, EventArgs e)
        {
            InitializeInput(6);
        }

        private void SevenBtn_Click(object sender, EventArgs e)
        {
            InitializeInput(7);
        }

        private void EightBtn_Click(object sender, EventArgs e)
        {
            InitializeInput(8);
        }

        private void NineBtn_Click(object sender, EventArgs e)
        {
            InitializeInput(9);
        }

        private void DotBtn_Click(object sender, EventArgs e)
        {
            if (!TxtBox.Text.Contains("."))
            {
                TxtBox.Text += ".";
            }
        }

        private void MinusBtn_Click(object sender, EventArgs e)
        {
            firstVal = decimal.Parse(TxtBox.Text);
            TxtBox.Clear();
            operators = "-";
        }

        private void PlusBtn_Click(object sender, EventArgs e)
        {
            firstVal = decimal.Parse(TxtBox.Text);
            TxtBox.Clear();
            operators = "+";
        }

        private void TimesBtn_Click(object sender, EventArgs e)
        {
            firstVal = decimal.Parse(TxtBox.Text);
            TxtBox.Clear();
            operators = "*";
        }

        private void DivideBtn_Click(object sender, EventArgs e)
        {
            firstVal = decimal.Parse(TxtBox.Text);
            TxtBox.Clear();
            operators = "/";
        }

        private void PercentageBtn_Click(object sender, EventArgs e)
        {
            firstVal = decimal.Parse(TxtBox.Text);
            TxtBox.Clear();
            operators = "%";
        }

        private void EqualBtn_Click(object sender, EventArgs e)
        {
            switch (operators)
            {
                case "-":

                    secondVal = decimal.Parse(TxtBox.Text);
                    Results = firstVal - secondVal;
                    TxtBox.Text = Results.ToString();
                    break;

                case "+":

                    secondVal = decimal.Parse(TxtBox.Text);
                    Results = firstVal + secondVal;
                    TxtBox.Text = Results.ToString();
                    break;

                case "/":

                    secondVal = decimal.Parse(TxtBox.Text);
                    Results = firstVal / secondVal;
                    TxtBox.Text = Results.ToString();
                    break;

                case "*":

                    secondVal = decimal.Parse(TxtBox.Text);
                    Results = firstVal * secondVal;
                    TxtBox.Text = Results.ToString();
                    break;

                case "%":

                    secondVal = decimal.Parse(TxtBox.Text);
                    Results = firstVal % secondVal;
                    TxtBox.Text = Results.ToString();
                    break;
            }
        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            TxtBox.Clear();
            firstVal = 0.0m;
            secondVal = 0.0m;
            Results = 0.0m;
            TxtBox.Text = "0";
        }
    }
}