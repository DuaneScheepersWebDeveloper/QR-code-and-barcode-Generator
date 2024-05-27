using MaterialSkin.Controls;
using PdfSharp.Drawing;
using PdfSharp.Pdf;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Forms;

namespace CSPrintQRCodeBarcode
{
    public partial class PrintQRCodeBarcode : MaterialForm
    {
        private readonly MaterialSkin.MaterialSkinManager skinManager;

        public PrintQRCodeBarcode()
        {
            InitializeComponent();
            skinManager = MaterialSkin.MaterialSkinManager.Instance;
            skinManager.EnforceBackcolorOnAllComponents = true;

            skinManager.AddFormToManage(this);
            skinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;

            skinManager.ColorScheme = new MaterialSkin.ColorScheme(
                MaterialSkin.Primary.Blue500,
                MaterialSkin.Primary.Blue700,
                MaterialSkin.Primary.Blue200,
                MaterialSkin.Accent.Blue200,
                MaterialSkin.TextShade.WHITE);
        }

        private void themeSwitch_CheckedChanged(object sender, System.EventArgs e)
        {
            SkinManager.Theme = SkinManager.Theme == MaterialSkin.MaterialSkinManager.Themes.DARK ? MaterialSkin.MaterialSkinManager.Themes.LIGHT : MaterialSkin.MaterialSkinManager.Themes.DARK;
        }

        private void barcodeButton_Click(object sender, System.EventArgs e)
        {
            Zen.Barcode.Code128BarcodeDraw barcode = Zen.Barcode.BarcodeDrawFactory.Code128WithChecksum;
            qrBox.BackgroundImage = barcode.Draw(barcodeTextBox.Text, 100);
        }

        private void qrCodeButton_Click(object sender, System.EventArgs e)
        {
            Zen.Barcode.CodeQrBarcodeDraw qrcode = Zen.Barcode.BarcodeDrawFactory.CodeQr;
            qrBox.BackgroundImage = qrcode.Draw(qrcodeTextBox.Text, 100);
        }

        private void saveImageButton_Click(object sender, System.EventArgs e)
        {
            if (qrBox.BackgroundImage != null)
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "JPG Image|*.jpg|PNG Image|*.png";
                saveFileDialog.Title = "Save Image As";
                saveFileDialog.ShowDialog();

                if (saveFileDialog.FileName != "")
                {
                    string extension = Path.GetExtension(saveFileDialog.FileName);
                    ImageFormat format = null;
                    if (extension == ".jpg" || extension == ".jpeg")
                        format = ImageFormat.Jpeg;
                    else if (extension == ".png")
                        format = ImageFormat.Png;

                    if (format != null)
                        qrBox.BackgroundImage.Save(saveFileDialog.FileName, format);
                }
            }
            else
            {
                MessageBox.Show("No image to save.");
            }
        }

        private void printButton_Click(object sender, System.EventArgs e)
        {
            if (qrBox.BackgroundImage != null)
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "PDF Document|*.pdf";
                saveFileDialog.Title = "Save PDF As";
                saveFileDialog.ShowDialog();

                if (saveFileDialog.FileName != "")
                {
                    PdfDocument document = new PdfDocument();
                    PdfPage page = document.AddPage();
                    XGraphics gfx = XGraphics.FromPdfPage(page);

                    MemoryStream memoryStream = new MemoryStream();
                    qrBox.BackgroundImage.Save(memoryStream, ImageFormat.Png);
                    XImage xImage = XImage.FromStream(memoryStream);

                    double xPos = 0;
                    double yPos = 0;
                    double imageSize = 180; // size of the images

                    while (yPos + imageSize <= page.Height)
                    {
                        while (xPos + imageSize <= page.Width)
                        {
                            gfx.DrawImage(xImage, xPos, yPos, imageSize, imageSize);
                            xPos += imageSize;
                        }
                        xPos = 0;
                        yPos += imageSize;
                    }

                    document.Save(saveFileDialog.FileName);
                }
            }
            else
            {
                MessageBox.Show("No image to save.");
            }
        }
    }
}
