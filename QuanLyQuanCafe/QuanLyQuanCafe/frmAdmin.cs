using QuanLyQuanCafe.DAO;
using QuanLyQuanCafe.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyQuanCafe
{
	public partial class frmAdmin : Form
	{
		BindingSource drinkList = new BindingSource();
		BindingSource accountList = new BindingSource();

		public Account loginAccount;

		public frmAdmin()
		{
			InitializeComponent();
			LoadDateTimePicker();
			LoadListBillByDate(dtpCheckIn.Value, dtpCheckOut.Value);
			dgvThucAn.DataSource = drinkList;
			dgvAccount.DataSource = accountList;
			LoadListDrink();
			LoadAccount();
			AddDrinkBinding();
			AddAccountBinding();
			LoadCategoryIntoComboBox(cbbLoai);
		}

		#region method

		void LoadAccount()
		{
			accountList.DataSource = AccountDAO.Instance.GetListAccount();
		}

		List<Drink> SearchDrinkByName(string name)
		{
			List<Drink> listDrink = DrinkDAO.Instance.SearchDrinkByName(name);

			return listDrink;
		}

		void AddAccountBinding()
		{
			txtTenDangNhap.DataBindings.Add(new Binding("Text", dgvAccount.DataSource, "UserName", true, DataSourceUpdateMode.Never));
			txtTenHienThi.DataBindings.Add(new Binding("Text", dgvAccount.DataSource, "DisplayName", true, DataSourceUpdateMode.Never));
			nmAccType.DataBindings.Add(new Binding("Value", dgvAccount.DataSource, "Type", true, DataSourceUpdateMode.Never));
		}

		void AddDrinkBinding()
		{
			//prevent text change on textbox affect to data grid view
			txtTenMon.DataBindings.Add(new Binding("Text", dgvThucAn.DataSource, "Name",true,DataSourceUpdateMode.Never));
			txtMaMon.DataBindings.Add(new Binding("Text", dgvThucAn.DataSource, "ID", true, DataSourceUpdateMode.Never));
			nmGia.DataBindings.Add(new Binding("Value", dgvThucAn.DataSource, "Price", true, DataSourceUpdateMode.Never));
		}

		void LoadCategoryIntoComboBox(ComboBox cb)
		{
			cbbLoai.DataSource = CategoryDAO.Instance.GetListCategory();
			cbbLoai.DisplayMember = "Name";
		}

		void LoadListDrink()
		{
			drinkList.DataSource = DrinkDAO.Instance.GetListDrink();
		}

		//load date time picker of one month
		void LoadDateTimePicker()
		{
			DateTime today = DateTime.Now;
			dtpCheckIn.Value = new DateTime(today.Year, today.Month, 1);
			dtpCheckOut.Value = dtpCheckIn.Value.AddMonths(1).AddDays(-1);
		}
		
		void LoadListBillByDate(DateTime checkIn, DateTime checkOut)
		{
			dgvDoanhThu.DataSource = BillDAO.Instance.GetListBillByDate(checkIn, checkOut);
		}

		void AddAccount(string userName, string displayName, int type)
		{
			if (AccountDAO.Instance.InsertAccount(userName, displayName, type))
			{
				MessageBox.Show("Thêm tài khoản mới thành công");
			}
			else
			{
				MessageBox.Show("Thêm tài khoản thất bại!");
			}

			LoadAccount();
		}

		void EditAccount(string userName, string displayName, int type)
		{
			if (AccountDAO.Instance.UpdateAccount(userName, displayName, type))
			{
				MessageBox.Show("Cập nhật tài khoản mới thành công");
			}
			else
			{
				MessageBox.Show("Cập nhật tài khoản thất bại!");
			}

			LoadAccount();
		}

		void DeleteAccount(string userName)
		{
			if(loginAccount.UserName.Equals(userName))
			{
				MessageBox.Show("Tài khoản đang đăng nhập không thể xóa!!!");
				return;
			}
			if (AccountDAO.Instance.DeleteAccount(userName))
			{
				MessageBox.Show("Xóa tài khoản mới thành công");
			}
			else
			{
				MessageBox.Show("Xóa tài khoản thất bại!");
			}

			LoadAccount();
		}

		void ResetPassword(string userName)
		{
			if(AccountDAO.Instance.ResetPass(userName))
			{
				MessageBox.Show("Reset mật khẩu thành công");
			}
			else
			{
				MessageBox.Show("Reset mật khẩu không thành công");
			}
		}
		#endregion

		#region event handler
		private void btnSearchMon_Click(object sender, EventArgs e)
		{
			drinkList.DataSource = SearchDrinkByName(txtTimThucAn.Text);
		}

		private void btnDong_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void btnThongKe_Click(object sender, EventArgs e)
		{
			LoadListBillByDate(dtpCheckIn.Value, dtpCheckOut.Value);
		}

		private void btnXemMon_Click(object sender, EventArgs e)
		{
			LoadListDrink();
		}

		private void txtMaMon_TextChanged(object sender, EventArgs e)
		{
			try
			{
				if (dgvThucAn.SelectedCells.Count > 0)
				{
					int id = (int)dgvThucAn.SelectedCells[0].OwningRow.Cells["CategoryID"].Value;

					Category category = CategoryDAO.Instance.GetCategoryByID(id);

					cbbLoai.SelectedItem = category;

					int index = -1;
					int i = 0;
					foreach (Category item in cbbLoai.Items)
					{
						if (item.ID == category.ID)
						{
							index = i;
							break;
						}
						i++;
					}
					cbbLoai.SelectedIndex = index;
				}
			}
			catch { }
		}

		private void btnThemMon_Click(object sender, EventArgs e)
		{
			string name = txtTenMon.Text;
			int categoryID = (cbbLoai.SelectedItem as Category).ID;
			float price = (float)nmGia.Value;

			if (DrinkDAO.Instance.InsertDrink(name, categoryID, price))
			{
				MessageBox.Show("Thêm món thành công");
				LoadListDrink();
				if (insertDrink != null)
					insertDrink(this, new EventArgs());
			}
			else
			{
				MessageBox.Show("Thêm không thành công!");
			}
		}

		private void btnSuaMon_Click(object sender, EventArgs e)
		{
			string name = txtTenMon.Text;
			int categoryID = (cbbLoai.SelectedItem as Category).ID;
			float price = (float)nmGia.Value;
			int id = Convert.ToInt32(txtMaMon.Text);

			if (DrinkDAO.Instance.UpdateDrink(id, name, categoryID, price))
			{
				MessageBox.Show("Sửa món thành công");
				LoadListDrink();
				if (updateDrink != null)
					updateDrink(this, new EventArgs());
			}
			else
			{
				MessageBox.Show("Sửa không thành công!");
			}
		}

		private void btnXoaMon_Click(object sender, EventArgs e)
		{
			int id = Convert.ToInt32(txtMaMon.Text);

			if (DrinkDAO.Instance.DeleteDrink(id))
			{
				MessageBox.Show("Xoá món thành công");
				LoadListDrink();
				if (deleteDrink != null)
					deleteDrink(this, new EventArgs());
			}
			else
			{
				MessageBox.Show("Xóa không thành công!");
			}
		}

		private void btnThemAcc_Click(object sender, EventArgs e)
		{
			string userName = txtTenDangNhap.Text;
			string displayName = txtTenHienThi.Text;
			int type = (int)nmAccType.Value;

			AddAccount(userName, displayName, type);
		}

		private void btnXoaAcc_Click(object sender, EventArgs e)
		{
			string userName = txtTenDangNhap.Text;

			DeleteAccount(userName);
		}

		private void btnSuaAcc_Click(object sender, EventArgs e)
		{
			string userName = txtTenDangNhap.Text;
			string displayName = txtTenHienThi.Text;
			int type = (int)nmAccType.Value;

			EditAccount(userName, displayName, type);
		}

		private void btnXemAcc_Click(object sender, EventArgs e)
		{
			LoadAccount();
		}

		private void btnResetMK_Click(object sender, EventArgs e)
		{
			string userName = txtTenDangNhap.Text;
			ResetPassword(userName);
		}

		private event EventHandler insertDrink;
		public event EventHandler InsertDrink
		{
			add { insertDrink += value; }
			remove { insertDrink -= value; }
		}

		private event EventHandler updateDrink;
		public event EventHandler UpdateDrink
		{
			add { updateDrink += value; }
			remove { updateDrink -= value; }
		}

		private event EventHandler deleteDrink;
		public event EventHandler DeleteDrink
		{
			add { deleteDrink += value; }
			remove { deleteDrink -= value; }
		}


		#endregion

	}
} 
