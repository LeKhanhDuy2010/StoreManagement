namespace StoreManagement
{
    partial class FormThemSP
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
            this.gbxInfo = new System.Windows.Forms.GroupBox();
            this.tbxGiaNhap = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbxPhanLoai = new System.Windows.Forms.ComboBox();
            this.btnChonAnh = new System.Windows.Forms.Button();
            this.pbxAnhSp = new System.Windows.Forms.PictureBox();
            this.tbxGiaTien = new System.Windows.Forms.TextBox();
            this.tbxSoLuong = new System.Windows.Forms.TextBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.tbxTenSP = new System.Windows.Forms.TextBox();
            this.tbxMaSP = new System.Windows.Forms.TextBox();
            this.lblPhanLoai = new System.Windows.Forms.Label();
            this.lblGia = new System.Windows.Forms.Label();
            this.lblSoLuong = new System.Windows.Forms.Label();
            this.lblTenSP = new System.Windows.Forms.Label();
            this.lblMaSP = new System.Windows.Forms.Label();
            this.gbxInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxAnhSp)).BeginInit();
            this.SuspendLayout();
            // 
            // gbxInfo
            // 
            this.gbxInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gbxInfo.BackgroundImage = global::StoreManagement.Properties.Resources.background;
            this.gbxInfo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.gbxInfo.Controls.Add(this.tbxGiaNhap);
            this.gbxInfo.Controls.Add(this.label2);
            this.gbxInfo.Controls.Add(this.cbxPhanLoai);
            this.gbxInfo.Controls.Add(this.btnChonAnh);
            this.gbxInfo.Controls.Add(this.pbxAnhSp);
            this.gbxInfo.Controls.Add(this.tbxGiaTien);
            this.gbxInfo.Controls.Add(this.tbxSoLuong);
            this.gbxInfo.Controls.Add(this.btnThem);
            this.gbxInfo.Controls.Add(this.tbxTenSP);
            this.gbxInfo.Controls.Add(this.tbxMaSP);
            this.gbxInfo.Controls.Add(this.lblPhanLoai);
            this.gbxInfo.Controls.Add(this.lblGia);
            this.gbxInfo.Controls.Add(this.lblSoLuong);
            this.gbxInfo.Controls.Add(this.lblTenSP);
            this.gbxInfo.Controls.Add(this.lblMaSP);
            this.gbxInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbxInfo.Location = new System.Drawing.Point(0, 0);
            this.gbxInfo.Name = "gbxInfo";
            this.gbxInfo.Size = new System.Drawing.Size(800, 565);
            this.gbxInfo.TabIndex = 2;
            this.gbxInfo.TabStop = false;
            this.gbxInfo.Text = "Thông tin sản phẩm";
            // 
            // tbxGiaNhap
            // 
            this.tbxGiaNhap.Location = new System.Drawing.Point(134, 438);
            this.tbxGiaNhap.Name = "tbxGiaNhap";
            this.tbxGiaNhap.Size = new System.Drawing.Size(660, 26);
            this.tbxGiaNhap.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 444);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 21);
            this.label2.TabIndex = 17;
            this.label2.Text = "Giá nhập:";
            // 
            // cbxPhanLoai
            // 
            this.cbxPhanLoai.FormattingEnabled = true;
            this.cbxPhanLoai.Location = new System.Drawing.Point(134, 396);
            this.cbxPhanLoai.Name = "cbxPhanLoai";
            this.cbxPhanLoai.Size = new System.Drawing.Size(660, 28);
            this.cbxPhanLoai.TabIndex = 14;
            // 
            // btnChonAnh
            // 
            this.btnChonAnh.AutoSize = true;
            this.btnChonAnh.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnChonAnh.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChonAnh.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnChonAnh.Location = new System.Drawing.Point(505, 195);
            this.btnChonAnh.Name = "btnChonAnh";
            this.btnChonAnh.Size = new System.Drawing.Size(108, 33);
            this.btnChonAnh.TabIndex = 13;
            this.btnChonAnh.Text = "Chọn ảnh";
            this.btnChonAnh.UseVisualStyleBackColor = false;
            this.btnChonAnh.Click += new System.EventHandler(this.btnChonAnh_Click);
            // 
            // pbxAnhSp
            // 
            this.pbxAnhSp.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.pbxAnhSp.Location = new System.Drawing.Point(299, 25);
            this.pbxAnhSp.Name = "pbxAnhSp";
            this.pbxAnhSp.Size = new System.Drawing.Size(200, 200);
            this.pbxAnhSp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxAnhSp.TabIndex = 12;
            this.pbxAnhSp.TabStop = false;
            // 
            // tbxGiaTien
            // 
            this.tbxGiaTien.Location = new System.Drawing.Point(134, 484);
            this.tbxGiaTien.Name = "tbxGiaTien";
            this.tbxGiaTien.Size = new System.Drawing.Size(660, 26);
            this.tbxGiaTien.TabIndex = 11;
            // 
            // tbxSoLuong
            // 
            this.tbxSoLuong.Location = new System.Drawing.Point(134, 346);
            this.tbxSoLuong.Name = "tbxSoLuong";
            this.tbxSoLuong.Size = new System.Drawing.Size(660, 26);
            this.tbxSoLuong.TabIndex = 9;
            // 
            // btnThem
            // 
            this.btnThem.AutoSize = true;
            this.btnThem.BackColor = System.Drawing.Color.IndianRed;
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnThem.Location = new System.Drawing.Point(359, 527);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 35);
            this.btnThem.TabIndex = 3;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // tbxTenSP
            // 
            this.tbxTenSP.Location = new System.Drawing.Point(134, 294);
            this.tbxTenSP.Name = "tbxTenSP";
            this.tbxTenSP.Size = new System.Drawing.Size(660, 26);
            this.tbxTenSP.TabIndex = 7;
            // 
            // tbxMaSP
            // 
            this.tbxMaSP.Location = new System.Drawing.Point(134, 248);
            this.tbxMaSP.Name = "tbxMaSP";
            this.tbxMaSP.ReadOnly = true;
            this.tbxMaSP.Size = new System.Drawing.Size(660, 26);
            this.tbxMaSP.TabIndex = 6;
            // 
            // lblPhanLoai
            // 
            this.lblPhanLoai.AutoSize = true;
            this.lblPhanLoai.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhanLoai.Location = new System.Drawing.Point(6, 404);
            this.lblPhanLoai.Name = "lblPhanLoai";
            this.lblPhanLoai.Size = new System.Drawing.Size(83, 21);
            this.lblPhanLoai.TabIndex = 4;
            this.lblPhanLoai.Text = "Phân loại:";
            // 
            // lblGia
            // 
            this.lblGia.AutoSize = true;
            this.lblGia.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGia.Location = new System.Drawing.Point(8, 490);
            this.lblGia.Name = "lblGia";
            this.lblGia.Size = new System.Drawing.Size(75, 21);
            this.lblGia.TabIndex = 3;
            this.lblGia.Text = "Giá tiền:";
            // 
            // lblSoLuong
            // 
            this.lblSoLuong.AutoSize = true;
            this.lblSoLuong.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoLuong.Location = new System.Drawing.Point(8, 352);
            this.lblSoLuong.Name = "lblSoLuong";
            this.lblSoLuong.Size = new System.Drawing.Size(77, 21);
            this.lblSoLuong.TabIndex = 2;
            this.lblSoLuong.Text = "Số lượng:";
            // 
            // lblTenSP
            // 
            this.lblTenSP.AutoSize = true;
            this.lblTenSP.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenSP.Location = new System.Drawing.Point(2, 300);
            this.lblTenSP.Name = "lblTenSP";
            this.lblTenSP.Size = new System.Drawing.Size(120, 21);
            this.lblTenSP.TabIndex = 1;
            this.lblTenSP.Text = "Tên sản phẩm:";
            // 
            // lblMaSP
            // 
            this.lblMaSP.AutoSize = true;
            this.lblMaSP.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaSP.Location = new System.Drawing.Point(6, 248);
            this.lblMaSP.Name = "lblMaSP";
            this.lblMaSP.Size = new System.Drawing.Size(118, 21);
            this.lblMaSP.TabIndex = 0;
            this.lblMaSP.Text = "Mã sản phẩm:";
            // 
            // FormThemSP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 565);
            this.Controls.Add(this.gbxInfo);
            this.Name = "FormThemSP";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ThemSP";
            this.Load += new System.EventHandler(this.FormThemSP_Load);
            this.gbxInfo.ResumeLayout(false);
            this.gbxInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxAnhSp)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxInfo;
        private System.Windows.Forms.PictureBox pbxAnhSp;
        private System.Windows.Forms.TextBox tbxGiaTien;
        private System.Windows.Forms.TextBox tbxSoLuong;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.TextBox tbxTenSP;
        private System.Windows.Forms.TextBox tbxMaSP;
        private System.Windows.Forms.Label lblPhanLoai;
        private System.Windows.Forms.Label lblGia;
        private System.Windows.Forms.Label lblSoLuong;
        private System.Windows.Forms.Label lblTenSP;
        private System.Windows.Forms.Label lblMaSP;
        private System.Windows.Forms.Button btnChonAnh;
        private System.Windows.Forms.ComboBox cbxPhanLoai;
        private System.Windows.Forms.TextBox tbxGiaNhap;
        private System.Windows.Forms.Label label2;
    }
}