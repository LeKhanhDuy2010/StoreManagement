using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StoreManagement.Utils
{
    class PhanTrang
    {
        private int itemsPerPage = 5; // Số mục trên mỗi trang
        private int currentPage = 1;
        private int totalItems;
        private int totalPages;

        private static PhanTrang instance;

        public static PhanTrang Instance
        {
            get
            {
                if (instance == null)
                    instance = new PhanTrang();
                return instance;
            }
        }

        public void HienThiDuLieuTrangHienTai(DataTable data, DataGridView dgvketQua)
        {

            totalItems = data.Rows.Count;
            totalPages = (int)Math.Ceiling((double)totalItems / itemsPerPage);
            // Lấy dữ liệu của trang hiện tại
            int startIndex = (currentPage - 1) * itemsPerPage;
            int endIndex = Math.Min(startIndex + itemsPerPage - 1, totalItems - 1);

            // Tạo một DataTable mới chứa dữ liệu của trang hiện tại
            DataTable currentPageData = data.Clone();
            for (int i = startIndex; i <= endIndex && i < totalItems; i++)
            {
                currentPageData.ImportRow(data.Rows[i]);
            }

            // Hiển thị dữ liệu trên DataGridView
            dgvketQua.DataSource = currentPageData;
        }
        public void Load(DataTable data, DataGridView dgvketQua, System.Windows.Forms.Label label)
        {
            currentPage = 1;
            HienThiDuLieuTrangHienTai(data, dgvketQua);
            CapNhatSoTrang(label);
        }
        public void CapNhatSoTrang(System.Windows.Forms.Label label)
        {
            // Hiển thị thông tin về trang
            label.Text = $"{currentPage} / {totalPages}";
        }

        public void DauTrang(DataTable data, DataGridView dgvketQua, System.Windows.Forms.Label label)
        {
            currentPage = 1;
            HienThiDuLieuTrangHienTai(data, dgvketQua);
            CapNhatSoTrang(label);
        }

        public void TrangKeTiep(DataTable data, DataGridView dgvketQua, System.Windows.Forms.Label label)
        {
            // Kiểm tra xem có trang tiếp theo không
            if (currentPage < totalPages)
            {
                currentPage++;
                HienThiDuLieuTrangHienTai(data, dgvketQua);
                CapNhatSoTrang(label);
            }
        }

        public void TrangCuoi(DataTable data, DataGridView dgvketQua, System.Windows.Forms.Label label)
        {
            currentPage = totalPages;
            HienThiDuLieuTrangHienTai(data, dgvketQua);
            CapNhatSoTrang(label);
        }

        public void TrangKeTruoc(DataTable data, DataGridView dgvketQua, System.Windows.Forms.Label label)
        {
            // Kiểm tra xem có trang trước đó không
            if (currentPage > 1)
            {
                currentPage--;
                HienThiDuLieuTrangHienTai(data, dgvketQua);
                CapNhatSoTrang(label);
            }
        }
    }
}
