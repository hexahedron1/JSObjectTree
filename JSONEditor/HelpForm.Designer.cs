namespace JSONEditor {
	partial class HelpForm {
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
			components = new System.ComponentModel.Container();
			TreeNode treeNode1 = new TreeNode("How to use");
			TreeNode treeNode2 = new TreeNode("Changelog");
			TreeNode treeNode3 = new TreeNode("Settings");
			TreeNode treeNode4 = new TreeNode("Help", new TreeNode[] { treeNode1, treeNode2, treeNode3 });
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HelpForm));
			splitContainer1 = new SplitContainer();
			HelpTree = new TreeView();
			TreeImageList = new ImageList(components);
			ContentBox = new TextBox();
			TitleLabel = new Label();
			((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
			splitContainer1.Panel1.SuspendLayout();
			splitContainer1.Panel2.SuspendLayout();
			splitContainer1.SuspendLayout();
			SuspendLayout();
			// 
			// splitContainer1
			// 
			splitContainer1.Dock = DockStyle.Fill;
			splitContainer1.Location = new Point(0, 0);
			splitContainer1.Name = "splitContainer1";
			// 
			// splitContainer1.Panel1
			// 
			splitContainer1.Panel1.Controls.Add(HelpTree);
			// 
			// splitContainer1.Panel2
			// 
			splitContainer1.Panel2.Controls.Add(ContentBox);
			splitContainer1.Panel2.Controls.Add(TitleLabel);
			splitContainer1.Size = new Size(800, 450);
			splitContainer1.SplitterDistance = 266;
			splitContainer1.TabIndex = 0;
			// 
			// HelpTree
			// 
			HelpTree.Dock = DockStyle.Fill;
			HelpTree.ImageKey = "file_lines-1.png";
			HelpTree.ImageList = TreeImageList;
			HelpTree.Location = new Point(0, 0);
			HelpTree.Name = "HelpTree";
			treeNode1.ImageKey = "file_lines-1.png";
			treeNode1.Name = "HowToUse";
			treeNode1.SelectedImageKey = "file_lines-1.png";
			treeNode1.Tag = "How to use";
			treeNode1.Text = "How to use";
			treeNode1.ToolTipText = "How to use";
			treeNode2.ImageKey = "file_lines-1.png";
			treeNode2.Name = "Changelog";
			treeNode2.SelectedImageKey = "file_lines-1.png";
			treeNode2.Tag = "Changelog";
			treeNode2.Text = "Changelog";
			treeNode3.ImageKey = "file_lines-1.png";
			treeNode3.Name = "Settings";
			treeNode3.SelectedImageKey = "file_lines-1.png";
			treeNode3.Tag = "Settings";
			treeNode3.Text = "Settings";
			treeNode4.ImageKey = "help_book_small-5.png";
			treeNode4.Name = "Help";
			treeNode4.SelectedImageKey = "help_book_small-5.png";
			treeNode4.Text = "Help";
			HelpTree.Nodes.AddRange(new TreeNode[] { treeNode4 });
			HelpTree.SelectedImageKey = "file_lines-1.png";
			HelpTree.Size = new Size(266, 450);
			HelpTree.TabIndex = 0;
			HelpTree.NodeMouseDoubleClick += HelpTree_NodeMouseDoubleClick;
			// 
			// TreeImageList
			// 
			TreeImageList.ColorDepth = ColorDepth.Depth32Bit;
			TreeImageList.ImageStream = (ImageListStreamer)resources.GetObject("TreeImageList.ImageStream");
			TreeImageList.TransparentColor = Color.Transparent;
			TreeImageList.Images.SetKeyName(0, "help_book_small-5.png");
			TreeImageList.Images.SetKeyName(1, "directory_closed-1.png");
			TreeImageList.Images.SetKeyName(2, "file_lines-1.png");
			// 
			// ContentBox
			// 
			ContentBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			ContentBox.Location = new Point(3, 42);
			ContentBox.Multiline = true;
			ContentBox.Name = "ContentBox";
			ContentBox.ReadOnly = true;
			ContentBox.ScrollBars = ScrollBars.Both;
			ContentBox.Size = new Size(524, 405);
			ContentBox.TabIndex = 1;
			ContentBox.Text = "Double click on a topic to show its content";
			// 
			// TitleLabel
			// 
			TitleLabel.AutoSize = true;
			TitleLabel.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
			TitleLabel.Location = new Point(3, 9);
			TitleLabel.Name = "TitleLabel";
			TitleLabel.Size = new Size(57, 30);
			TitleLabel.TabIndex = 0;
			TitleLabel.Text = "Help";
			// 
			// HelpForm
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(800, 450);
			Controls.Add(splitContainer1);
			Icon = (Icon)resources.GetObject("$this.Icon");
			Name = "HelpForm";
			Text = "Javascript Object Tree | Help";
			FormClosing += HelpForm_FormClosing;
			Load += HelpForm_Load;
			Shown += HelpForm_Shown;
			splitContainer1.Panel1.ResumeLayout(false);
			splitContainer1.Panel2.ResumeLayout(false);
			splitContainer1.Panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
			splitContainer1.ResumeLayout(false);
			ResumeLayout(false);
		}

		#endregion

		private SplitContainer splitContainer1;
		private TreeView HelpTree;
		private ImageList TreeImageList;
		private Label TitleLabel;
		private TextBox ContentBox;
	}
}