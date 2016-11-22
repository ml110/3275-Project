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
        private MySqlDataAdapter dgvFill;

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
    }
    }
