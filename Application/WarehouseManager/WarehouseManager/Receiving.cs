///////////////////////////////////////////////////////////////////////////////////////////////////
/* CSIS 3275 - SOFTWARE ENGINEERING
 * HI-TEC ELECTRONIC GOODS WAREHOUSE MANAGEMENT SYSTEM - RECEIVING FORM
 * 
 */
///////////////////////////////////////////////////////////////////////////////////////////////////
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
///////////////////////////////////////////////////////////////////////////////////////////////////
using MySql.Data.MySqlClient;
using System.Diagnostics;

namespace WarehouseManager
{
	public partial class Receiving : Form
	{
        //SQL Connection
        private MySqlConnection _connection;
		private readonly MySqlCommand _command;
		private readonly string _empName;

		private int _lookupId; //OrderID

		//these for storing the values I need to insert
		private readonly List<int> _listSkews = new List<int>();
		private readonly List<int> _listAmounts = new List<int>();
        
		//RELEASE CONSTRUCTOR
		public Receiving(MySqlConnection conn, MySqlCommand cmd, string empName)
		{
			InitializeComponent();
			_connection = conn;
			_command = cmd;
			_empName = empName;
			staReceiving.Items["tslLoggedUser"].Text = empName;

			if (_connection.State == ConnectionState.Open)
			{
				staReceiving.Items["tslServerStatus"].Text = @"Connected";
				staReceiving.Items["tslServerStatus"].ForeColor = Color.Green;

				connectToolStripMenuItem.Enabled = false;
				disconnectToolStripMenuItem.Enabled = true;
			}
			else
			{
				staReceiving.Items["tslServerStatus"].Text = @"Disconnected";
				staReceiving.Items["tslServerStatus"].ForeColor = Color.OrangeRed;

				connectToolStripMenuItem.Enabled = true;
				disconnectToolStripMenuItem.Enabled = false;
			}


		}

		//TEST CONSTRUCTOR
        public Receiving()
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

		//view the inputed order number
        private void btnLookup_Click(object sender, EventArgs e)
        {
			try
			{
				_lookupId = short.Parse(txtOrderID.Text);
				DisplayOrder(_lookupId);
				//updateOrderInfo(lookupID);
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

        //This method takes in a number (the orderID), and spits out the associated data to the DGV
        private void DisplayOrder(int oId)
        {
            var query = "SELECT P.product_id AS SKU, P.product_name AS PRODUCTNAME, " +
                        "concat(OP.quantity, \" units\") AS AMOUNT, " +
                        "concat(\"$\", (round((OP.quantity * P.product_price), 2))) AS TOTALPRICE, " +
                        "OP.isDamaged AS DAMAGED FROM `order` AS O";
                query += " INNER JOIN order_product AS OP ON O.order_id = OP.order_id";
                query += " INNER JOIN product AS P ON OP.product_id = P.product_id";
                query += " INNER JOIN supplier AS S ON O.supplier_id = S.supplier_id";
                query += " WHERE O.order_id = '" + oId + "'";

            var ds = new DataSet();
            dgvLookup.DataSource = null;

	        var mda = new MySqlDataAdapter(query, _connection);
            mda.Fill(ds, "ORDER");

            dgvLookup.DataSource = ds.Tables["ORDER"];

			//Check for empty result meaning no record found
			if (ds.Tables["ORDER"].Rows.Count == 0)
			{
				labOrderInfo.Text = "";
				throw new ArgumentException("No order with the ID " + oId + " was found.");
			}
	        UpdateOrderInfo(oId);

	        //Add the columns to the bottom
	        dgvChecklist.Columns.Clear(); //clear anything that's still there
	        dgvChecklist.Columns.Add((DataGridViewColumn)dgvLookup.Columns[0].Clone()); //SKU
	        dgvChecklist.Columns.Add((DataGridViewColumn)dgvLookup.Columns[1].Clone()); //Product Name
	        dgvChecklist.Columns.Add((DataGridViewColumn)dgvLookup.Columns[2].Clone()); //Quantity

	        //ensure the lists are clear
	        _listSkews.Clear();
	        _listAmounts.Clear();
        }

        //This method updates the left side panel with the order supplier and date
        private void UpdateOrderInfo(int oId)
        {
            var query = "SELECT S.supplier_name AS SNAME, O.order_date AS ODATE FROM `order` AS O";
                query += " INNER JOIN supplier AS S ON O.supplier_id = S.supplier_id";
                query += " WHERE O.order_id = '" + oId + "'";
            _command.CommandText = query;
            _command.Connection = _connection;
            var reader = _command.ExecuteReader();

            while (reader.Read())
            {
				var dateString = reader["ODATE"].ToString();
				dateString = dateString.Substring(0, 10).Trim();
				
				labOrderInfo.Text = reader["SNAME"] + Environment.NewLine;
                labOrderInfo.Text += dateString;
            }

            reader.Close();
        }

		//THIS needs to add the selected row from the top DGV into the bottom readonly DGV
		private void btnAdd_Click(object sender, EventArgs e)
		{
			try
			{
				int skew = short.Parse(dgvLookup.SelectedRows[0].Cells[0].Value.ToString());

				//check if SKU is already in the list, if it is then I can't add the stuff
				if (_listSkews.Contains(skew))
				{
					MessageBox.Show(@"The selected product has already been added!", @"AIYAH", MessageBoxButtons.OK);
				}
				else
				{
					//is the selected row damaged?
					if (dgvLookup.SelectedRows[0].Cells[4].Value.ToString() == "True")
					{
						MessageBox.Show(@"The selected product is damaged!", @"AIYAH", MessageBoxButtons.OK);
					}
					else
					{
						_listSkews.Add(skew);
						int amt = Int16.Parse(dgvLookup.SelectedRows[0].Cells[2].Value.ToString().Split(' ')[0]);
						_listAmounts.Add(amt);

						//Now add the rows
						var sku = dgvLookup.SelectedRows[0].Cells[0].Value.ToString();
						var pName = dgvLookup.SelectedRows[0].Cells[1].Value.ToString();
						var quan = dgvLookup.SelectedRows[0].Cells[2].Value.ToString();
						dgvChecklist.Rows.Add(sku, pName, quan);

						//disable the damaged checkbox
						dgvLookup.SelectedRows[0].Cells[4].ReadOnly = true;
						//colour the added row
						dgvLookup.SelectedRows[0].DefaultCellStyle.BackColor = Color.LightGreen;
					}
				}
			}
			catch (ArgumentOutOfRangeException)
			{
				MessageBox.Show(@"Please select a row.", @"AIYAH", MessageBoxButtons.OK);
			}
		}

		//time to update the DB
		private void btnUpdate_Click(object sender, EventArgs e)
		{
			try
			{
				//VALID CHECK//////
				OrderValid();
				//////////////////

				UpdateInventory(_listSkews, _listAmounts);
				UpdateDamaged();
				MessageBox.Show(@"Inventory Updated!", @"SUCCESS", MessageBoxButtons.OK);

				//clear the stuff on success
				_listSkews.Clear();
				_listAmounts.Clear();
				dgvChecklist.Rows.Clear();
				dgvChecklist.Columns.Clear();
				dgvLookup.DataSource = null;
				txtOrderID.Text = null;
				labOrderInfo.Text = null;
			}
			catch (ArgumentException ex)
			{
				MessageBox.Show(ex.Message, @"OOPS", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			catch (MySqlException)
			{
				MessageBox.Show(@"Error updating inventory. Please contact an Administrator.", @"OOPS", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		//actual method that updates
		private void UpdateInventory(IReadOnlyCollection<int> sku, List<int> amt)
		{
			//check if they're empty
			if (sku.Count < 1)
			{
				throw new ArgumentException("No products to add!");
			}

			for (var i = 0; i < _listSkews.Count; i++)
			{
				var currentStock = GetStock(sku.ElementAt(i));
				var updatedStock = currentStock + amt.ElementAt(i);
				
				_command.CommandText = "UPDATE product SET product_stock = '" + updatedStock + "' WHERE product_id = '" + sku.ElementAt(i) + "';";
				_command.Connection = _connection;
				var sRead = _command.ExecuteReader();
				sRead.Close();
			}
		}

		//method for returning the current stock 
		private int GetStock(int pId)
		{
			var stock = 0;

			_command.CommandText = "SELECT product_stock FROM product WHERE product_id = '" + pId + "' LIMIT 1;";
			_command.Connection = _connection;
			var sRead = _command.ExecuteReader();

			while (sRead.Read())
			{
				stock = short.Parse(sRead[0].ToString());
			}

			sRead.Close();

			return stock;
		}

		//method for updating damaged items in an order (order_product)
		//idea for this is to just scan through the display and find the ones that are damaged.
		private void UpdateDamaged()
		{
			for (var i = 0; i < dgvLookup.Rows.Count; i++)
			{
				Debug.WriteLine(i + " " + Convert.ToString(dgvLookup.Rows[i].Cells[4].Value));

				if (Convert.ToString(dgvLookup.Rows[i].Cells[4].Value) != "True") continue;
				int damSku = short.Parse(Convert.ToString(dgvLookup.Rows[i].Cells[0].Value));
				int damOid = short.Parse(txtOrderID.Text);

				_command.CommandText = "UPDATE order_product SET isDamaged = '1' WHERE order_id = '" + damOid + "' AND product_id = '" + damSku + "';";
				_command.Connection = _connection;
				var sRead = _command.ExecuteReader();
				sRead.Close();
			}
		}

		//This method checks to ensure that all items (rows) in the dgvLookup have been checked or added
		private void OrderValid()
		{
			var totalItems = dgvLookup.Rows.Count;
			var damagedItems = 0;
			var addedItems = dgvChecklist.Rows.Count;

			for (var i = 0; i < dgvLookup.Rows.Count; i++)
			{
				if (Convert.ToString(dgvLookup.Rows[i].Cells[4].Value) == "True")
				{
					damagedItems++;
				}
			}

			if ((damagedItems + addedItems) != totalItems)
			{
				throw new ArgumentException("You still have unprocessed items!");
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
			const string server = "173.180.133.176";
			const string db = "hi-tec";
			const string id = "root";
			const string pass = "superpassword";
			const string port = "3306";

			const string connectionString = "SERVER=" + server + ";PORT=" + port + ";DATABASE=" + db + ";UID=" + id + ";PASSWORD=" + pass + ";";
			_connection = new MySqlConnection(connectionString);

			_connection.Open();

			staReceiving.Items["tslServerStatus"].Text = @"Connected";
			staReceiving.Items["tslServerStatus"].ForeColor = Color.Green;

			connectToolStripMenuItem.Enabled = false;
			disconnectToolStripMenuItem.Enabled = true;
		}

		private void disconnectToolStripMenuItem_Click(object sender, EventArgs e)
		{
			_connection?.Close();

			staReceiving.Items["tslServerStatus"].Text = @"Disconnected";
			staReceiving.Items["tslServerStatus"].ForeColor = Color.OrangeRed;

			connectToolStripMenuItem.Enabled = true;
			disconnectToolStripMenuItem.Enabled = false;
		}
	}
}
