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
        }
        private void loadRequests()
        {
            cbRequests.DataSource = new DataAccess().LoadStudentRequests();
            cbRequests.DisplayMember = "statusID";
            cbRequests.ValueMember = "statusID";
        }
        private bool hasRequests()
        {
            if (cbRequests.Items.Count == 0) return false;
            return true;
        }
        private void btnSearch_Click(object sender, EventArgs e)
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
        }
    }
}
