using FacebookWrapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

// $G$ RUL-004 (-20) Wrong zip name format / folder name format
// $G$ RUL-999 (-10) Wrong solution name


// $G$ THE-001 (-19) your grade on diagrams document - 81. please see comments inside the document. (50% of your grade).

namespace A19_Ex02.UI
{

    // $G$ CSS-999 (-3) class must have access modifiers
    static class Program
	{


        // $G$ CSS-999 (-3) method must have access modifiers
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
			Application.Run(new mainForm());
		}
	}
}
