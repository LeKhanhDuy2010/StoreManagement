using StoreManagement.BUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StoreManagement
{
    public partial class FormThongTinTK : Form
    {
        public FormThongTinTK()
        {
            InitializeComponent();
        }

        private void FormThongTinTK_Load(object sender, EventArgs e)
        {
            NhanVienBUS.Instance.GetCurrentNhanVien(pbxAvatar,tbxMaNV,tbxTenDangNhap, tbxTenNV, tbxSdt);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            tbxTenNV.ReadOnly = false;
            tbxTenNV.Enabled = true;

            tbxSdt.ReadOnly = false;
            tbxSdt.Enabled = true;

            btnLuu.Visible = true;
            btnLuu.Enabled = true;

            btnHuy.Visible = true;
            btnHuy.Enabled = true;

            btnSua.Visible = false;
            btnSua.Enabled = false;

            btnDoiMK.Visible = false;
            btnDoiMK.Enabled = false;
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            tbxTenNV.ReadOnly = true;
            tbxTenNV.Enabled = false;

            tbxSdt.ReadOnly = true;
            tbxSdt.Enabled = false;
            
            btnLuu.Visible = false;
            btnLuu.Enabled = false;

            btnHuy.Visible = false;
            btnHuy.Enabled = false;

            btnSua.Visible = true;
            btnSua.Enabled = true;

            btnDoiMK.Visible = true;
            btnDoiMK.Enabled = true;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            NhanVienBUS.Instance.SuaCurrentNhanVien(tbxMaNV.Text, tbxTenNV.Text, tbxSdt.Text);
            btnHuy_Click(sender, e);
        }

        private void btnDoiMK_Click(object sender, EventArgs e)
        {
            FormDoiMK formDoiMK = new FormDoiMK();
            formDoiMK.ShowDialog();
        }
    }
}
