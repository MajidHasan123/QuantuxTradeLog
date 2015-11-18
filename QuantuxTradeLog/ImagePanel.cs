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

        //rich box comments
        private string _comments;
        public string Comments
        {
            get { return _comments; }
            set { richTextBoxComments.Text = value; }
        }

        //rick text foreground
        private Color _commentsForeground = Color.Black;
        public Color CommentsForeground
        {
            get { return _commentsForeground; }
            set
            {
                _commentsForeground = value; 
                richTextBoxComments.ForeColor = value; 
            }
        }

        private Color _labelBackColor=Color.Gray;
        public Color LabelBackColor
        {
            get { return _labelBackColor; }
            set
            { 
                _labelBackColor = value; 
                lblImageContainer.BackColor = value; 
            }
        }

        private bool _labelVisibility;
        public bool LabelVisibility
        {
            get { return _labelVisibility; }
            set 
            { 
                _labelVisibility = value;
                lblImageContainer.Visible = value; 
            }
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
