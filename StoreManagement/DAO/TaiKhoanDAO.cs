using StoreManagement.DTO;
using StoreManagement.Utils;
using System;
using System.Data;

namespace StoreManagement.DAO
{
    class TaiKhoanDAO
    {
        private static TaiKhoanDAO instance;

        public static TaiKhoanDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new TaiKhoanDAO();
                return instance;
            }
        }
        public TaiKhoanDAO() { }

        public bool LoginMethod(string TaiKhoan, string MatKhau)
        {
            string query = "select count(*) from TaiKhoan where TaiKhoan = @TaiKhoan and MatKhau = @MatKhau";
            object[] parameters = { TaiKhoan, MatKhau };
            return DataProvider.Instance.ExecuteScalar(query, parameters);
        }

        public DataTable GetCurrentNhanVien(string TaiKhoan)
        {
            string query =  "select nv.MaNhanVien, nv.TenNV, tk.VaiTro"
                            + " from NhanVien as nv"
                            + " inner join TaiKhoan as tk"
                            + " on nv.MaNhanVien = tk.MaNhanVien"
                            + " where tk.TaiKhoan = @TaiKhoan";
            object[] parameters = { TaiKhoan };
            return DataProvider.Instance.ExecuteQuery(query, parameters);
        }

        internal int DoiMK(string maNV, string mkCu, string mkMoi)
        {
            string query = "update TaiKhoan set MatKhau = @mkMoi " +
                " where MaNhanVien = @maNV and MatKhau = @mkCu ";
            object[] parameter = { mkMoi, maNV, mkCu };
            int result = DataProvider.Instance.ExecuteNonQuery(query, parameter);
            return result;
        }

        public DataTable GetDSTaiKhoan()
        {
            string query = "select TaiKhoan as 'Tên tài khoản',"
                                + " MaNhanVien as 'Mã nhân viên',"
                                + " MatKhau as 'Mật khẩu' ,"
                                + " VaiTro as 'Vai trò',"
                        + " from TaiKhoan";
            return DataProvider.Instance.ExecuteQuery(query);
        }

        internal int TaoTk(string tenTK, string maNV, string matkhau, string vaitro)
        {
            string query = "insert into TaiKhoan(TaiKhoan, MaNhanVien, MatKhau, VaiTro)"
                            + " values( @tenTK , @maNV , @matkhau , @vaitro )";
            object[] parameter = { tenTK, maNV, matkhau, vaitro };
            int result = DataProvider.Instance.ExecuteNonQuery(query, parameter);
            return result;
        }

        internal int XoaTK(string tenTK)
        {
            string query = "delete from TaiKhoan where TaiKhoan = @tenTK";
            object[] parameter = { tenTK };
            int result = DataProvider.Instance.ExecuteNonQuery(query, parameter);
            return result;
        }

        public bool ThemTaiKhoan(TaiKhoanDTO acc)
        {
            string query = "insert into TaiKhoan values ( @taiKhoan , @maNhanVien , @matKhau , @vaiTro )";
            object[] parameters = { acc.TaiKhoan, acc.MaNhanVien, acc.MatKhau, acc.VaiTro };
            bool result = false;
            if (DataProvider.Instance.ExecuteNonQuery(query, parameters) > 0)
            {
                result = true;
            }
            return result;
        }
        public bool XoaTaiKhoan(string id)
        {
            string query = "Delete TaiKhoan where MaNhanVien = @MaNhanVien";
            object[] parameter = { id };
            bool result = false;
            if (DataProvider.Instance.ExecuteNonQuery(query, parameter) > 0)
            {
                result = true;
            }
            return result;
        }
    }
}
