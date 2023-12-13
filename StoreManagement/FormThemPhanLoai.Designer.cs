namespace StoreManagement
{
    partial class FormThemPhanLoai
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
            this.tbxPL = new System.Windows.Forms.TextBox();
            this.tbxMaPL = new System.Windows.Forms.TextBox();
            this.lblTenKH = new System.Windows.Forms.Label();
            this.lblMaPL = new System.Windows.Forms.Label();
            this.btnThem = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbxPL
            // 
            this.tbxPL.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbxPL.Location = new System.Drawing.Point(177, 74);
            this.tbxPL.Name = "tbxPL";
            this.tbxPL.Size = new System.Drawing.Size(297, 26);
            this.tbxPL.TabIndex = 24;
            // 
            // tbxMaPL
            // 
            this.tbxMaPL.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbxMaPL.Location = new System.Drawing.Point(177, 22);
            this.tbxMaPL.Name = "tbxMaPL";
            this.tbxMaPL.ReadOnly = true;
            this.tbxMaPL.Size = new System.Drawing.Size(297, 26);
            this.tbxMaPL.TabIndex = 23;
            // 
            // lblTenKH
            // 
            this.lblTenKH.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTenKH.AutoSize = true;
            this.lblTenKH.Location = new System.Drawing.Point(53, 77);
            this.lblTenKH.Name = "lblTenKH";
            this.lblTenKH.Size = new System.Drawing.Size(78, 20);
            this.lblTenKH.TabIndex = 22;
            this.lblTenKH.Text = "Phân loại:";
            // 
            // lblMaPL
            // 
            this.lblMaPL.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMaPL.AutoSize = true;
            this.lblMaPL.Location = new System.Drawing.Point(53, 25);
            this.lblMaPL.Name = "lblMaPL";
            this.lblMaPL.Size = new System.Drawing.Size(103, 20);
            this.lblMaPL.TabIndex = 21;
            this.lblMaPL.Text = "Mã phân loại:";
            // 
            // btnThem
            // 
            this.btnThem.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnThem.AutoSize = true;
            this.btnThem.BackColor = System.Drawing.Color.IndianRed;
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnThem.Location = new System.Drawing.Point(399, 139);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 35);
            this.btnThem.TabIndex = 25;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // FormThemPhanLoai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.BackgroundImage = global::StoreManagement.Properties.Resources.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(578, 244);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.tbxPL);
            this.Controls.Add(this.tbxMaPL);
            this.Controls.Add(this.lblTenKH);
            this.Controls.Add(this.lblMaPL);
            this.DoubleBuffered = true;
            this.Name = "FormThemPhanLoai";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormThemPhanLoai";
            this.Load += new System.EventHandler(this.FormThemPhanLoai_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxPL;
        private System.Windows.Forms.TextBox tbxMaPL;
        private System.Windows.Forms.Label lblTenKH;
        private System.Windows.Forms.Label lblMaPL;
        private System.Windows.Forms.Button btnThem;
    }
}