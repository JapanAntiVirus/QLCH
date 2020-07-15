namespace QuanLyCuaHang
{
    partial class Login
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
            this.labUserName = new System.Windows.Forms.Label();
            this.labPassưord = new System.Windows.Forms.Label();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.labServerName = new System.Windows.Forms.Label();
            this.cbbServer = new System.Windows.Forms.ComboBox();
            this.labThongBao = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labUserName
            // 
            this.labUserName.AutoSize = true;
            this.labUserName.Location = new System.Drawing.Point(71, 86);
            this.labUserName.Name = "labUserName";
            this.labUserName.Size = new System.Drawing.Size(58, 13);
            this.labUserName.TabIndex = 0;
            this.labUserName.Text = "Tài khoản:";
            // 
            // labPassưord
            // 
            this.labPassưord.AutoSize = true;
            this.labPassưord.Location = new System.Drawing.Point(71, 135);
            this.labPassưord.Name = "labPassưord";
            this.labPassưord.Size = new System.Drawing.Size(55, 13);
            this.labPassưord.TabIndex = 1;
            this.labPassưord.Text = "Mật khẩu:";
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(163, 79);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(176, 20);
            this.txtUserName.TabIndex = 2;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(163, 128);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(176, 20);
            this.txtPassword.TabIndex = 3;
            // 
            // btnLogin
            // 
            this.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogin.Location = new System.Drawing.Point(74, 190);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(75, 23);
            this.btnLogin.TabIndex = 4;
            this.btnLogin.Text = "Đăng nhập";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.Location = new System.Drawing.Point(191, 190);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Thoát";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // labServerName
            // 
            this.labServerName.AutoSize = true;
            this.labServerName.Location = new System.Drawing.Point(71, 45);
            this.labServerName.Name = "labServerName";
            this.labServerName.Size = new System.Drawing.Size(41, 13);
            this.labServerName.TabIndex = 6;
            this.labServerName.Text = "Server:";
            // 
            // cbbServer
            // 
            this.cbbServer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbbServer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbServer.FormattingEnabled = true;
            this.cbbServer.Location = new System.Drawing.Point(163, 37);
            this.cbbServer.Name = "cbbServer";
            this.cbbServer.Size = new System.Drawing.Size(176, 21);
            this.cbbServer.TabIndex = 7;
            this.cbbServer.SelectedIndexChanged += new System.EventHandler(this.cbbServer_SelectedIndexChanged);
            // 
            // labThongBao
            // 
            this.labThongBao.AutoSize = true;
            this.labThongBao.ForeColor = System.Drawing.Color.Red;
            this.labThongBao.Location = new System.Drawing.Point(160, 162);
            this.labThongBao.Name = "labThongBao";
            this.labThongBao.Size = new System.Drawing.Size(0, 13);
            this.labThongBao.TabIndex = 8;
            // 
            // Login
            // 
            this.AcceptButton = this.btnLogin;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(412, 262);
            this.Controls.Add(this.labThongBao);
            this.Controls.Add(this.cbbServer);
            this.Controls.Add(this.labServerName);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.labPassưord);
            this.Controls.Add(this.labUserName);
            this.Name = "Login";
            this.Text = "Login";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Login_FormClosing);
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labUserName;
        private System.Windows.Forms.Label labPassưord;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label labServerName;
        private System.Windows.Forms.ComboBox cbbServer;
        private System.Windows.Forms.Label labThongBao;
    }
}