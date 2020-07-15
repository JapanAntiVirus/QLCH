namespace QuanLyCuaHang
{
    partial class XoaNhanVien
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
            this.cbbKieuXoa = new System.Windows.Forms.ComboBox();
            this.cbbMaNV = new System.Windows.Forms.ComboBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnXoaNV = new System.Windows.Forms.Button();
            this.labNhanVien = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cbbKieuXoa
            // 
            this.cbbKieuXoa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbKieuXoa.FormattingEnabled = true;
            this.cbbKieuXoa.Location = new System.Drawing.Point(91, 85);
            this.cbbKieuXoa.Name = "cbbKieuXoa";
            this.cbbKieuXoa.Size = new System.Drawing.Size(121, 21);
            this.cbbKieuXoa.TabIndex = 9;
            this.cbbKieuXoa.SelectedIndexChanged += new System.EventHandler(this.cbbKieuXoa_SelectedIndexChanged);
            // 
            // cbbMaNV
            // 
            this.cbbMaNV.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbMaNV.FormattingEnabled = true;
            this.cbbMaNV.Location = new System.Drawing.Point(236, 85);
            this.cbbMaNV.Name = "cbbMaNV";
            this.cbbMaNV.Size = new System.Drawing.Size(120, 21);
            this.cbbMaNV.TabIndex = 8;
            // 
            // btnCancel
            // 
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.Location = new System.Drawing.Point(208, 165);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Hủy";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnXoaNV
            // 
            this.btnXoaNV.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXoaNV.Location = new System.Drawing.Point(91, 165);
            this.btnXoaNV.Name = "btnXoaNV";
            this.btnXoaNV.Size = new System.Drawing.Size(75, 23);
            this.btnXoaNV.TabIndex = 5;
            this.btnXoaNV.Text = "Xóa";
            this.btnXoaNV.UseVisualStyleBackColor = true;
            this.btnXoaNV.Click += new System.EventHandler(this.btnXoaSP_Click);
            // 
            // labNhanVien
            // 
            this.labNhanVien.AutoSize = true;
            this.labNhanVien.Location = new System.Drawing.Point(88, 59);
            this.labNhanVien.Name = "labNhanVien";
            this.labNhanVien.Size = new System.Drawing.Size(59, 13);
            this.labNhanVien.TabIndex = 6;
            this.labNhanVien.Text = "Nhân viên:";
            // 
            // XoaNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(470, 272);
            this.Controls.Add(this.cbbKieuXoa);
            this.Controls.Add(this.cbbMaNV);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnXoaNV);
            this.Controls.Add(this.labNhanVien);
            this.Name = "XoaNhanVien";
            this.Text = "Xóa nhân viên";
            this.Load += new System.EventHandler(this.XoaNhanVien_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbbKieuXoa;
        private System.Windows.Forms.ComboBox cbbMaNV;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnXoaNV;
        private System.Windows.Forms.Label labNhanVien;
    }
}