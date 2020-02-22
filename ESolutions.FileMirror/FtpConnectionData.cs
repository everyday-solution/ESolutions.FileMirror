using System;
using System.Collections.Generic;
using System.Text;

namespace ESolutions.FileForwarder
{
	public class FtpConnectionData
	{
		#region Server
		public String Server
		{
			get;
			set;
		}
		#endregion

		#region Port
		public int Port
		{
			get;
			set;
		}
		#endregion

		#region User
		public String User
		{
			get;
			set;
		}
		#endregion

		#region Password
		public String Password
		{
			get;
			set;
		}
		#endregion

		#region RemoteDirectory
		public String RemoteDirectory
		{
			get;
			set;
		}
		#endregion
	}
}
