using StoreManagement.DAO;
using StoreManagement.DTO;
using System;
using System.Windows.Forms;

namespace StoreManagement.BUS
{
    class TaiKhoanBUS
    {
        private static TaiKhoanBUS instance;
        public static TaiKhoanBUS Instance
        {
            get
            {
                if (instance == null)
                    instance = new TaiKhoanBUS();
                return instance;
            }
        }
        public TaiKhoanBUS() { }

        public bool LoginMethod(string username, string password)
        {
            return TaiKhoanDAO.Instance.LoginMethod(username, password);
        }

        internal string[] DoiMatKhau(string mkCu, string mkMoi, string xacNhanMK)
        {
            string[] arr = new string[2];
            arr[0] = "error";
            if (mkMoi.Equals(xacNhanMK))
            {
            string maNV = NhanVienBUS.currentNhanVien.MaNhanVien;
            int result = TaiKhoanDAO.Instance.DoiMK(maNV, mkCu, mkMoi);
                if (result <= 0) 
                {
                    arr[1] = "Mật khẩu hoặc tài khoản không đúng";
                    return arr; 
                }
                arr[0] = "success";
                arr[1] = "Đổi mật khẩu thành công";
                return arr;
            }
            else 
            {
                arr[1] = "Xác nhận mật khẩu không trùng với mật khẩu mới";
                return arr; 
            }
        }

        public bool ThemTaiKhoan(TaiKhoanDTO acc)
        {
            return TaiKhoanDAO.Instance.ThemTaiKhoan(acc);
        }
        public bool XoaTaiKhoan(string maNhanVien)
        {
            return TaiKhoanDAO.Instance.XoaTaiKhoan(maNhanVien);
        }

    }
}
