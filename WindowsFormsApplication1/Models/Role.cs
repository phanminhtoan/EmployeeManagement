using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1.Models
{
    class Role:AbstractModel
    {
        public static DataTable getRole()
        {
            var con = connect();
            var getRoleData = new StringBuilder();
            getRoleData.Append("select * from ROLE");
            var sqlCmd = new SqlCommand(getRoleData.ToString(), con);
            var roleTable = new DataTable();
            var adapter = new SqlDataAdapter(sqlCmd);
            adapter.Fill(roleTable);
            return roleTable;
        }

    }
}
