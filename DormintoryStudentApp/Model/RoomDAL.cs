using DormintoryStudentApp.Supporting_Files;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace DormintoryStudentApp.Model
{
    class RoomDAL
    {
        public DataTable getListOfDom()
        {
            using (SqlConnection conn = DBUltiity.getConnection)
            {
                string query = "SELECT DISTINCT dom From Room ORDER BY dom ASC";

                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable domTable = new DataTable();
                da.Fill(domTable);
                return domTable;
            }
        } // end getListOfDom

        public DataTable getCapacityList()
        {
            using (SqlConnection conn = DBUltiity.getConnection)
            {
                string query = "SELECT DISTINCT numberOfSlot From Room ORDER BY numberOfSlot ASC";

                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable capacityTable = new DataTable();
                da.Fill(capacityTable);
                return capacityTable;
            }
        } // end get capacity list

        public DataTable getAllAvailableSlot()
        {
            using (SqlConnection conn = DBUltiity.getConnection)
            {
                string query = "SELECT r.roomID as Room, s.slotNumber as Slot, r.dom as AtDom, r.monthlyFee as MonthlyFee, r.numberOfSlot as Capacity FROM Room r INNER JOIN Slot s ON r.roomID = s.roomID WHERE s.isAvailable = 1 ORDER BY Room ASC";

                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable allAvailableSlotTable = new DataTable();
                da.Fill(allAvailableSlotTable);
                return allAvailableSlotTable;

            }

        } // end get all available room

        public DataTable getAvailableRoomByInput(string input)
        {
            using (SqlConnection conn = DBUltiity.getConnection)
            {
                string query = "SELECT r.roomID as Room, s.slotNumber as Slot, r.dom as AtDom, r.monthlyFee as MonthlyFee, r.numberOfSlot as Capacity FROM Room r INNER JOIN Slot s ON r.roomID = s.roomID WHERE r.roomID=@input AND s.isAvailable = 1 ORDER BY Room ASC";

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = query;
                cmd.Parameters.AddWithValue("@input", input);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable allAvailableSlotTable = new DataTable();
                da.Fill(allAvailableSlotTable);
                return allAvailableSlotTable;
            }

        } // end get available room by input


        public DataTable getAvailableRoomByProperty(string dom, int capacity)
        {
            using (SqlConnection conn = DBUltiity.getConnection)
            {
                string query = "SELECT r.roomID as Room, s.slotNumber as Slot, r.dom as AtDom, r.monthlyFee as MonthlyFee, r.numberOfSlot as Capacity FROM Room r INNER JOIN Slot s ON r.roomID = s.roomID WHERE r.dom = @dom AND r.numberOfSlot = @capacity AND s.isAvailable = 1 ORDER BY Room ASC";

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = query;
                cmd.Parameters.AddWithValue("@dom", dom);
                cmd.Parameters.AddWithValue("@capacity", capacity);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable allAvailableSlotTable = new DataTable();
                da.Fill(allAvailableSlotTable);
                return allAvailableSlotTable;
            }

        }

        public bool isRoomExisted(string input)
        {
            using(SqlConnection conn = DBUltiity.getConnection)
            {
                string query = "SELECT * FROM Room WHERE roomID=@roomID";

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = query;
                cmd.Parameters.AddWithValue("@roomID", input);
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    return true;
                }

                return false;

            }
        } // end isRoomExisted

    }
}
