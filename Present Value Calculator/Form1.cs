using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/* 
 Spencer Henze
 ITM 225
 10/10/16
 */
namespace Present_Value_Calculator
{
    public partial class Form1 : Form
    {
        double pV, fV, enteredRate, rate, years;
       
        public Form1()
        {
            InitializeComponent();
        }

        // Begin Declaring Methods:

        private void GetValues() // this method simply calls the other methods to consolidate the fetching process and will be used later when the calculate button is clicked for concise logic.
        {
            //fV = double.Parse(goalAmtTextBox.Text);
            fV = GetFV();
            years = GetYears();
            enteredRate = GetEnteredRate();
            rate = ConvertRate();
            
        } // end GetValues() method

        private double GetFV() // this method fetches the fV from the user, validates that it is a number entry, then parses the value to the fV variable.
        {
            if (double.TryParse(goalAmtTextBox.Text, out fV))
            {
                return fV;
            }
            else // if a non-numerical entry is entered, this will throw an error, set the focus to the textbox that was incorrect, clear its value, and return a dummy value to be validated later.
            {
                MessageBox.Show("Please enter a numerical value in the first text box", "Invalid Entry", MessageBoxButtons.OK, MessageBoxIcon.Error);
                goalAmtTextBox.Focus();
                goalAmtTextBox.Text = "";
                fV = 0;         // these last two lines are important to keep the method happy, and to validate the entry when calculating pV.
                return fV;
            }
        } // end GetfV() method

        private double GetYears() // this method fetches the years value from the user, validates that it is a number entry, then parses the value to the years variable.
        {
            if (double.TryParse(yearsTextBox.Text, out years))
            {
                return years;
            }
            else
            {
                MessageBox.Show("Please enter a numerical value in the second text box", "Invalid Entry", MessageBoxButtons.OK, MessageBoxIcon.Error);
                yearsTextBox.Focus();
                yearsTextBox.Text = "";
                years = 0;     // these last two lines are important to keep the method happy, and to validate the entry when calculating pV.
                return years;  
            }
        } // end GetYears() method.

        private double GetEnteredRate() // this method fetches the intermediate entered rate from the user, validates that it is a number entry, then parses the value to the intermediate variable called "enteredRate".
        {
            if (double.TryParse(rateTextBox.Text, out enteredRate)) //validates that numbers were entered
            {
                return enteredRate;
            }
            else
            {
                MessageBox.Show("Please enter a numerical value in the third text box. \nAlso, make sure your rate is annualized!", "Invalid Entry", MessageBoxButtons.OK, MessageBoxIcon.Error);
                rateTextBox.Focus();
                rateTextBox.Text = "";
                enteredRate = 0;     // these last two lines are important to keep the method happy, and to validate the entry when calculating pV.
                return enteredRate;
            }
        } // end GetEnteredRate() method


        private double ConvertRate() // this method converts the rate entered by the user, or at this point the "enteredRate" variable, to a decimal to be used in the calculation
        {
            rate = enteredRate / 100;
            return rate;
        } // end ConvertRate() method

        private void CalculatePV() // this method calculates the PV
        {
            double inside = 1 + rate; // I don't know of a way to use an exponential operator, so I first calculate the exponential part by calculating what is inside the parenthesis so that the Math.Pow() method can run the exponential process on a single perameter.
            double denom = Math.Pow(inside, years); // this finishes calculating the denominator of the equation.
            pV = fV / denom; // now that we have a concise denominator, we can do a simple division.
        } //end CalculatePV() method

        private void ClearFields() // I made this a method of its own so that I could just call it in other methods.
        {
            goalAmtTextBox.Text = "";
            yearsTextBox.Text = "";
            rateTextBox.Text = "";
            resultDispLabel.Text = "";
        } // end ClearFields() method

        //begin click events:

        private void calculateButton_Click(object sender, EventArgs e) // Here's the meat and potatoes.
        {
            GetValues();
            CalculatePV();

            if (pV != 0 && years != 0 && enteredRate != 0) // this is to validate that no errors were thrown. If there was an error, one of these three variables will have been set to 0 and the result will not display.
            {
                resultDispLabel.Text = pV.ToString("C"); // display the result of the calculation by converting it to a string and formatting it as currency
            }

        } // end calculateButton Click event


        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        } // end exit button click event

        private void clearButton_Click(object sender, EventArgs e)
        {
            ClearFields(); // uses the ClearFields() method to clear all of the fields.
        }  // End clear button click event

    } // end class Form1
} // end Namespace Present_Value_Calculator
