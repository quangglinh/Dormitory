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
    public partial class RoomExtra : Form
    {
        Student student;
        StudentDAL dao;
        public RoomExtra(Student Student)
        {
            InitializeComponent();
            dao = new StudentDAL();
            this.student = Student;
        }
        public void setName()
        {
            string title = $"Student: {this.student.name} - {this.student.studentID.ToUpper()}";
            lblStudentInfo.Text = title;
        }
        public void setYearDropDown()
        {
            DataTable years = dao.getYearByStudentExtra(this.student.studentID);
            DataView dv = new DataView(years);
            dv.Sort = "year DESC";
            cbbYear.DataSource = dv;
            cbbYear.DisplayMember = "year";
            cbbYear.ValueMember = "year";
        }
        public void setMonthDropDown()
        {
            int year = 0;
            try
            {
                int.TryParse(cbbYear.SelectedValue.ToString(), out year);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            DataTable months = dao.getMonthByStudentExtra(this.student.studentID, year);
            DataView dv = new DataView(months);
            dv.Sort = "month DESC";
            cbbMonth.DataSource = dv;
            cbbMonth.DisplayMember = "month";
            cbbMonth.ValueMember = "month";
        }
        public void setDataForTextField()
        {
            int year = 0;
            int month = 0;
            try
            {
                int.TryParse(cbbYear.SelectedValue.ToString(), out year);
                int.TryParse(cbbMonth.SelectedValue.ToString(), out month);
            }
            catch 
            {
            }
            if (year > 0 && month > 0)
            {
                DataRow row = dao.getBillhByStudentExtra(this.student.studentID, year, month);
                string electricCost = row["electricCost"].ToString();
                string waterCost = row["waterCost"].ToString();
                string extraFee = row["extraFee"].ToString();
                string extraFeeContent = row["extraFeeContent"].ToString();
                bool isComplete =  bool.Parse(row["isCompleteFee"].ToString());
                string note = row["note"].ToString();
                txtElectricCost.Text = electricCost;
                txtExtraContent.Text = extraFeeContent;
                txtWaterCost.Text = waterCost;
                txtExtraFee.Text = extraFee;
                if(!isComplete)
                {
                    completeFeeLabel.ForeColor = Color.Red;
                    completeFeeLabel.Text = "Chưa hoàn thành: " + note;
                } else
                {
                    completeFeeLabel.ForeColor = Color.Green;
                    completeFeeLabel.Text = "Đã hoàn thành";
                }
            }
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void RoomExtra_Load(object sender, EventArgs e)
        {
            setName();
            setYearDropDown();
            setMonthDropDown();
            setDataForTextField();
        }

        private void cbbMonth_SelectedIndexChanged(object sender, EventArgs e)
        {
            setDataForTextField();
        }

        private void cbbYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            setMonthDropDown();
            setDataForTextField();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
