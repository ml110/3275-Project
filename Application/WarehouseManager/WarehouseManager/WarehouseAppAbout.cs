using System;
using System.Windows.Forms;

namespace WarehouseManager
{
	internal partial class WarehouseAppAbout : Form
	{
		public WarehouseAppAbout()
		{
			InitializeComponent();
			Text = $@"M³CS Integrated Warehouse Management System";
			labelProductName.Text = @"M³CS IWMS";
			labelVersion.Text = @"Demo Version 0.61b";
			labelCopyright.Text = @"© HI-TEC 2016";
			labelCompanyName.Text = @"HI-TEC Electronic Supply Ltd.";
			textBoxDescription.Text = 
				@"This is a prototype warehouse management application for HI-TEC Electronic Supply Ltd., a fictional business-to-business supplier that operates in the Lower Mainland. "
				+ Environment.NewLine + Environment.NewLine + @"It tracks current stock, incoming orders, and outgoing shipments." 
				+ Environment.NewLine + Environment.NewLine + @"This system is comprised primarily of: " 
				+ Environment.NewLine + @"1) A mySQL Database"
				+ Environment.NewLine + @"2) A website for clients " 
				+ Environment.NewLine + @"3) A program for employees ";
		}

		public sealed override string Text
		{
			get { return base.Text; }
			set { base.Text = value; }
		}

		private void okButton_Click(object sender, EventArgs e)
		{
			Hide();
		}
	}
}
