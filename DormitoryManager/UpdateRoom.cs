using DormitoryManager.AppCode;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DormitoryManager
{
    public partial class UpdateRoom : Form
    {
        public UpdateRoom()
        {
            InitializeComponent();
            LoadRoom();
            LoadFee();
        }

        private void LoadRoom()
        {
            cbRoomId.DataSource = new DataAccess().LoadRooms();
            cbRoomId.ValueMember = "roomID";
            cbRoomId.DisplayMember = "roomID";
        }

        private void LoadFee()
        {
            string roomId = cbRoomId.SelectedValue.ToString();
            DataTable dt = new DataAccess().LoadRoomInfo(roomId);
            if(dt.Rows.Count>0)
                txtFee.Text = dt.Rows[0]["monthlyFee"].ToString();
        }
        private void cbRoomId_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadFee();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private bool isValidInput()
        {
            float fee;
            if(txtFee.Text.Trim() == "" || txtFee.Text.Trim() == " ")
            {
                MessageBox.Show("Fee must not be empty");
                return false;
            }
            try
            {
                fee = float.Parse(txtFee.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Fee must bee float nummber");
                return false;
            }
            if(fee <= 0)
            {
                MessageBox.Show("Fee must greater than 0!");
                return false;
            }
            return true;
        }
        private void btnChange_Click(object sender, EventArgs e)
        {
            if (isValidInput())
            {
                new DataAccess().UpdateFee(cbRoomId.SelectedValue.ToString(), float.Parse(txtFee.Text));
                MessageBox.Show("Update successful!");
            }
        }
    }
}
