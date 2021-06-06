using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImgViewer
{
    public partial class frmSelecte : Form
    {
        public frmSelecte()
        {
            InitializeComponent();
        }

        private void frmSelecte_Load(object sender, EventArgs e)
        {
            picSel.SizeMode = PictureBoxSizeMode.StretchImage;
            picSel.Size = picSel.Image.Size;
        }

        private void picSel_MouseDown(object sender, MouseEventArgs e)
        {
            Size sizePic = new Size();
            Size sizeMe = new Size();

            sizePic = picSel.Size;
            sizeMe = this.Size;

            if(e.Button == MouseButtons.Left) //왼쪽 버튼을 누른 경우 확대
            {
                sizePic.Height += 15;
                sizePic.Width += 15;
                picSel.Size = sizePic;

                sizeMe.Height += 15;
                sizeMe.Width += 15;
                this.Size = sizeMe;
            }
            else if(e.Button == MouseButtons.Right)
            {
                sizePic.Height -= 15;
                sizePic.Width -= 15;
                picSel.Size = sizePic;

                sizeMe.Height -= 15;
                sizeMe.Width -= 15;
                this.Size = sizeMe;
            }
        }
    }
}
