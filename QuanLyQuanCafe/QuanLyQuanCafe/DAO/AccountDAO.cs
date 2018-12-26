using QuanLyQuanCafe.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanCafe.DAO
{
	public class AccountDAO
	{
		private static AccountDAO instance;

		public static AccountDAO Instance
		{
			get{if (instance == null) instance = new AccountDAO(); return AccountDAO.instance;}
			private set { instance = value; }
		}

		private AccountDAO() { }

		public bool Login(string UserName, string Password)
		{
			string query = "USP_Login @userName , @passWord";

			DataTable result = DataProvider.Instance.ExecuteQuery(query, new object[] { UserName, Password });

			return result.Rows.Count > 0;
		}

		public bool UpdateAccount(string userName, string displayName, string pass, string newPass)
		{
			int result = DataProvider.Instance.ExecuteNonQuery("Exec USP_UpdateAccount @userName , @displayName , @password , @newPassword ", new object[] { userName, displayName, pass, newPass });
			return result > 0;
		}

		public Account GetAcountByUserName(string userName)
		{
			DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM dbo.ACCOUNT WHERE userName = '" + userName + "'");

			foreach(DataRow item in data.Rows)
			{
				return new Account(item);
			}
			return null;
		}

		public DataTable GetListAccount()
		{
			return DataProvider.Instance.ExecuteQuery("SELECT UserName, DisplayName, Type FROM dbo.Account");
		}

		public bool InsertAccount(string name, string displayName, int type)
		{
			string query = string.Format("INSERT dbo.Account (UserName, DisplayName, Type ) VALUES (N'{0}', N'{1}', {2})", name, displayName, type);
			int result = DataProvider.Instance.ExecuteNonQuery(query);
			return result > 0;
		}

		public bool UpdateAccount(string name, string displayName, int type)
		{
			string query = string.Format("UPDATE dbo.Account SET DisplayName = N'{0}', Type = {1} WHERE UserName = N'{2}'", displayName, type, name);
			int result = DataProvider.Instance.ExecuteNonQuery(query);

			return result > 0;
		}
		public bool DeleteAccount(string name)
		{
			string query = string.Format("DELETE dbo.Account WHERE UserName = N'{0}'", name);
			int result = DataProvider.Instance.ExecuteNonQuery(query);

			return result > 0;
		}

		public bool ResetPass(string name)
		{
			string query = string.Format("UPDATE dbo.Account SET Password = N'0' WHERE UserName = N'{0}'", name);
			int result = DataProvider.Instance.ExecuteNonQuery(query);

			return result > 0;
		}
	}
}
