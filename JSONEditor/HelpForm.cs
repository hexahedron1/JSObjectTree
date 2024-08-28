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
			{ "About", @$"This program is designed for editing JSON files in a tree format.
Made by hexahedron1 with C# using .NET 8.0
Version {parent.version}" },
			{ "How to use", @"To open a file, click on the File menu, then choose Open.
If you want to create a new file, choose the New option in the same menu.

JSON tokens are represented as nodes, and each token type has its own node:
	Property: contains a single value, object or array and acts as an identifier for it.
	Value: a primitive value that can be either a string (eg. ""hello world""), number (eg. 324 or 5.452) or boolean (eg. true).
	Array: similar to a property, but can contain multiple values. Cannot be renamed.
	Object: A composite value that has multiple properties inside. Cannot be renamed.
	Root: The highest node on the hiearchy, it cannot be modified or deleted.

To rename a node, select it and click again.
To add a node, select the desired parent node and click the Add Node button.
To remove a node, select the desired node and click the Remove node button.

Copy and paste will be implemented in future updates." },
			{ "Object && array formatting", @"You can specify a custom format that will be used for labels of objects and arrays.
To use the amount of the token's children, use {0}.
To use curly braces, simply double them like this: {{ }}.
For example, to display the length of an array with 4 elements in square brackets, use this:
[{0}]
This will be formatted as [4]." },
			{ "Settings", @"Using the settings window you can change the program's parameters for your own liking.
Settings are automatically saved and will be applied the next time the program gets started." },
			{ "Changelog", $@"Version: {parent.version}
- Initial release" }
				};
		}
	}
}
