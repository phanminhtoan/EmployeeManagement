﻿using System;
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
            var id = int.Parse(txtStaffId.Text);
            var name = txtStaffName.Text;
            var email = txtStaffEmail.Text;
            var roleId = int.Parse(cbxStaffRole.SelectedValue.ToString());
            DateTime date = staffDateTime.Value;

            bool createStaff = Staff.createStaff(id, name, email, roleId, date);
            
            if(createStaff == true)
            {
                MessageBox.Show("Thêm thành công");
                this.Close();
            }
            else
            {
                MessageBox.Show("Thêm thất bại");
            }
        }

        private void frmAddStaff_Load(object sender, EventArgs e)
        {
            loadRole();
        }

        private void loadRole()
        {
            cbxStaffRole.DataSource = Role.getRole();
            cbxStaffRole.DisplayMember = "name";
            cbxStaffRole.ValueMember = "id";
        }
    }
}
