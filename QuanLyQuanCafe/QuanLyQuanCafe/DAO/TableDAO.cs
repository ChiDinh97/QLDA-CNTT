using QuanLyQuanCafe.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanCafe.DAO
{
	public class TableDAO
	{
		private static TableDAO instance;

		public static TableDAO Instance
		{
			get { if (instance == null) instance = new TableDAO(); return TableDAO.instance; }
			private set { TableDAO.instance = value; }
		}

		public static int TableWidth = 90;
		public static int TableHeight = 90;

		private TableDAO() { }

		public List<Table> LoadTableList()
		{
			List<Table> tableList = new List<Table>();

			DataTable data = DataProvider.Instance.ExecuteQuery("USP_GetTableList");

			foreach (DataRow item in data.Rows)
			{
				Table table = new Table(item);
				tableList.Add(table);
			}

			return tableList;
		}

		public bool InsertTable(string name)
		{
			string query = string.Format("INSERT dbo.TableDrink (name) VALUES (N'{0}')", name);
			int result = DataProvider.Instance.ExecuteNonQuery(query);

			return result > 0;
		}

		public bool UpdateTable(int id, string name)
		{
			string query = string.Format("UPDATE dbo.TableDrink SET Name = N'{0}' WHERE id = {1}", name, id);
			int result = DataProvider.Instance.ExecuteNonQuery(query);

			return result > 0;
		}

		public bool DeleteTable(int id)
		{
			//delete bills refer to table first
			

			string query = string.Format("DELETE dbo.TableDrink WHERE id = {0}", id);
			int result = DataProvider.Instance.ExecuteNonQuery(query);

			return result > 0;
		}
	}
}
