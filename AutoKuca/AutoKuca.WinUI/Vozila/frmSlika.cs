using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoKuca.WinUI.Vozila
{
    public partial class frmSlika : Form
    {

        private int? _id = null;
        private readonly APIService _slika = new APIService("Slike");
        public frmSlika(int? id = null)
        {
            InitializeComponent();
            _id = id;
        }

        private void FrmSlika_Load(object sender, EventArgs e)
        {
            LoadSLika();
        }

        private async void LoadSLika()
        {
            var result = await _slika.GetById<Model.Slike>(_id);
            MemoryStream slikaByte = new MemoryStream(result.Slika);
            Bitmap slika = new Bitmap(slikaByte);
            this.pbSlika.Image = slika;
            GetVelicinaSlike(pbSlika);



        }

        private Size GetVelicinaSlike(PictureBox pictureBox)
        {
            Size containerSize = pictureBox.ClientSize;
            float containerAspectRatio = (float)containerSize.Height / (float)containerSize.Width;
            Size originalImageSize = pictureBox.Image.Size;
            float imageAspectRatio = (float)originalImageSize.Height / (float)originalImageSize.Width;

            Size result = new Size();
            if (containerAspectRatio > imageAspectRatio)
            {
                result.Width = containerSize.Width;
                result.Height = (int)(imageAspectRatio * (float)containerSize.Width);
            }
            else
            {
                result.Height = containerSize.Height;
                result.Width = (int)((1.0f / imageAspectRatio) * (float)containerSize.Height);
            }
            return result;
        }
    }
}
