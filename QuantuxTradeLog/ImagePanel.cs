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

        public string Comments
        {
            get { return richTextBoxComments.Text; }
            set { richTextBoxComments.Text = value; }
        }

        public Image Image
        {
            get
            {
                return lblImageContainer.Image;
            }
            set
            {
                lblImageContainer.Image = value;
            }
        }


    }
}
