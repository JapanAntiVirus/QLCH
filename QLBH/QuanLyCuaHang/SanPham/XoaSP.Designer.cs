namespace QuanLyCuaHang
{
    partial class XoaSanPham
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
            this.labMaSP = new System.Windows.Forms.Label();
            this.btnXoaSP = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.cbbMaSP = new System.Windows.Forms.ComboBox();
            this.cbbKieuXoa = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // labMaSP
            // 
            this.labMaSP.AutoSize = true;
            this.labMaSP.Location = new System.Drawing.Point(35, 20);
            this.labMaSP.Name = "labMaSP";
            this.labMaSP.Size = new System.Drawing.Size(58, 13);
            this.labMaSP.TabIndex = 1;
            this.labMaSP.Text = "Sản phẩm:";
            // 
            // btnXoaSP
            // 
            this.btnXoaSP.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXoaSP.Location = new System.Drawing.Point(38, 126);
            this.btnXoaSP.Name = "btnXoaSP";
            this.btnXoaSP.Size = new System.Drawing.Size(75, 23);
            this.btnXoaSP.TabIndex = 1;
            this.btnXoaSP.Text = "Xóa";
            this.btnXoaSP.UseVisualStyleBackColor = true;
            this.btnXoaSP.Click += new System.EventHandler(this.btnXoaSP_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.Location = new System.Drawing.Point(183, 126);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Hủy";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // cbbMaSP
            // 
            this.cbbMaSP.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbMaSP.FormattingEnabled = true;
            this.cbbMaSP.Location = new System.Drawing.Point(183, 46);
            this.cbbMaSP.Name = "cbbMaSP";
            this.cbbMaSP.Size = new System.Drawing.Size(120, 21);
            this.cbbMaSP.TabIndex = 3;
            // 
            // cbbKieuXoa
            // 
            this.cbbKieuXoa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbKieuXoa.FormattingEnabled = true;
            this.cbbKieuXoa.Location = new System.Drawing.Point(38, 46);
            this.cbbKieuXoa.Name = "cbbKieuXoa";
            this.cbbKieuXoa.Size = new System.Drawing.Size(121, 21);
            this.cbbKieuXoa.TabIndex = 4;
            this.cbbKieuXoa.SelectedIndexChanged += new System.EventHandler(this.cbbKieuXoa_SelectedIndexChanged);
            // 
            // XoaSanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(390, 191);
            this.Controls.Add(this.cbbKieuXoa);
            this.Controls.Add(this.cbbMaSP);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnXoaSP);
            this.Controls.Add(this.labMaSP);
            this.Name = "XoaSanPham";
            this.Text = "Xóa sản phẩm";
            this.Load += new System.EventHandler(this.XoaSanPham_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labMaSP;
        private System.Windows.Forms.Button btnXoaSP;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ComboBox cbbMaSP;
        private System.Windows.Forms.ComboBox cbbKieuXoa;
    }
}