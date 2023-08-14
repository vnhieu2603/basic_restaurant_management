using QuanLiQuanCafe.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLiQuanCafe
{
	public partial class fAccountProfile : Form
	{
		private Account loginAccount;

		public Account LoginAccount
		{
			get { return loginAccount; }
			set { loginAccount = value; ChangeAccount(loginAccount); }
		}
		public fAccountProfile(Account acc)
		{
			InitializeComponent();
			this.LoginAccount = acc;
		}

		void ChangeAccount(Account acc)
		{
			txtUsername.Text = acc.UserName.ToString();
			txtDisplayName.Text = acc.DisplayName.ToString();
			txtPassword.Text = acc.PassWord.ToString();
		}

		private void btnExit_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void btnUpdate_Click(object sender, EventArgs e)
		{
			string userName = txtUsername.Text;
			string displayName = txtDisplayName.Text;
			string password = txtPassword.Text;
			string newPassword = txtNewPassword.Text;
			string reEnter = txtReEnterPassword.Text;
			if (newPassword == reEnter || (newPassword == null && reEnter == null))
			{
				updateAccount(userName, displayName, password, newPassword);
				MessageBox.Show("Update successfully");


			}
			else
			{
				MessageBox.Show("reEnter does not match new password !!!");
			}
		}

		void updateAccount(string userName, string displayName, string password, string newPass)
		{
			QuanLyQuanCafeContext con = new QuanLyQuanCafeContext();
			var obj = con.Accounts.Find(userName);
			obj.DisplayName = displayName;
			if (newPass != "")
			{
				obj.PassWord = newPass;
			}
			con.Accounts.Update(obj);
			con.SaveChanges();

		}
	}
}
