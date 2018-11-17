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
    public partial class SearchRoom : Form
    {
        public SearchRoom()
        {
            InitializeComponent();
            messageLabel.Text = "";
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            string dom = (string)domComboBox.SelectedValue;
            int capacity = (int)capacityComboBox.SelectedValue;

            DataTable availableRoom = new RoomDAL().getAvailableRoomByProperty(dom, capacity);
            if(availableRoom.Rows.Count > 0)
            {
                // having available room
                searchResultDGV.DataSource = availableRoom;
                messageLabel.Text = "";
            } else
            {
                searchResultDGV.DataSource = null;
                messageLabel.ForeColor = Color.Yellow;
                messageLabel.Text = "No results found";
            }

        }

        private void searchByNameButton_Click(object sender, EventArgs e)
        {
            string input = inputText.Text.ToUpper();
            if(input == "")
            {
                messageLabel.Text = "Enter the room's name!";
                return;
            } else
            {
                bool isRoomExisted = new RoomDAL().isRoomExisted(input);
                if (isRoomExisted)
                {
                    DataTable availableRoom = new RoomDAL().getAvailableRoomByInput(input);

                    if(availableRoom.Rows.Count > 0)
                    {
                        // having available slot
                        searchResultDGV.DataSource = availableRoom;
                        messageLabel.Text = "";
                    } else
                    {
                        // this room is full
                        searchResultDGV.DataSource = availableRoom;
                        messageLabel.ForeColor = Color.Yellow;
                        messageLabel.Text =  "Room " + input + " is full now";
                        return;
                    }

                } else
                {
                    // send out message
                    searchResultDGV.DataSource = null;
                    messageLabel.ForeColor = Color.Yellow;
                    messageLabel.Text = "This room is not existed";
                    return;
                }
            }
        }

        private void SearchRoom_Load(object sender, EventArgs e)
        {
            messageLabel.Text = "";
            // load data for dom combobox
            DataTable domList = new RoomDAL().getListOfDom();
            domComboBox.DataSource = domList;
            domComboBox.DisplayMember = "dom";
            domComboBox.ValueMember = "dom";
            // load data for capacity combobox
            DataTable capacityList = new RoomDAL().getCapacityList();
            capacityComboBox.DataSource = capacityList;
            capacityComboBox.DisplayMember = "numberOfSlot";
            capacityComboBox.ValueMember = "numberOfSlot";

        }

        private void showAllButton_Click(object sender, EventArgs e)
        {
            DataTable allAvailableRoom = new RoomDAL().getAllAvailableSlot();
            searchResultDGV.DataSource = allAvailableRoom;
        }

        private void searchResultDGV_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {

            // center text in gridview
            foreach (DataGridViewColumn col in searchResultDGV.Columns)
            {
                col.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                col.HeaderCell.Style.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Pixel);
                col.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
        }
    }
}
