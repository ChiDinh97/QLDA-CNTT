namespace QuanLyQuanCafe
{
	partial class frmTableManager
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
			this.panel1 = new System.Windows.Forms.Panel();
			this.label2 = new System.Windows.Forms.Label();
			this.btnDong = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.panel2 = new System.Windows.Forms.Panel();
			this.pnlTable = new System.Windows.Forms.Panel();
			this.flpTable = new System.Windows.Forms.FlowLayoutPanel();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.adminToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
			this.thôngTinTàiKhoảnToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
			this.thôngTinCáNhânToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
			this.đăngXuấtToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.adminToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.thôngTinTàiKhoảnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.thôngTinCáNhânToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.cáNhânToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.panel4 = new System.Windows.Forms.Panel();
			this.lsvBill = new System.Windows.Forms.ListView();
			this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.panel5 = new System.Windows.Forms.Panel();
			this.numSoLuong = new System.Windows.Forms.NumericUpDown();
			this.btnAdd = new System.Windows.Forms.Button();
			this.cbbDrink = new System.Windows.Forms.ComboBox();
			this.cbbCategory = new System.Windows.Forms.ComboBox();
			this.panel6 = new System.Windows.Forms.Panel();
			this.txtTongTien = new System.Windows.Forms.TextBox();
			this.numDiscount = new System.Windows.Forms.NumericUpDown();
			this.btnDiscount = new System.Windows.Forms.Button();
			this.btnThanhToan = new System.Windows.Forms.Button();
			this.comboBox2 = new System.Windows.Forms.ComboBox();
			this.button1 = new System.Windows.Forms.Button();
			this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.adminToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.thôngTinTàiKhoảnToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.thôngTinCáNhânToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.đăngXuấtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			this.pnlTable.SuspendLayout();
			this.menuStrip1.SuspendLayout();
			this.panel4.SuspendLayout();
			this.panel5.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numSoLuong)).BeginInit();
			this.panel6.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numDiscount)).BeginInit();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.Maroon;
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.btnDong);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(660, 29);
			this.panel1.TabIndex = 0;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.White;
			this.label2.Location = new System.Drawing.Point(3, 8);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(139, 16);
			this.label2.TabIndex = 1;
			this.label2.Text = "Quản lý Will Coffee";
			// 
			// btnDong
			// 
			this.btnDong.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.btnDong.Dock = System.Windows.Forms.DockStyle.Right;
			this.btnDong.Image = global::QuanLyQuanCafe.Properties.Resources.icons8_delete_filled_24__1_;
			this.btnDong.Location = new System.Drawing.Point(631, 0);
			this.btnDong.Name = "btnDong";
			this.btnDong.Size = new System.Drawing.Size(29, 29);
			this.btnDong.TabIndex = 0;
			this.btnDong.UseVisualStyleBackColor = true;
			this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.Peru;
			this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label1.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(0, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(660, 48);
			this.label1.TabIndex = 0;
			this.label1.Text = " WILL COFFEE";
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.label1);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel2.Location = new System.Drawing.Point(0, 29);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(660, 48);
			this.panel2.TabIndex = 1;
			// 
			// pnlTable
			// 
			this.pnlTable.Controls.Add(this.flpTable);
			this.pnlTable.Location = new System.Drawing.Point(6, 111);
			this.pnlTable.Name = "pnlTable";
			this.pnlTable.Size = new System.Drawing.Size(329, 390);
			this.pnlTable.TabIndex = 2;
			// 
			// flpTable
			// 
			this.flpTable.AutoScroll = true;
			this.flpTable.Dock = System.Windows.Forms.DockStyle.Fill;
			this.flpTable.Location = new System.Drawing.Point(0, 0);
			this.flpTable.Name = "flpTable";
			this.flpTable.Size = new System.Drawing.Size(329, 390);
			this.flpTable.TabIndex = 0;
			// 
			// menuStrip1
			// 
			this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adminToolStripMenuItem2,
            this.thôngTinTàiKhoảnToolStripMenuItem2});
			this.menuStrip1.Location = new System.Drawing.Point(6, 80);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(306, 24);
			this.menuStrip1.TabIndex = 3;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// adminToolStripMenuItem2
			// 
			this.adminToolStripMenuItem2.Name = "adminToolStripMenuItem2";
			this.adminToolStripMenuItem2.Size = new System.Drawing.Size(55, 20);
			this.adminToolStripMenuItem2.Text = "Admin";
			this.adminToolStripMenuItem2.Click += new System.EventHandler(this.adminToolStripMenuItem2_Click);
			// 
			// thôngTinTàiKhoảnToolStripMenuItem2
			// 
			this.thôngTinTàiKhoảnToolStripMenuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thôngTinCáNhânToolStripMenuItem2,
            this.đăngXuấtToolStripMenuItem1});
			this.thôngTinTàiKhoảnToolStripMenuItem2.Name = "thôngTinTàiKhoảnToolStripMenuItem2";
			this.thôngTinTàiKhoảnToolStripMenuItem2.Size = new System.Drawing.Size(123, 20);
			this.thôngTinTàiKhoảnToolStripMenuItem2.Text = "Thông tin tài khoản";
			// 
			// thôngTinCáNhânToolStripMenuItem2
			// 
			this.thôngTinCáNhânToolStripMenuItem2.Name = "thôngTinCáNhânToolStripMenuItem2";
			this.thôngTinCáNhânToolStripMenuItem2.Size = new System.Drawing.Size(180, 22);
			this.thôngTinCáNhânToolStripMenuItem2.Text = "Thông tin cá nhân";
			this.thôngTinCáNhânToolStripMenuItem2.Click += new System.EventHandler(this.thôngTinCáNhânToolStripMenuItem2_Click);
			// 
			// đăngXuấtToolStripMenuItem1
			// 
			this.đăngXuấtToolStripMenuItem1.Name = "đăngXuấtToolStripMenuItem1";
			this.đăngXuấtToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
			this.đăngXuấtToolStripMenuItem1.Text = "Đăng xuất";
			this.đăngXuấtToolStripMenuItem1.Click += new System.EventHandler(this.đăngXuấtToolStripMenuItem1_Click_1);
			// 
			// adminToolStripMenuItem
			// 
			this.adminToolStripMenuItem.Name = "adminToolStripMenuItem";
			this.adminToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
			// 
			// thôngTinTàiKhoảnToolStripMenuItem
			// 
			this.thôngTinTàiKhoảnToolStripMenuItem.Name = "thôngTinTàiKhoảnToolStripMenuItem";
			this.thôngTinTàiKhoảnToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
			// 
			// thôngTinCáNhânToolStripMenuItem
			// 
			this.thôngTinCáNhânToolStripMenuItem.Name = "thôngTinCáNhânToolStripMenuItem";
			this.thôngTinCáNhânToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
			// 
			// cáNhânToolStripMenuItem
			// 
			this.cáNhânToolStripMenuItem.Name = "cáNhânToolStripMenuItem";
			this.cáNhânToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
			// 
			// panel4
			// 
			this.panel4.Controls.Add(this.lsvBill);
			this.panel4.Location = new System.Drawing.Point(341, 169);
			this.panel4.Name = "panel4";
			this.panel4.Size = new System.Drawing.Size(315, 279);
			this.panel4.TabIndex = 4;
			// 
			// lsvBill
			// 
			this.lsvBill.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
			this.lsvBill.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lsvBill.Location = new System.Drawing.Point(0, 0);
			this.lsvBill.Name = "lsvBill";
			this.lsvBill.Size = new System.Drawing.Size(315, 279);
			this.lsvBill.TabIndex = 0;
			this.lsvBill.UseCompatibleStateImageBehavior = false;
			this.lsvBill.View = System.Windows.Forms.View.Details;
			// 
			// columnHeader1
			// 
			this.columnHeader1.Text = "Tên món";
			// 
			// columnHeader2
			// 
			this.columnHeader2.Text = "Số lượng";
			this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// columnHeader3
			// 
			this.columnHeader3.Text = "Đơn giá";
			this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// columnHeader4
			// 
			this.columnHeader4.Text = "Thành tiền";
			this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// panel5
			// 
			this.panel5.Controls.Add(this.numSoLuong);
			this.panel5.Controls.Add(this.btnAdd);
			this.panel5.Controls.Add(this.cbbDrink);
			this.panel5.Controls.Add(this.cbbCategory);
			this.panel5.Location = new System.Drawing.Point(341, 111);
			this.panel5.Name = "panel5";
			this.panel5.Size = new System.Drawing.Size(315, 58);
			this.panel5.TabIndex = 5;
			// 
			// numSoLuong
			// 
			this.numSoLuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.numSoLuong.Location = new System.Drawing.Point(175, 20);
			this.numSoLuong.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
			this.numSoLuong.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.numSoLuong.Name = "numSoLuong";
			this.numSoLuong.Size = new System.Drawing.Size(56, 22);
			this.numSoLuong.TabIndex = 3;
			this.numSoLuong.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.numSoLuong.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			// 
			// btnAdd
			// 
			this.btnAdd.Location = new System.Drawing.Point(237, 4);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size(75, 48);
			this.btnAdd.TabIndex = 2;
			this.btnAdd.Text = "Thêm";
			this.btnAdd.UseVisualStyleBackColor = true;
			this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
			// 
			// cbbDrink
			// 
			this.cbbDrink.FormattingEnabled = true;
			this.cbbDrink.Location = new System.Drawing.Point(4, 31);
			this.cbbDrink.Name = "cbbDrink";
			this.cbbDrink.Size = new System.Drawing.Size(165, 21);
			this.cbbDrink.TabIndex = 1;
			// 
			// cbbCategory
			// 
			this.cbbCategory.FormattingEnabled = true;
			this.cbbCategory.Location = new System.Drawing.Point(4, 4);
			this.cbbCategory.Name = "cbbCategory";
			this.cbbCategory.Size = new System.Drawing.Size(165, 21);
			this.cbbCategory.TabIndex = 0;
			this.cbbCategory.SelectedIndexChanged += new System.EventHandler(this.cbbCategory_SelectedIndexChanged);
			// 
			// panel6
			// 
			this.panel6.Controls.Add(this.txtTongTien);
			this.panel6.Controls.Add(this.numDiscount);
			this.panel6.Controls.Add(this.btnDiscount);
			this.panel6.Controls.Add(this.btnThanhToan);
			this.panel6.Location = new System.Drawing.Point(341, 448);
			this.panel6.Name = "panel6";
			this.panel6.Size = new System.Drawing.Size(315, 53);
			this.panel6.TabIndex = 6;
			// 
			// txtTongTien
			// 
			this.txtTongTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtTongTien.ForeColor = System.Drawing.Color.DarkRed;
			this.txtTongTien.Location = new System.Drawing.Point(106, 19);
			this.txtTongTien.Name = "txtTongTien";
			this.txtTongTien.ReadOnly = true;
			this.txtTongTien.Size = new System.Drawing.Size(100, 20);
			this.txtTongTien.TabIndex = 8;
			this.txtTongTien.Text = "0";
			this.txtTongTien.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// numDiscount
			// 
			this.numDiscount.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
			this.numDiscount.Location = new System.Drawing.Point(4, 29);
			this.numDiscount.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
			this.numDiscount.Name = "numDiscount";
			this.numDiscount.Size = new System.Drawing.Size(68, 20);
			this.numDiscount.TabIndex = 5;
			this.numDiscount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// btnDiscount
			// 
			this.btnDiscount.Location = new System.Drawing.Point(4, 6);
			this.btnDiscount.Name = "btnDiscount";
			this.btnDiscount.Size = new System.Drawing.Size(68, 20);
			this.btnDiscount.TabIndex = 4;
			this.btnDiscount.Text = "Giảm giá";
			this.btnDiscount.UseVisualStyleBackColor = true;
			// 
			// btnThanhToan
			// 
			this.btnThanhToan.Location = new System.Drawing.Point(237, 5);
			this.btnThanhToan.Name = "btnThanhToan";
			this.btnThanhToan.Size = new System.Drawing.Size(75, 46);
			this.btnThanhToan.TabIndex = 3;
			this.btnThanhToan.Text = "Thanh toán";
			this.btnThanhToan.UseVisualStyleBackColor = true;
			this.btnThanhToan.Click += new System.EventHandler(this.btnThanhToan_Click);
			// 
			// comboBox2
			// 
			this.comboBox2.FormattingEnabled = true;
			this.comboBox2.Location = new System.Drawing.Point(4, 31);
			this.comboBox2.Name = "comboBox2";
			this.comboBox2.Size = new System.Drawing.Size(209, 21);
			this.comboBox2.TabIndex = 1;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(219, 4);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 48);
			this.button1.TabIndex = 2;
			this.button1.Text = "button1";
			this.button1.UseVisualStyleBackColor = true;
			// 
			// flowLayoutPanel1
			// 
			this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 4);
			this.flowLayoutPanel1.Name = "flowLayoutPanel1";
			this.flowLayoutPanel1.Size = new System.Drawing.Size(341, 382);
			this.flowLayoutPanel1.TabIndex = 0;
			// 
			// comboBox1
			// 
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Location = new System.Drawing.Point(4, 23);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(75, 21);
			this.comboBox1.TabIndex = 7;
			// 
			// adminToolStripMenuItem1
			// 
			this.adminToolStripMenuItem1.Name = "adminToolStripMenuItem1";
			this.adminToolStripMenuItem1.Size = new System.Drawing.Size(32, 19);
			// 
			// thôngTinTàiKhoảnToolStripMenuItem1
			// 
			this.thôngTinTàiKhoảnToolStripMenuItem1.Name = "thôngTinTàiKhoảnToolStripMenuItem1";
			this.thôngTinTàiKhoảnToolStripMenuItem1.Size = new System.Drawing.Size(32, 19);
			// 
			// thôngTinCáNhânToolStripMenuItem1
			// 
			this.thôngTinCáNhânToolStripMenuItem1.Name = "thôngTinCáNhânToolStripMenuItem1";
			this.thôngTinCáNhânToolStripMenuItem1.Size = new System.Drawing.Size(32, 19);
			// 
			// đăngXuấtToolStripMenuItem
			// 
			this.đăngXuấtToolStripMenuItem.Name = "đăngXuấtToolStripMenuItem";
			this.đăngXuấtToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
			// 
			// frmTableManager
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.PaleGoldenrod;
			this.ClientSize = new System.Drawing.Size(660, 509);
			this.Controls.Add(this.panel6);
			this.Controls.Add(this.panel5);
			this.Controls.Add(this.panel4);
			this.Controls.Add(this.pnlTable);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.menuStrip1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "frmTableManager";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "frmTableManager";
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.panel2.ResumeLayout(false);
			this.pnlTable.ResumeLayout(false);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.panel4.ResumeLayout(false);
			this.panel5.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.numSoLuong)).EndInit();
			this.panel6.ResumeLayout(false);
			this.panel6.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.numDiscount)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnDong;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Panel pnlTable;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem adminToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem thôngTinTàiKhoảnToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem thôngTinCáNhânToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem cáNhânToolStripMenuItem;
		private System.Windows.Forms.Panel panel4;
		private System.Windows.Forms.Panel panel5;
		private System.Windows.Forms.Button btnAdd;
		private System.Windows.Forms.ComboBox cbbDrink;
		private System.Windows.Forms.ComboBox cbbCategory;
		private System.Windows.Forms.Panel panel6;
		private System.Windows.Forms.ComboBox comboBox2;
		private System.Windows.Forms.NumericUpDown numSoLuong;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.FlowLayoutPanel flpTable;
		private System.Windows.Forms.NumericUpDown numDiscount;
		private System.Windows.Forms.Button btnDiscount;
		private System.Windows.Forms.Button btnThanhToan;
		private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
		private System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.ToolStripMenuItem adminToolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem thôngTinTàiKhoảnToolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem thôngTinCáNhânToolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem đăngXuấtToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem adminToolStripMenuItem2;
		private System.Windows.Forms.ToolStripMenuItem thôngTinTàiKhoảnToolStripMenuItem2;
		private System.Windows.Forms.ToolStripMenuItem thôngTinCáNhânToolStripMenuItem2;
		private System.Windows.Forms.ToolStripMenuItem đăngXuấtToolStripMenuItem1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ListView lsvBill;
		private System.Windows.Forms.ColumnHeader columnHeader1;
		private System.Windows.Forms.ColumnHeader columnHeader2;
		private System.Windows.Forms.ColumnHeader columnHeader3;
		private System.Windows.Forms.ColumnHeader columnHeader4;
		private System.Windows.Forms.TextBox txtTongTien;
	}
}