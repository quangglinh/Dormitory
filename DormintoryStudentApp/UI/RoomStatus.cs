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
    public partial class RoomStatus : Form
    {
        private ManagementForm parent;
        private string studentID;
        public RoomStatus(ManagementForm parentForm, string StudentID)
        {
            InitializeComponent();
            this.parent = parentForm;
            this.studentID = StudentID;
            initialValue();
        }
        public void initialValue ()
        {
            StudentDAL dao = new StudentDAL();
            StudentStatus student = dao.getStudentStatus(this.studentID);
            txtStudentName.Text = student.StudentName;
            txtStudentID.Text = student.StudentID;
            txtDom.Text = student.Dom.ToUpper();
            txtSlotNumber.Text = student.Slot.ToString();
            txtRoom.Text = student.Room.ToString();
        }
        private void btnRequest_Click(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void RoomStatus_Load(object sender, EventArgs e)
        {

        }
    }
}
