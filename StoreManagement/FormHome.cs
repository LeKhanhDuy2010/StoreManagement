using StoreManagement.BUS;
using StoreManagement.Utils;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace StoreManagement
{
    public partial class FormHome : Form
    {
        bool sidebarExpand = false;

        public FormHome()
        {
            InitializeComponent();
        }

        private void FormHome_Load(object sender, EventArgs e)
        {
            Console.WriteLine(NhanVienBUS.currentNhanVien.MaNhanVien);
            if (NhanVienBUS.currentNhanVien != null)
            {
                btnTenNV.Text = "Chào, " + NhanVienBUS.currentNhanVien.TenNhanVien.ToString();
            }
            else
            {
                btnTenNV.Text = "Chào, N/A";
            }
            if(NhanVienBUS.currentNhanVien?.VaiTro == "Nhân viên")
            {
                btnThongKe.Visible = false;
                btnThongKe.Enabled = false;
                btnSanPham.Visible = false;
                btnSanPham.Enabled = false;
                btnPhanloai.Visible = false;
                btnPhanloai.Enabled = false;
                btnNhanVien.Visible = false;
                btnNhanVien.Enabled = false;
                
            }
        }

        private void btnSanPham_Click(object sender, EventArgs e)
        {
            LoadingChildForm.Instance.OpenChildForm(new FormDSSanPham(), pnlForm);
            lblTittle.Text = "Danh Sách Sản Phẩm";
        }

        private void btnKhachHang_Click(object sender, EventArgs e)
        {
            LoadingChildForm.Instance.OpenChildForm(new FormDSKhachHang(), pnlForm);
            lblTittle.Text = "Danh Sách Khách Hàng";
        }

        private void btnNCC_Click(object sender, EventArgs e)
        {
            LoadingChildForm.Instance.OpenChildForm(new FormDSPhanLoai(), pnlForm);
            lblTittle.Text = "Danh Sách Phân Loại";
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            LoadingChildForm.Instance.OpenChildForm(new FormTTHD(), pnlForm);
            lblTittle.Text = "Thanh Toán Hóa Đơn";
        }

        private void btnDSHoaDon_Click(object sender, EventArgs e)
        {
            LoadingChildForm.Instance.OpenChildForm(new FormDSHoaDon(), pnlForm);
            lblTittle.Text = "Danh Sách Hóa Đơn";
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            LoadingChildForm.Instance.OpenChildForm(new FormThongKe(), pnlForm);
            lblTittle.Text = "Thống Kê";
        }

        private void btnTenNV_Click(object sender, EventArgs e)
        {
            timerSildeAnimation.Start();
        }

        private void timerSildeAnimation_Tick(object sender, EventArgs e)
        {
            if (sidebarExpand)
            {
                panelTaiKhoan.Height -= 10;
                if (panelTaiKhoan.Height == panelTaiKhoan.MinimumSize.Height)
                {
                    sidebarExpand = false;
                    timerSildeAnimation.Stop();
                }
            }
            else
            {
                panelTaiKhoan.Height += 10;
                if (panelTaiKhoan.Height == panelTaiKhoan.MaximumSize.Height)
                {
                    sidebarExpand = true;
                    timerSildeAnimation.Stop();
                }
            }
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(this,
                        "Are you sure you want to logout?",
                        "Closing Form",
                        MessageBoxButtons.OKCancel,
                        MessageBoxIcon.Question) == DialogResult.OK)
            {
                NhanVienBUS.currentNhanVien = null;
                Form parent = Parent.Parent as Form;
                parent.Size = new Size(800, 400);
                parent.Location = new Point(
                    (Screen.PrimaryScreen.Bounds.Size.Width / 2) - (parent.Size.Width / 2),
                    (Screen.PrimaryScreen.Bounds.Size.Height / 2) - (parent.Size.Height / 2)
                );
                LoadingChildForm.Instance.OpenChildForm(new FormLogin(), Parent as Panel);
            }
        }

        private void btnThongTin_Click(object sender, EventArgs e)
        {

                LoadingChildForm.Instance.OpenChildForm(new FormThongTinTK(), pnlForm);
        }

        private void btnNhanVien_Click(object sender, EventArgs e)
        {
            LoadingChildForm.Instance.OpenChildForm(new FormDSNhanVien(), pnlForm);
            lblTittle.Text = "Thông tin nhân viên";
        }
    }
}