using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace ESolutions.FileForwarder
{
	/// <summary>
	/// This forms uses directoryMirror class
	/// by Luc Archambault, stereo3d@gmail.com, February 2005
	/// </summary>
	public partial class MainForm : System.Windows.Forms.Form
	{
		#region SourceButton_Click
		private void SourceButton_Click  (object sender, System.EventArgs e)
		{
			if (onOff == false)
			{
				this.folderBrowserDialog.ShowDialog ();
				this.sourceLabel.Text = folderBrowserDialog.SelectedPath;
			}
			else
			{
				MessageBox.Show ("You need to stop the DirectoryMirror to change this path.", "DirectoryMirror is running");
			}
		}
		#endregion

		#region DestinationButton_Click
		private void DestinationButton_Click (object sender, System.EventArgs e)
		{
			if (onOff == false)
			{
				ConfigurationForm newForm = new ConfigurationForm ();
				newForm.ShowDialog ();

				if (newForm.FileLocation != null)
				{
					this.destinationLocation = newForm.FileLocation;
					this.destinationLabel.Text = destinationLocation.GetLocationString ();
				}
			}
			else
			{
				MessageBox.Show ("You need to stop the DirectoryMirror to change this path.", "DirectoryMirror is running");
			}
		}
		#endregion

		#region NotifyIcon1_DoubleClick
		// The tray icon has been double clicked
		private void NotifyIcon1_DoubleClick (object sender, System.EventArgs e)
		{
				// Show window
				this.Visible = true;
				this.Activate();
			}
		#endregion

		#region NotifyIcon1_Click
		// The tray icon has been clicked
		private void NotifyIcon1_Click (object sender, System.EventArgs e)
		{
			// Show window
			this.Visible = true;
			this.Activate();
		}
		#endregion

		#region Quit
		// Close the application
		private void Quit (object sender, System.EventArgs e)
		{
			this.Close();
			this.Dispose();
		}
		#endregion

		#region ViewSource
		// Open windows file explorer to see the source directory
		private void ViewSource (object sender, System.EventArgs e)
		{
         string targetURL = this.sourceLabel.ToString ();
			System.Diagnostics.Process.Start(targetURL);
		}
		#endregion

		#region ViewDestination
		// Open windows file explorer to see the ESolutions.FileForwarder directory
		private void ViewDestination (object sender, System.EventArgs e)
		{
			string targetURL = this.destinationLabel.ToString ();
			System.Diagnostics.Process.Start(targetURL);
		}
		#endregion

		#region InfoMessageEvent
		// Handles messages sent by the directoryMirror object
		private void InfoMessageEvent (string infoMessage)
		{
			if (this.InvokeRequired)
			{
				this.Invoke (new FileForwarder.InfoMessageEventHandler (this.InfoMessageEvent), new object[] {infoMessage});
			}
			else
			{
				logListView.Text = infoMessage + logListView.Text;
			}			
		}
		#endregion

		#region OnOffButton_Click
		private void OnOffButton_Click (object sender, System.EventArgs e)
		{
			try
			{
				if (this.onOff == false)
				{
					if ((this.sourceLabel.Text != "") && (this.destinationLabel.Text != ""))
					{
						this.fF = new FileForwarder (this.sourceLabel.Text, this.destinationLocation);
						this.fF.InfoMessageEvent += new ESolutions.FileForwarder.FileForwarder.InfoMessageEventHandler (InfoMessageEvent);
						this.onOff = true;
						this.logListView.Text = "\r\n \r\nSTARTED" + "\r\n" + logListView.Text;
						this.onOffButton.Text = "Stop";
						this.onOffLabel.Text = "Click to stop the DirectoryMirror";
					}
					else
					{
						MessageBox.Show ("Select a source folder and a ESolutions.FileForwarder folder.", "No folders selected");
					}
				}
				// If an instance of the directoryMirror object is running...
				else
				{
					this.fF.Dispose();
					this.onOff = false;
					this.logListView.Text = "\r\n \r\nSTOPPED" + "\r\n" + logListView.Text;
					this.onOffButton.Text = "Start";
					this.onOffLabel.Text = "Click to start the DirectoryMirror";
				}
			}
			catch (IOException iox)
			{
				this.logListView.Text = "\r\n EXCEPTION (start/stop): IO Error, " + iox.Message + this.logListView.Text;
			}
			catch (Exception ex)
			{
				this.logListView.Text = "\r\n EXCEPTION (start/stop): " + ex.Message + this.logListView.Text;
			}
		}
		#endregion
	}		
}
