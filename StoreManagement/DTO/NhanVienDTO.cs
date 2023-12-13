namespace StoreManagement.DTO
{
    class NhanVienDTO
    {
        private byte[] anhNhanVien;
        private string maNhanVien;
        private string tenNhanVien;
        private string sdt;

        public byte[] AnhNhanVien
        {
            get { return anhNhanVien; }
            set { anhNhanVien = value; }
        }

        public string MaNhanVien
        {
            get { return maNhanVien; }
            set { maNhanVien = value; }
        }

        public string TenNhanVien
        {
            get { return tenNhanVien; }
            set { tenNhanVien = value; }
        }

        public string Sdt
        {
            get { return sdt; }
            set { sdt = value; }
        }

        public NhanVienDTO(byte[] anhNhanVien, string maNhanVien, string tenNhanVien, string sdt )
        {
            this.anhNhanVien = anhNhanVien;
            this.maNhanVien = maNhanVien;
            this.tenNhanVien = tenNhanVien;
            this.sdt = sdt;
        }
    }
}
