using Microsoft.Office.Interop.Excel;
using StoreManagement.BUS;
using StoreManagement.DAO;
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

namespace StoreManagement
{
    public partial class FormDSNhanVien : Form
    {
        FormThemNhanVien them;
        private System.Data.DataTable dataTable;

        public FormDSNhanVien()
        {
            InitializeComponent();
        }
        private void FormDSNhanVien_Load(object sender, EventArgs e)
        {
            dataTable = NhanVienDAO.Instance.DSNhanVien();
            dgvNhanVien.DataSource = dataTable;
            dgvNhanVien.Columns["Mã nhân viên"].ReadOnly = true;

            PhanTrang.Instance.Load(dataTable, dgvNhanVien, lblPageview);

            DataGridViewImageColumn img = new DataGridViewImageColumn();
            img = (DataGridViewImageColumn)dgvNhanVien.Columns[0];
            img.ImageLayout = DataGridViewImageCellLayout.Zoom;

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            them = new FormThemNhanVien();
            them.ShowDialog();
            FormDSNhanVien_Load(sender, e);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                string id = dgvNhanVien.SelectedCells[0].OwningRow.Cells["Mã nhân viên"].Value.ToString();
                if (TaiKhoanBUS.Instance.XoaTaiKhoan(id) == true)
                {
                    if (NhanVienBUS.Instance.XoaNhanVien(id) == true)
                    {
                        MessageBox.Show("Xóa thành công");
                    }
                    else
                    {
                        MessageBox.Show("Xóa không thành công");
                    }
                }
                else
                {
                    MessageBox.Show("Xoá thông tin không thành công");
                }
                FormDSNhanVien_Load(sender, e);
            }
            catch (Exception ex)
            {
                //throw ex;
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            FormDSNhanVien_Load(sender, e);
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string maNhanVien = tbxTimKiem.Text.ToString();
            if(maNhanVien == "")
            {
                MessageBox.Show("Nhập mã nhân viên!","Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            NhanVienBUS.Instance.TimKiemNhanVien(dgvNhanVien, maNhanVien);
        }

        private void btnDauTrang_Click(object sender, EventArgs e)
        {
            PhanTrang.Instance.DauTrang(dataTable, dgvNhanVien, lblPageview);
        }

        private void btnFwd_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem có trang tiếp theo không
            PhanTrang.Instance.TrangKeTiep(dataTable, dgvNhanVien, lblPageview);
        }

        private void btnEPg_Click(object sender, EventArgs e)
        {
            PhanTrang.Instance.TrangCuoi(dataTable, dgvNhanVien, lblPageview);
        }

        private void btnBck_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem có trang trước đó không
            PhanTrang.Instance.TrangKeTruoc(dataTable, dgvNhanVien, lblPageview);
        }
    }
}
