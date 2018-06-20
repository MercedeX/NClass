// NClass - Free class diagram editor
// Copyright (C) 2006-2009 Balazs Tihanyi
// 
// This program is free software; you can redistribute it and/or modify it under 
// the terms of the GNU General Public License as published by the Free Software 
// Foundation; either version 3 of the License, or (at your option) any later version.
// 
// This program is distributed in the hope that it will be useful, but WITHOUT 
// ANY WARRANTY; without even the implied warranty of MERCHANTABILITY or FITNESS 
// FOR A PARTICULAR PURPOSE. See the GNU General Public License for more details.
//
// You should have received a copy of the GNU General Public License along with 
// this program; if not, write to the Free Software Foundation, Inc., 
// 59 Temple Place, Suite 330, Boston, MA  02111-1307  USA

using System;
using System.IO;
using System.Collections.Specialized;
using System.Windows.Forms;
using NClass.Core;
using NClass.CSharp;
using NClass.Java;
using NClass.Translations;
using System.Collections.Generic;
using System.Linq;
using NClass.CodeGenerator;

namespace NClass.GUI.Dialogs
{

	public partial class CodeGenerationDialog : Form
	{
		readonly Project _project = null;

        CodeGenerationModel _model = new CodeGenerationModel();

		public CodeGenerationDialog(Project project)
		{
			InitializeComponent();


			importToolStrip.Renderer = ToolStripSimplifiedRenderer.Default;

            _project = project;

            _model.Destination = Settings.Default.DestinationPath;
            _model.HasNotImplementedException = Settings.Default.UseNotImplementedExceptions;
            _model.IndentSize = Settings.Default.IndentSize;
            _model.Language = CSharpLanguage.Instance;
            _model.Solution = Settings.Default.SolutionType;
            _model.UseTabsForIndent = Settings.Default.UseTabsForIndents;
           


            txtDestination.TextChanged += (obj, arg) =>  _model.Destination = txtDestination.Text;
            cboLanguage.SelectedIndexChanged += (obj, arg) => UpdateImportList();
            btnBrowse.Click += (obj, arg) => txtDestination.Text = ChooseDestination(txtDestination.Text);
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            UpdateTexts();


            lstImportList.Items.Clear();
            UpdateImportList();

            txtDestination.Text = _model.Destination;
            chkUseTabs.Checked = _model.UseTabsForIndent;
            updIndentSize.Value = _model.IndentSize;
            cboSolutionType.SelectedIndex = (int)_model.Solution;
            chkNotImplemented.Checked = _model.HasNotImplementedException;
            cboLanguage.SelectedIndex = _model.Language is CSharpLanguage ? 0 : 1;

        }


        public CodeGenerationModel Result => _model;

		private void UpdateTexts()
		{
			this.Text = Strings.CodeGeneration;
			lblDestination.Text = Strings.Destination;
			btnAddItem.Text = Strings.ButtonAddItem;
			btnBrowse.Text = Strings.ButtonBrowse;
			btnGenerate.Text = Strings.ButtonGenerate;
			btnCancel.Text = Strings.ButtonCancel;
			toolImportList.Text = Strings.ImportList;
			toolMoveUp.Text = Strings.MoveUp;
			toolMoveDown.Text = Strings.MoveDown;
			toolDelete.Text = Strings.Delete;
			lblSolutionType.Text = Strings.SolutionType;
			grpCodeStyle.Text = Strings.CodeStyle;
			chkUseTabs.Text = Strings.UseTabs;
			lblIndentSize.Text = Strings.IndentSize;
			chkNotImplemented.Text = Strings.UseNotImplementedExceptions;
		}

		private void UpdateImportList()
		{
			Language language = null;

			//TODO: ezt le kellene kérdezni egy LanguageManager-től
			if (object.Equals(cboLanguage.SelectedItem, "C#"))
				language = CSharpLanguage.Instance;
			else if (object.Equals(cboLanguage.SelectedItem, "Java"))
				language = JavaLanguage.Instance;

			if (language != null)
			{
				Settings.Default.Upgrade();
				lstImportList.Items.Clear();
				foreach (string importString in Settings.Default.ImportList[language])
					lstImportList.Items.Add(importString);
			}
		}

		//private void SaveImportList()
		//{
		//	StringCollection importList = new StringCollection();
		//	foreach (object import in lstImportList.Items)
		//		importList.Add(import.ToString());

		//	//TODO: ezt is másképp kéne
		//	if (object.Equals(cboLanguage.SelectedItem, "C#"))
		//		Settings.Default.CSharpImportList = importList;
		//	else if (object.Equals(cboLanguage.SelectedItem, "Java"))
		//		Settings.Default.JavaImportList = importList;
		//}

		//public DialogResult ShowDialog(Project project)
		//{
		//	//this._project = project;

		//	//UpdateTexts();
		//	//UpdateValues();
		//	ShowDialog();
            

  //          //if (DialogResult == DialogResult.OK)
  //          //	Settings.Default.Save();
  //          //else
  //          //	Settings.Default.Reload();


  //          return DialogResult;
		//}

		private string ChooseDestination(string path)
		{
            var ret = path;
			using (FolderBrowserDialog dialog = new FolderBrowserDialog {
                Description = Strings.GeneratorTargetDir,
                SelectedPath = path
            })
			{
				if (dialog.ShowDialog() == DialogResult.OK) 
					ret = dialog.SelectedPath;
			}
            return ret; 
		}

		private void toolMoveUp_Click(object sender, EventArgs e)
		{
			int index = lstImportList.SelectedIndex;
			if (index > 0)
			{
				object temp = lstImportList.Items[index];
				lstImportList.Items[index] = lstImportList.Items[index - 1];
				lstImportList.Items[index - 1] = temp;
				lstImportList.SelectedIndex--;
				//SaveImportList();
			}
		}

        private void toolMoveDown_Click(object sender, EventArgs e)
		{
			int index = lstImportList.SelectedIndex;
			if (index < lstImportList.Items.Count - 1)
			{
				object temp = lstImportList.Items[index];
				lstImportList.Items[index] = lstImportList.Items[index + 1];
				lstImportList.Items[index + 1] = temp;
				lstImportList.SelectedIndex++;
				//SaveImportList();
			}
		}

		private void toolDelete_Click(object sender, EventArgs e)
		{
			if (lstImportList.SelectedItem != null)
			{
				int selectedIndex = lstImportList.SelectedIndex;
				lstImportList.Items.RemoveAt(selectedIndex);
				if (lstImportList.Items.Count > selectedIndex)
					lstImportList.SelectedIndex = selectedIndex;
				else
					lstImportList.SelectedIndex = lstImportList.Items.Count - 1;
				//SaveImportList();
			}
		}

		private void lstImportList_SelectedValueChanged(object sender, EventArgs e)
		{
			bool isSelected = (lstImportList.SelectedItem != null);

			toolMoveUp.Enabled = isSelected && (lstImportList.SelectedIndex > 0);
			toolMoveDown.Enabled = isSelected &&
				(lstImportList.SelectedIndex < lstImportList.Items.Count - 1);
			toolDelete.Enabled = isSelected;
		}

		private void lstImportList_Leave(object sender, EventArgs e)
		{
			lstImportList.SelectedItem = null;
		}

		private void txtNewImport_TextChanged(object sender, EventArgs e)
		{
			btnAddItem.Enabled = (txtNewImport.Text.Length > 0);
		}

		private void txtNewImport_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter && txtNewImport.Text.Length > 0)
			{
				lstImportList.Items.Add(txtNewImport.Text);
				txtNewImport.Text = string.Empty;
				//SaveImportList();
			}
		}

		private void btnAddItem_Click(object sender, EventArgs e)
		{
			lstImportList.Items.Add(txtNewImport.Text);
			txtNewImport.Text = string.Empty;
			txtNewImport.Focus();
			//SaveImportList();
		}

		private void chkUseTabs_CheckedChanged(object sender, EventArgs e)
		{
			bool useTabs = chkUseTabs.Checked;

			lblIndentSize.Enabled = !useTabs;
			updIndentSize.Enabled = !useTabs;
		}

		private void btnGenerate_Click(object sender, EventArgs e)
		{
            _model.Language = cboLanguage.SelectedIndex == 0 ? CSharpLanguage.Instance as Language : JavaLanguage.Instance as Language;
            _model.Solution = cboSolutionType.SelectedIndex == 0 ? SolutionType.VisualStudio2005 : SolutionType.VisualStudio2008;
            foreach(string it in lstImportList.Items)
            {
                _model.Usings.Add(it);
            }
            _model.IndentSize = Convert.ToInt32(updIndentSize.Value);
            _model.UseTabsForIndent = chkUseTabs.Checked;
            _model.HasNotImplementedException = chkNotImplemented.Checked;

            DialogResult = DialogResult.OK;
            Close();
		}

	}
}