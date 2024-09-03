namespace JSONEditor {
	partial class SettingsForm {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsForm));
			tabControl1 = new TabControl();
			StylePage = new TabPage();
			ObjArrayStyleGroupBox = new GroupBox();
			label2 = new Label();
			ArrayFormatBox = new TextBox();
			ObjFormatBox = new TextBox();
			label1 = new Label();
			MiscPage = new TabPage();
			CountTotalSubnodesCheck = new CheckBox();
			helpProvider = new HelpProvider();
			tabControl1.SuspendLayout();
			StylePage.SuspendLayout();
			ObjArrayStyleGroupBox.SuspendLayout();
			MiscPage.SuspendLayout();
			SuspendLayout();
			// 
			// tabControl1
			// 
			tabControl1.Controls.Add(StylePage);
			tabControl1.Controls.Add(MiscPage);
			tabControl1.Dock = DockStyle.Fill;
			tabControl1.Location = new Point(0, 0);
			tabControl1.Name = "tabControl1";
			tabControl1.SelectedIndex = 0;
			tabControl1.Size = new Size(412, 118);
			tabControl1.TabIndex = 0;
			// 
			// StylePage
			// 
			StylePage.Controls.Add(ObjArrayStyleGroupBox);
			StylePage.Location = new Point(4, 24);
			StylePage.Name = "StylePage";
			StylePage.Padding = new Padding(3);
			StylePage.Size = new Size(404, 90);
			StylePage.TabIndex = 0;
			StylePage.Text = "Style";
			StylePage.UseVisualStyleBackColor = true;
			// 
			// ObjArrayStyleGroupBox
			// 
			ObjArrayStyleGroupBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
			ObjArrayStyleGroupBox.Controls.Add(label2);
			ObjArrayStyleGroupBox.Controls.Add(ArrayFormatBox);
			ObjArrayStyleGroupBox.Controls.Add(ObjFormatBox);
			ObjArrayStyleGroupBox.Controls.Add(label1);
			ObjArrayStyleGroupBox.Location = new Point(8, 6);
			ObjArrayStyleGroupBox.Name = "ObjArrayStyleGroupBox";
			ObjArrayStyleGroupBox.Size = new Size(388, 76);
			ObjArrayStyleGroupBox.TabIndex = 0;
			ObjArrayStyleGroupBox.TabStop = false;
			ObjArrayStyleGroupBox.Text = "Objects && Arrays";
			ObjArrayStyleGroupBox.UseCompatibleTextRendering = true;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(6, 48);
			label2.Name = "label2";
			label2.Size = new Size(98, 15);
			label2.TabIndex = 3;
			label2.Text = "Array formatting:";
			// 
			// ArrayFormatBox
			// 
			ArrayFormatBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
			ArrayFormatBox.Location = new Point(117, 45);
			ArrayFormatBox.Name = "ArrayFormatBox";
			ArrayFormatBox.Size = new Size(265, 23);
			ArrayFormatBox.TabIndex = 2;
			ArrayFormatBox.Text = "[{0}]";
			ArrayFormatBox.TextChanged += ArrayFormatBox_TextChanged;
			// 
			// ObjFormatBox
			// 
			ObjFormatBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
			ObjFormatBox.Location = new Point(117, 16);
			ObjFormatBox.Name = "ObjFormatBox";
			ObjFormatBox.Size = new Size(265, 23);
			ObjFormatBox.TabIndex = 1;
			ObjFormatBox.Text = "{{0}}";
			ObjFormatBox.TextChanged += ObjFormatBox_TextChanged;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(6, 19);
			label1.Name = "label1";
			label1.Size = new Size(105, 15);
			label1.TabIndex = 0;
			label1.Text = "Object formatting:";
			// 
			// MiscPage
			// 
			MiscPage.Controls.Add(CountTotalSubnodesCheck);
			MiscPage.Location = new Point(4, 24);
			MiscPage.Name = "MiscPage";
			MiscPage.Size = new Size(404, 103);
			MiscPage.TabIndex = 1;
			MiscPage.Text = "Misc";
			MiscPage.UseVisualStyleBackColor = true;
			// 
			// CountTotalSubnodesCheck
			// 
			CountTotalSubnodesCheck.AutoSize = true;
			CountTotalSubnodesCheck.Location = new Point(8, 3);
			CountTotalSubnodesCheck.Name = "CountTotalSubnodesCheck";
			CountTotalSubnodesCheck.Size = new Size(239, 19);
			CountTotalSubnodesCheck.TabIndex = 0;
			CountTotalSubnodesCheck.Text = "Count total subnodes for selected nodes";
			CountTotalSubnodesCheck.UseVisualStyleBackColor = true;
			CountTotalSubnodesCheck.CheckedChanged += CountTotalSubnodesCheck_CheckedChanged;
			// 
			// SettingsForm
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(412, 118);
			Controls.Add(tabControl1);
			HelpButton = true;
			Icon = (Icon)resources.GetObject("$this.Icon");
			MaximizeBox = false;
			MinimizeBox = false;
			Name = "SettingsForm";
			Text = "Javascript Object Tree | Settings";
			FormClosing += SettingsForm_FormClosing;
			Load += SettingsForm_Load;
			tabControl1.ResumeLayout(false);
			StylePage.ResumeLayout(false);
			ObjArrayStyleGroupBox.ResumeLayout(false);
			ObjArrayStyleGroupBox.PerformLayout();
			MiscPage.ResumeLayout(false);
			MiscPage.PerformLayout();
			ResumeLayout(false);
		}

		#endregion

		private TabControl tabControl1;
		private TabPage StylePage;
		private GroupBox ObjArrayStyleGroupBox;
		private TextBox ArrayFormatBox;
		private TextBox ObjFormatBox;
		private Label label1;
		private Label label2;
		private HelpProvider helpProvider;
		private TabPage MiscPage;
		private CheckBox CountTotalSubnodesCheck;
	}
}