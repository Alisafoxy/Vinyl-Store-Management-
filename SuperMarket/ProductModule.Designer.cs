namespace SuperMarket
{
    partial class ProductModule
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
            this.lblId = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnUpdateModule = new System.Windows.Forms.Button();
            this.lblProductCode = new System.Windows.Forms.Label();
            this.txtProductCode = new System.Windows.Forms.TextBox();
            this.txtBarcode = new System.Windows.Forms.TextBox();
            this.lblBarcode = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblBrand = new System.Windows.Forms.Label();
            this.lblCategory = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.lblReOrder = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.numUpDReOrder = new System.Windows.Forms.NumericUpDown();
            this.cmbBrand = new System.Windows.Forms.ComboBox();
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            this.picClose = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDReOrder)).BeginInit();
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
            this.panel1.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "Product Module";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.BackColor = System.Drawing.SystemColors.Control;
            this.lblId.Location = new System.Drawing.Point(12, 392);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(27, 21);
            this.lblId.TabIndex = 14;
            this.lblId.Text = "Id";
            this.lblId.Visible = false;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(198)))), ((int)(((byte)(142)))));
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(658, 380);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(128, 45);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(106)))), ((int)(((byte)(78)))));
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(390, 380);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(128, 45);
            this.btnSave.TabIndex = 7;
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
            this.btnUpdateModule.Location = new System.Drawing.Point(524, 380);
            this.btnUpdateModule.Name = "btnUpdateModule";
            this.btnUpdateModule.Size = new System.Drawing.Size(128, 45);
            this.btnUpdateModule.TabIndex = 8;
            this.btnUpdateModule.Text = "Update";
            this.btnUpdateModule.UseVisualStyleBackColor = false;
            this.btnUpdateModule.Click += new System.EventHandler(this.btnUpdateModule_Click);
            // 
            // lblProductCode
            // 
            this.lblProductCode.AutoSize = true;
            this.lblProductCode.Location = new System.Drawing.Point(12, 78);
            this.lblProductCode.Name = "lblProductCode";
            this.lblProductCode.Size = new System.Drawing.Size(141, 21);
            this.lblProductCode.TabIndex = 11;
            this.lblProductCode.Text = "Product Code:";
            // 
            // txtProductCode
            // 
            this.txtProductCode.Location = new System.Drawing.Point(159, 78);
            this.txtProductCode.Name = "txtProductCode";
            this.txtProductCode.Size = new System.Drawing.Size(247, 30);
            this.txtProductCode.TabIndex = 0;
            // 
            // txtBarcode
            // 
            this.txtBarcode.Location = new System.Drawing.Point(581, 81);
            this.txtBarcode.Name = "txtBarcode";
            this.txtBarcode.Size = new System.Drawing.Size(203, 30);
            this.txtBarcode.TabIndex = 1;
            // 
            // lblBarcode
            // 
            this.lblBarcode.AutoSize = true;
            this.lblBarcode.Location = new System.Drawing.Point(467, 81);
            this.lblBarcode.Name = "lblBarcode";
            this.lblBarcode.Size = new System.Drawing.Size(90, 21);
            this.lblBarcode.TabIndex = 11;
            this.lblBarcode.Text = "Barcode:";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(159, 139);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(625, 30);
            this.txtDescription.TabIndex = 2;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(12, 139);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(112, 21);
            this.lblDescription.TabIndex = 11;
            this.lblDescription.Text = "Description:";
            // 
            // lblBrand
            // 
            this.lblBrand.AutoSize = true;
            this.lblBrand.Location = new System.Drawing.Point(12, 202);
            this.lblBrand.Name = "lblBrand";
            this.lblBrand.Size = new System.Drawing.Size(65, 21);
            this.lblBrand.TabIndex = 11;
            this.lblBrand.Text = "Brand:";
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Location = new System.Drawing.Point(12, 253);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(101, 21);
            this.lblCategory.TabIndex = 11;
            this.lblCategory.Text = "Category:";
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(159, 315);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(247, 30);
            this.txtPrice.TabIndex = 5;
            // 
            // lblReOrder
            // 
            this.lblReOrder.AutoSize = true;
            this.lblReOrder.Location = new System.Drawing.Point(467, 315);
            this.lblReOrder.Name = "lblReOrder";
            this.lblReOrder.Size = new System.Drawing.Size(145, 21);
            this.lblReOrder.TabIndex = 11;
            this.lblReOrder.Text = "Re-Order Level:";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(12, 315);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(58, 21);
            this.lblPrice.TabIndex = 11;
            this.lblPrice.Text = "Price:";
            // 
            // numUpDReOrder
            // 
            this.numUpDReOrder.Location = new System.Drawing.Point(645, 313);
            this.numUpDReOrder.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numUpDReOrder.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numUpDReOrder.Name = "numUpDReOrder";
            this.numUpDReOrder.Size = new System.Drawing.Size(139, 30);
            this.numUpDReOrder.TabIndex = 6;
            this.numUpDReOrder.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numUpDReOrder.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // cmbBrand
            // 
            this.cmbBrand.FormattingEnabled = true;
            this.cmbBrand.Location = new System.Drawing.Point(159, 199);
            this.cmbBrand.Name = "cmbBrand";
            this.cmbBrand.Size = new System.Drawing.Size(625, 29);
            this.cmbBrand.TabIndex = 3;
            // 
            // cmbCategory
            // 
            this.cmbCategory.FormattingEnabled = true;
            this.cmbCategory.Location = new System.Drawing.Point(159, 253);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(625, 29);
            this.cmbCategory.TabIndex = 4;
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
            // ProductModule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(814, 448);
            this.Controls.Add(this.cmbCategory);
            this.Controls.Add(this.cmbBrand);
            this.Controls.Add(this.numUpDReOrder);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnUpdateModule);
            this.Controls.Add(this.lblReOrder);
            this.Controls.Add(this.lblCategory);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.lblBrand);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.lblBarcode);
            this.Controls.Add(this.txtBarcode);
            this.Controls.Add(this.lblProductCode);
            this.Controls.Add(this.txtProductCode);
            this.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ProductModule";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ProductModule";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDReOrder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picClose)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox picClose;
        public System.Windows.Forms.Button btnCancel;
        public System.Windows.Forms.Button btnSave;
        public System.Windows.Forms.Button btnUpdateModule;
        private System.Windows.Forms.Label lblProductCode;
        public System.Windows.Forms.TextBox txtProductCode;
        public System.Windows.Forms.Label lblId;
        public System.Windows.Forms.TextBox txtBarcode;
        private System.Windows.Forms.Label lblBarcode;
        public System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblBrand;
        private System.Windows.Forms.Label lblCategory;
        public System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label lblReOrder;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.ComboBox cmbBrand;
        public System.Windows.Forms.NumericUpDown numUpDReOrder;
        public System.Windows.Forms.ComboBox cmbCategory;
    }
}