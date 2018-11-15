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
            MessageBox.Show(cbRequests.SelectedValue.ToString());

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
