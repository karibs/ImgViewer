
namespace ImgViewer
{
    partial class frmSelecte
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
            this.picSel = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picSel)).BeginInit();
            this.SuspendLayout();
            // 
            // picSel
            // 
            this.picSel.Location = new System.Drawing.Point(24, 12);
            this.picSel.Name = "picSel";
            this.picSel.Size = new System.Drawing.Size(100, 50);
            this.picSel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picSel.TabIndex = 0;
            this.picSel.TabStop = false;
            this.picSel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.picSel_MouseDown);
            // 
            // frmSelecte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.picSel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmSelecte";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmSelecte_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picSel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.PictureBox picSel;
    }
}