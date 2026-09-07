using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using QRCoder;

namespace AlumniDigitalIDCreator
{
    public partial class QRGenerator : Form
    {
        public QRGenerator()
        {
            InitializeComponent();
        }

        private void RenderQrCode()
        {
            string level = "L"; // comboBoxECC.SelectedItem.ToString();
            var eccLevel = (QRCodeGenerator.ECCLevel)(level == "L" ? 0 : level == "M" ? 1 : level == "Q" ? 2 : 3);
            var qrGenerator = new QRCodeGenerator();
            var qrCodeData = qrGenerator.CreateQrCode(textBoxQRCode.Text, eccLevel);
            var qrCode = new QRCode(qrCodeData);
            pictureBoxQRCode.BackgroundImage = qrCode.GetGraphic(20, GetPrimaryColor(), GetBackgroundColor(), GetIconBitmap(), 50); // (int)iconSize.Value);

            pictureBoxQRCode.Size = new System.Drawing.Size(pictureBoxQRCode.Width, pictureBoxQRCode.Height);
            //Set the SizeMode to center the image.
            pictureBoxQRCode.SizeMode = PictureBoxSizeMode.CenterImage;

            pictureBoxQRCode.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private Color GetPrimaryColor() => panelPreviewPrimaryColor.BackColor;

        private Color GetBackgroundColor() => panelPreviewBackgroundColor.BackColor;

        private Bitmap GetIconBitmap()
        {
            if (iconPath.Text.Length == 0)
            {
                return null;
            }
            try
            {
                return new Bitmap(iconPath.Text);
            }
            catch (Exception)
            {
                return null;
            }
        }

        private void panelPreviewPrimaryColor_Paint(object sender, PaintEventArgs e)
        {
        
        }

        private void btn_itemtype_Click(object sender, EventArgs e)
        {
            RenderQrCode();
        }
    }
}
