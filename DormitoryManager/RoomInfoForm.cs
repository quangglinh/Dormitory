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
    public partial class RoomInfoForm : Form
    {
        public RoomInfoForm()
        {
            InitializeComponent();
            LoadRoom();
            LoadRoomInformation();
        }
        private void LoadRoom()
        {
            cbRooms.DataSource = new DataAccess().LoadRooms();
            cbRooms.ValueMember = "roomID";
            cbRooms.DisplayMember = "roomID";
        }

        private void LoadRoomInformation()
        {
            DataTable dt = new DataAccess().LoadRoomInfo(cbRooms.SelectedValue.ToString());
            DataTable available = new DataAccess().LoadAvailableSlots(cbRooms.SelectedValue.ToString());
            txtDom.Text = dt.Rows[0][1].ToString();
            txtFee.Text = dt.Rows[0][2].ToString();
            txtNoS.Text = dt.Rows[0][3].ToString();
            if (available.Rows.Count > 0)
            {
                txtAvailable.Text = "";

                for (int i = 0; i < available.Rows.Count; i++)
                {
                    txtAvailable.Text += " " + available.Rows[i][0].ToString();
                }
            }
            else
            {
                txtAvailable.Text = "0";
            }
        }
        private void cbRooms_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadRoomInformation();
        }
    }
}
