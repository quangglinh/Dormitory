using DormintoryStudentApp.Entity;
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
    public partial class ManagementForm : Form
    {
        Student theStudent;
        StudentAccount theAccount;
        public ManagementForm()
        {
            InitializeComponent();
        }

        public ManagementForm(StudentAccount theAccount, Student theStudent)
        {
            InitializeComponent();
            this.theAccount = theAccount;
            this.theStudent = theStudent;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SearchRoom searchRoomForm = new SearchRoom();
            searchRoomForm.ShowDialog();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void ManagementForm_Load(object sender, EventArgs e)
        {
            lblHello.Text = "Welcome " + theStudent.name + ", " + theStudent.studentID.ToUpper();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            SignInForm signinForm = new SignInForm();
            signinForm.Show();
        }

        private void ManagementForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnRoomStatus_Click(object sender, EventArgs e)
        {
            RoomStatus roomStatusForm = new RoomStatus(this, theStudent.studentID);
            roomStatusForm.ShowDialog();
        }

        private void btnRoomExtra_Click(object sender, EventArgs e)
        {
            RoomExtra roomExtraForm = new RoomExtra(theStudent.studentID);
            roomExtraForm.ShowDialog();
        }
    }
}
