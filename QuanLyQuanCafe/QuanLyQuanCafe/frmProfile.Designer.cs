namespace QuanLyQuanCafe
{
	partial class frmProfile
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.label1 = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.label7 = new System.Windows.Forms.Label();
			this.btnDong = new System.Windows.Forms.Button();
			this.txtTenDangNhap = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.txtTenHienThi = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.txtPassword = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.txtMatKhauMoi = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.txtConfirmMK = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.btnLuu = new System.Windows.Forms.Button();
			this.btnHuy = new System.Windows.Forms.Button();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.Peru;
			this.label1.Dock = System.Windows.Forms.DockStyle.Top;
			this.label1.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(0, 29);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(354, 39);
			this.label1.TabIndex = 1;
			this.label1.Text = " WILL COFFEE";
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.Maroon;
			this.panel1.Controls.Add(this.label7);
			this.panel1.Controls.Add(this.btnDong);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(354, 29);
			this.panel1.TabIndex = 2;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.BackColor = System.Drawing.Color.Maroon;
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.ForeColor = System.Drawing.Color.White;
			this.label7.Location = new System.Drawing.Point(3, 8);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(130, 16);
			this.label7.TabIndex = 1;
			this.label7.Text = "Thông tin cá nhân";
			// 
			// btnDong
			// 
			this.btnDong.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.btnDong.Dock = System.Windows.Forms.DockStyle.Right;
			this.btnDong.Image = global::QuanLyQuanCafe.Properties.Resources.icons8_delete_filled_24__1_;
			this.btnDong.Location = new System.Drawing.Point(325, 0);
			this.btnDong.Name = "btnDong";
			this.btnDong.Size = new System.Drawing.Size(29, 29);
			this.btnDong.TabIndex = 0;
			this.btnDong.UseVisualStyleBackColor = true;
			this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
			// 
			// txtTenDangNhap
			// 
			this.txtTenDangNhap.Location = new System.Drawing.Point(148, 96);
			this.txtTenDangNhap.Name = "txtTenDangNhap";
			this.txtTenDangNhap.ReadOnly = true;
			this.txtTenDangNhap.Size = new System.Drawing.Size(168, 20);
			this.txtTenDangNhap.TabIndex = 7;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(38, 98);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(99, 16);
			this.label2.TabIndex = 6;
			this.label2.Text = "Tên đăng nhập";
			// 
			// txtTenHienThi
			// 
			this.txtTenHienThi.Location = new System.Drawing.Point(148, 138);
			this.txtTenHienThi.Name = "txtTenHienThi";
			this.txtTenHienThi.Size = new System.Drawing.Size(168, 20);
			this.txtTenHienThi.TabIndex = 9;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(38, 140);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(76, 16);
			this.label3.TabIndex = 8;
			this.label3.Text = "Tên hiển thị";
			// 
			// txtPassword
			// 
			this.txtPassword.Location = new System.Drawing.Point(148, 180);
			this.txtPassword.Name = "txtPassword";
			this.txtPassword.Size = new System.Drawing.Size(168, 20);
			this.txtPassword.TabIndex = 11;
			this.txtPassword.UseSystemPasswordChar = true;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(38, 182);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(62, 16);
			this.label4.TabIndex = 10;
			this.label4.Text = "Mật khẩu";
			// 
			// txtMatKhauMoi
			// 
			this.txtMatKhauMoi.Location = new System.Drawing.Point(148, 222);
			this.txtMatKhauMoi.Name = "txtMatKhauMoi";
			this.txtMatKhauMoi.Size = new System.Drawing.Size(168, 20);
			this.txtMatKhauMoi.TabIndex = 13;
			this.txtMatKhauMoi.UseSystemPasswordChar = true;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(38, 224);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(87, 16);
			this.label5.TabIndex = 12;
			this.label5.Text = "Mật khẩu mới";
			// 
			// txtConfirmMK
			// 
			this.txtConfirmMK.Location = new System.Drawing.Point(148, 264);
			this.txtConfirmMK.Name = "txtConfirmMK";
			this.txtConfirmMK.Size = new System.Drawing.Size(168, 20);
			this.txtConfirmMK.TabIndex = 15;
			this.txtConfirmMK.UseSystemPasswordChar = true;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(38, 266);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(63, 16);
			this.label6.TabIndex = 14;
			this.label6.Text = "Xác nhận";
			// 
			// btnLuu
			// 
			this.btnLuu.Location = new System.Drawing.Point(160, 298);
			this.btnLuu.Name = "btnLuu";
			this.btnLuu.Size = new System.Drawing.Size(75, 23);
			this.btnLuu.TabIndex = 16;
			this.btnLuu.Text = "Lưu";
			this.btnLuu.UseVisualStyleBackColor = true;
			this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
			// 
			// btnHuy
			// 
			this.btnHuy.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnHuy.Location = new System.Drawing.Point(241, 298);
			this.btnHuy.Name = "btnHuy";
			this.btnHuy.Size = new System.Drawing.Size(75, 23);
			this.btnHuy.TabIndex = 17;
			this.btnHuy.Text = "Hủy";
			this.btnHuy.UseVisualStyleBackColor = true;
			this.btnHuy.Click += new System.EventHandler(this.btnDong_Click);
			// 
			// frmProfile
			// 
			this.AcceptButton = this.btnLuu;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.PaleGoldenrod;
			this.CancelButton = this.btnHuy;
			this.ClientSize = new System.Drawing.Size(354, 333);
			this.Controls.Add(this.btnHuy);
			this.Controls.Add(this.btnLuu);
			this.Controls.Add(this.txtConfirmMK);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.txtMatKhauMoi);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.txtPassword);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.txtTenHienThi);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.txtTenDangNhap);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.panel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "frmProfile";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "frmProfile";
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button btnDong;
		private System.Windows.Forms.TextBox txtTenDangNhap;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtTenHienThi;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtPassword;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtMatKhauMoi;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox txtConfirmMK;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Button btnLuu;
		private System.Windows.Forms.Button btnHuy;
		private System.Windows.Forms.Label label7;
	}
}