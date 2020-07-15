namespace QuanLyCuaHang
{
    partial class SuaNCC
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
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.cbbMaNCC = new System.Windows.Forms.ComboBox();
            this.labMaKhach = new System.Windows.Forms.Label();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.labSDT = new System.Windows.Forms.Label();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.labDiaChi = new System.Windows.Forms.Label();
            this.labHoDem = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnHuy
            // 
            this.btnHuy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHuy.Location = new System.Drawing.Point(260, 244);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(75, 23);
            this.btnHuy.TabIndex = 55;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnSua
            // 
            this.btnSua.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSua.Location = new System.Drawing.Point(128, 244);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 23);
            this.btnSua.TabIndex = 54;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // cbbMaNCC
            // 
            this.cbbMaNCC.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbMaNCC.FormattingEnabled = true;
            this.cbbMaNCC.Location = new System.Drawing.Point(133, 19);
            this.cbbMaNCC.Name = "cbbMaNCC";
            this.cbbMaNCC.Size = new System.Drawing.Size(236, 21);
            this.cbbMaNCC.TabIndex = 53;
            this.cbbMaNCC.SelectedIndexChanged += new System.EventHandler(this.cbbMaNCC_SelectedIndexChanged);
            // 
            // labMaKhach
            // 
            this.labMaKhach.AutoSize = true;
            this.labMaKhach.Location = new System.Drawing.Point(49, 27);
            this.labMaKhach.Name = "labMaKhach";
            this.labMaKhach.Size = new System.Drawing.Size(50, 13);
            this.labMaKhach.TabIndex = 52;
            this.labMaKhach.Text = "Mã NCC:";
            // 
            // txtSDT
            // 
            this.txtSDT.Location = new System.Drawing.Point(133, 177);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(236, 20);
            this.txtSDT.TabIndex = 45;
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(133, 125);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(236, 20);
            this.txtDiaChi.TabIndex = 44;
            // 
            // labSDT
            // 
            this.labSDT.AutoSize = true;
            this.labSDT.Location = new System.Drawing.Point(47, 184);
            this.labSDT.Name = "labSDT";
            this.labSDT.Size = new System.Drawing.Size(73, 13);
            this.labSDT.TabIndex = 51;
            this.labSDT.Text = "Số điện thoại:";
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(133, 75);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(236, 20);
            this.txtHoTen.TabIndex = 40;
            // 
            // labDiaChi
            // 
            this.labDiaChi.AutoSize = true;
            this.labDiaChi.Location = new System.Drawing.Point(47, 128);
            this.labDiaChi.Name = "labDiaChi";
            this.labDiaChi.Size = new System.Drawing.Size(43, 13);
            this.labDiaChi.TabIndex = 49;
            this.labDiaChi.Text = "Địa chỉ:";
            // 
            // labHoDem
            // 
            this.labHoDem.AutoSize = true;
            this.labHoDem.Location = new System.Drawing.Point(49, 82);
            this.labHoDem.Name = "labHoDem";
            this.labHoDem.Size = new System.Drawing.Size(46, 13);
            this.labHoDem.TabIndex = 47;
            this.labHoDem.Text = "Họ Tên:";
            // 
            // SuaNCC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(436, 300);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.cbbMaNCC);
            this.Controls.Add(this.labMaKhach);
            this.Controls.Add(this.txtSDT);
            this.Controls.Add(this.txtDiaChi);
            this.Controls.Add(this.labSDT);
            this.Controls.Add(this.txtHoTen);
            this.Controls.Add(this.labDiaChi);
            this.Controls.Add(this.labHoDem);
            this.Name = "SuaNCC";
            this.Text = "SuaNCC";
            this.Load += new System.EventHandler(this.SuaNCC_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.ComboBox cbbMaNCC;
        private System.Windows.Forms.Label labMaKhach;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.Label labSDT;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.Label labDiaChi;
        private System.Windows.Forms.Label labHoDem;
    }
}