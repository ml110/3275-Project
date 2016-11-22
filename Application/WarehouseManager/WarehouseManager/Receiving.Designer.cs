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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Receiving));
            this.staReceiving = new System.Windows.Forms.StatusStrip();
            this.tslLoggedUser = new System.Windows.Forms.ToolStripStatusLabel();
            this.tslServerStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.menReceiving = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.serverToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.connectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.disconnectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.labOrderID = new System.Windows.Forms.Label();
            this.txtOrderID = new System.Windows.Forms.TextBox();
            this.btnLookup = new System.Windows.Forms.Button();
            this.dgvLookup = new System.Windows.Forms.DataGridView();
            this.dgvChecklist = new System.Windows.Forms.DataGridView();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.labOrderInfo = new System.Windows.Forms.Label();
            this.staReceiving.SuspendLayout();
            this.menReceiving.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLookup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChecklist)).BeginInit();
            this.SuspendLayout();
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
            this.serverToolStripMenuItem});
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
            this.serverToolStripMenuItem.Size = new System.Drawing.Size(106, 22);
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
            this.btnLookup.Click += new System.EventHandler(this.btnLookup_Click);
            // 
            // dgvLookup
            // 
            this.dgvLookup.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvLookup.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvLookup.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLookup.Location = new System.Drawing.Point(276, 27);
            this.dgvLookup.MultiSelect = false;
            this.dgvLookup.Name = "dgvLookup";
            this.dgvLookup.Size = new System.Drawing.Size(656, 204);
            this.dgvLookup.TabIndex = 9;
            this.dgvLookup.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLookup_CellContentClick);
            // 
            // dgvChecklist
            // 
            this.dgvChecklist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChecklist.Location = new System.Drawing.Point(276, 237);
            this.dgvChecklist.Name = "dgvChecklist";
            this.dgvChecklist.ReadOnly = true;
            this.dgvChecklist.Size = new System.Drawing.Size(656, 204);
            this.dgvChecklist.TabIndex = 14;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(804, 447);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(128, 29);
            this.btnUpdate.TabIndex = 15;
            this.btnUpdate.Text = "Execute Updates";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(170, 202);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(100, 29);
            this.btnAdd.TabIndex = 16;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // labOrderInfo
            // 
            this.labOrderInfo.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labOrderInfo.Location = new System.Drawing.Point(0, 94);
            this.labOrderInfo.Name = "labOrderInfo";
            this.labOrderInfo.Size = new System.Drawing.Size(270, 105);
            this.labOrderInfo.TabIndex = 17;
            this.labOrderInfo.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // Receiving
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 501);
            this.Controls.Add(this.labOrderInfo);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.dgvChecklist);
            this.Controls.Add(this.btnLookup);
            this.Controls.Add(this.txtOrderID);
            this.Controls.Add(this.labOrderID);
            this.Controls.Add(this.dgvLookup);
            this.Controls.Add(this.menReceiving);
            this.Controls.Add(this.staReceiving);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Receiving";
            this.Text = "Warehouse Manager - Receiving";
            this.staReceiving.ResumeLayout(false);
            this.staReceiving.PerformLayout();
            this.menReceiving.ResumeLayout(false);
            this.menReceiving.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLookup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChecklist)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.StatusStrip staReceiving;
		private System.Windows.Forms.ToolStripStatusLabel tslLoggedUser;
		private System.Windows.Forms.ToolStripStatusLabel tslServerStatus;
		private System.Windows.Forms.MenuStrip menReceiving;
		private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem serverToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem connectToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem disconnectToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem usersToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
		private System.Windows.Forms.Label labOrderID;
		private System.Windows.Forms.TextBox txtOrderID;
		private System.Windows.Forms.Button btnLookup;
		private System.Windows.Forms.DataGridView dgvLookup;
		private System.Windows.Forms.DataGridView dgvChecklist;
		private System.Windows.Forms.Button btnUpdate;
		private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label labOrderInfo;
	}
}