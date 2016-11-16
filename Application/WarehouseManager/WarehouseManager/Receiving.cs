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
        
        public Receiving()
		{
			InitializeComponent();
		}
	}
}
