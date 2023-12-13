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
using System.Windows.Forms.DataVisualization.Charting;

namespace StoreManagement
{
    public partial class FormThongKe : Form
    {
        private float tongThu;
        private float tongChi;
        private float tongLai;
        private System.Data.DataTable dataTable;

        public FormThongKe()
        {
            InitializeComponent();
        }

        private void FormThongKe_Load(object sender, EventArgs e)
        {
            FillChart();
            tbxSLSP.Text = ThongKeBUS.Instance.SLSanPham().ToString();
            tbxSLPL.Text = ThongKeBUS.Instance.SLPhanLoai().ToString();
            tbxSLKH.Text = ThongKeBUS.Instance.SLKhachHang().ToString();
            lblHoaDon.Text = "Tổng số hóa đơn đã tạo trong tháng " + DateTime.Now.Month.ToString() + ":";
            tbxHoaDon.Text = ThongKeBUS.Instance.SLHoaDon().ToString();
            pnlPrint.Visible = false;
        }

        private void FillChart()
        {
            DataTable table = ThongKeBUS.Instance.BieuDoDoanhThu();

            chrtDoanhThu.Series.Clear();
            chrtDoanhThu.ChartAreas[0].AxisX.Title = "Tháng";
            chrtDoanhThu.ChartAreas[0].AxisY.Title = "Doanh Thu";

            Series series = chrtDoanhThu.Series.Add("Doanh Thu");
            series.ChartType = SeriesChartType.Column;
            series.XValueType = ChartValueType.Int32;
            series.YValueType = ChartValueType.Int32;

            foreach (DataRow row in table.Rows)
            {
                series.Points.AddXY(row["Thang"], row["DoanhThu"]);
            }
        }

        private void btnBaoCao_Click(object sender, EventArgs e)
        {
            DateTime startDate = dtpStart.Value;
            DateTime endDate = dtpEnd.Value;
            if (cbxBaoCao.SelectedItem != null)
            {
                var selected = cbxBaoCao.SelectedItem.ToString();

                if (selected == "Sản phẩm tồn kho")
                {
                    pnlPrint.Visible = true;
                    dataTable = ThongKeDAO.Instance.SanPhamTonKho(startDate, endDate);
                    dgvBaoCao.DataSource = dataTable;
                    PhanTrang.Instance.Load(dataTable, dgvBaoCao, lblPageview);

                }
                else if (selected == "Sản phẩm tiêu thụ")
                {
                    pnlPrint.Visible = true;
                    dataTable = ThongKeDAO.Instance.SanPhamDaBan(startDate, endDate);
                    dgvBaoCao.DataSource = dataTable;
                    PhanTrang.Instance.Load(dataTable, dgvBaoCao, lblPageview);
                }
                else if (selected == "Chi tiết doanh thu")
                {
                    pnlPrint.Visible = true;
                    dataTable = ThongKeDAO.Instance.DoanhThu(startDate, endDate);
                    dgvBaoCao.DataSource = dataTable;
                    PhanTrang.Instance.Load(dataTable, dgvBaoCao, lblPageview);
                }
            }
            else
            {
                MessageBox.Show("Chọn giá trị", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXemChiTiet_Click(object sender, EventArgs e)
        {
            DateTime startDate = dtpStart.Value;
            DateTime endDate = dtpEnd.Value;
            if(startDate > endDate)
            {
                MessageBox.Show("Ngày bắt đầu phải nhỏ hơn hoặc bằng ngày kết thúc", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (cbxBaoCao.SelectedItem != null)
            {
                var selected = cbxBaoCao.SelectedItem.ToString();

                if (selected == "Sản phẩm tồn kho")
                {
                    printPreviewDialogBaoCao.Document = printDocumentTonKho;
                    printPreviewDialogBaoCao.ShowDialog();
                }
                else if (selected == "Sản phẩm tiêu thụ")
                {
                    printPreviewDialogBaoCao.Document = printDocumentDaBan;
                    printPreviewDialogBaoCao.ShowDialog();
                }
                else if (selected == "Chi tiết doanh thu")
                {
                    printPreviewDialogBaoCao.Document = printDocumentDoanhThu;
                    printPreviewDialogBaoCao.ShowDialog();
                }
            }
            else
            {
                MessageBox.Show("Chọn giá trị", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #region InBaoCao

        private void printDocumentDoanhThu_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            string startDate = "Từ: " + dtpStart.Value.ToString();
            string endDate = "Đến: " + dtpEnd.Value.ToString();



            //Header
            e.Graphics.DrawString("SIÊU THỊ MINI".ToUpper(), new Font("Microsoft Sans Serif",
                20, FontStyle.Bold), Brushes.Black, new Point(330, 20));
            e.Graphics.DrawString("Tô ký, Tân Chánh Hiệp, quận 12, Hồ Chí Minh".ToUpper(),
                new Font("Microsoft Sans Serif",
                12, FontStyle.Regular), Brushes.Black, new Point(200, 60));
            e.Graphics.DrawString("SDT: +84-024681012".ToUpper(), new Font("Microsoft Sans Serif",
                12, FontStyle.Regular), Brushes.Black, new Point(330, 80));
            e.Graphics.DrawString("BÁO CÁO DOANH THU".ToUpper(), new Font("Microsoft Sans Serif",
                18, FontStyle.Bold), Brushes.Black, new Point(280, 140));
            e.Graphics.DrawString(startDate.ToUpper(), new Font("Microsoft Sans Serif",
                12, FontStyle.Regular), Brushes.Black, new Point(330, 200));
            e.Graphics.DrawString(endDate.ToUpper(), new Font("Microsoft Sans Serif",
                12, FontStyle.Regular), Brushes.Black, new Point(330, 220));

            Pen blackPen = new Pen(Color.Black, 1);

            int y = 280;

            Point p1 = new Point(10, y);
            Point p2 = new Point(840, y);

            e.Graphics.DrawLine(blackPen, p1, p2);

            y += 10;

            //CollumnName

            e.Graphics.DrawString("Mã sản phẩm", new Font("Microsoft Sans Serif",
            12, FontStyle.Bold), Brushes.Black, new Point(20, y));
            e.Graphics.DrawString("Tên sản phẩm", new Font("Microsoft Sans Serif",
            12, FontStyle.Bold), Brushes.Black, new Point(180, y));
            e.Graphics.DrawString("Doanh thu", new Font("Microsoft Sans Serif",
            12, FontStyle.Bold), Brushes.Black, new Point(340, y));
            e.Graphics.DrawString("Vốn", new Font("Microsoft Sans Serif",
            12, FontStyle.Bold), Brushes.Black, new Point(480, y));
            e.Graphics.DrawString("Lợi nhuận", new Font("Microsoft Sans Serif",
            12, FontStyle.Bold), Brushes.Black, new Point(620, y));

            float tienThu;
            float tienChi;
            float tienLai;
            //DSSanPham
            for (int i = 0; i < dgvBaoCao.RowCount - 1; i++)
            {
                y += 20;

                string maSP = dgvBaoCao.Rows[i].Cells["MÃ SẢN PHẨM"].Value.ToString();
                string tenSanPham = dgvBaoCao.Rows[i].Cells["TÊN SẢN PHẨM"].Value.ToString();
                string doanhThu = dgvBaoCao.Rows[i].Cells["DOANH THU"].Value.ToString();
                tienThu = float.Parse(doanhThu);
                tongThu += tienThu;
                string tongGiaNhap = dgvBaoCao.Rows[i].Cells["TỔNG VỐN"].Value.ToString();
                tienChi = float.Parse(tongGiaNhap);
                tongChi += tienChi;
                string loiNhuan = dgvBaoCao.Rows[i].Cells["LỢI NHUẬN"].Value.ToString();
                tienLai = float.Parse(loiNhuan);
                tongLai += tienLai;


                e.Graphics.DrawString(maSP, new Font("Microsoft Sans Serif",
                12, FontStyle.Regular), Brushes.Black, new Point(20, y));
                e.Graphics.DrawString(tenSanPham, new Font("Microsoft Sans Serif",
                12, FontStyle.Regular), Brushes.Black, new Point(180, y));
                e.Graphics.DrawString(doanhThu, new Font("Microsoft Sans Serif",
                12, FontStyle.Regular), Brushes.Black, new Point(340, y));
                e.Graphics.DrawString(tongGiaNhap, new Font("Microsoft Sans Serif",
                12, FontStyle.Regular), Brushes.Black, new Point(480, y));
                e.Graphics.DrawString(loiNhuan, new Font("Microsoft Sans Serif",
                12, FontStyle.Regular), Brushes.Black, new Point(620, y));

            }


            y += 30;
            Point p3 = new Point(10, y);
            Point p4 = new Point(840, y);
            e.Graphics.DrawLine(blackPen, p3, p4);

            //Footer
            y += 20;
            e.Graphics.DrawString("TỔNG DOANH THU: " + tongThu.ToString(), new Font("Microsoft Sans Serif",
            12, FontStyle.Bold), Brushes.Black, new Point(620 - 80, y));

            y += 20;
            e.Graphics.DrawString("TỔNG SỐ VỐN: " + tongChi.ToString(), new Font("Microsoft Sans Serif",
            12, FontStyle.Bold), Brushes.Black, new Point(620 - 80, y));

            y += 20;
            e.Graphics.DrawString("TỒNG LỢI NHUẬN: " + tongLai.ToString(), new Font("Microsoft Sans Serif",
            12, FontStyle.Bold), Brushes.Black, new Point(620 - 80, y));

        }

        private void printDocumentTonKho_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            string startDate = "Từ: " + dtpStart.Value.ToString();
            string endDate = "Đến: " + dtpEnd.Value.ToString();



            //Header
            e.Graphics.DrawString("SIÊU THỊ MINI".ToUpper(), new Font("Microsoft Sans Serif",
                20, FontStyle.Bold), Brushes.Black, new Point(330, 20));
            e.Graphics.DrawString("Tô ký, Tân Chánh Hiệp, quận 12, Hồ Chí Minh".ToUpper(),
                new Font("Microsoft Sans Serif",
                12, FontStyle.Regular), Brushes.Black, new Point(200, 60));
            e.Graphics.DrawString("SDT: +84-024681012".ToUpper(), new Font("Microsoft Sans Serif",
                12, FontStyle.Regular), Brushes.Black, new Point(330, 80));
            e.Graphics.DrawString("DANH SÁCH SẢN PHẨM TỒN KHO".ToUpper(), new Font("Microsoft Sans Serif",
                18, FontStyle.Bold), Brushes.Black, new Point(180, 140));
            e.Graphics.DrawString(startDate.ToUpper(), new Font("Microsoft Sans Serif",
                12, FontStyle.Regular), Brushes.Black, new Point(330, 200));
            e.Graphics.DrawString(endDate.ToUpper(), new Font("Microsoft Sans Serif",
                12, FontStyle.Regular), Brushes.Black, new Point(330, 220));

            Pen blackPen = new Pen(Color.Black, 1);

            int y = 280;

            Point p1 = new Point(10, y);
            Point p2 = new Point(840, y);

            e.Graphics.DrawLine(blackPen, p1, p2);

            y += 10;

            //CollumnName

            e.Graphics.DrawString("Mã sản phẩm", new Font("Microsoft Sans Serif",
            12, FontStyle.Bold), Brushes.Black, new Point(100, y));
            e.Graphics.DrawString("Tên sản phẩm", new Font("Microsoft Sans Serif",
            12, FontStyle.Bold), Brushes.Black, new Point(300, y));
            e.Graphics.DrawString("Tồn kho", new Font("Microsoft Sans Serif",
            12, FontStyle.Bold), Brushes.Black, new Point(600, y));



            //DSSanPham
            for (int i = 0; i < dgvBaoCao.RowCount - 1; i++)
            {
                y += 20;

                string maSP = dgvBaoCao.Rows[i].Cells["MÃ SẢN PHẨM"].Value.ToString();
                string tenSanPham = dgvBaoCao.Rows[i].Cells["TÊN SẢN PHẨM"].Value.ToString();
                string tonKho = dgvBaoCao.Rows[i].Cells["TỒN KHO"].Value.ToString();


                e.Graphics.DrawString(maSP, new Font("Microsoft Sans Serif",
                12, FontStyle.Regular), Brushes.Black, new Point(100, y));
                e.Graphics.DrawString(tenSanPham, new Font("Microsoft Sans Serif",
                12, FontStyle.Regular), Brushes.Black, new Point(300, y));
                e.Graphics.DrawString(tonKho, new Font("Microsoft Sans Serif",
                12, FontStyle.Regular), Brushes.Black, new Point(600, y));


            }


            y += 30;
            Point p3 = new Point(10, y);
            Point p4 = new Point(840, y);
            e.Graphics.DrawLine(blackPen, p3, p4);

            //Footer

        }

        private void printDocumentDaBan_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            string startDate = "Từ: " + dtpStart.Value.ToString();
            string endDate = "Đến: " + dtpEnd.Value.ToString();



            //Header
            e.Graphics.DrawString("SIÊU THỊ MINI".ToUpper(), new Font("Microsoft Sans Serif",
                20, FontStyle.Bold), Brushes.Black, new Point(330, 20));
            e.Graphics.DrawString("Tô ký, Tân Chánh Hiệp, quận 12, Hồ Chí Minh".ToUpper(),
                new Font("Microsoft Sans Serif",
                12, FontStyle.Regular), Brushes.Black, new Point(200, 60));
            e.Graphics.DrawString("SDT: +84-024681012".ToUpper(), new Font("Microsoft Sans Serif",
                12, FontStyle.Regular), Brushes.Black, new Point(330, 80));
            e.Graphics.DrawString("DANH SÁCH SẢN PHẨM ĐÃ TIÊU THỤ".ToUpper(), new Font("Microsoft Sans Serif",
                18, FontStyle.Bold), Brushes.Black, new Point(180, 140));
            e.Graphics.DrawString(startDate.ToUpper(), new Font("Microsoft Sans Serif",
                12, FontStyle.Regular), Brushes.Black, new Point(330, 200));
            e.Graphics.DrawString(endDate.ToUpper(), new Font("Microsoft Sans Serif",
                12, FontStyle.Regular), Brushes.Black, new Point(330, 220));

            Pen blackPen = new Pen(Color.Black, 1);

            int y = 280;

            Point p1 = new Point(10, y);
            Point p2 = new Point(840, y);

            e.Graphics.DrawLine(blackPen, p1, p2);

            y += 10;

            //CollumnName

            e.Graphics.DrawString("Mã sản phẩm", new Font("Microsoft Sans Serif",
            12, FontStyle.Bold), Brushes.Black, new Point(100, y));
            e.Graphics.DrawString("Tên sản phẩm", new Font("Microsoft Sans Serif",
            12, FontStyle.Bold), Brushes.Black, new Point(300, y));
            e.Graphics.DrawString("Tiêu thụ", new Font("Microsoft Sans Serif",
            12, FontStyle.Bold), Brushes.Black, new Point(600, y));



            //DSSanPham
            for (int i = 0; i < dgvBaoCao.RowCount - 1; i++)
            {
                y += 20;

                string maSP = dgvBaoCao.Rows[i].Cells["MÃ SẢN PHẨM"].Value.ToString();
                string tenSanPham = dgvBaoCao.Rows[i].Cells["TÊN SẢN PHẨM"].Value.ToString();
                string tieuThu = dgvBaoCao.Rows[i].Cells["TIÊU THỤ"].Value.ToString();


                e.Graphics.DrawString(maSP, new Font("Microsoft Sans Serif",
                12, FontStyle.Regular), Brushes.Black, new Point(100, y));
                e.Graphics.DrawString(tenSanPham, new Font("Microsoft Sans Serif",
                12, FontStyle.Regular), Brushes.Black, new Point(300, y));
                e.Graphics.DrawString(tieuThu, new Font("Microsoft Sans Serif",
                12, FontStyle.Regular), Brushes.Black, new Point(600, y));


            }


            y += 30;
            Point p3 = new Point(10, y);
            Point p4 = new Point(840, y);
            e.Graphics.DrawLine(blackPen, p3, p4);

            //Footer
        }



        #endregion

        private void btnDauTrang_Click(object sender, EventArgs e)
        {
            PhanTrang.Instance.DauTrang(dataTable, dgvBaoCao, lblPageview);
        }

        private void btnFwd_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem có trang tiếp theo không
            PhanTrang.Instance.TrangKeTiep(dataTable, dgvBaoCao, lblPageview);
        }

        private void btnEPg_Click(object sender, EventArgs e)
        {
            PhanTrang.Instance.TrangCuoi(dataTable, dgvBaoCao, lblPageview);
        }

        private void btnBck_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem có trang trước đó không
            PhanTrang.Instance.TrangKeTruoc(dataTable, dgvBaoCao, lblPageview);
        }
    }
}
