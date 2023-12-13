using StoreManagement.DTO;
using StoreManagement.Utils;
using System.Data;

namespace StoreManagement.DAO
{
    class HoaDonDAO
    {
        private static HoaDonDAO instance;

        public static HoaDonDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new HoaDonDAO();
                return instance;
            }
        }

        public HoaDonDAO() { }

        public DataTable DSHoaDon()
        {
            string query = "select MaHoaDon as 'Mã hóa đơn', NgayBan as 'Ngày bán'," +
                "TenKH as 'Tên khách hàng', TongTien as 'Tổng tiền' " +
                "from HoaDon inner join KhachHang on HoaDon.MaKH = KhachHang.MaKH";
            return DataProvider.Instance.ExecuteQuery(query);
        }

        public bool LuuHoaDon(HoaDonDTO hoaDon)
        {
            string query = "insert into HoaDon values ( @MaHoaDon , @NgayBan , @TongTien , @MaKH , @GhiChu )";
            object[] parameters = { hoaDon.MaHoaDon, hoaDon.MaNhanVien, hoaDon.NgayBan, hoaDon.MaKH, hoaDon.TongTien };
            bool result = false;
            if (DataProvider.Instance.ExecuteNonQuery(query, parameters) > 0)
            {
                result = true;
            }
            return result;
        }

        public DataTable TimKiemHD(string maHoaDon)
        {
            string query = "select MaHoaDon as 'Mã hóa đơn', NgayBan as 'Ngày bán'," +
                "TenKH as 'Tên khách hàng', TongTien as 'Tổng tiền' " +
                "from HoaDon inner join KhachHang on HoaDon.MaKH = KhachHang.MaKH where MaHoaDon like @MaHoaDon";
            object[] parameter = { "%" + maHoaDon };
            return DataProvider.Instance.ExecuteQuery(query, parameter);
        }
    }
}
