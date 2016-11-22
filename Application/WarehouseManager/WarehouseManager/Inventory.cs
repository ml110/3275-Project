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
<<<<<<< HEAD
		private MySqlCommand _command;
		private int _pId;

		public Inventory(MySqlConnection conn, MySqlCommand cmd, string empName, int permId)
=======
		private readonly MySqlCommand _command;
		private string _empName;

<<<<<<< HEAD
        public Inventory(MySqlConnection conn, MySqlCommand cmd, string empName)
>>>>>>> f48655aa87fbb95755fd404b0bd92ef12f45d8a9
=======
		public Inventory(MySqlConnection conn, MySqlCommand cmd, string empName)
>>>>>>> parent of 93d8aaa... janky ass code from a janky ass coder. inventory half works
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
<<<<<<< HEAD
<<<<<<< HEAD
		}
		
		//Menu Control, User Information & Status Display Components
=======
		}      
>>>>>>> f48655aa87fbb95755fd404b0bd92ef12f45d8a9
=======
		}
>>>>>>> parent of 93d8aaa... janky ass code from a janky ass coder. inventory half works

		private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
		{
			_connection?.Close();
			Hide();
			var login = new FormMain();
			login.Closed += (s, args) => Close();
			login.Show();
		}
<<<<<<< HEAD

<<<<<<< HEAD
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
=======
//I HAVE TO FORCE CONNECTION UP AND DOWN FOR RELOAD BUTTON... I THINK????
        private bool OpenConnection()
        {
            try
            {
                _connection.Open();
                return true;
            }
            catch (MySqlException ex)
            {
                return false;
            }
        }

        private bool CloseConnection()
        {
            try
            {
                _connection.Close();
                return true;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        private void Inventory_Load(object sender, EventArgs e)
        {
            Inventory_Load();
        }

        private void refresh_Click(object sender, EventArgs e)
        {
            Inventory_Load();
        }

        private void Inventory_Load()
        {
            const string server = "192.168.1.78";
            const string db = "hi-tec";
            const string id = "root";
            const string pass = "superpassword";
            const string port = "3306";

            const string connectionString = "SERVER=" + server + ";PORT=" + port + ";DATABASE=" + db + ";UID=" + id + ";PASSWORD=" + pass + ";";
            _connection = new MySqlConnection(connectionString);


            if (this.OpenConnection() == true)
            {
                dgvFill = new MySqlDataAdapter("SELECT P.product_id AS SKU, P.product_name AS PRODUCTNAME, P.product_stock AS STOCK, SH.shelf_number AS SHELFNUM, AI.aisle_number AS AISLENUM, SE.section_name AS SECTIONNAME FROM product AS P INNER JOIN shelf AS SH ON P.shelf_id = SH.shelf_id INNER JOIN aisle AS AI ON SH.aisle_id = AI.aisle_id INNER JOIN section AS SE ON AI.section_id = SE.section_id", _connection);
                DataSet DS = new DataSet();
                dgvFill.Fill(DS);
                dgvInvDisplay.DataSource = DS.Tables[0];

                this.CloseConnection();
            }
        }

        private void dgvInvDisplay_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
    }
>>>>>>> f48655aa87fbb95755fd404b0bd92ef12f45d8a9
=======
	}
}
>>>>>>> parent of 93d8aaa... janky ass code from a janky ass coder. inventory half works
