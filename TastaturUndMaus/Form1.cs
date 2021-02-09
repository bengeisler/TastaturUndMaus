using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TastaturUndMaus
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void txtEingabe_KeyDown(object sender, KeyEventArgs e)
		{
			//lblAusgabe.Text = "Taste gedrückt. KeyCode: " + e.KeyCode;

			if (e.KeyCode == Keys.Enter)
			{
				//lblAusgabe.Text = txtEingabe.Text;
				btnAusgabe_Click(sender, e);
			}
		}

		private void btnAusgabe_Click(object sender, EventArgs e)
		{
			lblAusgabe.Text = txtEingabe.Text;
			// TextAusgeben();
		}

		//private void TextAusgeben()
		//{
		//	lblAusgabe.Text = txtEingabe.Text;
		//}
	}
}
