using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanCafe.DTO
{
	public class Drink
	{
		private string name;
		private int categoryID;
		private float price;
		private int id;

		public Drink(int id, string name, int categoryID, float price)
		{
			this.Id = id;
			this.Name = name;
			this.CategoryID = categoryID;
			this.Price = price;
		}

		public Drink(DataRow row)
		{
			this.Id = (int)row["id"];
			this.Name = row["name"].ToString();
			this.CategoryID = (int)row["idCategory"];
			this.Price = (float)Convert.ToDouble(row["price"].ToString());
		}

		public string Name { get => name; set => name = value; }
		public int CategoryID { get => categoryID; set => categoryID = value; }
		public float Price { get => price; set => price = value; }
		public int Id { get => id; set => id = value; }
	}
}
