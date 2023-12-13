using StoreManagement.BUS;
using StoreManagement.DAO;
using StoreManagement.DTO;
using StoreManagement.Utils;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace StoreManagement
{
    public partial class FormTTHD : Form
    {
        ThanhToanDTO thanhToan;
        HoaDonDTO hoaDon;
        FormNhapSoLuong nhapSLuong;
        private DataTable dataTable;
        private DataTable gioHang;

        string maHoaDon;
        readonly string maNhanvien = NhanVienBUS.currentNhanVien.MaNhanVien;


        public FormTTHD()
        {
            InitializeComponent();
        }
        private void FormTTHD_Load(object sender, EventArgs e)
        {

            dataTable = SanPhamDAO.Instance.DSSanPham();
            dgvSanPham.DataSource = dataTable;
            dgvSanPham.Columns["Mã sản phẩm"].Visible = false;
            dgvSanPham.Columns["Giảm giá"].Visible = false;
            dgvSanPham.Columns["Số lượng nhập"].Visible = false;
            dgvSanPham.Columns["Giá nhập"].Visible = false;
            DataGridViewImageColumn img = (DataGridViewImageColumn)dgvSanPham.Columns[0];
            img.ImageLayout = DataGridViewImageCellLayout.Zoom;

            //Lấy thông tin để phân trang
            PhanTrang.Instance.Load(dataTable, dgvSanPham, lblPageview);

            gioHang = LoadGioHang();
            dgvGioHang.DataSource = gioHang;

            btnTaoHoaDon.Enabled = true;
            pnlButton.Enabled = false;
            dtpkNgayBan.Value = DateTime.Today;
        }

        private DataTable LoadGioHang()
        {
            gioHang = new DataTable();
            if (gioHang.Columns.Count == 0)
            {
                gioHang.Columns.Add("MÃ SẢN PHẨM", typeof(string));
                gioHang.Columns.Add("TÊN SẢN PHẨM", typeof(string));
                gioHang.Columns.Add("SỐ LƯỢNG", typeof(int));
                gioHang.Columns.Add("GIÁ BÁN", typeof(float));
                gioHang.Columns.Add("GIẢM GIÁ", typeof(float));
                gioHang.Columns.Add("THÀNH TIỀN", typeof(float));
            }
            return gioHang;
        }

        private void btnTaoHoaDon_Click(object sender, EventArgs e)
        {
            ResetValue();
            pnlButton.Enabled = true;
            dgvGioHang.DataSource = gioHang;
            tbxMaHD.Text = ThanhToanBUS.Instance.idGenerate("HD");
            dtpkNgayBan.Value = DateTime.Today;
            btnTaoHoaDon.Enabled = false;
        }

        //Them san pham vao gio hang
        private void ThemVaoGioHang()
        {
            if (dgvSanPham.SelectedRows[0].Cells["Mã sản phẩm"].Value != null)
            {
                string maSanPham = dgvSanPham.SelectedRows[0].Cells["Mã sản phẩm"].Value.ToString();
                string tenSanPham = dgvSanPham.SelectedRows[0].Cells["Tên sản phẩm"].Value.ToString();
                float giaTien = float.Parse(dgvSanPham.SelectedRows[0].Cells["Giá bán"].Value.ToString());
                float giamGia;
                if (dgvSanPham.SelectedRows[0].Cells["Giảm giá"].Value.ToString() != "")
                {
                    giamGia = float.Parse(dgvSanPham.SelectedRows[0].Cells["Giảm giá"].Value.ToString());
                }
                else
                {
                    giamGia = 0;
                }

                bool found = false;

                int soLuong = 0;
                float thanhTien;
                int tongSLSanPham;

                //Get So Luong
                nhapSLuong = new FormNhapSoLuong();
                nhapSLuong.ShowDialog();
                soLuong = nhapSLuong.GetAmount();

                //Input phai lon hon 0
                if (soLuong > 0)
                {
                    //Check xem Sp đa ton tai trong gio hang chua
                    foreach (DataGridViewRow row in dgvGioHang.Rows)
                    {
                        if (row.Cells["MÃ SẢN PHẨM"].Value?.ToString() == maSanPham)
                        {
                            tongSLSanPham = (int)dgvSanPham.SelectedRows[0].Cells["Tồn kho"].Value - (int)row.Cells["SỐ LƯỢNG"].Value;
                            if (ThanhToanBUS.Instance.checkSoLuong(soLuong, tongSLSanPham) >= 0)
                            {
                                row.Cells["SỐ LƯỢNG"].Value = (int)row.Cells["SỐ LƯỢNG"].Value + soLuong;
                            }
                            found = true;
                            break;
                        }
                    }
                    if (found == false || dgvGioHang.Rows[0].Cells["MÃ SẢN PHẨM"].Value == null)
                    {
                        tongSLSanPham = (int)dgvSanPham.SelectedRows[0].Cells["Tồn kho"].Value;
                        if (ThanhToanBUS.Instance.checkSoLuong(soLuong, tongSLSanPham) >= 0)
                        {
                            DataRow gioHangRow = gioHang.NewRow();
                            gioHangRow["MÃ SẢN PHẨM"] = maSanPham;
                            gioHangRow["TÊN SẢN PHẨM"] = tenSanPham;
                            gioHangRow["SỐ LƯỢNG"] = soLuong;
                            gioHangRow["GIÁ BÁN"] = giaTien;
                            gioHangRow["GIẢM GIÁ"] = giamGia;
                            thanhTien = (float)(soLuong * giaTien) - (soLuong * giaTien * (giamGia / 100));
                            gioHangRow["THÀNH TIỀN"] = thanhTien;
                            gioHang.Rows.Add(gioHangRow);
                        }
                    }
                }
                TinhTien();
            }
            else
            {
                MessageBox.Show("Mời chọn sản phẩm");
            }
        }

        private void btnThemGioHang_Click(object sender, EventArgs e)
        {
            ThemVaoGioHang();
        }

        private void btnXoaGioHang_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvGioHang.SelectedRows)
            {
                dgvGioHang.Rows.RemoveAt(row.Index);
            }
        }

        private void dgvGioHang_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int soLuong;
            int tongSLSanPham;
            DataGridViewRow row = dgvGioHang.SelectedRows[0];

            //Get So Luong
            nhapSLuong = new FormNhapSoLuong();
            nhapSLuong.ShowDialog();
            soLuong = nhapSLuong.GetAmount();

            tongSLSanPham = (int)dgvSanPham.SelectedRows[0].Cells["Tồn kho"].Value - (int)row.Cells["SỐ LƯỢNG"].Value;
            if (ThanhToanBUS.Instance.checkSoLuong(soLuong, tongSLSanPham) >= 0 && soLuong > 0)
            {
                row.Cells["SỐ LƯỢNG"].Value = soLuong;
            }
            else if (soLuong <= 0)
            {
                btnXoaGioHang_Click(sender, e);
            }
        }

        private void dgvSanPham_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (!btnTaoHoaDon.Enabled)
            {
                ThemVaoGioHang();
            }
        }

        private void btnHuyHD_Click(object sender, EventArgs e)
        {
            ResetValue();
            FormTTHD_Load(sender, e);
        }
        //Tim kiem san pham
        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            ThanhToanBUS.Instance.TimKiemSanPham(dgvSanPham, tbxTimKiem.Text);
        }
        //Refresh
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            dgvSanPham.DataSource = SanPhamDAO.Instance.DSSanPham();
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            if (dgvGioHang.RowCount > 1)
            {
                GetValueHoaDon();
                try
                {
                    if (HoaDonBUS.Instance.LuuHoaDon(hoaDon) == true)
                    {
                        MessageBox.Show("Lưu hóa đơn thành công");
                        LuuCTHD();
                        pPDHoaDon.Document = pDHoaDon;
                        pPDHoaDon.ShowDialog();
                        btnTaoHoaDon.Enabled = true;
                        ResetValue();
                        FormTTHD_Load(sender, e);
                    }
                    else
                    {
                        MessageBox.Show("Lưu hóa đơn ko thành công");
                    }
                }
                catch (Exception ex)
                {
                    //throw ex;
                    MessageBox.Show("Lỗi: " + ex);
                }
            }
        }

        private float TinhTien()
        {
            float tongTien;
            float result = 0;
            float giamGia = 0;

            List<float> listThanhTien = new List<float>();
            try
            {
                for (int i = 0; i < dgvGioHang.RowCount - 1; i++)
                {
                    listThanhTien.Add(float.Parse(dgvGioHang.Rows[i].Cells["THÀNH TIỀN"].Value.ToString()));
                }

                if (dgvGioHang.RowCount > 1)
                {

                    if (dgvGioHang.Rows[0].Cells["THÀNH TIỀN"].Value != null && dgvGioHang.Rows[0].Cells["GIÁ BÁN"].Value != null)
                    {
                        for (int i = 0; i < dgvGioHang.RowCount - 1; i++)
                        {
                            result += listThanhTien[i];
                        }
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex);
            }
            tongTien = result;

            if (tbxGiamGia.Text != "")
            {
                giamGia = float.Parse(tbxGiamGia.Text) / 100;
            }
            tbxPhaiThanhToan.Text = (tongTien - (tongTien * giamGia)).ToString();
            tbxTongTien.Text = tongTien.ToString();
            return result;
        }

        private void tbxGiamGia_TextChanged(object sender, EventArgs e)
        {
            TinhTien();
        }

        private void GetValueHoaDon()
        {
            if (dgvGioHang.RowCount > 1)
            {

                string maHoaDon = tbxMaHD.Text;
                DateTime ngayBan = DateTime.Now;
                if (dtpkNgayBan.Value < DateTime.Now)
                {
                    ngayBan = dtpkNgayBan.Value;
                }
                float tongTien = float.Parse(tbxPhaiThanhToan.Text);
                FormDSKhachHang luuKH = new FormDSKhachHang();
                luuKH.ShowDialog();
                string maKH = luuKH.chonKH();
                hoaDon = new HoaDonDTO(maHoaDon, maNhanvien, ngayBan, maKH, tongTien);
            }
        }

        //GetValue CTHD
        public void LuuCTHD()
        {
            maHoaDon = tbxMaHD.Text;
            float thanhTien = float.Parse(tbxPhaiThanhToan.Text);

            int giamGia = 0;
            if (tbxGiamGia.Text != "")
            {
                giamGia = int.Parse(tbxGiamGia.Text);
            }

            for (int i = 0; i < dgvGioHang.RowCount - 1; i++)
            {
                string maSanPham = dgvGioHang.Rows[i].Cells["MÃ SẢN PHẨM"].Value.ToString();
                int soLuong = (int)dgvGioHang.Rows[i].Cells["SỐ LƯỢNG"].Value;
                float donGia = float.Parse(dgvGioHang.Rows[i].Cells["GIÁ BÁN"].Value.ToString());
                float giamGiaSP = float.Parse(dgvGioHang.Rows[i].Cells["GIẢM GIÁ"].Value.ToString());

                thanhToan = new ThanhToanDTO(maHoaDon, maSanPham, soLuong, donGia, giamGia, giamGiaSP, thanhTien);
                ThanhToanBUS.Instance.UpdateSoLuong(soLuong, maSanPham);
                ThanhToanBUS.Instance.LuuCTHD(thanhToan);
            }
        }

        public void ResetValue()
        {
            tbxMaHD.Text = "";
            tbxTongTien.Text = "";
            tbxGiamGia.Text = "";
            tbxPhaiThanhToan.Text = "";
            gioHang.Rows.Clear();
        }

        //In hoa don
        private void pDHoaDon_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            string maHD = "Mã hóa đơn: " + tbxMaHD.Text;
            string ngayBan = "Ngày: " + dtpkNgayBan.Value.ToString();

            string tongTien = "Tổng tiền: " + tbxTongTien.Text;
            string giamGiaHD = "Giảm giá: " + tbxGiamGia.Text + "%";
            string phaiThanhToan = "Thành tiền: " + tbxPhaiThanhToan.Text;

            //Header
            e.Graphics.DrawString("SIÊU THỊ MINI".ToUpper(), new Font("Microsoft Sans Serif",
                20, FontStyle.Bold), Brushes.Black, new Point(330, 20));
            e.Graphics.DrawString("Tô ký, Tân Chánh Hiệp, quận 12, Hồ Chí Minh".ToUpper(),
                new Font("Microsoft Sans Serif",
                12, FontStyle.Regular), Brushes.Black, new Point(200, 60));
            e.Graphics.DrawString("SDT: +84-024681012".ToUpper(), new Font("Microsoft Sans Serif",
                12, FontStyle.Regular), Brushes.Black, new Point(330, 80));
            e.Graphics.DrawString("HÓA ĐƠN BÁN HÀNG".ToUpper(), new Font("Microsoft Sans Serif",
                18, FontStyle.Bold), Brushes.Black, new Point(280, 140));
            e.Graphics.DrawString(maHD.ToUpper(), new Font("Microsoft Sans Serif",
                12, FontStyle.Bold), Brushes.Black, new Point(330, 170));
            e.Graphics.DrawString(ngayBan.ToUpper(), new Font("Microsoft Sans Serif",
                12, FontStyle.Regular), Brushes.Black, new Point(330, 190));

            Pen blackPen = new Pen(Color.Black, 1);

            int y = 220;

            Point p1 = new Point(10, y);
            Point p2 = new Point(840, y);

            e.Graphics.DrawLine(blackPen, p1, p2);

            y += 10;

            //CollumnName

            e.Graphics.DrawString("Tên sản phẩm", new Font("Microsoft Sans Serif",
            12, FontStyle.Bold), Brushes.Black, new Point(20, y));
            e.Graphics.DrawString("Tồn kho", new Font("Microsoft Sans Serif",
            12, FontStyle.Bold), Brushes.Black, new Point(180, y));
            e.Graphics.DrawString("Giá", new Font("Microsoft Sans Serif",
            12, FontStyle.Bold), Brushes.Black, new Point(340, y));
            e.Graphics.DrawString("Giảm giá", new Font("Microsoft Sans Serif",
            12, FontStyle.Bold), Brushes.Black, new Point(480, y));
            e.Graphics.DrawString("Thành tiền", new Font("Microsoft Sans Serif",
            12, FontStyle.Bold), Brushes.Black, new Point(620, y));

            //DSSanPham
            for (int i = 0; i < dgvGioHang.RowCount - 1; i++)
            {
                y += 20;

                string tenSanPham = dgvGioHang.Rows[i].Cells["TÊN SẢN PHẨM"].Value.ToString();
                string soLuong = dgvGioHang.Rows[i].Cells["SỐ LƯỢNG"].Value.ToString();
                string donGia = dgvGioHang.Rows[i].Cells["GIÁ BÁN"].Value.ToString();
                string giamGia = dgvGioHang.Rows[i].Cells["GIẢM GIÁ"].Value.ToString();
                string thanhTien = dgvGioHang.Rows[i].Cells["THÀNH TIỀN"].Value.ToString();



                e.Graphics.DrawString(tenSanPham, new Font("Microsoft Sans Serif",
                12, FontStyle.Regular), Brushes.Black, new Point(20, y));
                e.Graphics.DrawString(soLuong, new Font("Microsoft Sans Serif",
                12, FontStyle.Regular), Brushes.Black, new Point(180, y));
                e.Graphics.DrawString(donGia, new Font("Microsoft Sans Serif",
                12, FontStyle.Regular), Brushes.Black, new Point(340, y));
                e.Graphics.DrawString(giamGia, new Font("Microsoft Sans Serif",
                12, FontStyle.Regular), Brushes.Black, new Point(480, y));
                e.Graphics.DrawString(thanhTien, new Font("Microsoft Sans Serif",
                12, FontStyle.Regular), Brushes.Black, new Point(620, y));

            }


            y += 30;
            Point p3 = new Point(10, y);
            Point p4 = new Point(840, y);
            e.Graphics.DrawLine(blackPen, p3, p4);

            //Footer
            y += 20;
            e.Graphics.DrawString(tongTien, new Font("Microsoft Sans Serif",
            12, FontStyle.Bold), Brushes.Black, new Point(620 - 80, y));

            y += 20;
            e.Graphics.DrawString(giamGiaHD, new Font("Microsoft Sans Serif",
            12, FontStyle.Bold), Brushes.Black, new Point(620 - 80, y));

            y += 20;
            e.Graphics.DrawString(phaiThanhToan, new Font("Microsoft Sans Serif",
            12, FontStyle.Bold), Brushes.Black, new Point(620 - 80, y));

            y += 50;
            e.Graphics.DrawString("Xin cảm ơn quý khách!", new Font("Microsoft Sans Serif",
            14, FontStyle.Bold), Brushes.Black, new Point(300, y));
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
    }
}
