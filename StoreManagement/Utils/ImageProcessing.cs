using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace StoreManagement.Utils
{
    class ImageProcessing
    {
        private static ImageProcessing instance;

        public static ImageProcessing Instance
        {
            get
            {
                if (instance == null)
                    instance = new ImageProcessing();
                return instance;
            }
            //set { instance = value; }
        }

        //Chuyen doi hinh anh sang 1 mang byte
        public byte[] ImageToArray(PictureBox picture)
        {
            MemoryStream memory = new MemoryStream();
            if (picture.Image != null)
            {
                picture.Image.Save(memory, picture.Image.RawFormat);

            }
            return memory.ToArray();
        }

        public void ChooseImage(PictureBox picture)
        {
            OpenFileDialog openFile = new OpenFileDialog
            {
                Title = "Chon anh",
                Filter = "Image Files (*.gif; *.jpg; *.jpeg; *.bmp; *.wmf; *.png)|*.gif; *.jpg; *.jpeg; *.bmp; *.wmf; *.png"
            };
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                picture.ImageLocation = openFile.FileName;
            }
        }

        public void DgvToPbx(DataGridView data, PictureBox picture)
        {
            MemoryStream memory = new MemoryStream((byte[])data.SelectedRows[0].Cells[0].Value);
            picture.Image = Image.FromStream(memory);
        }
    }
}
