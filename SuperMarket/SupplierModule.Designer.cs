namespace SuperMarket
{
    partial class SupplierModule
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.picClose = new System.Windows.Forms.PictureBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnUpdateModule = new System.Windows.Forms.Button();
            this.lblId = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblContactPerson = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.lblSupplierName = new System.Windows.Forms.Label();
            this.txtSupplierName = new System.Windows.Forms.TextBox();
            this.txtContactP = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.lblFax = new System.Windows.Forms.Label();
            this.txtFax = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picClose)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(163)))), ((int)(((byte)(108)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.picClose);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(814, 57);
            this.panel1.TabIndex = 24;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "Supplier Module";
            // 
            // picClose
            // 
            this.picClose.Image = global::SuperMarket.Properties.Resources.Cancel;
            this.picClose.Location = new System.Drawing.Point(750, 4);
            this.picClose.Name = "picClose";
            this.picClose.Size = new System.Drawing.Size(52, 50);
            this.picClose.TabIndex = 1;
            this.picClose.TabStop = false;
            this.picClose.Click += new System.EventHandler(this.picClose_Click);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(106)))), ((int)(((byte)(78)))));
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(390, 392);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(128, 45);
            this.btnSave.TabIndex = 22;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnUpdateModule
            // 
            this.btnUpdateModule.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUpdateModule.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(163)))), ((int)(((byte)(108)))));
            this.btnUpdateModule.FlatAppearance.BorderSize = 0;
            this.btnUpdateModule.ForeColor = System.Drawing.Color.White;
            this.btnUpdateModule.Location = new System.Drawing.Point(524, 392);
            this.btnUpdateModule.Name = "btnUpdateModule";
            this.btnUpdateModule.Size = new System.Drawing.Size(128, 45);
            this.btnUpdateModule.TabIndex = 23;
            this.btnUpdateModule.Text = "Update";
            this.btnUpdateModule.UseVisualStyleBackColor = false;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.BackColor = System.Drawing.SystemColors.Control;
            this.lblId.Location = new System.Drawing.Point(12, 404);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(27, 21);
            this.lblId.TabIndex = 33;
            this.lblId.Text = "Id";
            this.lblId.Visible = false;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(198)))), ((int)(((byte)(142)))));
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(658, 392);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(128, 45);
            this.btnCancel.TabIndex = 25;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(10, 283);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(102, 21);
            this.lblPhone.TabIndex = 32;
            this.lblPhone.Text = "Phone No:";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(12, 336);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(141, 21);
            this.lblPrice.TabIndex = 28;
            this.lblPrice.Text = "E-Mail Address:";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(185, 333);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(601, 30);
            this.txtEmail.TabIndex = 5;
            // 
            // lblContactPerson
            // 
            this.lblContactPerson.AutoSize = true;
            this.lblContactPerson.Location = new System.Drawing.Point(10, 227);
            this.lblContactPerson.Name = "lblContactPerson";
            this.lblContactPerson.Size = new System.Drawing.Size(154, 21);
            this.lblContactPerson.TabIndex = 29;
            this.lblContactPerson.Text = "Contact Person:";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(10, 158);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(85, 21);
            this.lblAddress.TabIndex = 30;
            this.lblAddress.Text = "Address:";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(185, 149);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(601, 30);
            this.txtAddress.TabIndex = 1;
            // 
            // lblSupplierName
            // 
            this.lblSupplierName.AutoSize = true;
            this.lblSupplierName.Location = new System.Drawing.Point(10, 99);
            this.lblSupplierName.Name = "lblSupplierName";
            this.lblSupplierName.Size = new System.Drawing.Size(141, 21);
            this.lblSupplierName.TabIndex = 27;
            this.lblSupplierName.Text = "Supplier Name:";
            // 
            // txtSupplierName
            // 
            this.txtSupplierName.Location = new System.Drawing.Point(183, 90);
            this.txtSupplierName.Name = "txtSupplierName";
            this.txtSupplierName.Size = new System.Drawing.Size(601, 30);
            this.txtSupplierName.TabIndex = 0;
            // 
            // txtContactP
            // 
            this.txtContactP.Location = new System.Drawing.Point(183, 218);
            this.txtContactP.Name = "txtContactP";
            this.txtContactP.Size = new System.Drawing.Size(601, 30);
            this.txtContactP.TabIndex = 2;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(183, 274);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(233, 30);
            this.txtPhone.TabIndex = 3;
            // 
            // lblFax
            // 
            this.lblFax.AutoSize = true;
            this.lblFax.Location = new System.Drawing.Point(443, 283);
            this.lblFax.Name = "lblFax";
            this.lblFax.Size = new System.Drawing.Size(75, 21);
            this.lblFax.TabIndex = 36;
            this.lblFax.Text = "Fax No:";
            // 
            // txtFax
            // 
            this.txtFax.Location = new System.Drawing.Point(551, 274);
            this.txtFax.Name = "txtFax";
            this.txtFax.Size = new System.Drawing.Size(233, 30);
            this.txtFax.TabIndex = 4;
            // 
            // SupplierModule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(814, 448);
            this.Controls.Add(this.txtFax);
            this.Controls.Add(this.lblFax);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.txtContactP);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnUpdateModule);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblContactPerson);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.lblSupplierName);
            this.Controls.Add(this.txtSupplierName);
            this.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "SupplierModule";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SupplierModule";
            this.Load += new System.EventHandler(this.SupplierModule_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picClose)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picClose;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Button btnSave;
        public System.Windows.Forms.Button btnUpdateModule;
        public System.Windows.Forms.Label lblId;
        public System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblPrice;
        public System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblContactPerson;
        private System.Windows.Forms.Label lblAddress;
        public System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label lblSupplierName;
        public System.Windows.Forms.TextBox txtSupplierName;
        public System.Windows.Forms.TextBox txtContactP;
        public System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label lblFax;
        public System.Windows.Forms.TextBox txtFax;
    }
}