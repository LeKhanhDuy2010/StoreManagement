using StoreManagement.BUS;
using StoreManagement.DTO;
using StoreManagement.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace StoreManagement
{
    public partial class FormThemNhanVien : Form
    {
        NhanVienDTO nhanVien;
        TaiKhoanDTO taiKhoanmoi;
        public List<string> vaiTro = new List<string> { "Admin", "Nhân viên" };
        public FormThemNhanVien()
        {
            InitializeComponent();
        }
        private void FormThemNhanVien_Load(object sender, EventArgs e)
        {
            cbxVaiTro.DataSource = vaiTro.ToArray();
            tbxMaNV.Text = NhanVienBUS.Instance.idGenerate("NV");
        }
        public void GetValue()
        {
            byte[] anhNV = ImageProcessing.Instance.ImageToArray(pbxAnhNV);
            if (pbxAnhNV.Image == null)
            {
                pbxAnhNV.Image = pbxAnhNV.ErrorImage;
                anhNV = ImageProcessing.Instance.ImageToArray(pbxAnhNV);
            }
            string maNhanVien = tbxMaNV.Text;
            string tenNhanVien = tbxTenNV.Text;
            string sdt = tbxSdt.Text;
            string taiKhoan = tbxTaiKhoan.Text;
            string matKhau = tbxMatKhau.Text;
            string vaiTro = cbxVaiTro.Text;

            nhanVien = new NhanVienDTO(anhNV, maNhanVien, tenNhanVien, sdt);
            taiKhoanmoi = new TaiKhoanDTO(taiKhoan, maNhanVien, matKhau, vaiTro);
        }

        private void btnChonAnh_Click(object sender, EventArgs e)
        {
            ImageProcessing.Instance.ChooseImage(pbxAnhNV);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                GetValue();
                if (NhanVienBUS.Instance.ThemNhanVien(nhanVien) == true)
                {
                    if (TaiKhoanBUS.Instance.ThemTaiKhoan(taiKhoanmoi) == true)
                    {
                        MessageBox.Show("Thêm thành công");
                    }
                    else
                    {
                        MessageBox.Show("Thêm không thành công");
                    }
                }
                else
                {
                    MessageBox.Show("Thêm không thành công");
                }
                this.Close();
            }
            catch (Exception ex)
            {
                //throw ex;
                MessageBox.Show("Lỗi thêm: " + ex);
            }
        }
    }
}
