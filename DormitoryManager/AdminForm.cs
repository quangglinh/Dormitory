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
    }
}
