namespace Monopoly
{
    partial class AfisareCelula
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.imagineCelula = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.imagineCelula)).BeginInit();
            this.SuspendLayout();
            // 
            // imagineCelula
            // 
            this.imagineCelula.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.imagineCelula.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.imagineCelula.Location = new System.Drawing.Point(13, 13);
            this.imagineCelula.Name = "imagineCelula";
            this.imagineCelula.Size = new System.Drawing.Size(251, 331);
            this.imagineCelula.TabIndex = 0;
            this.imagineCelula.TabStop = false;
            // 
            // AfisareCelula
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(276, 356);
            this.Controls.Add(this.imagineCelula);
            this.Name = "AfisareCelula";
            this.Text = "AfisareCelula";
            ((System.ComponentModel.ISupportInitialize)(this.imagineCelula)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox imagineCelula;
    }
}