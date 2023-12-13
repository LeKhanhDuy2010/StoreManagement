
namespace StoreManagement
{
    partial class FormThongTinTK
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
            this.btnSua = new System.Windows.Forms.Button();
            this.tbxSdt = new System.Windows.Forms.TextBox();
            this.tbxTenNV = new System.Windows.Forms.TextBox();
            this.tbxMaNV = new System.Windows.Forms.TextBox();
            this.lblSdt = new System.Windows.Forms.Label();
            this.lblTenNV = new System.Windows.Forms.Label();
            this.lblMaNV = new System.Windows.Forms.Label();
            this.btnDoiMK = new System.Windows.Forms.Button();
            this.tbxTenDangNhap = new System.Windows.Forms.TextBox();
            this.lblTenDangNhap = new System.Windows.Forms.Label();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.pbxAvatar = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbxAvatar)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSua
            // 
            this.btnSua.AutoSize = true;
            this.btnSua.BackColor = System.Drawing.Color.DarkKhaki;
            this.btnSua.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSua.Location = new System.Drawing.Point(54, 301);
            this.btnSua.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 34);
            this.btnSua.TabIndex = 32;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // tbxSdt
            // 
            this.tbxSdt.Enabled = false;
            this.tbxSdt.Location = new System.Drawing.Point(345, 176);
            this.tbxSdt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbxSdt.Name = "tbxSdt";
            this.tbxSdt.ReadOnly = true;
            this.tbxSdt.Size = new System.Drawing.Size(212, 26);
            this.tbxSdt.TabIndex = 31;
            // 
            // tbxTenNV
            // 
            this.tbxTenNV.Enabled = false;
            this.tbxTenNV.Location = new System.Drawing.Point(345, 134);
            this.tbxTenNV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbxTenNV.Name = "tbxTenNV";
            this.tbxTenNV.ReadOnly = true;
            this.tbxTenNV.Size = new System.Drawing.Size(344, 26);
            this.tbxTenNV.TabIndex = 30;
            // 
            // tbxMaNV
            // 
            this.tbxMaNV.Enabled = false;
            this.tbxMaNV.Location = new System.Drawing.Point(345, 49);
            this.tbxMaNV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbxMaNV.Name = "tbxMaNV";
            this.tbxMaNV.ReadOnly = true;
            this.tbxMaNV.Size = new System.Drawing.Size(97, 26);
            this.tbxMaNV.TabIndex = 29;
            // 
            // lblSdt
            // 
            this.lblSdt.AutoSize = true;
            this.lblSdt.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSdt.Location = new System.Drawing.Point(223, 180);
            this.lblSdt.Name = "lblSdt";
            this.lblSdt.Size = new System.Drawing.Size(111, 21);
            this.lblSdt.TabIndex = 27;
            this.lblSdt.Text = "Số điện thoại:";
            // 
            // lblTenNV
            // 
            this.lblTenNV.AutoSize = true;
            this.lblTenNV.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenNV.Location = new System.Drawing.Point(209, 138);
            this.lblTenNV.Name = "lblTenNV";
            this.lblTenNV.Size = new System.Drawing.Size(127, 21);
            this.lblTenNV.TabIndex = 26;
            this.lblTenNV.Text = "Tên Nhân Viên:";
            // 
            // lblMaNV
            // 
            this.lblMaNV.AutoSize = true;
            this.lblMaNV.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaNV.Location = new System.Drawing.Point(216, 52);
            this.lblMaNV.Name = "lblMaNV";
            this.lblMaNV.Size = new System.Drawing.Size(125, 21);
            this.lblMaNV.TabIndex = 25;
            this.lblMaNV.Text = "Mã Nhân Viên:";
            // 
            // btnDoiMK
            // 
            this.btnDoiMK.AutoSize = true;
            this.btnDoiMK.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnDoiMK.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDoiMK.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnDoiMK.Location = new System.Drawing.Point(213, 301);
            this.btnDoiMK.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDoiMK.Name = "btnDoiMK";
            this.btnDoiMK.Size = new System.Drawing.Size(83, 34);
            this.btnDoiMK.TabIndex = 33;
            this.btnDoiMK.Text = "Đổi MK";
            this.btnDoiMK.UseVisualStyleBackColor = false;
            this.btnDoiMK.Click += new System.EventHandler(this.btnDoiMK_Click);
            // 
            // tbxTenDangNhap
            // 
            this.tbxTenDangNhap.Enabled = false;
            this.tbxTenDangNhap.Location = new System.Drawing.Point(345, 91);
            this.tbxTenDangNhap.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbxTenDangNhap.Name = "tbxTenDangNhap";
            this.tbxTenDangNhap.ReadOnly = true;
            this.tbxTenDangNhap.Size = new System.Drawing.Size(212, 26);
            this.tbxTenDangNhap.TabIndex = 35;
            // 
            // lblTenDangNhap
            // 
            this.lblTenDangNhap.AutoSize = true;
            this.lblTenDangNhap.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenDangNhap.Location = new System.Drawing.Point(202, 95);
            this.lblTenDangNhap.Name = "lblTenDangNhap";
            this.lblTenDangNhap.Size = new System.Drawing.Size(137, 21);
            this.lblTenDangNhap.TabIndex = 34;
            this.lblTenDangNhap.Text = "Tên Đăng Nhập:";
            // 
            // btnLuu
            // 
            this.btnLuu.AutoSize = true;
            this.btnLuu.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnLuu.Enabled = false;
            this.btnLuu.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnLuu.Location = new System.Drawing.Point(514, 301);
            this.btnLuu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(75, 34);
            this.btnLuu.TabIndex = 36;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = false;
            this.btnLuu.Visible = false;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.AutoSize = true;
            this.btnHuy.BackColor = System.Drawing.Color.IndianRed;
            this.btnHuy.Enabled = false;
            this.btnHuy.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuy.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnHuy.Location = new System.Drawing.Point(623, 301);
            this.btnHuy.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(75, 34);
            this.btnHuy.TabIndex = 37;
            this.btnHuy.Text = "Huỷ";
            this.btnHuy.UseVisualStyleBackColor = false;
            this.btnHuy.Visible = false;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // pbxAvatar
            // 
            this.pbxAvatar.Location = new System.Drawing.Point(33, 56);
            this.pbxAvatar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pbxAvatar.Name = "pbxAvatar";
            this.pbxAvatar.Size = new System.Drawing.Size(146, 148);
            this.pbxAvatar.TabIndex = 38;
            this.pbxAvatar.TabStop = false;
            // 
            // FormThongTinTK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.BackgroundImage = global::StoreManagement.Properties.Resources.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(748, 382);
            this.Controls.Add(this.pbxAvatar);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.tbxTenDangNhap);
            this.Controls.Add(this.lblTenDangNhap);
            this.Controls.Add(this.btnDoiMK);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.tbxSdt);
            this.Controls.Add(this.tbxTenNV);
            this.Controls.Add(this.tbxMaNV);
            this.Controls.Add(this.lblSdt);
            this.Controls.Add(this.lblTenNV);
            this.Controls.Add(this.lblMaNV);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormThongTinTK";
            this.Text = "FormThongTinTK";
            this.Load += new System.EventHandler(this.FormThongTinTK_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbxAvatar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.TextBox tbxSdt;
        private System.Windows.Forms.TextBox tbxTenNV;
        private System.Windows.Forms.TextBox tbxMaNV;
        private System.Windows.Forms.Label lblSdt;
        private System.Windows.Forms.Label lblTenNV;
        private System.Windows.Forms.Label lblMaNV;
        private System.Windows.Forms.Button btnDoiMK;
        private System.Windows.Forms.TextBox tbxTenDangNhap;
        private System.Windows.Forms.Label lblTenDangNhap;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.PictureBox pbxAvatar;
    }
}