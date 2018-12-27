using QuanLyQuanCafe.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanCafe.DAO
{
	public class DrinkDAO
	{
		private static DrinkDAO instance;

		private DrinkDAO()
		{

		}

		public List<Drink> GetDrinkByCategory(int id)
		{
			List<Drink> lst = new List<Drink>();

			string query = "SELECT * FROM DRINK WHERE idCategory = " + id;
			DataTable data = DataProvider.Instance.ExecuteQuery(query);

			foreach(DataRow item in data.Rows)
			{
				Drink drink = new Drink(item);
				lst.Add(drink);
			}

			return lst;
		}

		public static DrinkDAO Instance
		{
			get { if (instance == null) instance = new DrinkDAO(); return DrinkDAO.instance; }
			private set { DrinkDAO.instance = value; }
		}

		public List<Drink> GetListDrink()
		{
			List<Drink> lst = new List<Drink>();

			string query = "SELECT * FROM DRINK";

			DataTable data = DataProvider.Instance.ExecuteQuery(query);
			foreach(DataRow item in data.Rows)
			{
				Drink d = new Drink(item);
				lst.Add(d);
			}
			return lst;
		}

		public bool InsertDrink(string name, int id, float price)
		{
			string query = string.Format("INSERT dbo.Drink (name, idCategory, price ) VALUES (N'{0}', {1}, {2})",name, id, price);
			int result = DataProvider.Instance.ExecuteNonQuery(query);
			return result > 0;
		}

		public bool UpdateDrink(int idDrink, string name, int id, float price)
		{
			string query = string.Format("UPDATE dbo.Drink SET name = N'{0}', idCategory = {1}, price = {2} WHERE id = {3}", name, id, price, idDrink);
			int result = DataProvider.Instance.ExecuteNonQuery(query);

			return result > 0;
		}
		 public bool DeleteDrink(int idDrink)
		{
			BillInfoDAO.Instance.DeleteBillInfoByFoodID(idDrink);

			string query = string.Format("DELETE dbo.Drink WHERE id = {0}", idDrink);
			int result = DataProvider.Instance.ExecuteNonQuery(query);

			return result > 0;
		}

		public void DeleteDrinkByCategoryID(int categoryID)
		{
			DataProvider.Instance.ExecuteNonQuery("DELETE dbo.Drink WHERE idCategory = " + categoryID);
		}

		public List<Drink> SearchDrinkByName(string name)
		{
			List<Drink> list = new List<Drink>();

			string query = string.Format("SELECT * FROM dbo.Drink WHERE dbo.fuConvertToUnsign1(name) LIKE N'%' + dbo.fuConvertToUnsign1(N'{0}') + '%'", name);

			DataTable data = DataProvider.Instance.ExecuteQuery(query);

			foreach (DataRow item in data.Rows)
			{
				Drink d = new Drink(item);
				list.Add(d);
			}

			return list;
		}
	}
}
