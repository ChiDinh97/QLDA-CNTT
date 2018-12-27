using QuanLyQuanCafe.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanCafe.DAO
{
	public class BillInfoDAO
	{
		private static BillInfoDAO instance;

		public static BillInfoDAO Instance
		{
			get { if (instance == null) instance = new BillInfoDAO(); return BillInfoDAO.instance; }
			private set { BillInfoDAO.instance = value; }
		}

		private BillInfoDAO() { }

		public List<BillInfo> GetListBillInfo(int id)
		{
			List<BillInfo> listBillInfo = new List<BillInfo>();

			DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM dbo.BillInfo WHERE idBill = " + id);

			foreach (DataRow item in data.Rows)
			{
				BillInfo info = new BillInfo(item);
				listBillInfo.Add(info);
			}

			return listBillInfo;
		}

		public void DeleteBillInfoByIDBill(int idBill)
		{
			DataProvider.Instance.ExecuteNonQuery("DELETE dbo.BillInfo WHERE idBill = " + idBill);
		}

		public void InsertBillInfo(int idBill, int idDrink, int count)
		{
			DataProvider.Instance.ExecuteNonQuery("EXEC USP_InsertBillInfo @idBill , @idDrink , @idCount", new object[] { idBill, idDrink, count });
		}

		public void DeleteBillInfoByFoodID(int id)
		{
			DataProvider.Instance.ExecuteQuery("delete dbo.BillInfo where idDrink = " + id);
		}

		public int GetMaxIDBill()
		{
			try
			{
				return (int)DataProvider.Instance.ExecuteScalar("SELECT MAX(id) FROM dbo.Bill");
			}
			catch
			{
				return 1;
			}
		}
	}
}
