using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorApp
{
    public class Calculator
    {
        public enum OperatorEnum { None, Plus, Subtract, Multiply, Divide }
        public void AddInput(string value)
        {
            int n = 0;
            bool b = int.TryParse(value, out n);
            if (b == true)
            {
                if (this.Factor1 != null && this.Operator != OperatorEnum.None)
                {
                    this.Factor2 = AddInputToFactor(this.Factor2, n);
                }
                else
                {
                    this.Factor1 = AddInputToFactor(this.Factor1, n);
                }
            }
            else
            {
                switch (value.ToLower())
                {
                    case "+":
                        this.Operator = OperatorEnum.Plus;
                        break;
                    case "-":
                        this.Operator = OperatorEnum.Subtract;
                        break;
                    case "*":
                    case "x":
                        this.Operator = OperatorEnum.Multiply;
                        break;
                    case "/":
                    case "\\":
                        this.Operator = OperatorEnum.Divide;

                        break;
                }
            }
        }
        private decimal? AddInputToFactor(decimal? currentval, int newval)
        //if currentval = blank(null/0) set newval else concatenate newval on newval as string tryparse into currentval
        {
            if (currentval == null || currentval == 0) { currentval = newval; }
            else
            {
                string s = currentval.ToString() + newval.ToString();
                decimal n;
                decimal.TryParse(s, out n);
                currentval = n;
            }
            return currentval;
        }
        public string OperatorDisplay
        {
            get
            {
                string val = "";
                switch (this.Operator)
                {
                    case OperatorEnum.Subtract:
                        val = "-";
                        break;
                    case OperatorEnum.Plus:
                        val = "+";
                        break;
                    case OperatorEnum.Multiply:
                        val = "*";
                        break;
                    case OperatorEnum.Divide:
                        val = "/";
                        break;
                }
                return val;
            }
        }
        public decimal? Calculate()
        {
            decimal? val = 0;
            switch (this.Operator)
            {
                case OperatorEnum.Divide:
                    val = this.Factor1 / this.Factor2;
                    break;
                case OperatorEnum.Plus:
                    val = this.Factor1 + this.Factor2;
                    break;
                case OperatorEnum.Subtract:
                    val = this.Factor1 - this.Factor2;
                    break;
                case OperatorEnum.Multiply:
                    val = this.Factor1 * this.Factor2;
                    break;
            }
            this.Result = val;
            return val;
        }
        public void Clear()
        {
            this.Factor1 = null;
            this.Factor2 = null;
            this.Operator = OperatorEnum.None;
            this.Result = null;
        }
        public string EquationText
        {
            get
            {
                return $"{Factor1} {OperatorDisplay} {Factor2} {"="} {Result}";
            }
        }
        public decimal? Factor1 { get; set; }
        public decimal? Factor2 { get; set; }
        public OperatorEnum Operator { get; set; }
        public decimal? Result { get; private set; }
    }
}
