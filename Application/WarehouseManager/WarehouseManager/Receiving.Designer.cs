namespace WarehouseManager
{
	partial class Receiving
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
			this.labProductName = new System.Windows.Forms.Label();
			this.labSKU = new System.Windows.Forms.Label();
			this.labProductPrice = new System.Windows.Forms.Label();
			this.txtProductSKU = new System.Windows.Forms.TextBox();
			this.txtProductName = new System.Windows.Forms.TextBox();
			this.txtProductPrice = new System.Windows.Forms.TextBox();
			this.staReceiving = new System.Windows.Forms.StatusStrip();
			this.tslLoggedUser = new System.Windows.Forms.ToolStripStatusLabel();
			this.tslServerStatus = new System.Windows.Forms.ToolStripStatusLabel();
			this.menReceiving = new System.Windows.Forms.MenuStrip();
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
			this.labOrderID = new System.Windows.Forms.Label();
			this.txtOrderID = new System.Windows.Forms.TextBox();
			this.btnLookup = new System.Windows.Forms.Button();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.btnNewProduct = new System.Windows.Forms.Button();
			this.dataGridView2 = new System.Windows.Forms.DataGridView();
			this.btnUpdate = new System.Windows.Forms.Button();
			this.staReceiving.SuspendLayout();
			this.menReceiving.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
			this.SuspendLayout();
			// 
			// labProductName
			// 
			this.labProductName.AutoSize = true;
			this.labProductName.Font = new System.Drawing.Font("Lucida Console", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labProductName.Location = new System.Drawing.Point(23, 383);
			this.labProductName.Name = "labProductName";
			this.labProductName.Size = new System.Drawing.Size(141, 19);
			this.labProductName.TabIndex = 1;
			this.labProductName.Text = "Product Name";
			// 
			// labSKU
			// 
			this.labSKU.AutoSize = true;
			this.labSKU.Font = new System.Drawing.Font("Lucida Console", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labSKU.Location = new System.Drawing.Point(122, 348);
			this.labSKU.Name = "labSKU";
			this.labSKU.Size = new System.Drawing.Size(42, 19);
			this.labSKU.TabIndex = 2;
			this.labSKU.Text = "SKU";
			// 
			// labProductPrice
			// 
			this.labProductPrice.AutoSize = true;
			this.labProductPrice.Font = new System.Drawing.Font("Lucida Console", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labProductPrice.Location = new System.Drawing.Point(12, 418);
			this.labProductPrice.Name = "labProductPrice";
			this.labProductPrice.Size = new System.Drawing.Size(152, 19);
			this.labProductPrice.TabIndex = 3;
			this.labProductPrice.Text = "Product Price";
			// 
			// txtProductSKU
			// 
			this.txtProductSKU.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtProductSKU.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.txtProductSKU.Location = new System.Drawing.Point(170, 342);
			this.txtProductSKU.Name = "txtProductSKU";
			this.txtProductSKU.Size = new System.Drawing.Size(100, 29);
			this.txtProductSKU.TabIndex = 4;
			// 
			// txtProductName
			// 
			this.txtProductName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtProductName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.txtProductName.Location = new System.Drawing.Point(170, 377);
			this.txtProductName.Name = "txtProductName";
			this.txtProductName.Size = new System.Drawing.Size(100, 29);
			this.txtProductName.TabIndex = 5;
			// 
			// txtProductPrice
			// 
			this.txtProductPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtProductPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.txtProductPrice.Location = new System.Drawing.Point(170, 412);
			this.txtProductPrice.Name = "txtProductPrice";
			this.txtProductPrice.Size = new System.Drawing.Size(100, 29);
			this.txtProductPrice.TabIndex = 6;
			// 
			// staReceiving
			// 
			this.staReceiving.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tslLoggedUser,
            this.tslServerStatus});
			this.staReceiving.Location = new System.Drawing.Point(0, 479);
			this.staReceiving.Name = "staReceiving";
			this.staReceiving.Size = new System.Drawing.Size(944, 22);
			this.staReceiving.TabIndex = 7;
			this.staReceiving.Text = "statusStrip1";
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
			// menReceiving
			// 
			this.menReceiving.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.orderByToolStripMenuItem,
            this.usersToolStripMenuItem,
            this.helpToolStripMenuItem});
			this.menReceiving.Location = new System.Drawing.Point(0, 0);
			this.menReceiving.Name = "menReceiving";
			this.menReceiving.Size = new System.Drawing.Size(944, 24);
			this.menReceiving.TabIndex = 8;
			this.menReceiving.Text = "menuStrip1";
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
			this.serverToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
			this.serverToolStripMenuItem.Text = "Server";
			// 
			// connectToolStripMenuItem
			// 
			this.connectToolStripMenuItem.Name = "connectToolStripMenuItem";
			this.connectToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
			this.connectToolStripMenuItem.Text = "Connect";
			// 
			// disconnectToolStripMenuItem
			// 
			this.disconnectToolStripMenuItem.Name = "disconnectToolStripMenuItem";
			this.disconnectToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
			this.disconnectToolStripMenuItem.Text = "Disconnect";
			// 
			// importToolStripMenuItem
			// 
			this.importToolStripMenuItem.Name = "importToolStripMenuItem";
			this.importToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
			this.importToolStripMenuItem.Text = "Import...";
			// 
			// exportToolStripMenuItem
			// 
			this.exportToolStripMenuItem.Name = "exportToolStripMenuItem";
			this.exportToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
			this.exportToolStripMenuItem.Text = "Export...";
			// 
			// orderByToolStripMenuItem
			// 
			this.orderByToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.orderByToolStripMenuItem1,
            this.filterByToolStripMenuItem});
			this.orderByToolStripMenuItem.Name = "orderByToolStripMenuItem";
			this.orderByToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
			this.orderByToolStripMenuItem.Text = "Tools";
			// 
			// orderByToolStripMenuItem1
			// 
			this.orderByToolStripMenuItem1.Name = "orderByToolStripMenuItem1";
			this.orderByToolStripMenuItem1.Size = new System.Drawing.Size(120, 22);
			this.orderByToolStripMenuItem1.Text = "Order By";
			// 
			// filterByToolStripMenuItem
			// 
			this.filterByToolStripMenuItem.Name = "filterByToolStripMenuItem";
			this.filterByToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
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
			this.logOutToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
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
			this.aboutToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
			this.aboutToolStripMenuItem.Text = "About...";
			// 
			// labOrderID
			// 
			this.labOrderID.AutoSize = true;
			this.labOrderID.Font = new System.Drawing.Font("Lucida Console", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labOrderID.Location = new System.Drawing.Point(67, 33);
			this.labOrderID.Name = "labOrderID";
			this.labOrderID.Size = new System.Drawing.Size(97, 19);
			this.labOrderID.TabIndex = 10;
			this.labOrderID.Text = "Order ID";
			// 
			// txtOrderID
			// 
			this.txtOrderID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtOrderID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.txtOrderID.Location = new System.Drawing.Point(170, 27);
			this.txtOrderID.Name = "txtOrderID";
			this.txtOrderID.Size = new System.Drawing.Size(100, 29);
			this.txtOrderID.TabIndex = 11;
			// 
			// btnLookup
			// 
			this.btnLookup.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnLookup.Location = new System.Drawing.Point(170, 62);
			this.btnLookup.Name = "btnLookup";
			this.btnLookup.Size = new System.Drawing.Size(100, 29);
			this.btnLookup.TabIndex = 12;
			this.btnLookup.Text = "Order Lookup";
			this.btnLookup.UseVisualStyleBackColor = true;
			// 
			// dataGridView1
			// 
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(276, 27);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(656, 204);
			this.dataGridView1.TabIndex = 9;
			// 
			// btnNewProduct
			// 
			this.btnNewProduct.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnNewProduct.Location = new System.Drawing.Point(170, 447);
			this.btnNewProduct.Name = "btnNewProduct";
			this.btnNewProduct.Size = new System.Drawing.Size(100, 29);
			this.btnNewProduct.TabIndex = 13;
			this.btnNewProduct.Text = "Add Product";
			this.btnNewProduct.UseVisualStyleBackColor = true;
			// 
			// dataGridView2
			// 
			this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView2.Location = new System.Drawing.Point(276, 237);
			this.dataGridView2.Name = "dataGridView2";
			this.dataGridView2.Size = new System.Drawing.Size(656, 204);
			this.dataGridView2.TabIndex = 14;
			// 
			// btnUpdate
			// 
			this.btnUpdate.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnUpdate.Location = new System.Drawing.Point(804, 447);
			this.btnUpdate.Name = "btnUpdate";
			this.btnUpdate.Size = new System.Drawing.Size(128, 29);
			this.btnUpdate.TabIndex = 15;
			this.btnUpdate.Text = "Update Details";
			this.btnUpdate.UseVisualStyleBackColor = true;
			// 
			// Receiving
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(944, 501);
			this.Controls.Add(this.btnUpdate);
			this.Controls.Add(this.dataGridView2);
			this.Controls.Add(this.btnNewProduct);
			this.Controls.Add(this.btnLookup);
			this.Controls.Add(this.txtOrderID);
			this.Controls.Add(this.labOrderID);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.menReceiving);
			this.Controls.Add(this.staReceiving);
			this.Controls.Add(this.txtProductPrice);
			this.Controls.Add(this.txtProductName);
			this.Controls.Add(this.txtProductSKU);
			this.Controls.Add(this.labProductPrice);
			this.Controls.Add(this.labSKU);
			this.Controls.Add(this.labProductName);
			this.Name = "Receiving";
			this.Text = "Warehouse Manager - Receiving";
			this.staReceiving.ResumeLayout(false);
			this.staReceiving.PerformLayout();
			this.menReceiving.ResumeLayout(false);
			this.menReceiving.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label labProductName;
		private System.Windows.Forms.Label labSKU;
		private System.Windows.Forms.Label labProductPrice;
		private System.Windows.Forms.TextBox txtProductSKU;
		private System.Windows.Forms.TextBox txtProductName;
		private System.Windows.Forms.TextBox txtProductPrice;
		private System.Windows.Forms.StatusStrip staReceiving;
		private System.Windows.Forms.ToolStripStatusLabel tslLoggedUser;
		private System.Windows.Forms.ToolStripStatusLabel tslServerStatus;
		private System.Windows.Forms.MenuStrip menReceiving;
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
		private System.Windows.Forms.Label labOrderID;
		private System.Windows.Forms.TextBox txtOrderID;
		private System.Windows.Forms.Button btnLookup;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Button btnNewProduct;
		private System.Windows.Forms.DataGridView dataGridView2;
		private System.Windows.Forms.Button btnUpdate;
	}
}