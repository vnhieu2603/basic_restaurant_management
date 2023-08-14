using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLiQuanCafe.Models;


namespace QuanLiQuanCafe.DAO
{
	internal class DataProvider
	{
		public IQueryable<dynamic> loadAccoutList()
		{
			QuanLyQuanCafeContext con = new QuanLyQuanCafeContext();
			var acc = con.Accounts.Select(x => new
			{
				UserName = x.UserName,
				DisplayName = x.DisplayName,
				PassWord = x.PassWord,
				Type = x.Type
			});
			return acc;
		}
	}
}
