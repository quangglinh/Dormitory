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
    public partial class StudentCheckout : Form {
        public StudentCheckout() {
            InitializeComponent();
        }
        public void LoadRoomInfo() {
            Slot slot = new StudentAccess().getSlot(txtStudentId.Text);
            if (slot == null) {
                btnCheckout.Enabled = UIUtil.FillRoom(txtRoom, txtSlot, txtDom, txtFee, txtMaxSlot, null, -1);
                return;
            }
            Room now = new StudentAccess().GetRoom(slot.RoomID);
            btnCheckout.Enabled = UIUtil.FillRoom(txtRoom, txtSlot, txtDom, txtFee, txtMaxSlot, now, slot.Number);
        }

        

        private void LoadStudents() {
            btnCheckout.Enabled = false;
            LoadRoomInfo();
            Student student = new StudentAccess().GetStudent(txtStudentId.Text);
            UIUtil.FillStudent(txtStudentName, txtStudentMail, txtStudentPhone, lbAvailable, student);
            if (student == null) {
                return;
            }
            if (student.Id.Length > 0 &&  new StudentAccess().isStudentAvailable(txtStudentId.Text)) {
                lbAvailable.Text = "Not checked in yet";
                lbAvailable.ForeColor = Color.Orange;
            } else {
                LoadRoomInfo();
                lbAvailable.ForeColor = Color.Green;
            }
            
        }
        private void StudentCheckin_Load(object sender, EventArgs e) {
            LoadStudents();
        }

        private void txtStudentId_TextChanged(object sender, EventArgs e) {
            LoadStudents();
        }

        private void btnCheckout_Click(object sender, EventArgs e) {
            string studentID = txtStudentId.Text;
            int result = new StudentAccess().Checkout(studentID);
            if (result == 1) {
                MessageBox.Show("Checkout success");
            } else {
                MessageBox.Show("Checkout failed");
            }
            LoadStudents();
        }
    }


}
