using StoreManagement.DAO;
using StoreManagement.DTO;
using StoreManagement.Utils;
using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace StoreManagement.BUS
{
    class NhanVienBUS
    {
        public static CurrentNhanVienDTO currentNhanVien;


        private static NhanVienBUS instance;

        public static NhanVienBUS Instance
        {
            get
            {
                if (instance == null)
                    instance = new NhanVienBUS();
                return instance;
            }
        }

        public NhanVienBUS() { }


        public void SetCurrentNhanVien(string TaiKhoan)
        {
            
            DataTable data = TaiKhoanDAO.Instance.GetCurrentNhanVien(TaiKhoan);
            if (data.Rows.Count > 0)
            {
                DataRow row = data.Rows[0];
                string MaNhanVien = row[0] as string;
                string TenNhanVien = row[1] != null ? row[1] as string : "";
                string VaiTro = row[2] as string;

                currentNhanVien = new CurrentNhanVienDTO(MaNhanVien, TenNhanVien, VaiTro);
            }
        }

        public void GetCurrentNhanVien(PictureBox pbxAvatar, TextBox tbxMaNV, TextBox tbxTenTK, TextBox tbxTenNV, TextBox tbxSDT)
        {
            DataTable data = NhanVienDAO.Instance.GetNhanVienById(currentNhanVien.MaNhanVien);
            if (data.Rows.Count > 0)
            {
                DataRow row = data.Rows[0];
                Console.WriteLine($"avt: {row[0] as string}");
                if (!row.IsNull("AnhNV"))
                {
                    byte[] img = (byte[])row["AnhNV"];
                    MemoryStream stmBLOBData = new MemoryStream(img);
                    pbxAvatar.Image = Image.FromStream(stmBLOBData);
                }
                tbxMaNV.Text = row[1] as string;
                tbxTenTK.Text = row[2] as string;
                tbxTenNV.Text = row[3] as string;
                tbxSDT.Text = row[4] as string;
            }
        }

        public void SuaCurrentNhanVien(string maNV, string tenNV, string sdt)
        {
            NhanVienDAO.Instance.SuaNhanVien(maNV, tenNV, sdt);
        }

        public bool ThemNhanVien(NhanVienDTO NV)
        {
            return NhanVienDAO.Instance.ThemNhanVien(NV);
        }
        public bool XoaNhanVien(string maNhanVien)
        {
            return NhanVienDAO.Instance.XoaNhanVien(maNhanVien);
        }
        public void TimKiemNhanVien(DataGridView dgv, string maNhanVien)
        {
           dgv.DataSource = NhanVienDAO.Instance.GetNhanVienById(maNhanVien);
        }

        public string idGenerate(string prefix)
        {
            int maxRow = NhanVienDAO.Instance.idGenerate();
            string id = prefix + maxRow;
            return id;
        }
    }
}
