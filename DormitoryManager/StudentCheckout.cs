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

        public void LoadCheckout() {
            Slot slot = new StudentAccess().getSlot(txtStudentId.Text);
            if (slot == null) {
                txtSlot.Text = txtRoom.Text = txtDom.Text = txtFee.Text = txtMaxSlot.Text = "Not Found";
                return;
            }
            txtSlot.Text = slot.Number.ToString();
            Room now = new StudentAccess().GetRoom(slot.RoomID);
            if (now != null) {
                txtRoom.Text = now.ID;
                txtDom.Text = now.Dom;
                txtFee.Text = now.Fee.ToString();
                txtMaxSlot.Text = now.NoSlot.ToString();

                btnCheckout.Enabled = true;
            } else {
                txtSlot.Text = txtRoom.Text = txtDom.Text = txtFee.Text = txtMaxSlot.Text = "Not Found";
                
            }

        }

        private void LoadStudents() {
            btnCheckout.Enabled = false;
            LoadCheckout();
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
                lbAvailable.Text = "Not checked in yet";
                lbAvailable.ForeColor = Color.Red;

            } else {
                lbAvailable.Text = "Found!";
                LoadCheckout();
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
            txtStudentId.Text = "";
        }
    }


}
