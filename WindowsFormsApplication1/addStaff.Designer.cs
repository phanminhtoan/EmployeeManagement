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
            this.txtStaffPhoneNumber = new System.Windows.Forms.TextBox();
            this.staffDateTime = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã Nhân Viên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Họ Tên";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Phone Number";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ngày Vào Làm";
            // 
            // createStaff
            // 
            this.createStaff.Location = new System.Drawing.Point(144, 182);
            this.createStaff.Name = "createStaff";
            this.createStaff.Size = new System.Drawing.Size(75, 23);
            this.createStaff.TabIndex = 4;
            this.createStaff.Text = "Create";
            this.createStaff.UseVisualStyleBackColor = true;
            this.createStaff.Click += new System.EventHandler(this.createStaff_Click);
            // 
            // txtStaffId
            // 
            this.txtStaffId.Location = new System.Drawing.Point(144, 31);
            this.txtStaffId.Name = "txtStaffId";
            this.txtStaffId.Size = new System.Drawing.Size(200, 20);
            this.txtStaffId.TabIndex = 5;
            // 
            // txtStaffName
            // 
            this.txtStaffName.Location = new System.Drawing.Point(144, 64);
            this.txtStaffName.Name = "txtStaffName";
            this.txtStaffName.Size = new System.Drawing.Size(200, 20);
            this.txtStaffName.TabIndex = 6;
            // 
            // txtStaffPhoneNumber
            // 
            this.txtStaffPhoneNumber.Location = new System.Drawing.Point(144, 100);
            this.txtStaffPhoneNumber.Name = "txtStaffPhoneNumber";
            this.txtStaffPhoneNumber.Size = new System.Drawing.Size(200, 20);
            this.txtStaffPhoneNumber.TabIndex = 7;
            // 
            // staffDateTime
            // 
            this.staffDateTime.Location = new System.Drawing.Point(144, 135);
            this.staffDateTime.Name = "staffDateTime";
            this.staffDateTime.Size = new System.Drawing.Size(200, 20);
            this.staffDateTime.TabIndex = 8;
            // 
            // frmAddStaff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 261);
            this.Controls.Add(this.staffDateTime);
            this.Controls.Add(this.txtStaffPhoneNumber);
            this.Controls.Add(this.txtStaffName);
            this.Controls.Add(this.txtStaffId);
            this.Controls.Add(this.createStaff);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmAddStaff";
            this.Text = "Thêm nhân viên";
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
        private System.Windows.Forms.TextBox txtStaffPhoneNumber;
        private System.Windows.Forms.DateTimePicker staffDateTime;
    }
}