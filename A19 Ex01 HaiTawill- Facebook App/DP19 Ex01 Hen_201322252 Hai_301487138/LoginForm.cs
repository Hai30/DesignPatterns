using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace A19_Ex01_Hen_201322252_Hai_301487138
{
	public partial class LoginForm : Form
	{
		public LoginForm()
		{
			InitializeComponent();
			
		}

		private void buttonLogin_Click_1(object sender, EventArgs e)
		{
			FaceNewsForm newForm = new FaceNewsForm();
			newForm.Show();
			this.Hide();
		}


	
	}
}
