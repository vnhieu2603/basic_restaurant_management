namespace QuanLiQuanCafe
{
	partial class fAccountProfile
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
			panel2 = new Panel();
			txtUsername = new TextBox();
			label1 = new Label();
			panel1 = new Panel();
			txtDisplayName = new TextBox();
			label2 = new Label();
			panel3 = new Panel();
			txtPassword = new TextBox();
			label3 = new Label();
			panel4 = new Panel();
			txtNewPassword = new TextBox();
			label4 = new Label();
			panel5 = new Panel();
			txtReEnterPassword = new TextBox();
			label5 = new Label();
			btnUpdate = new Button();
			btnExit = new Button();
			panel2.SuspendLayout();
			panel1.SuspendLayout();
			panel3.SuspendLayout();
			panel4.SuspendLayout();
			panel5.SuspendLayout();
			SuspendLayout();
			// 
			// panel2
			// 
			panel2.Controls.Add(txtUsername);
			panel2.Controls.Add(label1);
			panel2.Location = new Point(44, 43);
			panel2.Name = "panel2";
			panel2.Size = new Size(724, 52);
			panel2.TabIndex = 1;
			// 
			// txtUsername
			// 
			txtUsername.Location = new Point(388, 12);
			txtUsername.Name = "txtUsername";
			txtUsername.ReadOnly = true;
			txtUsername.Size = new Size(270, 27);
			txtUsername.TabIndex = 1;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
			label1.Location = new Point(17, 16);
			label1.Name = "label1";
			label1.Size = new Size(108, 23);
			label1.TabIndex = 0;
			label1.Text = "Username";
			// 
			// panel1
			// 
			panel1.Controls.Add(txtDisplayName);
			panel1.Controls.Add(label2);
			panel1.Location = new Point(44, 112);
			panel1.Name = "panel1";
			panel1.Size = new Size(724, 52);
			panel1.TabIndex = 2;
			// 
			// txtDisplayName
			// 
			txtDisplayName.Location = new Point(388, 12);
			txtDisplayName.Name = "txtDisplayName";
			txtDisplayName.Size = new Size(270, 27);
			txtDisplayName.TabIndex = 1;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
			label2.Location = new Point(17, 16);
			label2.Name = "label2";
			label2.Size = new Size(144, 23);
			label2.TabIndex = 0;
			label2.Text = "Display name";
			// 
			// panel3
			// 
			panel3.Controls.Add(txtPassword);
			panel3.Controls.Add(label3);
			panel3.Location = new Point(44, 185);
			panel3.Name = "panel3";
			panel3.Size = new Size(724, 52);
			panel3.TabIndex = 2;
			// 
			// txtPassword
			// 
			txtPassword.Location = new Point(388, 12);
			txtPassword.Name = "txtPassword";
			txtPassword.ReadOnly = true;
			txtPassword.Size = new Size(270, 27);
			txtPassword.TabIndex = 1;
			txtPassword.UseSystemPasswordChar = true;
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
			label3.Location = new Point(17, 16);
			label3.Name = "label3";
			label3.Size = new Size(100, 23);
			label3.TabIndex = 0;
			label3.Text = "Password";
			// 
			// panel4
			// 
			panel4.Controls.Add(txtNewPassword);
			panel4.Controls.Add(label4);
			panel4.Location = new Point(44, 256);
			panel4.Name = "panel4";
			panel4.Size = new Size(724, 52);
			panel4.TabIndex = 2;
			// 
			// txtNewPassword
			// 
			txtNewPassword.Location = new Point(388, 12);
			txtNewPassword.Name = "txtNewPassword";
			txtNewPassword.Size = new Size(270, 27);
			txtNewPassword.TabIndex = 1;
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
			label4.Location = new Point(17, 16);
			label4.Name = "label4";
			label4.Size = new Size(152, 23);
			label4.TabIndex = 0;
			label4.Text = "New password";
			// 
			// panel5
			// 
			panel5.Controls.Add(txtReEnterPassword);
			panel5.Controls.Add(label5);
			panel5.Location = new Point(44, 328);
			panel5.Name = "panel5";
			panel5.Size = new Size(724, 52);
			panel5.TabIndex = 2;
			// 
			// txtReEnterPassword
			// 
			txtReEnterPassword.Location = new Point(388, 12);
			txtReEnterPassword.Name = "txtReEnterPassword";
			txtReEnterPassword.Size = new Size(270, 27);
			txtReEnterPassword.TabIndex = 1;
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
			label5.Location = new Point(17, 16);
			label5.Name = "label5";
			label5.Size = new Size(238, 23);
			label5.TabIndex = 0;
			label5.Text = "Re-enter new password";
			// 
			// btnUpdate
			// 
			btnUpdate.Location = new Point(348, 399);
			btnUpdate.Name = "btnUpdate";
			btnUpdate.Size = new Size(174, 34);
			btnUpdate.TabIndex = 3;
			btnUpdate.Text = "Update";
			btnUpdate.UseVisualStyleBackColor = true;
			btnUpdate.Click += btnUpdate_Click;
			// 
			// btnExit
			// 
			btnExit.Location = new Point(528, 399);
			btnExit.Name = "btnExit";
			btnExit.Size = new Size(174, 34);
			btnExit.TabIndex = 4;
			btnExit.Text = "Exit";
			btnExit.UseVisualStyleBackColor = true;
			btnExit.Click += btnExit_Click;
			// 
			// fAccountProfile
			// 
			AcceptButton = btnUpdate;
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			CancelButton = btnExit;
			ClientSize = new Size(800, 450);
			Controls.Add(btnExit);
			Controls.Add(btnUpdate);
			Controls.Add(panel5);
			Controls.Add(panel4);
			Controls.Add(panel3);
			Controls.Add(panel1);
			Controls.Add(panel2);
			Name = "fAccountProfile";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "fAccountProfile";
			panel2.ResumeLayout(false);
			panel2.PerformLayout();
			panel1.ResumeLayout(false);
			panel1.PerformLayout();
			panel3.ResumeLayout(false);
			panel3.PerformLayout();
			panel4.ResumeLayout(false);
			panel4.PerformLayout();
			panel5.ResumeLayout(false);
			panel5.PerformLayout();
			ResumeLayout(false);
		}

		#endregion

		private Panel panel2;
		private TextBox txtUsername;
		private Label label1;
		private Panel panel1;
		private TextBox txtDisplayName;
		private Label label2;
		private Panel panel3;
		private TextBox txtPassword;
		private Label label3;
		private Panel panel4;
		private TextBox txtNewPassword;
		private Label label4;
		private Panel panel5;
		private TextBox txtReEnterPassword;
		private Label label5;
		private Button btnUpdate;
		private Button btnExit;
	}
}