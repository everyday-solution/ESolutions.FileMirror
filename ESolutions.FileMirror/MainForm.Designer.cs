using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ESolutions.FileForwarder
{
	partial class MainForm
	{
		private System.Windows.Forms.NotifyIcon notifyIcon1;
		private System.Windows.Forms.ContextMenu cMenuIcon;
		private System.Windows.Forms.MenuItem menuItem1;
		private System.Windows.Forms.GroupBox startStopGroupBox;
		private System.Windows.Forms.MenuItem menuItem2;
		private System.Windows.Forms.MenuItem menuItem4;
		private System.ComponentModel.IContainer components;
		private System.Windows.Forms.GroupBox foldersGroupBox;
		private System.Windows.Forms.Button sourceButton;
		private System.Windows.Forms.Button destinationButton;
		private System.Windows.Forms.TextBox logListView;
		private System.Windows.Forms.Label onOffLabel;
		private System.Windows.Forms.Label destinationLabel;
		private System.Windows.Forms.Label sourceLabel;
		private System.Windows.Forms.Button onOffButton;
		private ESolutions.FileForwarder.FileForwarder fF;
		private FileLocation destinationLocation;
		private FolderBrowserDialog folderBrowserDialog;
		private bool onOff = false;

		#region MainForm
		public MainForm()
		{
			InitializeComponent();
			logListView.Text = "\r\n\r\n\r\nThis text box reads from bottom to top, so you don't need to scroll down";
		}
		#endregion

		#region Dispose
		protected override void Dispose(bool disposing)
		{
			if (disposing)
			{
				if (components != null)
				{
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		#endregion

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.startStopGroupBox = new System.Windows.Forms.GroupBox();
			this.onOffLabel = new System.Windows.Forms.Label();
			this.onOffButton = new System.Windows.Forms.Button();
			this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
			this.cMenuIcon = new System.Windows.Forms.ContextMenu();
			this.menuItem2 = new System.Windows.Forms.MenuItem();
			this.menuItem4 = new System.Windows.Forms.MenuItem();
			this.menuItem1 = new System.Windows.Forms.MenuItem();
			this.foldersGroupBox = new System.Windows.Forms.GroupBox();
			this.destinationLabel = new System.Windows.Forms.Label();
			this.sourceLabel = new System.Windows.Forms.Label();
			this.sourceButton = new System.Windows.Forms.Button();
			this.destinationButton = new System.Windows.Forms.Button();
			this.logListView = new System.Windows.Forms.TextBox();
			this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
			this.startStopGroupBox.SuspendLayout();
			this.foldersGroupBox.SuspendLayout();
			this.SuspendLayout();
			// 
			// startStopGroupBox
			// 
			this.startStopGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
			| System.Windows.Forms.AnchorStyles.Right)));
			this.startStopGroupBox.Controls.Add(this.onOffLabel);
			this.startStopGroupBox.Controls.Add(this.onOffButton);
			this.startStopGroupBox.Location = new System.Drawing.Point(16, 166);
			this.startStopGroupBox.Name = "startStopGroupBox";
			this.startStopGroupBox.Size = new System.Drawing.Size(966, 89);
			this.startStopGroupBox.TabIndex = 8;
			this.startStopGroupBox.TabStop = false;
			this.startStopGroupBox.Text = "Start / Stop";
			// 
			// onOffLabel
			// 
			this.onOffLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
			| System.Windows.Forms.AnchorStyles.Right)));
			this.onOffLabel.Location = new System.Drawing.Point(192, 31);
			this.onOffLabel.Name = "onOffLabel";
			this.onOffLabel.Size = new System.Drawing.Size(758, 43);
			this.onOffLabel.TabIndex = 1;
			this.onOffLabel.Text = "Click to start the DirectoryMirror";
			this.onOffLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// onOffButton
			// 
			this.onOffButton.Location = new System.Drawing.Point(16, 31);
			this.onOffButton.Name = "onOffButton";
			this.onOffButton.Size = new System.Drawing.Size(160, 43);
			this.onOffButton.TabIndex = 0;
			this.onOffButton.Text = "Start";
			this.onOffButton.Click += new System.EventHandler(this.OnOffButton_Click);
			// 
			// notifyIcon1
			// 
			this.notifyIcon1.ContextMenu = this.cMenuIcon;
			this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
			this.notifyIcon1.Text = "FileMirror";
			this.notifyIcon1.Visible = true;
			this.notifyIcon1.Click += new System.EventHandler(this.NotifyIcon1_Click);
			this.notifyIcon1.DoubleClick += new System.EventHandler(this.NotifyIcon1_DoubleClick);
			// 
			// cMenuIcon
			// 
			this.cMenuIcon.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
			this.menuItem2,
			this.menuItem4,
			this.menuItem1});
			// 
			// menuItem2
			// 
			this.menuItem2.Index = 0;
			this.menuItem2.Text = "Source Folder";
			this.menuItem2.Click += new System.EventHandler(this.ViewSource);
			// 
			// menuItem4
			// 
			this.menuItem4.Index = 1;
			this.menuItem4.Text = "Mirror Folder";
			this.menuItem4.Click += new System.EventHandler(this.ViewDestination);
			// 
			// menuItem1
			// 
			this.menuItem1.Index = 2;
			this.menuItem1.Text = "Quit";
			this.menuItem1.Click += new System.EventHandler(this.Quit);
			// 
			// foldersGroupBox
			// 
			this.foldersGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
			| System.Windows.Forms.AnchorStyles.Right)));
			this.foldersGroupBox.Controls.Add(this.destinationLabel);
			this.foldersGroupBox.Controls.Add(this.sourceLabel);
			this.foldersGroupBox.Controls.Add(this.sourceButton);
			this.foldersGroupBox.Controls.Add(this.destinationButton);
			this.foldersGroupBox.Location = new System.Drawing.Point(16, 15);
			this.foldersGroupBox.Name = "foldersGroupBox";
			this.foldersGroupBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.foldersGroupBox.Size = new System.Drawing.Size(966, 135);
			this.foldersGroupBox.TabIndex = 8;
			this.foldersGroupBox.TabStop = false;
			this.foldersGroupBox.Text = "Folders";
			// 
			// destinationLabel
			// 
			this.destinationLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
			| System.Windows.Forms.AnchorStyles.Right)));
			this.destinationLabel.BackColor = System.Drawing.Color.Silver;
			this.destinationLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.destinationLabel.ForeColor = System.Drawing.Color.Black;
			this.destinationLabel.Location = new System.Drawing.Point(16, 89);
			this.destinationLabel.Name = "destinationLabel";
			this.destinationLabel.Size = new System.Drawing.Size(874, 29);
			this.destinationLabel.TabIndex = 6;
			// 
			// sourceLabel
			// 
			this.sourceLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
			| System.Windows.Forms.AnchorStyles.Right)));
			this.sourceLabel.BackColor = System.Drawing.Color.Silver;
			this.sourceLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.sourceLabel.ForeColor = System.Drawing.Color.Black;
			this.sourceLabel.Location = new System.Drawing.Point(16, 30);
			this.sourceLabel.Name = "sourceLabel";
			this.sourceLabel.Size = new System.Drawing.Size(874, 29);
			this.sourceLabel.TabIndex = 5;
			// 
			// sourceButton
			// 
			this.sourceButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.sourceButton.Location = new System.Drawing.Point(902, 30);
			this.sourceButton.Name = "sourceButton";
			this.sourceButton.Size = new System.Drawing.Size(52, 29);
			this.sourceButton.TabIndex = 2;
			this.sourceButton.Text = "...";
			this.sourceButton.Click += new System.EventHandler(this.SourceButton_Click);
			// 
			// destinationButton
			// 
			this.destinationButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
			| System.Windows.Forms.AnchorStyles.Right)));
			this.destinationButton.Location = new System.Drawing.Point(902, 89);
			this.destinationButton.Name = "destinationButton";
			this.destinationButton.Size = new System.Drawing.Size(52, 29);
			this.destinationButton.TabIndex = 4;
			this.destinationButton.Text = "...";
			this.destinationButton.Click += new System.EventHandler(this.DestinationButton_Click);
			// 
			// logListView
			// 
			this.logListView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
			| System.Windows.Forms.AnchorStyles.Left)
			| System.Windows.Forms.AnchorStyles.Right)));
			this.logListView.Location = new System.Drawing.Point(16, 275);
			this.logListView.Multiline = true;
			this.logListView.Name = "logListView";
			this.logListView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.logListView.Size = new System.Drawing.Size(966, 272);
			this.logListView.TabIndex = 9;
			// 
			// folderBrowserDialog
			// 
			this.folderBrowserDialog.SelectedPath = "folderBrowserDialog1";
			// 
			// MainForm
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(10, 24);
			this.ClientSize = new System.Drawing.Size(1014, 575);
			this.Controls.Add(this.logListView);
			this.Controls.Add(this.foldersGroupBox);
			this.Controls.Add(this.startStopGroupBox);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.MinimumSize = new System.Drawing.Size(1040, 561);
			this.Name = "MainForm";
			this.ShowInTaskbar = false;
			this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
			this.Text = "FileForwarder";
			this.startStopGroupBox.ResumeLayout(false);
			this.foldersGroupBox.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}
		#endregion
	}
}
