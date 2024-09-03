using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JSONEditor {
	public partial class HelpForm : Form {
		public HelpForm(Form1 p) {
			InitializeComponent();
			parent = p;
		}
		Form1 parent;
		Dictionary<string, string> help;

		private void HelpTree_AfterSelect(object sender, TreeViewEventArgs e) {

		}

		private void HelpForm_FormClosing(object sender, FormClosingEventArgs e) {
			e.Cancel = true;
			Hide();
		}

		private void HelpTree_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e) {
			string? tag = (string?)e.Node.Tag;
			if (help.TryGetValue(tag ?? string.Empty, out var h)) {
				ContentBox.Text = h;
				TitleLabel.Text = tag;
			}
		}

		private void HelpForm_Shown(object sender, EventArgs e) {
			help = new() {
			{ "How to use", @"To open a file, click on the File menu, then choose Open.
If you want to create a new file, choose the New option in the same menu.

JSON tokens are represented as nodes, and each token type has its own node:
    Property: contains a single value, object or array and acts as an identifier for it.
    Value: a primitive value that can be either a string (eg. ""hello world""), number (eg. 324 or 5.452) or boolean (eg. true).
    Array: similar to a property, but can contain multiple values. Cannot be renamed.
    Object: A composite value that has multiple properties inside. Cannot be renamed.
    Root: The highest node on the hiearchy, it cannot be modified or deleted.

To rename a node, select it and click again.
To add a node, select the parent node and click the Add Node button.
To remove a node, select the node and click the Remove node button.
To copy a node, select it and choose the Copy option in Edit menu or press Ctrl+C
To paste nodes, select the parent node and choose the Paste option in Edit menu or press Ctrl+V
    NOTE: you can only paste objects at this time.

When you select a node, information about it will be displayed on the status bar:
  - Its type
  - Its first-order subnodes
  - Its total subnodes (if enabled)" },
			{ "Settings", @"Using the settings window you can change the program's parameters for your own liking.
Settings are automatically saved and will be applied the next time the program gets started.
To get information about a specific parameter, click the ? button and select the parameter you want to get help about." },
			{ "Changelog", $@"Version: {parent.version}
  - Added node info in status bar
  - Added an option to enable counting all subnodes of a node on select
  - Added github link in About box
  - Added error handling for when a file cannot be parsed as json
  - Help now uses spaces instead of tabs for indentation
  - Removed Settings help category" },
			{ "Settings help", @"You can view help about each setting by clicking on the help button in the settings menu and clicking on the desired setting." }
			};
		}

		private void HelpForm_Load(object sender, EventArgs e) {

		}
	}
}
