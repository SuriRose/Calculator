namespace CalcWinForms
{
    public partial class Form1 : Form
    {
        //
        calculator calc1 = new calculator();
        calculator calc2 = new calculator();
        calculator calc3 = new calculator();
        calculator calc4 = new calculator();
        public Form1()
        {
            InitializeComponent();
            btn0.Click += Btn0_Click;
            btn1.Click += Btn0_Click;
            btn2.Click += Btn0_Click;
            btn3.Click += Btn0_Click;
            btn4.Click += Btn0_Click;
            btn5.Click += Btn0_Click;
            btn6.Click += Btn0_Click;
            btn7.Click += Btn0_Click;
            btn8.Click += Btn0_Click;
            btn.Click += Btn0_Click;
        }

        private void Btn0_Click(object? sender, EventArgs e)
        {
            
        }

        private void DisplayCalculatorValue()
        {
            lblfirstfactor.text = activecalc.factor1.Tostring();
            lblsecoundfactor.text = activecalc.factor1.Tostring();
            lbloperator.text = activecalc.operator.Tostring();
            lblresult.text = activecalc.result.Tostring();
        }
        private void InputFactor(string value)
        {
            activecalc.AddInput(value);
            DisplayCalculatorValue();
        }

    }
}