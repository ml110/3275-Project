//AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WarehouseManager
{
	public partial class Shipping : Form
	{
        private MySqlConnection _connection;
        private readonly MySqlCommand _command;
        private readonly string _empName;
        private int _shippingId;

		List<int> listSkews = new List<int>(); //stores the SKUs
		List<int> listQuan = new List<int>(); //stores the amounts
		private int newID; //for new shipments

        public Shipping(MySqlConnection conn, MySqlCommand cmd, string empName)
        {
            InitializeComponent();
            _connection = conn;
            _command = cmd;
            _empName = empName;
	        staShipping.Items["tslLoggedUser"].Text = _empName;

	        if (conn != null)
			{
				staShipping.Items["tslServerStatus"].Text = @"Connected";
				staShipping.Items["tslServerStatus"].ForeColor = Color.Green;

				connectToolStripMenuItem.Enabled = false;
				disconnectToolStripMenuItem.Enabled = true;
			}
			else
			{
				staShipping.Items["tslServerStatus"].Text = @"Disconnected";
				staShipping.Items["tslServerStatus"].ForeColor = Color.OrangeRed;

				connectToolStripMenuItem.Enabled = true;
				disconnectToolStripMenuItem.Enabled = false;
			}

			//code needs to go here to change the lower left to display:
			// 1. The currently logged in user
			// 2. Connection status
		}

        public Shipping()
        {
            InitializeComponent();
            DbConnect();
            _command = new MySqlCommand();
        }
        //TEMP CONNECT METHOD; REMOVE FROM FINAL VERSION
        private void DbConnect()
        {
            const string server = "173.180.133.176";
            const string db = "hi-tec";
            const string id = "root";
            const string pass = "superpassword";
            const string port = "3306";

            const string connectionString = "SERVER=" + server + ";PORT=" + port + ";DATABASE=" + db + ";UID=" + id + ";PASSWORD=" + pass + ";";
            _connection = new MySqlConnection(connectionString);

            _connection.Open();
        }

		private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
		{
			var about = new WarehouseAppAbout();
			about.Closed += (s, args) => Close();
			about.Show();
		}

        private void btnLoadShipment_Click(object sender, EventArgs e)
        {
            try
            {         
                if (string.IsNullOrEmpty(txtProductSKU.Text))
                {
                    DisplayAllShipments();
                }
                else
                {
                    _shippingId = short.Parse(txtProductSKU.Text);
                    DisplayShipment(_shippingId);
                }
            }
            catch (FormatException) //for shitty inputs
            {
                MessageBox.Show(@"Are you sure you know what a number is? Because I don't think you do...", @"HEY IDIOT", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (ArgumentException ex) //for no rows/order
            {
                MessageBox.Show(ex.Message, @"AIYAH", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void DisplayShipment(int sId)
        {
            var query = " SELECT SP.product_id, SP.quantity, P.product_name," +
                        " round((SP.quantity * P.product_price), 2) AS TOTALPRICE" +
                        " FROM shipment_product AS SP";
            query += " INNER JOIN product AS P ON SP.product_id = P.product_id";
            query += " WHERE SP.shipment_id = '" + sId + "'";

            var ds = new DataSet();
            dgvPendingShipment.DataSource = null;

            var mda = new MySqlDataAdapter(query, _connection);
            mda.Fill(ds, "SHIPMENT");

            dgvPendingShipment.DataSource = ds.Tables["SHIPMENT"];

            if (ds.Tables["SHIPMENT"].Rows.Count == 0)
            {
                throw new ArgumentException("No shipment with the ID " + sId + " was found.");
            }

			//disable the markShip button
			btnMarkShipped.Enabled = false;
        }

        private void DisplayAllShipments()
        {
            var query = " SELECT S.shipment_id AS ID, L.location_name AS DESTINATION, S.shipment_date AS SHIPDATE," +
                        " C.client_name AS CLIENT, C.client_rep AS CONTACT, S.hasShipped AS SHIPPED" +
                          " FROM shipment AS S";
            query += " INNER JOIN location AS L ON S.location_id = L.location_id";
            query += " INNER JOIN client AS C ON L.client_id = C.client_id";
            query += " ORDER BY S.shipment_id ASC";

            var dataset = new DataSet();
            dgvPendingShipment.DataSource = null;

            var myadapter = new MySqlDataAdapter(query, _connection);
            myadapter.Fill(dataset, "SHIPMENT");

            dgvPendingShipment.DataSource = dataset.Tables["SHIPMENT"];

			//enable the markShip button
			btnMarkShipped.Enabled = true;
        }

		//Add the shit to the thing
        private void btnAddProduct_Click(object sender, EventArgs e)
        {
			int pID = 0;
			int amt = 0;
			string pName = "";

			try
			{
				pID = Convert.ToInt32(txtSKU.Text);
				amt = Convert.ToInt32(txtProductQuantity.Text);
				pName = getProduct(pID);

				//CHECK FOR DUPLICATES FIRST
				if (listSkews.Contains(pID))
				{
					throw new ArgumentException("The specified product has already been added!");				
				}
				else
				{
					if (amt < 1)
					{
						throw new ArgumentException("Please enter an amount greater than 0."); //amount check
					}
					else
					{
						listSkews.Add(pID);
						listQuan.Add(amt);
					}
				}

				ListViewItem lineProduct = new ListViewItem(pID.ToString());
				lineProduct.SubItems.Add(pName);
				lineProduct.SubItems.Add(amt.ToString());

				lstShipProducts.Items.Add(lineProduct);

				//enable the super insert fuckmobobobsdffsdfsf
				btnCreate.Enabled = true;
			}
			catch (ArgumentException ex)
			{
				MessageBox.Show(ex.Message, @"AIYAH", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			catch (FormatException)
			{
				MessageBox.Show("Product SKU and quantity must be numbers!", @"AIYAH", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
        }

		//remove selected product row
        private void btnRemoveProduct_Click(object sender, EventArgs e)
        {
			try
			{
				removeRow();
			}
			catch (ArgumentException ex)
			{
				MessageBox.Show(ex.Message, @"AIYAH", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
        }

		//method of row removal
		private void removeRow()
		{
			if (lstShipProducts.SelectedItems.Count < 1) //check if anythings selected
			{
				throw new ArgumentException("Select a row to remove!");
			}
			else
			{
				//get the SKU first, then the index of that sku and remove the elements at that IDX in the two lists
				int removalSKU = Convert.ToInt32(lstShipProducts.SelectedItems[0].SubItems[0].ToString());
				int removalIDX = listSkews.IndexOf(removalSKU);
				listSkews.Remove(removalIDX);
				listQuan.Remove(removalIDX);
				
				lstShipProducts.Items.Remove(lstShipProducts.SelectedItems[0]);
			}
		}

		private void DisplayDesination()
        {
            string query = "SELECT concat(\"[\", location_id, \"] \", location_name) AS LOC from location";
            DataSet destinations = new DataSet();
            MySqlDataAdapter myAdapter = new MySqlDataAdapter(query, _connection);
            myAdapter.Fill(destinations, "LOC");
            cboDestination.DataSource = destinations.Tables["LOC"];
            cboDestination.DisplayMember = "LOC";

			//NOTE: i actually don't like how janky having the ID infront of the name looks, but I need to ensure that 
			//I'm using a unique identifier in the other parts of the program. If anyone can think of a better option,
			//let me know.
        }

        private void Shipping_Load(object sender, EventArgs e)
        {
            DisplayDesination();
			labDate.Text = DateTime.Now.Date.ToString(CultureInfo.InvariantCulture).Substring(0, 10); //Note: either I'm really fucking tired and losing it, or the "1"s in the label look fucked
        }

		private void connectToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (_connection.State == ConnectionState.Closed)
			{
				const string server = "173.180.133.176";
				const string db = "hi-tec";
				const string id = "root";
				const string pass = "superpassword";
				const string port = "3306";

				const string connectionString = "SERVER=" + server + ";PORT=" + port + ";DATABASE=" + db + ";UID=" + id + ";PASSWORD=" + pass + ";";
				_connection = new MySqlConnection(connectionString);

				_connection.Open();

				staShipping.Items["tslServerStatus"].Text = @"Connected";
				staShipping.Items["tslServerStatus"].ForeColor = Color.Green;

				connectToolStripMenuItem.Enabled = false;
				disconnectToolStripMenuItem.Enabled = true;
			}
		}

		//THIS THING
		//marks the selected row (shipment) as shipped
		private void btnMarkShipped_Click(object sender, EventArgs e)
		{
			try
			{
				mark();
			}
			catch (ArgumentException ex)
			{
				MessageBox.Show(ex.Message, @"AIYAH", MessageBoxButtons.OK);
			}
			catch (MySqlException)
			{
				MessageBox.Show(@"Error updating shipments. Please contact an Administrator.", @"OOPS", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		//this is the actual mark as shipped method, called by above button
		private void mark()
		{
			if (dgvPendingShipment.SelectedRows.Count < 1) //check if you actually have anything selected
			{
				throw new ArgumentException("No row selected!");
			}

			if (dgvPendingShipment.SelectedRows[0].Cells[5].Value.ToString() == "True") //check if already shipped
			{
				throw new ArgumentException("Shipment is already shipped!");
			}

			string crap = dgvPendingShipment.SelectedRows[0].Cells[0].Value.ToString();
			int SID = Int32.Parse(crap);

			//run the update query
			string updateQuery = "UPDATE shipment SET hasShipped = '1' WHERE shipment_id = '" + SID + "';";
			_command.CommandText = updateQuery;
			_command.Connection = _connection;
			MySqlDataReader MDR = _command.ExecuteReader();
			MDR.Close();

			//update the display
			DisplayAllShipments();
		}

		//prepares a new shipment to be created
		private void btnNewShipment_Click(object sender, EventArgs e)
		{
			//ENABLE THE CONTROLS YO
			cboDestination.Enabled = true;
			txtSKU.Enabled = true;
			txtProductQuantity.Enabled = true;
			btnAddProduct.Enabled = true;
			btnRemoveProduct.Enabled = true;
			
			//New shipment_id
			newID = getLastID("shipment", "shipment_id") + 1;
			
			//update the labeldisplay shit yeah fuck am i tired
			labShipID_Display.Text = "New Shipment ID: " + newID.ToString();

			MessageBox.Show("New shipment staged!", "READY", MessageBoxButtons.OK);
		}

		//This will grab the last ID in a mojig
		private int getLastID(string table, string field)
		{
			int theID = 0;

			string query = "SELECT " + field + " FROM " + table + " ORDER BY " + field + " DESC LIMIT 1;";
			_command.CommandText = query;
			_command.Connection = _connection;
			MySqlDataReader MDR = _command.ExecuteReader();

			while (MDR.Read())
			{
				theID = Convert.ToInt32(MDR[0].ToString());
			}

			MDR.Close();

			return theID;
		}

		//gets the product name given a SKU
		private string getProduct(int SKU)
		{
			string name = "";

			string query = "SELECT product_name FROM product WHERE product_id = '" + SKU + "';";
			_command.CommandText = query;
			_command.Connection = _connection;
			MySqlDataReader MDR = _command.ExecuteReader();

			while (MDR.Read())
			{
				name = MDR[0].ToString();
			}

			MDR.Close();

			if (String.IsNullOrEmpty(name))
			{
				throw new ArgumentException("No product with the SKU " + SKU + " exists!");
			}
			else
			{
				return name;
			}
		}

		//putting this here for now
		private void btnCreate_Click(object sender, EventArgs e)
		{
			try
			{
				DialogResult confirm = MessageBox.Show("Are you sure?", "CONFIRM SHIPMENT", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

				if (confirm == DialogResult.Yes)
				{
					int locationID = Convert.ToInt32(cboDestination.Text.Split(']')[0].Trim('['));
					string shipDate = labDate.Text;
					createShipment(newID, locationID, shipDate);

					//if we've gotten this far, then it's a success and I gotta reset everything and shit
					MessageBox.Show("Shipment created!", "SUCCESS", MessageBoxButtons.OK);

					listQuan.Clear();
					listSkews.Clear();
					lstShipProducts.Items.Clear();
					txtSKU.Clear();
					txtSKU.Enabled = false;
					txtProductQuantity.Clear();
					txtProductQuantity.Enabled = false;

					btnAddProduct.Enabled = false;
					btnRemoveProduct.Enabled = false;
					btnCreate.Enabled = false;

					labShipID_Display.Text = "---";

					//re-display all the shipments so the user can see the changes
					DisplayAllShipments();
				}
			}
			catch (ArgumentException ex)
			{
				MessageBox.Show(ex.Message, @"AIYAH", MessageBoxButtons.OK);
			}
			catch (MySqlException)
			{
				MessageBox.Show(@"Error creating the shipment. Please contact an Administrator.", @"OOPS", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		//method for insertions
		private void createShipment(int id, int loc, string date)
		{
			//prep the date for proper format in the DB
			DateTime dateFormat = DateTime.Parse(date);
			date = dateFormat.ToString("yyyy-MM-dd");

			string shipmentQuery = "INSERT INTO shipment VALUES ('" + id + "', '" + loc + "', '" + date + "', '0');";
			_command.CommandText = shipmentQuery;
			_command.Connection = _connection;
			MySqlDataReader MDR = _command.ExecuteReader();
			MDR.Close();

			createShipmentDetails(id); //make the stuff
		}

		//for shipment_products
		private void createShipmentDetails(int id)
		{
			for (int i = 0; i < listSkews.Count; i++)
			{
				int SKU = listSkews.ElementAt(i);
				int AMT = listQuan.ElementAt(i);

				string detailQuery = "INSERT INTO shipment_product VALUES ('" + id + "', '" + SKU + "', '" + AMT + "');";
				_command.CommandText = detailQuery;
				_command.Connection = _connection;
				MySqlDataReader MDR = _command.ExecuteReader();
				MDR.Close();
			}
		}

		private void disconnectToolStripMenuItem_Click_1(object sender, EventArgs e)
		{
			_connection?.Close();

			if (_connection.State == ConnectionState.Closed)
			{
				staShipping.Items["tslServerStatus"].Text = @"Disconnected";
				staShipping.Items["tslServerStatus"].ForeColor = Color.OrangeRed;

				connectToolStripMenuItem.Enabled = true;
				disconnectToolStripMenuItem.Enabled = false;
			}
		}

		private void logOutToolStripMenuItem_Click_1(object sender, EventArgs e)
		{
			_connection?.Close();
			Hide();
			var login = new FormMain();
			login.Closed += (s, args) => Close();
			login.Show();
		}
	}
}
