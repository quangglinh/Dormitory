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
    public partial class ComplainForm : Form
    {
        Student theStudent;
        public ComplainForm()
        {
            InitializeComponent();
        }
        public ComplainForm(Student theStudent)
        {
            InitializeComponent();
            this.theStudent = theStudent;
        }

        private void ComplainForm_Load(object sender, EventArgs e)
        {
            // load data
            loadData();
        }
        public void loadData()
        {
            StudentDAL studentDAL = new StudentDAL();
            RoomDAL roomDAL = new RoomDAL();
            Slot slot = roomDAL.getSlotByStudentID(theStudent.studentID);
            nameField.Text = theStudent.name;
            idField.Text = theStudent.studentID;
            slotField.Text = slot.slotNumber.ToString();
            roomField.Text = slot.roomID;


        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (contentField.Text == "")
            {
                MessageBox.Show("Content can't be empty!", "Inform", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            } else
            {
                // insert to database

                bool successInsert = new RequestDAL().addComplain(theStudent.studentID, slotField.Text, roomField.Text, contentField.Text, "1");
                if(successInsert)
                {
                    MessageBox.Show("Request has sent!", "Inform", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                } else
                {
                    MessageBox.Show("Send fail", "Inform", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                
            }
        }
    }
}
