using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanCafe.DTO
{
	public class Bill
	{
		private int iD;
		private DateTime? dateCheckin;
		private DateTime? dateCheckOut;
		private int status;
		private int discount;

		public Bill(int id, DateTime? dateCheckin, DateTime? dateCheckOut, int status, int discount)
		{
			this.ID = id;
			this.DateCheckin = dateCheckin;
			this.DateCheckOut = dateCheckOut;
			this.Status = status;
			this.Discount = discount;
		}

		public Bill(DataRow row)
		{
			this.ID = (int)row["id"];
			this.DateCheckin = (DateTime?)row["dateCheckin"];
			var dateCheckOutTemp = row["dateCheckOut"];
			if (dateCheckOutTemp.ToString() != "")
				this.dateCheckOut = (DateTime?)dateCheckOutTemp;

			this.Status = (int)row["status"];
			this.Discount = (int)row["discount"];
		}

		public DateTime? DateCheckin { get => dateCheckin; set => dateCheckin = value; }
		public DateTime? DateCheckOut { get => dateCheckOut; set => dateCheckOut = value; }
		public int ID { get => iD; set => iD = value; }
		public int Status { get => status; set => status = value; }
		public int Discount { get => discount; set => discount = value; }
	}
}
