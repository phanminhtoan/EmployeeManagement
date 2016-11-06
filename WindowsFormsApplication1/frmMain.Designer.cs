namespace WindowsFormsApplication1
{
    partial class frmMain
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
            this.dgvStaff = new System.Windows.Forms.DataGridView();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lbName = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.addStaff = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStaff)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvStaff
            // 
            this.dgvStaff.AllowUserToAddRows = false;
            this.dgvStaff.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStaff.Location = new System.Drawing.Point(1, 74);
            this.dgvStaff.Name = "dgvStaff";
            this.dgvStaff.Size = new System.Drawing.Size(576, 184);
            this.dgvStaff.TabIndex = 1;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(116, 14);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 20);
            this.txtName.TabIndex = 2;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Location = new System.Drawing.Point(51, 21);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(48, 13);
            this.lbName.TabIndex = 3;
            this.lbName.Text = "Từ Khóa";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(478, 11);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(99, 23);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // addStaff
            // 
            this.addStaff.Location = new System.Drawing.Point(478, 40);
            this.addStaff.Name = "addStaff";
            this.addStaff.Size = new System.Drawing.Size(99, 23);
            this.addStaff.TabIndex = 5;
            this.addStaff.Text = "Add";
            this.addStaff.UseVisualStyleBackColor = true;
            this.addStaff.Click += new System.EventHandler(this.addStaff_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 261);
            this.Controls.Add(this.addStaff);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.lbName);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.dgvStaff);
            this.Name = "frmMain";
            this.Text = "Quản Lý Nhân Viên";
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStaff)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvStaff;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button addStaff;
    }
}

