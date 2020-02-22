using System;
using System.Collections.Generic;
using System.Text;

namespace ESolutions.FileForwarder
{
	#region LocationTypes
	public enum LocationTypes : int
	{
		Ftp,
		File
	}
	#endregion

	[Serializable ()]
	public class FileLocation
	{
		//Properties
		#region LocationType
		public LocationTypes LocationType
		{
			get;
			set;
		} = new LocationTypes();
		#endregion

		#region Directory
		public String Directory
		{
			get;
			set;
		}
		#endregion

		#region FtpData
		public FtpConnectionData FtpData
		{
			get;
			set;
		}
		#endregion

		//Constructors
		#region FileLocation
		public FileLocation ()
		{
		}
		#endregion 

		//Methods
		#region GetLocationString
		public String GetLocationString ()
		{
			String locationString = "";

			if (this.LocationType == LocationTypes.File)
			{
				locationString = this.Directory;
			}
			else
			{
				var parameters = new Object[5];
				parameters[0] = this.FtpData.User;
				parameters[1] = this.FtpData.Password;
				parameters[2] = this.FtpData.Server;
				parameters[3] = this.FtpData.Port;
				parameters[4] = this.FtpData.RemoteDirectory;

				locationString = "ftp://{0}:{1}@{2}:{3}/{4}/";
				locationString = String.Format (locationString, parameters);
			}

			return locationString;
		}
		#endregion
	}
}
