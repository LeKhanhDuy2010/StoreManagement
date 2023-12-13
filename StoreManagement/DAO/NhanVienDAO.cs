using StoreManagement.DTO;
using StoreManagement.Utils;
using System.Data;

namespace StoreManagement.DAO
{
    class NhanVienDAO
    {
        private static NhanVienDAO instance;

        public static NhanVienDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new NhanVienDAO();
                return instance;
            }
        }
        public NhanVienDAO() { }

        public DataTable GetNhanVienById(string MaNhanVien)
        {

            string query =  "select nv.AnhNV, nv.MaNhanVien, tk.TaiKhoan, nv.TenNV, nv.Sdt"
                            + " from NhanVien as nv"
                            + " inner join TaiKhoan as tk"
                            + " on nv.MaNhanVien = tk.MaNhanVien"
                            + " where nv.MaNhanVien = @MaNhanVien";
            object[] parameter = { MaNhanVien };
            return DataProvider.Instance.ExecuteQuery(query, parameter);
        }

        public int SuaNhanVien(string maNV, string tenNV, string sdt)
        {

            string query = "update NhanVien set tenNV = @tenNV ," +
                " sdt = @sdt where maNhanVien = @maNV";
            object[] parameter = { tenNV, sdt, maNV };
            return DataProvider.Instance.ExecuteNonQuery(query, parameter);
        }

      
        public DataTable DSNhanVien()
        {
            string query = "select AnhNV as 'Ảnh' , " +
                "NhanVien.MaNhanVien as 'Mã nhân viên' , TenNV as 'Tên nhân viên' , " +
                "Sdt as 'Số điện thoại',TaiKhoan as 'Tài khoản' , " +
                "MatKhau as 'Mật khẩu', VaiTro as 'Vai trò' from NhanVien " +
                "inner join TaiKhoan on NhanVien.MaNhanVien = TaiKhoan.MaNhanVien ";
            return DataProvider.Instance.ExecuteQuery(query);
        }

        
        public bool ThemNhanVien(NhanVienDTO NV)
        {
            string query = "insert into NhanVien values ( @Anh , @MaNhanVien , @tenNhanVien , @Sdt )";
            object[] parameters = { NV.AnhNhanVien, NV.MaNhanVien, NV.TenNhanVien, NV.Sdt };
            bool result = false;
            if (DataProvider.Instance.ExecuteNonQuery(query, parameters) > 0)
            {
                result = true;
            }
            return result;
        }
        public bool XoaNhanVien(string id)
        {
            string query = "Delete NhanVien where MaNhanVien = @MaNhanVien";
            object[] parameter = { id };
            bool result = false;
            if (DataProvider.Instance.ExecuteNonQuery(query, parameter) > 0)
            {
                result = true;
            }
            return result;
        }

        public int idGenerate()
        {
            string query = "select * from NhanVien";
            int maxRow = DataProvider.Instance.ExecuteQuery(query).Rows.Count + 1;
            return maxRow;
        }
    }
}
