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
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
        }

        private void AddRoom_Click(object sender, EventArgs e)
        {
            new AddRoomForm().Show();
        }

        private void UpdateRoom_Click(object sender, EventArgs e)
        {
            new UpdateRoom().Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new RoomInfoForm().Show();
        }

        private void StudentRequests_Click(object sender, EventArgs e)
        {
            new ViewChangeRequest().Show();
        }

        private void button2_Click(object sender, EventArgs e) {
            var tmp = new StudentCheckin();
            tmp.Show();
        }

        private void button3_Click(object sender, EventArgs e) {
            var tmp = new StudentCheckout();
            tmp.Show();

        }

        private void button4_Click(object sender, EventArgs e) {
            new UpdateStudentStatus().Show();
        }

        private void button5_Click(object sender, EventArgs e) {
            ChangeRoom ttmp = new ChangeRoom();
            ttmp.Show();
        }

        private void btnLeaveRoomRequest_Click(object sender, EventArgs e)
        {
            new ViewLeaveRequest().Show();
        }
    }
}
