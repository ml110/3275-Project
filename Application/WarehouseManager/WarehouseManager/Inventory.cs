using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WarehouseManager
{
	public partial class Inventory : Form
	{
		private MySqlConnection _connection;
		private readonly MySqlCommand _command;
		private string _empName;

		public Inventory(MySqlConnection conn, MySqlCommand cmd, string empName)
		{
			InitializeComponent();
			_connection = conn;
			_command = cmd;
			_empName = empName;
			staInventory.Items["tslLoggedUser"].Text = _empName;
			
			if (conn != null)
			{
				staInventory.Items["tslServerStatus"].Text = @"Connected";
				staInventory.Items["tslServerStatus"].ForeColor = Color.Green;

				connectToolStripMenuItem.Enabled = false;
			}
			else
			{
				staInventory.Items["tslServerStatus"].Text = @"Disconnected";
				staInventory.Items["tslServerStatus"].ForeColor = Color.OrangeRed;
			}
		}

		public Inventory()
		{
			InitializeComponent();
		}

		private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
		{
			_connection?.Close();
			Hide();
			var login = new FormMain();
			login.Closed += (s, args) => Close();
			login.Show();
		}
	}
}
