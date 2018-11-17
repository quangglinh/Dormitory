using DormintoryStudentApp.Entity;
using DormintoryStudentApp.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DormintoryStudentApp.UI
{
    public partial class ChangePasswordForm : Form
    {
        public ChangePasswordForm()
        {
            InitializeComponent();
        }
        StudentAccount theAccount;
        public ChangePasswordForm(StudentAccount theAccount)
        {
            InitializeComponent();
            this.theAccount = theAccount;
            messageLabel.Text = "";
        }

        private void ChangePasswordForm_Load(object sender, EventArgs e)
        {
            nameLabel.Text = theAccount.username;
        }

        private void saveChangeButton_Click(object sender, EventArgs e)
        {
            if (currentPassField.Text=="" || newPassField.Text=="" || confirmPassField.Text == "")
            {
                messageLabel.ForeColor = Color.Yellow;
                messageLabel.Text = "All Field Required!";
                return;
            } 
            else if (!( new StudentAccountDAL().validCurrentPassword(currentPassField.Text, theAccount.username) ) )
            {
                messageLabel.ForeColor = Color.Yellow;
                messageLabel.Text = "Current password is not correct!";
                return;
            } else if (!(new StudentAccountDAL().validConfirmPassword(newPassField.Text, confirmPassField.Text)))
            {
                messageLabel.ForeColor = Color.Yellow;
                messageLabel.Text = "Confirm password is not match!";
                return;
            } else
            {
                bool successChange = new StudentAccountDAL().changePassword(newPassField.Text, theAccount.studentID);
                if(successChange)
                {
                    messageLabel.ForeColor = Color.GreenYellow;
                    messageLabel.Text = "Change successfully";
                    return;
                } else
                {
                    messageLabel.ForeColor = Color.Yellow;
                    messageLabel.Text = "Change fail!";
                    return;
                }
            }
        }

        private void nameLabel_Click(object sender, EventArgs e)
        {

        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
