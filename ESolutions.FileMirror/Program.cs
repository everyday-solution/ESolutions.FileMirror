using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ESolutions.FileForwarder
{
	public static class Program
	{
		#region Main
		[STAThread]
		static void Main()
		{
			Application.Run(new MainForm());
		}
		#endregion
	}
}
