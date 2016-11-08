using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1.Models
{
    public abstract class  AbstractModel
    {
        protected static SqlConnection connect()
        {
            var connection = new SqlConnection();
            connection.ConnectionString = "Data Source=DESKTOP-7H93CC6\\SQLEXPRESS;Initial Catalog=QLNV;Integrated Security=True";
            return connection;
        }
    }
}
