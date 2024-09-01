namespace JSONEditor {
	partial class AboutBox {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose(bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			tableLayoutPanel = new TableLayoutPanel();
			logoPictureBox = new PictureBox();
			labelProductName = new Label();
			labelVersion = new Label();
			labelCompanyName = new Label();
			textBoxDescription = new TextBox();
			panel1 = new Panel();
			GithubLink = new LinkLabel();
			okButton = new Button();
			tableLayoutPanel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)logoPictureBox).BeginInit();
			panel1.SuspendLayout();
			SuspendLayout();
			// 
			// tableLayoutPanel
			// 
			tableLayoutPanel.ColumnCount = 2;
			tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 32.64887F));
			tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 67.35113F));
			tableLayoutPanel.Controls.Add(logoPictureBox, 0, 0);
			tableLayoutPanel.Controls.Add(labelProductName, 1, 0);
			tableLayoutPanel.Controls.Add(labelVersion, 1, 1);
			tableLayoutPanel.Controls.Add(labelCompanyName, 1, 2);
			tableLayoutPanel.Controls.Add(textBoxDescription, 1, 3);
			tableLayoutPanel.Controls.Add(panel1, 1, 4);
			tableLayoutPanel.Dock = DockStyle.Fill;
			tableLayoutPanel.Location = new Point(10, 10);
			tableLayoutPanel.Margin = new Padding(4, 3, 4, 3);
			tableLayoutPanel.Name = "tableLayoutPanel";
			tableLayoutPanel.RowCount = 5;
			tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 11.1111107F));
			tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 11.1111107F));
			tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 11.1111107F));
			tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 55.5555573F));
			tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 11.1111107F));
			tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
			tableLayoutPanel.Size = new Size(487, 307);
			tableLayoutPanel.TabIndex = 0;
			// 
			// logoPictureBox
			// 
			logoPictureBox.BackgroundImageLayout = ImageLayout.Center;
			logoPictureBox.Dock = DockStyle.Fill;
			logoPictureBox.Image = Properties.Resources.QIP_Shot___Screen_29_08_24;
			logoPictureBox.Location = new Point(4, 3);
			logoPictureBox.Margin = new Padding(4, 3, 4, 3);
			logoPictureBox.Name = "logoPictureBox";
			tableLayoutPanel.SetRowSpan(logoPictureBox, 5);
			logoPictureBox.Size = new Size(150, 301);
			logoPictureBox.SizeMode = PictureBoxSizeMode.CenterImage;
			logoPictureBox.TabIndex = 12;
			logoPictureBox.TabStop = false;
			// 
			// labelProductName
			// 
			labelProductName.Dock = DockStyle.Fill;
			labelProductName.Location = new Point(165, 0);
			labelProductName.Margin = new Padding(7, 0, 4, 0);
			labelProductName.MaximumSize = new Size(0, 20);
			labelProductName.Name = "labelProductName";
			labelProductName.Size = new Size(318, 20);
			labelProductName.TabIndex = 19;
			labelProductName.Text = "Javascript Object Tree";
			labelProductName.TextAlign = ContentAlignment.MiddleLeft;
			// 
			// labelVersion
			// 
			labelVersion.Dock = DockStyle.Fill;
			labelVersion.Location = new Point(165, 34);
			labelVersion.Margin = new Padding(7, 0, 4, 0);
			labelVersion.MaximumSize = new Size(0, 20);
			labelVersion.Name = "labelVersion";
			labelVersion.Size = new Size(318, 20);
			labelVersion.TabIndex = 0;
			labelVersion.Text = "Version";
			labelVersion.TextAlign = ContentAlignment.MiddleLeft;
			// 
			// labelCompanyName
			// 
			labelCompanyName.Dock = DockStyle.Fill;
			labelCompanyName.Location = new Point(165, 68);
			labelCompanyName.Margin = new Padding(7, 0, 4, 0);
			labelCompanyName.MaximumSize = new Size(0, 20);
			labelCompanyName.Name = "labelCompanyName";
			labelCompanyName.Size = new Size(318, 20);
			labelCompanyName.TabIndex = 22;
			labelCompanyName.Text = "By hexahedron1";
			labelCompanyName.TextAlign = ContentAlignment.MiddleLeft;
			// 
			// textBoxDescription
			// 
			textBoxDescription.Dock = DockStyle.Fill;
			textBoxDescription.Location = new Point(165, 105);
			textBoxDescription.Margin = new Padding(7, 3, 4, 3);
			textBoxDescription.Multiline = true;
			textBoxDescription.Name = "textBoxDescription";
			textBoxDescription.ReadOnly = true;
			textBoxDescription.ScrollBars = ScrollBars.Both;
			textBoxDescription.Size = new Size(318, 164);
			textBoxDescription.TabIndex = 23;
			textBoxDescription.TabStop = false;
			textBoxDescription.Text = "A program designed for viewing and editing JSON files in a tree format\r\nMade with .NET 8 using C#";
			// 
			// panel1
			// 
			panel1.Controls.Add(GithubLink);
			panel1.Controls.Add(okButton);
			panel1.Dock = DockStyle.Fill;
			panel1.Location = new Point(161, 275);
			panel1.Name = "panel1";
			panel1.Size = new Size(323, 29);
			panel1.TabIndex = 24;
			// 
			// GithubLink
			// 
			GithubLink.AutoSize = true;
			GithubLink.Location = new Point(4, 7);
			GithubLink.Name = "GithubLink";
			GithubLink.Size = new Size(43, 15);
			GithubLink.TabIndex = 26;
			GithubLink.TabStop = true;
			GithubLink.Text = "Github";
			GithubLink.LinkClicked += GithubLink_LinkClicked;
			// 
			// okButton
			// 
			okButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
			okButton.DialogResult = DialogResult.Cancel;
			okButton.Location = new Point(238, 3);
			okButton.Margin = new Padding(4, 3, 4, 3);
			okButton.Name = "okButton";
			okButton.Size = new Size(81, 23);
			okButton.TabIndex = 25;
			okButton.Text = "&OK";
			// 
			// AboutBox
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(507, 327);
			Controls.Add(tableLayoutPanel);
			FormBorderStyle = FormBorderStyle.FixedDialog;
			Margin = new Padding(4, 3, 4, 3);
			MaximizeBox = false;
			MinimizeBox = false;
			Name = "AboutBox";
			Padding = new Padding(10);
			ShowIcon = false;
			ShowInTaskbar = false;
			StartPosition = FormStartPosition.CenterParent;
			Text = "JS Object Tree | About";
			Load += AboutBox_Load;
			tableLayoutPanel.ResumeLayout(false);
			tableLayoutPanel.PerformLayout();
			((System.ComponentModel.ISupportInitialize)logoPictureBox).EndInit();
			panel1.ResumeLayout(false);
			panel1.PerformLayout();
			ResumeLayout(false);
		}

		#endregion

		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
		private System.Windows.Forms.PictureBox logoPictureBox;
		private System.Windows.Forms.Label labelProductName;
		private System.Windows.Forms.Label labelVersion;
		private System.Windows.Forms.Label labelCompanyName;
		private System.Windows.Forms.TextBox textBoxDescription;
		private Panel panel1;
		private LinkLabel GithubLink;
		private Button okButton;
	}
}
