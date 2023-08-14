namespace QuanLiQuanCafe
{
	partial class fTableManager
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
			menuStrip1 = new MenuStrip();
			toolStripMenuItem1 = new ToolStripMenuItem();
			adminToolStripMenuItem = new ToolStripMenuItem();
			accountInformationToolStripMenuItem = new ToolStripMenuItem();
			MyAccountToolStripMenuItem = new ToolStripMenuItem();
			logoutToolStripMenuItem1 = new ToolStripMenuItem();
			panel2 = new Panel();
			lvBill = new ListView();
			columnHeader1 = new ColumnHeader();
			columnHeader2 = new ColumnHeader();
			columnHeader3 = new ColumnHeader();
			columnHeader4 = new ColumnHeader();
			columnHeader5 = new ColumnHeader();
			panel3 = new Panel();
			label1 = new Label();
			txtTotalPrice = new TextBox();
			btnCheckOut = new Button();
			panel4 = new Panel();
			nUdAddFood = new NumericUpDown();
			btnAddFood = new Button();
			cbxFood = new ComboBox();
			cbxCategoryFood = new ComboBox();
			flpTable = new FlowLayoutPanel();
			menuStrip1.SuspendLayout();
			panel2.SuspendLayout();
			panel3.SuspendLayout();
			panel4.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)nUdAddFood).BeginInit();
			SuspendLayout();
			// 
			// menuStrip1
			// 
			menuStrip1.ImageScalingSize = new Size(20, 20);
			menuStrip1.Items.AddRange(new ToolStripItem[] { toolStripMenuItem1, adminToolStripMenuItem, accountInformationToolStripMenuItem });
			menuStrip1.Location = new Point(0, 0);
			menuStrip1.Name = "menuStrip1";
			menuStrip1.Size = new Size(936, 28);
			menuStrip1.TabIndex = 1;
			menuStrip1.Text = "menuStrip1";
			// 
			// toolStripMenuItem1
			// 
			toolStripMenuItem1.Name = "toolStripMenuItem1";
			toolStripMenuItem1.Size = new Size(27, 24);
			toolStripMenuItem1.Text = " ";
			// 
			// adminToolStripMenuItem
			// 
			adminToolStripMenuItem.Name = "adminToolStripMenuItem";
			adminToolStripMenuItem.Size = new Size(67, 24);
			adminToolStripMenuItem.Text = "Admin";
			adminToolStripMenuItem.Click += adminToolStripMenuItem_Click;
			// 
			// accountInformationToolStripMenuItem
			// 
			accountInformationToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { MyAccountToolStripMenuItem, logoutToolStripMenuItem1 });
			accountInformationToolStripMenuItem.Name = "accountInformationToolStripMenuItem";
			accountInformationToolStripMenuItem.Size = new Size(159, 24);
			accountInformationToolStripMenuItem.Text = "Account information";
			// 
			// MyAccountToolStripMenuItem
			// 
			MyAccountToolStripMenuItem.Name = "MyAccountToolStripMenuItem";
			MyAccountToolStripMenuItem.Size = new Size(168, 26);
			MyAccountToolStripMenuItem.Text = "My account";
			MyAccountToolStripMenuItem.Click += MyAccountToolStripMenuItem_Click;
			// 
			// logoutToolStripMenuItem1
			// 
			logoutToolStripMenuItem1.Name = "logoutToolStripMenuItem1";
			logoutToolStripMenuItem1.Size = new Size(168, 26);
			logoutToolStripMenuItem1.Text = "Logout";
			logoutToolStripMenuItem1.Click += logoutToolStripMenuItem1_Click;
			// 
			// panel2
			// 
			panel2.Controls.Add(lvBill);
			panel2.Location = new Point(496, 111);
			panel2.Name = "panel2";
			panel2.Size = new Size(428, 329);
			panel2.TabIndex = 1;
			// 
			// lvBill
			// 
			lvBill.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4, columnHeader5 });
			lvBill.GridLines = true;
			lvBill.HideSelection = true;
			lvBill.Location = new Point(4, 3);
			lvBill.Name = "lvBill";
			lvBill.Size = new Size(421, 323);
			lvBill.TabIndex = 0;
			lvBill.UseCompatibleStateImageBehavior = false;
			lvBill.View = View.Details;
			// 
			// columnHeader1
			// 
			columnHeader1.Text = "Food Id";
			// 
			// columnHeader2
			// 
			columnHeader2.Text = "Name";
			columnHeader2.Width = 140;
			// 
			// columnHeader3
			// 
			columnHeader3.Text = "Price";
			// 
			// columnHeader4
			// 
			columnHeader4.Text = "Count";
			// 
			// columnHeader5
			// 
			columnHeader5.Text = "Total Price";
			columnHeader5.Width = 80;
			// 
			// panel3
			// 
			panel3.Controls.Add(label1);
			panel3.Controls.Add(txtTotalPrice);
			panel3.Controls.Add(btnCheckOut);
			panel3.Location = new Point(496, 446);
			panel3.Name = "panel3";
			panel3.Size = new Size(428, 76);
			panel3.TabIndex = 2;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(253, 13);
			label1.Name = "label1";
			label1.Size = new Size(79, 20);
			label1.TabIndex = 9;
			label1.Text = "Total price";
			// 
			// txtTotalPrice
			// 
			txtTotalPrice.Font = new Font("Arial", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
			txtTotalPrice.ForeColor = Color.Red;
			txtTotalPrice.Location = new Point(207, 36);
			txtTotalPrice.Name = "txtTotalPrice";
			txtTotalPrice.ReadOnly = true;
			txtTotalPrice.Size = new Size(125, 28);
			txtTotalPrice.TabIndex = 8;
			txtTotalPrice.Text = "0";
			txtTotalPrice.TextAlign = HorizontalAlignment.Right;
			// 
			// btnCheckOut
			// 
			btnCheckOut.Location = new Point(338, 3);
			btnCheckOut.Name = "btnCheckOut";
			btnCheckOut.Size = new Size(87, 62);
			btnCheckOut.TabIndex = 4;
			btnCheckOut.Text = "Check out";
			btnCheckOut.UseVisualStyleBackColor = true;
			btnCheckOut.Click += btnCheckOut_Click;
			// 
			// panel4
			// 
			panel4.Controls.Add(nUdAddFood);
			panel4.Controls.Add(btnAddFood);
			panel4.Controls.Add(cbxFood);
			panel4.Controls.Add(cbxCategoryFood);
			panel4.Location = new Point(496, 31);
			panel4.Name = "panel4";
			panel4.Size = new Size(428, 74);
			panel4.TabIndex = 3;
			// 
			// nUdAddFood
			// 
			nUdAddFood.Location = new Point(121, 37);
			nUdAddFood.Name = "nUdAddFood";
			nUdAddFood.Size = new Size(53, 27);
			nUdAddFood.TabIndex = 3;
			nUdAddFood.Value = new decimal(new int[] { 1, 0, 0, 0 });
			// 
			// btnAddFood
			// 
			btnAddFood.Location = new Point(22, 37);
			btnAddFood.Name = "btnAddFood";
			btnAddFood.Size = new Size(93, 29);
			btnAddFood.TabIndex = 2;
			btnAddFood.Text = "Add food";
			btnAddFood.UseVisualStyleBackColor = true;
			btnAddFood.Click += btnAddFood_Click;
			// 
			// cbxFood
			// 
			cbxFood.FormattingEnabled = true;
			cbxFood.Location = new Point(192, 3);
			cbxFood.Name = "cbxFood";
			cbxFood.Size = new Size(164, 28);
			cbxFood.TabIndex = 1;
			// 
			// cbxCategoryFood
			// 
			cbxCategoryFood.FormattingEnabled = true;
			cbxCategoryFood.Location = new Point(22, 3);
			cbxCategoryFood.Name = "cbxCategoryFood";
			cbxCategoryFood.Size = new Size(164, 28);
			cbxCategoryFood.TabIndex = 0;
			cbxCategoryFood.SelectedIndexChanged += cbxCategoryFood_SelectedIndexChanged;
			// 
			// flpTable
			// 
			flpTable.AutoScroll = true;
			flpTable.Location = new Point(12, 31);
			flpTable.Name = "flpTable";
			flpTable.Size = new Size(478, 491);
			flpTable.TabIndex = 4;
			// 
			// fTableManager
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(936, 525);
			Controls.Add(flpTable);
			Controls.Add(panel4);
			Controls.Add(panel3);
			Controls.Add(panel2);
			Controls.Add(menuStrip1);
			MainMenuStrip = menuStrip1;
			Name = "fTableManager";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "Table Manager";
			menuStrip1.ResumeLayout(false);
			menuStrip1.PerformLayout();
			panel2.ResumeLayout(false);
			panel3.ResumeLayout(false);
			panel3.PerformLayout();
			panel4.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)nUdAddFood).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion
		private MenuStrip menuStrip1;
		private ToolStripMenuItem toolStripMenuItem1;
		private ToolStripMenuItem adminToolStripMenuItem;
		private ToolStripMenuItem accountInformationToolStripMenuItem;
		private ToolStripMenuItem MyAccountToolStripMenuItem;
		private ToolStripMenuItem logoutToolStripMenuItem1;
		private Panel panel2;
		private ListView lvBill;
		private Panel panel3;
		private Panel panel4;
		private ComboBox cbxFood;
		private ComboBox cbxCategoryFood;
		private NumericUpDown nUdAddFood;
		private Button btnAddFood;
		private FlowLayoutPanel flpTable;
		private Button btnCheckOut;
		private ColumnHeader columnHeader1;
		private ColumnHeader columnHeader2;
		private ColumnHeader columnHeader3;
		private ColumnHeader columnHeader4;
		private ColumnHeader columnHeader5;
		private TextBox txtTotalPrice;
		private Label label1;
	}
}