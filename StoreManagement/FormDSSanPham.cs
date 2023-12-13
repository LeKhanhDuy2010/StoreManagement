using StoreManagement.BUS;
using StoreManagement.DAO;
using StoreManagement.DTO;
using System;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using StoreManagement.Utils;

namespace StoreManagement
{
    public partial class FormDSSanPham : Form
    {
        SanPhamDTO sanPham;
        FormThemSP them;
        private DataTable dataTable;

        public FormDSSanPham()
        {
            InitializeComponent();
        }
        private void FormDSSanPham_Load(object sender, EventArgs e)
        {

            //Dgv
            dataTable = SanPhamDAO.Instance.DSSanPham();
            dgvSanPham.DataSource = dataTable;
            dgvSanPham.Columns["Ảnh"].ReadOnly = true;
            dgvSanPham.Columns["Mã sản phẩm"].Visible = false;
            // Sắp xếp tăng dần theo cột "Tên Cột"
            dgvSanPham.Sort(dgvSanPham.Columns["Tên sản phẩm"], ListSortDirection.Ascending);


            PhanTrang.Instance.Load(dataTable, dgvSanPham, lblPageview);

            //Dua du lieu tu bang NhaCungCap vao combobox
            cbxTimPL.DataSource = cbxPhanLoai.DataSource = PhanLoaiDAO.Instance.DSPhanLoai();
            cbxTimPL.DisplayMember = cbxPhanLoai.DisplayMember = "Tên loại";
            cbxTimPL.ValueMember = cbxPhanLoai.ValueMember = "Mã loại";

            //Xu ly hien thi hinh anh
            DataGridViewImageColumn img = new DataGridViewImageColumn();
            img = (DataGridViewImageColumn)dgvSanPham.Columns[0];
            img.ImageLayout = DataGridViewImageCellLayout.Zoom;

            //GroupBox Info
            gbxInfo.Enabled = false;

            clearInfo();
        }


        //Input
        public void GetValue()
        {
            byte[] anh = ImageProcessing.Instance.ImageToArray(pbxAnhSp);
            string maSanPham = tbxMaSP.Text;
            string tenSanPham = tbxTenSP.Text;
            string maLoai = cbxPhanLoai.SelectedValue.ToString();
            int tonKho = int.Parse(tbxSoLuong.Text);
            float giaNhap = float.Parse(tbxGiaNhap.Text);
            float giaTien = float.Parse(tbxGiaTien.Text);
            float giamGia = float.Parse(cbxGiamGia.Text);
            int soLuongNhap = int.Parse(dgvSanPham.SelectedRows[0].Cells["Số lượng nhập"].Value.ToString());
            sanPham = new SanPhamDTO(anh, maSanPham, tenSanPham, maLoai, tonKho, giaTien, giamGia, giaNhap, soLuongNhap);
        }

        //Chon anh tu may tinh
        private void PbxAnhSp_Click(object sender, EventArgs e)
        {
            ImageProcessing.Instance.ChooseImage(pbxAnhSp);
        }

        //Lam moi Datagridview
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            FormDSSanPham_Load(sender, e);
            clearInfo();
        }

        //Chon san pham
        private void dgvSanPham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            gbxInfo.Enabled = true;
            if (dgvSanPham.SelectedRows[0].Cells["Ảnh"].Value.ToString() != null)
            {
                ImageProcessing.Instance.DgvToPbx(dgvSanPham, pbxAnhSp);
            }
            else
            {
                pbxAnhSp.Image = null;
            }
            tbxMaSP.Text = dgvSanPham.SelectedRows[0].Cells["Mã sản phẩm"].Value.ToString();
            tbxTenSP.Text = dgvSanPham.SelectedRows[0].Cells["Tên sản phẩm"].Value.ToString();
            cbxPhanLoai.Text = dgvSanPham.SelectedRows[0].Cells["Tên loại"].Value.ToString();
            tbxSoLuong.Text = dgvSanPham.SelectedRows[0].Cells["Tồn kho"].Value.ToString();
            tbxGiaTien.Text = dgvSanPham.SelectedRows[0].Cells["Giá bán"].Value.ToString();
            tbxGiaNhap.Text = dgvSanPham.SelectedRows[0].Cells["Giá nhập"].Value.ToString();
            cbxGiamGia.Text = dgvSanPham.SelectedRows[0].Cells["Giảm giá"].Value.ToString();
        }

        //Xoa thong tin
        private void clearInfo()
        {
            gbxInfo.Enabled = false;
            pbxAnhSp.Image = null;
            tbxMaSP.Text = " ";
            tbxTenSP.Text = " ";
            cbxPhanLoai.Text = " ";
            tbxSoLuong.Text = " ";
            tbxGiaTien.Text = " ";
        }

        //Tim kiem san pham
        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            SanPhamBUS.Instance.TimKiemSanPham(dgvSanPham, tbxTimKiem.Text);
        }

        //Mo form ThemSP
        private void btnThem_Click(object sender, EventArgs e)
        {
            them = new FormThemSP();
            them.ShowDialog();
            FormDSSanPham_Load(sender, e);
        }

        //Sua thong tin san pham
        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                GetValue();
                if (SanPhamBUS.Instance.SuaSanPham(sanPham) == true)
                {
                    MessageBox.Show("Sửa thông tin thành công");
                }
                else
                {
                    MessageBox.Show("Sửa thông tin không thành công");
                }
                clearInfo();
                FormDSSanPham_Load(sender, e);
            }
            catch (Exception ex)
            {
                //throw ex;
                MessageBox.Show("Lỗi: " + ex);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                string MaSanPham = tbxMaSP.Text;
                if (SanPhamBUS.Instance.XoaSanPham(MaSanPham) == true)
                {
                    MessageBox.Show("Xóa thành công");
                }
                else
                {
                    MessageBox.Show("Xóa không thành công");
                }
                FormDSSanPham_Load(sender, e);
            }
            catch (Exception ex)
            {
                //throw ex;
                MessageBox.Show("Lỗi: " + ex);
            }
        }


        private void btnDauTrang_Click(object sender, EventArgs e)
        {
            PhanTrang.Instance.DauTrang(dataTable, dgvSanPham, lblPageview);
        }

        private void btnFwd_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem có trang tiếp theo không
            PhanTrang.Instance.TrangKeTiep(dataTable, dgvSanPham, lblPageview);
        }

        private void btnEPg_Click(object sender, EventArgs e)
        {
            PhanTrang.Instance.TrangCuoi(dataTable, dgvSanPham, lblPageview);
        }

        private void btnBck_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem có trang trước đó không
            PhanTrang.Instance.TrangKeTruoc(dataTable, dgvSanPham, lblPageview);
        }

        private void btnNhapHang_Click(object sender, EventArgs e)
        {
            FormNhapSoLuong formNhapSoLuong = new FormNhapSoLuong();
            formNhapSoLuong.ShowDialog();
            int GetAmount = formNhapSoLuong.GetAmount();
            string maSp = tbxMaSP.Text;
            int tonKho = int.Parse(tbxSoLuong.Text) + GetAmount;
            int soLuongNhap = int.Parse(dgvSanPham.SelectedRows[0].Cells["Số lượng nhập"].Value.ToString()) + GetAmount;

            try
            {
                if (SanPhamBUS.Instance.NhapHang(tonKho, soLuongNhap, maSp) == true)
                {
                    MessageBox.Show("Nhập hàng thành công");
                }
                else
                {
                    MessageBox.Show("Nhập hàng không thành công");
                }
                clearInfo();
                FormDSSanPham_Load(sender, e);
            }
            catch (Exception ex)
            {
                //throw ex;
                MessageBox.Show("Lỗi: " + ex);
            }
        }


    }
}
