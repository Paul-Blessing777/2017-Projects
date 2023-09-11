using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Administrator
{
    public partial class Admin_Login : Form
    {
        public Admin_Login()
        {
            InitializeComponent();
        }
        string username = "Paul";
        string password = "Blessing";
        DB_backup_and_restore DB_backup_and_restoreForm = new DB_backup_and_restore();



        private void loginButton_Click(object sender, EventArgs e)
        {
            if (usernameTextBox.Text == username)
            {
                if (passwordTextBox.Text == password)
                {
                    DB_backup_and_restoreForm.ShowDialog();
                }
            }
            else
            {
                MessageBox.Show("Incorrect username or password, please try again");
            }
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            // Closes the form
            this.Close();
        }

        private void usernameTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
