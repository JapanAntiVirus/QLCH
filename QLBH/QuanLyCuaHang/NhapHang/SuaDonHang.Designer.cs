namespace QuanLyCuaHang
{
    partial class SuaDonHang
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
            this.numSoLuong = new System.Windows.Forms.NumericUpDown();
            this.dtpNgayNhap = new System.Windows.Forms.DateTimePicker();
            this.labNgaySinh = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.labSoLuong = new System.Windows.Forms.Label();
            this.cbbMaSP = new System.Windows.Forms.ComboBox();
            this.labMaSP = new System.Windows.Forms.Label();
            this.cbbDonHang = new System.Windows.Forms.ComboBox();
            this.labMaKhach = new System.Windows.Forms.Label();
            this.cbbMaNCC = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numSoLuong)).BeginInit();
            this.SuspendLayout();
            // 
            // numSoLuong
            // 
            this.numSoLuong.Location = new System.Drawing.Point(539, 17);
            this.numSoLuong.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numSoLuong.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numSoLuong.Name = "numSoLuong";
            this.numSoLuong.Size = new System.Drawing.Size(135, 20);
            this.numSoLuong.TabIndex = 83;
            this.numSoLuong.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // dtpNgayNhap
            // 
            this.dtpNgayNhap.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayNhap.Location = new System.Drawing.Point(539, 97);
            this.dtpNgayNhap.Name = "dtpNgayNhap";
            this.dtpNgayNhap.Size = new System.Drawing.Size(135, 20);
            this.dtpNgayNhap.TabIndex = 81;
            this.dtpNgayNhap.Value = new System.DateTime(1998, 1, 1, 10, 3, 0, 0);
            // 
            // labNgaySinh
            // 
            this.labNgaySinh.AutoSize = true;
            this.labNgaySinh.Location = new System.Drawing.Point(403, 103);
            this.labNgaySinh.Name = "labNgaySinh";
            this.labNgaySinh.Size = new System.Drawing.Size(62, 13);
            this.labNgaySinh.TabIndex = 82;
            this.labNgaySinh.Text = "Ngày nhập:";
            // 
            // btnClose
            // 
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Location = new System.Drawing.Point(390, 226);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 35);
            this.btnClose.TabIndex = 78;
            this.btnClose.Text = "Thoát";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSua
            // 
            this.btnSua.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSua.Location = new System.Drawing.Point(168, 226);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 35);
            this.btnSua.TabIndex = 75;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // labSoLuong
            // 
            this.labSoLuong.AutoSize = true;
            this.labSoLuong.Location = new System.Drawing.Point(403, 24);
            this.labSoLuong.Name = "labSoLuong";
            this.labSoLuong.Size = new System.Drawing.Size(52, 13);
            this.labSoLuong.TabIndex = 80;
            this.labSoLuong.Text = "Số lượng:";
            // 
            // cbbMaSP
            // 
            this.cbbMaSP.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbMaSP.FormattingEnabled = true;
            this.cbbMaSP.Location = new System.Drawing.Point(168, 83);
            this.cbbMaSP.Name = "cbbMaSP";
            this.cbbMaSP.Size = new System.Drawing.Size(135, 21);
            this.cbbMaSP.TabIndex = 74;
            // 
            // labMaSP
            // 
            this.labMaSP.AutoSize = true;
            this.labMaSP.Location = new System.Drawing.Point(60, 86);
            this.labMaSP.Name = "labMaSP";
            this.labMaSP.Size = new System.Drawing.Size(74, 13);
            this.labMaSP.TabIndex = 73;
            this.labMaSP.Text = "Mã sản phẩm:";
            // 
            // cbbDonHang
            // 
            this.cbbDonHang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbDonHang.FormattingEnabled = true;
            this.cbbDonHang.Location = new System.Drawing.Point(168, 19);
            this.cbbDonHang.Name = "cbbDonHang";
            this.cbbDonHang.Size = new System.Drawing.Size(135, 21);
            this.cbbDonHang.TabIndex = 72;
            this.cbbDonHang.SelectedIndexChanged += new System.EventHandler(this.cbbMaNCC_SelectedIndexChanged);
            // 
            // labMaKhach
            // 
            this.labMaKhach.AutoSize = true;
            this.labMaKhach.Location = new System.Drawing.Point(60, 22);
            this.labMaKhach.Name = "labMaKhach";
            this.labMaKhach.Size = new System.Drawing.Size(74, 13);
            this.labMaKhach.TabIndex = 71;
            this.labMaKhach.Text = "Mã đơn hàng:";
            // 
            // cbbMaNCC
            // 
            this.cbbMaNCC.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbMaNCC.FormattingEnabled = true;
            this.cbbMaNCC.Location = new System.Drawing.Point(168, 144);
            this.cbbMaNCC.Name = "cbbMaNCC";
            this.cbbMaNCC.Size = new System.Drawing.Size(135, 21);
            this.cbbMaNCC.TabIndex = 85;
            this.cbbMaNCC.SelectedIndexChanged += new System.EventHandler(this.cbbMaNCC_SelectedIndexChanged_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 152);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 84;
            this.label1.Text = "Mã NCC:";
            // 
            // SuaDonHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(709, 292);
            this.Controls.Add(this.cbbMaNCC);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numSoLuong);
            this.Controls.Add(this.dtpNgayNhap);
            this.Controls.Add(this.labNgaySinh);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.labSoLuong);
            this.Controls.Add(this.cbbMaSP);
            this.Controls.Add(this.labMaSP);
            this.Controls.Add(this.cbbDonHang);
            this.Controls.Add(this.labMaKhach);
            this.Name = "SuaDonHang";
            this.Text = "Sửa đơn hàng";
            this.Load += new System.EventHandler(this.SuaDonHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numSoLuong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numSoLuong;
        private System.Windows.Forms.DateTimePicker dtpNgayNhap;
        private System.Windows.Forms.Label labNgaySinh;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Label labSoLuong;
        private System.Windows.Forms.ComboBox cbbMaSP;
        private System.Windows.Forms.Label labMaSP;
        private System.Windows.Forms.ComboBox cbbDonHang;
        private System.Windows.Forms.Label labMaKhach;
        private System.Windows.Forms.ComboBox cbbMaNCC;
        private System.Windows.Forms.Label label1;
    }
}