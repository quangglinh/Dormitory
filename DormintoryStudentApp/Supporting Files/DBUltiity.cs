using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

namespace DormintoryStudentApp.Supporting_Files
{
    class DBUltiity
    {
        class DbUtil
        {
            public static SqlConnection getConnection
            {
                get
                {
                    string connectionString = ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString;
                    return new SqlConnection(connectionString);
                }
            }
        }
    }
}
