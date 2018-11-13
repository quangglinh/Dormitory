using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DormitoryManager.AppCode;

namespace DormitoryManager {
    public partial class StudentCheckin : Form {
        public StudentCheckin() {
            InitializeComponent();
        }

        public void LoadCheckout() {

        }

        private void LoadStudents() {

            gbRoom.Enabled = false;
            Student student = new StudentAccess().GetStudent(txtStudentId.Text);
            if (student == null) {
                txtStudentMail.Text = txtStudentName.Text = txtStudentPhone.Text = "Not Found";
                lbAvailable.Text = "Not Found";
                lbAvailable.ForeColor = Color.Red;
                return;
            }
            txtStudentMail.Text = student.Email;
            txtStudentName.Text = student.Name;
            txtStudentPhone.Text = student.Phone;
            if (student.Id.Length > 0 &&  new StudentAccess().isStudentAvailable(txtStudentId.Text)) {
                lbAvailable.Text = "Available";
                lbAvailable.ForeColor = Color.Green;
                gbRoom.Enabled = true;
            } else {
                lbAvailable.Text = "Not Available";
                lbAvailable.ForeColor = Color.Red;
                LoadCheckout();
            }
        }
        private void StudentCheckin_Load(object sender, EventArgs e) {
            LoadRoom();
            LoadStudents();
        }

        

        private void LoadRoom() {
            DataTable rooms = new DataAccess().LoadRooms();
            cbRoom.DataSource = rooms;
            cbRoom.ValueMember = "roomID";
        }

        private void LoadSlot(string roomID) {
            DataTable dt = new DataAccess().LoadAvailableSlots(roomID);


            if (dt.Rows.Count == 0) {
                cbSlot.DataSource = null;
                cbSlot.Items.Clear();
                cbSlot.Enabled = false;
                cbSlot.Items.Add("No more space");
                return;
            }
            cbSlot.Enabled = true;
            cbSlot.DataSource = dt;
            cbSlot.ValueMember = "slotNumber";
            cbSlot.DisplayMember = "slotNumber";
            btnCheckin.Enabled = true;


        }

        private void cbRoom_SelectedIndexChanged(object sender, EventArgs e) {
            btnCheckin.Enabled = false;
            Room now = new StudentAccess().GetRoom(cbRoom.Text);
            if (now != null ) {
                txtDom.Text = now.Dom;
                txtFee.Text = now.Fee.ToString();
                txtMaxSlot.Text = now.NoSlot.ToString();
                LoadSlot(cbRoom.Text);
            } else {
                txtDom.Text = txtFee.Text = txtMaxSlot.Text = "Not Found";
                cbSlot.DataSource = null;
                cbSlot.Text = "Not available";
            }

        }



        private void txtStudentId_TextChanged(object sender, EventArgs e) {
            LoadStudents();
        }

        private void btnCheckin_Click(object sender, EventArgs e) {
            string studentID = txtStudentId.Text;
            string roomId = cbRoom.Text;
            int slot = int.Parse(cbSlot.Text);
            int result = new StudentAccess().Checkin(studentID, roomId, slot);
            if (result == 1) {
                MessageBox.Show("Checkin success");
            } else {
                MessageBox.Show("Checkin failed");
            }
            txtStudentId.Text = "";
            cbRoom.SelectedIndex = 0;
        }
    }


}
