///////////////////////////////////////////////////////////////////////////////////////////////////
/* CSIS 3275 - SOFTWARE ENGINEERING
 * HI-TEC ELECTRONIC GOODS WAREHOUSE MANAGEMENT SYSTEM - RECEIVING FORM
 * 
 */
///////////////////////////////////////////////////////////////////////////////////////////////////
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
using System.Data.SqlClient;
using System.Diagnostics;

namespace WarehouseManager
{
	public partial class Receiving : Form
	{
        //SQL Connection
        private MySqlConnection connection;
		MySqlCommand command;

        private int lookupID; //OrderID

		//these for storing the values I need to insert
		List<int> listSkews = new List<int>();
		List<int> listAmounts = new List<int>();
        
		//RELEASE CONSTRUCTOR
		public Receiving(MySqlConnection conn, MySqlCommand cmd, string empName)
		{
			InitializeComponent();
			connection = conn;
			command = cmd;

			//code needs to go here to change the lower left to display:
			// 1. The currently logged in user
			// 2. Connection status
		}

		//TEST CONSTRUCTOR
        public Receiving()
		{
			InitializeComponent();
            DBConnect();
			command = new MySqlCommand();
		}

        //TEMP CONNECT METHOD; REMOVE FROM FINAL VERSION
        private void DBConnect()
        {
			string server = "173.180.133.176";
			//string server = "localhost";
            string db = "hi-tec";
            string id = "root";
			string pass = "superpassword";
            //string pass = "superpassword";
            string port = "3306";

            string connectionString = "SERVER=" + server + ";PORT=" + port + ";DATABASE=" + db + ";UID=" + id + ";PASSWORD=" + pass + ";";
            connection = new MySqlConnection(connectionString);

            connection.Open();

            if (connection != null)
            {
                tslServerStatus.Text = "Connected";
                tslServerStatus.ForeColor = System.Drawing.Color.Green;
            }
            else
            {
                tslServerStatus.Text = "Disconnected";
                tslServerStatus.ForeColor = System.Drawing.Color.Red;
            }
        }

		//view the inputed order number
        private void btnLookup_Click(object sender, EventArgs e)
        {
			try
			{
				lookupID = Int16.Parse(txtOrderID.Text);
				displayOrder(lookupID);
				//updateOrderInfo(lookupID);
			}
			catch (FormatException) //for shitty inputs
			{
				MessageBox.Show("Are you sure you know what a number is? Because I don't think you do...", "HEY IDIOT", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			catch (ArgumentException ex) //for no rows/order
			{
				MessageBox.Show(ex.Message, "AIYAH", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
        }

        //This method takes in a number (the orderID), and spits out the associated data to the DGV
        private void displayOrder(int oID)
        {
            string QUERY = "SELECT P.product_id AS SKU, P.product_name AS PRODUCTNAME, concat(OP.quantity, \" units\") AS AMOUNT, concat(\"$\", (round((OP.quantity * P.product_price), 2))) AS TOTALPRICE, OP.isDamaged AS DAMAGED FROM `order` AS O";
                QUERY += " INNER JOIN order_product AS OP ON O.order_id = OP.order_id";
                QUERY += " INNER JOIN product AS P ON OP.product_id = P.product_id";
                QUERY += " INNER JOIN supplier AS S ON O.supplier_id = S.supplier_id";
                QUERY += " WHERE O.order_id = '" + oID + "'";

            DataSet ds = new DataSet();
            dgvLookup.DataSource = null;
            MySqlDataAdapter MDA;

            MDA = new MySqlDataAdapter(QUERY, connection);
            MDA.Fill(ds, "ORDER");

            dgvLookup.DataSource = ds.Tables["ORDER"];

			//Check for empty result meaning no record found
			if (ds.Tables["ORDER"].Rows.Count == 0)
			{
				labOrderInfo.Text = "";
				throw new System.ArgumentException("No order with the ID " + oID.ToString() + " was found.");
			}
			else
			{
				updateOrderInfo(oID);

				//Add the columns to the bottom
				dgvChecklist.Columns.Clear(); //clear anything that's still there
				dgvChecklist.Columns.Add((DataGridViewColumn)dgvLookup.Columns[0].Clone()); //SKU
				dgvChecklist.Columns.Add((DataGridViewColumn)dgvLookup.Columns[1].Clone()); //Product Name
				dgvChecklist.Columns.Add((DataGridViewColumn)dgvLookup.Columns[2].Clone()); //Quantity

				//ensure the lists are clear
				listSkews.Clear();
				listAmounts.Clear();
			}
        }

        //This method updates the left side panel with the order supplier and date
        private void updateOrderInfo(int oID)
        {
            string QUERY = "SELECT S.supplier_name AS SNAME, O.order_date AS ODATE FROM `order` AS O";
                QUERY += " INNER JOIN supplier AS S ON O.supplier_id = S.supplier_id";
                QUERY += " WHERE O.order_id = '" + oID + "'";
            command.CommandText = QUERY;
            command.Connection = connection;
            MySqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
				string dateString = reader["ODATE"].ToString();
				dateString = dateString.Substring(0, 10).Trim();
				
				labOrderInfo.Text = reader["SNAME"].ToString() + "\n";
                labOrderInfo.Text += dateString;
            }

            reader.Close();
        }

		//THIS needs to add the selected row from the top DGV into the bottom readonly DGV
		private void btnAdd_Click(object sender, EventArgs e)
		{
			try
			{
				int skew = Int16.Parse(dgvLookup.SelectedRows[0].Cells[0].Value.ToString());

				//check if SKU is already in the list, if it is then I can't add the stuff
				if (listSkews.Contains(skew))
				{
					MessageBox.Show("The selected product has already been added!", "AIYAH", MessageBoxButtons.OK);
				}
				else
				{
					//is the selected row damaged?
					if (dgvLookup.SelectedRows[0].Cells[4].Value.ToString() == "True")
					{
						MessageBox.Show("The selected product is damaged!", "AIYAH", MessageBoxButtons.OK);
					}
					else
					{
						listSkews.Add(skew);
						int amt = Int16.Parse(dgvLookup.SelectedRows[0].Cells[2].Value.ToString().Split(' ')[0]);
						listAmounts.Add(amt);

						//Now add the rows
						string SKU = dgvLookup.SelectedRows[0].Cells[0].Value.ToString();
						string pName = dgvLookup.SelectedRows[0].Cells[1].Value.ToString();
						string quan = dgvLookup.SelectedRows[0].Cells[2].Value.ToString();
						dgvChecklist.Rows.Add(SKU, pName, quan);

						//disable the damaged checkbox
						dgvLookup.SelectedRows[0].Cells[4].ReadOnly = true;
						//colour the added row
						dgvLookup.SelectedRows[0].DefaultCellStyle.BackColor = System.Drawing.Color.LightGreen;
					}
				}
			}
			catch (ArgumentOutOfRangeException)
			{
				MessageBox.Show("Please select a row.", "AIYAH", MessageBoxButtons.OK);
			}
		}

		//time to update the DB
		private void btnUpdate_Click(object sender, EventArgs e)
		{
			try
			{
				//VALID CHECK//////
				orderValid();
				//////////////////

				updateInventory(listSkews, listAmounts);
				updateDamaged();
				MessageBox.Show("Inventory Updated!", "SUCCESS", MessageBoxButtons.OK);

				//clear the stuff on success
				listSkews.Clear();
				listAmounts.Clear();
				dgvChecklist.Rows.Clear();
				dgvChecklist.Columns.Clear();
				dgvLookup.DataSource = null;
				txtOrderID.Text = null;
				labOrderInfo.Text = null;
			}
			catch (ArgumentException ex)
			{
				MessageBox.Show(ex.Message, "OOPS", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			catch (MySql.Data.MySqlClient.MySqlException)
			{
				MessageBox.Show("Error updating inventory. Please contact an Administrator.", "OOPS", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		//actual method that updates
		private void updateInventory(List<int> SKU, List<int> AMT)
		{
			//check if they're empty
			if (SKU.Count < 1)
			{
				throw new ArgumentException("No products to add!");
			}

			for (int i = 0; i < listSkews.Count; i++)
			{
				int currentStock = getStock(SKU.ElementAt(i));
				int updatedStock = currentStock + AMT.ElementAt(i);
				
				command.CommandText = "UPDATE product SET product_stock = '" + updatedStock + "' WHERE product_id = '" + SKU.ElementAt(i) + "';";
				command.Connection = connection;
				MySqlDataReader sRead = command.ExecuteReader();
				sRead.Close();
			}
		}

		//method for returning the current stock 
		private int getStock(int pID)
		{
			int stock = 0;

			command.CommandText = "SELECT product_stock FROM product WHERE product_id = '" + pID + "' LIMIT 1;";
			command.Connection = connection;
			MySqlDataReader sRead = command.ExecuteReader();

			while (sRead.Read())
			{
				stock = Int16.Parse(sRead[0].ToString());
			}

			sRead.Close();

			return stock;
		}

		//method for updating damaged items in an order (order_product)
		//idea for this is to just scan through the display and find the ones that are damaged.
		private void updateDamaged()
		{
			for (int i = 0; i < dgvLookup.Rows.Count; i++)
			{
				Debug.WriteLine(i + " " + Convert.ToString(dgvLookup.Rows[i].Cells[4].Value));

				if (Convert.ToString(dgvLookup.Rows[i].Cells[4].Value) == "True") //if damaged
				{
					int damSKU = Int16.Parse(Convert.ToString(dgvLookup.Rows[i].Cells[0].Value));
					int damOID = Int16.Parse(txtOrderID.Text);

					command.CommandText = "UPDATE order_product SET isDamaged = '1' WHERE order_id = '" + damOID + "' AND product_id = '" + damSKU + "';";
					command.Connection = connection;
					MySqlDataReader sRead = command.ExecuteReader();
					sRead.Close();
				}
			}
		}

		//This method checks to ensure that all items (rows) in the dgvLookup have been checked or added
		private void orderValid()
		{
			int totalItems = dgvLookup.Rows.Count;
			int damagedItems = 0;
			int addedItems = dgvChecklist.Rows.Count;

			for (int i = 0; i < dgvLookup.Rows.Count; i++)
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
	}
}
