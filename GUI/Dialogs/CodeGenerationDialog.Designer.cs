namespace NClass.GUI.Dialogs
{
	partial class CodeGenerationDialog
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
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
		private void InitializeComponent()
		{
            this.chkUseTabs = new System.Windows.Forms.CheckBox();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.updIndentSize = new System.Windows.Forms.NumericUpDown();
            this.lblIndentSize = new System.Windows.Forms.Label();
            this.grpCodeStyle = new System.Windows.Forms.GroupBox();
            this.chkNotImplemented = new System.Windows.Forms.CheckBox();
            this.lblSolutionType = new System.Windows.Forms.Label();
            this.cboSolutionType = new System.Windows.Forms.ComboBox();
            this.cboLanguage = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.txtDestination = new System.Windows.Forms.TextBox();
            this.lblDestination = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAddItem = new System.Windows.Forms.Button();
            this.txtNewImport = new System.Windows.Forms.TextBox();
            this.importToolStrip = new System.Windows.Forms.ToolStrip();
            this.toolImportList = new System.Windows.Forms.ToolStripLabel();
            this.toolDelete = new System.Windows.Forms.ToolStripButton();
            this.toolMoveDown = new System.Windows.Forms.ToolStripButton();
            this.toolMoveUp = new System.Windows.Forms.ToolStripButton();
            this.lstImportList = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.updIndentSize)).BeginInit();
            this.grpCodeStyle.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.importToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // chkUseTabs
            // 
            this.chkUseTabs.AutoSize = true;
            this.chkUseTabs.Location = new System.Drawing.Point(159, 202);
            this.chkUseTabs.Name = "chkUseTabs";
            this.chkUseTabs.Size = new System.Drawing.Size(120, 17);
            this.chkUseTabs.TabIndex = 0;
            this.chkUseTabs.Text = "Use tabs for indents";
            this.chkUseTabs.UseVisualStyleBackColor = true;
            this.chkUseTabs.CheckedChanged += new System.EventHandler(this.chkUseTabs_CheckedChanged);
            // 
            // btnGenerate
            // 
            this.btnGenerate.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnGenerate.Location = new System.Drawing.Point(186, 343);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(75, 23);
            this.btnGenerate.TabIndex = 10;
            this.btnGenerate.Text = "Generate";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(267, 343);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 11;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // updIndentSize
            // 
            this.updIndentSize.Location = new System.Drawing.Point(81, 199);
            this.updIndentSize.Maximum = new decimal(new int[] {
            16,
            0,
            0,
            0});
            this.updIndentSize.Name = "updIndentSize";
            this.updIndentSize.Size = new System.Drawing.Size(43, 20);
            this.updIndentSize.TabIndex = 2;
            this.updIndentSize.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            // 
            // lblIndentSize
            // 
            this.lblIndentSize.AutoSize = true;
            this.lblIndentSize.Enabled = false;
            this.lblIndentSize.Location = new System.Drawing.Point(14, 202);
            this.lblIndentSize.Name = "lblIndentSize";
            this.lblIndentSize.Size = new System.Drawing.Size(61, 13);
            this.lblIndentSize.TabIndex = 1;
            this.lblIndentSize.Text = "Indent size:";
            // 
            // grpCodeStyle
            // 
            this.grpCodeStyle.Controls.Add(this.btnAddItem);
            this.grpCodeStyle.Controls.Add(this.txtNewImport);
            this.grpCodeStyle.Controls.Add(this.importToolStrip);
            this.grpCodeStyle.Controls.Add(this.lstImportList);
            this.grpCodeStyle.Controls.Add(this.chkNotImplemented);
            this.grpCodeStyle.Controls.Add(this.lblIndentSize);
            this.grpCodeStyle.Controls.Add(this.cboSolutionType);
            this.grpCodeStyle.Controls.Add(this.updIndentSize);
            this.grpCodeStyle.Controls.Add(this.lblSolutionType);
            this.grpCodeStyle.Controls.Add(this.chkUseTabs);
            this.grpCodeStyle.Location = new System.Drawing.Point(12, 81);
            this.grpCodeStyle.Name = "grpCodeStyle";
            this.grpCodeStyle.Size = new System.Drawing.Size(330, 255);
            this.grpCodeStyle.TabIndex = 9;
            this.grpCodeStyle.TabStop = false;
            this.grpCodeStyle.Text = "Code style";
            // 
            // chkNotImplemented
            // 
            this.chkNotImplemented.AutoSize = true;
            this.chkNotImplemented.Location = new System.Drawing.Point(17, 225);
            this.chkNotImplemented.Name = "chkNotImplemented";
            this.chkNotImplemented.Size = new System.Drawing.Size(243, 17);
            this.chkNotImplemented.TabIndex = 4;
            this.chkNotImplemented.Text = "Fill methods with \'Not implemented\' exceptions";
            this.chkNotImplemented.UseVisualStyleBackColor = true;
            // 
            // lblSolutionType
            // 
            this.lblSolutionType.AutoSize = true;
            this.lblSolutionType.Location = new System.Drawing.Point(3, 22);
            this.lblSolutionType.Name = "lblSolutionType";
            this.lblSolutionType.Size = new System.Drawing.Size(72, 13);
            this.lblSolutionType.TabIndex = 12;
            this.lblSolutionType.Text = "Solution Type";
            // 
            // cboSolutionType
            // 
            this.cboSolutionType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSolutionType.FormattingEnabled = true;
            this.cboSolutionType.Items.AddRange(new object[] {
            "Visual Studio 2005",
            "Visual Studio 2008"});
            this.cboSolutionType.Location = new System.Drawing.Point(81, 19);
            this.cboSolutionType.Name = "cboSolutionType";
            this.cboSolutionType.Size = new System.Drawing.Size(221, 21);
            this.cboSolutionType.TabIndex = 13;
            // 
            // cboLanguage
            // 
            this.cboLanguage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLanguage.FormattingEnabled = true;
            this.cboLanguage.Items.AddRange(new object[] {
            "C#",
            "Java"});
            this.cboLanguage.Location = new System.Drawing.Point(78, 22);
            this.cboLanguage.Name = "cboLanguage";
            this.cboLanguage.Size = new System.Drawing.Size(110, 21);
            this.cboLanguage.TabIndex = 14;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.btnBrowse, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtDestination, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblDestination, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 49);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(330, 26);
            this.tableLayoutPanel1.TabIndex = 15;
            // 
            // btnBrowse
            // 
            this.btnBrowse.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnBrowse.Location = new System.Drawing.Point(303, 1);
            this.btnBrowse.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(27, 23);
            this.btnBrowse.TabIndex = 6;
            this.btnBrowse.Text = "...";
            this.btnBrowse.UseVisualStyleBackColor = true;
            // 
            // txtDestination
            // 
            this.txtDestination.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDestination.Location = new System.Drawing.Point(66, 3);
            this.txtDestination.Name = "txtDestination";
            this.txtDestination.Size = new System.Drawing.Size(231, 20);
            this.txtDestination.TabIndex = 5;
            // 
            // lblDestination
            // 
            this.lblDestination.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblDestination.AutoSize = true;
            this.lblDestination.Location = new System.Drawing.Point(0, 6);
            this.lblDestination.Margin = new System.Windows.Forms.Padding(0, 0, 0, 1);
            this.lblDestination.Name = "lblDestination";
            this.lblDestination.Size = new System.Drawing.Size(63, 13);
            this.lblDestination.TabIndex = 4;
            this.lblDestination.Text = "Destination:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Language";
            // 
            // btnAddItem
            // 
            this.btnAddItem.Enabled = false;
            this.btnAddItem.Location = new System.Drawing.Point(285, 173);
            this.btnAddItem.Name = "btnAddItem";
            this.btnAddItem.Size = new System.Drawing.Size(28, 23);
            this.btnAddItem.TabIndex = 17;
            this.btnAddItem.Text = "+";
            this.btnAddItem.UseVisualStyleBackColor = true;
            // 
            // txtNewImport
            // 
            this.txtNewImport.Location = new System.Drawing.Point(17, 173);
            this.txtNewImport.Name = "txtNewImport";
            this.txtNewImport.Size = new System.Drawing.Size(262, 20);
            this.txtNewImport.TabIndex = 16;
            // 
            // importToolStrip
            // 
            this.importToolStrip.AutoSize = false;
            this.importToolStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.importToolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.importToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolImportList,
            this.toolDelete,
            this.toolMoveDown,
            this.toolMoveUp});
            this.importToolStrip.Location = new System.Drawing.Point(130, 47);
            this.importToolStrip.Name = "importToolStrip";
            this.importToolStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.importToolStrip.Size = new System.Drawing.Size(183, 25);
            this.importToolStrip.TabIndex = 14;
            this.importToolStrip.Text = "toolStrip1";
            // 
            // toolImportList
            // 
            this.toolImportList.Name = "toolImportList";
            this.toolImportList.Size = new System.Drawing.Size(61, 22);
            this.toolImportList.Text = "Import list";
            // 
            // toolDelete
            // 
            this.toolDelete.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolDelete.Enabled = false;
            this.toolDelete.Image = global::NClass.GUI.Properties.Resources.Delete;
            this.toolDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolDelete.Name = "toolDelete";
            this.toolDelete.Size = new System.Drawing.Size(23, 22);
            this.toolDelete.Text = "Delete";
            // 
            // toolMoveDown
            // 
            this.toolMoveDown.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolMoveDown.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolMoveDown.Enabled = false;
            this.toolMoveDown.Image = global::NClass.GUI.Properties.Resources.MoveDown;
            this.toolMoveDown.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolMoveDown.Name = "toolMoveDown";
            this.toolMoveDown.Size = new System.Drawing.Size(23, 22);
            this.toolMoveDown.Text = "Move Down";
            // 
            // toolMoveUp
            // 
            this.toolMoveUp.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolMoveUp.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolMoveUp.Enabled = false;
            this.toolMoveUp.Image = global::NClass.GUI.Properties.Resources.MoveUp;
            this.toolMoveUp.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolMoveUp.Name = "toolMoveUp";
            this.toolMoveUp.Size = new System.Drawing.Size(23, 22);
            this.toolMoveUp.Text = "Move Up";
            // 
            // lstImportList
            // 
            this.lstImportList.FormattingEnabled = true;
            this.lstImportList.Location = new System.Drawing.Point(17, 75);
            this.lstImportList.Name = "lstImportList";
            this.lstImportList.Size = new System.Drawing.Size(296, 95);
            this.lstImportList.TabIndex = 15;
            // 
            // CodeGenerationDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(367, 383);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.cboLanguage);
            this.Controls.Add(this.grpCodeStyle);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnGenerate);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CodeGenerationDialog";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Code Generation";
            ((System.ComponentModel.ISupportInitialize)(this.updIndentSize)).EndInit();
            this.grpCodeStyle.ResumeLayout(false);
            this.grpCodeStyle.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.importToolStrip.ResumeLayout(false);
            this.importToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.CheckBox chkUseTabs;
		private System.Windows.Forms.Button btnGenerate;
		private System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.NumericUpDown updIndentSize;
		private System.Windows.Forms.Label lblIndentSize;
		private System.Windows.Forms.GroupBox grpCodeStyle;
		private System.Windows.Forms.Label lblSolutionType;
		private System.Windows.Forms.ComboBox cboSolutionType;
		private System.Windows.Forms.CheckBox chkNotImplemented;
		private System.Windows.Forms.ComboBox cboLanguage;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.Button btnBrowse;
		private System.Windows.Forms.TextBox txtDestination;
		private System.Windows.Forms.Label lblDestination;
        private System.Windows.Forms.Button btnAddItem;
        private System.Windows.Forms.TextBox txtNewImport;
        private System.Windows.Forms.ToolStrip importToolStrip;
        private System.Windows.Forms.ToolStripLabel toolImportList;
        private System.Windows.Forms.ToolStripButton toolDelete;
        private System.Windows.Forms.ToolStripButton toolMoveDown;
        private System.Windows.Forms.ToolStripButton toolMoveUp;
        private System.Windows.Forms.ListBox lstImportList;
        private System.Windows.Forms.Label label1;
    }
}