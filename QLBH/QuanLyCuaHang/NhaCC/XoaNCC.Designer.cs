﻿namespace QuanLyCuaHang
{
    partial class XoaNCC
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
            this.cbbMaNCC = new System.Windows.Forms.ComboBox();
            this.Xóa = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "MaNCC";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // cbbMaNCC
            // 
            this.cbbMaNCC.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbMaNCC.FormattingEnabled = true;
            this.cbbMaNCC.Location = new System.Drawing.Point(133, 44);
            this.cbbMaNCC.Name = "cbbMaNCC";
            this.cbbMaNCC.Size = new System.Drawing.Size(119, 21);
            this.cbbMaNCC.TabIndex = 1;
            this.cbbMaNCC.SelectedIndexChanged += new System.EventHandler(this.cbbMaNCC_SelectedIndexChanged);
            // 
            // Xóa
            // 
            this.Xóa.Location = new System.Drawing.Point(63, 127);
            this.Xóa.Name = "Xóa";
            this.Xóa.Size = new System.Drawing.Size(67, 23);
            this.Xóa.TabIndex = 2;
            this.Xóa.Text = "Xóa";
            this.Xóa.UseVisualStyleBackColor = true;
            this.Xóa.Click += new System.EventHandler(this.Xóa_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(177, 127);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Hủy";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // XoaNCC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(340, 206);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Xóa);
            this.Controls.Add(this.cbbMaNCC);
            this.Controls.Add(this.label1);
            this.Name = "XoaNCC";
            this.Text = " ";
            this.Load += new System.EventHandler(this.XoaNCC_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbbMaNCC;
        private System.Windows.Forms.Button Xóa;
        private System.Windows.Forms.Button button2;
    }
}