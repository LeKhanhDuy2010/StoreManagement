using StoreManagement.DAO;
using StoreManagement.DTO;
using System.Windows.Forms;

namespace StoreManagement.BUS
{
    class PhanLoaiBUS
    {
        private static PhanLoaiBUS instance;

        public static PhanLoaiBUS Instance
        {
            get
            {
                if (instance == null)
                    instance = new PhanLoaiBUS();
                return instance;
            }
        }

        public PhanLoaiBUS() { }

        public void DSPhanLoai()
        {
            PhanLoaiDAO.Instance.DSPhanLoai();
        }

        public void TimKiemLoai(DataGridView Dgv, string TenLoai)
        {
            Dgv.DataSource = PhanLoaiDAO.Instance.TimKiemLoai(TenLoai);
        }

        public bool ThemLoai(PhanLoaiDTO phanLoai)
        {
            return PhanLoaiDAO.Instance.ThemLoai(phanLoai);
        }

        public bool SuaLoai(PhanLoaiDTO phanLoai)
        {
            return PhanLoaiDAO.Instance.SuaLoai(phanLoai);
        }
        public bool XoaLoai(string id)
        {
            return PhanLoaiDAO.Instance.XoaLoai(id);
        }
        public bool CheckExistence(string id)
        {
            return PhanLoaiDAO.Instance.CheckExistence(id);
        }

        public string idGenerate(string prefix)
        {
            int maxRow = PhanLoaiDAO.Instance.idGenerate();

            string id = prefix + maxRow;
            return id;
        }
    }
}
