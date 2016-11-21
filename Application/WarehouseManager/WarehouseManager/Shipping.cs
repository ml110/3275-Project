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
	}
}
