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
    public partial class AddRoomForm : Form
    {
        public AddRoomForm()
        {
            InitializeComponent();
        }
        //verify room id
        private bool IsValidRoomId()
        {
            String RoomId = txtRoomId.Text;
            if(RoomId.Contains(" "))
            {
                MessageBox.Show("The room id must not contain space(s)!");
                return false;
            }
            if(RoomId.Trim().Equals("") || RoomId.Trim().Equals(" "))
            {
                MessageBox.Show("The room id must not empty!");
                return false;
            }
            return true;
        }

        //verify dom
        private bool IsValidDom()
        {
            String dom = txtDom.Text;
            if (dom.Contains(" "))
            {
                MessageBox.Show("The dom must not contain space(s)!");
                return false;
            }
            if (dom.Trim().Equals("") || dom.Trim().Equals(" "))
            {
                MessageBox.Show("The dom must not empty!");
                return false;
            }
            return true;
        }

        //verify Fee
        private bool IsValidFee()
        {
            string fee = txtFee.Text;
            float tmp;
            if (fee.Contains(" "))
            {
                MessageBox.Show("The fee must not contain space(s)!");
                return false;
            }
            if (fee.Trim().Equals("") || fee.Trim().Equals(" "))
            {
                MessageBox.Show("The fee must not empty!");
                return false;
            }
            try
            {
                tmp = float.Parse(fee);
            }
            catch (Exception)
            {
                MessageBox.Show("Fee must bee a number!");
                return false;
            }
            tmp = float.Parse(fee);
            if (tmp < 0)
            {
                MessageBox.Show("Fee must greater or equals 0!");
                return false;
            }
            return true;
        }

        //verify Slot
        private bool IsValidSlot()
        {
            string slot = txtNoS.Text;
            int tmp;
            if (slot.Contains(" "))
            {
                MessageBox.Show("The slot must not contain space(s)!");
                return false;
            }
            if (slot.Trim().Equals("") || slot.Trim().Equals(" "))
            {
                MessageBox.Show("The slot must not empty!");
                return false;
            }
            try
            {
                tmp = int.Parse(slot);
            }
            catch (Exception)
            {
                MessageBox.Show("Slot must bee a number!");
                return false;
            }
            tmp = int.Parse(slot);
            if (tmp < 0)
            {
                MessageBox.Show("Slot must greater than 0!");
                return false;
            }
            return true;
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!IsValidRoomId()) return;
            if (!IsValidDom()) return;
            if (!IsValidFee()) return;
            if (!IsValidSlot()) return;
            try
            {
                string roomId = txtRoomId.Text;
                string dom = txtDom.Text;
                float fee = float.Parse(txtFee.Text);
                int slot = int.Parse(txtNoS.Text);

                new DataAccess().AddNewRoom(roomId,dom,fee,slot);
                MessageBox.Show("Add room successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
