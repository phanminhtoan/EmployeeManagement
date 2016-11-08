using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        
        private void txtName_TextChanged(object sender, EventArgs e)
        {
            btnSearch_Click(sender, e);
        }

        private SqlConnection  connect()
        {
            var connection = new SqlConnection();
            connection.ConnectionString = "Data Source=DESKTOP-7H93CC6\\SQLEXPRESS;Initial Catalog=QLNV;Integrated Security=True";
            return connection;
        }
        private DataTable sreachStaff( string KeyName)
        {
            var connection = connect();
            var dataName = new StringBuilder();
            dataName.Append("select * from USERS where name like '%'+ @keyName +'%' ");
            var sqlCmd = new SqlCommand(dataName.ToString(), connection);
            var param = new SqlParameter("@keyName", SqlDbType.VarChar);
            param.Value = KeyName;
            sqlCmd.Parameters.Add(param);

            var customerTable = new DataTable();
            var adapter = new SqlDataAdapter(sqlCmd);
            adapter.Fill(customerTable);
            connection.Close();
            return customerTable ;
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            string keyName = txtName.Text;
            //dgvStaff.AutoGenerateColumns = false;
            dgvStaff.DataSource = sreachStaff(keyName);
        }

        private void addStaff_Click(object sender, EventArgs e)
        {
            var fromAddStaff = new frmAddStaff();
            fromAddStaff.Show();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
              
        }
    }
}
