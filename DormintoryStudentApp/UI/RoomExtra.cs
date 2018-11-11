﻿using DormintoryStudentApp.Entity;
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
        string studentID;
        StudentDAL dao;
        public RoomExtra(string StudentID)
        {
            InitializeComponent();
            dao = new StudentDAL();
            this.studentID = StudentID;
        }
        public void setYearDropDown()
        {
            DataTable years = dao.getYearByStudentExtra(this.studentID);
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
            }
            DataTable months = dao.getMonthByStudentExtra(this.studentID, year);
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
            catch (Exception ex)
            {
            }
            if (year > 0 && month > 0)
            {
                DataRow row = dao.getBillhByStudentExtra(this.studentID, year, month);
                string electricCost = row["electricCost"].ToString();
                string waterCost = row["waterCost"].ToString();
                string extraFee = row["extraFee"].ToString();
                string extraFeeContent = row["extraFeeContent"].ToString();
                txtElectricCost.Text = electricCost;
                txtExtraContent.Text = extraFeeContent;
                txtWaterCost.Text = waterCost;
                txtExtraFee.Text = extraFee;
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
