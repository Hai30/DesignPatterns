using FacebookWrapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

// $G$ RUL-004 (-20) Wrong zip name format / folder name format
// $G$ RUL-999 (-10) Wrong solution name


// $G$ THE-001 (-43) your grade on diagrams document - 57. please see comments inside the document. (40% of your grade).



namespace A19_Ex01_Hen_201322252_Hai_301487138
{
	static class Program
	{
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			Clipboard.SetText("designpatterns");
			FacebookService.s_UseForamttedToStrings = true;
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new LoginForm());
		}
	}
}
