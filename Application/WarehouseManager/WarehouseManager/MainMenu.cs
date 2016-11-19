using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WarehouseManager
{
	public partial class FormMain : Form
	{
		public FormMain()
		{
			InitializeComponent();
		}

		private void btnRec_Click(object sender, EventArgs e)
		{
			var recForm = new Receiving {Visible = true};
		}

		private void btnLogin_Click(object sender, EventArgs e)
		{

		}
	}
}
