using QuanLyQuanCafe.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanCafe.DAO
{
	public class CategoryDAO
	{
		private static CategoryDAO instance;

		private CategoryDAO()
		{

		}

		public List<Category> GetListCategory()
		{
			List<Category> lst = new List<Category>();
			string query = "SELECT id, name FROM DRINKCATEGORY";
			DataTable data = DataProvider.Instance.ExecuteQuery(query);

			foreach(DataRow item in data.Rows)
			{
				Category category = new Category(item);
				lst.Add(category);
			}
			return lst;
		}

		public static CategoryDAO Instance
		{
			get { if (instance == null) instance = new CategoryDAO(); return CategoryDAO.instance;}
			private set { CategoryDAO.instance = value; }
		}

		public Category GetCategoryByID(int id)
		{
			Category cat = null;
			string query = "SELECT * FROM DRINKCATEGORY WHERE ID = " + id;
			DataTable data = DataProvider.Instance.ExecuteQuery(query);
			foreach(DataRow item in data.Rows)
			{
				cat = new Category(item);
				return cat;
			}

			return cat;
		}

		public bool InsertCategory(string name)
		{
			string query = string.Format("INSERT dbo.DrinkCategory (name) VALUES (N'{0}')", name);
			int result = DataProvider.Instance.ExecuteNonQuery(query);
			return result > 0;
		}

		public bool UpdateCategory(int id, string name)
		{
			string query = string.Format("UPDATE dbo.DrinkCategory SET name = N'{0}' WHERE id = {1}", name, id);
			int result = DataProvider.Instance.ExecuteNonQuery(query);

			return result > 0;
		}

		public bool DeleteCategory(int id)
		{
			//delete all drink refer to this category
			DrinkDAO.Instance.DeleteDrinkByCategoryID(id);

			//then delete category
			string query = string.Format("DELETE dbo.DrinkCategory WHERE id = {0}", id);
			int result = DataProvider.Instance.ExecuteNonQuery(query);

			return result > 0;
		}
	}
}
