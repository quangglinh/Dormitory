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
    public partial class LeaveRoomRequestForm : Form
    {
        Student theStudent;
        public LeaveRoomRequestForm()
        {
            InitializeComponent();
        }

        public LeaveRoomRequestForm(Student theStudent)
        {
            InitializeComponent();
            this.theStudent = theStudent;
        }

        private void LeaveRoomRequestForm_Load(object sender, EventArgs e)
        {
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

        private void sendButton_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Do you really want to leave? \nYour request will be sent to the dom't manager", "Confirm", MessageBoxButtons.YesNo);
            if (confirmResult==DialogResult.No)
            {
                return;
            } else
            {
                bool successInsert = new RequestDAL().addLeaveRoomRequest(theStudent.studentID, slotField.Text, roomField.Text, "1");
                if(successInsert)
                {
                    MessageBox.Show("Request has sent", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                } else
                {
                    MessageBox.Show("Send fail", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
