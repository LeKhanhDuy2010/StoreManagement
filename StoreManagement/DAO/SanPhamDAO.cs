using System.Data.SqlClient;
using System.Data;
using StoreManagement.DTO;
using StoreManagement.Utils;

namespace StoreManagement.DAO
{
    class SanPhamDAO
    {
        private static SanPhamDAO instance;

        public static SanPhamDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new SanPhamDAO();
                return instance;
            }
            //set { instance = value; }
        }
        public SanPhamDAO() { }

        public static SqlCommand cmd = new SqlCommand();

        public DataTable DSSanPham()
        {
            string query = "select AnhSanPham as 'Ảnh'," +
                " MaSanPham as 'Mã sản phẩm'," +
                " TenSanPham as 'Tên sản phẩm' ," +
                " PhanLoai.TenLoai as 'Tên loại', " +
                " SoLuongNhap as 'Số lượng nhập', " +
                " SoLuong as 'Tồn kho', " +
                " GiaNhap as 'Giá nhập' ," +
                " GiaBan as 'Giá bán' ," +
                " GiamGia as 'Giảm giá' " +
                " from SanPham inner join PhanLoai on SanPham.MaLoai = PhanLoai.MaLoai";
            return DataProvider.Instance.ExecuteQuery(query);
        }

        public DataTable TimKiemSanPham(string tenSanPham)
        {
            string query = "select AnhSanPham as 'Ảnh' ," +
                " MaSanPham as 'Mã sản phẩm' ," +
                " TenSanPham as 'Tên sản phẩm' ," +
                " PhanLoai.TenLoai as 'Tên loại' ," +
                " SoLuongNhap as 'Số lượng nhập', " +
                " SoLuong as 'Tồn kho', " +
                " GiaNhap as 'Giá nhập' ," +
                " GiaBan as 'Giá bán' ," +
                " GiamGia as 'Giảm giá' " +
                " from SanPham inner join PhanLoai on SanPham.MaLoai = PhanLoai.MaLoai " +
                " where TenSanPham like @tenSanPham ";
            object[] parameter = { "%" + tenSanPham + "%" };
            return DataProvider.Instance.ExecuteQuery(query, parameter);
        }

        public bool ThemSanPham(SanPhamDTO sanPham)
        {
            string query = "insert into SanPham values ( @AnhSanPham , @MaSanPham ," +
               " @TenSanPham , @MaLoai , @TonKho , @GiaBan , @GiaNhap , @SoLuongNhap , @GiamGia )";
            object[] parameters = { sanPham.Anh, sanPham.MaSanPham, sanPham.TenSanPham,
                sanPham.MaLoai, sanPham.TonKho, sanPham.GiaBan, sanPham.GiaNhap ,sanPham.SoLuongNhap, sanPham.GiamGia};
            bool result = false;
            if (DataProvider.Instance.ExecuteNonQuery(query, parameters) > 0)
            {
                result = true;
            }
            return result;
        }

        public bool SuaSanPham(SanPhamDTO sanPham)
        {
            string query = "update SanPham set AnhSanPham = @AnhSanPham , " +
                "TenSanPham = @TenSanPham , MaLoai = @MaLoai , " +
               "SoLuong = @TonKho , GiaBan = @GiaBan , GiamGia = @GiamGia , GiaNhap = @GiaNhap , SoLuongNhap = @SoLuongNhap" +
               " where MaSanPham = @MaSanPham ";
            object[] parameters = { sanPham.Anh, sanPham.TenSanPham,
                sanPham.MaLoai, sanPham.TonKho, sanPham.GiaBan , sanPham.GiamGia, sanPham.GiaNhap, sanPham.SoLuongNhap , sanPham.MaSanPham };
            bool result = false;
            if (DataProvider.Instance.ExecuteNonQuery(query, parameters) > 0)
            {
                result = true;
            }
            return result;
        }

        public bool NhapHang(int TonKho, int SoLuongNhap, string MaSP)
        {
            string query = "update SanPham set SoLuong = @TonKho , SoLuongNhap = @SoLuongNhap  " +
                            " where MaSanPham = @MaSanPham ";
            object[] parameters = { TonKho, SoLuongNhap, MaSP };
            bool result = false;
            if (DataProvider.Instance.ExecuteNonQuery(query, parameters) > 0)
            {
                result = true;
            }
            return result;
        }

        public bool XoaSanPham(string MaSanPham)
        {
            string query = "delete SanPham where MaSanPham = @MaSanPham";
            object[] parameter = { MaSanPham };
            bool result = false;
            if (DataProvider.Instance.ExecuteNonQuery(query, parameter) > 0)
            {
                result = true;
            }
            return result;
        }

        public int idGenerate()
        {
            string query = "select * from SanPham";
            int maxRow = DataProvider.Instance.ExecuteQuery(query).Rows.Count + 1;
            return maxRow;
        }
    }
}
