using QuanLyQuanCafe.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanCafe.DAO
{
	public class BillDAO
	{
		private static BillDAO instance;

		public static BillDAO Instance
		{
			get { if (instance == null) instance = new BillDAO(); return BillDAO.instance; }
			private set { BillDAO.instance = value; }
		}

		private BillDAO() { }

		/// <summary>
		/// Thành công: bill ID
		/// thất bại: -1
		/// </summary>
		/// <param name="id"></param>
		/// <returns></returns>
		public int GetUncheckBillIDByTableID(int id)
		{
			DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM dbo.Bill WHERE idTable = " + id + " AND status = 0");

			if (data.Rows.Count > 0)
			{
				Bill bill = new Bill(data.Rows[0]);
				return bill.ID;
			}

			return -1;
		}

		public void InsertBill(int id)
		{
			DataProvider.Instance.ExecuteNonQuery("EXEC USP_InsertBill @idTable", new object[] { id });
		}

		public void CheckOut(int id, int discount, float totalPrice)
		{
			string query = "UPDATE dbo.Bill SET DateCheckOut = GETDATE(), status = 1, " + "discount = " + discount + ", totalPrice = " + totalPrice+ " WHERE id = " + id;
			DataProvider.Instance.ExecuteNonQuery(query);
		}

		public DataTable GetListBillByDate(DateTime checkIn, DateTime checkOut)
		{
			return DataProvider.Instance.ExecuteQuery("EXEC USP_GetListBillByDate @checkIn , @checkOut", new object[] { checkIn, checkOut });
		}
	}
}
