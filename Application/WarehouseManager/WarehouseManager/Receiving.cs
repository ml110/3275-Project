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
        MySqlCommand command = new MySqlCommand();

        private int lookupID; //OrderID

		//these for storing the values I need to insert
		List<int> listSkews = new List<int>();
		List<int> listAmounts = new List<int>();
        
		//public Receiving(MySqlConnection conn, MySqlCommand cmd)
        public Receiving()
		{
			InitializeComponent();
            DBConnect(); //REMOVE THIS IN FINAL VERSION
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
				MessageBox.Show(ex.Message, "OOPS", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
			int skew = Int16.Parse(dgvLookup.SelectedRows[0].Cells[0].Value.ToString());
			listSkews.Add(skew);
			int amt = Int16.Parse(dgvLookup.SelectedRows[0].Cells[2].Value.ToString().Split(' ')[0]);
			listAmounts.Add(amt);

			//DataGridViewColumn DGVcol = dgvLookup.Columns.
			//dgvChecklist.Rows.Add("test", "test", "test");
		}
	}
}
