namespace JSONEditor {
	public partial class SettingsForm : Form {
		public SettingsForm(Form1 p) {
			InitializeComponent();
			parent = p;
		}
		Form1 parent;
		private void SettingsForm_Load(object sender, EventArgs e) {
			ObjFormatBox.Text = parent.saver.GetValue("objFormat", "{{{0}}}");
			ArrayFormatBox.Text = parent.saver.GetValue("arrayFormat", "[{0}]");
			helpProvider.SetShowHelp(ObjFormatBox, true);
			helpProvider.SetHelpString(ObjFormatBox, @"The formatting for object nodes.
{0} will be replaced with the amount of properties of the object.
To use curly braces, put {{ and }}.");
			helpProvider.SetShowHelp(ArrayFormatBox, true);
			helpProvider.SetHelpString(ArrayFormatBox, @"The formatting for array nodes.
{0} will be replaced with the length of the array.
To use curly braces, put {{ and }}.");
			helpProvider.SetShowHelp(CountTotalSubnodesCheck, true);
			helpProvider.SetHelpString(CountTotalSubnodesCheck, @"Whether when you select a node the program will count all nodes under it.
This may theoretically cause performance issues although not tested.");
		}

		private void SettingsForm_HelpButtonClicked(object sender, System.ComponentModel.CancelEventArgs e) {

		}

		private void SettingsForm_FormClosing(object sender, FormClosingEventArgs e) {
			e.Cancel = true;
			Hide();
		}

		private void ObjFormatBox_TextChanged(object sender, EventArgs e) {
			parent.saver.SetValue("objFormat", ObjFormatBox.Text);
		}

		private void ArrayFormatBox_TextChanged(object sender, EventArgs e) {
			parent.saver.SetValue("arrayFormat", ArrayFormatBox.Text);
		}

		private void CountTotalSubnodesCheck_CheckedChanged(object sender, EventArgs e) {
			parent.saver.SetValue("countTotalSubnodes", CountTotalSubnodesCheck.Checked);
		}
	}
}
