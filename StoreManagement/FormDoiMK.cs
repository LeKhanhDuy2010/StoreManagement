using StoreManagement.BUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StoreManagement
{
    public partial class FormDoiMK : Form
    {
        public FormDoiMK()
        {
            InitializeComponent();
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            string[] message = TaiKhoanBUS.Instance.DoiMatKhau(tbxMatKhauCu.Text, tbxMatKhauMoi.Text, tbxXacNhanMK.Text);
            MessageBox.Show(message[1], message[0]);
            if (message[0] == "success")
                Close();
        }
    }
}
