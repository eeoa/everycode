namespace Everycode
{
	partial class OptionsForm
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
			if (disposing && (components != null))
			{
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
			this.m_buttonOK = new System.Windows.Forms.Button();
			this.m_buttonCancel = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.m_textBoxSSPath = new System.Windows.Forms.TextBox();
			this.m_textBoxUser = new System.Windows.Forms.TextBox();
			this.m_textBoxPassword = new System.Windows.Forms.TextBox();
			this.m_buttonSSPathBrowse = new System.Windows.Forms.Button();
			this.label4 = new System.Windows.Forms.Label();
			this.m_textBoxWorkingFolder = new System.Windows.Forms.TextBox();
			this.m_buttonWorkingFolderBrowse = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// m_buttonOK
			// 
			this.m_buttonOK.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.m_buttonOK.Location = new System.Drawing.Point(51, 113);
			this.m_buttonOK.Name = "m_buttonOK";
			this.m_buttonOK.Size = new System.Drawing.Size(90, 25);
			this.m_buttonOK.TabIndex = 0;
			this.m_buttonOK.Text = "确定";
			this.m_buttonOK.UseVisualStyleBackColor = true;
			this.m_buttonOK.Click += new System.EventHandler(this.m_buttonOK_Click);
			// 
			// m_buttonCancel
			// 
			this.m_buttonCancel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.m_buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.m_buttonCancel.Location = new System.Drawing.Point(203, 113);
			this.m_buttonCancel.Name = "m_buttonCancel";
			this.m_buttonCancel.Size = new System.Drawing.Size(84, 25);
			this.m_buttonCancel.TabIndex = 1;
			this.m_buttonCancel.Text = "放弃";
			this.m_buttonCancel.UseVisualStyleBackColor = true;
			this.m_buttonCancel.Click += new System.EventHandler(this.m_buttonCancel_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(21, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(77, 12);
			this.label1.TabIndex = 2;
			this.label1.Text = "SS数据库路径";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(45, 32);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(53, 12);
			this.label2.TabIndex = 3;
			this.label2.Text = "SS用户名";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(57, 56);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(41, 12);
			this.label3.TabIndex = 4;
			this.label3.Text = "SS密码";
			// 
			// m_textBoxSSPath
			// 
			this.m_textBoxSSPath.Location = new System.Drawing.Point(104, 6);
			this.m_textBoxSSPath.Name = "m_textBoxSSPath";
			this.m_textBoxSSPath.ReadOnly = true;
			this.m_textBoxSSPath.Size = new System.Drawing.Size(174, 21);
			this.m_textBoxSSPath.TabIndex = 5;
			// 
			// m_textBoxUser
			// 
			this.m_textBoxUser.Location = new System.Drawing.Point(104, 29);
			this.m_textBoxUser.Name = "m_textBoxUser";
			this.m_textBoxUser.Size = new System.Drawing.Size(215, 21);
			this.m_textBoxUser.TabIndex = 5;
			// 
			// m_textBoxPassword
			// 
			this.m_textBoxPassword.Location = new System.Drawing.Point(104, 53);
			this.m_textBoxPassword.Name = "m_textBoxPassword";
			this.m_textBoxPassword.Size = new System.Drawing.Size(215, 21);
			this.m_textBoxPassword.TabIndex = 5;
			this.m_textBoxPassword.UseSystemPasswordChar = true;
			// 
			// m_buttonSSPathBrowse
			// 
			this.m_buttonSSPathBrowse.Location = new System.Drawing.Point(284, 6);
			this.m_buttonSSPathBrowse.Name = "m_buttonSSPathBrowse";
			this.m_buttonSSPathBrowse.Size = new System.Drawing.Size(35, 20);
			this.m_buttonSSPathBrowse.TabIndex = 6;
			this.m_buttonSSPathBrowse.Text = "...";
			this.m_buttonSSPathBrowse.UseVisualStyleBackColor = true;
			this.m_buttonSSPathBrowse.Click += new System.EventHandler(this.m_buttonBrowse_Click);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(21, 82);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(77, 12);
			this.label4.TabIndex = 2;
			this.label4.Text = "默认工作路径";
			// 
			// m_textBoxWorkingFolder
			// 
			this.m_textBoxWorkingFolder.Location = new System.Drawing.Point(104, 79);
			this.m_textBoxWorkingFolder.Name = "m_textBoxWorkingFolder";
			this.m_textBoxWorkingFolder.ReadOnly = true;
			this.m_textBoxWorkingFolder.Size = new System.Drawing.Size(174, 21);
			this.m_textBoxWorkingFolder.TabIndex = 5;
			// 
			// m_buttonWorkingFolderBrowse
			// 
			this.m_buttonWorkingFolderBrowse.Location = new System.Drawing.Point(284, 79);
			this.m_buttonWorkingFolderBrowse.Name = "m_buttonWorkingFolderBrowse";
			this.m_buttonWorkingFolderBrowse.Size = new System.Drawing.Size(35, 20);
			this.m_buttonWorkingFolderBrowse.TabIndex = 6;
			this.m_buttonWorkingFolderBrowse.Text = "...";
			this.m_buttonWorkingFolderBrowse.UseVisualStyleBackColor = true;
			this.m_buttonWorkingFolderBrowse.Click += new System.EventHandler(this.m_buttonWorkingFolderBrowse_Click);
			// 
			// OptionsForm
			// 
			this.AcceptButton = this.m_buttonOK;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.m_buttonCancel;
			this.ClientSize = new System.Drawing.Size(346, 147);
			this.Controls.Add(this.m_buttonWorkingFolderBrowse);
			this.Controls.Add(this.m_buttonSSPathBrowse);
			this.Controls.Add(this.m_textBoxPassword);
			this.Controls.Add(this.m_textBoxWorkingFolder);
			this.Controls.Add(this.m_textBoxUser);
			this.Controls.Add(this.m_textBoxSSPath);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.m_buttonCancel);
			this.Controls.Add(this.m_buttonOK);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "OptionsForm";
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "设置";
			this.TopMost = true;
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button m_buttonOK;
		private System.Windows.Forms.Button m_buttonCancel;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox m_textBoxSSPath;
		private System.Windows.Forms.TextBox m_textBoxUser;
		private System.Windows.Forms.TextBox m_textBoxPassword;
		private System.Windows.Forms.Button m_buttonSSPathBrowse;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox m_textBoxWorkingFolder;
		private System.Windows.Forms.Button m_buttonWorkingFolderBrowse;

	}
}