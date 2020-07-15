namespace QuanLyCuaHang
{
    partial class XoaDonHang
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
            this.button2 = new System.Windows.Forms.Button();
            this.Xóa = new System.Windows.Forms.Button();
            this.cbbMaNhap = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(200, 114);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "Hủy";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Xóa
            // 
            this.Xóa.Location = new System.Drawing.Point(54, 114);
            this.Xóa.Name = "Xóa";
            this.Xóa.Size = new System.Drawing.Size(75, 23);
            this.Xóa.TabIndex = 6;
            this.Xóa.Text = "Xóa";
            this.Xóa.UseVisualStyleBackColor = true;
            this.Xóa.Click += new System.EventHandler(this.Xóa_Click);
            // 
            // cbbMaNhap
            // 
            this.cbbMaNhap.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbMaNhap.FormattingEnabled = true;
            this.cbbMaNhap.Location = new System.Drawing.Point(154, 43);
            this.cbbMaNhap.Name = "cbbMaNhap";
            this.cbbMaNhap.Size = new System.Drawing.Size(121, 21);
            this.cbbMaNhap.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Mã đơn hàng:";
            // 
            // XoaDonHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(328, 188);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Xóa);
            this.Controls.Add(this.cbbMaNhap);
            this.Controls.Add(this.label1);
            this.Name = "XoaDonHang";
            this.Text = "XoaDonHang";
            this.Load += new System.EventHandler(this.XoaDonHang_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button Xóa;
        private System.Windows.Forms.ComboBox cbbMaNhap;
        private System.Windows.Forms.Label label1;
    }
}