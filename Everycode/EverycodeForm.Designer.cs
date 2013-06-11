namespace Everycode
{
	partial class EverycodeForm
	{
		/// <summary>
		/// 必需的设计器变量。
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// 清理所有正在使用的资源。
		/// </summary>
		/// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows 窗体设计器生成的代码

		/// <summary>
		/// 设计器支持所需的方法 - 不要
		/// 使用代码编辑器修改此方法的内容。
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EverycodeForm));
			this.m_statusStrip = new System.Windows.Forms.StatusStrip();
			this.m_splitMainForm = new System.Windows.Forms.SplitContainer();
			this.m_listVersion = new System.Windows.Forms.ListBox();
			this.m_listResult = new System.Windows.Forms.ListView();
			this.Project = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.SSPath = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.Label = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.m_textBoxKeyWord = new System.Windows.Forms.TextBox();
			this.m_menuStrip = new System.Windows.Forms.MenuStrip();
			this.文件ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.设置ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.退出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.查找ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.帮助ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.关于ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.m_notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
			((System.ComponentModel.ISupportInitialize)(this.m_splitMainForm)).BeginInit();
			this.m_splitMainForm.Panel1.SuspendLayout();
			this.m_splitMainForm.Panel2.SuspendLayout();
			this.m_splitMainForm.SuspendLayout();
			this.m_menuStrip.SuspendLayout();
			this.SuspendLayout();
			// 
			// m_statusStrip
			// 
			this.m_statusStrip.Location = new System.Drawing.Point(0, 478);
			this.m_statusStrip.Name = "m_statusStrip";
			this.m_statusStrip.Size = new System.Drawing.Size(600, 22);
			this.m_statusStrip.TabIndex = 2;
			this.m_statusStrip.Text = "statusStrip1";
			// 
			// m_splitMainForm
			// 
			this.m_splitMainForm.Dock = System.Windows.Forms.DockStyle.Fill;
			this.m_splitMainForm.Location = new System.Drawing.Point(0, 24);
			this.m_splitMainForm.Name = "m_splitMainForm";
			// 
			// m_splitMainForm.Panel1
			// 
			this.m_splitMainForm.Panel1.Controls.Add(this.m_listVersion);
			// 
			// m_splitMainForm.Panel2
			// 
			this.m_splitMainForm.Panel2.Controls.Add(this.m_listResult);
			this.m_splitMainForm.Panel2.Controls.Add(this.m_textBoxKeyWord);
			this.m_splitMainForm.Size = new System.Drawing.Size(600, 454);
			this.m_splitMainForm.SplitterDistance = 199;
			this.m_splitMainForm.TabIndex = 0;
			this.m_splitMainForm.TabStop = false;
			// 
			// m_listVersion
			// 
			this.m_listVersion.Dock = System.Windows.Forms.DockStyle.Fill;
			this.m_listVersion.FormattingEnabled = true;
			this.m_listVersion.IntegralHeight = false;
			this.m_listVersion.ItemHeight = 12;
			this.m_listVersion.Location = new System.Drawing.Point(0, 0);
			this.m_listVersion.Name = "m_listVersion";
			this.m_listVersion.Size = new System.Drawing.Size(199, 454);
			this.m_listVersion.TabIndex = 0;
			// 
			// m_listResult
			// 
			this.m_listResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.m_listResult.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Project,
            this.SSPath,
            this.Label});
			this.m_listResult.Dock = System.Windows.Forms.DockStyle.Fill;
			this.m_listResult.Location = new System.Drawing.Point(0, 21);
			this.m_listResult.Name = "m_listResult";
			this.m_listResult.Size = new System.Drawing.Size(397, 433);
			this.m_listResult.TabIndex = 1;
			this.m_listResult.UseCompatibleStateImageBehavior = false;
			this.m_listResult.View = System.Windows.Forms.View.Details;
			// 
			// Project
			// 
			this.Project.Text = "工程";
			this.Project.Width = 163;
			// 
			// SSPath
			// 
			this.SSPath.Text = "SS路径";
			this.SSPath.Width = 193;
			// 
			// Label
			// 
			this.Label.Text = "Label";
			this.Label.Width = 67;
			// 
			// m_textBoxKeyWord
			// 
			this.m_textBoxKeyWord.Dock = System.Windows.Forms.DockStyle.Top;
			this.m_textBoxKeyWord.ImeMode = System.Windows.Forms.ImeMode.Off;
			this.m_textBoxKeyWord.Location = new System.Drawing.Point(0, 0);
			this.m_textBoxKeyWord.Name = "m_textBoxKeyWord";
			this.m_textBoxKeyWord.Size = new System.Drawing.Size(397, 21);
			this.m_textBoxKeyWord.TabIndex = 0;
			// 
			// m_menuStrip
			// 
			this.m_menuStrip.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.m_menuStrip.ImageScalingSize = new System.Drawing.Size(0, 0);
			this.m_menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.文件ToolStripMenuItem,
            this.查找ToolStripMenuItem,
            this.帮助ToolStripMenuItem});
			this.m_menuStrip.Location = new System.Drawing.Point(0, 0);
			this.m_menuStrip.Name = "m_menuStrip";
			this.m_menuStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
			this.m_menuStrip.Size = new System.Drawing.Size(600, 24);
			this.m_menuStrip.TabIndex = 2;
			this.m_menuStrip.Text = "menuStrip1";
			// 
			// 文件ToolStripMenuItem
			// 
			this.文件ToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.文件ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.设置ToolStripMenuItem,
            this.退出ToolStripMenuItem});
			this.文件ToolStripMenuItem.Name = "文件ToolStripMenuItem";
			this.文件ToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
			this.文件ToolStripMenuItem.Text = "文件(&F)";
			// 
			// 设置ToolStripMenuItem
			// 
			this.设置ToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.设置ToolStripMenuItem.Name = "设置ToolStripMenuItem";
			this.设置ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.设置ToolStripMenuItem.Text = "设置(&O) ";
			this.设置ToolStripMenuItem.Click += new System.EventHandler(this.设置ToolStripMenuItem_Click);
			// 
			// 退出ToolStripMenuItem
			// 
			this.退出ToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.退出ToolStripMenuItem.Name = "退出ToolStripMenuItem";
			this.退出ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.退出ToolStripMenuItem.Text = "退出(&X) ";
			this.退出ToolStripMenuItem.Click += new System.EventHandler(this.退出ToolStripMenuItem_Click);
			// 
			// 查看查找ToolStripMenuItem
			// 
			this.查找ToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.查找ToolStripMenuItem.Name = "查找ToolStripMenuItem";
			this.查找ToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
			this.查找ToolStripMenuItem.Text = "查找(&S) ";
			// 
			// 帮助ToolStripMenuItem
			// 
			this.帮助ToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.帮助ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.关于ToolStripMenuItem});
			this.帮助ToolStripMenuItem.Name = "帮助ToolStripMenuItem";
			this.帮助ToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
			this.帮助ToolStripMenuItem.Text = "帮助(&H) ";
			// 
			// 关于ToolStripMenuItem
			// 
			this.关于ToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.关于ToolStripMenuItem.Name = "关于ToolStripMenuItem";
			this.关于ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.关于ToolStripMenuItem.Text = "关于(&A) ";
			// 
			// m_notifyIcon
			// 
			this.m_notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("m_notifyIcon.Icon")));
			this.m_notifyIcon.Text = "Everycode";
			this.m_notifyIcon.Click += new System.EventHandler(this.m_notifyIcon_Click);
			// 
			// EverycodeForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(600, 500);
			this.Controls.Add(this.m_splitMainForm);
			this.Controls.Add(this.m_statusStrip);
			this.Controls.Add(this.m_menuStrip);
			this.KeyPreview = true;
			this.MainMenuStrip = this.m_menuStrip;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "EverycodeForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Everycode";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.EverycodeForm_FormClosing);
			this.Load += new System.EventHandler(this.EverycodeForm_Load);
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.EverycodeForm_KeyDown);
			this.m_splitMainForm.Panel1.ResumeLayout(false);
			this.m_splitMainForm.Panel2.ResumeLayout(false);
			this.m_splitMainForm.Panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.m_splitMainForm)).EndInit();
			this.m_splitMainForm.ResumeLayout(false);
			this.m_menuStrip.ResumeLayout(false);
			this.m_menuStrip.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.SplitContainer m_splitMainForm;
		private System.Windows.Forms.ListBox m_listVersion;
		private System.Windows.Forms.ListView m_listResult;
		private System.Windows.Forms.TextBox m_textBoxKeyWord;
		private System.Windows.Forms.StatusStrip m_statusStrip;
		private System.Windows.Forms.MenuStrip m_menuStrip;
		private System.Windows.Forms.NotifyIcon m_notifyIcon;

		private System.Windows.Forms.ToolStripMenuItem 文件ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 设置ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 退出ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 查找ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 帮助ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 关于ToolStripMenuItem;
		private System.Windows.Forms.ColumnHeader Project;
		private System.Windows.Forms.ColumnHeader SSPath;
		private System.Windows.Forms.ColumnHeader Label;
	}
}

