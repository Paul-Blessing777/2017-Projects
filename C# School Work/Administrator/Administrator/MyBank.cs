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
    public partial class MyBank : Form
    {
        public MyBank()
        {
            InitializeComponent();
        }
        Admin_Login Admin_LoginForm = new Admin_Login();
        private void admin_Button_Click(object sender, EventArgs e)
        {
            Admin_LoginForm.ShowDialog();
        }
    }
}
