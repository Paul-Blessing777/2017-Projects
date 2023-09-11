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
    public partial class ATM : Form
    {
        public ATM()
        {
            InitializeComponent();
        }

        double savings = 0;
        double checking = 0;
        double amount;

        private void DisplayBalances()
        {


            savingsLabel.Text = savings.ToString("C");
            checkingLabel.Text = checking.ToString("C");
        }

        private void depositButton_Click(object sender, EventArgs e)
        {
            try
            {


                if (savingsRadioButton.Checked)
                {
                    if (amount >= 0)

                    {
                        amount = double.Parse(amountTextBox.Text);

                        savings += amount;
                    }
                    else
                    {
                        MessageBox.Show("Please enter a positive number");
                    }
                }

                else if (checkingRadioButton.Checked)
                {
                    if (amount >= 0)

                    {
                        amount = double.Parse(amountTextBox.Text);

                        checking += amount;
                    }
                    else
                    {
                        MessageBox.Show("Please enter a positive number");
                    }
                }

                DisplayBalances();



            }
            catch (Exception ex)
            {
                MessageBox.Show("There was an error try again");
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {


                if (savingsRadioButton.Checked)
                {
                    if (amount >= 0)
                    {
                        if (amount <= savings)
                        {


                            amount = double.Parse(amountTextBox.Text);

                            savings -= amount;
                        }

                        else
                        {
                            MessageBox.Show("Not enough funds");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please enter a positive number");
                    }
                }






                else if (checkingRadioButton.Checked)
                {
                    if (amount >= 0)
                    {
                        if (amount <= checking)
                        {


                            amount = double.Parse(amountTextBox.Text);

                            checking -= amount;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please enter a positive number");
                    }
                }
                else
                {
                    MessageBox.Show("Not enough funds");
                }


                DisplayBalances();
            }
            catch (Exception ex)
            {
                MessageBox.Show("There was an error try again");
            }


        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            // Clears the amount box.
            amountTextBox.Text = "";

            // Reset the focus
            amountTextBox.Focus();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // Closes the form.
            this.Close();
        }
    }
}
