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
    public partial class MyBank : Form
    {
        public MyBank()
        {
            InitializeComponent();
        }

        // Connects the forms.
        Admin_Login Admin_Loginform = new Admin_Login(); 
        ATM ATMform = new ATM();
        LoanQualify LoanQualifyForm = new LoanQualify();


        private void Admin_button_Click(object sender, EventArgs e)
        {
            Admin_Loginform.ShowDialog(); // Displays Admin_login Form.
        }

        private void atmbutton_Click(object sender, EventArgs e)
        {
            ATMform.ShowDialog(); // Displays ATM form.
        }

        private void loanButton_Click(object sender, EventArgs e)
        {
            LoanQualifyForm.ShowDialog(); // Displays LoanQualify Form.
        }
    }
}
