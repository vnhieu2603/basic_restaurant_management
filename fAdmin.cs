using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;
using QuanLiQuanCafe.Models;

namespace QuanLiQuanCafe
{
	public partial class fAdmin : Form
	{
		public fAdmin()
		{
			InitializeComponent();
			showRevenue(dateTimePicker1.Value, dateTimePicker2.Value);
			loadAccoutList();
			loadFoodList();
			loadCategoryList();
			loadTableList();
		}

		private void btnShowRevenue_Click(object sender, EventArgs e)
		{

			showRevenue(dateTimePicker1.Value, dateTimePicker2.Value);
		}

		public void showRevenue(DateTime checkIn, DateTime checkOut)
		{
			QuanLyQuanCafeContext con = new QuanLyQuanCafeContext();
			var re = con.Bills.Where(x => x.DateCheckIn >= checkIn.Date && x.DateCheckOut <= checkOut.Date && x.Status == 1)
				.Select(x => new
				{
					Id = x.Id,
					Table = x.IdTableNavigation.Name,
					DateCheckIn = x.DateCheckIn,
					DateCheckOut = x.DateCheckOut,
					TotalPrice = x.TotalPrice
				});
			dgvRevenue.DataSource = re.ToList();
			dgvRevenue.Columns["Id"].Visible = false;


		}

		public void loadAccoutList()
		{
			QuanLyQuanCafeContext con = new QuanLyQuanCafeContext();
			cbxUserType.Items.Clear();
			cbxUserType.Items.Add("Staff");
			cbxUserType.Items.Add("Admin");
			cbxUserType.SelectedIndex = 0;
			var acc = con.Accounts
				.Select(x => new
				{
					UserName = x.UserName,
					DisplayName = x.DisplayName,
					Type = x.Type
				});
			dgvAccount.DataSource = acc.ToList();
			dgvAccount.Columns["DisplayName"].HeaderText = "Tên hiển thị";
		}

		public void loadFoodList()
		{
			QuanLyQuanCafeContext con = new QuanLyQuanCafeContext();
			cbxCategory.DataSource = con.FoodCategories.Select(x => x.Name).ToList<string>();

			var acc = con.Foods
				.Select(x => new
				{
					Id = x.Id,
					Name = x.Name,
					Category = x.IdCategoryNavigation.Name,
					price = (int)x.Price,
				});
			dgvFood.DataSource = acc.ToList();

		}

		public void loadCategoryList()
		{
			QuanLyQuanCafeContext con = new QuanLyQuanCafeContext();


			var fCa = con.FoodCategories
				.Select(x => new
				{
					Id = x.Id,
					Name = x.Name,
				});
			dgvCategory.DataSource = fCa.ToList();

		}

		public void loadTableList()
		{
			QuanLyQuanCafeContext con = new QuanLyQuanCafeContext();


			var tf = con.TableFoods
				.Select(x => new
				{
					Id = x.Id,
					Name = x.Name,
					Status = x.Status
				});
			dgvTable.DataSource = tf.ToList();

		}

		private void dgvFood_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			int n = e.RowIndex;
			QuanLyQuanCafeContext con = new QuanLyQuanCafeContext();
			if (n >= 0)
			{
				txtFoodID.Text = dgvFood[0, n].Value.ToString();
				txtFoodName.Text = dgvFood[1, n].Value.ToString();
				cbxCategory.DataSource = con.FoodCategories.Select(x => x.Name).ToList<string>();
				cbxCategory.SelectedItem = dgvFood[2, n].Value.ToString();
				nUDfoodPrice.Value = (int)dgvFood[3, n].Value;
			}
		}

		private void btnUpdateFood_Click(object sender, EventArgs e)
		{
			QuanLyQuanCafeContext con = new QuanLyQuanCafeContext();
			int id = int.Parse(txtFoodID.Text);
			var obj = con.Foods.Find(id);
			string name = txtFoodName.Text;
			string categoryName = cbxCategory.SelectedItem.ToString();
			var category = con.FoodCategories.FirstOrDefault(x => x.Name == categoryName);
			int categoryId = category.Id;
			double price = (double)nUDfoodPrice.Value;

			obj.Name = name;
			obj.IdCategory = categoryId;
			obj.Price = price;
			con.Foods.Update(obj);
			con.SaveChanges();
			MessageBox.Show("Update successfully");
			loadFoodList();
		}

		private void btnAddFood_Click(object sender, EventArgs e)
		{
			QuanLyQuanCafeContext con = new QuanLyQuanCafeContext();
			string name = txtFoodName.Text;
			string categoryName = cbxCategory.SelectedItem.ToString();
			var category = con.FoodCategories.FirstOrDefault(x => x.Name == categoryName);
			int categoryId = category.Id;
			double price = (double)nUDfoodPrice.Value;

			if (name == null || name.Length == 0)
			{
				MessageBox.Show("Please input name !!!");
			}
			else
			{
				var foodName = con.Foods.FirstOrDefault(x => x.Name == name);
				if (foodName != null)
				{
					MessageBox.Show("Food name already exist !!!");
				}
				else
				{
					con.Foods.Add(new Food
					{
						Name = name,
						IdCategory = categoryId,
						Price = price,
					});
					con.SaveChanges();
					MessageBox.Show("Add successfully");
					loadFoodList();
				}

			}

		}

		private void btnDeleteFood_Click(object sender, EventArgs e)
		{
			QuanLyQuanCafeContext con = new QuanLyQuanCafeContext();
			if (txtFoodID.Text == "" || txtFoodID.Text == null)
			{
				MessageBox.Show("Choose a food to delete !!!");
			}
			else
			{
				int id = int.Parse(txtFoodID.Text);
				var obj = con.Foods.Find(id);
				var ans = MessageBox.Show($"Confirm to Delete ?",
					"Confirm messeges box", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
				if (ans == DialogResult.Yes)
				{
					con.Foods.Remove(obj);
					con.SaveChanges();
					loadFoodList();
				}
			}

		}

		private void btnShowFood_Click(object sender, EventArgs e)
		{
			loadFoodList();
		}

		private void btnSearchFood_Click(object sender, EventArgs e)
		{
			QuanLyQuanCafeContext con = new QuanLyQuanCafeContext();
			string searchKey = txtSearchFood.Text.ToString();
			if (searchKey == "" || searchKey == null)
			{
				loadFoodList();
			}
			else
			{
				cbxCategory.DataSource = con.FoodCategories.Select(x => x.Name).ToList<string>();
				var acc = con.Foods.Where(x => x.Name.Contains(searchKey))
				.Select(x => new
				{
					Id = x.Id,
					Name = x.Name,
					Category = x.IdCategoryNavigation.Name,
					price = (int)x.Price,
				});
				dgvFood.DataSource = acc.ToList();
			}
		}

		private void dgvCategory_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			int n = e.RowIndex;
			QuanLyQuanCafeContext con = new QuanLyQuanCafeContext();
			if (n >= 0)
			{
				txtCategoryId.Text = dgvCategory[0, n].Value.ToString();
				txtCategoryName.Text = dgvCategory[1, n].Value.ToString();

			}
		}

		private void btnUpdateCategory_Click(object sender, EventArgs e)
		{
			QuanLyQuanCafeContext con = new QuanLyQuanCafeContext();
			int id = int.Parse(txtCategoryId.Text);
			var obj = con.FoodCategories.Find(id);
			string name = txtCategoryName.Text;

			obj.Name = name;
			con.FoodCategories.Update(obj);
			con.SaveChanges();
			MessageBox.Show("Update successfully");
			loadCategoryList();

		}

		private void btnAddCategory_Click(object sender, EventArgs e)
		{
			QuanLyQuanCafeContext con = new QuanLyQuanCafeContext();
			string name = txtCategoryName.Text;
			if (name == "" || name == null)
			{
				MessageBox.Show("Input name to add");
			}
			else
			{
				var categoryName = con.FoodCategories.FirstOrDefault(x => x.Name == name);
				if (categoryName != null)
				{
					MessageBox.Show("Category name already exist !!!");

				}
				else
				{
					con.FoodCategories.Add(new FoodCategory
					{
						Name = name,
					});
					con.SaveChanges();
					MessageBox.Show("Add successfully");
					loadCategoryList();
				}
			}
		}

		private void txtUpdateTable_Click(object sender, EventArgs e)
		{
			QuanLyQuanCafeContext con = new QuanLyQuanCafeContext();
			int id = int.Parse(txtTableId.Text);
			var obj = con.TableFoods.Find(id);

			string name = txtTableName.Text;

			obj.Name = name;

			con.TableFoods.Update(obj);
			con.SaveChanges();
			loadTableList();

		}

		private void dgvTable_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			int n = e.RowIndex;
			QuanLyQuanCafeContext con = new QuanLyQuanCafeContext();
			if (n >= 0)
			{
				txtTableId.Text = dgvTable[0, n].Value.ToString();
				txtTableName.Text = dgvTable[1, n].Value.ToString();
				txtTableStatus.Text = dgvTable[2, n].Value.ToString();

			}
		}

		private void txtDeleteTable_Click(object sender, EventArgs e)
		{
			QuanLyQuanCafeContext con = new QuanLyQuanCafeContext();
			if (txtTableId.Text == "" || txtTableId.Text == null)
			{
				MessageBox.Show("Choose a table to delete !!!");
			}
			else
			{
				int id = int.Parse(txtTableId.Text);
				var obj = con.TableFoods.Find(id);
				if (obj.Status != "Trống")
				{
					MessageBox.Show("Cannot delete this table !!");
				}
				else
				{
					var ans = MessageBox.Show($"Confirm to Delete ?",
					"Confirm messeges box", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
					if (ans == DialogResult.Yes)
					{
						con.TableFoods.Remove(obj);
						con.SaveChanges();
						loadTableList();
					}
				}
			}
		}

		private void txtAddTable_Click(object sender, EventArgs e)
		{
			QuanLyQuanCafeContext con = new QuanLyQuanCafeContext();
			string name = txtTableName.Text;
			if (name == "" || name == null)
			{
				MessageBox.Show("Input name to add");
			}
			else
			{
				var tableName = con.TableFoods.FirstOrDefault(x => x.Name == name);
				if (tableName != null)
				{
					MessageBox.Show("Table name already exist");
				}
				else
				{
					con.TableFoods.Add(new TableFood
					{
						Name = name,
						Status = "Trống"
					});
					con.SaveChanges();
					MessageBox.Show("Add successfully");
					loadTableList();
				}
			}
		}

		private void dgvAccount_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			int n = e.RowIndex;
			QuanLyQuanCafeContext con = new QuanLyQuanCafeContext();
			if (n >= 0)
			{
				txtAccountUsername.Text = dgvAccount[0, n].Value.ToString();
				txtAccountDisplayName.Text = dgvAccount[1, n].Value.ToString();
				cbxUserType.SelectedIndex = dgvAccount[2, n].Value.ToString() == "1" ? 1 : 0;
			}
		}

		private void btnAddAccount_Click(object sender, EventArgs e)
		{
			QuanLyQuanCafeContext con = new QuanLyQuanCafeContext();
			string userName = txtAccountUsername.Text;
			string displayName = txtAccountDisplayName.Text;
			string password = GenerateRandomPassword();
			int type = cbxUserType.SelectedIndex;
			if (userName == null || userName == "")
			{
				MessageBox.Show("Please input Username");

			}
			else
			{
				var u = con.Accounts.FirstOrDefault(x => x.UserName == userName);
				if (u != null)
				{
					MessageBox.Show("This Username already exist");
				}
				else
				{
					if (displayName == null || displayName == "")
					{
						MessageBox.Show("Please input display name !!!");
					}
					else
					{
						con.Accounts.Add(new Account
						{
							UserName = userName,
							DisplayName = displayName,
							PassWord = password,
							Type = type == 1 ? 1 : 0
						});
						con.SaveChanges();
						MessageBox.Show("Add successfully");
						loadAccoutList();
					}

				}
			}



		}

		private string GenerateRandomPassword()
		{
			string characters = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
			int passwordLength = 6;
			Random random = new Random();
			StringBuilder password = new StringBuilder();

			for (int i = 0; i < passwordLength; i++)
			{
				int index = random.Next(0, characters.Length);
				password.Append(characters[index]);
			}

			return password.ToString();
		}

		private void btnDeleteAccount_Click(object sender, EventArgs e)
		{
			QuanLyQuanCafeContext con = new QuanLyQuanCafeContext();
			string userName = txtAccountUsername.Text;
			if (userName == null || userName == "")
			{
				MessageBox.Show("Select an account to delete !!");
			}
			else
			{
				var u = con.Accounts.FirstOrDefault(x => x.UserName == userName);
				if (u.Type == 0)
				{
					var ans = MessageBox.Show($"Confirm to Delete ?",
					"Confirm messeges box", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
					if (ans == DialogResult.Yes)
					{
						con.Accounts.Remove(u);
						con.SaveChanges();
						loadAccoutList();
					}
				}
				else
				{
					MessageBox.Show("Cannot delete an admin !!");
				}
			}
		}

		private void btnUpdateAccount_Click(object sender, EventArgs e)
		{
			QuanLyQuanCafeContext con = new QuanLyQuanCafeContext();
			string userName = txtAccountUsername.Text;
			if (userName == null || userName == "")
			{
				MessageBox.Show("Select an account to update");
			}
			else
			{
				var u = con.Accounts.FirstOrDefault(x => x.UserName == userName);
				if (u == null)
				{
					MessageBox.Show("Account not exist");
					return;
				}
				string displayName = txtAccountDisplayName.Text;
				int type = cbxUserType.SelectedIndex;

				if (u.Type == 1)
				{
					if (type == 0)
					{
						MessageBox.Show("Cannot change type of this admin account");
					}
					else
					{
						u.DisplayName = displayName;
						con.Accounts.Update(u);
						con.SaveChanges();
						MessageBox.Show("Update successfully");
						loadAccoutList();
					}
				}
				else
				{
					u.DisplayName = displayName;
					u.Type = type;

					con.Accounts.Update(u);
					con.SaveChanges();

					MessageBox.Show("Update successfully");
					loadAccoutList();
				}
			}
		}

		private void btnTodayRevenue_Click(object sender, EventArgs e)
		{
			DateTime currrentDate = DateTime.Now;
			QuanLyQuanCafeContext con = new QuanLyQuanCafeContext();
			var re = con.Bills.Where(x => x.DateCheckOut == currrentDate.Date && x.Status == 1)
				.Select(x => new
				{
					Id = x.Id,

					Table = x.IdTableNavigation.Name,
					DateCheckIn = x.DateCheckIn,
					DateCheckOut = x.DateCheckOut,
					TotalPrice = x.TotalPrice
				});
			dgvRevenue.DataSource = re.ToList();
			dgvRevenue.Columns["Id"].Visible = false;

		}

		private void btnWeekRevenue_Click(object sender, EventArgs e)
		{
			DateTime currrentDate = DateTime.Now;
			DateTime previous7Date = currrentDate.AddDays(-7);
			QuanLyQuanCafeContext con = new QuanLyQuanCafeContext();
			var re = con.Bills.Where(x => x.DateCheckOut <= currrentDate.Date && x.DateCheckOut >= previous7Date.Date && x.Status == 1)
				.Select(x => new
				{
					Id = x.Id,

					Table = x.IdTableNavigation.Name,
					DateCheckIn = x.DateCheckIn,
					DateCheckOut = x.DateCheckOut,
					TotalPrice = x.TotalPrice
				});
			dgvRevenue.DataSource = re.ToList();
			dgvRevenue.Columns["Id"].Visible = false;

		}

		private void btnYearRevenue_Click(object sender, EventArgs e)
		{
			DateTime currrentDate = DateTime.Now;
			DateTime previous7Date = currrentDate.AddDays(-365);
			QuanLyQuanCafeContext con = new QuanLyQuanCafeContext();
			var re = con.Bills.Where(x => x.DateCheckOut <= currrentDate.Date && x.DateCheckOut >= previous7Date.Date && x.Status == 1)
				.Select(x => new
				{
					Id = x.Id,
					Table = x.IdTableNavigation.Name,
					DateCheckIn = x.DateCheckIn,
					DateCheckOut = x.DateCheckOut,
					TotalPrice = x.TotalPrice
				});
			dgvRevenue.DataSource = re.ToList();
			dgvRevenue.Columns["Id"].Visible = false;

		}

		private void dgvRevenue_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			lvBillInfoAdmin.Items.Clear();
			int n = e.RowIndex;
			QuanLyQuanCafeContext con = new QuanLyQuanCafeContext();

			if (n >= 0)
			{
				string billId = dgvRevenue[0, n].Value.ToString();
				string data2 = dgvRevenue[1, n].Value.ToString();
				string dateTimeCheckIn = dgvRevenue[2, n].Value.ToString();
				string[] parts1 = dateTimeCheckIn.Split(' ');
				string dateCheckIn = parts1[0];

				string dateTimeCheckOut = dgvRevenue[3, n].Value.ToString();
				string[] parts2 = dateTimeCheckIn.Split(' ');
				string dateCheckOut = parts2[0];

				string totalPrice = dgvRevenue[4, n].Value.ToString();
				var bInfoList = new List<BillInfo>();
				var bInfo = con.BillInfos.Where(x => x.IdBill == int.Parse(billId)).ToList();
				bInfoList.AddRange(bInfo);

				double priceForFood = 0;

				foreach (var item in bInfoList)
				{
					var foodName = con.Foods.Where(x => x.Id == item.IdFood).Select(x => x.Name).FirstOrDefault();
					ListViewItem lsItem = new ListViewItem(foodName);

					var foodPrice = con.Foods.Where(x => x.Id == item.IdFood).Select(x => x.Price).FirstOrDefault();
					lsItem.SubItems.Add(foodPrice.ToString());
					lsItem.SubItems.Add(item.Count.ToString());
					priceForFood = foodPrice * item.Count;
					lsItem.SubItems.Add(priceForFood.ToString());
					lvBillInfoAdmin.Items.Add(lsItem);
				}
				txtBillPrice.Text = totalPrice;


			}
		}
	}
}
