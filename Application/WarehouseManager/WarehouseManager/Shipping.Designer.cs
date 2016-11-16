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
			this.importToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.exportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.orderByToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.orderByToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.filterByToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.usersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.btnNewShipment = new System.Windows.Forms.Button();
			this.txtProductSKU = new System.Windows.Forms.TextBox();
			this.labShipmentID = new System.Windows.Forms.Label();
			this.labLacationID = new System.Windows.Forms.Label();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.dgvPendingShipment = new System.Windows.Forms.DataGridView();
			this.panShipDetail = new System.Windows.Forms.Panel();
			this.labDate = new System.Windows.Forms.Label();
			this.btnRemoveProduct = new System.Windows.Forms.Button();
			this.btnAddProduct = new System.Windows.Forms.Button();
			this.listView1 = new System.Windows.Forms.ListView();
			this.labQuantity = new System.Windows.Forms.Label();
			this.txtProductQuantity = new System.Windows.Forms.TextBox();
			this.cboProductID = new System.Windows.Forms.ComboBox();
			this.labProductID = new System.Windows.Forms.Label();
			this.labShipID_Display = new System.Windows.Forms.Label();
			this.btnLoadShipment = new System.Windows.Forms.Button();
			this.btnCreate = new System.Windows.Forms.Button();
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
			this.staShipping.Size = new System.Drawing.Size(944, 22);
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
            this.orderByToolStripMenuItem,
            this.usersToolStripMenuItem,
            this.helpToolStripMenuItem});
			this.menShipping.Location = new System.Drawing.Point(0, 0);
			this.menShipping.Name = "menShipping";
			this.menShipping.Size = new System.Drawing.Size(944, 24);
			this.menShipping.TabIndex = 9;
			this.menShipping.Text = "menuStrip1";
			// 
			// fileToolStripMenuItem
			// 
			this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.serverToolStripMenuItem,
            this.importToolStripMenuItem,
            this.exportToolStripMenuItem});
			this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
			this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
			this.fileToolStripMenuItem.Text = "File";
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
			// 
			// disconnectToolStripMenuItem
			// 
			this.disconnectToolStripMenuItem.Name = "disconnectToolStripMenuItem";
			this.disconnectToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.disconnectToolStripMenuItem.Text = "Disconnect";
			// 
			// importToolStripMenuItem
			// 
			this.importToolStripMenuItem.Name = "importToolStripMenuItem";
			this.importToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.importToolStripMenuItem.Text = "Import...";
			// 
			// exportToolStripMenuItem
			// 
			this.exportToolStripMenuItem.Name = "exportToolStripMenuItem";
			this.exportToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.exportToolStripMenuItem.Text = "Export...";
			// 
			// orderByToolStripMenuItem
			// 
			this.orderByToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.orderByToolStripMenuItem1,
            this.filterByToolStripMenuItem});
			this.orderByToolStripMenuItem.Name = "orderByToolStripMenuItem";
			this.orderByToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
			this.orderByToolStripMenuItem.Text = "Tools";
			// 
			// orderByToolStripMenuItem1
			// 
			this.orderByToolStripMenuItem1.Name = "orderByToolStripMenuItem1";
			this.orderByToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
			this.orderByToolStripMenuItem1.Text = "Order By";
			// 
			// filterByToolStripMenuItem
			// 
			this.filterByToolStripMenuItem.Name = "filterByToolStripMenuItem";
			this.filterByToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.filterByToolStripMenuItem.Text = "Filter By";
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
			// 
			// btnNewShipment
			// 
			this.btnNewShipment.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnNewShipment.Location = new System.Drawing.Point(11, 201);
			this.btnNewShipment.Name = "btnNewShipment";
			this.btnNewShipment.Size = new System.Drawing.Size(121, 29);
			this.btnNewShipment.TabIndex = 20;
			this.btnNewShipment.Text = "New Shipment";
			this.btnNewShipment.UseVisualStyleBackColor = true;
			// 
			// txtProductSKU
			// 
			this.txtProductSKU.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtProductSKU.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.txtProductSKU.Location = new System.Drawing.Point(138, 98);
			this.txtProductSKU.Name = "txtProductSKU";
			this.txtProductSKU.Size = new System.Drawing.Size(127, 29);
			this.txtProductSKU.TabIndex = 17;
			// 
			// labShipmentID
			// 
			this.labShipmentID.AutoSize = true;
			this.labShipmentID.Font = new System.Drawing.Font("Lucida Console", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labShipmentID.Location = new System.Drawing.Point(2, 104);
			this.labShipmentID.Name = "labShipmentID";
			this.labShipmentID.Size = new System.Drawing.Size(130, 19);
			this.labShipmentID.TabIndex = 15;
			this.labShipmentID.Text = "Shipment ID";
			// 
			// labLacationID
			// 
			this.labLacationID.AutoSize = true;
			this.labLacationID.Font = new System.Drawing.Font("Lucida Console", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labLacationID.Location = new System.Drawing.Point(2, 139);
			this.labLacationID.Name = "labLacationID";
			this.labLacationID.Size = new System.Drawing.Size(130, 19);
			this.labLacationID.TabIndex = 14;
			this.labLacationID.Text = "Location ID";
			// 
			// comboBox1
			// 
			this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Location = new System.Drawing.Point(138, 133);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(200, 28);
			this.comboBox1.TabIndex = 22;
			// 
			// dgvPendingShipment
			// 
			this.dgvPendingShipment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvPendingShipment.Location = new System.Drawing.Point(138, 167);
			this.dgvPendingShipment.Name = "dgvPendingShipment";
			this.dgvPendingShipment.Size = new System.Drawing.Size(329, 309);
			this.dgvPendingShipment.TabIndex = 23;
			// 
			// panShipDetail
			// 
			this.panShipDetail.Controls.Add(this.btnCreate);
			this.panShipDetail.Controls.Add(this.labDate);
			this.panShipDetail.Controls.Add(this.btnRemoveProduct);
			this.panShipDetail.Controls.Add(this.btnAddProduct);
			this.panShipDetail.Controls.Add(this.listView1);
			this.panShipDetail.Controls.Add(this.labQuantity);
			this.panShipDetail.Controls.Add(this.txtProductQuantity);
			this.panShipDetail.Controls.Add(this.cboProductID);
			this.panShipDetail.Controls.Add(this.labProductID);
			this.panShipDetail.Controls.Add(this.labShipID_Display);
			this.panShipDetail.Location = new System.Drawing.Point(474, 167);
			this.panShipDetail.Name = "panShipDetail";
			this.panShipDetail.Size = new System.Drawing.Size(470, 309);
			this.panShipDetail.TabIndex = 24;
			// 
			// labDate
			// 
			this.labDate.AutoSize = true;
			this.labDate.Font = new System.Drawing.Font("Lucida Console", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labDate.Location = new System.Drawing.Point(326, 282);
			this.labDate.Name = "labDate";
			this.labDate.Size = new System.Drawing.Size(141, 19);
			this.labDate.TabIndex = 31;
			this.labDate.Text = "Current Date";
			// 
			// btnRemoveProduct
			// 
			this.btnRemoveProduct.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnRemoveProduct.Location = new System.Drawing.Point(3, 71);
			this.btnRemoveProduct.Name = "btnRemoveProduct";
			this.btnRemoveProduct.Size = new System.Drawing.Size(85, 29);
			this.btnRemoveProduct.TabIndex = 22;
			this.btnRemoveProduct.Text = "Remove";
			this.btnRemoveProduct.UseVisualStyleBackColor = true;
			// 
			// btnAddProduct
			// 
			this.btnAddProduct.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnAddProduct.Location = new System.Drawing.Point(3, 36);
			this.btnAddProduct.Name = "btnAddProduct";
			this.btnAddProduct.Size = new System.Drawing.Size(85, 29);
			this.btnAddProduct.TabIndex = 21;
			this.btnAddProduct.Text = "Add";
			this.btnAddProduct.UseVisualStyleBackColor = true;
			// 
			// listView1
			// 
			this.listView1.Location = new System.Drawing.Point(94, 36);
			this.listView1.Name = "listView1";
			this.listView1.Size = new System.Drawing.Size(373, 243);
			this.listView1.TabIndex = 30;
			this.listView1.UseCompatibleStateImageBehavior = false;
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
			this.txtProductQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.txtProductQuantity.Location = new System.Drawing.Point(379, 4);
			this.txtProductQuantity.Name = "txtProductQuantity";
			this.txtProductQuantity.Size = new System.Drawing.Size(88, 29);
			this.txtProductQuantity.TabIndex = 27;
			// 
			// cboProductID
			// 
			this.cboProductID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cboProductID.FormattingEnabled = true;
			this.cboProductID.Location = new System.Drawing.Point(124, 5);
			this.cboProductID.Name = "cboProductID";
			this.cboProductID.Size = new System.Drawing.Size(146, 28);
			this.cboProductID.TabIndex = 26;
			// 
			// labProductID
			// 
			this.labProductID.AutoSize = true;
			this.labProductID.Font = new System.Drawing.Font("Lucida Console", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labProductID.Location = new System.Drawing.Point(3, 9);
			this.labProductID.Name = "labProductID";
			this.labProductID.Size = new System.Drawing.Size(119, 19);
			this.labProductID.TabIndex = 25;
			this.labProductID.Text = "Product ID";
			// 
			// labShipID_Display
			// 
			this.labShipID_Display.AutoSize = true;
			this.labShipID_Display.Font = new System.Drawing.Font("Lucida Console", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labShipID_Display.Location = new System.Drawing.Point(3, 282);
			this.labShipID_Display.Name = "labShipID_Display";
			this.labShipID_Display.Size = new System.Drawing.Size(130, 19);
			this.labShipID_Display.TabIndex = 16;
			this.labShipID_Display.Text = "Shipment ID";
			// 
			// btnLoadShipment
			// 
			this.btnLoadShipment.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnLoadShipment.Location = new System.Drawing.Point(11, 166);
			this.btnLoadShipment.Name = "btnLoadShipment";
			this.btnLoadShipment.Size = new System.Drawing.Size(121, 29);
			this.btnLoadShipment.TabIndex = 25;
			this.btnLoadShipment.Text = "Load Shipment";
			this.btnLoadShipment.UseVisualStyleBackColor = true;
			// 
			// btnCreate
			// 
			this.btnCreate.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnCreate.Location = new System.Drawing.Point(3, 250);
			this.btnCreate.Name = "btnCreate";
			this.btnCreate.Size = new System.Drawing.Size(85, 29);
			this.btnCreate.TabIndex = 33;
			this.btnCreate.Text = "Create";
			this.btnCreate.UseVisualStyleBackColor = true;
			// 
			// Shipping
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(944, 501);
			this.Controls.Add(this.btnLoadShipment);
			this.Controls.Add(this.panShipDetail);
			this.Controls.Add(this.dgvPendingShipment);
			this.Controls.Add(this.comboBox1);
			this.Controls.Add(this.btnNewShipment);
			this.Controls.Add(this.txtProductSKU);
			this.Controls.Add(this.labShipmentID);
			this.Controls.Add(this.labLacationID);
			this.Controls.Add(this.menShipping);
			this.Controls.Add(this.staShipping);
			this.Name = "Shipping";
			this.Text = "Warehouse Manager - Shipping";
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
		private System.Windows.Forms.ToolStripMenuItem importToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem exportToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem orderByToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem orderByToolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem filterByToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem usersToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
		private System.Windows.Forms.Button btnNewShipment;
		private System.Windows.Forms.TextBox txtProductSKU;
		private System.Windows.Forms.Label labShipmentID;
		private System.Windows.Forms.Label labLacationID;
		private System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.DataGridView dgvPendingShipment;
		private System.Windows.Forms.Panel panShipDetail;
		private System.Windows.Forms.Button btnRemoveProduct;
		private System.Windows.Forms.Button btnAddProduct;
		private System.Windows.Forms.ListView listView1;
		private System.Windows.Forms.Label labQuantity;
		private System.Windows.Forms.TextBox txtProductQuantity;
		private System.Windows.Forms.ComboBox cboProductID;
		private System.Windows.Forms.Label labProductID;
		private System.Windows.Forms.Label labShipID_Display;
		private System.Windows.Forms.Label labDate;
		private System.Windows.Forms.Button btnLoadShipment;
		private System.Windows.Forms.Button btnCreate;
	}
}