using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace MortageCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        // Sets variables to be used later
        double LoanAmount;
        double NumberOfMonths;
        double MonthlyRate;
        double MonthlyPayment;
        double totalPayment;
        double totalLoan;
        double count = 0;

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            try {
                // Gets inputted numbers and converts them to doubles.
                MonthlyRate = double.Parse(annualInterestTextBox.Text) / 100 / 12; 
                LoanAmount = double.Parse(amountLoanTextBox.Text);
                NumberOfMonths = double.Parse(numberYearsTextBox.Text) * 12;

                // PMT equation.
                double denominator = Math.Pow((1 + MonthlyRate), NumberOfMonths) - 1;
                MonthlyPayment = (MonthlyRate + (MonthlyRate / denominator)) * LoanAmount;

                // Displays the monthly payment in dollar format.
                monthlyPaymentLabel.Text = MonthlyPayment.ToString("C");

                // Adds each inputted loan amount together and displays in dollar format.
                totalLoan += LoanAmount;
                totalLoansLabel.Text = totalLoan.ToString("C");

                // Adds each monthly payment found together and displays in dollar format.
                totalPayment += MonthlyPayment;
                totalMonthlyPaymentsLabel.Text = totalPayment.ToString("C");

                // counts every time the calculate button is clicked.
                count++;

                // Divides the totalPayments by the count to find the average monthly payment.
                // Displays that number in dollars.
                double average = totalPayment / count;
                averageMonthlyPaymentsLabel.Text = average.ToString("C");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please enter only numbers");
            }

        }
        private void clearButton_Click(object sender, EventArgs e)
        {
            // Clears all inputs except those in the summary box
            //And sets the focus to amountLoanTextBox
            amountLoanTextBox.Text = "";
            annualInterestTextBox.Text = "";
            numberYearsTextBox.Text = "";
            monthlyPaymentLabel.Text = "";
            salaryTextBox.Text = "";
            yearsWorkedTextBox.Text = "";
            decisionLabel.Text = "";
            amountLoanTextBox.Focus();

        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // Closes Application.
            this.Close();
        }

        private void qualifyButton_Click(object sender, EventArgs e)
        {
            // Variables of need requirments.
            const decimal MINIMUM_SALARY = 40000m;
            const int MINIMUM_YEARS_ON_JOB = 2;

            //Local Variables
            decimal salary;
            int yearsOnJob;

            try { 
            // Get the Salary and years on the job
            salary = decimal.Parse(salaryTextBox.Text);
            yearsOnJob = int.Parse(yearsWorkedTextBox.Text);

            
                // Determine whether the user qualifies
                if (yearsOnJob >= 5)

                {
                    decisionLabel.Text = "You qualify for the loan.";

                }
                else

                if (salary >= MINIMUM_SALARY)
                {
                    if (yearsOnJob >= MINIMUM_YEARS_ON_JOB)
                    {
                        // The user qualifies
                        decisionLabel.Text = "You qualify for the loan.";
                    }

                    else
                    {
                        // The user does not qualify
                        decisionLabel.Text = " Minimum years at current" + " job not met.";
                    }

                }
                else
                {
                    // The user does not qualify
                    decisionLabel.Text = "Minimum salary requirement" + " not met.";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please try again");
            }
        }
    }
}
