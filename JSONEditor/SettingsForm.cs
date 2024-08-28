namespace JSONEditor {
	public partial class SettingsForm : Form {
		public SettingsForm(Form1 p) {
			InitializeComponent();
			parent = p;
			helpForm = new(p);
		}
		HelpForm helpForm;
		Form1 parent;
		private void SettingsForm_Load(object sender, EventArgs e) {
			ObjFormatBox.Text = parent.saver.GetValue("objFormat", "{{{0}}}");
			ArrayFormatBox.Text = parent.saver.GetValue("arrayFormat", "[{0}]");
		}

		private void SettingsForm_HelpButtonClicked(object sender, System.ComponentModel.CancelEventArgs e) {
			if (!helpForm.Visible)
				helpForm.Show();
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
	}
}
