using System;

namespace Monopoly
{
    partial class EstiInInchisoare
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
        private void InitializeComponent(Jucator jucator)
        {
            this.SuspendLayout();
            // 
            // EstiInInchisoare
            // 
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Name = "EstiInInchisoare";
            this.ResumeLayout(false);

        }

        private void platesc_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.Button platesc;
        private System.Windows.Forms.Button dauCuZarul;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label numarIncercari;
    }
}