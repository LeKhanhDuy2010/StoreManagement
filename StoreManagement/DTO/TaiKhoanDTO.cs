namespace StoreManagement.DTO
{
    class TaiKhoanDTO
    {
        private string taiKhoan;
        public string TaiKhoan
        {
            get { return taiKhoan; }
            set { taiKhoan = value; }
        }

        private string maNhanVien;
        public string MaNhanVien
        {
            get { return maNhanVien; }
            set { maNhanVien = value; }
        }

        private string matKhau;
        public string MatKhau
        {
            get { return matKhau; }
            set { matKhau = value; }
        }

        private string vaiTro;
        public string VaiTro
        {
            get { return vaiTro; }
            set { vaiTro = value; }
        }

        public TaiKhoanDTO(string taiKhoan, string maNhanVien, string matKhau, string vaiTro)
        {
            this.taiKhoan = taiKhoan;
            this.maNhanVien = maNhanVien;
            this.matKhau = matKhau;
            this.vaiTro = vaiTro;
        }
    }
}
