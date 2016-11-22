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
			const string server = "192.168.1.78";
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

		private void btnLogin_Click(object sender, EventArgs e)
		{
			ButtonAction();
		}

		private void ButtonAction()
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
							var temp2 = DbValidate(validId, validPass);
							var isValid = bool.Parse(temp2[0]);
							if (!isValid)
							{
								erpLogin.SetError(btnLogin, @"Username or Password is incorrect");
							}
							else
							{
								erpLogin.SetError(btnLogin, @"");
								GetPermission(int.Parse(temp2[1]),temp2[2]);
							}

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

		/*	V1.0 w/ empID = 1, empPass = Yellow
			SELECT emmloyee.employee_id, employee_creds.employee_password
			INNER JOIN employee ON employee_creds.employee_id = employee.employee_id
			WHERE employee.employee_id = '1' AND employee_creds.employee_password = 'Yellow'
			V1.1 w/ empID = 1, empPass = Yellow
			SELECT employee.employee_id AS ID, employee_creds.employee_password AS PASSWORD, 
			concat_ws(',', employee.employee_fname, employee.employee_lname) AS FullName 
			FROM employee 
			INNER JOIN employee_creds ON employee.employee_id = employee_creds.employee_id 
			WHERE employee.employee_id = 1 AND employee_creds.employee_password = 'Yellow'
		*/
		private string[] DbValidate(int empId, string empPass)
		{
			var query1 = "SELECT employee.employee_id AS ID, employee_creds.employee_password AS PASSWORD, " +
			             "concat_ws(',', employee.employee_fname, employee.employee_lname) AS FullName " +
			             "FROM employee " +
			             "INNER JOIN employee_creds ON employee.employee_id = employee_creds.employee_id " +
			             "WHERE employee.employee_id = "+ empId +" AND employee_creds.employee_password = '" + empPass + "'";
			
			_command.Connection = _connection;
			_command.CommandText = query1;
			var reader = _command.ExecuteReader();
			string[] retValue = { bool.FalseString, "", "" };
			while (reader.Read())
			{
				var empName = reader["FullName"].ToString();
				var dbEmpId = int.Parse(reader["ID"].ToString());
				var dbEmpPass = reader["PASSWORD"].ToString();

				if (dbEmpId == empId && dbEmpPass == empPass)
				{
					empName = empName.Replace(',', ' ');
					reader.Close();
					retValue = new[] {bool.TrueString, dbEmpId.ToString(), empName};
					break;
				}
			}
			reader.Close();
			return retValue;
		}
		
		private void GetPermission(int empId, string empName)
		{
			var query2 = "SELECT PG.permission_id AS PID, PG.permission_group_name AS PNAME FROM employee_creds AS EC INNER JOIN permission_group AS PG ON EC.permission_id = PG.permission_id WHERE EC.employee_id = " + empId;
			
			//test query, delete later
			var query3 ="SELECT EC.employee_id AS EID, PG.permission_id AS PID, PG.permission_group_name AS PNAME FROM employee_creds AS EC INNER JOIN permission_group AS PG ON EC.permission_id = PG.permission_id WHERE EC.employee_id = 7";
			
			_command.Connection = _connection;
			_command.CommandText = query2;
			var reader = _command.ExecuteReader();
			var pname = "";
			var pid = 0;
			while (reader.Read())
			{
				pid = int.Parse(reader["PID"].ToString());
				pname = reader["PNAME"].ToString();
			}
			reader.Close();
			InvokeForm(pname,empName,pid);
			
		}
		/* Permission Group Name Reference
		 * 1. Warehouse Employee
		 * 2. Receiving
		 * 3. Shipping
		 * 4. Operations Supervisor - History
		 * 5. Warehouse Manager		- History
		 * 6. Administrator			- History
		 */
		private void InvokeForm(string formName, string empName, int pid)
		{
			Hide();

			//Invoking Inventory Form's Constructor
			if (formName == "Warehouse Employee")
			{
				var warehouse = new Inventory(_connection, _command, empName, pid);
				warehouse.Closed += (s, args) => Close();
				warehouse.Show();
			}
			//Invoking Receiving Form's Constructor
			if (formName == "Receiving")
			{
				var receiving = new Receiving(_connection, _command, empName);
				receiving.Closed += (s, args) => Close();
				receiving.Show();
			}
			//Invoking Shipping Form's Constructor
			if (formName == "Shipping")
			{
				var shipping = new Shipping(_connection, _command, empName);
				shipping.Closed += (s, args) => Close();
				shipping.Show();
			}
			//Invoking Operations Supervisor Form's Constructor
			if (formName == "Operations Supervisor")
			{
				var history = new History(_connection, _command, empName, pid);
				history.Closed += (s, args) => Close();
				history.Show();
			}
		}

		private void txtLoginPass_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (e.KeyChar == (char) Keys.Return)
			{
				ButtonAction();
			}
		}
	}
}
