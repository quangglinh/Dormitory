using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace DormitoryManager.AppCode
{
    class DataAccess
    {
        public void AddNewRoom(string roomId, string dom, float fee, int slot)
        {
            using (SqlConnection connection = DBUtil.getConnection)
            {
                SqlCommand cmd = new SqlCommand("Insert into Room " +
                    "values(@roomId, @dom, @fee, @slot)",connection);
                cmd.Parameters.AddWithValue("@roomId", roomId);
                cmd.Parameters.AddWithValue("@dom", dom);
                cmd.Parameters.AddWithValue("@fee", fee);
                cmd.Parameters.AddWithValue("@slot", slot);
                connection.Open();
                cmd.ExecuteNonQuery();
                connection.Close();
            }
        }
    }
}
