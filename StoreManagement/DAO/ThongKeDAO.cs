using StoreManagement.Utils;
using System;
using System.Data;

namespace StoreManagement.DAO
{
    class ThongKeDAO
    {
        private static ThongKeDAO instance;
        public static ThongKeDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new ThongKeDAO();
                return instance;
            }
        }
        public ThongKeDAO() { }

        public DataTable BieuDoDoanhThu()
        {
            string query = "select month(NgayBan) as Thang, sum(TongTien) as DoanhThu from HoaDon group by month(NgayBan)";
            return DataProvider.Instance.ExecuteQuery(query);
        }

        public int SLSanPham()
        {
            string query = "select * from SanPham";
            int total = DataProvider.Instance.ExecuteQuery(query).Rows.Count;
            return total;
        }

        public int SLPhanLoai()
        {
            string query = "select * from PhanLoai";
            int total = DataProvider.Instance.ExecuteQuery(query).Rows.Count;
            return total;
        }

        public int SLKhachHang()
        {
            string query = "select * from KhachHang";
            int total = DataProvider.Instance.ExecuteQuery(query).Rows.Count;
            return total;
        }
        public int SLHoaDon(string month)
        {
            string query = "select * from HoaDon where month(NgayBan) = @month";
            object[] parameter = { month };
            int total = DataProvider.Instance.ExecuteQuery(query, parameter).Rows.Count;
            return total;
        }

        public DataTable SanPhamTonKho(DateTime startTime, DateTime endTime)
        {
            string query = "SELECT SanPham.MaSanPham as 'MÃ SẢN PHẨM' , SanPham.TenSanPham as 'TÊN SẢN PHẨM' , " +
                            "SanPham.SoLuong AS 'TỒN KHO' " +
                           "FROM SanPham " +
                           "WHERE SanPham.SoLuong > 0 AND SanPham.MaSanPham NOT IN " +
                           "(SELECT DISTINCT ChiTietHoaDon.MaSanPham " +
                           "FROM ChiTietHoaDon " +
                           "JOIN HoaDon ON ChiTietHoaDon.MaHoaDon = HoaDon.MaHoaDon " +
                           "WHERE HoaDon.NgayBan BETWEEN @Start AND @End ) " +
                           "ORDER BY SanPham.SoLuong ";

            object[] parameters = { startTime, endTime };
            return DataProvider.Instance.ExecuteQuery(query, parameters);
        }

        public DataTable SanPhamDaBan(DateTime startTime, DateTime endTime)
        {
            string query = "SELECT ChiTietHoaDon.MaSanPham as 'MÃ SẢN PHẨM', SanPham.TenSanPham as 'TÊN SẢN PHẨM' , " +
                           "SUM(ChiTietHoaDon.SoLuong) AS 'TIÊU THỤ' " +
                           "FROM ChiTietHoaDon " +
                           "JOIN HoaDon ON ChiTietHoaDon.MaHoaDon = HoaDon.MaHoaDon " +
                           "JOIN SanPham ON ChiTietHoaDon.MaSanPham = SanPham.MaSanPham " +
                           "WHERE HoaDon.NgayBan BETWEEN @startTime AND @endTime " +
                           "GROUP BY ChiTietHoaDon.MaSanPham, SanPham.TenSanPham " +
                           "ORDER BY SUM(ChiTietHoaDon.SoLuong) DESC ";

            object[] parameters = { startTime, endTime };

            return DataProvider.Instance.ExecuteQuery(query, parameters);
        }


        public DataTable DoanhThu(DateTime startTime, DateTime endTime)
        {
            string query = "SELECT sp.MaSanPham as 'MÃ SẢN PHẨM', sp.TenSanPham as 'TÊN SẢN PHẨM' , " +
                            "ISNULL(SUM(cthd.SoLuong * cthd.DonGia * (1 - cthd.GiamGia / 100)), 0) AS 'DOANH THU' , " +
                            "ISNULL(SUM(sp.GiaNhap * cthd.SoLuong), 0) AS 'TỔNG VỐN' , " +
                            "ISNULL(SUM(cthd.SoLuong * cthd.DonGia * (1 - cthd.GiamGia / 100)), 0) - ISNULL(SUM(sp.GiaNhap * cthd.SoLuong), 0) AS 'LỢI NHUẬN' " +
                    "FROM SanPham sp " +
                    "JOIN ChiTietHoaDon cthd ON sp.MaSanPham = cthd.MaSanPham " +
                    "JOIN HoaDon hd ON cthd.MaHoaDon = hd.MaHoaDon " +
                    "WHERE hd.NgayBan BETWEEN @startTime AND @endTime " +
                    "GROUP BY sp.MaSanPham, sp.TenSanPham ";

            object[] parameters = { startTime, endTime };

            return DataProvider.Instance.ExecuteQuery(query, parameters);
        }
    }
}
