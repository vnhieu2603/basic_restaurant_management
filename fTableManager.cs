
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
//using Microsoft.EntityFrameworkCore.Metadata.Internal;
using QuanLiQuanCafe.Models;
namespace QuanLiQuanCafe
{
	public partial class fTableManager : Form
	{
		private Account loginAccount;

		public Account LoginAccount
		{
			get { return loginAccount; }
			set { loginAccount = value; ChangeAccount(loginAccount.Type); }
		}
		public fTableManager(Account acc)
		{
			InitializeComponent();
			this.LoginAccount = acc;
			loadTable();
			loadCategory();
			accountInformationToolStripMenuItem.Text = "Hello " + loginAccount.DisplayName;
		}

		void ChangeAccount(int type)
		{
			adminToolStripMenuItem.Enabled = type == 1;
		}

		public void loadTable()
		{
			QuanLyQuanCafeContext con = new QuanLyQuanCafeContext();
			var tf = con.TableFoods.ToList();
			foreach (var item in tf)
			{
				Button btn = new Button { Width = 90, Height = 90 };
				btn.Text = item.Name + Environment.NewLine + item.Status;
				btn.Click += btn_Click;
				btn.Tag = item;

				switch (item.Status)
				{
					case "Trống":
						btn.BackColor = Color.White;
						break;
					default:
						btn.BackColor = Color.BurlyWood;
						break;
				}
				flpTable.Controls.Add(btn);
			}
		}

		void loadCategory()
		{
			QuanLyQuanCafeContext con = new QuanLyQuanCafeContext();
			var foodCategory = con.FoodCategories.ToList();
			cbxCategoryFood.DataSource = foodCategory;
			cbxCategoryFood.DisplayMember = "name";
		}

		void loadFoodListByCategoryId(int id)
		{
			QuanLyQuanCafeContext con = new QuanLyQuanCafeContext();
			var f = con.Foods.Where(x => x.IdCategory == id).ToList();
			cbxFood.DataSource = f;
			cbxFood.DisplayMember = "name";

		}

		void btn_Click(object sender, EventArgs e)
		{
			int tableId = ((sender as Button).Tag as TableFood).Id;
			lvBill.Tag = (sender as Button).Tag;
			showBill(tableId);
		}

		void showBill(int id)
		{
			lvBill.Items.Clear();
			QuanLyQuanCafeContext con = new QuanLyQuanCafeContext();
			var b = con.Bills.Where(x => x.IdTable == id && x.Status == 0)
				.ToList();

			var bInfoList = new List<BillInfo>();

			foreach (var item in b)
			{
				var bInfo = con.BillInfos.Where(x => x.IdBill == item.Id).ToList();
				bInfoList.AddRange(bInfo);
			}
			double priceForFood = 0;
			double totalPrice = 0;
			foreach (var item in bInfoList)
			{
				ListViewItem lsItem = new ListViewItem(item.IdFood.ToString());
				var foodName = con.Foods.Where(x => x.Id == item.IdFood).Select(x => x.Name).FirstOrDefault();
				lsItem.SubItems.Add(foodName.ToString());

				var foodPrice = con.Foods.Where(x => x.Id == item.IdFood).Select(x => x.Price).FirstOrDefault();
				lsItem.SubItems.Add(foodPrice.ToString());
				lsItem.SubItems.Add(item.Count.ToString());
				priceForFood = foodPrice * item.Count;
				lsItem.SubItems.Add(priceForFood.ToString());
				lvBill.Items.Add(lsItem);
				totalPrice += priceForFood;
			}
			txtTotalPrice.Text = totalPrice.ToString();
		}

		private void logoutToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void MyAccountToolStripMenuItem_Click(object sender, EventArgs e)
		{
			fAccountProfile f = new fAccountProfile(loginAccount);
			f.ShowDialog();
		}

		private void adminToolStripMenuItem_Click(object sender, EventArgs e)
		{
			fAdmin f = new fAdmin();
			f.ShowDialog();
		}

		private void cbxCategoryFood_SelectedIndexChanged(object sender, EventArgs e)
		{
			int id = 0;
			ComboBox cb = sender as ComboBox;

			if (cb.SelectedItem == null)
			{
				return;
			}

			FoodCategory selected = cb.SelectedItem as FoodCategory;
			id = selected.Id;

			loadFoodListByCategoryId(id);
		}

		private void btnAddFood_Click(object sender, EventArgs e)
		{
			TableFood tableFood = lvBill.Tag as TableFood;
			QuanLyQuanCafeContext con = new QuanLyQuanCafeContext();
			var b = con.Bills.FirstOrDefault(x => x.IdTable == tableFood.Id && x.Status == 0);
			if (b == null)
			{
				int count = (int)nUdAddFood.Value;
				if (count != 0)
				{
					insertBill(tableFood.Id);
					int maxIdBill = con.Bills.Max(x => x.Id);
					int foodId = (cbxFood.SelectedItem as Food).Id;
					insertBillInfo(maxIdBill, foodId, count);
					showBill(tableFood.Id);
				}
			}
			else
			{
				int billId = b.Id;
				int foodId = (cbxFood.SelectedItem as Food).Id;
				int count = (int)nUdAddFood.Value;
				var bInfo = con.BillInfos.FirstOrDefault(x => x.IdFood == foodId && x.IdBill == billId);
				if (bInfo == null)
				{
					if (count != 0)
					{
						insertBillInfo(billId, foodId, count);
					}
				}
				else
				{
					updateBillInfo(bInfo.Id, count);
				}
				flpTable.Controls.Clear();
				loadTable();
				showBill(tableFood.Id);
			}


		}

		void insertBill(int id)
		{
			QuanLyQuanCafeContext con = new QuanLyQuanCafeContext();

			DateTime currentDate = DateTime.Today;
			int tableId = id;
			var tableF = con.TableFoods.Find(tableId);
			tableF.Status = "Có";
			con.TableFoods.Update(tableF);
			con.SaveChanges();

			con.Bills.Add(new Bill
			{
				DateCheckIn = currentDate,
				IdTable = tableId,
				Status = 0,
				TotalPrice = 0
			});
			con.SaveChanges();
			flpTable.Controls.Clear();
			loadTable();

		}

		void insertBillInfo(int idBill, int idFood, int count)
		{
			QuanLyQuanCafeContext con = new QuanLyQuanCafeContext();

			con.BillInfos.Add(new BillInfo
			{
				IdBill = idBill,
				IdFood = idFood,
				Count = count
			});
			con.SaveChanges();

		}

		void updateBillInfo(int billInfoId, int count)
		{
			QuanLyQuanCafeContext con = new QuanLyQuanCafeContext();
			var obj = con.BillInfos.Find(billInfoId);
			if (count == 0)
			{
				con.BillInfos.Remove(obj);
				con.SaveChanges();

			}
			else
			{
				obj.Count = count;
				con.BillInfos.Update(obj);
				con.SaveChanges();

			}

		}

		private void btnCheckOut_Click(object sender, EventArgs e)
		{
			TableFood tableFood = lvBill.Tag as TableFood;
			QuanLyQuanCafeContext con = new QuanLyQuanCafeContext();

			DateTime currentDate = DateTime.Today;

			var b = con.Bills.FirstOrDefault(x => x.IdTable == tableFood.Id && x.Status == 0);

			b.Status = 1;
			b.DateCheckOut = currentDate;
			float totalPrice;
			if (float.TryParse(txtTotalPrice.Text, out totalPrice))
			{
				b.TotalPrice = totalPrice;
			}
			var t = con.TableFoods.FirstOrDefault(x => x.Id == b.IdTable);
			t.Status = "Trống";
			con.SaveChanges();
			flpTable.Controls.Clear();
			loadTable();
			showBill(t.Id);
		}
	}
}
