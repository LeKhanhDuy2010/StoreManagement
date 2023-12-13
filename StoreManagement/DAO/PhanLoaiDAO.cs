using StoreManagement.DTO;
using StoreManagement.Utils;
using System.Data;

namespace StoreManagement.DAO
{
    class PhanLoaiDAO
    {
        private static PhanLoaiDAO instance;

        public static PhanLoaiDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new PhanLoaiDAO();
                return instance;
            }
        }
        public PhanLoaiDAO() { }
        public DataTable DSPhanLoai()
        {
            string query = "select MaLoai as 'Mã loại' , TenLoai as 'Tên loại' from PhanLoai";
            return DataProvider.Instance.ExecuteQuery(query);
        }

        public DataTable TimKiemLoai(string TenLoai)
        {
            string query = "select MaLoai as 'Mã loại' , TenLoai as 'Tên loại' from PhanLoai where TenLoai like @TenLoai";
            object[] parameter = { "%" + TenLoai + "%" };
            return DataProvider.Instance.ExecuteQuery(query, parameter);
        }

        public bool ThemLoai(PhanLoaiDTO phanLoai)
        {
            string query = "insert into PhanLoai values ( @MaLoai , @TenLoai )";
            object[] parameters = { phanLoai.MaLoai, phanLoai.TenLoai };
            bool result = false;
            if (DataProvider.Instance.ExecuteNonQuery(query, parameters) > 0)
            {
                result = true;
            }
            return result;
        }

        public bool SuaLoai(PhanLoaiDTO phanLoai)
        {
            string query = "update PhanLoai set TenLoai = @TenLoai where MaLoai = @MaLoai";
            object[] parameters = { phanLoai.TenLoai, phanLoai.MaLoai };
            bool result = false;
            if (DataProvider.Instance.ExecuteNonQuery(query, parameters) > 0)
            {
                result = true;
            }
            return result;
        }

        public bool XoaLoai(string id)
        {
            string query = "Delete PhanLoai where MaLoai = @MaLoai";
            object[] parameter = { id };
            bool result = false;
            if (DataProvider.Instance.ExecuteNonQuery(query, parameter) > 0)
            {
                result = true;
            }
            return result;
        }

        public bool CheckExistence(string id)
        {
            string query = "Select PhanLoai.MaLoai from PhanLoai, SanPham " +
                "where PhanLoai.MaLoai = @MaLoai and SanPham.MaLoai = @MaLoai";
            object[] parameter = { id };
            bool result = false;
            if (DataProvider.Instance.ExecuteScalar(query, parameter) == true)
            {
                result = true;
            }
            return result;
        }

        public int idGenerate()
        {
            string query = "select * from PhanLoai";
            int maxRow = DataProvider.Instance.ExecuteQuery(query).Rows.Count + 1;
            return maxRow;
        }
    }
}
