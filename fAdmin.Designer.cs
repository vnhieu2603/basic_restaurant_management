namespace QuanLiQuanCafe
{
	partial class fAdmin
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
			tcAdmin = new TabControl();
			tpBill = new TabPage();
			panel4 = new Panel();
			txtBillPrice = new TextBox();
			label14 = new Label();
			lvBillInfoAdmin = new ListView();
			columnHeader1 = new ColumnHeader();
			columnHeader2 = new ColumnHeader();
			columnHeader3 = new ColumnHeader();
			columnHeader4 = new ColumnHeader();
			dgvRevenue = new DataGridView();
			panel3 = new Panel();
			label10 = new Label();
			btnYearRevenue = new Button();
			btnWeekRevenue = new Button();
			btnTodayRevenue = new Button();
			btnShowRevenue = new Button();
			dateTimePicker1 = new DateTimePicker();
			dateTimePicker2 = new DateTimePicker();
			tpFood = new TabPage();
			panel6 = new Panel();
			txtSearchFood = new TextBox();
			btnSearchFood = new Button();
			panel5 = new Panel();
			panel10 = new Panel();
			nUDfoodPrice = new NumericUpDown();
			label4 = new Label();
			panel9 = new Panel();
			cbxCategory = new ComboBox();
			label3 = new Label();
			panel8 = new Panel();
			txtFoodName = new TextBox();
			textBox2 = new TextBox();
			label2 = new Label();
			panel7 = new Panel();
			txtFoodID = new TextBox();
			txtUsername = new TextBox();
			label1 = new Label();
			panel2 = new Panel();
			btnShowFood = new Button();
			btnUpdateFood = new Button();
			btnDeleteFood = new Button();
			btnAddFood = new Button();
			panel1 = new Panel();
			dgvFood = new DataGridView();
			tpCategory = new TabPage();
			panel12 = new Panel();
			panel15 = new Panel();
			txtCategoryName = new TextBox();
			textBox4 = new TextBox();
			label7 = new Label();
			panel16 = new Panel();
			txtCategoryId = new TextBox();
			textBox6 = new TextBox();
			label8 = new Label();
			panel17 = new Panel();
			btnUpdateCategory = new Button();
			btnAddCategory = new Button();
			panel18 = new Panel();
			dgvCategory = new DataGridView();
			tpTable = new TabPage();
			panel11 = new Panel();
			panel21 = new Panel();
			txtTableStatus = new TextBox();
			label9 = new Label();
			panel13 = new Panel();
			txtTableName = new TextBox();
			textBox3 = new TextBox();
			label5 = new Label();
			panel14 = new Panel();
			txtTableId = new TextBox();
			textBox7 = new TextBox();
			label6 = new Label();
			panel19 = new Panel();
			txtUpdateTable = new Button();
			txtDeleteTable = new Button();
			txtAddTable = new Button();
			panel20 = new Panel();
			dgvTable = new DataGridView();
			tpAccount = new TabPage();
			panel23 = new Panel();
			panel22 = new Panel();
			cbxUserType = new ComboBox();
			label15 = new Label();
			panel26 = new Panel();
			txtAccountDisplayName = new TextBox();
			textBox8 = new TextBox();
			label12 = new Label();
			panel27 = new Panel();
			txtAccountUsername = new TextBox();
			textBox10 = new TextBox();
			label13 = new Label();
			panel28 = new Panel();
			btnUpdateAccount = new Button();
			btnDeleteAccount = new Button();
			btnAddAccount = new Button();
			panel29 = new Panel();
			dgvAccount = new DataGridView();
			tcAdmin.SuspendLayout();
			tpBill.SuspendLayout();
			panel4.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)dgvRevenue).BeginInit();
			panel3.SuspendLayout();
			tpFood.SuspendLayout();
			panel6.SuspendLayout();
			panel5.SuspendLayout();
			panel10.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)nUDfoodPrice).BeginInit();
			panel9.SuspendLayout();
			panel8.SuspendLayout();
			panel7.SuspendLayout();
			panel2.SuspendLayout();
			panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)dgvFood).BeginInit();
			tpCategory.SuspendLayout();
			panel12.SuspendLayout();
			panel15.SuspendLayout();
			panel16.SuspendLayout();
			panel17.SuspendLayout();
			panel18.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)dgvCategory).BeginInit();
			tpTable.SuspendLayout();
			panel11.SuspendLayout();
			panel21.SuspendLayout();
			panel13.SuspendLayout();
			panel14.SuspendLayout();
			panel19.SuspendLayout();
			panel20.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)dgvTable).BeginInit();
			tpAccount.SuspendLayout();
			panel23.SuspendLayout();
			panel22.SuspendLayout();
			panel26.SuspendLayout();
			panel27.SuspendLayout();
			panel28.SuspendLayout();
			panel29.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)dgvAccount).BeginInit();
			SuspendLayout();
			// 
			// tcAdmin
			// 
			tcAdmin.Controls.Add(tpBill);
			tcAdmin.Controls.Add(tpFood);
			tcAdmin.Controls.Add(tpCategory);
			tcAdmin.Controls.Add(tpTable);
			tcAdmin.Controls.Add(tpAccount);
			tcAdmin.Location = new Point(30, 33);
			tcAdmin.Name = "tcAdmin";
			tcAdmin.SelectedIndex = 0;
			tcAdmin.Size = new Size(1035, 510);
			tcAdmin.TabIndex = 0;
			// 
			// tpBill
			// 
			tpBill.Controls.Add(panel4);
			tpBill.Controls.Add(panel3);
			tpBill.Location = new Point(4, 29);
			tpBill.Name = "tpBill";
			tpBill.Padding = new Padding(3);
			tpBill.Size = new Size(1027, 477);
			tpBill.TabIndex = 0;
			tpBill.Text = "Revenue";
			tpBill.UseVisualStyleBackColor = true;
			// 
			// panel4
			// 
			panel4.Controls.Add(txtBillPrice);
			panel4.Controls.Add(label14);
			panel4.Controls.Add(lvBillInfoAdmin);
			panel4.Controls.Add(dgvRevenue);
			panel4.Location = new Point(9, 51);
			panel4.Name = "panel4";
			panel4.Size = new Size(1012, 402);
			panel4.TabIndex = 3;
			// 
			// txtBillPrice
			// 
			txtBillPrice.Location = new Point(848, 347);
			txtBillPrice.Name = "txtBillPrice";
			txtBillPrice.ReadOnly = true;
			txtBillPrice.Size = new Size(155, 27);
			txtBillPrice.TabIndex = 2;
			// 
			// label14
			// 
			label14.AutoSize = true;
			label14.Font = new Font("Century Gothic", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
			label14.Location = new Point(731, 349);
			label14.Name = "label14";
			label14.Size = new Size(111, 23);
			label14.TabIndex = 1;
			label14.Text = "Total price";
			// 
			// lvBillInfoAdmin
			// 
			lvBillInfoAdmin.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4 });
			lvBillInfoAdmin.GridLines = true;
			lvBillInfoAdmin.HideSelection = true;
			lvBillInfoAdmin.Location = new Point(595, 3);
			lvBillInfoAdmin.Name = "lvBillInfoAdmin";
			lvBillInfoAdmin.Size = new Size(408, 323);
			lvBillInfoAdmin.TabIndex = 0;
			lvBillInfoAdmin.UseCompatibleStateImageBehavior = false;
			lvBillInfoAdmin.View = View.Details;
			// 
			// columnHeader1
			// 
			columnHeader1.Text = "Name";
			columnHeader1.Width = 200;
			// 
			// columnHeader2
			// 
			columnHeader2.Text = "Count";
			// 
			// columnHeader3
			// 
			columnHeader3.Text = "Price";
			// 
			// columnHeader4
			// 
			columnHeader4.Text = "Total Price";
			columnHeader4.Width = 100;
			// 
			// dgvRevenue
			// 
			dgvRevenue.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dgvRevenue.Location = new Point(3, 3);
			dgvRevenue.Name = "dgvRevenue";
			dgvRevenue.RowHeadersWidth = 51;
			dgvRevenue.RowTemplate.Height = 29;
			dgvRevenue.Size = new Size(586, 396);
			dgvRevenue.TabIndex = 0;
			dgvRevenue.CellClick += dgvRevenue_CellClick;
			// 
			// panel3
			// 
			panel3.Controls.Add(label10);
			panel3.Controls.Add(btnYearRevenue);
			panel3.Controls.Add(btnWeekRevenue);
			panel3.Controls.Add(btnTodayRevenue);
			panel3.Controls.Add(btnShowRevenue);
			panel3.Controls.Add(dateTimePicker1);
			panel3.Controls.Add(dateTimePicker2);
			panel3.Location = new Point(6, 6);
			panel3.Name = "panel3";
			panel3.Size = new Size(1015, 39);
			panel3.TabIndex = 2;
			// 
			// label10
			// 
			label10.AutoSize = true;
			label10.Location = new Point(513, 12);
			label10.Name = "label10";
			label10.Size = new Size(72, 20);
			label10.TabIndex = 6;
			label10.Text = "Show by: ";
			// 
			// btnYearRevenue
			// 
			btnYearRevenue.Location = new Point(791, 7);
			btnYearRevenue.Name = "btnYearRevenue";
			btnYearRevenue.Size = new Size(94, 29);
			btnYearRevenue.TabIndex = 5;
			btnYearRevenue.Text = "Year";
			btnYearRevenue.UseVisualStyleBackColor = true;
			btnYearRevenue.Click += btnYearRevenue_Click;
			// 
			// btnWeekRevenue
			// 
			btnWeekRevenue.Location = new Point(691, 7);
			btnWeekRevenue.Name = "btnWeekRevenue";
			btnWeekRevenue.Size = new Size(94, 29);
			btnWeekRevenue.TabIndex = 4;
			btnWeekRevenue.Text = "Week";
			btnWeekRevenue.UseVisualStyleBackColor = true;
			btnWeekRevenue.Click += btnWeekRevenue_Click;
			// 
			// btnTodayRevenue
			// 
			btnTodayRevenue.Location = new Point(591, 7);
			btnTodayRevenue.Name = "btnTodayRevenue";
			btnTodayRevenue.Size = new Size(94, 29);
			btnTodayRevenue.TabIndex = 3;
			btnTodayRevenue.Text = "Today";
			btnTodayRevenue.UseVisualStyleBackColor = true;
			btnTodayRevenue.Click += btnTodayRevenue_Click;
			// 
			// btnShowRevenue
			// 
			btnShowRevenue.Location = new Point(285, 5);
			btnShowRevenue.Name = "btnShowRevenue";
			btnShowRevenue.Size = new Size(94, 29);
			btnShowRevenue.TabIndex = 2;
			btnShowRevenue.Text = "Show";
			btnShowRevenue.UseVisualStyleBackColor = true;
			btnShowRevenue.Click += btnShowRevenue_Click;
			// 
			// dateTimePicker1
			// 
			dateTimePicker1.Format = DateTimePickerFormat.Short;
			dateTimePicker1.Location = new Point(6, 7);
			dateTimePicker1.Name = "dateTimePicker1";
			dateTimePicker1.Size = new Size(131, 27);
			dateTimePicker1.TabIndex = 1;
			dateTimePicker1.Value = new DateTime(2023, 6, 1, 0, 0, 0, 0);
			// 
			// dateTimePicker2
			// 
			dateTimePicker2.Format = DateTimePickerFormat.Short;
			dateTimePicker2.Location = new Point(143, 7);
			dateTimePicker2.Name = "dateTimePicker2";
			dateTimePicker2.Size = new Size(121, 27);
			dateTimePicker2.TabIndex = 0;
			// 
			// tpFood
			// 
			tpFood.Controls.Add(panel6);
			tpFood.Controls.Add(panel5);
			tpFood.Controls.Add(panel2);
			tpFood.Controls.Add(panel1);
			tpFood.Location = new Point(4, 29);
			tpFood.Name = "tpFood";
			tpFood.Padding = new Padding(3);
			tpFood.Size = new Size(1027, 477);
			tpFood.TabIndex = 1;
			tpFood.Text = "Food";
			tpFood.UseVisualStyleBackColor = true;
			// 
			// panel6
			// 
			panel6.Controls.Add(txtSearchFood);
			panel6.Controls.Add(btnSearchFood);
			panel6.Location = new Point(579, 19);
			panel6.Name = "panel6";
			panel6.Size = new Size(356, 67);
			panel6.TabIndex = 2;
			// 
			// txtSearchFood
			// 
			txtSearchFood.Location = new Point(16, 21);
			txtSearchFood.Name = "txtSearchFood";
			txtSearchFood.Size = new Size(245, 27);
			txtSearchFood.TabIndex = 5;
			// 
			// btnSearchFood
			// 
			btnSearchFood.Location = new Point(267, 21);
			btnSearchFood.Name = "btnSearchFood";
			btnSearchFood.Size = new Size(86, 27);
			btnSearchFood.TabIndex = 4;
			btnSearchFood.Text = "Search";
			btnSearchFood.UseVisualStyleBackColor = true;
			btnSearchFood.Click += btnSearchFood_Click;
			// 
			// panel5
			// 
			panel5.Controls.Add(panel10);
			panel5.Controls.Add(panel9);
			panel5.Controls.Add(panel8);
			panel5.Controls.Add(panel7);
			panel5.Location = new Point(579, 92);
			panel5.Name = "panel5";
			panel5.Size = new Size(356, 377);
			panel5.TabIndex = 1;
			// 
			// panel10
			// 
			panel10.Controls.Add(nUDfoodPrice);
			panel10.Controls.Add(label4);
			panel10.Location = new Point(3, 166);
			panel10.Name = "panel10";
			panel10.Size = new Size(350, 46);
			panel10.TabIndex = 8;
			// 
			// nUDfoodPrice
			// 
			nUDfoodPrice.Location = new Point(111, 12);
			nUDfoodPrice.Maximum = new decimal(new int[] { 10000000, 0, 0, 0 });
			nUDfoodPrice.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
			nUDfoodPrice.Name = "nUDfoodPrice";
			nUDfoodPrice.Size = new Size(231, 27);
			nUDfoodPrice.TabIndex = 1;
			nUDfoodPrice.Value = new decimal(new int[] { 1, 0, 0, 0 });
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
			label4.Location = new Point(3, 12);
			label4.Name = "label4";
			label4.Size = new Size(58, 23);
			label4.TabIndex = 0;
			label4.Text = "Price";
			// 
			// panel9
			// 
			panel9.Controls.Add(cbxCategory);
			panel9.Controls.Add(label3);
			panel9.Location = new Point(3, 114);
			panel9.Name = "panel9";
			panel9.Size = new Size(350, 46);
			panel9.TabIndex = 8;
			// 
			// cbxCategory
			// 
			cbxCategory.FormattingEnabled = true;
			cbxCategory.Location = new Point(111, 7);
			cbxCategory.Name = "cbxCategory";
			cbxCategory.Size = new Size(231, 28);
			cbxCategory.TabIndex = 1;
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
			label3.Location = new Point(3, 12);
			label3.Name = "label3";
			label3.Size = new Size(102, 23);
			label3.TabIndex = 0;
			label3.Text = "Category";
			// 
			// panel8
			// 
			panel8.Controls.Add(txtFoodName);
			panel8.Controls.Add(textBox2);
			panel8.Controls.Add(label2);
			panel8.Location = new Point(3, 62);
			panel8.Name = "panel8";
			panel8.Size = new Size(350, 46);
			panel8.TabIndex = 7;
			// 
			// txtFoodName
			// 
			txtFoodName.Location = new Point(111, 8);
			txtFoodName.Name = "txtFoodName";
			txtFoodName.Size = new Size(231, 27);
			txtFoodName.TabIndex = 6;
			// 
			// textBox2
			// 
			textBox2.Location = new Point(388, 12);
			textBox2.Name = "textBox2";
			textBox2.Size = new Size(270, 27);
			textBox2.TabIndex = 1;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
			label2.Location = new Point(3, 12);
			label2.Name = "label2";
			label2.Size = new Size(70, 23);
			label2.TabIndex = 0;
			label2.Text = "Name";
			// 
			// panel7
			// 
			panel7.Controls.Add(txtFoodID);
			panel7.Controls.Add(txtUsername);
			panel7.Controls.Add(label1);
			panel7.Location = new Point(3, 10);
			panel7.Name = "panel7";
			panel7.Size = new Size(350, 46);
			panel7.TabIndex = 6;
			// 
			// txtFoodID
			// 
			txtFoodID.Location = new Point(111, 8);
			txtFoodID.Name = "txtFoodID";
			txtFoodID.ReadOnly = true;
			txtFoodID.Size = new Size(231, 27);
			txtFoodID.TabIndex = 6;
			// 
			// txtUsername
			// 
			txtUsername.Location = new Point(388, 12);
			txtUsername.Name = "txtUsername";
			txtUsername.Size = new Size(270, 27);
			txtUsername.TabIndex = 1;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
			label1.Location = new Point(3, 12);
			label1.Name = "label1";
			label1.Size = new Size(29, 23);
			label1.TabIndex = 0;
			label1.Text = "Id";
			// 
			// panel2
			// 
			panel2.Controls.Add(btnShowFood);
			panel2.Controls.Add(btnUpdateFood);
			panel2.Controls.Add(btnDeleteFood);
			panel2.Controls.Add(btnAddFood);
			panel2.Location = new Point(22, 19);
			panel2.Name = "panel2";
			panel2.Size = new Size(531, 67);
			panel2.TabIndex = 1;
			// 
			// btnShowFood
			// 
			btnShowFood.Location = new Point(406, 10);
			btnShowFood.Name = "btnShowFood";
			btnShowFood.Size = new Size(96, 48);
			btnShowFood.TabIndex = 3;
			btnShowFood.Text = "Show all";
			btnShowFood.UseVisualStyleBackColor = true;
			btnShowFood.Click += btnShowFood_Click;
			// 
			// btnUpdateFood
			// 
			btnUpdateFood.Location = new Point(284, 10);
			btnUpdateFood.Name = "btnUpdateFood";
			btnUpdateFood.Size = new Size(93, 48);
			btnUpdateFood.TabIndex = 2;
			btnUpdateFood.Text = "Update";
			btnUpdateFood.UseVisualStyleBackColor = true;
			btnUpdateFood.Click += btnUpdateFood_Click;
			// 
			// btnDeleteFood
			// 
			btnDeleteFood.Location = new Point(147, 10);
			btnDeleteFood.Name = "btnDeleteFood";
			btnDeleteFood.Size = new Size(97, 48);
			btnDeleteFood.TabIndex = 1;
			btnDeleteFood.Text = "Delete";
			btnDeleteFood.UseVisualStyleBackColor = true;
			btnDeleteFood.Click += btnDeleteFood_Click;
			// 
			// btnAddFood
			// 
			btnAddFood.Location = new Point(15, 10);
			btnAddFood.Name = "btnAddFood";
			btnAddFood.Size = new Size(98, 48);
			btnAddFood.TabIndex = 0;
			btnAddFood.Text = "Add";
			btnAddFood.UseVisualStyleBackColor = true;
			btnAddFood.Click += btnAddFood_Click;
			// 
			// panel1
			// 
			panel1.Controls.Add(dgvFood);
			panel1.Location = new Point(22, 92);
			panel1.Name = "panel1";
			panel1.Size = new Size(531, 377);
			panel1.TabIndex = 0;
			// 
			// dgvFood
			// 
			dgvFood.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dgvFood.Location = new Point(10, 10);
			dgvFood.Name = "dgvFood";
			dgvFood.RowHeadersWidth = 51;
			dgvFood.RowTemplate.Height = 29;
			dgvFood.Size = new Size(506, 360);
			dgvFood.TabIndex = 0;
			dgvFood.CellClick += dgvFood_CellClick;
			// 
			// tpCategory
			// 
			tpCategory.Controls.Add(panel12);
			tpCategory.Controls.Add(panel17);
			tpCategory.Controls.Add(panel18);
			tpCategory.Location = new Point(4, 29);
			tpCategory.Name = "tpCategory";
			tpCategory.Padding = new Padding(3);
			tpCategory.Size = new Size(1027, 477);
			tpCategory.TabIndex = 2;
			tpCategory.Text = "Category";
			tpCategory.UseVisualStyleBackColor = true;
			// 
			// panel12
			// 
			panel12.Controls.Add(panel15);
			panel12.Controls.Add(panel16);
			panel12.Location = new Point(580, 86);
			panel12.Name = "panel12";
			panel12.Size = new Size(356, 377);
			panel12.TabIndex = 4;
			// 
			// panel15
			// 
			panel15.Controls.Add(txtCategoryName);
			panel15.Controls.Add(textBox4);
			panel15.Controls.Add(label7);
			panel15.Location = new Point(3, 62);
			panel15.Name = "panel15";
			panel15.Size = new Size(350, 46);
			panel15.TabIndex = 7;
			// 
			// txtCategoryName
			// 
			txtCategoryName.Location = new Point(111, 8);
			txtCategoryName.Name = "txtCategoryName";
			txtCategoryName.Size = new Size(231, 27);
			txtCategoryName.TabIndex = 6;
			// 
			// textBox4
			// 
			textBox4.Location = new Point(388, 12);
			textBox4.Name = "textBox4";
			textBox4.Size = new Size(270, 27);
			textBox4.TabIndex = 1;
			// 
			// label7
			// 
			label7.AutoSize = true;
			label7.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
			label7.Location = new Point(3, 12);
			label7.Name = "label7";
			label7.Size = new Size(70, 23);
			label7.TabIndex = 0;
			label7.Text = "Name";
			// 
			// panel16
			// 
			panel16.Controls.Add(txtCategoryId);
			panel16.Controls.Add(textBox6);
			panel16.Controls.Add(label8);
			panel16.Location = new Point(3, 10);
			panel16.Name = "panel16";
			panel16.Size = new Size(350, 46);
			panel16.TabIndex = 6;
			// 
			// txtCategoryId
			// 
			txtCategoryId.Location = new Point(111, 8);
			txtCategoryId.Name = "txtCategoryId";
			txtCategoryId.ReadOnly = true;
			txtCategoryId.Size = new Size(231, 27);
			txtCategoryId.TabIndex = 6;
			// 
			// textBox6
			// 
			textBox6.Location = new Point(388, 12);
			textBox6.Name = "textBox6";
			textBox6.Size = new Size(270, 27);
			textBox6.TabIndex = 1;
			// 
			// label8
			// 
			label8.AutoSize = true;
			label8.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
			label8.Location = new Point(3, 12);
			label8.Name = "label8";
			label8.Size = new Size(29, 23);
			label8.TabIndex = 0;
			label8.Text = "Id";
			// 
			// panel17
			// 
			panel17.Controls.Add(btnUpdateCategory);
			panel17.Controls.Add(btnAddCategory);
			panel17.Location = new Point(14, 13);
			panel17.Name = "panel17";
			panel17.Size = new Size(533, 67);
			panel17.TabIndex = 5;
			// 
			// btnUpdateCategory
			// 
			btnUpdateCategory.Location = new Point(438, 10);
			btnUpdateCategory.Name = "btnUpdateCategory";
			btnUpdateCategory.Size = new Size(73, 48);
			btnUpdateCategory.TabIndex = 2;
			btnUpdateCategory.Text = "Update";
			btnUpdateCategory.UseVisualStyleBackColor = true;
			btnUpdateCategory.Click += btnUpdateCategory_Click;
			// 
			// btnAddCategory
			// 
			btnAddCategory.Location = new Point(15, 10);
			btnAddCategory.Name = "btnAddCategory";
			btnAddCategory.Size = new Size(73, 48);
			btnAddCategory.TabIndex = 0;
			btnAddCategory.Text = "Add";
			btnAddCategory.UseVisualStyleBackColor = true;
			btnAddCategory.Click += btnAddCategory_Click;
			// 
			// panel18
			// 
			panel18.Controls.Add(dgvCategory);
			panel18.Location = new Point(14, 86);
			panel18.Name = "panel18";
			panel18.Size = new Size(533, 377);
			panel18.TabIndex = 3;
			// 
			// dgvCategory
			// 
			dgvCategory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dgvCategory.Location = new Point(10, 10);
			dgvCategory.Name = "dgvCategory";
			dgvCategory.RowHeadersWidth = 51;
			dgvCategory.RowTemplate.Height = 29;
			dgvCategory.Size = new Size(501, 360);
			dgvCategory.TabIndex = 0;
			dgvCategory.CellClick += dgvCategory_CellClick;
			// 
			// tpTable
			// 
			tpTable.Controls.Add(panel11);
			tpTable.Controls.Add(panel19);
			tpTable.Controls.Add(panel20);
			tpTable.Location = new Point(4, 29);
			tpTable.Name = "tpTable";
			tpTable.Padding = new Padding(3);
			tpTable.Size = new Size(1027, 477);
			tpTable.TabIndex = 3;
			tpTable.Text = "Table";
			tpTable.UseVisualStyleBackColor = true;
			// 
			// panel11
			// 
			panel11.Controls.Add(panel21);
			panel11.Controls.Add(panel13);
			panel11.Controls.Add(panel14);
			panel11.Location = new Point(603, 86);
			panel11.Name = "panel11";
			panel11.Size = new Size(356, 377);
			panel11.TabIndex = 7;
			// 
			// panel21
			// 
			panel21.Controls.Add(txtTableStatus);
			panel21.Controls.Add(label9);
			panel21.Location = new Point(3, 114);
			panel21.Name = "panel21";
			panel21.Size = new Size(350, 46);
			panel21.TabIndex = 8;
			// 
			// txtTableStatus
			// 
			txtTableStatus.Location = new Point(111, 8);
			txtTableStatus.Name = "txtTableStatus";
			txtTableStatus.ReadOnly = true;
			txtTableStatus.Size = new Size(231, 27);
			txtTableStatus.TabIndex = 7;
			// 
			// label9
			// 
			label9.AutoSize = true;
			label9.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
			label9.Location = new Point(3, 12);
			label9.Name = "label9";
			label9.Size = new Size(66, 23);
			label9.TabIndex = 0;
			label9.Text = "Status";
			// 
			// panel13
			// 
			panel13.Controls.Add(txtTableName);
			panel13.Controls.Add(textBox3);
			panel13.Controls.Add(label5);
			panel13.Location = new Point(3, 62);
			panel13.Name = "panel13";
			panel13.Size = new Size(350, 46);
			panel13.TabIndex = 7;
			// 
			// txtTableName
			// 
			txtTableName.Location = new Point(111, 8);
			txtTableName.Name = "txtTableName";
			txtTableName.Size = new Size(231, 27);
			txtTableName.TabIndex = 6;
			// 
			// textBox3
			// 
			textBox3.Location = new Point(388, 12);
			textBox3.Name = "textBox3";
			textBox3.Size = new Size(270, 27);
			textBox3.TabIndex = 1;
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
			label5.Location = new Point(3, 12);
			label5.Name = "label5";
			label5.Size = new Size(70, 23);
			label5.TabIndex = 0;
			label5.Text = "Name";
			// 
			// panel14
			// 
			panel14.Controls.Add(txtTableId);
			panel14.Controls.Add(textBox7);
			panel14.Controls.Add(label6);
			panel14.Location = new Point(3, 10);
			panel14.Name = "panel14";
			panel14.Size = new Size(350, 46);
			panel14.TabIndex = 6;
			// 
			// txtTableId
			// 
			txtTableId.Location = new Point(111, 8);
			txtTableId.Name = "txtTableId";
			txtTableId.ReadOnly = true;
			txtTableId.Size = new Size(231, 27);
			txtTableId.TabIndex = 6;
			// 
			// textBox7
			// 
			textBox7.Location = new Point(388, 12);
			textBox7.Name = "textBox7";
			textBox7.Size = new Size(270, 27);
			textBox7.TabIndex = 1;
			// 
			// label6
			// 
			label6.AutoSize = true;
			label6.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
			label6.Location = new Point(3, 12);
			label6.Name = "label6";
			label6.Size = new Size(29, 23);
			label6.TabIndex = 0;
			label6.Text = "Id";
			// 
			// panel19
			// 
			panel19.Controls.Add(txtUpdateTable);
			panel19.Controls.Add(txtDeleteTable);
			panel19.Controls.Add(txtAddTable);
			panel19.Location = new Point(14, 13);
			panel19.Name = "panel19";
			panel19.Size = new Size(514, 67);
			panel19.TabIndex = 8;
			// 
			// txtUpdateTable
			// 
			txtUpdateTable.Location = new Point(418, 10);
			txtUpdateTable.Name = "txtUpdateTable";
			txtUpdateTable.Size = new Size(93, 48);
			txtUpdateTable.TabIndex = 2;
			txtUpdateTable.Text = "Update";
			txtUpdateTable.UseVisualStyleBackColor = true;
			txtUpdateTable.Click += txtUpdateTable_Click;
			// 
			// txtDeleteTable
			// 
			txtDeleteTable.Location = new Point(207, 10);
			txtDeleteTable.Name = "txtDeleteTable";
			txtDeleteTable.Size = new Size(111, 48);
			txtDeleteTable.TabIndex = 1;
			txtDeleteTable.Text = "Delete";
			txtDeleteTable.UseVisualStyleBackColor = true;
			txtDeleteTable.Click += txtDeleteTable_Click;
			// 
			// txtAddTable
			// 
			txtAddTable.Location = new Point(15, 10);
			txtAddTable.Name = "txtAddTable";
			txtAddTable.Size = new Size(97, 48);
			txtAddTable.TabIndex = 0;
			txtAddTable.Text = "Add";
			txtAddTable.UseVisualStyleBackColor = true;
			txtAddTable.Click += txtAddTable_Click;
			// 
			// panel20
			// 
			panel20.Controls.Add(dgvTable);
			panel20.Location = new Point(14, 86);
			panel20.Name = "panel20";
			panel20.Size = new Size(535, 377);
			panel20.TabIndex = 6;
			// 
			// dgvTable
			// 
			dgvTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dgvTable.Location = new Point(10, 10);
			dgvTable.Name = "dgvTable";
			dgvTable.RowHeadersWidth = 51;
			dgvTable.RowTemplate.Height = 29;
			dgvTable.Size = new Size(504, 360);
			dgvTable.TabIndex = 0;
			dgvTable.CellClick += dgvTable_CellClick;
			// 
			// tpAccount
			// 
			tpAccount.Controls.Add(panel23);
			tpAccount.Controls.Add(panel28);
			tpAccount.Controls.Add(panel29);
			tpAccount.Location = new Point(4, 29);
			tpAccount.Name = "tpAccount";
			tpAccount.Padding = new Padding(3);
			tpAccount.Size = new Size(1027, 477);
			tpAccount.TabIndex = 4;
			tpAccount.Text = "Account";
			tpAccount.UseVisualStyleBackColor = true;
			// 
			// panel23
			// 
			panel23.Controls.Add(panel22);
			panel23.Controls.Add(panel26);
			panel23.Controls.Add(panel27);
			panel23.Location = new Point(578, 86);
			panel23.Name = "panel23";
			panel23.Size = new Size(356, 377);
			panel23.TabIndex = 4;
			// 
			// panel22
			// 
			panel22.Controls.Add(cbxUserType);
			panel22.Controls.Add(label15);
			panel22.Location = new Point(6, 129);
			panel22.Name = "panel22";
			panel22.Size = new Size(350, 46);
			panel22.TabIndex = 9;
			// 
			// cbxUserType
			// 
			cbxUserType.FormattingEnabled = true;
			cbxUserType.Location = new Point(144, 10);
			cbxUserType.Name = "cbxUserType";
			cbxUserType.Size = new Size(199, 28);
			cbxUserType.TabIndex = 1;
			// 
			// label15
			// 
			label15.AutoSize = true;
			label15.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
			label15.Location = new Point(3, 12);
			label15.Name = "label15";
			label15.Size = new Size(56, 23);
			label15.TabIndex = 0;
			label15.Text = "Type";
			// 
			// panel26
			// 
			panel26.Controls.Add(txtAccountDisplayName);
			panel26.Controls.Add(textBox8);
			panel26.Controls.Add(label12);
			panel26.Location = new Point(6, 77);
			panel26.Name = "panel26";
			panel26.Size = new Size(350, 46);
			panel26.TabIndex = 7;
			// 
			// txtAccountDisplayName
			// 
			txtAccountDisplayName.Location = new Point(145, 8);
			txtAccountDisplayName.Name = "txtAccountDisplayName";
			txtAccountDisplayName.Size = new Size(197, 27);
			txtAccountDisplayName.TabIndex = 6;
			// 
			// textBox8
			// 
			textBox8.Location = new Point(388, 12);
			textBox8.Name = "textBox8";
			textBox8.Size = new Size(270, 27);
			textBox8.TabIndex = 1;
			// 
			// label12
			// 
			label12.AutoSize = true;
			label12.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
			label12.Location = new Point(3, 12);
			label12.Name = "label12";
			label12.Size = new Size(144, 23);
			label12.TabIndex = 0;
			label12.Text = "Display name";
			// 
			// panel27
			// 
			panel27.Controls.Add(txtAccountUsername);
			panel27.Controls.Add(textBox10);
			panel27.Controls.Add(label13);
			panel27.Location = new Point(3, 10);
			panel27.Name = "panel27";
			panel27.Size = new Size(350, 46);
			panel27.TabIndex = 6;
			// 
			// txtAccountUsername
			// 
			txtAccountUsername.Location = new Point(145, 8);
			txtAccountUsername.Name = "txtAccountUsername";
			txtAccountUsername.Size = new Size(197, 27);
			txtAccountUsername.TabIndex = 6;
			// 
			// textBox10
			// 
			textBox10.Location = new Point(388, 12);
			textBox10.Name = "textBox10";
			textBox10.Size = new Size(270, 27);
			textBox10.TabIndex = 1;
			// 
			// label13
			// 
			label13.AutoSize = true;
			label13.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
			label13.Location = new Point(3, 12);
			label13.Name = "label13";
			label13.Size = new Size(108, 23);
			label13.TabIndex = 0;
			label13.Text = "Username";
			// 
			// panel28
			// 
			panel28.Controls.Add(btnUpdateAccount);
			panel28.Controls.Add(btnDeleteAccount);
			panel28.Controls.Add(btnAddAccount);
			panel28.Location = new Point(14, 13);
			panel28.Name = "panel28";
			panel28.Size = new Size(533, 67);
			panel28.TabIndex = 5;
			// 
			// btnUpdateAccount
			// 
			btnUpdateAccount.Location = new Point(407, 10);
			btnUpdateAccount.Name = "btnUpdateAccount";
			btnUpdateAccount.Size = new Size(109, 48);
			btnUpdateAccount.TabIndex = 2;
			btnUpdateAccount.Text = "Update";
			btnUpdateAccount.UseVisualStyleBackColor = true;
			btnUpdateAccount.Click += btnUpdateAccount_Click;
			// 
			// btnDeleteAccount
			// 
			btnDeleteAccount.Location = new Point(210, 10);
			btnDeleteAccount.Name = "btnDeleteAccount";
			btnDeleteAccount.Size = new Size(107, 48);
			btnDeleteAccount.TabIndex = 1;
			btnDeleteAccount.Text = "Delete";
			btnDeleteAccount.UseVisualStyleBackColor = true;
			btnDeleteAccount.Click += btnDeleteAccount_Click;
			// 
			// btnAddAccount
			// 
			btnAddAccount.Location = new Point(15, 10);
			btnAddAccount.Name = "btnAddAccount";
			btnAddAccount.Size = new Size(116, 48);
			btnAddAccount.TabIndex = 0;
			btnAddAccount.Text = "Add";
			btnAddAccount.UseVisualStyleBackColor = true;
			btnAddAccount.Click += btnAddAccount_Click;
			// 
			// panel29
			// 
			panel29.Controls.Add(dgvAccount);
			panel29.Location = new Point(14, 86);
			panel29.Name = "panel29";
			panel29.Size = new Size(533, 377);
			panel29.TabIndex = 3;
			// 
			// dgvAccount
			// 
			dgvAccount.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dgvAccount.Location = new Point(10, 10);
			dgvAccount.Name = "dgvAccount";
			dgvAccount.RowHeadersWidth = 51;
			dgvAccount.RowTemplate.Height = 29;
			dgvAccount.Size = new Size(506, 360);
			dgvAccount.TabIndex = 0;
			dgvAccount.CellClick += dgvAccount_CellClick;
			// 
			// fAdmin
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(1098, 564);
			Controls.Add(tcAdmin);
			Name = "fAdmin";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "Admin";
			tcAdmin.ResumeLayout(false);
			tpBill.ResumeLayout(false);
			panel4.ResumeLayout(false);
			panel4.PerformLayout();
			((System.ComponentModel.ISupportInitialize)dgvRevenue).EndInit();
			panel3.ResumeLayout(false);
			panel3.PerformLayout();
			tpFood.ResumeLayout(false);
			panel6.ResumeLayout(false);
			panel6.PerformLayout();
			panel5.ResumeLayout(false);
			panel10.ResumeLayout(false);
			panel10.PerformLayout();
			((System.ComponentModel.ISupportInitialize)nUDfoodPrice).EndInit();
			panel9.ResumeLayout(false);
			panel9.PerformLayout();
			panel8.ResumeLayout(false);
			panel8.PerformLayout();
			panel7.ResumeLayout(false);
			panel7.PerformLayout();
			panel2.ResumeLayout(false);
			panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)dgvFood).EndInit();
			tpCategory.ResumeLayout(false);
			panel12.ResumeLayout(false);
			panel15.ResumeLayout(false);
			panel15.PerformLayout();
			panel16.ResumeLayout(false);
			panel16.PerformLayout();
			panel17.ResumeLayout(false);
			panel18.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)dgvCategory).EndInit();
			tpTable.ResumeLayout(false);
			panel11.ResumeLayout(false);
			panel21.ResumeLayout(false);
			panel21.PerformLayout();
			panel13.ResumeLayout(false);
			panel13.PerformLayout();
			panel14.ResumeLayout(false);
			panel14.PerformLayout();
			panel19.ResumeLayout(false);
			panel20.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)dgvTable).EndInit();
			tpAccount.ResumeLayout(false);
			panel23.ResumeLayout(false);
			panel22.ResumeLayout(false);
			panel22.PerformLayout();
			panel26.ResumeLayout(false);
			panel26.PerformLayout();
			panel27.ResumeLayout(false);
			panel27.PerformLayout();
			panel28.ResumeLayout(false);
			panel29.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)dgvAccount).EndInit();
			ResumeLayout(false);
		}

		#endregion

		private TabControl tcAdmin;
		private TabPage tpBill;
		private Panel panel4;
		private DataGridView dgvRevenue;
		private Panel panel3;
		private Button btnShowRevenue;
		private DateTimePicker dateTimePicker1;
		private DateTimePicker dateTimePicker2;
		private TabPage tpFood;
		private TabPage tpCategory;
		private TabPage tpTable;
		private TabPage tpAccount;
		private Panel panel6;
		private Button btnSearchFood;
		private Panel panel5;
		private Panel panel2;
		private Button btnShowFood;
		private Button btnUpdateFood;
		private Button btnDeleteFood;
		private Button btnAddFood;
		private Panel panel1;
		private DataGridView dgvFood;
		private TextBox txtSearchFood;
		private Panel panel7;
		private TextBox txtUsername;
		private Label label1;
		private TextBox txtFoodID;
		private Panel panel9;
		private Label label3;
		private Panel panel8;
		private TextBox txtFoodName;
		private TextBox textBox2;
		private Label label2;
		private Panel panel10;
		private NumericUpDown nUDfoodPrice;
		private Label label4;
		private ComboBox cbxCategory;
		private Panel panel12;
		private Panel panel15;
		private TextBox txtCategoryName;
		private TextBox textBox4;
		private Label label7;
		private Panel panel16;
		private TextBox txtCategoryId;
		private TextBox textBox6;
		private Label label8;
		private Panel panel17;
		private Button btnUpdateCategory;
		private Button btnAddCategory;
		private Panel panel18;
		private DataGridView dgvCategory;
		private Panel panel11;
		private Panel panel21;
		private Label label9;
		private Panel panel13;
		private TextBox txtTableName;
		private TextBox textBox3;
		private Label label5;
		private Panel panel14;
		private TextBox txtTableId;
		private TextBox textBox7;
		private Label label6;
		private Panel panel19;
		private Button txtUpdateTable;
		private Button txtDeleteTable;
		private Button txtAddTable;
		private Panel panel20;
		private DataGridView dgvTable;
		private Panel panel23;
		private Panel panel26;
		private TextBox txtAccountDisplayName;
		private TextBox textBox8;
		private Label label12;
		private Panel panel27;
		private TextBox txtAccountUsername;
		private TextBox textBox10;
		private Label label13;
		private Panel panel28;
		private Button btnUpdateAccount;
		private Button btnDeleteAccount;
		private Button btnAddAccount;
		private Panel panel29;
		private DataGridView dgvAccount;
		private TextBox txtTableStatus;
		private Button btnTodayRevenue;
		private Button btnYearRevenue;
		private Button btnWeekRevenue;
		private Label label10;
		private ListView lvBillInfoAdmin;
		private ColumnHeader columnHeader1;
		private ColumnHeader columnHeader2;
		private ColumnHeader columnHeader3;
		private ColumnHeader columnHeader4;
		private TextBox txtBillPrice;
		private Label label14;
		private Panel panel22;
		private ComboBox cbxUserType;
		private Label label15;
	}
}