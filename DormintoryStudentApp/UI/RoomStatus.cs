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
        public RoomStatus()
        {
            InitializeComponent();
        }
        Student theStudent;
        public RoomStatus(Student theStudent)
        {
            this.theStudent = theStudent;
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void RoomStatus_Load(object sender, EventArgs e)
        {
            // student infor
            studentInfoLabel.Text = theStudent.name + ", ID: " + theStudent.studentID.ToUpper();

            // grid data view
            DataTable statusTable = new StudentDAL().getStatus(theStudent.studentID);
            roomStatusDGV.DataSource = statusTable;
        }

        private void dgvStudentStatus_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            this.roomStatusDGV.Columns["studentID"].Visible = false;
            // style for header strip
            roomStatusDGV.Columns["month"].HeaderText = "MONTH";
            roomStatusDGV.Columns["year"].HeaderText = "YEAR";
            roomStatusDGV.Columns["electricCost"].HeaderText = "Electric Cost";
            roomStatusDGV.Columns["waterCost"].HeaderText = "Water Cost";
            roomStatusDGV.Columns["extraFee"].HeaderText = "Extra Fee";
            roomStatusDGV.Columns["extraFeeContent"].HeaderText = "Reason";

            // center text in gridview
            foreach (DataGridViewColumn col in roomStatusDGV.Columns)
            {
                col.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                col.HeaderCell.Style.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Pixel);
                col.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
        }
    }
}
