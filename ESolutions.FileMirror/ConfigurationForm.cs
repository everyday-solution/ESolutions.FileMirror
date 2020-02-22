using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Configuration;
using System.Xml;

namespace ESolutions.FileForwarder
{
	public partial class ConfigurationForm : Form
	{
		//Properties
		#region FileLocation
		public FileLocation FileLocation
		{
			get;
			set;
		} = new FileLocation();
		#endregion

		//Constructors
		#region ConfigurationForm 
		public ConfigurationForm ()
		{
			InitializeComponent ();
			this.FileLocation.LocationType = LocationTypes.File;
			this.typeComboBox.SelectedIndex = 0;
			this.portTextBox.Text = "21";
		}
		#endregion

		//Methods
		#region TypeComboBox_SelectedIndexChanged
		private void TypeComboBox_SelectedIndexChanged (object sender, EventArgs e)
		{
			if (typeComboBox.SelectedIndex == 0)
			{
				directoryPanel.Visible = true;
				ftpPanel.Visible = false;
				FileLocation.LocationType = LocationTypes.File;
			}
			else
			{
				directoryPanel.Visible = false;
				ftpPanel.Visible = true;
				FileLocation.LocationType = LocationTypes.Ftp;
			}
		}
		#endregion

		#region CancelButton_Click
		private void CancelButton_Click (object sender, EventArgs e)
		{
			FileLocation = null;
			this.Close ();
		}
		#endregion

		#region OkButton_Click
		private void OkButton_Click (object sender, EventArgs e)
		{
			this.FileLocation.Directory = this.directoryTextBox.Text;
			this.FileLocation.FtpData.Server = this.serverTextBox.Text;
			this.FileLocation.FtpData.Port = Convert.ToInt32 (this.portTextBox.Text);
			this.FileLocation.FtpData.User = this.userTextBox.Text;
			this.FileLocation.FtpData.Password = this.passwordTextBox.Text;
			this.FileLocation.FtpData.RemoteDirectory = this.remoteDirectoryTextBox.Text;

			// Save Settings
			/*
			SettingElement element = new SettingElement ();
			SettingElementCollection collection = new SettingElementCollection ();
			SettingValueElement elementValue = new SettingValueElement ();
			XmlDocument doc = new System.Xml.XmlDocument ();
			
			element.Name = "LocationType";
			elementValue.ValueXml = "LocationType";
			elementValue.ValueXml.Value = this.fileLocation.LocationType;
			element.Value = elementValue;
			collection.Add (element);

			element.Name = "Directory";
			elementValue.ValueXml = doc.CreateElement ("Directory");
			elementValue.ValueXml.Value = this.fileLocation.Directory;
			element.Value = elementValue;
			collection.Add (element);

			element.Name = "FtpServer";
			elementValue.ValueXml.Value = this.fileLocation.FtpData.Server;
			element.Value = elementValue;
			collection.Add (element);

			element.Name = "FtpPort";
			elementValue.ValueXml.Value = this.fileLocation.FtpData.Port.ToString ();
			element.Value = elementValue;
			collection.Add (element);

			element.Name = "FtpUser";
			elementValue.ValueXml.Value = this.fileLocation.FtpData.User;
			element.Value = elementValue;			
			collection.Add (element);

			element.Name = "FtpPassword";
			elementValue.ValueXml.Value = this.fileLocation.FtpData.Password;
			element.Value = elementValue;
			collection.Add (element);

			element.Name = "FtpRemoteDirectory";
			elementValue.ValueXml.Value = this.fileLocation.FtpData.RemoteDirectory;
			element.Value = elementValue;
			collection.Add (element);
			*/
			this.Close ();
		}
		#endregion

		#region ChooseDirectoryButton_Click
		private void ChooseDirectoryButton_Click (object sender, EventArgs e)
		{
			this.folderBrowserDialog.ShowDialog ();
			this.directoryTextBox.Text = folderBrowserDialog.SelectedPath;
		}
		#endregion
	}
}