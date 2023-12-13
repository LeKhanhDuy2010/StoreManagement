using StoreManagement.Utils;
using System;
using System.Threading;
using System.Windows.Forms;

namespace StoreManagement
{
    public partial class FormApplication : Form
    {

        public FormApplication()
        {
            InitializeComponent();
        }

        private void FormApplication_Load(object sender, EventArgs e)
        {

            Thread.Sleep(10000);
            LoadingChildForm.Instance.OpenChildForm(new FormLogin(), panelMain);
        }

        private void FormApplication_FormClosing(object sender, FormClosingEventArgs e)
        {
            Control[] home = panelMain.Controls.Find("FormHome", false);
            if (home.Length > 0)
                if (MessageBox.Show(this,
                     "Are you sure you want to quit?",
                     "Closing Form",
                     MessageBoxButtons.OKCancel,
                     MessageBoxIcon.Question) == DialogResult.Cancel)
                {
                    // cancel the form closing if necessary
                    e.Cancel = true;
                }
        }

    }
}
