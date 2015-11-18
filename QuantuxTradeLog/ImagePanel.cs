using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuantuxTradeLog
{
    public partial class ImagePanel : UserControl
    {
        public ImagePanel()
        {
            InitializeComponent();
        }

        private string _comments;
        public string Comments
        {
            get { return _comments; }
            set { richTextBoxComments.Text = value; }
        }

        private Image _image;
        public Image Image
        {
            get{ return _image; }
            set
            {
                _image = value;
                lblImageContainer.Image = value;
            }
        }

        private void pnlContainer_SizeChanged(object sender, EventArgs e)
        {
            
        }

        private void ImagePanel_SizeChanged(object sender, EventArgs e)
        {
            pnlContainer.Width = this.Width;
            pnlContainer.Height = this.Height;
        }
    }
}
