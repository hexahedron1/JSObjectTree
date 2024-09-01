using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JSONEditor {
	partial class AboutBox : Form {
		public AboutBox(Form1 p) {
			InitializeComponent();
			labelVersion.Text = string.Format("Version {0}", AssemblyVersion);
			parent = p;
		}
		Form1 parent;
		#region Assembly Attribute Accessors

		public string AssemblyVersion {
			get {
				return Assembly.GetExecutingAssembly().GetName().Version.ToString();
			}
		}
		#endregion

		private void AboutBox_Load(object sender, EventArgs e) {
		}

		private void GithubLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
			string link = "https://github.com/hexahedron1/JSObjectTree";
			try {
				Process.Start(link);
			} catch {
				var result = MessageBox.Show("Unable to open the link. Do you want to copy it to the clipboard?", parent.title, MessageBoxButtons.YesNo, MessageBoxIcon.Error);
				if (result == DialogResult.Yes) {
					Clipboard.SetText(link);
				}
			}
		}
	}
}
