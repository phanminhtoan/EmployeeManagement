namespace WindowsFormsApplication1
{
    partial class frmAddStaff
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.createStaff = new System.Windows.Forms.Button();
            this.txtStaffId = new System.Windows.Forms.TextBox();
            this.txtStaffName = new System.Windows.Forms.TextBox();
            this.txtStaffEmail = new System.Windows.Forms.TextBox();
            this.lbStaffRole = new System.Windows.Forms.Label();
            this.cbxStaffRole = new System.Windows.Forms.ComboBox();
            this.staffDateTime = new System.Windows.Forms.DateTimePicker();
            this.btnAddStaffCancel = new System.Windows.Forms.Button();
            this.grbAddStaff = new System.Windows.Forms.GroupBox();
            this.lbErrorAddStaff = new System.Windows.Forms.Label();
            this.grbAddStaff.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã Nhân Viên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Họ Tên";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Email";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 167);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ngày Sinh";
            // 
            // createStaff
            // 
            this.createStaff.Location = new System.Drawing.Point(422, 47);
            this.createStaff.Name = "createStaff";
            this.createStaff.Size = new System.Drawing.Size(75, 23);
            this.createStaff.TabIndex = 4;
            this.createStaff.Text = "Create";
            this.createStaff.UseVisualStyleBackColor = true;
            this.createStaff.Click += new System.EventHandler(this.createStaff_Click);
            // 
            // txtStaffId
            // 
            this.txtStaffId.Location = new System.Drawing.Point(140, 23);
            this.txtStaffId.Name = "txtStaffId";
            this.txtStaffId.Size = new System.Drawing.Size(200, 20);
            this.txtStaffId.TabIndex = 5;
            // 
            // txtStaffName
            // 
            this.txtStaffName.Location = new System.Drawing.Point(140, 56);
            this.txtStaffName.Name = "txtStaffName";
            this.txtStaffName.Size = new System.Drawing.Size(200, 20);
            this.txtStaffName.TabIndex = 6;
            // 
            // txtStaffEmail
            // 
            this.txtStaffEmail.Location = new System.Drawing.Point(140, 92);
            this.txtStaffEmail.Name = "txtStaffEmail";
            this.txtStaffEmail.Size = new System.Drawing.Size(200, 20);
            this.txtStaffEmail.TabIndex = 7;
            // 
            // lbStaffRole
            // 
            this.lbStaffRole.AutoSize = true;
            this.lbStaffRole.Location = new System.Drawing.Point(9, 131);
            this.lbStaffRole.Name = "lbStaffRole";
            this.lbStaffRole.Size = new System.Drawing.Size(37, 13);
            this.lbStaffRole.TabIndex = 9;
            this.lbStaffRole.Text = "Vai trò";
            // 
            // cbxStaffRole
            // 
            this.cbxStaffRole.FormattingEnabled = true;
            this.cbxStaffRole.Location = new System.Drawing.Point(140, 123);
            this.cbxStaffRole.Name = "cbxStaffRole";
            this.cbxStaffRole.Size = new System.Drawing.Size(200, 21);
            this.cbxStaffRole.TabIndex = 10;
            // 
            // staffDateTime
            // 
            this.staffDateTime.Location = new System.Drawing.Point(140, 159);
            this.staffDateTime.Name = "staffDateTime";
            this.staffDateTime.Size = new System.Drawing.Size(200, 20);
            this.staffDateTime.TabIndex = 11;
            // 
            // btnAddStaffCancel
            // 
            this.btnAddStaffCancel.Location = new System.Drawing.Point(422, 80);
            this.btnAddStaffCancel.Name = "btnAddStaffCancel";
            this.btnAddStaffCancel.Size = new System.Drawing.Size(75, 23);
            this.btnAddStaffCancel.TabIndex = 12;
            this.btnAddStaffCancel.Text = "cancel";
            this.btnAddStaffCancel.UseVisualStyleBackColor = true;
            this.btnAddStaffCancel.Click += new System.EventHandler(this.btnAddStaffCancel_Click);
            // 
            // grbAddStaff
            // 
            this.grbAddStaff.Controls.Add(this.txtStaffEmail);
            this.grbAddStaff.Controls.Add(this.label1);
            this.grbAddStaff.Controls.Add(this.staffDateTime);
            this.grbAddStaff.Controls.Add(this.label2);
            this.grbAddStaff.Controls.Add(this.cbxStaffRole);
            this.grbAddStaff.Controls.Add(this.label3);
            this.grbAddStaff.Controls.Add(this.lbStaffRole);
            this.grbAddStaff.Controls.Add(this.label4);
            this.grbAddStaff.Controls.Add(this.txtStaffId);
            this.grbAddStaff.Controls.Add(this.txtStaffName);
            this.grbAddStaff.Location = new System.Drawing.Point(12, 24);
            this.grbAddStaff.Name = "grbAddStaff";
            this.grbAddStaff.Size = new System.Drawing.Size(365, 193);
            this.grbAddStaff.TabIndex = 13;
            this.grbAddStaff.TabStop = false;
            // 
            // lbErrorAddStaff
            // 
            this.lbErrorAddStaff.AutoSize = true;
            this.lbErrorAddStaff.ForeColor = System.Drawing.Color.Red;
            this.lbErrorAddStaff.Location = new System.Drawing.Point(12, 24);
            this.lbErrorAddStaff.Name = "lbErrorAddStaff";
            this.lbErrorAddStaff.Size = new System.Drawing.Size(0, 13);
            this.lbErrorAddStaff.TabIndex = 14;
            // 
            // frmAddStaff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 244);
            this.Controls.Add(this.lbErrorAddStaff);
            this.Controls.Add(this.grbAddStaff);
            this.Controls.Add(this.btnAddStaffCancel);
            this.Controls.Add(this.createStaff);
            this.Name = "frmAddStaff";
            this.Text = "Thêm nhân viên";
            this.Load += new System.EventHandler(this.frmAddStaff_Load);
            this.grbAddStaff.ResumeLayout(false);
            this.grbAddStaff.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button createStaff;
        private System.Windows.Forms.TextBox txtStaffId;
        private System.Windows.Forms.TextBox txtStaffName;
        private System.Windows.Forms.TextBox txtStaffEmail;
        private System.Windows.Forms.Label lbStaffRole;
        private System.Windows.Forms.ComboBox cbxStaffRole;
        private System.Windows.Forms.DateTimePicker staffDateTime;
        private System.Windows.Forms.Button btnAddStaffCancel;
        private System.Windows.Forms.GroupBox grbAddStaff;
        private System.Windows.Forms.Label lbErrorAddStaff;
    }
}