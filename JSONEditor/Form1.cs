using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using ProgletSoft.DataSaving;
using System.Diagnostics.Contracts;
using System.Globalization;
using System.IO;
using System.Reflection;

namespace JSONEditor {
	public partial class Form1 : Form {
		public Form1() {
			InitializeComponent();
			settingsForm = new(this);
			helpForm = new(this);
			aboutBox = new(this);
			version = Assembly.GetExecutingAssembly().GetName().Version?.ToString() ?? "unknown";
			exePath = new FileInfo(Assembly.GetExecutingAssembly().Location).Directory.FullName;
			saver = new(Path.Join(exePath, "settings"));
		}
		HelpForm helpForm;
		AboutBox aboutBox;
		public DataSaver saver;
		string exePath = "";
		string objFormat = "";
		string arrayFormat = "";
		bool countTotalSubnodes = false;
		public string version = "";
		private void PropViewMenuItem_Click(object sender, EventArgs e) {
			MainSplitContainer.Panel2Collapsed = false;
		}
		bool unsaved = false;
		public string title = "Javascript Object Tree";
		string file = "";
		SettingsForm settingsForm;
		private void OpenFileMenuItem_Click(object sender, EventArgs e) {
			DialogResult result;
			if (unsaved) {
				result = MessageBox.Show("Save changes?", title, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
				if (result == DialogResult.Cancel)
					return;
				else if (result == DialogResult.Yes)
					SaveFileMenuItem.PerformClick();
			}
			result = openFileDialog.ShowDialog();
			if (result == DialogResult.OK) {
				LoadFile(openFileDialog.FileName);
			}
		}
		void LoadFile(string path) {
			file = path;
			string json = File.ReadAllText(path);
			try {
				dynamic? obj = JsonConvert.DeserializeObject(json);
				Text = $"{title} | {new FileInfo(file).Name}";
				if (obj is null)
					MessageBox.Show("Oops the json is somehow null", title, MessageBoxButtons.OK, MessageBoxIcon.Error);
				else {
					Tree.Nodes.Clear();
					var root = new TreeNode("root", 0, 0) { Tag = "root" };
					Tree.Nodes.Add(root);
					foreach (JToken p in obj)
						root.Nodes.Add(MakeNode(p));
				}
				SaveFileMenuItem.Enabled = true;
				SaveAsFileMenuItem.Enabled = true;
			} catch (JsonException) {
				MessageBox.Show("Unable to parse the file as json.", title, MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
		}
		TreeNode MakeNode(JToken? token) {
			TreeNode node = new();
			if (token is JProperty prop) {
				node.Text = prop.Name;
				node.ImageIndex = 0;
				node.SelectedImageIndex = node.ImageIndex;
				node.Nodes.AddRange((from t in prop select MakeNode(t)).ToArray());
				node.Tag = "property";
			} else if (token is JValue value) {
				node.Tag = "value";
				if (value.Value is null) {
				}
				node.Text = value.Value?.ToString() ?? "null";
				node.ImageIndex = 1;
				node.SelectedImageIndex = 1;
			} else if (token is JArray array) {
				node.ImageIndex = 4;
				node.SelectedImageIndex = 4;
				node.Tag = "array";
				node.Text = string.Format(arrayFormat, array.Count);
				node.Nodes.AddRange((from t in array select MakeNode(t)).ToArray());
			} else if (token is JObject obj) {
				node.Text = string.Format(objFormat, obj.Count);
				node.Tag = "object";
				node.ImageIndex = 3;
				node.SelectedImageIndex = 3;
				foreach (var pair in obj) {
					var n = new TreeNode(pair.Key);
					n.Tag = "property";
					n.ImageIndex = 0;
					n.SelectedImageIndex = 0;
					n.Nodes.Add(MakeNode(pair.Value));
					node.Nodes.Add(n);
				}
			} else {
				node.Tag = "noEdit";
				node.Text = token?.GetType().Name ?? "Unknown type";
				node.ImageIndex = 2;
				node.SelectedImageIndex = 2;
			}
			return node;
		}
		int CountTotalChildren(TreeNode node) {
			int output = 0;
			output += node.Nodes.Count;
			if (output > 0) {
				foreach (TreeNode n in node.Nodes)
					output += CountTotalChildren(n);
			}
			return output;
		}
		private void Tree_AfterSelect(object sender, TreeViewEventArgs e) {
			if (e.Node is null) {
				AddNodeButton.Enabled = false;
				DeleteNodeButton.Enabled = false;
				CopyEditMenuItem.Enabled = false;
				PasteEditMenuItem.Enabled = false;
				NodeNameLabel.Visible = false;
				NodeChildrenLabel.Visible = false;
				NodeTotalChildrenLabel.Visible = false;
			} else {
				CopyEditMenuItem.Enabled = true;
				PasteEditMenuItem.Enabled = true;
				AddNodeButton.Enabled = (string)e.Node.Tag != "value" || ((string)e.Node.Tag == "property" && e.Node.Nodes.Count != 0);
				DeleteNodeButton.Enabled = (string)e.Node.Tag != "root";
				AddValueMenuItem.Enabled = ((string)e.Node.Tag == "property" && e.Node.Nodes.Count == 0) || (string)e.Node.Tag == "array";
				AddObjectMenuItem.Enabled = ((string)e.Node.Tag == "property" && e.Node.Nodes.Count == 0) || (string)e.Node.Tag == "array";
				AddArrayMenuItem.Enabled = ((string)e.Node.Tag == "property" && e.Node.Nodes.Count == 0) || (string)e.Node.Tag == "array";
				NodeNameLabel.Visible = true;
				switch ((string)e.Node.Tag) {
					case "object":
					case "root":
						NodeNameLabel.Text = "Selected node: Object";
						break;
					case "property":
						NodeNameLabel.Text = "Selected node: Property";
						break;
					case "value":
						NodeNameLabel.Text = "Selected node: Value";
						break;
					case "array":
						NodeNameLabel.Text = "Selected node: Array";
						break;
					default:
						NodeNameLabel.Text = "Selected node: Unknown";
						break;
				}
				if ((string)e.Node.Tag == "property" || (string)e.Node.Tag == "value") {
					NodeChildrenLabel.Visible = false;
				} else {
					NodeChildrenLabel.Visible = true;
					NodeChildrenLabel.Text = $"Subnodes: {e.Node.Nodes.Count}";				
				}
				if (countTotalSubnodes) {
					int total = CountTotalChildren(e.Node);
					NodeTotalChildrenLabel.Visible = true;
					NodeTotalChildrenLabel.Text = $"Total subnodes: {total}";
				} else
					NodeTotalChildrenLabel.Visible = false;
			}
		}

		private void Tree_AfterLabelEdit(object sender, NodeLabelEditEventArgs e) {
			if ((string?)e.Node?.Tag == "object" || (string?)e.Node?.Tag == "array" || (string?)e.Node?.Tag == "root")
				e.CancelEdit = true;
			if (!e.CancelEdit) {
				MarkUnsaved();
			}
		}
		void MarkUnsaved() {
			unsaved = true;
			if (!Text.EndsWith("*"))
				Text += " *";
		}
		private void AddNodeButton_ButtonClick(object sender, EventArgs e) {
			var node = Tree.SelectedNode;
			if ((string)node.Tag != "property" && (string)node.Tag != "array") {
				var n = new TreeNode("New node");
				n.Tag = "property";
				n.ImageIndex = 0;
				n.SelectedImageIndex = 0;
				node.Nodes.Add(n);
				if ((string)node.Tag == "object") {
					node.Text = string.Format(objFormat, node.Nodes.Count);
				}
				n.EnsureVisible();
				n.BeginEdit();
				MarkUnsaved();
			}
		}

		private void AddObjectMenuItem_Click(object sender, EventArgs e) {
			var node = Tree.SelectedNode;
			var n = new TreeNode(string.Format(objFormat, 0));
			n.Tag = "object";
			n.ImageIndex = 3;
			n.SelectedImageIndex = 3;
			node.Nodes.Add(n);
			if ((string)node.Tag == "array") {
				node.Text = string.Format(arrayFormat, node.Nodes.Count);
			}
			n.EnsureVisible();
			MarkUnsaved();
		}

		private void DeleteNodeButton_Click(object sender, EventArgs e) {
			var node = Tree.SelectedNode;
			var parent = node.Parent;
			if ((string)parent.Tag == "object") {
				parent.Text = string.Format(objFormat, node.Nodes.Count);
			}
			if ((string)parent.Tag == "array") {
				parent.Text = string.Format(arrayFormat, node.Nodes.Count);
			}
			parent.Nodes.Remove(node);
			MarkUnsaved();
		}

		private void AddValueMenuItem_Click(object sender, EventArgs e) {
			var node = Tree.SelectedNode;
			var n = new TreeNode("value");
			n.Tag = "value";
			n.ImageIndex = 1;
			n.SelectedImageIndex = 1;
			node.Nodes.Add(n);
			if ((string)node.Tag == "array") {
				node.Text = $"[{node.Nodes.Count}]";
			}
			n.EnsureVisible();
			n.BeginEdit();
			MarkUnsaved();
		}

		private void Form1_FormClosing(object sender, FormClosingEventArgs e) {
			if (unsaved) {
				var result = MessageBox.Show("Save changes?", title, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
				if (result == DialogResult.Cancel)
					e.Cancel = true;
				else if (result == DialogResult.Yes)
					SaveFileMenuItem.PerformClick();
			}
		}

		private void NewFileMenuItem_Click(object sender, EventArgs e) {
			if (unsaved) {
				var result = MessageBox.Show("Save changes?", title, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
				if (result == DialogResult.Cancel)
					return;
				else if (result == DialogResult.Yes)
					SaveFileMenuItem.PerformClick();
			}
			file = "";
			Tree.Nodes.Clear();
			var root = new TreeNode("root", 0, 0) { Tag = "root" };
			Tree.Nodes.Add(root);
			SaveFileMenuItem.Enabled = true;
			SaveAsFileMenuItem.Enabled = true;
		}

		private void AddArrayMenuItem_Click(object sender, EventArgs e) {
			var node = Tree.SelectedNode;
			var n = new TreeNode(string.Format(arrayFormat, 0));
			n.Tag = "array";
			n.ImageIndex = 4;
			n.SelectedImageIndex = 4;
			node.Nodes.Add(n);
			n.EnsureVisible();
			MarkUnsaved();
		}

		private void Tree_BeforeExpand(object sender, TreeViewCancelEventArgs e) {
			if (e.Node is null)
				return;
			foreach (TreeNode node in e.Node.Nodes) {
				foreach (TreeNode? n in node.Nodes) {
					if (n is not null && n.Text == string.Empty)
						node.Nodes.Remove(n);
				}
			}
		}
		JToken Jsonify(TreeNode node) {
			var tag = (string)node.Tag;
			if (tag == "value") {
				JValue v;
				if (bool.TryParse(node.Text, out bool bvalue))
					v = new(bvalue);
				else if (long.TryParse(node.Text, out long lvalue))
					v = new(lvalue);
				else if (double.TryParse(node.Text, new CultureInfo("en-us"), out double dvalue))
					v = new(dvalue);
				else if (string.IsNullOrEmpty(node.Text))
					v = new((string?)null);
				else
					v = new(node.Text);
				return v;
			} else if (tag == "property") {
				if (node.Nodes.Count == 0)
					return new JProperty(node.Text, (object?)null);
				else
					return new JProperty(node.Text, Jsonify(node.Nodes[0]));
			} else if (tag == "array") {
				JArray array = new();
				foreach (TreeNode n in node.Nodes)
					array.Add(Jsonify(n));
				return array;
			}
			JObject obj = new();
			foreach (TreeNode n in node.Nodes)
				obj.Add(Jsonify(n));
			return obj;
		}
		private void SaveFileMenuItem_Click(object sender, EventArgs e) {
			if (string.IsNullOrEmpty(file)) {
				SaveAsFileMenuItem.PerformClick();
			} else {
				JObject obj = (JObject)Jsonify(Tree.Nodes[0]);
				string json = obj.ToString();
				File.WriteAllText(file, json);
				unsaved = false;
				Text = $"{title} | {new FileInfo(file).Name}";
			}
		}

		private void SaveAsFileMenuItem_Click(object sender, EventArgs e) {
			var result = saveFileDialog.ShowDialog();
			if (result == DialogResult.OK) {
				file = saveFileDialog.FileName;
				SaveFileMenuItem.PerformClick();
			}
		}

		private void PrefEditMenuItem_Click(object sender, EventArgs e) {
			if (!settingsForm.Visible)
				settingsForm.Show();
		}

		private void Form1_Load(object sender, EventArgs e) {
			objFormat = saver.GetValue("objFormat", "{{{0}}}");
			arrayFormat = saver.GetValue("arrayFormat", "[{0}]");
			countTotalSubnodes = saver.GetValue("countTotalSubnodes", false);
			string[] args = (from x in Environment.GetCommandLineArgs() where x.EndsWith(".json") select x).ToArray();
			if (args.Length > 0 && File.Exists(args[0]))
				LoadFile(args[0]);
		}

		private void Tree_KeyDown(object sender, KeyEventArgs e) {
			if (e.KeyCode == Keys.N && e.Control)
				NewFileMenuItem.PerformClick();
			else if (e.KeyCode == Keys.O && e.Control)
				OpenFileMenuItem.PerformClick();
			else if (e.KeyCode == Keys.S && e.Control) {
				if (e.Shift && SaveAsFileMenuItem.Enabled)
					SaveAsFileMenuItem.PerformClick();
				else if (SaveFileMenuItem.Enabled)
					SaveFileMenuItem.PerformClick();
			} else if (e.KeyCode == Keys.C && e.Control)
				CopyEditMenuItem.PerformClick();
			else if (e.KeyCode == Keys.V && e.Control) {
				if (e.Shift)
					LoadFromClipboardFileMenuItem.PerformClick();
				else
					PasteEditMenuItem.PerformClick();
			}
			e.SuppressKeyPress = true;
		}

		private void HelpViewMenuItem_Click(object sender, EventArgs e) {
			if (!helpForm.Visible)
				helpForm.Show();
		}

		private void AboutHelpMenuItem_Click(object sender, EventArgs e) {
			if (!aboutBox.Visible)
				aboutBox.ShowDialog();
		}

		private void SettingsViewMenuItem_Click(object sender, EventArgs e) {
			if (!settingsForm.Visible)
				settingsForm.Show();
		}

		private void CopyEditMenuItem_Click(object sender, EventArgs e) {
			var node = Tree.SelectedNode;
			if (node is not null) {
				string json = Jsonify(node).ToString();
				Clipboard.SetText(json);
			}
		}

		private void PasteEditMenuItem_Click(object sender, EventArgs e) {
			var node = Tree.SelectedNode;
			if (node is null)
				return;
			var tag = Tree.SelectedNode.Tag.ToString();
			if (tag is null)
				return;
			try {
				string json = Clipboard.GetText();
				try {
					JToken token = JToken.Parse(json);
					if (token is JObject obj) {
						if ((tag == "property" && node.Nodes.Count == 0) || tag == "array") {
							TreeNode newNode = MakeNode(obj);
							node.Nodes.Add(newNode);
							return;
						} else {
							MessageBox.Show("Unable to paste an object into this node", title, MessageBoxButtons.OK, MessageBoxIcon.Warning);
						}
					} else if (token is JProperty prop) {
						if (tag == "root" || tag == "object") {
							TreeNode newNode = MakeNode(prop);
							node.Nodes.Add(newNode);
							return;
						} else {
							MessageBox.Show("Unable to paste a property into this node", title, MessageBoxButtons.OK, MessageBoxIcon.Warning);
						}
					} else if (token is JArray arr) {
						if ((tag == "property" && node.Nodes.Count == 0) || tag == "array") {
							TreeNode newNode = MakeNode(arr);
							node.Nodes.Add(newNode);
							return;
						} else {
							MessageBox.Show("Unable to paste an array into this node", title, MessageBoxButtons.OK, MessageBoxIcon.Warning);
						}
					} else if (token is JValue val) {
						if ((tag == "property" && node.Nodes.Count == 0) || tag == "array") {
							TreeNode newNode = MakeNode(val);
							node.Nodes.Add(newNode);
							return;
						} else {
							MessageBox.Show("Unable to paste a value into this node", title, MessageBoxButtons.OK, MessageBoxIcon.Warning);
						}
					}
				} catch {
					MessageBox.Show("Your clipboard does not contain valid json", title, MessageBoxButtons.OK, MessageBoxIcon.Warning);
				}
			} catch (Exception exc) {
				MessageBox.Show(exc.ToString(), title, MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void LoadFromClipboardFileMenuItem_Click(object sender, EventArgs e) {
			if (unsaved) {
				DialogResult result = MessageBox.Show("Save changes?", title, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
				if (result == DialogResult.Cancel)
					return;
				else if (result == DialogResult.Yes)
					SaveFileMenuItem.PerformClick();
			}
			string json = Clipboard.GetText();
			try {
				dynamic? obj = JsonConvert.DeserializeObject(json);
				Text = $"{title}";
				if (obj is null)
					MessageBox.Show("Oops the json is somehow null", title, MessageBoxButtons.OK, MessageBoxIcon.Error);
				else {
					Tree.Nodes.Clear();
					var root = new TreeNode("root", 0, 0) { Tag = "root" };
					Tree.Nodes.Add(root);
					foreach (JToken p in obj)
						root.Nodes.Add(MakeNode(p));
				}
				SaveFileMenuItem.Enabled = true;
				SaveAsFileMenuItem.Enabled = true;
				MarkUnsaved();
			} catch (JsonException) {
				MessageBox.Show("Your clipboard does not contain valid json", title, MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
		}
	}
}
