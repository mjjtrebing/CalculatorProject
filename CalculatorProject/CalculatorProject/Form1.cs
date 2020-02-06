using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorProject
{
    public partial class CalculatorApp : Form
    {
        OperatorHandler mathTracker = new OperatorHandler();
        
        public CalculatorApp()
        {
            InitializeComponent();
            mathTracker = new OperatorHandler();
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        public void displayTracker(String boxSetter)
        {
            if (mathTracker.getResetValue())
            {
                displayBox.Text = "0";
                mathTracker.setResetValue(false);
            }

            if (displayBox.Text.Equals("0"))
            {
                if (boxSetter.Equals("."))
                {
                    displayBox.Text += boxSetter; //which will be "0."
                }
                else
                {
                    displayBox.Text = boxSetter;
                }
            }
            else
            {
                displayBox.Text += boxSetter;
            }
        }
        

        
        private void one_Box_Click(object sender, EventArgs e)
        {
           
                displayTracker("1");
            
        }

        private void two_Box_Click(object sender, EventArgs e)
        {
            
                displayTracker("2");
            
        }
        private void three_Box_Click(object sender, EventArgs e)
        {
                  
            displayTracker("3");
        }

        private void four_Box_Click(object sender, EventArgs e)
        {
         
                 displayTracker("4");
        }

        private void five_Box_Click(object sender, EventArgs e)
        {
           
          displayTracker("5");
        }

        private void six_Box_Click(object sender, EventArgs e)
        {
            displayTracker("6");
        }

        private void seven_Box_Click(object sender, EventArgs e)
        {
            displayTracker("7");
        }

        private void eight_Box_Click(object sender, EventArgs e)
        {
            displayTracker("8");
        }

        private void nine_Box_Click(object sender, EventArgs e)
        {
            displayTracker("9");
        }

        private void zero_Box_Click(object sender, EventArgs e)
        {
            displayTracker("0");
        }

        private void decimalPoint_Box_Click(object sender, EventArgs e)
        {

            if(displayBox.Text.Contains(".") ==false)
            {
                displayTracker(".");
            }
        }

        private void plus_Box_Click(object sender, EventArgs e)
        {
            mathTracker.populate(displayBox.Text);
            double result = mathTracker.addOperator("+");
            displayBox.Text = result.ToString();
        }

        private void equals_Box_Click(object sender, EventArgs e)
        {
            mathTracker.setFinalValue(displayBox.Text);
            if(mathTracker.isFull())
            {
                double result = mathTracker.searchHandler();
                displayBox.Text = result.ToString();
                mathTracker.clearCalcMemeory();
                mathTracker.setResetValue(true); //the value here must be set to true because once the next time a number is pressed this value is checked and if true, it will set the value to 0 again
            }
        }

        private void minus_Box_Click(object sender, EventArgs e)
        {
            mathTracker.populate(displayBox.Text);
            double result = mathTracker.addOperator("-");
            displayBox.Text = result.ToString();
        }

        private void divide_Box_Click(object sender, EventArgs e)
        {
            mathTracker.populate(displayBox.Text);
            double result = mathTracker.addOperator("/");
            
                displayBox.Text = result.ToString();
            
        }

        private void multiply_Box_Click(object sender, EventArgs e)
        {
            mathTracker.populate(displayBox.Text);
            double result = mathTracker.addOperator("*");
            displayBox.Text = result.ToString();
        }

        private void clear_Box_Click(object sender, EventArgs e)
        {
            mathTracker.clearCalcMemeory();
            displayBox.Text = "0";
        }

        private void clearEntry_Box_Click(object sender, EventArgs e)
        {
            displayBox.Text = "0";
        }

        private void deleteEntry_Box_Click(object sender, EventArgs e)
        {
            if (!displayBox.Text.Equals("0") && displayBox.Text.Length !=1)
            {
                displayBox.Text = displayBox.Text.Substring(0, displayBox.Text.Length - 1);
            }
            else
            {
                displayBox.Text = "0";
            }
        }

        private void shift_Box_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Currently this is a 4 function calculator. However, more mathmatical functions and a history button will be added later through the shift button.\n\n Happy Calculations!!");
        }
    }
}
