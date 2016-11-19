namespace WarehouseManager
{
	partial class FormMain
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
			this.splitContainer1 = new System.Windows.Forms.SplitContainer();
			this.btnRec = new System.Windows.Forms.Button();
			this.btnLogin = new System.Windows.Forms.Button();
			this.labLoginTitle = new System.Windows.Forms.Label();
			this.txtLoginPass = new System.Windows.Forms.TextBox();
			this.labLoginPass = new System.Windows.Forms.Label();
			this.txtLoginID = new System.Windows.Forms.TextBox();
			this.labLoginID = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
			this.splitContainer1.Panel2.SuspendLayout();
			this.splitContainer1.SuspendLayout();
			this.SuspendLayout();
			// 
			// splitContainer1
			// 
			this.splitContainer1.BackColor = System.Drawing.Color.Gray;
			this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer1.IsSplitterFixed = true;
			this.splitContainer1.Location = new System.Drawing.Point(0, 0);
			this.splitContainer1.Name = "splitContainer1";
			// 
			// splitContainer1.Panel1
			// 
			this.splitContainer1.Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.splitContainer1.Panel1.BackgroundImage = global::WarehouseManager.Properties.Resources.LoginPanel2;
			// 
			// splitContainer1.Panel2
			// 
			this.splitContainer1.Panel2.BackColor = System.Drawing.SystemColors.Control;
			this.splitContainer1.Panel2.Controls.Add(this.btnRec);
			this.splitContainer1.Panel2.Controls.Add(this.btnLogin);
			this.splitContainer1.Panel2.Controls.Add(this.labLoginTitle);
			this.splitContainer1.Panel2.Controls.Add(this.txtLoginPass);
			this.splitContainer1.Panel2.Controls.Add(this.labLoginPass);
			this.splitContainer1.Panel2.Controls.Add(this.txtLoginID);
			this.splitContainer1.Panel2.Controls.Add(this.labLoginID);
			this.splitContainer1.Size = new System.Drawing.Size(944, 501);
			this.splitContainer1.SplitterDistance = 340;
			this.splitContainer1.SplitterWidth = 2;
			this.splitContainer1.TabIndex = 0;
			// 
			// btnRec
			// 
			this.btnRec.Location = new System.Drawing.Point(458, 442);
			this.btnRec.Name = "btnRec";
			this.btnRec.Size = new System.Drawing.Size(113, 44);
			this.btnRec.TabIndex = 6;
			this.btnRec.Text = "TEST BUTTON FOR RECEIVING";
			this.btnRec.UseVisualStyleBackColor = true;
			this.btnRec.Click += new System.EventHandler(this.btnRec_Click);
			// 
			// btnLogin
			// 
			this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnLogin.Location = new System.Drawing.Point(124, 286);
			this.btnLogin.Name = "btnLogin";
			this.btnLogin.Size = new System.Drawing.Size(349, 35);
			this.btnLogin.TabIndex = 5;
			this.btnLogin.Text = "Login";
			this.btnLogin.UseVisualStyleBackColor = true;
			this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
			// 
			// labLoginTitle
			// 
			this.labLoginTitle.AutoSize = true;
			this.labLoginTitle.Font = new System.Drawing.Font("Verdana", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labLoginTitle.Location = new System.Drawing.Point(30, 27);
			this.labLoginTitle.Name = "labLoginTitle";
			this.labLoginTitle.Size = new System.Drawing.Size(550, 38);
			this.labLoginTitle.TabIndex = 4;
			this.labLoginTitle.Text = "Warehouse Manager - User Login";
			// 
			// txtLoginPass
			// 
			this.txtLoginPass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtLoginPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.txtLoginPass.Location = new System.Drawing.Point(124, 245);
			this.txtLoginPass.Name = "txtLoginPass";
			this.txtLoginPass.Size = new System.Drawing.Size(349, 35);
			this.txtLoginPass.TabIndex = 3;
			// 
			// labLoginPass
			// 
			this.labLoginPass.AutoSize = true;
			this.labLoginPass.Font = new System.Drawing.Font("Lucida Console", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labLoginPass.Location = new System.Drawing.Point(120, 217);
			this.labLoginPass.Name = "labLoginPass";
			this.labLoginPass.Size = new System.Drawing.Size(122, 24);
			this.labLoginPass.TabIndex = 2;
			this.labLoginPass.Text = "Password";
			// 
			// txtLoginID
			// 
			this.txtLoginID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtLoginID.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.txtLoginID.Location = new System.Drawing.Point(124, 155);
			this.txtLoginID.Name = "txtLoginID";
			this.txtLoginID.Size = new System.Drawing.Size(349, 35);
			this.txtLoginID.TabIndex = 1;
			// 
			// labLoginID
			// 
			this.labLoginID.AutoSize = true;
			this.labLoginID.Font = new System.Drawing.Font("Lucida Console", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labLoginID.Location = new System.Drawing.Point(120, 127);
			this.labLoginID.Name = "labLoginID";
			this.labLoginID.Size = new System.Drawing.Size(164, 24);
			this.labLoginID.TabIndex = 0;
			this.labLoginID.Text = "Employee ID";
			// 
			// FormMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(944, 501);
			this.Controls.Add(this.splitContainer1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "FormMain";
			this.Text = "Warehouse Manager - Login";
			this.splitContainer1.Panel2.ResumeLayout(false);
			this.splitContainer1.Panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
			this.splitContainer1.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.SplitContainer splitContainer1;
		private System.Windows.Forms.Button btnLogin;
		private System.Windows.Forms.Label labLoginTitle;
		private System.Windows.Forms.TextBox txtLoginPass;
		private System.Windows.Forms.Label labLoginPass;
		private System.Windows.Forms.TextBox txtLoginID;
		private System.Windows.Forms.Label labLoginID;
        private System.Windows.Forms.Button btnRec;
	}
}

