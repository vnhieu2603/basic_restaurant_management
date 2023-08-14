namespace QuanLiQuanCafe
{
	partial class fLogin
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
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
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fLogin));
			panel1 = new Panel();
			btnExit = new Button();
			btnLogin = new Button();
			panel3 = new Panel();
			txtPassword = new TextBox();
			label2 = new Label();
			panel2 = new Panel();
			txtUsername = new TextBox();
			label1 = new Label();
			panel1.SuspendLayout();
			panel3.SuspendLayout();
			panel2.SuspendLayout();
			SuspendLayout();
			// 
			// panel1
			// 
			panel1.BackColor = Color.Transparent;
			panel1.Controls.Add(btnExit);
			panel1.Controls.Add(btnLogin);
			panel1.Controls.Add(panel3);
			panel1.Controls.Add(panel2);
			panel1.Location = new Point(233, 55);
			panel1.Name = "panel1";
			panel1.Size = new Size(488, 242);
			panel1.TabIndex = 0;
			// 
			// btnExit
			// 
			btnExit.Location = new Point(193, 153);
			btnExit.Name = "btnExit";
			btnExit.Size = new Size(122, 36);
			btnExit.TabIndex = 4;
			btnExit.Text = "Exit";
			btnExit.UseVisualStyleBackColor = true;
			btnExit.Click += btnExit_Click;
			// 
			// btnLogin
			// 
			btnLogin.Location = new Point(65, 153);
			btnLogin.Name = "btnLogin";
			btnLogin.Size = new Size(122, 36);
			btnLogin.TabIndex = 3;
			btnLogin.Text = "Login";
			btnLogin.UseVisualStyleBackColor = true;
			btnLogin.Click += btnLogin_Click;
			// 
			// panel3
			// 
			panel3.Controls.Add(txtPassword);
			panel3.Controls.Add(label2);
			panel3.Location = new Point(5, 79);
			panel3.Name = "panel3";
			panel3.Size = new Size(477, 52);
			panel3.TabIndex = 2;
			// 
			// txtPassword
			// 
			txtPassword.Location = new Point(184, 12);
			txtPassword.Name = "txtPassword";
			txtPassword.Size = new Size(270, 27);
			txtPassword.TabIndex = 1;
			txtPassword.Text = "123";
			txtPassword.UseSystemPasswordChar = true;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
			label2.ForeColor = SystemColors.ButtonHighlight;
			label2.Location = new Point(17, 16);
			label2.Name = "label2";
			label2.Size = new Size(100, 23);
			label2.TabIndex = 0;
			label2.Text = "Password";
			// 
			// panel2
			// 
			panel2.Controls.Add(txtUsername);
			panel2.Controls.Add(label1);
			panel2.Location = new Point(5, 12);
			panel2.Name = "panel2";
			panel2.Size = new Size(477, 52);
			panel2.TabIndex = 0;
			// 
			// txtUsername
			// 
			txtUsername.Location = new Point(184, 12);
			txtUsername.Name = "txtUsername";
			txtUsername.Size = new Size(270, 27);
			txtUsername.TabIndex = 1;
			txtUsername.Text = "hieuvn";
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
			label1.ForeColor = SystemColors.ButtonHighlight;
			label1.Location = new Point(17, 16);
			label1.Name = "label1";
			label1.Size = new Size(108, 23);
			label1.TabIndex = 0;
			label1.Text = "Username";
			// 
			// fLogin
			// 
			AcceptButton = btnLogin;
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.White;
			BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
			BackgroundImageLayout = ImageLayout.Stretch;
			CancelButton = btnExit;
			ClientSize = new Size(733, 337);
			Controls.Add(panel1);
			Name = "fLogin";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "Login";
			FormClosing += fLogin_FormClosing;
			panel1.ResumeLayout(false);
			panel3.ResumeLayout(false);
			panel3.PerformLayout();
			panel2.ResumeLayout(false);
			panel2.PerformLayout();
			ResumeLayout(false);
		}

		#endregion

		private Panel panel1;
		private Panel panel2;
		private Label label1;
		private Panel panel3;
		private TextBox txtPassword;
		private Label label2;
		private TextBox txtUsername;
		private Button btnExit;
		private Button btnLogin;
	}
}