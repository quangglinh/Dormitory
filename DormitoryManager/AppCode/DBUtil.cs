using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

namespace DormitoryManager.AppCode
{
    class DBUtil
    {
        public static SqlConnection getConnection
        {
            get
            {
                string connectionString = @"server=localhost;database=DomManagement;user=sa;password=123456";
                return new SqlConnection(connectionString);
            }
        }
    }
}
