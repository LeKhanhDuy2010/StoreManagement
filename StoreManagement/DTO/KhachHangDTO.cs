namespace StoreManagement.DTO
{
    class KhachHangDTO
    {
        private string maKH;
        public string MaKH
        {
            get { return maKH; }
            set { maKH = value; }
        }

        private string tenKH;
        public string TenKH
        {
            get { return tenKH; }
            set { tenKH = value; }
        }

        private string sdt;
        public string Sdt
        {
            get { return sdt; }
            set { sdt = value; }
        }

        private string ghiChu;
        public string GhiChu
        {
            get { return ghiChu; }
            set { ghiChu = value; }
        }

        public KhachHangDTO(string maKH, string tenKH, string sdt, string ghiChu)
        {
            this.maKH = maKH;
            this.tenKH = tenKH;
            this.sdt = sdt;
            this.ghiChu = ghiChu;
        }
    }
}
