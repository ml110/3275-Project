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
		private MySqlCommand _command;
		private int _pId;

		public Inventory(MySqlConnection conn, MySqlCommand cmd, string empName, int permId)
		{
			InitializeComponent();
			_connection = conn;
			_command = cmd;
			_pId = permId;
			staInventory.Items["tslLoggedUser"].Text = empName;
			
			if (_connection.State == ConnectionState.Open)
			{
				staInventory.Items["tslServerStatus"].Text = @"Connected";
				staInventory.Items["tslServerStatus"].ForeColor = Color.Green;

				connectToolStripMenuItem.Enabled = false;
				disconnectToolStripMenuItem.Enabled = true;
			}
			else
			{
				staInventory.Items["tslServerStatus"].Text = @"Disconnected";
				staInventory.Items["tslServerStatus"].ForeColor = Color.OrangeRed;

				connectToolStripMenuItem.Enabled = true;
				disconnectToolStripMenuItem.Enabled = false;
			}
		}

		public Inventory()
		{
			InitializeComponent();
		}
		
		//Menu Control, User Information & Status Display Components

		private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
		{
			_connection?.Close();
			Hide();
			var login = new FormMain();
			login.Closed += (s, args) => Close();
			login.Show();
		}

		private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
		{
			var about = new WarehouseAppAbout();
			about.Closed += (s, args) => Close();
			about.Show();
		}

		private void connectToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (_connection.State != ConnectionState.Closed) return;
			const string server = "173.180.133.176";
			const string db = "hi-tec";
			const string id = "root";
			const string pass = "superpassword";
			const string port = "3306";

			const string connectionString = "SERVER=" + server + ";PORT=" + port + ";DATABASE=" + db + ";UID=" + id + ";PASSWORD=" + pass + ";";
			_connection = new MySqlConnection(connectionString);

			_connection.Open();

			staInventory.Items["tslServerStatus"].Text = @"Connected";
			staInventory.Items["tslServerStatus"].ForeColor = Color.Green;

			connectToolStripMenuItem.Enabled = false;
			disconnectToolStripMenuItem.Enabled = true;
		}

		private void disconnectToolStripMenuItem_Click(object sender, EventArgs e)
		{
			_connection?.Close();

			staInventory.Items["tslServerStatus"].Text = @"Disconnected";
			staInventory.Items["tslServerStatus"].ForeColor = Color.OrangeRed;

			connectToolStripMenuItem.Enabled = true;
			disconnectToolStripMenuItem.Enabled = false;
		}
	}
}
