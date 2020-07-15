namespace QuanLyCuaHang
{
    partial class ThemSanPham
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
            this.labDonGia = new System.Windows.Forms.Label();
            this.labTenSP = new System.Windows.Forms.Label();
            this.labDonViTinh = new System.Windows.Forms.Label();
            this.labSLT = new System.Windows.Forms.Label();
            this.txtTenSP = new System.Windows.Forms.TextBox();
            this.txtDonViTinh = new System.Windows.Forms.TextBox();
            this.numDonGia = new System.Windows.Forms.NumericUpDown();
            this.btnThemSanPham = new System.Windows.Forms.Button();
            this.numSLT = new System.Windows.Forms.NumericUpDown();
            this.btnClose = new System.Windows.Forms.Button();
            this.dgvSanPham = new System.Windows.Forms.DataGridView();
            this.btnSuaSanPham = new System.Windows.Forms.Button();
            this.btnXoaSanPham = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.labSearch = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numDonGia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSLT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSanPham)).BeginInit();
            this.SuspendLayout();
            // 
            // labDonGia
            // 
            this.labDonGia.AutoSize = true;
            this.labDonGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labDonGia.Location = new System.Drawing.Point(368, 27);
            this.labDonGia.Name = "labDonGia";
            this.labDonGia.Size = new System.Drawing.Size(47, 13);
            this.labDonGia.TabIndex = 0;
            this.labDonGia.Text = "Đơn giá:";
            // 
            // labTenSP
            // 
            this.labTenSP.AutoSize = true;
            this.labTenSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labTenSP.Location = new System.Drawing.Point(25, 27);
            this.labTenSP.Name = "labTenSP";
            this.labTenSP.Size = new System.Drawing.Size(78, 13);
            this.labTenSP.TabIndex = 1;
            this.labTenSP.Text = "Tên sản phẩm:";
            // 
            // labDonViTinh
            // 
            this.labDonViTinh.AutoSize = true;
            this.labDonViTinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labDonViTinh.Location = new System.Drawing.Point(25, 95);
            this.labDonViTinh.Name = "labDonViTinh";
            this.labDonViTinh.Size = new System.Drawing.Size(63, 13);
            this.labDonViTinh.TabIndex = 2;
            this.labDonViTinh.Text = "Đơn vị tính:";
            // 
            // labSLT
            // 
            this.labSLT.AutoSize = true;
            this.labSLT.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labSLT.Location = new System.Drawing.Point(368, 88);
            this.labSLT.Name = "labSLT";
            this.labSLT.Size = new System.Drawing.Size(73, 13);
            this.labSLT.TabIndex = 3;
            this.labSLT.Text = "Số lượng  tồn:";
            // 
            // txtTenSP
            // 
            this.txtTenSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenSP.Location = new System.Drawing.Point(122, 20);
            this.txtTenSP.Name = "txtTenSP";
            this.txtTenSP.Size = new System.Drawing.Size(135, 20);
            this.txtTenSP.TabIndex = 0;
            // 
            // txtDonViTinh
            // 
            this.txtDonViTinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDonViTinh.Location = new System.Drawing.Point(122, 88);
            this.txtDonViTinh.Name = "txtDonViTinh";
            this.txtDonViTinh.Size = new System.Drawing.Size(135, 20);
            this.txtDonViTinh.TabIndex = 1;
            // 
            // numDonGia
            // 
            this.numDonGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numDonGia.Location = new System.Drawing.Point(459, 20);
            this.numDonGia.Maximum = new decimal(new int[] {
            1410065407,
            2,
            0,
            0});
            this.numDonGia.Name = "numDonGia";
            this.numDonGia.Size = new System.Drawing.Size(120, 20);
            this.numDonGia.TabIndex = 2;
            // 
            // btnThemSanPham
            // 
            this.AcceptButton = this.btnThemSanPham;
            this.btnThemSanPham.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThemSanPham.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemSanPham.Location = new System.Drawing.Point(109, 195);
            this.btnThemSanPham.Name = "btnThemSanPham";
            this.btnThemSanPham.Size = new System.Drawing.Size(75, 23);
            this.btnThemSanPham.TabIndex = 4;
            this.btnThemSanPham.Text = "Thêm";
            this.btnThemSanPham.UseVisualStyleBackColor = true;
            this.btnThemSanPham.Click += new System.EventHandler(this.btnThemSanPham_Click);
            // 
            // numSLT
            // 
            this.numSLT.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numSLT.Location = new System.Drawing.Point(459, 82);
            this.numSLT.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numSLT.Name = "numSLT";
            this.numSLT.Size = new System.Drawing.Size(120, 20);
            this.numSLT.TabIndex = 3;
            // 
            // btnClose
            // 
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(532, 195);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 7;
            this.btnClose.Text = "Thoát";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // dgvSanPham
            // 
            this.dgvSanPham.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSanPham.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dgvSanPham.BackgroundColor = System.Drawing.Color.White;
            this.dgvSanPham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSanPham.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvSanPham.Location = new System.Drawing.Point(0, 271);
            this.dgvSanPham.Name = "dgvSanPham";
            this.dgvSanPham.ReadOnly = true;
            this.dgvSanPham.Size = new System.Drawing.Size(764, 250);
            this.dgvSanPham.TabIndex = 8;
            this.dgvSanPham.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dvtSanPham_CellMouseDoubleClick);
            // 
            // btnSuaSanPham
            // 
            this.btnSuaSanPham.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSuaSanPham.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuaSanPham.Location = new System.Drawing.Point(236, 195);
            this.btnSuaSanPham.Name = "btnSuaSanPham";
            this.btnSuaSanPham.Size = new System.Drawing.Size(75, 23);
            this.btnSuaSanPham.TabIndex = 5;
            this.btnSuaSanPham.Text = "Sửa";
            this.btnSuaSanPham.UseVisualStyleBackColor = true;
            this.btnSuaSanPham.Click += new System.EventHandler(this.btnSuaSanPham_Click);
            // 
            // btnXoaSanPham
            // 
            this.btnXoaSanPham.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXoaSanPham.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaSanPham.Location = new System.Drawing.Point(393, 195);
            this.btnXoaSanPham.Name = "btnXoaSanPham";
            this.btnXoaSanPham.Size = new System.Drawing.Size(75, 23);
            this.btnXoaSanPham.TabIndex = 6;
            this.btnXoaSanPham.Text = "Xóa";
            this.btnXoaSanPham.UseVisualStyleBackColor = true;
            this.btnXoaSanPham.Click += new System.EventHandler(this.btnXoaSanPham_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(629, 248);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(135, 20);
            this.txtSearch.TabIndex = 9;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // labSearch
            // 
            this.labSearch.AutoSize = true;
            this.labSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labSearch.Location = new System.Drawing.Point(571, 255);
            this.labSearch.Name = "labSearch";
            this.labSearch.Size = new System.Drawing.Size(52, 13);
            this.labSearch.TabIndex = 10;
            this.labSearch.Text = "Tìm kiếm:";
            // 
            // ThemSanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(764, 521);
            this.Controls.Add(this.labSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnXoaSanPham);
            this.Controls.Add(this.btnSuaSanPham);
            this.Controls.Add(this.dgvSanPham);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.numSLT);
            this.Controls.Add(this.btnThemSanPham);
            this.Controls.Add(this.numDonGia);
            this.Controls.Add(this.txtDonViTinh);
            this.Controls.Add(this.txtTenSP);
            this.Controls.Add(this.labSLT);
            this.Controls.Add(this.labDonViTinh);
            this.Controls.Add(this.labTenSP);
            this.Controls.Add(this.labDonGia);
            this.Name = "ThemSanPham";
            this.Text = "Thêm sẩn phẩm";
            this.Load += new System.EventHandler(this.ThemSanPham_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numDonGia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSLT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSanPham)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labDonGia;
        private System.Windows.Forms.Label labTenSP;
        private System.Windows.Forms.Label labDonViTinh;
        private System.Windows.Forms.Label labSLT;
        private System.Windows.Forms.TextBox txtTenSP;
        private System.Windows.Forms.TextBox txtDonViTinh;
        private System.Windows.Forms.NumericUpDown numDonGia;
        private System.Windows.Forms.Button btnThemSanPham;
        private System.Windows.Forms.NumericUpDown numSLT;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.DataGridView dgvSanPham;
        private System.Windows.Forms.Button btnSuaSanPham;
        private System.Windows.Forms.Button btnXoaSanPham;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label labSearch;
    }
}