namespace WarehouseManager
{
	partial class Shipping
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
			this.staShipping = new System.Windows.Forms.StatusStrip();
			this.tslLoggedUser = new System.Windows.Forms.ToolStripStatusLabel();
			this.tslServerStatus = new System.Windows.Forms.ToolStripStatusLabel();
			this.menShipping = new System.Windows.Forms.MenuStrip();
			this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.serverToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.connectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.disconnectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.usersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.btnNewShipment = new System.Windows.Forms.Button();
			this.txtProductSKU = new System.Windows.Forms.TextBox();
			this.labShipmentID = new System.Windows.Forms.Label();
			this.labLacationID = new System.Windows.Forms.Label();
			this.cboDestination = new System.Windows.Forms.ComboBox();
			this.dgvPendingShipment = new System.Windows.Forms.DataGridView();
			this.panShipDetail = new System.Windows.Forms.Panel();
			this.txtSKU = new System.Windows.Forms.TextBox();
			this.btnCreate = new System.Windows.Forms.Button();
			this.labDate = new System.Windows.Forms.Label();
			this.btnRemoveProduct = new System.Windows.Forms.Button();
			this.btnAddProduct = new System.Windows.Forms.Button();
			this.lstShipProducts = new System.Windows.Forms.ListView();
			this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.labQuantity = new System.Windows.Forms.Label();
			this.txtProductQuantity = new System.Windows.Forms.TextBox();
			this.labProductID = new System.Windows.Forms.Label();
			this.labShipID_Display = new System.Windows.Forms.Label();
			this.btnLoadShipment = new System.Windows.Forms.Button();
			this.btnMarkShipped = new System.Windows.Forms.Button();
			this.staShipping.SuspendLayout();
			this.menShipping.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvPendingShipment)).BeginInit();
			this.panShipDetail.SuspendLayout();
			this.SuspendLayout();
			// 
			// staShipping
			// 
			this.staShipping.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tslLoggedUser,
            this.tslServerStatus});
			this.staShipping.Location = new System.Drawing.Point(0, 479);
			this.staShipping.Name = "staShipping";
			this.staShipping.Size = new System.Drawing.Size(1035, 22);
			this.staShipping.TabIndex = 8;
			this.staShipping.Text = "statusStrip1";
			// 
			// tslLoggedUser
			// 
			this.tslLoggedUser.Name = "tslLoggedUser";
			this.tslLoggedUser.Size = new System.Drawing.Size(62, 17);
			this.tslLoggedUser.Text = "UserName";
			// 
			// tslServerStatus
			// 
			this.tslServerStatus.Name = "tslServerStatus";
			this.tslServerStatus.Size = new System.Drawing.Size(39, 17);
			this.tslServerStatus.Text = "Status";
			// 
			// menShipping
			// 
			this.menShipping.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.usersToolStripMenuItem,
            this.helpToolStripMenuItem});
			this.menShipping.Location = new System.Drawing.Point(0, 0);
			this.menShipping.Name = "menShipping";
			this.menShipping.Size = new System.Drawing.Size(1035, 24);
			this.menShipping.TabIndex = 9;
			this.menShipping.Text = "menuStrip1";
			// 
			// fileToolStripMenuItem
			// 
			this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.serverToolStripMenuItem});
			this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
			this.fileToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
			this.fileToolStripMenuItem.Text = "System";
			// 
			// serverToolStripMenuItem
			// 
			this.serverToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.connectToolStripMenuItem,
            this.disconnectToolStripMenuItem});
			this.serverToolStripMenuItem.Name = "serverToolStripMenuItem";
			this.serverToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.serverToolStripMenuItem.Text = "Server";
			// 
			// connectToolStripMenuItem
			// 
			this.connectToolStripMenuItem.Name = "connectToolStripMenuItem";
			this.connectToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.connectToolStripMenuItem.Text = "Connect";
			this.connectToolStripMenuItem.Click += new System.EventHandler(this.connectToolStripMenuItem_Click);
			// 
			// disconnectToolStripMenuItem
			// 
			this.disconnectToolStripMenuItem.Name = "disconnectToolStripMenuItem";
			this.disconnectToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.disconnectToolStripMenuItem.Text = "Disconnect";
			this.disconnectToolStripMenuItem.Click += new System.EventHandler(this.disconnectToolStripMenuItem_Click_1);
			// 
			// usersToolStripMenuItem
			// 
			this.usersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logOutToolStripMenuItem});
			this.usersToolStripMenuItem.Name = "usersToolStripMenuItem";
			this.usersToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
			this.usersToolStripMenuItem.Text = "Users";
			// 
			// logOutToolStripMenuItem
			// 
			this.logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
			this.logOutToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.logOutToolStripMenuItem.Text = "Log Out";
			this.logOutToolStripMenuItem.Click += new System.EventHandler(this.logOutToolStripMenuItem_Click_1);
			// 
			// helpToolStripMenuItem
			// 
			this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
			this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
			this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
			this.helpToolStripMenuItem.Text = "Help";
			// 
			// aboutToolStripMenuItem
			// 
			this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
			this.aboutToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.aboutToolStripMenuItem.Text = "About...";
			this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
			// 
			// btnNewShipment
			// 
			this.btnNewShipment.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnNewShipment.Location = new System.Drawing.Point(554, 27);
			this.btnNewShipment.Name = "btnNewShipment";
			this.btnNewShipment.Size = new System.Drawing.Size(121, 29);
			this.btnNewShipment.TabIndex = 20;
			this.btnNewShipment.Text = "New Shipment";
			this.btnNewShipment.UseVisualStyleBackColor = true;
			this.btnNewShipment.Click += new System.EventHandler(this.btnNewShipment_Click);
			// 
			// txtProductSKU
			// 
			this.txtProductSKU.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtProductSKU.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.txtProductSKU.Location = new System.Drawing.Point(138, 27);
			this.txtProductSKU.Name = "txtProductSKU";
			this.txtProductSKU.Size = new System.Drawing.Size(127, 29);
			this.txtProductSKU.TabIndex = 17;
			// 
			// labShipmentID
			// 
			this.labShipmentID.AutoSize = true;
			this.labShipmentID.Font = new System.Drawing.Font("Lucida Console", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labShipmentID.Location = new System.Drawing.Point(2, 33);
			this.labShipmentID.Name = "labShipmentID";
			this.labShipmentID.Size = new System.Drawing.Size(130, 19);
			this.labShipmentID.TabIndex = 15;
			this.labShipmentID.Text = "Shipment ID";
			// 
			// labLacationID
			// 
			this.labLacationID.AutoSize = true;
			this.labLacationID.Font = new System.Drawing.Font("Lucida Console", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labLacationID.Location = new System.Drawing.Point(724, 34);
			this.labLacationID.Name = "labLacationID";
			this.labLacationID.Size = new System.Drawing.Size(130, 19);
			this.labLacationID.TabIndex = 14;
			this.labLacationID.Text = "Destination";
			// 
			// cboDestination
			// 
			this.cboDestination.Enabled = false;
			this.cboDestination.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cboDestination.FormattingEnabled = true;
			this.cboDestination.Location = new System.Drawing.Point(858, 28);
			this.cboDestination.Name = "cboDestination";
			this.cboDestination.Size = new System.Drawing.Size(176, 28);
			this.cboDestination.TabIndex = 22;
			// 
			// dgvPendingShipment
			// 
			this.dgvPendingShipment.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
			this.dgvPendingShipment.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
			this.dgvPendingShipment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvPendingShipment.Location = new System.Drawing.Point(6, 62);
			this.dgvPendingShipment.MultiSelect = false;
			this.dgvPendingShipment.Name = "dgvPendingShipment";
			this.dgvPendingShipment.ReadOnly = true;
			this.dgvPendingShipment.Size = new System.Drawing.Size(543, 379);
			this.dgvPendingShipment.TabIndex = 23;
			// 
			// panShipDetail
			// 
			this.panShipDetail.Controls.Add(this.txtSKU);
			this.panShipDetail.Controls.Add(this.btnCreate);
			this.panShipDetail.Controls.Add(this.labDate);
			this.panShipDetail.Controls.Add(this.btnRemoveProduct);
			this.panShipDetail.Controls.Add(this.btnAddProduct);
			this.panShipDetail.Controls.Add(this.lstShipProducts);
			this.panShipDetail.Controls.Add(this.labQuantity);
			this.panShipDetail.Controls.Add(this.txtProductQuantity);
			this.panShipDetail.Controls.Add(this.labProductID);
			this.panShipDetail.Controls.Add(this.labShipID_Display);
			this.panShipDetail.Location = new System.Drawing.Point(555, 63);
			this.panShipDetail.Name = "panShipDetail";
			this.panShipDetail.Size = new System.Drawing.Size(478, 414);
			this.panShipDetail.TabIndex = 24;
			// 
			// txtSKU
			// 
			this.txtSKU.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtSKU.Enabled = false;
			this.txtSKU.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.txtSKU.Location = new System.Drawing.Point(139, 4);
			this.txtSKU.Name = "txtSKU";
			this.txtSKU.Size = new System.Drawing.Size(131, 29);
			this.txtSKU.TabIndex = 34;
			// 
			// btnCreate
			// 
			this.btnCreate.Enabled = false;
			this.btnCreate.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnCreate.Location = new System.Drawing.Point(317, 36);
			this.btnCreate.Name = "btnCreate";
			this.btnCreate.Size = new System.Drawing.Size(150, 29);
			this.btnCreate.TabIndex = 33;
			this.btnCreate.Text = "Create Shipment";
			this.btnCreate.UseVisualStyleBackColor = true;
			this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
			// 
			// labDate
			// 
			this.labDate.Font = new System.Drawing.Font("Lucida Console", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labDate.Location = new System.Drawing.Point(261, 391);
			this.labDate.Name = "labDate";
			this.labDate.Size = new System.Drawing.Size(212, 19);
			this.labDate.TabIndex = 31;
			this.labDate.Text = "Current Date";
			this.labDate.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// btnRemoveProduct
			// 
			this.btnRemoveProduct.Enabled = false;
			this.btnRemoveProduct.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnRemoveProduct.Location = new System.Drawing.Point(94, 36);
			this.btnRemoveProduct.Name = "btnRemoveProduct";
			this.btnRemoveProduct.Size = new System.Drawing.Size(85, 29);
			this.btnRemoveProduct.TabIndex = 22;
			this.btnRemoveProduct.Text = "Remove";
			this.btnRemoveProduct.UseVisualStyleBackColor = true;
			this.btnRemoveProduct.Click += new System.EventHandler(this.btnRemoveProduct_Click);
			// 
			// btnAddProduct
			// 
			this.btnAddProduct.Enabled = false;
			this.btnAddProduct.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnAddProduct.Location = new System.Drawing.Point(3, 36);
			this.btnAddProduct.Name = "btnAddProduct";
			this.btnAddProduct.Size = new System.Drawing.Size(85, 29);
			this.btnAddProduct.TabIndex = 21;
			this.btnAddProduct.Text = "Add";
			this.btnAddProduct.UseVisualStyleBackColor = true;
			this.btnAddProduct.Click += new System.EventHandler(this.btnAddProduct_Click);
			// 
			// lstShipProducts
			// 
			this.lstShipProducts.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
			this.lstShipProducts.FullRowSelect = true;
			this.lstShipProducts.GridLines = true;
			this.lstShipProducts.Location = new System.Drawing.Point(0, 71);
			this.lstShipProducts.MultiSelect = false;
			this.lstShipProducts.Name = "lstShipProducts";
			this.lstShipProducts.Size = new System.Drawing.Size(473, 308);
			this.lstShipProducts.TabIndex = 30;
			this.lstShipProducts.UseCompatibleStateImageBehavior = false;
			this.lstShipProducts.View = System.Windows.Forms.View.Details;
			// 
			// columnHeader1
			// 
			this.columnHeader1.Text = "SKU";
			this.columnHeader1.Width = 62;
			// 
			// columnHeader2
			// 
			this.columnHeader2.Text = "PRODUCT";
			this.columnHeader2.Width = 276;
			// 
			// columnHeader3
			// 
			this.columnHeader3.Text = "QUANTITY";
			this.columnHeader3.Width = 128;
			// 
			// labQuantity
			// 
			this.labQuantity.AutoSize = true;
			this.labQuantity.Font = new System.Drawing.Font("Lucida Console", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labQuantity.Location = new System.Drawing.Point(276, 9);
			this.labQuantity.Name = "labQuantity";
			this.labQuantity.Size = new System.Drawing.Size(97, 19);
			this.labQuantity.TabIndex = 28;
			this.labQuantity.Text = "Quantity";
			// 
			// txtProductQuantity
			// 
			this.txtProductQuantity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtProductQuantity.Enabled = false;
			this.txtProductQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.txtProductQuantity.Location = new System.Drawing.Point(379, 4);
			this.txtProductQuantity.Name = "txtProductQuantity";
			this.txtProductQuantity.Size = new System.Drawing.Size(88, 29);
			this.txtProductQuantity.TabIndex = 27;
			// 
			// labProductID
			// 
			this.labProductID.AutoSize = true;
			this.labProductID.Font = new System.Drawing.Font("Lucida Console", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labProductID.Location = new System.Drawing.Point(3, 9);
			this.labProductID.Name = "labProductID";
			this.labProductID.Size = new System.Drawing.Size(130, 19);
			this.labProductID.TabIndex = 25;
			this.labProductID.Text = "Product SKU";
			// 
			// labShipID_Display
			// 
			this.labShipID_Display.AutoSize = true;
			this.labShipID_Display.Font = new System.Drawing.Font("Lucida Console", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labShipID_Display.Location = new System.Drawing.Point(3, 391);
			this.labShipID_Display.Name = "labShipID_Display";
			this.labShipID_Display.Size = new System.Drawing.Size(42, 19);
			this.labShipID_Display.TabIndex = 16;
			this.labShipID_Display.Text = "---";
			// 
			// btnLoadShipment
			// 
			this.btnLoadShipment.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnLoadShipment.Location = new System.Drawing.Point(429, 28);
			this.btnLoadShipment.Name = "btnLoadShipment";
			this.btnLoadShipment.Size = new System.Drawing.Size(121, 29);
			this.btnLoadShipment.TabIndex = 25;
			this.btnLoadShipment.Text = "Load Shipment";
			this.btnLoadShipment.UseVisualStyleBackColor = true;
			this.btnLoadShipment.Click += new System.EventHandler(this.btnLoadShipment_Click);
			// 
			// btnMarkShipped
			// 
			this.btnMarkShipped.Enabled = false;
			this.btnMarkShipped.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnMarkShipped.Location = new System.Drawing.Point(402, 444);
			this.btnMarkShipped.Name = "btnMarkShipped";
			this.btnMarkShipped.Size = new System.Drawing.Size(147, 29);
			this.btnMarkShipped.TabIndex = 26;
			this.btnMarkShipped.Text = "Mark as Shipped";
			this.btnMarkShipped.UseVisualStyleBackColor = true;
			this.btnMarkShipped.Click += new System.EventHandler(this.btnMarkShipped_Click);
			// 
			// Shipping
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1035, 501);
			this.Controls.Add(this.btnMarkShipped);
			this.Controls.Add(this.btnLoadShipment);
			this.Controls.Add(this.panShipDetail);
			this.Controls.Add(this.dgvPendingShipment);
			this.Controls.Add(this.cboDestination);
			this.Controls.Add(this.btnNewShipment);
			this.Controls.Add(this.txtProductSKU);
			this.Controls.Add(this.labShipmentID);
			this.Controls.Add(this.labLacationID);
			this.Controls.Add(this.menShipping);
			this.Controls.Add(this.staShipping);
			this.Name = "Shipping";
			this.Text = "Warehouse Manager - Shipping";
			this.Load += new System.EventHandler(this.Shipping_Load);
			this.staShipping.ResumeLayout(false);
			this.staShipping.PerformLayout();
			this.menShipping.ResumeLayout(false);
			this.menShipping.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvPendingShipment)).EndInit();
			this.panShipDetail.ResumeLayout(false);
			this.panShipDetail.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.StatusStrip staShipping;
		private System.Windows.Forms.ToolStripStatusLabel tslLoggedUser;
		private System.Windows.Forms.ToolStripStatusLabel tslServerStatus;
		private System.Windows.Forms.MenuStrip menShipping;
		private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem serverToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem connectToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem disconnectToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem usersToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
		private System.Windows.Forms.Button btnNewShipment;
		private System.Windows.Forms.TextBox txtProductSKU;
		private System.Windows.Forms.Label labShipmentID;
		private System.Windows.Forms.Label labLacationID;
		private System.Windows.Forms.ComboBox cboDestination;
		private System.Windows.Forms.DataGridView dgvPendingShipment;
		private System.Windows.Forms.Panel panShipDetail;
		private System.Windows.Forms.Button btnRemoveProduct;
		private System.Windows.Forms.Button btnAddProduct;
		private System.Windows.Forms.ListView lstShipProducts;
		private System.Windows.Forms.Label labQuantity;
		private System.Windows.Forms.TextBox txtProductQuantity;
		private System.Windows.Forms.Label labProductID;
		private System.Windows.Forms.Label labShipID_Display;
		private System.Windows.Forms.Label labDate;
		private System.Windows.Forms.Button btnLoadShipment;
		private System.Windows.Forms.Button btnCreate;
		private System.Windows.Forms.Button btnMarkShipped;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
		private System.Windows.Forms.TextBox txtSKU;
		private System.Windows.Forms.ColumnHeader columnHeader3;
    }
}