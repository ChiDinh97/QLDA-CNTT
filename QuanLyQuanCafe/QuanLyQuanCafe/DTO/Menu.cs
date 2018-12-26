using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanCafe.DTO
{
	public class Menu
	{
		public Menu(string drinkName, int count, float price, float totalPrice)
		{
			this.DrinkName = drinkName;
			this.Count = count;
			this.Price = price;
			this.TotalPrice = totalPrice;
		}
		
		public Menu(DataRow row)
		{
			this.DrinkName = row["Name"].ToString();
			this.Count = (int)row["count"];
			this.Price = (float)Convert.ToDouble(row["price"].ToString());
			this.TotalPrice = (float)Convert.ToDouble(row["totalPrice"].ToString());
		}

		private float totalPrice;
		private float price;
		private int count;
		private string drinkName;

		public string DrinkName { get => drinkName; set => drinkName = value; }
		public int Count { get => count; set => count = value; }
		public float TotalPrice { get => totalPrice; set => totalPrice = value; }
		public float Price { get => price; set => price = value; }
	}
}
