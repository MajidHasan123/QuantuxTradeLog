namespace QuantuxTradeLog
{
    partial class ImagePanel
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblImageContainer = new System.Windows.Forms.Label();
            this.lblBottom = new System.Windows.Forms.Label();
            this.richTextBoxComments = new System.Windows.Forms.RichTextBox();
            this.pnlContainer = new System.Windows.Forms.Panel();
            this.pnlContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblImageContainer
            // 
            this.lblImageContainer.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.lblImageContainer.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblImageContainer.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lblImageContainer.Location = new System.Drawing.Point(0, 0);
            this.lblImageContainer.Name = "lblImageContainer";
            this.lblImageContainer.Size = new System.Drawing.Size(153, 96);
            this.lblImageContainer.TabIndex = 0;
            // 
            // lblBottom
            // 
            this.lblBottom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(128)))));
            this.lblBottom.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblBottom.Location = new System.Drawing.Point(0, 172);
            this.lblBottom.Name = "lblBottom";
            this.lblBottom.Size = new System.Drawing.Size(150, 14);
            this.lblBottom.TabIndex = 4;
            // 
            // richTextBoxComments
            // 
            this.richTextBoxComments.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.richTextBoxComments.Location = new System.Drawing.Point(0, 96);
            this.richTextBoxComments.Margin = new System.Windows.Forms.Padding(3, 82, 3, 0);
            this.richTextBoxComments.Name = "richTextBoxComments";
            this.richTextBoxComments.Size = new System.Drawing.Size(153, 94);
            this.richTextBoxComments.TabIndex = 5;
            this.richTextBoxComments.Text = "";
            // 
            // pnlContainer
            // 
            this.pnlContainer.AutoSize = true;
            this.pnlContainer.Controls.Add(this.lblImageContainer);
            this.pnlContainer.Controls.Add(this.lblBottom);
            this.pnlContainer.Controls.Add(this.richTextBoxComments);
            this.pnlContainer.Location = new System.Drawing.Point(0, 0);
            this.pnlContainer.Name = "pnlContainer";
            this.pnlContainer.Size = new System.Drawing.Size(153, 190);
            this.pnlContainer.TabIndex = 6;
            this.pnlContainer.SizeChanged += new System.EventHandler(this.pnlContainer_SizeChanged);
            // 
            // ImagePanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlContainer);
            this.Name = "ImagePanel";
            this.Size = new System.Drawing.Size(151, 186);
            this.SizeChanged += new System.EventHandler(this.ImagePanel_SizeChanged);
            this.pnlContainer.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblImageContainer;
        private System.Windows.Forms.Label lblBottom;
        private System.Windows.Forms.RichTextBox richTextBoxComments;
        private System.Windows.Forms.Panel pnlContainer;
    }
}
