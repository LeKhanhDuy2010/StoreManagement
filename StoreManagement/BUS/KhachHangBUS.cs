using StoreManagement.DAO;
using StoreManagement.DTO;
using System.Windows.Forms;

namespace StoreManagement.BUS
{
    class KhachHangBUS
    {
        private static KhachHangBUS instance;
        public static KhachHangBUS Instance
        {
            get
            {
                if (instance == null)
                    instance = new KhachHangBUS();
                return instance;
            }
        }
        public KhachHangBUS() { }

        public void DSNCC()
        {
            KhachHangDAO.Instance.DSKhachHang();
        }

        public void TimKiemKH(DataGridView Dgv, string TenKH)
        {
            Dgv.DataSource = KhachHangDAO.Instance.TimKiemKH(TenKH);
        }

        public bool ThemKH(KhachHangDTO KH)
        {
            return KhachHangDAO.Instance.ThemKH(KH);
        }

        public bool SuaKH(KhachHangDTO KH)
        {
            return KhachHangDAO.Instance.SuaKH(KH);
        }
        public bool XoaKH(string id)
        {
            return KhachHangDAO.Instance.XoaKH(id);
        }

        public string idGenerate(string prefix)
        {
            int maxRow = KhachHangDAO.Instance.IdGenerate();

            string id = prefix + maxRow;
            return id;
        }

        public bool ExistInHoaDon(string id)
        {
            return KhachHangDAO.Instance.ExistInHoaDon(id);
        }
    }
}
