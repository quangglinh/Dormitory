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
    public partial class ChangeRoom : Form {
        public ChangeRoom() {
            InitializeComponent();
        }
        public void LoadRoomInfo() {
            Slot slot = new StudentAccess().getSlot(txtStudentId.Text);
            if (slot == null) {
                UIUtil.FillRoom(txtFromRoom, txtFromSlot, txtFromDom, txtFromFee, txtFromMaxSlot, null, 0);
                return;
            }
            LoadRoom();
            cbSlot.DataSource = null;
            Room now = new StudentAccess().GetRoom(slot.RoomID);
            UIUtil.FillRoom(txtFromRoom, txtFromSlot, txtFromDom, txtFromFee, txtFromMaxSlot, now, slot.Number);
        }

        private void LoadStudents() {
            gbRoom.Enabled = false;
            Student student = new StudentAccess().GetStudent(txtStudentId.Text);
            LoadRoomInfo();
            UIUtil.FillStudent(txtStudentName, txtStudentMail, txtStudentPhone, lbAvailable, student);
            if (student == null) return;
            LoadRoom();
            if (new StudentAccess().isStudentAvailable(txtStudentId.Text)) {
                lbAvailable.Text = "Not Checked in yet";
                lbAvailable.ForeColor = Color.Orange;
            } else {
                lbAvailable.Text = "Found";
                lbAvailable.ForeColor = Color.Green;
                gbRoom.Enabled = true;
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
            btnChange.Enabled = true;
        }

        private void cbRoom_SelectedIndexChanged(object sender, EventArgs e) {
            btnChange.Enabled = false;
            Room now = new StudentAccess().GetRoom(cbRoom.Text);
            UIUtil.FillRoom(cbRoom, cbSlot, txtDom, txtFee, txtMaxSlot, now, -1);
            if (now != null) {
                txtDom.Text = now.Dom;
                txtFee.Text = now.Fee.ToString();
                txtMaxSlot.Text = now.NoSlot.ToString();
                Slot slot = new StudentAccess().getSlot(txtStudentId.Text);
                LoadSlot(cbRoom.Text);
            } else {
                cbSlot.Text = "Not available";
            }
        }
        private void txtStudentId_TextChanged(object sender, EventArgs e) {
            LoadStudents();
        }

        public void Import(string studentID, Slot from, Slot to) {
            Slot origin = new StudentAccess().getSlot(studentID);
            if (origin.RoomID != from.RoomID || origin.Number != from.Number || !new StudentAccess().IsSlotAvailable(to)) {
                MessageBox.Show("Request has expired");
                //delete request
                this.Close();
            }
            txtStudentId.Text = studentID;
            LoadStudents();
            cbRoom.Text = to.RoomID;
            LoadSlot(to.RoomID);
            cbSlot.Text = to.Number.ToString();
        }

        private void btnChange_Click(object sender, EventArgs e) {
            string studentID = txtStudentId.Text;
            string roomId = cbRoom.Text;
            int slot = int.Parse(cbSlot.Text);
            int checkout = new StudentAccess().Checkout(studentID);
            if (checkout == 0) {
                MessageBox.Show("Change Room failed");
                return;
            }
            int result = new StudentAccess().Checkin(studentID, roomId, slot);
            if (result == 1) {
                MessageBox.Show("Change Room success");
            } else {
                MessageBox.Show("Change Room failed");
            }
            LoadStudents();
            cbRoom.SelectedIndex = 0;
        }
    }


}
