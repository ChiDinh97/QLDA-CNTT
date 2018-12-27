using QuanLyQuanCafe.DAO;
using QuanLyQuanCafe.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyQuanCafe
{
	public partial class frmTableManager : Form
	{
		private Account loginAcc;

		public Account LoginAcc
		{
			get { return loginAcc; }
			set { loginAcc = value; ChangeAccount(loginAcc.Type); }
		}

		public frmTableManager(Account loginAcc)
		{
			InitializeComponent();

			this.LoginAcc = loginAcc;
			LoadTableList();
			LoadCategory();
		}

		#region methods
		void ChangeAccount(int type)
		{
			adminToolStripMenuItem2.Enabled = type == 1;
			thôngTinTàiKhoảnToolStripMenuItem2.Text += " [" + LoginAcc.DisplayName +"]";
		}

		public void LoadTableList()
		{
			flpTable.Controls.Clear();
			List<Table> lstTable = TableDAO.Instance.LoadTableList();

			foreach(Table item in lstTable)
			{
				Button btn = new Button() { Width = TableDAO.TableWidth, Height = TableDAO.TableHeight };
				btn.Text = item.Name + Environment.NewLine + item.Status;
				btn.Click += btn_Click;
				btn.Tag = item;

				if (item.Status == "Trống")
					btn.BackColor = Color.Beige;
				else
					btn.BackColor = Color.Chocolate;

				flpTable.Controls.Add(btn);
			}
		}

		void ShowBill(int id)
		{
			lsvBill.Items.Clear();
			float totalPrice = 0;
			List<QuanLyQuanCafe.DTO.Menu> listBillInfo = MenuDAO.Instance.GetListMenuByTable(id);

			foreach (QuanLyQuanCafe.DTO.Menu item in listBillInfo)
			{
				ListViewItem lsvItem = new ListViewItem(item.DrinkName.ToString());
				lsvItem.SubItems.Add(item.Count.ToString());
				lsvItem.SubItems.Add(item.Price.ToString());
				lsvItem.SubItems.Add(item.TotalPrice.ToString());
				totalPrice += item.TotalPrice;

				lsvBill.Items.Add(lsvItem);
			}

			//convert money currency into vnd
			CultureInfo culture = new CultureInfo("vi-VN");
			txtTongTien.Text = totalPrice.ToString("c", culture);
		}

		void LoadCategory()
		{
			List<Category> lstCategory = CategoryDAO.Instance.GetListCategory();
			cbbCategory.DataSource = lstCategory;
			cbbCategory.DisplayMember = "Name";
		}

		void LoadListCategoryByID(int id)
		{
			List<Drink> lstDrink = DrinkDAO.Instance.GetDrinkByCategory(id);
			cbbDrink.DataSource = lstDrink;
			cbbDrink.DisplayMember = "Name";
		}

		public void CheckOut(int id)
		{
			string query = "UPDATE dbo.Bill SET status = 1 WHERE id = " + id;
			DataProvider.Instance.ExecuteNonQuery(query);
		}

		#endregion

		#region event handlers

		void btn_Click(object sender, EventArgs e)
		{
			int tableID = ((sender as Button).Tag as Table).ID;
			lsvBill.Tag = (sender as Button).Tag;
			ShowBill(tableID);
		}

		private void btnDong_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void đăngXuấtToolStripMenuItem1_Click_1(object sender, EventArgs e)
		{
			Close();
		}

		private void thôngTinCáNhânToolStripMenuItem2_Click(object sender, EventArgs e)
		{
			frmProfile frm = new frmProfile(LoginAcc);
			frm.UpdateAccount += frm_UpdateAccount;
			frm.ShowDialog();
		}

		//apply change from frmProfile immediately into main form
		private void frm_UpdateAccount(object sender, AccountEvent e)
		{
			thôngTinTàiKhoảnToolStripMenuItem2.Text = "Thông tin tài khoản [" + e.Acc.DisplayName + "]";
		}

		private void adminToolStripMenuItem2_Click(object sender, EventArgs e)
		{
			frmAdmin frm = new frmAdmin();

			frm.loginAccount = LoginAcc;
			frm.InsertDrink += frm_InsertDrink;
			frm.UpdateDrink += frm_UpdateDrink;
			frm.DeleteDrink += frm_DeleteDrink;

			frm.ShowDialog();
		}

		private void frm_DeleteDrink(object sender, EventArgs e)
		{
			LoadListCategoryByID((cbbCategory.SelectedItem as Category).ID);
			if (lsvBill.Tag != null)
				ShowBill((lsvBill.Tag as Table).ID);
			LoadTableList();
		}

		private void frm_UpdateDrink(object sender, EventArgs e)
		{
			LoadListCategoryByID((cbbCategory.SelectedItem as Category).ID);
			if(lsvBill.Tag != null)
				ShowBill((lsvBill.Tag as Table).ID);
		}

		private void frm_InsertDrink(object sender, EventArgs e)
		{
			LoadListCategoryByID((cbbCategory.SelectedItem as Category).ID);
			if (lsvBill.Tag != null)
				ShowBill((lsvBill.Tag as Table).ID);
		}

		private void cbbCategory_SelectedIndexChanged(object sender, EventArgs e)
		{
			int id = 0;
			ComboBox cbb = sender as ComboBox;

			if (cbb.SelectedItem == null)
				return;

			Category selected = cbb.SelectedItem as Category;
			id = selected.ID;

			LoadListCategoryByID(id);
		}

		private void btnAdd_Click(object sender, EventArgs e)
		{
			Table table = lsvBill.Tag as Table;

			if (table == null)
			{
				MessageBox.Show("Hãy chọn bàn");
				return;
			}

			//get current id Bill
			int idBill = BillDAO.Instance.GetUncheckBillIDByTableID(table.ID);
			int idDrink = (cbbDrink.SelectedItem as Drink).Id;
			int count = (int)numSoLuong.Value;
			if(idBill == -1)    //not exist yet
			{
				BillDAO.Instance.InsertBill(table.ID);
				BillInfoDAO.Instance.InsertBillInfo(BillInfoDAO.Instance.GetMaxIDBill(), idDrink, count);
			}
			else
			{
				BillInfoDAO.Instance.InsertBillInfo(idBill, idDrink, count);
			}

			//refresh listview table 
			ShowBill(table.ID);
			LoadTableList();
		}

		private void btnThanhToan_Click(object sender, EventArgs e)
		{
			Table table = lsvBill.Tag as Table;
			int idBill = BillDAO.Instance.GetUncheckBillIDByTableID(table.ID);
			int discount = (int)numDiscount.Value;

			//try parse string into double
			string str = txtTongTien.Text.Split(',')[0];

			double totalPrice = double.Parse(str.Replace('.', ','));
			double totalPriceWDiscount = totalPrice - (totalPrice / 100) * discount;

			if (idBill != -1)
			{
				if (MessageBox.Show(String.Format("Bạn muốn thanh toán hóa đơn cho bàn {0}\n Tổng hóa đơn: {1} x {2}% = {3}",table.Name, totalPrice, discount, totalPriceWDiscount), "Thông báo", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
				{
					BillDAO.Instance.CheckOut(idBill, discount, (float)totalPriceWDiscount);
					ShowBill(table.ID);
				}
			}
			LoadTableList();
		}
		#endregion

	}
}
