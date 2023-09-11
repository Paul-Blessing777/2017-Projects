using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace MyBank1
{
    struct customersEntry // Creates structure for customers file.
    {
        public int customerID;
        public string firstName;
        public string lastName;
        public int accountID;
    }

    struct loansEntry // Creates structure for loans file.
    {
        public int customerID;
        public int loanID;
        public int loanType;
        public double amount;
        public int years;
        public double interestRate;
    }

    struct accountsEntry // Creates structure for accounts file.
    {
        public int accountID;
        public double accountNumber;
        public int type;
        public double amount;
    }
    public partial class DB_backup_and_restore : Form
    {
        public DB_backup_and_restore()
        {
            InitializeComponent();
        }

        private List<customersEntry> customersList =
           new List<customersEntry>(); // Creates list for customers file.

        private List<loansEntry> loansList =
           new List<loansEntry>(); // Creates list for loans file.

        private List<accountsEntry> accountsList =
          new List<accountsEntry>(); // Creates list for accounts file.

        private void Restorecustomer() // Method reads from the customers file
                                       //and splits the data into lists.
        {


            customersList.Clear(); // Clears the list.
            foreach (string line in File.ReadLines("customers.txt")) // Goes through each line in the
                                                                     // file.
            {
                string[] values = line.Split(',');
                var customer = new customersEntry // Splits the data.
                {
                    customerID = int.Parse(values[0]),
                    firstName = values[1],
                    lastName = values[2],
                    accountID = int.Parse(values[3]),
                };

                customersList.Add(customer); // Updates the list.

            }

        }
        private void RestoreLoans() // Method reads from the loans file
                                    //and splits the data into lists.
        {
            loansList.Clear(); // Clears the list.
            foreach (string line in File.ReadLines("loans.txt")) // Goes through each line in the
                                                                 // file.
            {
                string[] values = line.Split(',');
                var loans = new loansEntry // Splits the data.
                {
                    customerID = int.Parse(values[0]),
                    loanID = int.Parse(values[1]),
                    loanType = int.Parse(values[2]),
                    amount = double.Parse(values[3]),
                    years = int.Parse(values[4]),
                    interestRate = double.Parse(values[5]),

                };
                loansList.Add(loans); // Updates the list.



            }
        }

        private void Restoreaccounts() // Method reads from the accounts file
                                       //and splits the data into lists.
        {
            accountsList.Clear(); // Clears the list.
            foreach (string line in File.ReadLines("accounts.txt")) //Goes through each line in the
                                                                    // file.
            {
                string[] values = line.Split(',');
                var accounts = new accountsEntry // Splits the data.
                {
                    accountID = int.Parse(values[0]),
                    accountNumber = double.Parse(values[1]),
                    type = int.Parse(values[2]),
                    amount = double.Parse(values[3]),


                };
                accountsList.Add(accounts); // Updates the list.
            }
        }

        private void BackupCustomers() // Method uses updated lists to put split data into
                                       // a backup file.
        {
            using (StreamWriter outputFile = File.CreateText("customers_backup.txt")) // Creates new file.
            {
                foreach (var item in customersList) // Goes through the list.
                {
                    outputFile.WriteLine(item.customerID + "," + // Writes each item into the file delimenated 
                                                                 // with commas.
                                    item.firstName + "," +
                                    item.lastName + "," +
                                    item.accountID);
                }
            }
        }

        private void BackupLoans() // Method uses updated lists to put split data into
                                   // a backup file.
        {
            using (StreamWriter outputFile = File.CreateText("loans_backup.txt")) // Creates new file.
            {
                foreach (var item in loansList) // Goes through the list.
                {
                    outputFile.WriteLine(item.customerID + "," + // Writes each item into the file delimenated 
                                                                 // with commas.
                                    item.loanID + "," +
                                    item.loanType + "," +
                                    item.amount + "," +
                                    item.years + "," +
                                    item.interestRate);
                }
            }
        }

        private void BackupAccounts() // Method uses updated lists to put split data into
                                      // a backup file.
        {
            using (StreamWriter outputFile = File.CreateText("accounts_backup.txt")) // Creates new file.
            {
                foreach (var item in accountsList) // Goes through the list.
                {
                    outputFile.WriteLine(item.accountID + "," + // Writes each item into the file delimenated 
                                                                // with commas.
                                    item.accountNumber + "," +
                                    item.type + "," +
                                    item.amount);
                }
            }
        }
        private void restoreButton_Click(object sender, EventArgs e)
        {
            Restorecustomer();
            RestoreLoans();
            Restoreaccounts();
        }

        private void backupButton_Click(object sender, EventArgs e)
        {
            BackupCustomers();
            BackupLoans();
            BackupAccounts();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            // Closes the form
            this.Close();
        }
    }
}
