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


        public void LoadRoomInfo() {
            Slot slot = new StudentAccess().getSlot(txtStudentId.Text);
            if (slot == null) {
                grStatus.Enabled = UIUtil.FillRoom(txtRoom, txtSlot, txtDom, txtFee, txtMaxSlot, null, -1);
                return;
            }
            Room now = new StudentAccess().GetRoom(slot.RoomID);
            grStatus.Enabled = UIUtil.FillRoom(txtRoom, txtSlot, txtDom, txtFee, txtMaxSlot, now, slot.Number);
        }

       

        private void LoadStatus() {

            string studentID = txtStudentId.Text;
            int month;
            int year;
            StudentStatus status = null;
            try {
                studentID = txtStudentId.Text;
                month = int.Parse(cbMonth.Text);
                year = int.Parse(cbYear.Text);
                status = new StudentAccess().GetStudentStatus(studentID, month, year);
            } catch (Exception ex) {
                Console.WriteLine(ex.Message);
            } finally {
                btnUpdate.Enabled = UIUtil.FillStatus(txtElec, txtWater, txtExtra, txtExtraInfo, txtInfo, checkComplete,  status);
            }
        }

        private void LoadStudents() {
            LoadRoomInfo();
            Student student = new StudentAccess().GetStudent(txtStudentId.Text);
            LoadStatus();

            UIUtil.FillStudent(txtStudentName, txtStudentMail, txtStudentPhone, lbAvailable, student);
            if (student == null) {
                return;
            }
            lbAvailable.Text = "Not checked in yet";
            lbAvailable.ForeColor = Color.Orange;
            if (student.Id.Length > 0 && new StudentAccess().isStudentAvailable(txtStudentId.Text)) {
                UIUtil.FillStatus(txtElec, txtWater, txtExtra, txtExtraInfo, txtInfo, checkComplete, null);
            } else {                
                lbAvailable.Text = "Found!";
                lbAvailable.ForeColor = Color.Green;
                LoadRoomInfo();
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
            } catch  {
                lb.ForeColor = Color.Red;
                return 0;
            }
            lb.ForeColor = Color.Green;
            return 1;
        }
        void CheckValid() {
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
                string extraInfo = txtExtraInfo.Text;
                bool complete = checkComplete.Checked;
                string info = txtInfo.Text;
                StudentStatus newstatus = new StudentStatus() {
                    StudentID = studentID,
                    Month = month,
                    Year = year,
                    ElectricCost = electric,
                    WaterCost = water,
                    ExtraFee = extra,
                    ExtraNote = extraInfo,
                    Note = info,
                    Complete = complete,
                };
                if (new StudentAccess().UpdateStudentStatus(newstatus) != 0) {
                    MessageBox.Show("Update Success");

                } else {
                    MessageBox.Show("Update Failed");
                }
                LoadStatus();
            } catch  {
                MessageBox.Show("Update Failed");
            }

        }


        private void Valid(object sender, EventArgs e) {
            CheckValid();
        }
    }


}
