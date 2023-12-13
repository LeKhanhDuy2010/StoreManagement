using Microsoft.Office.Interop.Excel;
using StoreManagement.BUS;
using StoreManagement.DAO;
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
    public partial class FormDSHoaDon : Form
    {
        private System.Data.DataTable dataTable;

        public FormDSHoaDon()
        {
            InitializeComponent();
        }


        private void FormDSHoaDon_Load(object sender, EventArgs e)
        {
            dgvHD.DataSource = HoaDonDAO.Instance.DSHoaDon();
            dataTable = HoaDonDAO.Instance.DSHoaDon();            // Hiển thị trang đầu tiên
            PhanTrang.Instance.Load(dataTable, dgvHD, lblPageview);
        }

        private void btnCTHD_Click(object sender, EventArgs e)
        {
            FormCTHD form = new FormCTHD();
            form.ShowDialog();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string maHoaDon = tbxTimKiem.Text;
            HoaDonBUS.Instance.TimKiemHD(dgvHD, maHoaDon);
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            dgvHD.DataSource = HoaDonDAO.Instance.DSHoaDon();
        }

        private void btnDauTrang_Click(object sender, EventArgs e)
        {
            PhanTrang.Instance.DauTrang(dataTable, dgvHD, lblPageview);
        }

        private void btnFwd_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem có trang tiếp theo không
            PhanTrang.Instance.TrangKeTiep(dataTable, dgvHD, lblPageview);
        }

        private void btnEPg_Click(object sender, EventArgs e)
        {
            PhanTrang.Instance.TrangCuoi(dataTable, dgvHD, lblPageview);
        }

        private void btnBck_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem có trang trước đó không
            PhanTrang.Instance.TrangKeTruoc(dataTable, dgvHD, lblPageview);
        }
    }
}
