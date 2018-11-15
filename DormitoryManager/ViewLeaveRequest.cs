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
    public partial class ViewLeaveRequest : Form
    {
        public ViewLeaveRequest()
        {
            InitializeComponent();
            loadRequests();
            LoadRequestInformation();
        }
        private void loadRequests()
        {
            cbRequests.DataSource = new DataAccess().LoadLeaveRoomRequests();
            cbRequests.DisplayMember = "requestID";
            cbRequests.ValueMember = "requestID";
        }
        private bool hasRequests()
        {
            if (cbRequests.Items.Count == 0) return false;
            return true;
        }

        private void LoadRequestInformation()
        {
            int requestId;
            if (!hasRequests())
            {
                MessageBox.Show("There are no requests!");
                return;
            }
            try
            {
                requestId = int.Parse(cbRequests.SelectedValue.ToString());
                DataTable dt = new DataAccess().LoadLeaveRequestInfo(requestId);
                txtId.Text = dt.Rows[0]["studentID"].ToString();
                txtName.Text = dt.Rows[0]["name"].ToString();
                txtFromSlot.Text = dt.Rows[0]["fromSlot"].ToString();
                txtFromRoom.Text = dt.Rows[0]["atRoom"].ToString();
                txtStatus.Text = dt.Rows[0]["status"].ToString();
                btnApprove.Enabled = true;
                btnReject.Enabled = true;
                btnQueue.Enabled = true;
                if (txtStatus.Text == "processing") btnQueue.Enabled = false;
                if (txtStatus.Text == "done" || txtStatus.Text == "reject")
                {
                    btnApprove.Enabled = false;
                    btnReject.Enabled = false;
                    btnQueue.Enabled = false;
                }
            }
            catch (Exception)
            {

            }
        }

        private void btnApprove_Click(object sender, EventArgs e)
        {
            new DataAccess().UpdateLeaveRoomRequest(int.Parse(cbRequests.SelectedValue.ToString()), 3, "LeaveRoomRequest");
            MessageBox.Show("Update successful!");

        }

        private void btnReject_Click(object sender, EventArgs e)
        {
            new DataAccess().UpdateLeaveRoomRequest(int.Parse(cbRequests.SelectedValue.ToString()), 4, "LeaveRoomRequest");
            MessageBox.Show("Update successful!");
        }

        private void btnQueue_Click(object sender, EventArgs e)
        {
            new DataAccess().UpdateLeaveRoomRequest(int.Parse(cbRequests.SelectedValue.ToString()), 2, "LeaveRoomRequest");
            MessageBox.Show("Update successful!");
        }

        private void cbRequests_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadRequestInformation();
        }

        private void btnCheckOut_Click(object sender, EventArgs e)
        {
            var tmp = new StudentCheckout();
            tmp.Show();
            tmp.Import(txtId.Text, new AppCode.Slot() { RoomID = txtFromRoom.Text, Number = int.Parse(txtFromSlot.Text) });
        }

        private void btnQueue_Click_1(object sender, EventArgs e)
        {

        }

        private void btnApprove_Click_1(object sender, EventArgs e)
        {

        }

        private void btnReject_Click_1(object sender, EventArgs e)
        {

        }
    }
}
