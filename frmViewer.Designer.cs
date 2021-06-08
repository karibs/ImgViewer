
namespace ImgViewer
{
    partial class frmViewer
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.lstDir = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.imglstTmp = new System.Windows.Forms.ImageList(this.components);
            this.lblPath = new System.Windows.Forms.Label();
            this.picSelect = new System.Windows.Forms.PictureBox();
            this.tipPath = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSelect)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(800, 450);
            this.splitContainer1.SplitterDistance = 266;
            this.splitContainer1.TabIndex = 0;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.IsSplitterFixed = true;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.lstDir);
            this.splitContainer2.Panel1.Controls.Add(this.lblPath);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.picSelect);
            this.splitContainer2.Panel2.SizeChanged += new System.EventHandler(this.splitContainer2_Panel2_SizeChanged);
            this.splitContainer2.Size = new System.Drawing.Size(262, 446);
            this.splitContainer2.SplitterDistance = 277;
            this.splitContainer2.TabIndex = 0;
            // 
            // lstDir
            // 
            this.lstDir.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.lstDir.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstDir.HideSelection = false;
            this.lstDir.Location = new System.Drawing.Point(0, 15);
            this.lstDir.MultiSelect = false;
            this.lstDir.Name = "lstDir";
            this.lstDir.Size = new System.Drawing.Size(262, 262);
            this.lstDir.SmallImageList = this.imglstTmp;
            this.lstDir.TabIndex = 1;
            this.lstDir.UseCompatibleStateImageBehavior = false;
            this.lstDir.View = System.Windows.Forms.View.Details;
            this.lstDir.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lstDir_MouseDoubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "드라이브 및 폴더";
            this.columnHeader1.Width = 200;
            // 
            // imglstTmp
            // 
            this.imglstTmp.ColorDepth = System.Windows.Forms.ColorDepth.Depth24Bit;
            this.imglstTmp.ImageSize = new System.Drawing.Size(16, 16);
            this.imglstTmp.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // lblPath
            // 
            this.lblPath.AutoSize = true;
            this.lblPath.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblPath.Location = new System.Drawing.Point(0, 0);
            this.lblPath.Name = "lblPath";
            this.lblPath.Size = new System.Drawing.Size(45, 15);
            this.lblPath.TabIndex = 0;
            this.lblPath.Text = "label1";
            this.lblPath.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // picSelect
            // 
            this.picSelect.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.picSelect.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picSelect.Location = new System.Drawing.Point(46, 26);
            this.picSelect.Name = "picSelect";
            this.picSelect.Size = new System.Drawing.Size(153, 82);
            this.picSelect.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picSelect.TabIndex = 0;
            this.picSelect.TabStop = false;
            // 
            // frmViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitContainer1);
            this.Name = "frmViewer";
            this.Text = "이미지 뷰어";
            this.Load += new System.EventHandler(this.frmViewer_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picSelect)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.ListView lstDir;
        private System.Windows.Forms.Label lblPath;
        private System.Windows.Forms.PictureBox picSelect;
        private System.Windows.Forms.ImageList imglstTmp;
        private System.Windows.Forms.ToolTip tipPath;
        private System.Windows.Forms.ColumnHeader columnHeader1;
    }
}

