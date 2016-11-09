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
using WindowsFormsApplication1.Models;

namespace WindowsFormsApplication1
{
    public partial class frmAddStaff : Form
    {
        public frmAddStaff()
        {
            InitializeComponent();
        }

        private  SqlConnection connect()
        {
            var connection = new SqlConnection();
            connection.ConnectionString = "Data Source=DESKTOP-7H93CC6\\SQLEXPRESS;Initial Catalog=QLNV;Integrated Security=True";
            return connection;
        }
        private void createStaff_Click(object sender, EventArgs e)
        {
            try
            {
                var id = int.Parse(txtStaffId.Text);
                var name = txtStaffName.Text;
                var email = txtStaffEmail.Text;
                var roleId = int.Parse(cbxStaffRole.SelectedValue.ToString());
                DateTime date = staffDateTime.Value;

                bool createStaff = Staff.createStaff(id, name, email, roleId, date);

                if (createStaff == true)
                {
                    this.Close();
                    MessageBox.Show("Thêm thành công");
                }
                else
                {
                    MessageBox.Show("Thêm thất bại");
                }
            }
            catch(Exception exception)
            {
                lbErrorAddStaff.Text = "Can't create, Please check your information again";
            }
            
        }

        private void frmAddStaff_Load(object sender, EventArgs e)
        {
            loadRole();
        }

        private void loadRole()
        {
            try
            {
                cbxStaffRole.DataSource = Role.getRole();
                cbxStaffRole.DisplayMember = "name";
                cbxStaffRole.ValueMember = "id";
            }
            catch(Exception exception)
            {
                lbErrorAddStaff.Text = "Can't get data Role, Please check your connection with database";
            }
           
        }

        private void btnAddStaffCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
