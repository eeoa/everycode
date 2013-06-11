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
	public partial class EverycodeForm : Form
	{
		public EverycodeForm()
		{
			InitializeComponent();
		}

		private void m_notifyIcon_Click(object sender, EventArgs e)
		{
			TopShow();
		}

		private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			m_bColse = true;
			this.m_notifyIcon.Visible = false;
			this.Close();
		}


		private OptionsForm m_formOption;

		private void 设置ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			m_formOption = new OptionsForm();
			System.Windows.Forms.DialogResult result = m_formOption.ShowDialog(this);
		}

		public void OnHotkey(int HotkeyID)
		{
			TopShow();
		}

		private void EverycodeForm_Load(object sender, EventArgs e)
		{
			HotKey hotkey;
			hotkey = new HotKey(this.Handle);
			HotKey.Hotkey1 = hotkey.RegisterHotkey(System.Windows.Forms.Keys.Q, HotKey.KeyFlags.MOD_WIN);   //定义快键(Alt + F3)
			hotkey.OnHotkey += new HotkeyEventHandler(OnHotkey);
		}

		private void EverycodeForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (m_bColse)
			{
				e.Cancel = false;
			}
			else
			{
				GoToTaskPanel();
				e.Cancel = true;
			}

		}

		private void TopShow()
		{
			this.m_notifyIcon.Visible = false;
			this.Visible = true;
			this.Focus();
			this.ShowInTaskbar = true;
			this.ActiveControl = this.m_textBoxKeyWord;
		}

		private void GoToTaskPanel()
		{
			this.Hide();
			this.ShowInTaskbar = false;
			this.m_notifyIcon.Visible = true;
			this.m_textBoxKeyWord.Clear();
		}

		bool m_bColse = false;

		private void EverycodeForm_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Escape)
			{
				GoToTaskPanel();
			}
			else if (this.ActiveControl == this.m_splitMainForm &&
				this.m_splitMainForm.ActiveControl == this.m_textBoxKeyWord)
			{
				if (e.KeyCode == Keys.Down)
				{
					this.ActiveControl = this.m_listResult;
				}
			}
		}

	}
}
