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

        public void LoadRoomInfo() {
            Slot slot = new StudentAccess().getSlot(txtStudentId.Text);
            if (slot == null) {
                UIUtil.FillRoom(cbRoom, cbSlot, txtDom, txtFee, txtMaxSlot, null, 0);
                return;
            }
            LoadRoom();
            cbSlot.DataSource = null;
            Room now = new StudentAccess().GetRoom(slot.RoomID);
            UIUtil.FillRoom(cbRoom, cbSlot, txtDom, txtFee, txtMaxSlot, now, slot.Number);
        }

        private void LoadStudents() {
            gbRoom.Enabled = false;
            Student student = new StudentAccess().GetStudent(txtStudentId.Text);
            LoadRoomInfo();
            UIUtil.FillStudent(txtStudentName, txtStudentMail, txtStudentPhone, lbAvailable, student);
            if (student == null) return;
            LoadRoom();
            if (new StudentAccess().isStudentAvailable(txtStudentId.Text)) {
                lbAvailable.Text = "Available";
                lbAvailable.ForeColor = Color.Green;
                gbRoom.Enabled = true;
            } else {
                lbAvailable.Text = "Already Checked in";
                lbAvailable.ForeColor = Color.Orange;
                
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
            UIUtil.FillRoom(cbRoom, cbSlot, txtDom, txtFee, txtMaxSlot, now, -1);
            if (now != null ) {
                txtDom.Text = now.Dom;
                txtFee.Text = now.Fee.ToString();
                txtMaxSlot.Text = now.NoSlot.ToString();
                Slot slot = new StudentAccess().getSlot(txtStudentId.Text);
                if (slot == null) LoadSlot(cbRoom.Text);
                else cbSlot.Text = slot.Number.ToString();
            } else {
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
            LoadStudents();
            cbRoom.SelectedIndex = 0;
        }

        public void Import(string studentID, Slot slot) {
            txtStudentId.Text = studentID;
            if (!new StudentAccess().IsSlotAvailable(slot)) {
                MessageBox.Show("Request has expired");
                //delete request
                this.Close();
            }
            cbRoom.SelectedIndex = cbRoom.FindString(slot.RoomID);
            cbSlot.Text = slot.Number.ToString();
            
        }

    }


}
