using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JSONEditor {
	partial class AboutBox : Form {
		public AboutBox() {
			InitializeComponent();
			this.labelVersion.Text = string.Format("Version {0}", AssemblyVersion);
		}

		#region Assembly Attribute Accessors

		public string AssemblyVersion {
			get {
				return Assembly.GetExecutingAssembly().GetName().Version.ToString();
			}
		}
		#endregion

		private void AboutBox_Load(object sender, EventArgs e) {

		}
	}
}
