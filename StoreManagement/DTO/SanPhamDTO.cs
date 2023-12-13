namespace StoreManagement.DTO
{
    class SanPhamDTO
    {
        private byte[] anh;
        private string maSanPham;
        private string tenSanPham;
        private string maLoai;
        private int tonKho;
        private float giaBan;
        private float giamGia;
        private float giaNhap;
        private int soLuongNhap;


        public byte[] Anh
        {
            get { return anh; }
            set { anh = value; }
        }

        public string MaSanPham
        {
            get { return maSanPham; }
            set { maSanPham = value; }
        }

        public string TenSanPham
        {
            get { return tenSanPham; }
            set { tenSanPham = value; }
        }

        public string MaLoai
        {
            get { return maLoai; }
            set { maLoai = value; }
        }

        public int TonKho
        {
            get { return tonKho; }
            set { tonKho = value; }
        }

        public float GiaBan
        {
            get { return giaBan; }
            set { giaBan = value; }
        }


        public float GiamGia
        {
            get { return giamGia; }
            set { giamGia = value; }
        }

        public float GiaNhap
        {
            get { return giaNhap; }
            set { giaNhap = value; }
        }


        public int SoLuongNhap
        {
            get { return soLuongNhap; }
            set { soLuongNhap = value; }
        }


        public SanPhamDTO(byte[] anh, string maSanPham, string tenSanPham, string maLoai, int tonKho, float giaBan, float giamGia, float giaNhap, int soLuongNhap)
        {
            this.anh = anh;
            this.maSanPham = maSanPham;
            this.tenSanPham = tenSanPham;
            this.maLoai = maLoai;
            this.tonKho = tonKho;
            this.giaBan = giaBan;
            this.giamGia = giamGia;
            this.giaNhap = giaNhap;
            this.soLuongNhap = soLuongNhap;
        }
    }
}
