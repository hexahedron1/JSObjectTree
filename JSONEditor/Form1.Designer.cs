namespace JSONEditor {
	partial class Form1 {
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
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
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			statusStrip1 = new StatusStrip();
			Progressbar = new ToolStripProgressBar();
			StatusLabel = new ToolStripStatusLabel();
			toolStrip1 = new ToolStrip();
			FileDropdownButton = new ToolStripDropDownButton();
			NewFileMenuItem = new ToolStripMenuItem();
			OpenFileMenuItem = new ToolStripMenuItem();
			SaveFileMenuItem = new ToolStripMenuItem();
			SaveAsFileMenuItem = new ToolStripMenuItem();
			EditDropdownButton = new ToolStripDropDownButton();
			CopyEditMenuItem = new ToolStripMenuItem();
			PasteEditMenuItem = new ToolStripMenuItem();
			PrefEditMenuItem = new ToolStripMenuItem();
			ViewDropdownButton = new ToolStripDropDownButton();
			PropViewMenuItem = new ToolStripMenuItem();
			toolStripSeparator1 = new ToolStripSeparator();
			AddNodeButton = new ToolStripSplitButton();
			AddValueMenuItem = new ToolStripMenuItem();
			AddObjectMenuItem = new ToolStripMenuItem();
			AddArrayMenuItem = new ToolStripMenuItem();
			DeleteNodeButton = new ToolStripButton();
			MainSplitContainer = new SplitContainer();
			Tree = new TreeView();
			TreeImageList = new ImageList(components);
			MessageList = new ListView();
			MessageToolStrip = new ToolStrip();
			ErrorCheck = new ToolStripButton();
			toolStripSeparator2 = new ToolStripSeparator();
			WarningCheck = new ToolStripButton();
			openFileDialog = new OpenFileDialog();
			saveFileDialog = new SaveFileDialog();
			statusStrip1.SuspendLayout();
			toolStrip1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)MainSplitContainer).BeginInit();
			MainSplitContainer.Panel1.SuspendLayout();
			MainSplitContainer.Panel2.SuspendLayout();
			MainSplitContainer.SuspendLayout();
			MessageToolStrip.SuspendLayout();
			SuspendLayout();
			// 
			// statusStrip1
			// 
			statusStrip1.Items.AddRange(new ToolStripItem[] { Progressbar, StatusLabel });
			statusStrip1.Location = new Point(0, 428);
			statusStrip1.Name = "statusStrip1";
			statusStrip1.Size = new Size(800, 22);
			statusStrip1.TabIndex = 0;
			statusStrip1.Text = "statusStrip1";
			// 
			// Progressbar
			// 
			Progressbar.Name = "Progressbar";
			Progressbar.Size = new Size(100, 16);
			Progressbar.Visible = false;
			// 
			// StatusLabel
			// 
			StatusLabel.Name = "StatusLabel";
			StatusLabel.Size = new Size(67, 17);
			StatusLabel.Text = "StatusLabel";
			StatusLabel.Visible = false;
			// 
			// toolStrip1
			// 
			toolStrip1.Items.AddRange(new ToolStripItem[] { FileDropdownButton, EditDropdownButton, ViewDropdownButton, toolStripSeparator1, AddNodeButton, DeleteNodeButton });
			toolStrip1.Location = new Point(0, 0);
			toolStrip1.Name = "toolStrip1";
			toolStrip1.Size = new Size(800, 25);
			toolStrip1.TabIndex = 1;
			toolStrip1.Text = "toolStrip1";
			// 
			// FileDropdownButton
			// 
			FileDropdownButton.DisplayStyle = ToolStripItemDisplayStyle.Text;
			FileDropdownButton.DropDownItems.AddRange(new ToolStripItem[] { NewFileMenuItem, OpenFileMenuItem, SaveFileMenuItem, SaveAsFileMenuItem });
			FileDropdownButton.Image = (Image)resources.GetObject("FileDropdownButton.Image");
			FileDropdownButton.ImageTransparentColor = Color.Magenta;
			FileDropdownButton.Name = "FileDropdownButton";
			FileDropdownButton.Size = new Size(38, 22);
			FileDropdownButton.Text = "File";
			// 
			// NewFileMenuItem
			// 
			NewFileMenuItem.Image = Properties.Resources.template_empty_1;
			NewFileMenuItem.Name = "NewFileMenuItem";
			NewFileMenuItem.ShortcutKeyDisplayString = "Ctrl+N";
			NewFileMenuItem.Size = new Size(193, 22);
			NewFileMenuItem.Text = "New...";
			NewFileMenuItem.Click += NewFileMenuItem_Click;
			// 
			// OpenFileMenuItem
			// 
			OpenFileMenuItem.Name = "OpenFileMenuItem";
			OpenFileMenuItem.ShortcutKeyDisplayString = "Ctrl+O";
			OpenFileMenuItem.Size = new Size(193, 22);
			OpenFileMenuItem.Text = "Open...";
			OpenFileMenuItem.Click += OpenFileMenuItem_Click;
			// 
			// SaveFileMenuItem
			// 
			SaveFileMenuItem.Enabled = false;
			SaveFileMenuItem.Name = "SaveFileMenuItem";
			SaveFileMenuItem.ShortcutKeyDisplayString = "Ctrl+S";
			SaveFileMenuItem.Size = new Size(193, 22);
			SaveFileMenuItem.Text = "Save";
			SaveFileMenuItem.Click += SaveFileMenuItem_Click;
			// 
			// SaveAsFileMenuItem
			// 
			SaveAsFileMenuItem.Enabled = false;
			SaveAsFileMenuItem.Name = "SaveAsFileMenuItem";
			SaveAsFileMenuItem.ShortcutKeyDisplayString = "Ctrl+Shift+S";
			SaveAsFileMenuItem.Size = new Size(193, 22);
			SaveAsFileMenuItem.Text = "Save as...";
			SaveAsFileMenuItem.Click += SaveAsFileMenuItem_Click;
			// 
			// EditDropdownButton
			// 
			EditDropdownButton.DisplayStyle = ToolStripItemDisplayStyle.Text;
			EditDropdownButton.DropDownItems.AddRange(new ToolStripItem[] { CopyEditMenuItem, PasteEditMenuItem, PrefEditMenuItem });
			EditDropdownButton.Image = (Image)resources.GetObject("EditDropdownButton.Image");
			EditDropdownButton.ImageTransparentColor = Color.Magenta;
			EditDropdownButton.Name = "EditDropdownButton";
			EditDropdownButton.Size = new Size(40, 22);
			EditDropdownButton.Text = "Edit";
			// 
			// CopyEditMenuItem
			// 
			CopyEditMenuItem.Enabled = false;
			CopyEditMenuItem.Name = "CopyEditMenuItem";
			CopyEditMenuItem.ShortcutKeyDisplayString = "Ctrl+C";
			CopyEditMenuItem.Size = new Size(144, 22);
			CopyEditMenuItem.Text = "Copy";
			// 
			// PasteEditMenuItem
			// 
			PasteEditMenuItem.Enabled = false;
			PasteEditMenuItem.Name = "PasteEditMenuItem";
			PasteEditMenuItem.ShortcutKeyDisplayString = "Ctrl+V";
			PasteEditMenuItem.Size = new Size(144, 22);
			PasteEditMenuItem.Text = "Paste";
			// 
			// PrefEditMenuItem
			// 
			PrefEditMenuItem.Image = Properties.Resources.settings_gear_5;
			PrefEditMenuItem.Name = "PrefEditMenuItem";
			PrefEditMenuItem.Size = new Size(144, 22);
			PrefEditMenuItem.Text = "Preferences";
			PrefEditMenuItem.Click += PrefEditMenuItem_Click;
			// 
			// ViewDropdownButton
			// 
			ViewDropdownButton.DisplayStyle = ToolStripItemDisplayStyle.Text;
			ViewDropdownButton.DropDownItems.AddRange(new ToolStripItem[] { PropViewMenuItem });
			ViewDropdownButton.Enabled = false;
			ViewDropdownButton.Image = (Image)resources.GetObject("ViewDropdownButton.Image");
			ViewDropdownButton.ImageTransparentColor = Color.Magenta;
			ViewDropdownButton.Name = "ViewDropdownButton";
			ViewDropdownButton.Size = new Size(45, 22);
			ViewDropdownButton.Text = "View";
			ViewDropdownButton.Visible = false;
			// 
			// PropViewMenuItem
			// 
			PropViewMenuItem.Checked = true;
			PropViewMenuItem.CheckState = CheckState.Checked;
			PropViewMenuItem.Name = "PropViewMenuItem";
			PropViewMenuItem.Size = new Size(104, 22);
			PropViewMenuItem.Text = "Errors";
			PropViewMenuItem.Click += PropViewMenuItem_Click;
			// 
			// toolStripSeparator1
			// 
			toolStripSeparator1.Name = "toolStripSeparator1";
			toolStripSeparator1.Size = new Size(6, 25);
			// 
			// AddNodeButton
			// 
			AddNodeButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
			AddNodeButton.DropDownItems.AddRange(new ToolStripItem[] { AddValueMenuItem, AddObjectMenuItem, AddArrayMenuItem });
			AddNodeButton.Enabled = false;
			AddNodeButton.Image = Properties.Resources.ole2;
			AddNodeButton.ImageTransparentColor = Color.Magenta;
			AddNodeButton.Name = "AddNodeButton";
			AddNodeButton.Size = new Size(32, 22);
			AddNodeButton.Text = "Add property";
			AddNodeButton.ButtonClick += AddNodeButton_ButtonClick;
			// 
			// AddValueMenuItem
			// 
			AddValueMenuItem.Enabled = false;
			AddValueMenuItem.Image = Properties.Resources.ole;
			AddValueMenuItem.Name = "AddValueMenuItem";
			AddValueMenuItem.Size = new Size(109, 22);
			AddValueMenuItem.Text = "Value";
			AddValueMenuItem.Click += AddValueMenuItem_Click;
			// 
			// AddObjectMenuItem
			// 
			AddObjectMenuItem.Enabled = false;
			AddObjectMenuItem.Image = Properties.Resources.ole2_obj;
			AddObjectMenuItem.Name = "AddObjectMenuItem";
			AddObjectMenuItem.Size = new Size(109, 22);
			AddObjectMenuItem.Text = "Object";
			AddObjectMenuItem.Click += AddObjectMenuItem_Click;
			// 
			// AddArrayMenuItem
			// 
			AddArrayMenuItem.Enabled = false;
			AddArrayMenuItem.Image = Properties.Resources.ole_array;
			AddArrayMenuItem.Name = "AddArrayMenuItem";
			AddArrayMenuItem.Size = new Size(109, 22);
			AddArrayMenuItem.Text = "Array";
			AddArrayMenuItem.Click += AddArrayMenuItem_Click;
			// 
			// DeleteNodeButton
			// 
			DeleteNodeButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
			DeleteNodeButton.Enabled = false;
			DeleteNodeButton.Image = Properties.Resources.recycle_bin_empty_2k_1;
			DeleteNodeButton.ImageTransparentColor = Color.Magenta;
			DeleteNodeButton.Name = "DeleteNodeButton";
			DeleteNodeButton.Size = new Size(23, 22);
			DeleteNodeButton.Text = "Delete";
			DeleteNodeButton.Click += DeleteNodeButton_Click;
			// 
			// MainSplitContainer
			// 
			MainSplitContainer.Dock = DockStyle.Fill;
			MainSplitContainer.FixedPanel = FixedPanel.Panel2;
			MainSplitContainer.Location = new Point(0, 25);
			MainSplitContainer.Name = "MainSplitContainer";
			MainSplitContainer.Orientation = Orientation.Horizontal;
			// 
			// MainSplitContainer.Panel1
			// 
			MainSplitContainer.Panel1.Controls.Add(Tree);
			// 
			// MainSplitContainer.Panel2
			// 
			MainSplitContainer.Panel2.Controls.Add(MessageList);
			MainSplitContainer.Panel2.Controls.Add(MessageToolStrip);
			MainSplitContainer.Panel2Collapsed = true;
			MainSplitContainer.Size = new Size(800, 403);
			MainSplitContainer.SplitterDistance = 280;
			MainSplitContainer.TabIndex = 2;
			// 
			// Tree
			// 
			Tree.Dock = DockStyle.Fill;
			Tree.HideSelection = false;
			Tree.ImageIndex = 0;
			Tree.ImageList = TreeImageList;
			Tree.LabelEdit = true;
			Tree.Location = new Point(0, 0);
			Tree.Name = "Tree";
			Tree.SelectedImageIndex = 0;
			Tree.Size = new Size(800, 403);
			Tree.TabIndex = 0;
			Tree.AfterLabelEdit += Tree_AfterLabelEdit;
			Tree.BeforeExpand += Tree_BeforeExpand;
			Tree.AfterSelect += Tree_AfterSelect;
			Tree.KeyDown += Tree_KeyDown;
			// 
			// TreeImageList
			// 
			TreeImageList.ColorDepth = ColorDepth.Depth32Bit;
			TreeImageList.ImageStream = (ImageListStreamer)resources.GetObject("TreeImageList.ImageStream");
			TreeImageList.TransparentColor = Color.Transparent;
			TreeImageList.Images.SetKeyName(0, "ole2.png");
			TreeImageList.Images.SetKeyName(1, "ole.png");
			TreeImageList.Images.SetKeyName(2, "circle_question-1.png");
			TreeImageList.Images.SetKeyName(3, "ole2-obj.png");
			TreeImageList.Images.SetKeyName(4, "ole-array.png");
			// 
			// MessageList
			// 
			MessageList.Dock = DockStyle.Fill;
			MessageList.Location = new Point(0, 25);
			MessageList.Name = "MessageList";
			MessageList.Size = new Size(150, 21);
			MessageList.TabIndex = 1;
			MessageList.UseCompatibleStateImageBehavior = false;
			// 
			// MessageToolStrip
			// 
			MessageToolStrip.Items.AddRange(new ToolStripItem[] { ErrorCheck, toolStripSeparator2, WarningCheck });
			MessageToolStrip.Location = new Point(0, 0);
			MessageToolStrip.Name = "MessageToolStrip";
			MessageToolStrip.Size = new Size(150, 25);
			MessageToolStrip.TabIndex = 0;
			MessageToolStrip.Text = "Message tool strip";
			// 
			// ErrorCheck
			// 
			ErrorCheck.Image = Properties.Resources.msg_error_2;
			ErrorCheck.ImageTransparentColor = Color.Magenta;
			ErrorCheck.Name = "ErrorCheck";
			ErrorCheck.Size = new Size(66, 22);
			ErrorCheck.Text = "0 Errors";
			// 
			// toolStripSeparator2
			// 
			toolStripSeparator2.Name = "toolStripSeparator2";
			toolStripSeparator2.Size = new Size(6, 25);
			// 
			// WarningCheck
			// 
			WarningCheck.Enabled = false;
			WarningCheck.Image = Properties.Resources.msg_warning_2;
			WarningCheck.ImageTransparentColor = Color.Magenta;
			WarningCheck.Name = "WarningCheck";
			WarningCheck.Size = new Size(86, 20);
			WarningCheck.Text = "0 Warnings";
			// 
			// openFileDialog
			// 
			openFileDialog.DefaultExt = "json";
			openFileDialog.Filter = "JSON Files|*.json";
			// 
			// saveFileDialog
			// 
			saveFileDialog.DefaultExt = "json";
			saveFileDialog.Filter = "JSON Files|*.json";
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(800, 450);
			Controls.Add(MainSplitContainer);
			Controls.Add(toolStrip1);
			Controls.Add(statusStrip1);
			Icon = (Icon)resources.GetObject("$this.Icon");
			Name = "Form1";
			Text = "Javascript Object Tree";
			FormClosing += Form1_FormClosing;
			Load += Form1_Load;
			statusStrip1.ResumeLayout(false);
			statusStrip1.PerformLayout();
			toolStrip1.ResumeLayout(false);
			toolStrip1.PerformLayout();
			MainSplitContainer.Panel1.ResumeLayout(false);
			MainSplitContainer.Panel2.ResumeLayout(false);
			MainSplitContainer.Panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)MainSplitContainer).EndInit();
			MainSplitContainer.ResumeLayout(false);
			MessageToolStrip.ResumeLayout(false);
			MessageToolStrip.PerformLayout();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private StatusStrip statusStrip1;
		private ToolStripProgressBar Progressbar;
		private ToolStripStatusLabel StatusLabel;
		private ToolStrip toolStrip1;
		private ToolStripDropDownButton EditDropdownButton;
		private ToolStripDropDownButton FileDropdownButton;
		private ToolStripMenuItem NewFileMenuItem;
		private ToolStripMenuItem OpenFileMenuItem;
		private ToolStripMenuItem SaveFileMenuItem;
		private ToolStripMenuItem SaveAsFileMenuItem;
		private ToolStripMenuItem CopyEditMenuItem;
		private ToolStripMenuItem PasteEditMenuItem;
		private ToolStripMenuItem PrefEditMenuItem;
		private ToolStripDropDownButton ViewDropdownButton;
		private SplitContainer MainSplitContainer;
		private TreeView Tree;
		private ImageList TreeImageList;
		private ToolStripMenuItem PropViewMenuItem;
		private ToolStripSeparator toolStripSeparator1;
		private ToolStripSplitButton AddNodeButton;
		private ToolStripMenuItem AddValueMenuItem;
		private ToolStripButton DeleteNodeButton;
		private OpenFileDialog openFileDialog;
		private ToolStrip MessageToolStrip;
		private ToolStripButton ErrorCheck;
		private ToolStripSeparator toolStripSeparator2;
		private ToolStripButton WarningCheck;
		private ListView MessageList;
		private ToolStripMenuItem AddObjectMenuItem;
		private ToolStripMenuItem AddArrayMenuItem;
		private SaveFileDialog saveFileDialog;
	}
}
