using QuanLyQuanCafe.DAO;
using QuanLyQuanCafe.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyQuanCafe
{
	public partial class frmProfile : Form
	{
		private Account loginAcc;
		public Account LoginAcc
		{
			get { return loginAcc; }
			set { loginAcc = value; ChangeAccount(LoginAcc); }
		}

		void ChangeAccount(Account acc)
		{
			txtTenDangNhap.Text = LoginAcc.UserName;
			txtTenHienThi.Text = LoginAcc.DisplayName;
		}

		void UpdateAccountInfo()
		{
			string displayName = txtTenHienThi.Text;
			string password = txtPassword.Text;
			string newpass = txtMatKhauMoi.Text;
			string reenterPass = txtConfirmMK.Text;
			string userName = txtTenDangNhap.Text;

			if(!newpass.Equals(reenterPass))
			{
				MessageBox.Show("Vui lòng nhập lại mật khẩu đúng với mật khẩu mới!");
			}
			else
			{
				if(AccountDAO.Instance.UpdateAccount(userName,displayName,password,newpass))
				{
					MessageBox.Show("Cập nhật thành công");
					if (updateAccount != null)
						updateAccount(this, new AccountEvent(AccountDAO.Instance.GetAcountByUserName(userName)));
				}
				else
				{
					MessageBox.Show("Vui lòng nhập đúng mật khẩu!");
				}
			}
		}

		public frmProfile(Account loginAcc)
		{
			InitializeComponent();
			this.LoginAcc = loginAcc;
		}

		private event EventHandler<AccountEvent> updateAccount;
		public event EventHandler<AccountEvent> UpdateAccount
		{
			add { updateAccount += value; }
			remove { updateAccount -= value; }
		}

		private void btnDong_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void btnLuu_Click(object sender, EventArgs e)
		{
			UpdateAccountInfo();
		}
	}

	public class AccountEvent:EventArgs
	{
		private Account acc;
		public AccountEvent(Account acc)
		{
			this.Acc = acc;
		}

		public Account Acc { get => acc; set => acc = value; }
	}
}
