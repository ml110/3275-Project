namespace WarehouseManager
{
	partial class Inventory
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inventory));
			this.dgvInvDisplay = new System.Windows.Forms.DataGridView();
			this.menInventory = new System.Windows.Forms.MenuStrip();
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
			this.staInventory = new System.Windows.Forms.StatusStrip();
			this.tslLoggedUser = new System.Windows.Forms.ToolStripStatusLabel();
			this.tslServerStatus = new System.Windows.Forms.ToolStripStatusLabel();
			this.tooInventory = new System.Windows.Forms.ToolStrip();
			this.tscTxtSearch = new System.Windows.Forms.ToolStripTextBox();
			this.tscBtnSearch = new System.Windows.Forms.ToolStripButton();
			((System.ComponentModel.ISupportInitialize)(this.dgvInvDisplay)).BeginInit();
			this.menInventory.SuspendLayout();
			this.staInventory.SuspendLayout();
			this.tooInventory.SuspendLayout();
			this.SuspendLayout();
			// 
			// dgvInvDisplay
			// 
			this.dgvInvDisplay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvInvDisplay.Location = new System.Drawing.Point(12, 52);
			this.dgvInvDisplay.Name = "dgvInvDisplay";
			this.dgvInvDisplay.Size = new System.Drawing.Size(920, 424);
			this.dgvInvDisplay.TabIndex = 0;
			// 
			// menInventory
			// 
			this.menInventory.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.orderByToolStripMenuItem,
            this.usersToolStripMenuItem,
            this.helpToolStripMenuItem});
			this.menInventory.Location = new System.Drawing.Point(0, 0);
			this.menInventory.Name = "menInventory";
			this.menInventory.Size = new System.Drawing.Size(944, 24);
			this.menInventory.TabIndex = 1;
			this.menInventory.Text = "menuStrip1";
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
			this.orderByToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
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
			// staInventory
			// 
			this.staInventory.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tslLoggedUser,
            this.tslServerStatus});
			this.staInventory.Location = new System.Drawing.Point(0, 479);
			this.staInventory.Name = "staInventory";
			this.staInventory.Size = new System.Drawing.Size(944, 22);
			this.staInventory.TabIndex = 2;
			this.staInventory.Text = "statusStrip1";
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
			// tooInventory
			// 
			this.tooInventory.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tscTxtSearch,
            this.tscBtnSearch});
			this.tooInventory.Location = new System.Drawing.Point(0, 24);
			this.tooInventory.Name = "tooInventory";
			this.tooInventory.Size = new System.Drawing.Size(944, 25);
			this.tooInventory.TabIndex = 3;
			this.tooInventory.Text = "toolStrip1";
			// 
			// tscTxtSearch
			// 
			this.tscTxtSearch.Name = "tscTxtSearch";
			this.tscTxtSearch.Size = new System.Drawing.Size(200, 25);
			// 
			// tscBtnSearch
			// 
			this.tscBtnSearch.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.tscBtnSearch.Image = ((System.Drawing.Image)(resources.GetObject("tscBtnSearch.Image")));
			this.tscBtnSearch.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tscBtnSearch.Name = "tscBtnSearch";
			this.tscBtnSearch.Size = new System.Drawing.Size(46, 22);
			this.tscBtnSearch.Text = "Search";
			// 
			// Inventory
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(944, 501);
			this.Controls.Add(this.tooInventory);
			this.Controls.Add(this.staInventory);
			this.Controls.Add(this.dgvInvDisplay);
			this.Controls.Add(this.menInventory);
			this.MainMenuStrip = this.menInventory;
			this.Name = "Inventory";
			this.Text = "Warehouse Manager - Inventory";
			((System.ComponentModel.ISupportInitialize)(this.dgvInvDisplay)).EndInit();
			this.menInventory.ResumeLayout(false);
			this.menInventory.PerformLayout();
			this.staInventory.ResumeLayout(false);
			this.staInventory.PerformLayout();
			this.tooInventory.ResumeLayout(false);
			this.tooInventory.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView dgvInvDisplay;
		private System.Windows.Forms.MenuStrip menInventory;
		private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem serverToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem connectToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem disconnectToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem importToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem exportToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem orderByToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem orderByToolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem filterByToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
		private System.Windows.Forms.StatusStrip staInventory;
		private System.Windows.Forms.ToolStripStatusLabel tslServerStatus;
		private System.Windows.Forms.ToolStripStatusLabel tslLoggedUser;
		private System.Windows.Forms.ToolStrip tooInventory;
		private System.Windows.Forms.ToolStripTextBox tscTxtSearch;
		private System.Windows.Forms.ToolStripButton tscBtnSearch;
		private System.Windows.Forms.ToolStripMenuItem usersToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem;
	}
}