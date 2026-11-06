using System;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        private double _firstNumber = 0;
        private string _operation = "";
        private bool _startNewNumber = true;

        public Form1()
        {
            InitializeComponent();
            txtDisplay.Text = "0";
        }

        private void Digit_Click(object sender, EventArgs e)
        {
            string digit = ((Button)sender).Text;

            if (_startNewNumber || txtDisplay.Text == "0")
            {
                txtDisplay.Text = digit;
                _startNewNumber = false;
            }
            else
            {
                txtDisplay.Text += digit;
            }
        }

        private void Decimal_Click(object sender, EventArgs e)
        {
            if (_startNewNumber)
            {
                txtDisplay.Text = "0.";
                _startNewNumber = false;
            }
            else if (!txtDisplay.Text.Contains("."))
            {
                txtDisplay.Text += ".";
            }
        }

        private void Operator_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            // Chain operations: 2 + 3 + ... computes 5 first
            if (_operation != "" && !_startNewNumber)
                Calculate();

            double parsed;
            if (!double.TryParse(txtDisplay.Text, out parsed))
                parsed = 0;
            _firstNumber = parsed;

            switch (btn.Name)
            {
                case "btnAdd": _operation = "+"; break;
                case "btnSub": _operation = "-"; break;
                case "btnMul": _operation = "*"; break;
                case "btnDiv": _operation = "/"; break;
                default: _operation = ""; break;
            }

            _startNewNumber = true;
        }

        private void Equals_Click(object sender, EventArgs e)
        {
            if (_operation == "") return;
            Calculate();
            _operation = "";
            _startNewNumber = true;
        }

        private void Calculate()
        {
            double second;
            if (!double.TryParse(txtDisplay.Text, out second))
                second = 0;
            double result = 0;

            switch (_operation)
            {
                case "+": result = _firstNumber + second; break;
                case "-": result = _firstNumber - second; break;
                case "*": result = _firstNumber * second; break;
                case "/":
                    if (second == 0)
                    {
                        txtDisplay.Text = "Cannot divide by 0";
                        _operation = "";
                        _firstNumber = 0;
                        _startNewNumber = true;
                        return;
                    }
                    result = _firstNumber / second;
                    break;
            }

            txtDisplay.Text = result.ToString();
            _firstNumber = result;
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = "0";
            _firstNumber = 0;
            _operation = "";
            _startNewNumber = true;
        }

        private void Negate_Click(object sender, EventArgs e)
        {
            double v;
            if (double.TryParse(txtDisplay.Text, out v))
                txtDisplay.Text = (-v).ToString();
        }

        private void Percent_Click(object sender, EventArgs e)
        {
            double v;
            if (double.TryParse(txtDisplay.Text, out v))
                txtDisplay.Text = (v / 100).ToString();
        }
    }
}