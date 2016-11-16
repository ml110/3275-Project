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
        
        public Receiving()
		{
			InitializeComponent();
            DBConnect();
		}

        //TEMP CONNECT METHOD; REMOVE ONCE ACTUAL DB IS UP
        private void DBConnect()
        {
            string server = "localhost";
            string db = "hi-tec";
            string id = "root";
            string pass = "";
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


        private void btnLookup_Click(object sender, EventArgs e)
        {
            try
            {
                lookupID = Int16.Parse(txtOrderID.Text);
                displayOrder(lookupID);
                updateOrderInfo(lookupID);
            }
            catch (FormatException)
            {
                MessageBox.Show("ERROR: Are you sure you know what a number is? Because I don't think you do...", "HEY IDIOT", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //This method takes in a number (the orderID), and spits out the associated data to the DGV
        private void displayOrder(int oID)
        {
            string QUERY = "SELECT P.product_name AS PRODUCTNAME, OP.quantity AS UNITAMOUNT, concat(\"$\", (round((OP.quantity * P.product_price), 2))) AS TOTALPRICE FROM `order` AS O";
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
                labOrderInfo.Text = "Order Supplier: " + reader["SNAME"].ToString() + "\n";
                labOrderInfo.Text += "Order Date: " + reader["ODATE"].ToString();
            }

            reader.Close();
        }
	}
}
