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
            this.SuspendLayout();
            // 
            // lblImageContainer
            // 
            this.lblImageContainer.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.lblImageContainer.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lblImageContainer.Location = new System.Drawing.Point(0, 0);
            this.lblImageContainer.Name = "lblImageContainer";
            this.lblImageContainer.Size = new System.Drawing.Size(200, 100);
            this.lblImageContainer.TabIndex = 0;
            // 
            // lblBottom
            // 
            this.lblBottom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(128)))));
            this.lblBottom.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblBottom.Location = new System.Drawing.Point(0, 206);
            this.lblBottom.Name = "lblBottom";
            this.lblBottom.Size = new System.Drawing.Size(200, 26);
            this.lblBottom.TabIndex = 4;
            this.lblBottom.Text = "Reply";
            // 
            // richTextBoxComments
            // 
            this.richTextBoxComments.Location = new System.Drawing.Point(0, 100);
            this.richTextBoxComments.Margin = new System.Windows.Forms.Padding(0);
            this.richTextBoxComments.Name = "richTextBoxComments";
            this.richTextBoxComments.Size = new System.Drawing.Size(200, 106);
            this.richTextBoxComments.TabIndex = 5;
            this.richTextBoxComments.Text = "";
            // 
            // ImagePanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.richTextBoxComments);
            this.Controls.Add(this.lblBottom);
            this.Controls.Add(this.lblImageContainer);
            this.Name = "ImagePanel";
            this.Size = new System.Drawing.Size(200, 232);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblImageContainer;
        private System.Windows.Forms.Label lblBottom;
        private System.Windows.Forms.RichTextBox richTextBoxComments;
    }
}
