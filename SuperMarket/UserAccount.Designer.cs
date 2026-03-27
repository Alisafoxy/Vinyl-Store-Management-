namespace SuperMarket
{
    partial class UserAccount
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblManageBrand = new System.Windows.Forms.Label();
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.metroTabPage1 = new MetroFramework.Controls.MetroTabPage();
            this.btnCancelAcc = new System.Windows.Forms.Button();
            this.btnSaveAcc = new System.Windows.Forms.Button();
            this.cmbRole = new System.Windows.Forms.ComboBox();
            this.lblFullName = new System.Windows.Forms.Label();
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.txtReTypePassword = new System.Windows.Forms.TextBox();
            this.lblRole = new System.Windows.Forms.Label();
            this.lblReTypePassword = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.lblUserName = new System.Windows.Forms.Label();
            this.metroTabPage3 = new MetroFramework.Controls.MetroTabPage();
            this.dgvUser = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Edit = new System.Windows.Forms.DataGridViewImageColumn();
            this.Delete = new System.Windows.Forms.DataGridViewImageColumn();
            this.metroTabPage2 = new MetroFramework.Controls.MetroTabPage();
            this.btnPassCancel = new System.Windows.Forms.Button();
            this.btnPassSave = new System.Windows.Forms.Button();
            this.txtReTypePass = new System.Windows.Forms.TextBox();
            this.lblReTypePass = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.lblNewPass = new System.Windows.Forms.Label();
            this.txtCurrentPass = new System.Windows.Forms.TextBox();
            this.lblCurrentPas = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.metroTabControl1.SuspendLayout();
            this.metroTabPage1.SuspendLayout();
            this.metroTabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUser)).BeginInit();
            this.metroTabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(163)))), ((int)(((byte)(108)))));
            this.panel1.Controls.Add(this.lblManageBrand);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 428);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1182, 125);
            this.panel1.TabIndex = 3;
            // 
            // lblManageBrand
            // 
            this.lblManageBrand.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblManageBrand.ForeColor = System.Drawing.Color.White;
            this.lblManageBrand.Image = global::SuperMarket.Properties.Resources.Users_Settings2;
            this.lblManageBrand.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblManageBrand.Location = new System.Drawing.Point(12, 21);
            this.lblManageBrand.Name = "lblManageBrand";
            this.lblManageBrand.Size = new System.Drawing.Size(237, 70);
            this.lblManageBrand.TabIndex = 0;
            this.lblManageBrand.Text = "User Settings";
            this.lblManageBrand.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Controls.Add(this.metroTabPage1);
            this.metroTabControl1.Controls.Add(this.metroTabPage3);
            this.metroTabControl1.Controls.Add(this.metroTabPage2);
            this.metroTabControl1.Location = new System.Drawing.Point(16, 12);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 0;
            this.metroTabControl1.Size = new System.Drawing.Size(1154, 425);
            this.metroTabControl1.TabIndex = 4;
            this.metroTabControl1.UseSelectable = true;
            // 
            // metroTabPage1
            // 
            this.metroTabPage1.BackColor = System.Drawing.SystemColors.Control;
            this.metroTabPage1.Controls.Add(this.btnCancelAcc);
            this.metroTabPage1.Controls.Add(this.btnSaveAcc);
            this.metroTabPage1.Controls.Add(this.cmbRole);
            this.metroTabPage1.Controls.Add(this.lblFullName);
            this.metroTabPage1.Controls.Add(this.txtFullName);
            this.metroTabPage1.Controls.Add(this.txtReTypePassword);
            this.metroTabPage1.Controls.Add(this.lblRole);
            this.metroTabPage1.Controls.Add(this.lblReTypePassword);
            this.metroTabPage1.Controls.Add(this.txtPassword);
            this.metroTabPage1.Controls.Add(this.lblPassword);
            this.metroTabPage1.Controls.Add(this.txtUserName);
            this.metroTabPage1.Controls.Add(this.lblUserName);
            this.metroTabPage1.HorizontalScrollbarBarColor = true;
            this.metroTabPage1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.HorizontalScrollbarSize = 5;
            this.metroTabPage1.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage1.Name = "metroTabPage1";
            this.metroTabPage1.Size = new System.Drawing.Size(1146, 383);
            this.metroTabPage1.TabIndex = 0;
            this.metroTabPage1.Text = "Create Account";
            this.metroTabPage1.VerticalScrollbarBarColor = true;
            this.metroTabPage1.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.VerticalScrollbarSize = 4;
            // 
            // btnCancelAcc
            // 
            this.btnCancelAcc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelAcc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(198)))), ((int)(((byte)(142)))));
            this.btnCancelAcc.FlatAppearance.BorderSize = 0;
            this.btnCancelAcc.ForeColor = System.Drawing.Color.White;
            this.btnCancelAcc.Location = new System.Drawing.Point(709, 338);
            this.btnCancelAcc.Name = "btnCancelAcc";
            this.btnCancelAcc.Size = new System.Drawing.Size(128, 45);
            this.btnCancelAcc.TabIndex = 11;
            this.btnCancelAcc.Text = "Cancel";
            this.btnCancelAcc.UseVisualStyleBackColor = false;
            this.btnCancelAcc.Click += new System.EventHandler(this.btnCancelAcc_Click);
            // 
            // btnSaveAcc
            // 
            this.btnSaveAcc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSaveAcc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(106)))), ((int)(((byte)(78)))));
            this.btnSaveAcc.FlatAppearance.BorderSize = 0;
            this.btnSaveAcc.ForeColor = System.Drawing.Color.White;
            this.btnSaveAcc.Location = new System.Drawing.Point(551, 338);
            this.btnSaveAcc.Name = "btnSaveAcc";
            this.btnSaveAcc.Size = new System.Drawing.Size(128, 45);
            this.btnSaveAcc.TabIndex = 10;
            this.btnSaveAcc.Text = "Save";
            this.btnSaveAcc.UseVisualStyleBackColor = false;
            this.btnSaveAcc.Click += new System.EventHandler(this.btnSaveAcc_Click);
            // 
            // cmbRole
            // 
            this.cmbRole.FormattingEnabled = true;
            this.cmbRole.Items.AddRange(new object[] {
            "Administrator",
            "Cashier"});
            this.cmbRole.Location = new System.Drawing.Point(316, 260);
            this.cmbRole.Name = "cmbRole";
            this.cmbRole.Size = new System.Drawing.Size(206, 29);
            this.cmbRole.TabIndex = 4;
            // 
            // lblFullName
            // 
            this.lblFullName.AutoSize = true;
            this.lblFullName.BackColor = System.Drawing.Color.Aquamarine;
            this.lblFullName.Location = new System.Drawing.Point(120, 207);
            this.lblFullName.Name = "lblFullName";
            this.lblFullName.Size = new System.Drawing.Size(100, 21);
            this.lblFullName.TabIndex = 2;
            this.lblFullName.Text = "Full Name:";
            // 
            // txtFullName
            // 
            this.txtFullName.Location = new System.Drawing.Point(316, 198);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(521, 30);
            this.txtFullName.TabIndex = 3;
            // 
            // txtReTypePassword
            // 
            this.txtReTypePassword.Location = new System.Drawing.Point(316, 139);
            this.txtReTypePassword.Name = "txtReTypePassword";
            this.txtReTypePassword.Size = new System.Drawing.Size(521, 30);
            this.txtReTypePassword.TabIndex = 2;
            // 
            // lblRole
            // 
            this.lblRole.AutoSize = true;
            this.lblRole.BackColor = System.Drawing.Color.Aquamarine;
            this.lblRole.Location = new System.Drawing.Point(120, 268);
            this.lblRole.Name = "lblRole";
            this.lblRole.Size = new System.Drawing.Size(53, 21);
            this.lblRole.TabIndex = 2;
            this.lblRole.Text = "Role:";
            // 
            // lblReTypePassword
            // 
            this.lblReTypePassword.AutoSize = true;
            this.lblReTypePassword.BackColor = System.Drawing.Color.Aquamarine;
            this.lblReTypePassword.Location = new System.Drawing.Point(120, 148);
            this.lblReTypePassword.Name = "lblReTypePassword";
            this.lblReTypePassword.Size = new System.Drawing.Size(172, 21);
            this.lblReTypePassword.TabIndex = 2;
            this.lblReTypePassword.Text = "Re-Type Password:";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(316, 83);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(521, 30);
            this.txtPassword.TabIndex = 1;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.BackColor = System.Drawing.Color.Aquamarine;
            this.lblPassword.Location = new System.Drawing.Point(120, 92);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(95, 21);
            this.lblPassword.TabIndex = 2;
            this.lblPassword.Text = "Password:";
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(316, 26);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(521, 30);
            this.txtUserName.TabIndex = 0;
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.BackColor = System.Drawing.Color.Aquamarine;
            this.lblUserName.Location = new System.Drawing.Point(120, 35);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(103, 21);
            this.lblUserName.TabIndex = 2;
            this.lblUserName.Text = "Username:";
            // 
            // metroTabPage3
            // 
            this.metroTabPage3.BackColor = System.Drawing.Color.Transparent;
            this.metroTabPage3.Controls.Add(this.dgvUser);
            this.metroTabPage3.HorizontalScrollbarBarColor = true;
            this.metroTabPage3.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage3.HorizontalScrollbarSize = 5;
            this.metroTabPage3.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage3.Name = "metroTabPage3";
            this.metroTabPage3.Size = new System.Drawing.Size(1146, 383);
            this.metroTabPage3.TabIndex = 2;
            this.metroTabPage3.Text = "Activate/UnActivate Account";
            this.metroTabPage3.VerticalScrollbarBarColor = true;
            this.metroTabPage3.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage3.VerticalScrollbarSize = 4;
            // 
            // dgvUser
            // 
            this.dgvUser.AllowUserToAddRows = false;
            this.dgvUser.BackgroundColor = System.Drawing.Color.White;
            this.dgvUser.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(163)))), ((int)(((byte)(108)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvUser.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvUser.ColumnHeadersHeight = 30;
            this.dgvUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvUser.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Edit,
            this.Delete});
            this.dgvUser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvUser.EnableHeadersVisualStyles = false;
            this.dgvUser.Location = new System.Drawing.Point(0, 0);
            this.dgvUser.Name = "dgvUser";
            this.dgvUser.RowHeadersVisible = false;
            this.dgvUser.RowHeadersWidth = 51;
            this.dgvUser.RowTemplate.Height = 24;
            this.dgvUser.Size = new System.Drawing.Size(1146, 383);
            this.dgvUser.TabIndex = 2;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column1.HeaderText = "No";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 62;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column2.HeaderText = "Id";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Visible = false;
            this.Column2.Width = 56;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column3.HeaderText = "Brand";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Edit
            // 
            this.Edit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Edit.HeaderText = "";
            this.Edit.Image = global::SuperMarket.Properties.Resources.Edit2;
            this.Edit.MinimumWidth = 6;
            this.Edit.Name = "Edit";
            this.Edit.Width = 6;
            // 
            // Delete
            // 
            this.Delete.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Delete.HeaderText = "";
            this.Delete.Image = global::SuperMarket.Properties.Resources.Trash_Can2;
            this.Delete.MinimumWidth = 6;
            this.Delete.Name = "Delete";
            this.Delete.Width = 6;
            // 
            // metroTabPage2
            // 
            this.metroTabPage2.Controls.Add(this.btnPassCancel);
            this.metroTabPage2.Controls.Add(this.btnPassSave);
            this.metroTabPage2.Controls.Add(this.txtReTypePass);
            this.metroTabPage2.Controls.Add(this.lblReTypePass);
            this.metroTabPage2.Controls.Add(this.textBox3);
            this.metroTabPage2.Controls.Add(this.lblNewPass);
            this.metroTabPage2.Controls.Add(this.txtCurrentPass);
            this.metroTabPage2.Controls.Add(this.lblCurrentPas);
            this.metroTabPage2.Controls.Add(this.textBox1);
            this.metroTabPage2.Controls.Add(this.label1);
            this.metroTabPage2.HorizontalScrollbarBarColor = true;
            this.metroTabPage2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.HorizontalScrollbarSize = 5;
            this.metroTabPage2.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage2.Name = "metroTabPage2";
            this.metroTabPage2.Size = new System.Drawing.Size(1146, 383);
            this.metroTabPage2.TabIndex = 1;
            this.metroTabPage2.Text = "Change Password";
            this.metroTabPage2.VerticalScrollbarBarColor = true;
            this.metroTabPage2.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.VerticalScrollbarSize = 4;
            // 
            // btnPassCancel
            // 
            this.btnPassCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPassCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(198)))), ((int)(((byte)(142)))));
            this.btnPassCancel.FlatAppearance.BorderSize = 0;
            this.btnPassCancel.ForeColor = System.Drawing.Color.White;
            this.btnPassCancel.Location = new System.Drawing.Point(619, 342);
            this.btnPassCancel.Name = "btnPassCancel";
            this.btnPassCancel.Size = new System.Drawing.Size(128, 45);
            this.btnPassCancel.TabIndex = 13;
            this.btnPassCancel.Text = "Cancel";
            this.btnPassCancel.UseVisualStyleBackColor = false;
            // 
            // btnPassSave
            // 
            this.btnPassSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPassSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(106)))), ((int)(((byte)(78)))));
            this.btnPassSave.FlatAppearance.BorderSize = 0;
            this.btnPassSave.ForeColor = System.Drawing.Color.White;
            this.btnPassSave.Location = new System.Drawing.Point(447, 342);
            this.btnPassSave.Name = "btnPassSave";
            this.btnPassSave.Size = new System.Drawing.Size(128, 45);
            this.btnPassSave.TabIndex = 12;
            this.btnPassSave.Text = "Save";
            this.btnPassSave.UseVisualStyleBackColor = false;
            // 
            // txtReTypePass
            // 
            this.txtReTypePass.Location = new System.Drawing.Point(322, 258);
            this.txtReTypePass.Name = "txtReTypePass";
            this.txtReTypePass.Size = new System.Drawing.Size(383, 30);
            this.txtReTypePass.TabIndex = 5;
            // 
            // lblReTypePass
            // 
            this.lblReTypePass.AutoSize = true;
            this.lblReTypePass.BackColor = System.Drawing.Color.Aquamarine;
            this.lblReTypePass.Location = new System.Drawing.Point(106, 261);
            this.lblReTypePass.Name = "lblReTypePass";
            this.lblReTypePass.Size = new System.Drawing.Size(167, 21);
            this.lblReTypePass.TabIndex = 4;
            this.lblReTypePass.Text = "Re-Type Password";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(322, 186);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(383, 30);
            this.textBox3.TabIndex = 5;
            // 
            // lblNewPass
            // 
            this.lblNewPass.AutoSize = true;
            this.lblNewPass.BackColor = System.Drawing.Color.Aquamarine;
            this.lblNewPass.Location = new System.Drawing.Point(106, 189);
            this.lblNewPass.Name = "lblNewPass";
            this.lblNewPass.Size = new System.Drawing.Size(139, 21);
            this.lblNewPass.TabIndex = 4;
            this.lblNewPass.Text = "New Password:";
            // 
            // txtCurrentPass
            // 
            this.txtCurrentPass.Location = new System.Drawing.Point(322, 110);
            this.txtCurrentPass.Name = "txtCurrentPass";
            this.txtCurrentPass.Size = new System.Drawing.Size(383, 30);
            this.txtCurrentPass.TabIndex = 5;
            // 
            // lblCurrentPas
            // 
            this.lblCurrentPas.AutoSize = true;
            this.lblCurrentPas.BackColor = System.Drawing.Color.Aquamarine;
            this.lblCurrentPas.Location = new System.Drawing.Point(106, 110);
            this.lblCurrentPas.Name = "lblCurrentPas";
            this.lblCurrentPas.Size = new System.Drawing.Size(166, 21);
            this.lblCurrentPas.TabIndex = 4;
            this.lblCurrentPas.Text = "Current Password:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(322, 46);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(383, 30);
            this.textBox1.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Aquamarine;
            this.label1.Location = new System.Drawing.Point(106, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 21);
            this.label1.TabIndex = 4;
            this.label1.Text = "Username:";
            // 
            // UserAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1182, 553);
            this.ControlBox = false;
            this.Controls.Add(this.metroTabControl1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UserAccount";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UserAccount";
            this.Load += new System.EventHandler(this.UserAccount_Load);
            this.panel1.ResumeLayout(false);
            this.metroTabControl1.ResumeLayout(false);
            this.metroTabPage1.ResumeLayout(false);
            this.metroTabPage1.PerformLayout();
            this.metroTabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUser)).EndInit();
            this.metroTabPage2.ResumeLayout(false);
            this.metroTabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblManageBrand;
        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private MetroFramework.Controls.MetroTabPage metroTabPage1;
        private MetroFramework.Controls.MetroTabPage metroTabPage2;
        private MetroFramework.Controls.MetroTabPage metroTabPage3;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.ComboBox cmbRole;
        private System.Windows.Forms.Label lblFullName;
        private System.Windows.Forms.TextBox txtReTypePassword;
        private System.Windows.Forms.Label lblRole;
        private System.Windows.Forms.Label lblReTypePassword;
        private System.Windows.Forms.TextBox txtFullName;
        public System.Windows.Forms.Button btnCancelAcc;
        public System.Windows.Forms.Button btnSaveAcc;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Button btnPassCancel;
        public System.Windows.Forms.Button btnPassSave;
        private System.Windows.Forms.TextBox txtReTypePass;
        private System.Windows.Forms.Label lblReTypePass;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label lblNewPass;
        private System.Windows.Forms.TextBox txtCurrentPass;
        private System.Windows.Forms.Label lblCurrentPas;
        private System.Windows.Forms.DataGridView dgvUser;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewImageColumn Edit;
        private System.Windows.Forms.DataGridViewImageColumn Delete;
    }
}