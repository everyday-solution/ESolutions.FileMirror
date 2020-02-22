using System;
using System.IO;
using System.Security.Permissions;
using System.Configuration;
using System.Collections;
using System.Threading;

namespace ESolutions.FileForwarder
{
	/// <summary>
	/// fileForwarder
	/// An implementation based on the FileSystemWatcher class
	/// by Luc Archambault, stereo3d@gmail.com, February 2005
	/// 
	/// This class watches for IO activity in a "source" 
	/// directory to forward (move) a file into a specified 
	/// the destination directory. Through the 
	/// "infoMessageEvent" it sends back messages about IO
	/// activity and encountered exceptions.
	/// </summary>
	/// 

	// This class is based on the FileSystemWatcher class
	public class FileForwarder : System.IO.FileSystemWatcher
	{
		//Events and delegates
		#region InfoMessageEventHandler
		public delegate void InfoMessageEventHandler(string infoMessage);
		#endregion

		#region InfoMessageEvent
		public event InfoMessageEventHandler InfoMessageEvent;
		#endregion

		//Fields
		#region ftp
		private static FtpClient ftp = null;
		#endregion

		#region fileMoves
		public Queue filesMoves = new Queue();
		#endregion

		//Properties
		#region DestinationLocation
		public FileLocation DestinationLocation
		{
			get;
			set;
		} = new FileLocation();
		#endregion

		//Constructor
		#region FileForwarder
		public FileForwarder(string sourceLocation, FileLocation destinationLocation)
		{
			this.Path = sourceLocation;
			this.DestinationLocation = destinationLocation;
			this.Filter = "";
			this.NotifyFilter = ((System.IO.NotifyFilters)((System.IO.NotifyFilters.FileName |
																			System.IO.NotifyFilters.DirectoryName |
																			System.IO.NotifyFilters.LastWrite)));
			this.IncludeSubdirectories = true;
			this.EnableRaisingEvents = true;

			this.Changed += new FileSystemEventHandler(Fsw_OnChanged);
		}
		#endregion

		//Methods
		#region Fsw_OnChanged
		private void Fsw_OnChanged(object sender, System.IO.FileSystemEventArgs e)
		{
			if (File.Exists(e.FullPath) == true
				 && !filesMoves.Contains(e.FullPath))
			{
				try
				{
					FileStream fs = File.Open(e.FullPath, FileMode.Open, FileAccess.Write);
					fs.Close();
					InfoMessageEvent("\r\n" + "Start moving file " + e.FullPath);
					this.MoveFile(e);
				}
				catch (IOException ex)
				{
					InfoMessageEvent("\r\n" + e.FullPath + " is locked, try to move it later: " + ex.Message);
				}
			}
		}
		#endregion

		#region MoveFile
		private void MoveFile(System.IO.FileSystemEventArgs e)
		{
			try
			{
				filesMoves.Enqueue(e.FullPath);
				if (this.DestinationLocation.LocationType == LocationTypes.File)
				{
					string destination = e.FullPath.Replace(this.Path, this.DestinationLocation.GetLocationString());
					System.IO.File.Move(e.FullPath.ToString(), destination);
				}
				else
				{   //Files must be copied to FTP-location
					while (ftp != null)
					{
						Thread.Sleep(1000);
					}

					AsyncCallback callback = new AsyncCallback(CloseConnection);

					ftp = new FtpClient(this.DestinationLocation.FtpData.Server,
					  							this.DestinationLocation.FtpData.User,
												this.DestinationLocation.FtpData.Password,
												10,
												this.DestinationLocation.FtpData.Port);

					if (ftp.Login())
					{
						ftp.ChangeDir(this.DestinationLocation.FtpData.RemoteDirectory);
						ftp.BeginMove(e.FullPath, callback);
					}
					else
					{
						ftp = null;
					}
				}
				InfoMessageEvent("\r\n" + e.ChangeType + " " + e.FullPath);
			}
			catch (DirectoryNotFoundException iox)
			{
				InfoMessageEvent("\r\nEXCEPTION (onChanged): Directory Not Found , " + iox.Message);
				if (ftp != null)
				{
					ftp.Close();
					ftp = null;
				}
			}
			catch (FileNotFoundException iox)
			{
				InfoMessageEvent("\r\nEXCEPTION (onChanged): File Not Found, " + iox.Message);
				if (ftp != null)
				{
					ftp.Close();
					ftp = null;
				}
			}
			catch (IOException iox)
			{
				InfoMessageEvent("\r\nEXCEPTION (onChanged): IO Error, " + iox.Message);
				if (ftp != null)
				{
					ftp.Close();
					ftp = null;
				}
			}
			catch (Exception ex)
			{
				InfoMessageEvent("\r\nEXCEPTION (onChanged): " + ex.Message);
				if (ftp != null)
				{
					ftp.Close();
					ftp = null;
				}
			}
		}
		#endregion

		#region CloseConnection
		private void CloseConnection(IAsyncResult result)
		{
			if (result.IsCompleted == true)
			{
				InfoMessageEvent("\r\n Transfer finished:");
				ftp.Close();
				ftp = null;
			}
			else
			{
				InfoMessageEvent("\r\nTransfer terminated abnormaly, please check the log file");
				ftp = null;
			}
		}
		#endregion
	}
}
