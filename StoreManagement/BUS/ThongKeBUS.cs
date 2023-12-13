using StoreManagement.DAO;
using System;
using System.Data;

namespace StoreManagement.BUS
{
    class ThongKeBUS
    {
        private static ThongKeBUS instance;
        public static ThongKeBUS Instance
        {
            get
            {
                if (instance == null)
                    instance = new ThongKeBUS();
                return instance;
            }
        }
        public ThongKeBUS() { }

        public DataTable BieuDoDoanhThu()
        {
            DataTable data = ThongKeDAO.Instance.BieuDoDoanhThu();
            return data;
        }
        public int SLSanPham()
        {
            return ThongKeDAO.Instance.SLSanPham();
        }
        public int SLPhanLoai()
        {
            return ThongKeDAO.Instance.SLPhanLoai();
        }
        public int SLKhachHang()
        {
            return ThongKeDAO.Instance.SLKhachHang();
        }
        public int SLHoaDon()
        {
            string month = DateTime.Now.Month.ToString();
            return ThongKeDAO.Instance.SLHoaDon(month);
        }

        public DataTable SanPhamTonKho(DateTime start, DateTime end)
        {
            DataTable data = ThongKeDAO.Instance.SanPhamTonKho(start, end);
            return data;
        }
        public DataTable SanPhamDaBan(DateTime start, DateTime end)
        {
            DataTable data = ThongKeDAO.Instance.SanPhamDaBan(start, end);
            return data;
        }
        public DataTable DoanhThu(DateTime start, DateTime end)
        {
            DataTable data = ThongKeDAO.Instance.DoanhThu(start, end);
            return data;
        }
    }
}
