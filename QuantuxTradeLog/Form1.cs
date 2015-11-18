using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace QuantuxTradeLog
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            List<TradelogData> data = new List<TradelogData>();

            data.Add(new TradelogData() { RMult = "1", Ticks = "10", Points = "r", AveragePrice = "26", Trade="T"});
            data.Add(new TradelogData() { RMult = "2", Ticks = "35", Points = "d", AveragePrice = "26", Trade="E" });
            data.Add(new TradelogData() { RMult = "65", Ticks = "30", Points = "d", AveragePrice = "26", Trade = "E" });
            data.Add(new TradelogData() { RMult = "96", Ticks = "78", Points = "r", AveragePrice = "26", Trade = "T" });
            data.Add(new TradelogData() { RMult = "63", Ticks = "96", Points = "r", AveragePrice = "26", Trade = "E" });
            data.Add(new TradelogData() { RMult = "1", Ticks = "10", Points = "r", AveragePrice = "26", Trade = "E" });
            data.Add(new TradelogData() { RMult = "2", Ticks = "35", Points = "d", AveragePrice = "26", Trade = "T" });
            data.Add(new TradelogData() { RMult = "65", Ticks = "30", Points = "d", AveragePrice = "26", Trade = "T" });
            data.Add(new TradelogData() { RMult = "96", Ticks = "78", Points = "r", AveragePrice = "26", Trade = "E" });
            data.Add(new TradelogData() { RMult = "63", Ticks = "96", Points = "r", AveragePrice = "26", Trade = "T" });
            dataGridView1.DataSource = data;

            // bind to the updated source
            dataGridView1.DataSource = data;
            //setting width of cell
            dataGridView1.Columns[0].Width = 43;
            dataGridView1.Columns[1].Width = 37;
            dataGridView1.Columns[2].Width = 32;
            dataGridView1.Columns[3].Width = 52;
            dataGridView1.Columns[4].Width = 30;

         
        }


        private void lblCamera_Click(object sender, EventArgs e)
        {
            // Getting file
            string filePath = "";
            ofdImage.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";

            DialogResult dResult = ofdImage.ShowDialog();

            // Get path for selected file
            if (dResult == System.Windows.Forms.DialogResult.OK)
                filePath = ofdImage.FileName;

            // Converting file to bitmap format
            Bitmap btmp = new Bitmap(filePath);

            btmp = ResizeImage(btmp, 200, 100);

            Clipboard.SetDataObject(btmp);
            DataFormats.Format selectedFormat = DataFormats.GetFormat(DataFormats.Bitmap);

            // Validate format before pasting 

            if (rTxtboxMsg.CanPaste(selectedFormat))
            {
                rTxtboxMsg.Paste(selectedFormat);
                rTxtboxMsg.AppendText(Environment.NewLine);
                rTxtboxMsg.Focus();
            }
            else
                MessageBox.Show("Data format is not supported! ");
        }

        private Bitmap ResizeImage(Bitmap image, int width, int height)
        {
            var destRect = new Rectangle(0, 0, width, height);
            var destImage = new Bitmap(width, height);

            destImage.SetResolution(image.HorizontalResolution, image.VerticalResolution);

            using (var graphics = Graphics.FromImage(destImage))
            {
                graphics.CompositingMode = CompositingMode.SourceCopy;
                graphics.CompositingQuality = CompositingQuality.HighQuality;
                graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
                graphics.SmoothingMode = SmoothingMode.HighQuality;
                graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;

                using (var wrapMode = new ImageAttributes())
                {
                    wrapMode.SetWrapMode(WrapMode.TileFlipXY);
                    graphics.DrawImage(image, destRect, 0, 0, image.Width, image.Height, GraphicsUnit.Pixel, wrapMode);
                }
            }

            return destImage;
        }

        private void lblCameraIcon_Click(object sender, EventArgs e)
        {

            System.Drawing.Image currentImage = CaptureScreen();
            currentImage.Save(@"D:\ScreenShot1.png", System.Drawing.Imaging.ImageFormat.Png);
            currentImage.Dispose();
            currentImage = null;
 
        }

        private System.Drawing.Image CaptureScreen()
        {
            Size screenSize = Screen.PrimaryScreen.Bounds.Size;
            Bitmap target = new Bitmap(screenSize.Width, screenSize.Height);
            using (Graphics g = Graphics.FromImage(target))
            {
                g.CopyFromScreen(0, 0, 0, 0, screenSize);
            }
            return target;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Image i = Image.FromFile(@"D:\ScreenShot1.png");
            imagePanel1.Image = i;
        }

       
    }

    public class TradelogData 
    {
        public string RMult { get; set; }
        public string Ticks { get; set; }
        public string Points { get; set; }
        public string AveragePrice { get; set; }
        public string Trade { get; set; }

    }
}
