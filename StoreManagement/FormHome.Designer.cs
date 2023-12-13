namespace StoreManagement
{
    partial class FormHome
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormHome));
            this.pnlTittle = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lblTittle = new System.Windows.Forms.Label();
            this.pnlForm = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.flowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pbxLogo = new System.Windows.Forms.PictureBox();
            this.panelTaiKhoan = new System.Windows.Forms.Panel();
            this.btnTenNV = new System.Windows.Forms.Button();
            this.btnDangXuat = new System.Windows.Forms.Button();
            this.btnThongTin = new System.Windows.Forms.Button();
            this.btnThanhToan = new System.Windows.Forms.Button();
            this.btnSanPham = new System.Windows.Forms.Button();
            this.btnPhanloai = new System.Windows.Forms.Button();
            this.btnDSHoaDon = new System.Windows.Forms.Button();
            this.btnNhanVien = new System.Windows.Forms.Button();
            this.btnKhachHang = new System.Windows.Forms.Button();
            this.btnThongKe = new System.Windows.Forms.Button();
            this.timerSildeAnimation = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.pnlTittle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.pnlForm.SuspendLayout();
            this.flowLayoutPanel.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogo)).BeginInit();
            this.panelTaiKhoan.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTittle
            // 
            this.pnlTittle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.pnlTittle.Controls.Add(this.pictureBox2);
            this.pnlTittle.Controls.Add(this.lblTittle);
            this.pnlTittle.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTittle.Location = new System.Drawing.Point(205, 0);
            this.pnlTittle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlTittle.Name = "pnlTittle";
            this.pnlTittle.Size = new System.Drawing.Size(1088, 96);
            this.pnlTittle.TabIndex = 1;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::StoreManagement.Properties.Resources.home;
            this.pictureBox2.Location = new System.Drawing.Point(24, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(77, 61);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // lblTittle
            // 
            this.lblTittle.AutoSize = true;
            this.lblTittle.Font = new System.Drawing.Font("Century Gothic", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTittle.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblTittle.Location = new System.Drawing.Point(107, 26);
            this.lblTittle.Name = "lblTittle";
            this.lblTittle.Size = new System.Drawing.Size(137, 47);
            this.lblTittle.TabIndex = 0;
            this.lblTittle.Text = "Home";
            // 
            // pnlForm
            // 
            this.pnlForm.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pnlForm.BackgroundImage = global::StoreManagement.Properties.Resources.background1;
            this.pnlForm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pnlForm.Controls.Add(this.label2);
            this.pnlForm.Controls.Add(this.label1);
            this.pnlForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlForm.Location = new System.Drawing.Point(205, 96);
            this.pnlForm.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlForm.Name = "pnlForm";
            this.pnlForm.Size = new System.Drawing.Size(1088, 598);
            this.pnlForm.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(183, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(418, 47);
            this.label1.TabIndex = 0;
            this.label1.Text = "QUẢN LÝ BÁN HÀNG";
            // 
            // flowLayoutPanel
            // 
            this.flowLayoutPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.flowLayoutPanel.Controls.Add(this.panel2);
            this.flowLayoutPanel.Controls.Add(this.panelTaiKhoan);
            this.flowLayoutPanel.Controls.Add(this.btnThanhToan);
            this.flowLayoutPanel.Controls.Add(this.btnSanPham);
            this.flowLayoutPanel.Controls.Add(this.btnPhanloai);
            this.flowLayoutPanel.Controls.Add(this.btnDSHoaDon);
            this.flowLayoutPanel.Controls.Add(this.btnNhanVien);
            this.flowLayoutPanel.Controls.Add(this.btnKhachHang);
            this.flowLayoutPanel.Controls.Add(this.btnThongKe);
            this.flowLayoutPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.flowLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.flowLayoutPanel.Name = "flowLayoutPanel";
            this.flowLayoutPanel.Size = new System.Drawing.Size(205, 694);
            this.flowLayoutPanel.TabIndex = 6;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pbxLogo);
            this.panel2.Location = new System.Drawing.Point(3, 4);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 190);
            this.panel2.TabIndex = 6;
            // 
            // pbxLogo
            // 
            this.pbxLogo.Image = global::StoreManagement.Properties.Resources.OIP_removebg_preview;
            this.pbxLogo.Location = new System.Drawing.Point(0, 0);
            this.pbxLogo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbxLogo.Name = "pbxLogo";
            this.pbxLogo.Size = new System.Drawing.Size(200, 184);
            this.pbxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxLogo.TabIndex = 0;
            this.pbxLogo.TabStop = false;
            // 
            // panelTaiKhoan
            // 
            this.panelTaiKhoan.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelTaiKhoan.Controls.Add(this.btnTenNV);
            this.panelTaiKhoan.Controls.Add(this.btnDangXuat);
            this.panelTaiKhoan.Controls.Add(this.btnThongTin);
            this.panelTaiKhoan.Location = new System.Drawing.Point(3, 202);
            this.panelTaiKhoan.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelTaiKhoan.MaximumSize = new System.Drawing.Size(200, 112);
            this.panelTaiKhoan.MinimumSize = new System.Drawing.Size(200, 38);
            this.panelTaiKhoan.Name = "panelTaiKhoan";
            this.panelTaiKhoan.Size = new System.Drawing.Size(200, 40);
            this.panelTaiKhoan.TabIndex = 3;
            // 
            // btnTenNV
            // 
            this.btnTenNV.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnTenNV.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTenNV.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnTenNV.Location = new System.Drawing.Point(0, 0);
            this.btnTenNV.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnTenNV.Name = "btnTenNV";
            this.btnTenNV.Size = new System.Drawing.Size(202, 38);
            this.btnTenNV.TabIndex = 5;
            this.btnTenNV.Text = "TenNV";
            this.btnTenNV.UseVisualStyleBackColor = false;
            this.btnTenNV.Click += new System.EventHandler(this.btnTenNV_Click);
            // 
            // btnDangXuat
            // 
            this.btnDangXuat.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnDangXuat.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDangXuat.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDangXuat.Location = new System.Drawing.Point(0, 78);
            this.btnDangXuat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDangXuat.Name = "btnDangXuat";
            this.btnDangXuat.Size = new System.Drawing.Size(200, 32);
            this.btnDangXuat.TabIndex = 4;
            this.btnDangXuat.Text = "Đăng xuất";
            this.btnDangXuat.UseVisualStyleBackColor = false;
            this.btnDangXuat.Click += new System.EventHandler(this.btnDangXuat_Click);
            // 
            // btnThongTin
            // 
            this.btnThongTin.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnThongTin.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThongTin.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnThongTin.Location = new System.Drawing.Point(0, 40);
            this.btnThongTin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThongTin.Name = "btnThongTin";
            this.btnThongTin.Size = new System.Drawing.Size(200, 32);
            this.btnThongTin.TabIndex = 3;
            this.btnThongTin.Text = "Thông tin";
            this.btnThongTin.UseVisualStyleBackColor = false;
            this.btnThongTin.Click += new System.EventHandler(this.btnThongTin_Click);
            // 
            // btnThanhToan
            // 
            this.btnThanhToan.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnThanhToan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnThanhToan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThanhToan.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnThanhToan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThanhToan.Location = new System.Drawing.Point(3, 248);
            this.btnThanhToan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThanhToan.Name = "btnThanhToan";
            this.btnThanhToan.Size = new System.Drawing.Size(200, 50);
            this.btnThanhToan.TabIndex = 3;
            this.btnThanhToan.Text = "Thanh Toán";
            this.btnThanhToan.UseVisualStyleBackColor = false;
            this.btnThanhToan.Click += new System.EventHandler(this.btnThanhToan_Click);
            // 
            // btnSanPham
            // 
            this.btnSanPham.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnSanPham.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSanPham.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSanPham.Location = new System.Drawing.Point(3, 302);
            this.btnSanPham.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSanPham.Name = "btnSanPham";
            this.btnSanPham.Size = new System.Drawing.Size(200, 50);
            this.btnSanPham.TabIndex = 0;
            this.btnSanPham.Text = "Sản Phẩm";
            this.btnSanPham.UseVisualStyleBackColor = false;
            this.btnSanPham.Click += new System.EventHandler(this.btnSanPham_Click);
            // 
            // btnPhanloai
            // 
            this.btnPhanloai.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnPhanloai.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPhanloai.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnPhanloai.Location = new System.Drawing.Point(3, 356);
            this.btnPhanloai.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPhanloai.Name = "btnPhanloai";
            this.btnPhanloai.Size = new System.Drawing.Size(200, 50);
            this.btnPhanloai.TabIndex = 2;
            this.btnPhanloai.Text = "Phân Loại";
            this.btnPhanloai.UseVisualStyleBackColor = false;
            this.btnPhanloai.Click += new System.EventHandler(this.btnNCC_Click);
            // 
            // btnDSHoaDon
            // 
            this.btnDSHoaDon.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnDSHoaDon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDSHoaDon.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDSHoaDon.Location = new System.Drawing.Point(3, 410);
            this.btnDSHoaDon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDSHoaDon.Name = "btnDSHoaDon";
            this.btnDSHoaDon.Size = new System.Drawing.Size(200, 50);
            this.btnDSHoaDon.TabIndex = 5;
            this.btnDSHoaDon.Text = "Hóa Đơn";
            this.btnDSHoaDon.UseVisualStyleBackColor = false;
            this.btnDSHoaDon.Click += new System.EventHandler(this.btnDSHoaDon_Click);
            // 
            // btnNhanVien
            // 
            this.btnNhanVien.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnNhanVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNhanVien.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnNhanVien.Location = new System.Drawing.Point(3, 464);
            this.btnNhanVien.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnNhanVien.Name = "btnNhanVien";
            this.btnNhanVien.Size = new System.Drawing.Size(200, 50);
            this.btnNhanVien.TabIndex = 7;
            this.btnNhanVien.Text = "Nhân viên";
            this.btnNhanVien.UseVisualStyleBackColor = false;
            this.btnNhanVien.Click += new System.EventHandler(this.btnNhanVien_Click);
            // 
            // btnKhachHang
            // 
            this.btnKhachHang.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnKhachHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKhachHang.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnKhachHang.Location = new System.Drawing.Point(3, 518);
            this.btnKhachHang.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnKhachHang.Name = "btnKhachHang";
            this.btnKhachHang.Size = new System.Drawing.Size(200, 50);
            this.btnKhachHang.TabIndex = 1;
            this.btnKhachHang.Text = "Khách Hàng";
            this.btnKhachHang.UseVisualStyleBackColor = false;
            this.btnKhachHang.Click += new System.EventHandler(this.btnKhachHang_Click);
            // 
            // btnThongKe
            // 
            this.btnThongKe.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnThongKe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThongKe.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnThongKe.Location = new System.Drawing.Point(3, 572);
            this.btnThongKe.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThongKe.Name = "btnThongKe";
            this.btnThongKe.Size = new System.Drawing.Size(200, 50);
            this.btnThongKe.TabIndex = 4;
            this.btnThongKe.Text = "Thống kê";
            this.btnThongKe.UseVisualStyleBackColor = false;
            this.btnThongKe.Click += new System.EventHandler(this.btnThongKe_Click);
            // 
            // timerSildeAnimation
            // 
            this.timerSildeAnimation.Tick += new System.EventHandler(this.timerSildeAnimation_Tick);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(313, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(458, 258);
            this.label2.TabIndex = 1;
            this.label2.Text = "Thực hiện: \r\n                Phạm Hoàng Long\r\n                Lê Khánh Duy\r\n     " +
    "           Trần Ngọc Đức";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // FormHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.BackgroundImage = global::StoreManagement.Properties.Resources.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1293, 694);
            this.Controls.Add(this.pnlForm);
            this.Controls.Add(this.pnlTittle);
            this.Controls.Add(this.flowLayoutPanel);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MinimumSize = new System.Drawing.Size(1310, 738);
            this.Name = "FormHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Store";
            this.Load += new System.EventHandler(this.FormHome_Load);
            this.pnlTittle.ResumeLayout(false);
            this.pnlTittle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.pnlForm.ResumeLayout(false);
            this.pnlForm.PerformLayout();
            this.flowLayoutPanel.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogo)).EndInit();
            this.panelTaiKhoan.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlTittle;
        private System.Windows.Forms.Label lblTittle;
        private System.Windows.Forms.Panel pnlForm;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pbxLogo;
        private System.Windows.Forms.Panel panelTaiKhoan;
        private System.Windows.Forms.Button btnDangXuat;
        private System.Windows.Forms.Button btnThongTin;
        private System.Windows.Forms.Button btnSanPham;
        private System.Windows.Forms.Button btnPhanloai;
        private System.Windows.Forms.Button btnThongKe;
        private System.Windows.Forms.Button btnDSHoaDon;
        private System.Windows.Forms.Button btnKhachHang;
        private System.Windows.Forms.Button btnThanhToan;
        private System.Windows.Forms.Timer timerSildeAnimation;
        private System.Windows.Forms.Button btnTenNV;
        private System.Windows.Forms.Button btnNhanVien;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

