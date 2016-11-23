namespace WarehouseManager
{
	partial class History
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(History));
			this.staHistory = new System.Windows.Forms.StatusStrip();
			this.tslLoggedUser = new System.Windows.Forms.ToolStripStatusLabel();
			this.tslServerStatus = new System.Windows.Forms.ToolStripStatusLabel();
			this.menHistory = new System.Windows.Forms.MenuStrip();
			this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.serverToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.connectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.disconnectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.usersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.dgvShipments = new System.Windows.Forms.DataGridView();
			this.toolHistory = new System.Windows.Forms.ToolStrip();
			this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
			this.inventoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.receivingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.shippingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.dgvOrders = new System.Windows.Forms.DataGridView();
			this.staHistory.SuspendLayout();
			this.menHistory.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvShipments)).BeginInit();
			this.toolHistory.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvOrders)).BeginInit();
			this.SuspendLayout();
			// 
			// staHistory
			// 
			this.staHistory.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tslLoggedUser,
            this.tslServerStatus});
			this.staHistory.Location = new System.Drawing.Point(0, 479);
			this.staHistory.Name = "staHistory";
			this.staHistory.Size = new System.Drawing.Size(944, 22);
			this.staHistory.TabIndex = 9;
			this.staHistory.Text = "statusStrip1";
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
			// menHistory
			// 
			this.menHistory.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.usersToolStripMenuItem,
            this.helpToolStripMenuItem});
			this.menHistory.Location = new System.Drawing.Point(0, 0);
			this.menHistory.Name = "menHistory";
			this.menHistory.Size = new System.Drawing.Size(944, 24);
			this.menHistory.TabIndex = 10;
			this.menHistory.Text = "menuStrip1";
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
			this.serverToolStripMenuItem.Size = new System.Drawing.Size(106, 22);
			this.serverToolStripMenuItem.Text = "Server";
			// 
			// connectToolStripMenuItem
			// 
			this.connectToolStripMenuItem.Name = "connectToolStripMenuItem";
			this.connectToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
			this.connectToolStripMenuItem.Text = "Connect";
			this.connectToolStripMenuItem.Click += new System.EventHandler(this.connectToolStripMenuItem_Click);
			// 
			// disconnectToolStripMenuItem
			// 
			this.disconnectToolStripMenuItem.Name = "disconnectToolStripMenuItem";
			this.disconnectToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
			this.disconnectToolStripMenuItem.Text = "Disconnect";
			this.disconnectToolStripMenuItem.Click += new System.EventHandler(this.disconnectToolStripMenuItem_Click);
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
			this.logOutToolStripMenuItem.Click += new System.EventHandler(this.logOutToolStripMenuItem_Click);
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
			this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
			// 
			// dgvShipments
			// 
			this.dgvShipments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvShipments.Location = new System.Drawing.Point(6, 52);
			this.dgvShipments.Name = "dgvShipments";
			this.dgvShipments.Size = new System.Drawing.Size(458, 424);
			this.dgvShipments.TabIndex = 0;
			this.dgvShipments.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgvShipments_DataBindingComplete);
			// 
			// toolHistory
			// 
			this.toolHistory.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
			this.toolHistory.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton1});
			this.toolHistory.Location = new System.Drawing.Point(0, 24);
			this.toolHistory.Name = "toolHistory";
			this.toolHistory.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
			this.toolHistory.Size = new System.Drawing.Size(944, 25);
			this.toolHistory.TabIndex = 11;
			this.toolHistory.Text = "toolStrip1";
			// 
			// toolStripDropDownButton1
			// 
			this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inventoryToolStripMenuItem,
            this.receivingToolStripMenuItem,
            this.shippingToolStripMenuItem});
			this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
			this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
			this.toolStripDropDownButton1.Size = new System.Drawing.Size(91, 22);
			this.toolStripDropDownButton1.Text = "Choose Form";
			// 
			// inventoryToolStripMenuItem
			// 
			this.inventoryToolStripMenuItem.Name = "inventoryToolStripMenuItem";
			this.inventoryToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.inventoryToolStripMenuItem.Text = "Inventory";
			this.inventoryToolStripMenuItem.Click += new System.EventHandler(this.inventoryToolStripMenuItem_Click);
			// 
			// receivingToolStripMenuItem
			// 
			this.receivingToolStripMenuItem.Name = "receivingToolStripMenuItem";
			this.receivingToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.receivingToolStripMenuItem.Text = "Receiving";
			this.receivingToolStripMenuItem.Click += new System.EventHandler(this.receivingToolStripMenuItem_Click);
			// 
			// shippingToolStripMenuItem
			// 
			this.shippingToolStripMenuItem.Name = "shippingToolStripMenuItem";
			this.shippingToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.shippingToolStripMenuItem.Text = "Shipping";
			this.shippingToolStripMenuItem.Click += new System.EventHandler(this.shippingToolStripMenuItem_Click);
			// 
			// dgvOrders
			// 
			this.dgvOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvOrders.Location = new System.Drawing.Point(470, 52);
			this.dgvOrders.Name = "dgvOrders";
			this.dgvOrders.Size = new System.Drawing.Size(468, 424);
			this.dgvOrders.TabIndex = 12;
			// 
			// History
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(944, 501);
			this.Controls.Add(this.dgvOrders);
			this.Controls.Add(this.toolHistory);
			this.Controls.Add(this.dgvShipments);
			this.Controls.Add(this.menHistory);
			this.Controls.Add(this.staHistory);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "History";
			this.Text = "Warehouse Manager - History";
			this.Load += new System.EventHandler(this.History_Load);
			this.staHistory.ResumeLayout(false);
			this.staHistory.PerformLayout();
			this.menHistory.ResumeLayout(false);
			this.menHistory.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvShipments)).EndInit();
			this.toolHistory.ResumeLayout(false);
			this.toolHistory.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvOrders)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.StatusStrip staHistory;
		private System.Windows.Forms.ToolStripStatusLabel tslLoggedUser;
		private System.Windows.Forms.ToolStripStatusLabel tslServerStatus;
		private System.Windows.Forms.MenuStrip menHistory;
		private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem serverToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem connectToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem disconnectToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem usersToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
		private System.Windows.Forms.DataGridView dgvShipments;
		private System.Windows.Forms.ToolStrip toolHistory;
		private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
		private System.Windows.Forms.ToolStripMenuItem inventoryToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem receivingToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem shippingToolStripMenuItem;
		private System.Windows.Forms.DataGridView dgvOrders;
	}
}