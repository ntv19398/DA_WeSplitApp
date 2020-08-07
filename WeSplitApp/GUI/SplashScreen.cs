using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WeSplitApp.Sources;

namespace WeSplitApp.GUI
{
    public partial class SplashScreen : Form
    {
        List<Splash> lstSplash = new List<Splash>();
        private bool check = true;

        public SplashScreen()
        {
            InitializeComponent();
            timer1.Enabled = true;
            ReLoad();
        }
        private void ReLoad()
        {
            lstSplash = DataProcess.getSplash();
            Random r = new Random();
            int random = r.Next(0, 5);
            Image image = Image.FromFile(lstSplash[random].urlImage);
            Image img = resizeImage(image, 115, 120);
            panel1.BackgroundImage = img;
            lblthongtin.Text = lstSplash[random].thongTin;
        }
        public Image resizeImage(Image img, int width, int height)
        {
            Bitmap b = new Bitmap(width, height);
            Graphics g = Graphics.FromImage((Image)b);

            g.DrawImage(img, 0, 0, width, height);
            g.Dispose();

            return (Image)b;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            check = !check;
        }
        int second = 3;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if(second <= 0)
            {
                if(check == false)
                {
                    FileStream fs = new FileStream("Off.txt", FileMode.Create);
                }
                timer1.Enabled = false;
                this.Close();
            }
            
            second--;
        }
    }
}
