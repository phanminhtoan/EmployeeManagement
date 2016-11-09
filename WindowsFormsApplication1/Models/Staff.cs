using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1.Models
{
   public class Staff:AbstractModel
    {
        public static bool createStaff(int id, string name, string email,int roleId ,DateTime date)
        {
            var con = connect();
            con.Open();
            var dataInsert = new StringBuilder();

            dataInsert.AppendFormat("insert into USERS(id,name,email,role,birthday) ");
            dataInsert.AppendFormat("values('{0}', '{1}', '{2}', '{3}', '{4}')", id, name, email, roleId, date.ToShortDateString());
            var sqlCmd = new SqlCommand(dataInsert.ToString(), con);
            /*
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
            */

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
