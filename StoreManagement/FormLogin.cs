using StoreManagement.BUS;
using StoreManagement.Utils;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace StoreManagement
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private const string defaultUsernameText = " Username";
        private const string defaultPasswordText = " Password";

        private void changeHomeForm(string taiKhoan)
        {
            Form parent = Parent.Parent as Form;
            parent.Size = new Size(1200, 600);
            parent.Location = new Point(
                (Screen.PrimaryScreen.Bounds.Size.Width / 2) - (parent.Size.Width / 2),
                (Screen.PrimaryScreen.Bounds.Size.Height / 2) - (parent.Size.Height / 2)
            );

            NhanVienBUS.Instance.SetCurrentNhanVien(taiKhoan);
            LoadingChildForm.Instance.OpenChildForm(new FormHome(), Parent as Panel);
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            hidebtn.Tag = "hide.ico";
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (testCbx.Checked)
            {
                changeHomeForm("test");
                return;
            }
            if (tbxTaiKhoan.Text == defaultUsernameText || tbxMatKhau.Text == defaultPasswordText)
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin đăng nhập", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (tbxTaiKhoan.Text.Trim() == "" || tbxMatKhau.Text.Trim() == "")
            {
                MessageBox.Show("Thông tin đăng nhập không thể bỏ trống", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (tbxTaiKhoan.Text[0] == ' ' || tbxMatKhau.Text[0] == ' ')
            {
                MessageBox.Show("Thông tin đăng nhập không thể bắt đầu bằng phím cách (space key)", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                if (TaiKhoanBUS.Instance.LoginMethod(tbxTaiKhoan.Text, tbxMatKhau.Text) == true)
                {
                    changeHomeForm(tbxTaiKhoan.Text);
                }
                else
                {
                    MessageBox.Show("Tài Khoản hoặc Mật Khẩu không đúng!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void hidebtn_Click(object sender, EventArgs e)
        {
            hidebtn.Image.Dispose();
            hidebtn.Tag = (string)hidebtn.Tag == "hide.ico" ? "show.ico" : "hide.ico";
            hidebtn.Image = (string)hidebtn.Tag == "hide.ico" ?  Properties.Resources.hide : Properties.Resources.show;
            tbxMatKhau.UseSystemPasswordChar = !tbxMatKhau.UseSystemPasswordChar;
        }
    }
}
