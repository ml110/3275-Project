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
	public partial class Shipping : Form
	{
        private MySqlConnection _connection;
        private readonly MySqlCommand _command;
        private readonly string _empName;
        private int _shippingId; 

        public Shipping(MySqlConnection conn, MySqlCommand cmd, string empName)
        {
            InitializeComponent();
            _connection = conn;
            _command = cmd;
            _empName = empName;

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
            //string server = "localhost";
            const string db = "hi-tec";
            const string id = "root";
            const string pass = "superpassword";
            //string pass = "superpassword";
            const string port = "3306";

            const string connectionString = "SERVER=" + server + ";PORT=" + port + ";DATABASE=" + db + ";UID=" + id + ";PASSWORD=" + pass + ";";
            _connection = new MySqlConnection(connectionString);

            _connection.Open();
        }

		private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
		{
			var aboutpage = new WarehouseAppAbout {Visible = true};
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
        }

        private void DisplayAllShipments()
        {
            var query = " SELECT S.shipment_id, L.location_name AS Destination, S.shipment_date," +
                        " C.client_name, C.client_rep, S.hasShipped" +
                          " FROM shipment AS S";
            query += " INNER JOIN location AS L ON S.location_id = L.location_id";
            query += " INNER JOIN client AS C ON L.client_id = C.client_id";
            query += " ORDER BY S.shipment_id ASC";

            var dataset = new DataSet();
            dgvPendingShipment.DataSource = null;

            var myadapter = new MySqlDataAdapter(query, _connection);
            myadapter.Fill(dataset, "SHIPMENT");

            dgvPendingShipment.DataSource = dataset.Tables["SHIPMENT"];
        }
    }
}
