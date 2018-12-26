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
			string query = "SELECT * FROM DRINKCATEGORY";
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
	}
}
