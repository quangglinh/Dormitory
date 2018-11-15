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
    public partial class UpdateStudentStatus : Form {
        public UpdateStudentStatus() {
            InitializeComponent();
        }

        public void LoadCheckout() {
            grStatus.Enabled = false;
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
                grStatus.Enabled = true;
            } else {
                txtSlot.Text = txtRoom.Text = txtDom.Text = txtFee.Text = txtMaxSlot.Text = "Not Found";

            }

        }

        private void LoadStatus() {

            string studentID = txtStudentId.Text;
            int month;
            int year;
            try {
                studentID = txtStudentId.Text;
                month = int.Parse(cbMonth.Text);
                year = int.Parse(cbYear.Text);
                StudentStatus student = new StudentAccess().GetStudentStatus(studentID, month, year);
                txtElec.Text = student.ElectricCost.ToString();
                txtWater.Text = student.WaterCost.ToString();
                txtExtra.Text = student.ExtraFee.ToString();
                txtInfo.Text = student.Desc;
            } catch (Exception ex) {
                txtElec.Text = txtWater.Text = txtExtra.Text = txtInfo.Text = "Not Found!";
            }

        }

        private void LoadStudents() {
            LoadCheckout();
            Student student = new StudentAccess().GetStudent(txtStudentId.Text);
            
            if (student == null) {
                txtStudentMail.Text = txtStudentName.Text = txtStudentPhone.Text = "Not Found";
                lbAvailable.Text = "Not Found";
                lbAvailable.ForeColor = Color.Red;
                return;
            }
            lbAvailable.Text = "Not checked in yet";
            
            lbAvailable.ForeColor = Color.Red;
            txtStudentMail.Text = student.Email;
            txtStudentName.Text = student.Name;
            txtStudentPhone.Text = student.Phone;
            
            if (student.Id.Length > 0 && new StudentAccess().isStudentAvailable(txtStudentId.Text)) {
                txtElec.Text = txtWater.Text = txtExtra.Text = txtInfo.Text = "Not checked in yet";
            } else {
                LoadCheckout();
                LoadStatus();
                lbAvailable.Text = "Found!";
                lbAvailable.ForeColor = Color.Green;

            }

        }

        private void LoadMonths() {
            cbMonth.SelectedIndex = 0;
        }
        private void LoadYears() {
            List<int> years = StudentAccess.GenerateYear();
            cbYear.DataSource = years;
        }

        private void StudentCheckin_Load(object sender, EventArgs e) {
            LoadStudents();
            LoadYears();
            LoadMonths();
        }

        private void txtStudentId_TextChanged(object sender, EventArgs e) {
            LoadStudents();
        }

        private void cbMonth_SelectedIndexChanged(object sender, EventArgs e) {
            LoadStatus();
        }

        private void cbYear_SelectedIndexChanged(object sender, EventArgs e) {
            LoadStatus();
        }


        int Valid(TextBox txt, Label lb) {
            try {
                double.Parse(txt.Text);
            } catch (Exception ex) {
                lb.ForeColor = Color.Red;
                return 0;
            }
            lb.ForeColor = Color.Green;
            return 1;
        }
        void Valid() {
            btnUpdate.Enabled = false;
            int sum = Valid(txtElec, lbElectricFee) + Valid(txtWater, lbWaterFee) + Valid(txtExtra, lbExtraFee);
            if (sum == 3) btnUpdate.Enabled = true;
            
        }

        private void btnUpdate_Click(object sender, EventArgs e) {
            string studentID = txtStudentId.Text;
            int month = int.Parse(cbMonth.Text);
            int year = int.Parse(cbYear.Text);
            try {
                double electric = double.Parse(txtElec.Text);
                double water = double.Parse(txtWater.Text);
                double extra = double.Parse(txtExtra.Text);
                string info = txtInfo.Text;
                StudentStatus newstatus = new StudentStatus() {
                    StudentID = studentID,
                    Month = month,
                    Year = year,
                    ElectricCost = electric,
                    WaterCost = water,
                    ExtraFee = extra,
                    Desc = info
                };
                if (new StudentAccess().UpdateStudentStatus(newstatus) != 0) {
                    MessageBox.Show("Update Success");
                    
                } else {
                    MessageBox.Show("Update Failed");
                }
                LoadStatus();
            } catch (Exception ex) {
                MessageBox.Show("Update Failed");
            }
            
        }

        private void txtElec_TextChanged(object sender, EventArgs e) {
            Valid();
        }

        private void txtWater_TextChanged(object sender, EventArgs e) {
            Valid();
        }

        private void txtExtra_TextChanged(object sender, EventArgs e) {
            Valid();
        }
    }


}
