using System;
using System.Windows.Forms;

namespace StoreManagement
{
    public partial class FormNhapSoLuong : Form
    {
        int soLuong;
        public FormNhapSoLuong()
        {
            InitializeComponent();
        }
        public int GetAmount()
        {
            if (tbxSoLuong.Text != "")
            {
                if (!int.TryParse(tbxSoLuong.Text, out soLuong))
                {
                    MessageBox.Show("Mời nhập đúng kiểu dữ liệu");
                }
            }
            else soLuong = 0;
            return soLuong;
        }

        public void btnOK_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            tbxSoLuong.Text = "";
            Close();
        }
    }
}
