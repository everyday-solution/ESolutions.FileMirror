namespace ESolutions.FileForwarder
{
	partial class ConfigurationForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		#region Dispose
		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose (bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose ();
			}
			base.Dispose (disposing);
		}
		#endregion

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent ()
		{
			this.typeComboBox = new System.Windows.Forms.ComboBox ();
			this.typeLabel = new System.Windows.Forms.Label ();
			this.directoryTextBox = new System.Windows.Forms.TextBox ();
			this.label2 = new System.Windows.Forms.Label ();
			this.directoryPanel = new System.Windows.Forms.Panel ();
			this.chooseDirectoryButton = new System.Windows.Forms.Button ();
			this.label3 = new System.Windows.Forms.Label ();
			this.ftpPanel = new System.Windows.Forms.Panel ();
			this.portLabel = new System.Windows.Forms.Label ();
			this.portTextBox = new System.Windows.Forms.TextBox ();
			this.serverLabel = new System.Windows.Forms.Label ();
			this.serverTextBox = new System.Windows.Forms.TextBox ();
			this.remoteDirectoryLabel = new System.Windows.Forms.Label ();
			this.remoteDirectoryTextBox = new System.Windows.Forms.TextBox ();
			this.passwordLabel = new System.Windows.Forms.Label ();
			this.passwordTextBox = new System.Windows.Forms.TextBox ();
			this.userLabel = new System.Windows.Forms.Label ();
			this.userTextBox = new System.Windows.Forms.TextBox ();
			this.okButton = new System.Windows.Forms.Button ();
			this.cancelButton = new System.Windows.Forms.Button ();
			this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog ();
			this.directoryPanel.SuspendLayout ();
			this.ftpPanel.SuspendLayout ();
			this.SuspendLayout ();
			// 
			// typeComboBox
			// 
			this.typeComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
							| System.Windows.Forms.AnchorStyles.Right)));
			this.typeComboBox.FormattingEnabled = true;
			this.typeComboBox.Items.AddRange (new object[] {
            "Harddrive",
            "FTP"});
			this.typeComboBox.Location = new System.Drawing.Point (67, 9);
			this.typeComboBox.Name = "typeComboBox";
			this.typeComboBox.Size = new System.Drawing.Size (200, 21);
			this.typeComboBox.TabIndex = 0;
			this.typeComboBox.SelectedIndexChanged += new System.EventHandler (this.TypeComboBox_SelectedIndexChanged);
			// 
			// typeLabel
			// 
			this.typeLabel.AutoSize = true;
			this.typeLabel.Location = new System.Drawing.Point (15, 12);
			this.typeLabel.Name = "typeLabel";
			this.typeLabel.Size = new System.Drawing.Size (27, 13);
			this.typeLabel.TabIndex = 1;
			this.typeLabel.Text = "Type";
			// 
			// directoryTextBox
			// 
			this.directoryTextBox.Location = new System.Drawing.Point (55, 19);
			this.directoryTextBox.Name = "directoryTextBox";
			this.directoryTextBox.Size = new System.Drawing.Size (200, 20);
			this.directoryTextBox.TabIndex = 3;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point (12, 58);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size (0, 0);
			this.label2.TabIndex = 4;
			// 
			// directoryPanel
			// 
			this.directoryPanel.Controls.Add (this.chooseDirectoryButton);
			this.directoryPanel.Controls.Add (this.label3);
			this.directoryPanel.Controls.Add (this.directoryTextBox);
			this.directoryPanel.Location = new System.Drawing.Point (12, 36);
			this.directoryPanel.Name = "directoryPanel";
			this.directoryPanel.Size = new System.Drawing.Size (304, 56);
			this.directoryPanel.TabIndex = 5;
			// 
			// chooseDirectoryButton
			// 
			this.chooseDirectoryButton.Location = new System.Drawing.Point (261, 19);
			this.chooseDirectoryButton.Name = "chooseDirectoryButton";
			this.chooseDirectoryButton.Size = new System.Drawing.Size (28, 20);
			this.chooseDirectoryButton.TabIndex = 6;
			this.chooseDirectoryButton.Text = "...";
			this.chooseDirectoryButton.Click += new System.EventHandler (this.ChooseDirectoryButton_Click);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point (3, 22);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size (45, 13);
			this.label3.TabIndex = 6;
			this.label3.Text = "Directory";
			// 
			// ftpPanel
			// 
			this.ftpPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.ftpPanel.Controls.Add (this.portLabel);
			this.ftpPanel.Controls.Add (this.portTextBox);
			this.ftpPanel.Controls.Add (this.serverLabel);
			this.ftpPanel.Controls.Add (this.serverTextBox);
			this.ftpPanel.Controls.Add (this.remoteDirectoryLabel);
			this.ftpPanel.Controls.Add (this.remoteDirectoryTextBox);
			this.ftpPanel.Controls.Add (this.passwordLabel);
			this.ftpPanel.Controls.Add (this.passwordTextBox);
			this.ftpPanel.Controls.Add (this.userLabel);
			this.ftpPanel.Controls.Add (this.userTextBox);
			this.ftpPanel.Location = new System.Drawing.Point (12, 36);
			this.ftpPanel.Name = "ftpPanel";
			this.ftpPanel.Size = new System.Drawing.Size (304, 150);
			this.ftpPanel.TabIndex = 6;
			this.ftpPanel.Visible = false;
			// 
			// portLabel
			// 
			this.portLabel.AutoSize = true;
			this.portLabel.Location = new System.Drawing.Point (3, 41);
			this.portLabel.Name = "portLabel";
			this.portLabel.Size = new System.Drawing.Size (22, 13);
			this.portLabel.TabIndex = 9;
			this.portLabel.Text = "Port";
			// 
			// portTextBox
			// 
			this.portTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.portTextBox.Location = new System.Drawing.Point (61, 38);
			this.portTextBox.Name = "portTextBox";
			this.portTextBox.Size = new System.Drawing.Size (228, 20);
			this.portTextBox.TabIndex = 2;
			// 
			// serverLabel
			// 
			this.serverLabel.AutoSize = true;
			this.serverLabel.Location = new System.Drawing.Point (3, 15);
			this.serverLabel.Name = "serverLabel";
			this.serverLabel.Size = new System.Drawing.Size (34, 13);
			this.serverLabel.TabIndex = 7;
			this.serverLabel.Text = "Server";
			// 
			// serverTextBox
			// 
			this.serverTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.serverTextBox.Location = new System.Drawing.Point (61, 12);
			this.serverTextBox.Name = "serverTextBox";
			this.serverTextBox.Size = new System.Drawing.Size (228, 20);
			this.serverTextBox.TabIndex = 1;
			// 
			// remoteDirectoryLabel
			// 
			this.remoteDirectoryLabel.AutoSize = true;
			this.remoteDirectoryLabel.Location = new System.Drawing.Point (3, 119);
			this.remoteDirectoryLabel.Name = "remoteDirectoryLabel";
			this.remoteDirectoryLabel.Size = new System.Drawing.Size (45, 13);
			this.remoteDirectoryLabel.TabIndex = 5;
			this.remoteDirectoryLabel.Text = "Directory";
			// 
			// remoteDirectoryTextBox
			// 
			this.remoteDirectoryTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.remoteDirectoryTextBox.Location = new System.Drawing.Point (61, 116);
			this.remoteDirectoryTextBox.Name = "remoteDirectoryTextBox";
			this.remoteDirectoryTextBox.Size = new System.Drawing.Size (228, 20);
			this.remoteDirectoryTextBox.TabIndex = 5;
			// 
			// passwordLabel
			// 
			this.passwordLabel.AutoSize = true;
			this.passwordLabel.Location = new System.Drawing.Point (3, 93);
			this.passwordLabel.Name = "passwordLabel";
			this.passwordLabel.Size = new System.Drawing.Size (49, 13);
			this.passwordLabel.TabIndex = 3;
			this.passwordLabel.Text = "Password";
			// 
			// passwordTextBox
			// 
			this.passwordTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.passwordTextBox.Location = new System.Drawing.Point (61, 90);
			this.passwordTextBox.Name = "passwordTextBox";
			this.passwordTextBox.PasswordChar = '*';
			this.passwordTextBox.Size = new System.Drawing.Size (228, 20);
			this.passwordTextBox.TabIndex = 4;			
			// 
			// userLabel
			// 
			this.userLabel.AutoSize = true;
			this.userLabel.Location = new System.Drawing.Point (3, 67);
			this.userLabel.Name = "userLabel";
			this.userLabel.Size = new System.Drawing.Size (25, 13);
			this.userLabel.TabIndex = 1;
			this.userLabel.Text = "User";
			// 
			// userTextBox
			// 
			this.userTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.userTextBox.Location = new System.Drawing.Point (61, 64);
			this.userTextBox.Name = "userTextBox";
			this.userTextBox.Size = new System.Drawing.Size (228, 20);
			this.userTextBox.TabIndex = 3;
			// 
			// okButton
			// 
			this.okButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.okButton.Location = new System.Drawing.Point (160, 193);
			this.okButton.Name = "okButton";
			this.okButton.Size = new System.Drawing.Size (75, 23);
			this.okButton.TabIndex = 100;
			this.okButton.Text = "&Ok";
			this.okButton.Click += new System.EventHandler (this.OkButton_Click);
			// 
			// cancelButton
			// 
			this.cancelButton.Location = new System.Drawing.Point (241, 193);
			this.cancelButton.Name = "cancelButton";
			this.cancelButton.Size = new System.Drawing.Size (75, 23);
			this.cancelButton.TabIndex = 101;
			this.cancelButton.Text = "&Cancel";
			this.cancelButton.Click += new System.EventHandler (this.CancelButton_Click);
			// 
			// ConfigurationForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF (6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size (325, 224);
			this.Controls.Add (this.cancelButton);
			this.Controls.Add (this.okButton);
			this.Controls.Add (this.ftpPanel);
			this.Controls.Add (this.directoryPanel);
			this.Controls.Add (this.label2);
			this.Controls.Add (this.typeLabel);
			this.Controls.Add (this.typeComboBox);
			this.Name = "ConfigurationForm";
			this.Text = "Location";
			this.directoryPanel.ResumeLayout (false);
			this.directoryPanel.PerformLayout ();
			this.ftpPanel.ResumeLayout (false);
			this.ftpPanel.PerformLayout ();
			this.ResumeLayout (false);
			this.PerformLayout ();

		}

		#endregion

		private System.Windows.Forms.ComboBox typeComboBox;
		private System.Windows.Forms.Label typeLabel;
		private System.Windows.Forms.TextBox directoryTextBox;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Panel directoryPanel;
		private System.Windows.Forms.Button chooseDirectoryButton;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Panel ftpPanel;
		private System.Windows.Forms.TextBox userTextBox;
		private System.Windows.Forms.Label userLabel;
		private System.Windows.Forms.Label passwordLabel;
		private System.Windows.Forms.TextBox passwordTextBox;
		private System.Windows.Forms.Label remoteDirectoryLabel;
		private System.Windows.Forms.TextBox remoteDirectoryTextBox;
		private System.Windows.Forms.Label portLabel;
		private System.Windows.Forms.TextBox portTextBox;
		private System.Windows.Forms.Label serverLabel;
		private System.Windows.Forms.TextBox serverTextBox;
		private System.Windows.Forms.Button okButton;
		private System.Windows.Forms.Button cancelButton;
		private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
	}
}