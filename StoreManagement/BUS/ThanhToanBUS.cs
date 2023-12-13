using StoreManagement.DAO;
using StoreManagement.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StoreManagement.BUS
{
    class ThanhToanBUS
    {
        private static ThanhToanBUS instance;

        public static ThanhToanBUS Instance
        {
            get
            {
                if (instance == null)
                    instance = new ThanhToanBUS();
                return instance;
            }
        }
        public ThanhToanBUS() { }

        public void TimKiemSanPham(DataGridView Dgv, string tenSanPham)
        {
            Dgv.DataSource = ThanhToanDAO.Instance.TimKiemSanPham(tenSanPham);
        }

        public bool LuuCTHD(ThanhToanDTO thanhToan)
        {
            return ThanhToanDAO.Instance.LuuCTHD(thanhToan);
        }

        public string idGenerate(string prefix)
        {
            int maxRow = ThanhToanDAO.Instance.IdGenerate();

            string id = prefix + maxRow;
            return id;
        }

        public int checkSoLuong(int soLuong, int TongSLSanPham)
        {
            int result = TongSLSanPham - soLuong;
            if (result < 0)
            {
                MessageBox.Show("Số lượng nhập vào không được vượt quá số lượng sản phẩm hiện tại \n"
                    + "Số lượng sản phẩm hiện tại: " + TongSLSanPham);
                return result;
            }
            return result;
        }

        public bool UpdateSoLuong(int soLuong, string maSanPham)
        {
            return ThanhToanDAO.Instance.UpdateSoLuong(soLuong, maSanPham);
        }
    }
}
