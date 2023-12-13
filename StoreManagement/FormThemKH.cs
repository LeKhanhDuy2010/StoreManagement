using StoreManagement.BUS;
using StoreManagement.DTO;
using System;
using System.Windows.Forms;

namespace StoreManagement
{
    public partial class FormThemKH : Form
    {
        KhachHangDTO KH;
        public FormThemKH()
        {
            InitializeComponent();
        }

        private void FormThemKH_Load(object sender, EventArgs e)
        {
            tbxMaKH.Text = KhachHangBUS.Instance.idGenerate("KH");
        }

        private void GetValue()
        {
            string maKhachHang = tbxMaKH.Text;
            string tenKhachHang = tbxTenKH.Text;
            string sdt = tbxSdt.Text;
            string ghiChu = tbxGhiChu.Text;

            KH = new KhachHangDTO(maKhachHang, tenKhachHang, sdt, ghiChu);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                GetValue();
                if (KhachHangBUS.Instance.ThemKH(KH) == true)
                {
                    MessageBox.Show("Thêm thành công");
                }
                else
                {
                    MessageBox.Show("Thêm không thành công");
                }
                this.Close();
            }
            catch (Exception ex)
            {
                //throw ex;
                MessageBox.Show("Lỗi thêm: " + ex);
            }
        }
    }
}
