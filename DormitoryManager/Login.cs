using DormitoryManager.AppCode;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DormitoryManager
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            txtPassword.UseSystemPasswordChar = PasswordPropertyTextAttribute.Yes.Password;
        }

        private bool IsValidInput()
        {
            if(txtUserName.Text.Trim() == "" || txtUserName.Text.Trim() == " ")
            {
                MessageBox.Show("Username is empty!");
                return false;
            }
            if (txtPassword.Text.Trim() == "" || txtPassword.Text.Trim() == " ")
            {
                MessageBox.Show("Password is empty!");
                return false;
            }
            return true;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (IsValidInput())
            {
                DataTable dt = new DataAccess().LoadManager(txtUserName.Text, txtPassword.Text);
                if(dt.Rows.Count == 0)
                {
                    MessageBox.Show("username or password is incorrect!");
                    return;
                }
                new AdminForm().Show();
                this.Hide();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
