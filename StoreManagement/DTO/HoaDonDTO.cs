using System;

namespace StoreManagement.DTO
{
    class HoaDonDTO
    {
        private string maHoaDon;

        public string MaHoaDon
        {
            get { return maHoaDon; }
            set { maHoaDon = value; }
        }

        private string maNhanVien;
        public string MaNhanVien
        {
            get { return maNhanVien; }
            set { maNhanVien = value; }
        }

        private DateTime ngayBan;

        public DateTime NgayBan
        {
            get { return ngayBan; }
            set { ngayBan = value; }
        }

        private string maKH;

        public string MaKH
        {
            get { return maKH; }
            set { maKH = value; }
        }

        private float tongTien;

        public float TongTien
        {
            get { return tongTien; }
            set { tongTien = value; }
        }


        public HoaDonDTO(string maHoaDon, string maNhanVien, DateTime ngayBan, string maKH, float tongTien)
        {
            this.maHoaDon = maHoaDon;
            this.maNhanVien = maNhanVien;
            this.ngayBan = ngayBan;
            this.maKH = maKH;
            this.tongTien = tongTien;
        }
    }
}
