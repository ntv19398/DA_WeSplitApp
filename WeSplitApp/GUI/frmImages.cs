using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WeSplitApp.Sources;

namespace WeSplitApp.GUI
{
    public partial class frmImages : Form
    {
        private List<Img> lstImg = new List<Img>();
        List<ChuyenDi> lstCD = new List<ChuyenDi>();
        private string _macd;
        public frmImages()
        {
            InitializeComponent();
        }

        public frmImages(string maCD)
        {
            InitializeComponent();
            _macd = maCD;
            lstImg = DataProcess.getListImage();
            lstCD = DataProcess.getListChuyenDi();
            Load();
        }

        private void Load()
        {
            List<Img> listImage = getListImg();
            string tenCD = getTenCD();
            lbTitle.Text = "Danh sách hình ảnh của chuyến đi " + tenCD;
            for(int i = 0; i < listImage.Count; i++)
            {
                PictureBox ptb = addPictureBox(listImage[i]._maImage, listImage[i]._urlImage);
                flpImages.Controls.Add(ptb);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
            frmDetail frm = new frmDetail(_macd);
            frm.Show();
        }
        private string getTenCD()
        {
            string ten = null;
            for (int i = 0; i < lstCD.Count; i++)
            {
                if (lstCD[i].maCD == _macd)
                {
                    ten = lstCD[i].tenCD;
                }
            }
            return ten;
        }
        private List<Img> getListImg()
        {
            List<Img> listImage = new List<Img>();
            for(int i = 0; i < lstImg.Count; i++)
            {
                if(lstImg[i]._maCD == _macd)
                {
                    listImage.Add(lstImg[i]);
                }
            }
            return listImage;
        }
        private PictureBox addPictureBox(string maImage, string url)
        {
            PictureBox ptb = new PictureBox();
            ptb.Name = "" + maImage;
            ptb.Width = 300;
            ptb.Height = 200;
            Image image = Image.FromFile(url);
            Image img = resizeImage(image, 300, 200);
            ptb.Image = img;
            // Give the button a flat appearance.
            return ptb;
        }
        public Image resizeImage(Image img, int width, int height)
        {
            Bitmap b = new Bitmap(width, height);
            Graphics g = Graphics.FromImage((Image)b);

            g.DrawImage(img, 0, 0, width, height);
            g.Dispose();

            return (Image)b;
        }
    }
}
