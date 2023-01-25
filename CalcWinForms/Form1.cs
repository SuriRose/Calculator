using CalculatorApp;

namespace CalcWinForms
{
    public partial class Form1 : Form
    {
        //
        Calculator activecalc = new Calculator();
       Calculator calc1 = new Calculator();
       Calculator calc2 = new Calculator();
       Calculator calc3 = new Calculator();
        public Form1()
        {
            InitializeComponent();
            btn0.Click += BtnEquation_Click;
            btn1.Click += BtnEquation_Click;
            btn2.Click += BtnEquation_Click;
            btn3.Click += BtnEquation_Click;
            btn4.Click += BtnEquation_Click;
            btn5.Click += BtnEquation_Click;
            btn6.Click += BtnEquation_Click;
            btn7.Click += BtnEquation_Click;
            btn8.Click += BtnEquation_Click;
           // btn9.Click += BtnEquation_Click;
            btnDivide.Click += BtnEquation_Click;
            btnTimes.Click += BtnEquation_Click;
            btnSubtract.Click += BtnEquation_Click;
            btnPlus.Click += BtnEquation_Click;
            btnClear.Click += BtnClear_Click;
            btnEqual.Click += BtnEquals_Click;
            optCalc1.Click += OptCalc1_Click;
            optCalc2.Click += OptCalc2_Click;
            optCalc3.Click += OptCalc3_Click;
            SwitchCalculator(1);
            activecalc = new Calculator();
        }

        private void OptCalc3_Click(object? sender, EventArgs e)
        {
            SwitchCalculator(3);
        }

        private void OptCalc2_Click(object? sender, EventArgs e)
        {
            SwitchCalculator(2);
        }

        private void OptCalc1_Click(object? sender, EventArgs e)
        {
            SwitchCalculator(1);
        }

        private void DisplayCalculatorValues()
        {
            lblFactor1.Text = activecalc.Factor1.ToString();
            lblFactor2.Text = activecalc.Factor2.ToString();
            lblOperator.Text = activecalc.OperatorDisplay;
            lblResult.Text = activecalc.Result.ToString();
        }

        private void InputFactor(string value)
        {
            activecalc.AddInput(value);
            DisplayCalculatorValues();
        }

        private void Calculate()
        {
            activecalc.Calculate();
            DisplayCalculatorValues();
        }

        private void ClearCalculator()
        {
            activecalc.Clear();
            DisplayCalculatorValues();
        }

        private void SwitchCalculator(int value)
        {
            switch (value)
            {
                case 1:
                    activecalc = calc1;
                    break;
                case 2:
                    activecalc = calc2;
                    break;
                case 3:
                    activecalc = calc3;
                    break;
            }
            DisplayCalculatorValues();
        }
        private void BtnEquation_Click(object? sender, EventArgs e)
        {
            InputFactor(((Button)sender).Text);
        }
        private void BtnEquals_Click(object? sender, EventArgs e)
        {
            this.Calculate();

        }
        private void BtnClear_Click(object? sender, EventArgs e)
        {
            this.ClearCalculator();
        }


    }
}

