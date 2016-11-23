using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
///////////////////////////////////////////////////////////////////////////////////////////////////
using MySql.Data.MySqlClient;

namespace WarehouseManager
{
	public partial class History : Form
	{
		private MySqlConnection _connection;
		private readonly MySqlCommand _command;
		private string _empName;
		private int _pId;

		public History(MySqlConnection conn, MySqlCommand cmd, string empName, int permId)
		{
			InitializeComponent();
			_connection = conn;
			_command = cmd;
			_empName = empName;
			_pId = permId;
			staHistory.Items["tslLoggedUser"].Text = empName;

			if (_connection.State == ConnectionState.Open)
			{
				staHistory.Items["tslServerStatus"].Text = @"Connected";
				staHistory.Items["tslServerStatus"].ForeColor = Color.Green;

				connectToolStripMenuItem.Enabled = false;
				disconnectToolStripMenuItem.Enabled = true;
			}
			else
			{
				staHistory.Items["tslServerStatus"].Text = @"Disconnected";
				staHistory.Items["tslServerStatus"].ForeColor = Color.OrangeRed;

				connectToolStripMenuItem.Enabled = true;
				disconnectToolStripMenuItem.Enabled = false;
			}
		}

		public History()
		{
			InitializeComponent();
		}

		private void dbCall()
		{
			
		}

///////////////////////////////////////////////////////////////////////////////////////////////////
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

			staHistory.Items["tslServerStatus"].Text = @"Connected";
			staHistory.Items["tslServerStatus"].ForeColor = Color.Green;

			connectToolStripMenuItem.Enabled = false;
			disconnectToolStripMenuItem.Enabled = true;
		}

		private void disconnectToolStripMenuItem_Click(object sender, EventArgs e)
		{
			_connection?.Close();

			staHistory.Items["tslServerStatus"].Text = @"Disconnected";
			staHistory.Items["tslServerStatus"].ForeColor = Color.OrangeRed;

			connectToolStripMenuItem.Enabled = true;
			disconnectToolStripMenuItem.Enabled = false;
		}

		private void inventoryToolStripMenuItem_Click(object sender, EventArgs e)
		{
			var warehouse = new Inventory(_connection, _command, _empName, _pId);
			warehouse.Closed += (s, args) => Close();
			warehouse.Show();
		}

		private void receivingToolStripMenuItem_Click(object sender, EventArgs e)
		{
			var receiving = new Receiving(_connection, _command, _empName);
			receiving.Closed += (s, args) => Close();
			receiving.Show();
		}

		private void shippingToolStripMenuItem_Click(object sender, EventArgs e)
		{
			var shipping = new Shipping(_connection, _command, _empName);
			shipping.Closed += (s, args) => Close();
			shipping.Show();
		}
	}
}
