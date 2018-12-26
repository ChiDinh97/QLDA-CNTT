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
	public partial class frmLogin : Form
	{
		public frmLogin()
		{
			InitializeComponent();
		}

		private void btnHuy_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void btnDangNhap_Click(object sender, EventArgs e)
		{
			string Username = txtTenDangNhap.Text;
			string Password = txtMatKhau.Text;

			if (Login(Username, Password))
			{
				Account loginAcc = AccountDAO.Instance.GetAcountByUserName(Username);
				frmTableManager frm = new frmTableManager(loginAcc);
				this.Hide();
				frm.ShowDialog();
				this.Show();
			}
			else
			{
				MessageBox.Show("Đăng nhập thất bại");
			}
		}

		public bool Login(string UserName, string Password)
		{
			return AccountDAO.Instance.Login(UserName, Password);
		}
	}
}
