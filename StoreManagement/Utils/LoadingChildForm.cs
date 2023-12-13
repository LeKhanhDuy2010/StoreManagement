using System;
using System.Windows.Forms;

namespace StoreManagement.Utils
{
    class LoadingChildForm
    {
        private static LoadingChildForm instance;

        public static LoadingChildForm Instance
        {
            get
            {
                if (instance == null)
                    instance = new LoadingChildForm();
                return instance;
            }
        }

        public void OpenChildForm(object Form, Panel pnl)
        {
            if (pnl.Controls.Count > 0)
            {
                foreach (Control control in pnl.Controls)
                {
                    if (control is Form form)
                    {
                        form.Close();
                    }
                }
            }

            Form NewChildForm = Form as Form;
            NewChildForm.TopLevel = false;
            NewChildForm.FormBorderStyle = FormBorderStyle.None;
            NewChildForm.Dock = DockStyle.Fill;
            pnl.Controls.Add(NewChildForm);
            pnl.Tag = NewChildForm;
            NewChildForm.BringToFront();
            NewChildForm.Show();
        }
    }
}
