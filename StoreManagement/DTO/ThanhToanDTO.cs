using System.Runtime.InteropServices;

namespace StoreManagement.DTO
{
    class ThanhToanDTO
    {
        private string maHoaDon;
        public string MaHoaDon
        {
            get { return maHoaDon; }
            set { maHoaDon = value; }
        }

        private string maSanPham;
        public string MaSanPham
        {
            get { return maSanPham; }
            set { maSanPham = value; }
        }

        private int soLuong;
        public int SoLuong
        {
            get { return soLuong; }
            set { soLuong = value; }
        }

        private float donGia;
        public float DonGia
        {
            get { return donGia; }
            set { donGia = value; }
        }

        private int giamGia;
        public int GiamGia
        {
            get { return giamGia; }
            set { giamGia = value; }
        }

        private float thanhTien;
        public float ThanhTien
        {
            get { return thanhTien; }
            set { thanhTien = value; }
        }
        private float giamGiaSP;

        public float GiamGiaSP
        {
            get { return giamGiaSP; }
            set { giamGiaSP = value; }
        }

        public ThanhToanDTO(string maHoaDon, string maSanPham, int soLuong, float donGia, int giamGia, float giamGiaSP, float thanhTien)
        {
            this.maHoaDon = maHoaDon;
            this.maSanPham = maSanPham;
            this.soLuong = soLuong;
            this.donGia = donGia;
            this.giamGia = giamGia;
            this.giamGiaSP = giamGiaSP;
            this.thanhTien = thanhTien;
        }
    }
}
