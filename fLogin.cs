using QuanLiQuanCafe.Models;

namespace QuanLiQuanCafe
{
	public partial class fLogin : Form
	{
		public fLogin()
		{
			InitializeComponent();
		}

		private void btnLogin_Click(object sender, EventArgs e)
		{
			string username = txtUsername.Text;
			string password = txtPassword.Text;
			if (Login(username, password))
			{
				Account loginAccount = getAccountByUsername(username);
				if (loginAccount != null)
				{
					fTableManager f = new fTableManager(loginAccount);
					this.Hide();
					f.ShowDialog();
					this.Show();
				}

			}
			else
			{
				MessageBox.Show("Wrong username or password !!!");
			}
		}

		Account getAccountByUsername(string username)
		{
			QuanLyQuanCafeContext con = new QuanLyQuanCafeContext();
			Account acc = con.Accounts.FirstOrDefault(x => x.UserName.Equals(username));
			return acc;
		}
		bool Login(string username, string password)
		{
			QuanLyQuanCafeContext con = new QuanLyQuanCafeContext();
			var acc = con.Accounts.FirstOrDefault(x => x.UserName.Equals(username)
			&& x.PassWord.Equals(password));
			if (acc == null)
			{
				return false;

			}
			else
			{
				return true;
			}
		}

		private void btnExit_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void fLogin_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (MessageBox.Show("You want to exit ?", "Notification", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
			{
				e.Cancel = true;
			}
		}
	}
}