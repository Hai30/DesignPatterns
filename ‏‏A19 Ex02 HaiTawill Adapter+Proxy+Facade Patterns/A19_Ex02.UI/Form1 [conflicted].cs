using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace A19_Ex02.UI
{

    // $G$ CSS-999 (-3) name of the file and the calls should be the same

    public partial class mainForm : Form
	{
		public mainForm()
		{
			InitializeComponent();
			
		}

		private void buttonLogin_Click_1(object sender, EventArgs e)
		{
			FaceNewsForm newForm = new FaceNewsForm(this);
			newForm.Show();
		}


	
	}
}
