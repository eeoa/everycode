using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Everycode
{
	public partial class OptionsForm : Form
	{
		public OptionsForm()
		{
			InitializeComponent();
		}

		private void m_buttonOK_Click(object sender, EventArgs e)
		{
			this.DialogResult = DialogResult.OK;
			this.Close();
		}

		private void m_buttonCancel_Click(object sender, EventArgs e)
		{

		}

		private void m_buttonBrowse_Click(object sender, EventArgs e)
		{
			OpenFileDialog fileDialog1 = new OpenFileDialog();
			fileDialog1.InitialDirectory = "d:\\";
			fileDialog1.Filter = "xls files (*.xls)|*.xls|All files (*.*)|*.*";
			fileDialog1.FilterIndex = 1;
			fileDialog1.RestoreDirectory = true;
			if (fileDialog1.ShowDialog() == DialogResult.OK)
			{
				this.m_textBoxSSPath.Text = fileDialog1.FileName;
			}
		}

		private void m_buttonWorkingFolderBrowse_Click(object sender, EventArgs e)
		{
			FolderBrowserDialog folderBrowserDialog1 = new FolderBrowserDialog();
			if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
			{
				this.m_textBoxWorkingFolder.Text = folderBrowserDialog1.SelectedPath;
			}
		}
	}
}
