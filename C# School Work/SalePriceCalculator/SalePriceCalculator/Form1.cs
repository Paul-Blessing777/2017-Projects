﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalePriceCalculator
{
    public partial class Form1 : Form
    {
        //Constant Fields
        const decimal FIVE_CENTS_VALUE = 0.05m;
        const decimal TEN_CENTS_VALUE = 0.10m;
        const decimal TWENTY_FIVE_CENTS_VALUE = 0.25m;
        const decimal FIFTY_CENTS_VALUE = .50m;

        //Field variable to olf the total
        // initalized with 0.
        private decimal total = 0m;

        public Form1()
        {
            InitializeComponent();
        }

        private void outputDescriptionLabel_Click(object sender, EventArgs e)
        {

        }

        private void fiveCentsPictureBox_Click(object sender, EventArgs e)
        {
            //Add the value of 5 cents to the total.
            total += FIVE_CENTS_VALUE;

            //Display the total, formatted as currency.
            TotalLabel.Text = total.ToString("c");
        }

        private void tenCentsPictureBox_Click(object sender, EventArgs e)
        {
            //Add the value of 10 cents to the total.
            total += TEN_CENTS_VALUE;

            //Display the total, formatted as currency.
            TotalLabel.Text = total.ToString("c");
        }

        private void twentyFiveCentsPictureBox_Click(object sender, EventArgs e)
        {
            //Add the value of 25 cents to the total.
            total += TWENTY_FIVE_CENTS_VALUE;

            //Display the total, formatted as currency.
            TotalLabel.Text = total.ToString("c");
        }

        private void fiftyCentsPictureBox_Click(object sender, EventArgs e)
        {
            //Add the value of 50 cents to the total.
            total += FIFTY_CENTS_VALUE;

            //Display the total, formatted as currency.
            TotalLabel.Text = total.ToString("c");
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            //Close the form.
            this.Close();
        }
    }
}
