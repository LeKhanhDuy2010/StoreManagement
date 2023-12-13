using StoreManagement.DAO;
using StoreManagement.DTO;
using System.Windows.Forms;

namespace StoreManagement.BUS
{
    class HoaDonBUS
    {
        private static HoaDonBUS instance;
        public static HoaDonBUS Instance
        {
            get
            {
                if (instance == null)
                    instance = new HoaDonBUS();
                return instance;
            }
        }
        public HoaDonBUS() { }

        public bool LuuHoaDon(HoaDonDTO hoaDon)
        {
            return HoaDonDAO.Instance.LuuHoaDon(hoaDon);
        }

        public void TimKiemHD(DataGridView Dgv, string maHoaDon)
        {
            Dgv.DataSource = HoaDonDAO.Instance.TimKiemHD(maHoaDon);
        }
    }
}
