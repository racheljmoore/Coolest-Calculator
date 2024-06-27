using System;
using System.Diagnostics;
using System.Security.Cryptography.X509Certificates;
using static System.Windows.Forms.AxHost;

namespace Coolest_Calculator
{
    [DebuggerDisplay($"{{{nameof(GetDebuggerDisplay)}(),nq}}")]
    public partial class Form1 : Form
    {
        private CalculatorState _state;
        private double _firstNumber;
        public Form1()
        {
            InitializeComponent(GetLoad(GetLoad(GetLoad())));
            _state = CalculatorState.Result;
            _firstNumber = 0.0d;
            //by adding a d at the end of the number source allowed us to represent fractional
            //and whole numbers that very in integers
            //When the user inputs the first number the calculator will return back a zero prior to
            //the user entering the
            //second number because of the first number identifier
            //defaults


        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Results_TextChanged(object sender, EventArgs e)
        {

        }

        private string GetDebuggerDisplay()
        {
            return ToString();
        }
        private void ChangeCalculatorState(CalculatorState state)
        //setting the temp state into our perminate global state
        {
            _state = state;
            if (double.TryParse(Results.Text, out double result))
            {
                _firstNumber = result;
                Results.Text = "0";

                //creating a line of code to tell the calculator when we input
                //the first number and choose our function it results in a zero (as a holding space)
                //for the second number prior to recieving the solution
                //Since number is not recoginized D by putting it in " identifidied it as an input

            }

        }

        private void AddNumberDisplay(int number)
        {
            if (double.TryParse(Results.Text, out double result))
            {
                if (result == 0) { Results.Text = number.ToString(); }
                else { Results.Text = $"{Results.Text}{number}"; }
            }
            else
            {
                Results.Text = number.ToString();
            }
        }
        private void button_1_Click(object sender, EventArgs e)
        {
            AddNumberDisplay(1);


        }

        private void button_2_Click(object sender, EventArgs e)
        {
            AddNumberDisplay(2);
        }

        private void button_3_Click(object sender, EventArgs e)
        {
            AddNumberDisplay(3);
        }

        private void button_4_Click(object sender, EventArgs e)
        {
            AddNumberDisplay(4);
        }

        private void button_5_Click(object sender, EventArgs e)
        {
            AddNumberDisplay(5);
        }

        private void button_6_Click(object sender, EventArgs e)
        {
            AddNumberDisplay(6);
        }

        private void button_7_Click(object sender, EventArgs e)
        {
            AddNumberDisplay(7);
        }

        private void button_8_Click(object sender, EventArgs e)
        {
            AddNumberDisplay(8);
        }

        private void button_9_Click(object sender, EventArgs e)
        {
            AddNumberDisplay(9);
        }

        private void button_0_Click(object sender, EventArgs e)
        {
            if (double.TryParse(Results.Text, out double result))
            {
                double finalResult = 0.0d;
                switch (_state)
                {


                    case CalculatorState.Addition:
                        finalResult = _firstNumber + result;
                        Results.Text = finalResult.ToString();
                        break;
                        AddNumberDisplay(0);
                }
            }
//adding response to each number in the calculator 

        }

        private void Clear_Click(object sender, EventArgs e)
        {
            Results.Text = "Money";
        }

        private void button_plus_Click(object sender, EventArgs e)
        {
            ChangeCalculatorState(CalculatorState.Addition);


        }

        private void button_equals_Click(object sender, EventArgs e)
        {


            if (double.TryParse(Results.Text, out double result))
            {
                double finalResult = 0.0d;


                switch (_state)
                {


                    case CalculatorState.Addition:
                        finalResult = _firstNumber + result;
                        Results.Text = finalResult.ToString();
                        break;
                    case CalculatorState.Subtraction:
                        finalResult = _firstNumber - result;
                        Results.Text = finalResult.ToString();
                        break;
                    case CalculatorState.Multiply:
                        finalResult = _firstNumber * result;
                        Results.Text = finalResult.ToString();
                        break;
                    case CalculatorState.Divide:
                        finalResult = _firstNumber / result;
                        Results.Text = finalResult.ToString();
                        break;
                    case CalculatorState.Result:
                    default:


                        Results.Text = _firstNumber.ToString(); break;
                }

            }

        }

        private void button_subtract_Click(object sender, EventArgs e)
        {
            ChangeCalculatorState(CalculatorState.Subtraction);
        }

        private void button_multiply_Click(object sender, EventArgs e)
        {
            ChangeCalculatorState(CalculatorState.Multiply);

        }
    }
}


          

       