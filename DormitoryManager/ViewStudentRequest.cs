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
    public partial class ViewStudentRequest : Form
    {
        public ViewStudentRequest()
        {
            InitializeComponent();
            loadRequests();
            LoadRequestInformation();
        }
        private void loadRequests()
        {
            cbRequests.DataSource = new DataAccess().LoadStudentRequests();
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
            if (!hasRequests())
            {
                MessageBox.Show("There are no requests!");
                return;
            }
            DataTable dt = new DataAccess().LoadStudentRequestInfo(cbRequests.SelectedValue.ToString());
            txtId.Text = dt.Rows[0]["studentID"].ToString();
            txtName.Text = dt.Rows[0]["name"].ToString();
            txtFromSlot.Text = dt.Rows[0]["fromSlot"].ToString();
            txtFromRoom.Text = dt.Rows[0]["atRoom"].ToString();
            txtToSlot.Text = dt.Rows[0]["toSlot"].ToString();
            txtToRoom.Text = dt.Rows[0]["toRoom"].ToString();
            txtReason.Text = dt.Rows[0]["reason"].ToString();
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
        private void cbRequests_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadRequestInformation();
        }

        private void btnApprove_Click(object sender, EventArgs e)
        {
            new DataAccess().UpdateRequest(int.Parse(cbRequests.SelectedValue.ToString()), 3);
            MessageBox.Show("Update successful!");

        }

        private void btnReject_Click(object sender, EventArgs e)
        {
            new DataAccess().UpdateRequest(int.Parse(cbRequests.SelectedValue.ToString()), 4);
            MessageBox.Show("Update successful!");
        }

        private void btnQueue_Click(object sender, EventArgs e)
        {
            new DataAccess().UpdateRequest(int.Parse(cbRequests.SelectedValue.ToString()), 2);
            MessageBox.Show("Update successful!");
        }
    }
}
