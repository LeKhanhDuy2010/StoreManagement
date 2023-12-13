using StoreManagement.BUS;
using StoreManagement.DAO;
using StoreManagement.DTO;
using StoreManagement.Utils;
using System;
using System.Windows.Forms;

namespace StoreManagement
{
    public partial class FormThemSP : Form
    {
        public FormThemSP()
        {
            InitializeComponent();
        }

        private void FormThemSP_Load(object sender, EventArgs e)
        {
            //Do du lieu cua bang NhaCungCap vao combobox
            cbxPhanLoai.DataSource = PhanLoaiDAO.Instance.DSPhanLoai();
            cbxPhanLoai.DisplayMember = "Tên loại";
            cbxPhanLoai.ValueMember = "Mã loại";
            tbxMaSP.Text = SanPhamBUS.Instance.idGenerate("SP");
        }

        //Lay gia tri tu user
        private SanPhamDTO GetValue()
        {
            byte[] anh = ImageProcessing.Instance.ImageToArray(pbxAnhSp);
            if (pbxAnhSp.Image == null)
            {
                pbxAnhSp.Image = pbxAnhSp.ErrorImage;
                anh = ImageProcessing.Instance.ImageToArray(pbxAnhSp);
            }
            string maSanPham = tbxMaSP.Text;
            string tenSanPham = tbxTenSP.Text;

            string maLoai = cbxPhanLoai.SelectedValue.ToString();
            int soLuongNhap = int.Parse(tbxSoLuong.Text);
            int TonKho = soLuongNhap;
            float giaNhap = float.Parse(tbxGiaNhap.Text);
            float giaTien = float.Parse(tbxGiaTien.Text);
            //float giamGia = float.Parse(cbxGiamGia.Text);

            return new SanPhamDTO(anh, maSanPham, tenSanPham, maLoai, TonKho, giaTien, 0, giaNhap, soLuongNhap);
        }

        //Chon anh tu may tinh
        private void btnChonAnh_Click(object sender, EventArgs e)
        {
            ImageProcessing.Instance.ChooseImage(pbxAnhSp);
        }

        //Them san pham
        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                SanPhamDTO sanPham = GetValue();
                if (SanPhamBUS.Instance.ThemSanPham(sanPham) == true)
                {
                    MessageBox.Show("Thêm thành công");
                }
                else
                {
                    MessageBox.Show("Thêm không thành công");
                }
                Close();
            }
            catch (Exception ex)
            {
                //throw ex;
                MessageBox.Show("Lỗi thêm: " + ex);
            }
        }
    }
}
