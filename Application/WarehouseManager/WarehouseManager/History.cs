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
		private MySqlDataAdapter _dgvData;

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

		private void History_Load(object sender, EventArgs e)
		{
			if (_connection.State == ConnectionState.Open)
			{
				_dgvData = new MySqlDataAdapter("SELECT S.shipment_id AS ID, L.location_name AS Destination, L.location_rep AS Representative, P.phone_number AS Phone, S.shipment_date AS \"Date\", S.hasShipped AS \"Stat.\" FROM shipment AS S INNER JOIN location AS L ON S.location_id = L.location_id INNER JOIN phone AS P ON L.phone_id = P.phone_id ORDER BY S.shipment_date", _connection);
				var ds = new DataSet();
				_dgvData.Fill(ds);
				dgvShipments.DataSource = ds.Tables[0];

				_dgvData = new MySqlDataAdapter();
			}
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
			//const string server = "173.180.133.176";
            const string server = "192.168.1.78";
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
			var receiving = new Receiving(_connection, _command, _empName,_pId);
			receiving.Closed += (s, args) => Close();
			receiving.Show();
		}

		private void shippingToolStripMenuItem_Click(object sender, EventArgs e)
		{
			var shipping = new Shipping(_connection, _command, _empName,_pId);
			shipping.Closed += (s, args) => Close();
			shipping.Show();
		}

		private void dgvShipments_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
		{
			dgvShipments.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
			dgvShipments.ReadOnly = true;
			dgvShipments.RowHeadersVisible = false;
		}
	}
}
