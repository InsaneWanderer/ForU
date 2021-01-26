using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace WindowsFormsApp4
{
    class DBUtils
    {
        public static SqlConnection GetDBConnection()
        {   //DESKTOP-PPOTBC4\SQLEXPRESS         
            string datasource = @"DESKTOP-BP1NIOC";

            string database = "CinemaOnline";

            return DBSQLServerUtils.GetDBConnection(datasource, database);
        }
    }
}
