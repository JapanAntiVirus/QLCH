namespace QuanLyCuaHang
{
    partial class ViewHoaDon
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
            this.treeViewHD = new System.Windows.Forms.TreeView();
            this.dgvHD = new System.Windows.Forms.DataGridView();
            this.dgvChiTietHD = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTietHD)).BeginInit();
            this.SuspendLayout();
            // 
            // treeViewHD
            // 
            this.treeViewHD.Dock = System.Windows.Forms.DockStyle.Left;
            this.treeViewHD.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.treeViewHD.Location = new System.Drawing.Point(0, 0);
            this.treeViewHD.Name = "treeViewHD";
            this.treeViewHD.Size = new System.Drawing.Size(313, 601);
            this.treeViewHD.TabIndex = 0;
            this.treeViewHD.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeViewHD_AfterSelect);
            // 
            // dgvHD
            // 
            this.dgvHD.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHD.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dgvHD.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvHD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHD.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvHD.Location = new System.Drawing.Point(313, 482);
            this.dgvHD.Name = "dgvHD";
            this.dgvHD.ReadOnly = true;
            this.dgvHD.Size = new System.Drawing.Size(849, 119);
            this.dgvHD.TabIndex = 1;
            // 
            // dgvChiTietHD
            // 
            this.dgvChiTietHD.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvChiTietHD.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dgvChiTietHD.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvChiTietHD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChiTietHD.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvChiTietHD.Location = new System.Drawing.Point(313, 0);
            this.dgvChiTietHD.Name = "dgvChiTietHD";
            this.dgvChiTietHD.ReadOnly = true;
            this.dgvChiTietHD.Size = new System.Drawing.Size(849, 482);
            this.dgvChiTietHD.TabIndex = 2;
            // 
            // ViewHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1162, 601);
            this.Controls.Add(this.dgvChiTietHD);
            this.Controls.Add(this.dgvHD);
            this.Controls.Add(this.treeViewHD);
            this.Name = "ViewHoaDon";
            this.Text = "Lịch sử thanh toán";
            this.Load += new System.EventHandler(this.ViewHoaDon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTietHD)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView treeViewHD;
        private System.Windows.Forms.DataGridView dgvHD;
        private System.Windows.Forms.DataGridView dgvChiTietHD;
    }
}