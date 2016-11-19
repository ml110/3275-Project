///////////////////////////////////////////////////////////////////////////////////////////////////
/* CSIS 3275 - SOFTWARE ENGINEERING
 * HI-TEC ELECTRONIC GOODS WAREHOUSE MANAGEMENT SYSTEM - EMPLOYEE LOGIN FORM
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

namespace WarehouseManager
{
	public partial class FormMain : Form
	{
		//SQL Connection
		private MySqlConnection _connection;
		private readonly MySqlCommand _command;

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

		public FormMain()
		{
			InitializeComponent();
			DbConnect();
			_command = new MySqlCommand();
		}

		private void btnRec_Click(object sender, EventArgs e)
		{
			var recForm = new Receiving {Visible = true};
		}

		private void btnLogin_Click(object sender, EventArgs e)
		{
			/* validatedResult value meaning:
			 * 0 => Field is Empty
			 * 1 => Field is an Integer
			 * 2 => Field is not an Integer
			 * -1 => Something Fucky is going on
			 */
			//Login ID Validation Block
			//
			if (!string.IsNullOrWhiteSpace(txtLoginID.Text))
			{
				int temp;
				if (!int.TryParse(txtLoginID.Text, out temp))
				{
					erpLogin.SetError(txtLoginID, @"Entered Text is not a Valid Employee ID!");
				}
				else
				{
					erpLogin.SetError(txtLoginID, @"");
					var validId = int.Parse(txtLoginID.Text);
					if (!string.IsNullOrWhiteSpace(txtLoginPass.Text))
					{
						int temp1;
						if (!int.TryParse(txtLoginPass.Text, out temp1))
						{
							var validPass = txtLoginPass.Text;
							DbValidate(validId, validPass);
						}
						else
						{
							erpLogin.SetError(txtLoginPass, @"Entered Text is not a valid Password!");
						}

					}
					else
					{
						erpLogin.SetError(txtLoginPass, @"Please Enter Your Employee Password!");
					}
				}
			}
			else
			{
				erpLogin.SetError(txtLoginID, @"Please Enter Your Employee ID!");
			}
			
			
		}
		/* 
		 * SELECT emmloyee.employee_id, employee_creds.employee_password
		 * INNER JOIN employee ON employee_creds.employee_id = employee.employee_id
		 * WHERE employee.employee_id = '1' AND employee_creds.employee_password = 'Yellow'
		 */
		private void DbValidate(int empId, string empPass)
		{
			/*var query = "SELECT employee.employee_fname, employee.employee_lname, permission_group.permission_group_name" +
			            "INNER JOIN employee ON employee.employee_id = employee_creds.employee_id, " +
			            "INNER JOIN employee_creds ON employee_creds.permission_id = permission_group.permission_id, " +
			            "WHERE employee.employee_id = '" + empId + "' AND employee_creds.employee_password = '" + empPass + "'";
			*/

			var query1 = "SELECT employee.employee_id AS ID, employee_creds.employee_password AS PASSWORD, concat_ws(',', employee.employee_fname, employee.employee_lname) AS FullName" +
			             "FROM employee " +
			             "INNER JOIN employee_creds ON employee.employee_id = employee_creds.employee_id " +
			             "WHERE employee.employee_id = '" + empId + "' AND employee_creds.employee_password = '" + empPass + "'";
			var query2 = "";
			_command.Connection = _connection;
			_command.CommandText = query1;
			var reader = _command.ExecuteReader();
			var empName = "";
			int dbEmpId;
			string dbEmpPass;
			while (reader.Read())
			{
				empName = reader["FullName"].ToString();
				dbEmpId = int.Parse(reader["ID"].ToString());
				dbEmpPass = reader["PASSWORD"].ToString();
			}

			reader.Close();
			if (empName != "")
			{
				Hide();
				//Invoking Receiving Form's Constructor
				var receiving = new Receiving(_connection, _command, empName);
				receiving.Closed += (s, args) => Close();
				receiving.Show();
			}
				
		}

        private void button1_Click(object sender, EventArgs e)
        {
            var shipping = new Shipping() {Visible= true }; 
        }
    }
}
