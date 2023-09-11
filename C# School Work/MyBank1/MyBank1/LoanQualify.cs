using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyBank1
{
    public partial class LoanQualify : Form
    {
        public LoanQualify()
        {
            InitializeComponent();
        }

        Mortage MortageForm = new Mortage();

        // The number digits method accepts a string arguement
        // and returns the number of numeric digits it contains.
        private int NumberDigits(string str)
        {
            int digits = 0; // the number of digits

            // Count the digits in str
            foreach (char ch in str)
            {
                if (char.IsDigit(ch))
                {
                    digits++;
                }
            }
            // Return the number of digits.
            return digits;
        }
        private void submitButton_Click(object sender, EventArgs e)
        {
            MortageForm.ShowDialog();
            /// I had to comment this out because it wasn't working properly.
            //string firstName = firstNameTextBox.Text;
            //string firstNameCheck = "xxxxxxxxxxxxxxxxxxxx";
            //string lastName = lastNameTextBox.Text;
            //string lastNameCheck = "xxxxxxxxxxxxxxxxxxxxxxxxxxxxxx";
            //string MI = miTextBox.Text;
            //string MICheck = "xx";
            //string number = numberTextBox.Text;
            //string city = cityTextBox.Text;
            //string street = streetTextBox.Text;
            //string employer = employerTextBox.Text;
            //// Variables of need requirments.
            //const decimal MINIMUM_SALARY = 40000m;
            //const int MINIMUM_YEARS_ON_JOB = 2;

            ////Local Variables
            //decimal salary;
            //int yearsOnJob;

            //try
            //{
            //    // Get the Salary and years on the job
            //    salary = decimal.Parse(salaryTextBox.Text);
            //    yearsOnJob = int.Parse(yearsTextBox.Text);


            // Determine whether the user qualifies

            //        if (lastName.Length <= NumberDigits(lastNameCheck))
            //        {
            //            if (firstName.Length <= NumberDigits(firstNameCheck))
            //            {
            //                if (MI.Length <= NumberDigits(MICheck))
            //                {
            //                    if (city.Length <= NumberDigits(firstNameCheck))
            //                    {
            //                        if (street.Length <= NumberDigits(firstNameCheck))
            //                        {
            //                            if (yearsOnJob >= 5)

            //                            {
            //                                decisionLabel.Text = "You qualify for the loan.";

            //                            }
            //                            else

            //        if (salary >= MINIMUM_SALARY)
            //                            {
            //                                if (yearsOnJob >= MINIMUM_YEARS_ON_JOB)
            //                                {
            //                                    // The user qualifies
            //                                    decisionLabel.Text = "You qualify for the loan.";
            //                                }

            //                                else
            //                                {
            //                                    // The user does not qualify
            //                                    decisionLabel.Text = " Minimum years at current" + " job not met.";
            //                                }

            //                            }
            //                            else
            //                            {
            //                                // The user does not qualify
            //                                decisionLabel.Text = "Minimum salary requirement" + " not met.";
            //                            }
            //                        }
            //                    }
            //                }
            //            }
            //        }
            //    }
            //    catch (Exception ex)
            //    {
            //        MessageBox.Show("Please try again");
            //    }
            //}
        }
    

    private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
                               
                        }

                    
                
                
           
        
    

