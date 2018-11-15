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

        }

        private void button1_Click(object sender, EventArgs e)
        {
            new RoomInfoForm().Show();
        }

        private void StudentRequests_Click(object sender, EventArgs e)
        {
            new ViewStudentRequest().Show();
        }

        private void button2_Click(object sender, EventArgs e) {
            var tmp = new StudentCheckin();
            tmp.Show();
            tmp.Import("se01107", new AppCode.Slot() { RoomID = "A101", Number = 2 });
            //tmp.Import("se01107", new AppCode.Slot() { RoomID = "A101", Number = 1 });
        }

        private void button3_Click(object sender, EventArgs e) {
            var tmp = new StudentCheckout();
            tmp.Show();
            tmp.Import("se00100", new AppCode.Slot() { RoomID = "A101", Number = 1 });
            //tmp.Import("se00100", new AppCode.Slot() { RoomID = "A102", Number = 1 });

        }

        private void button4_Click(object sender, EventArgs e) {
            new UpdateStudentStatus().Show();
        }

        private void button5_Click(object sender, EventArgs e) {
            ChangeRoom ttmp = new ChangeRoom();
            ttmp.Show();
            ttmp.Import("se05177", new AppCode.Slot() { Number = 3, RoomID = "A107" }, new AppCode.Slot() { Number = 4, RoomID = "A107" });

        }
    }
}
