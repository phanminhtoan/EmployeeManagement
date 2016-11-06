using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1.Models
{
   public class Staff
    {
        private static SqlConnection connect()
        {
            var connection = new SqlConnection();
            connection.ConnectionString = "Data Source=DESKTOP-7H93CC6\\SQLEXPRESS;Initial Catalog=QLBH;Integrated Security=True";
            return connection;
        }

        public static bool createStaff(string id, string name, string phone, DateTime date)
        {
            var con = connect();
            con.Open();
            var dataInsert = new StringBuilder();
            dataInsert.Append("insert into NHANVIEN ");
            dataInsert.Append("values(@MANV, @HOTEN, @SODT, @NGVL)");
            var sqlCmd = new SqlCommand(dataInsert.ToString(), con);
            
            sqlCmd.Parameters.Add("@MANV", SqlDbType.NChar);
            sqlCmd.Parameters.Add("@HOTEN", SqlDbType.NVarChar);
            sqlCmd.Parameters.Add("@SODT", SqlDbType.NVarChar);
            sqlCmd.Parameters.Add("@NGVL", SqlDbType.SmallDateTime);

            sqlCmd.Parameters["@MANV"].Value = id;
            sqlCmd.Parameters["@HOTEN"].Value = name;
            sqlCmd.Parameters["@SODT"].Value = phone;
            sqlCmd.Parameters["@NGVL"].Value = date.ToShortDateString();
            
            /*var param = new SqlParameter();
              param.DbType = DbType.String;
              param.ParameterName = "@MANV";
              param.Value = id;
              sqlCmd.Parameters.Add(param);

              param = new SqlParameter();
              param.DbType = DbType.String;
              param.ParameterName = "@HOTEN";
              param.Value = name;
              sqlCmd.Parameters.Add(param);

              param = new SqlParameter();
              param.DbType = DbType.String;
              param.ParameterName = "@SODT";
              param.Value = phone;
              sqlCmd.Parameters.Add(param);

              param = new SqlParameter();
              param.DbType = DbType.DateTime;
              param.ParameterName = "@NGVL";
              param.Value = date.ToShortDateString();
              sqlCmd.Parameters.Add(param);
         */
            int count = sqlCmd.ExecuteNonQuery();
            con.Close();
            if (count == 1)
                return true;
            return false;
        }
    }
}
