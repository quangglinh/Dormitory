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

        public RoomStatus(ManagementForm parentForm)
        {
            InitializeComponent();
        }
        //public void initialValue (StudentInfomation Student)
        //{
        //    txtStudentName.Text = Student.name;
        //    txtStudentID.Text = Student.studentID;
        //    txtDom.Text = Student.dom.ToUpper();
        //    txtSlotNumber.Text = Student.slotNumber.ToString();
        //}
        private void btnRequest_Click(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
