using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using WeSplitApp.Sources;

namespace WeSplitApp.GUI
{
    public partial class frmHomeScreen : Form
    {
        public int FirstIndex = 0;
        public int PageSize = 4;
        public int MaxPage = 0;
        public int FirstIndexDD = 0;
        public int PageSizeDD = 4;
        public int MaxPageDD = 0;
        List<ChuyenDi> lstCD = new List<ChuyenDi>();
        public frmHomeScreen()
        {
            InitializeComponent();
            string exeFile = (new System.Uri(Assembly.GetEntryAssembly().CodeBase)).AbsolutePath;
            string exeDir = Path.GetDirectoryName(exeFile);
            string fullPath = Path.Combine(exeDir, "Off.txt");
            if(!File.Exists(fullPath))
            {
                SplashScreen frm = new SplashScreen();
                frm.ShowDialog();
            }
            lstCD = DataProcess.getListChuyenDi();
            LoadButtonDSDangDi();
            LoadButtonDSDaDi();
        }
        private void LoadButtonDSDangDi()
        {
            MaxPage = FirstIndex * PageSize + PageSize;

            if (MaxPage >= lstCD.Count())
            {
                MaxPage = lstCD.Count();
            }
            flpDSDangDi.Controls.Clear();
            for (int i = 0; i < lstCD.Count; i++)
            {
                if(lstCD[i].tinhTrang == "Đang đi")
                {
                    Button btn = addButton(lstCD[i].maCD, lstCD[i].tenCD, lstCD[i].urlImage);
                    flpDSDangDi.Controls.Add(btn);
                    btn.Click += new System.EventHandler(this.button_Click);
                }
            }
        }
        private void LoadButtonDSDaDi()
        {
            MaxPageDD = FirstIndexDD * PageSizeDD + PageSizeDD;

            if (MaxPageDD >= lstCD.Count())
            {
                MaxPageDD = lstCD.Count();
            }
            flpDSDaDi.Controls.Clear();
            for (int i = 0; i < lstCD.Count; i++)
            {
                if (lstCD[i].tinhTrang == "Đã đi")
                {
                    Button btn = addButton(lstCD[i].maCD, lstCD[i].tenCD, lstCD[i].urlImage);
                    flpDSDangDi.Controls.Add(btn);
                    btn.Click += new System.EventHandler(this.button_Click);
                }
            }
        }

        private void button_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            frmDetail frm = new frmDetail(btn.Name);
            frm.Show();
        }

        private Button addButton(string id, string name, string url)
        {
            Button btn = new Button();
            btn.Name = "" + id;
            btn.Width = 200;
            btn.Height = 200;
            btn.Text = name;
            Image image = Image.FromFile(url);
            Image img = resizeImage(image, 185, 155);
            btn.Image = img;
            btn.ImageAlign = ContentAlignment.TopCenter;
            btn.TextAlign = ContentAlignment.BottomCenter;
            // Give the button a flat appearance.
            btn.FlatStyle = FlatStyle.Flat;
            return btn;
        }
        public Image resizeImage(Image img, int width, int height)
        {
            Bitmap b = new Bitmap(width, height);
            Graphics g = Graphics.FromImage((Image)b);

            g.DrawImage(img, 0, 0, width, height);
            g.Dispose();

            return (Image)b;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            frmSearch frm = new frmSearch(txtSearch.Text.ToString());
            frm.Show();
        }

        private void btnPrevDangDi_Click(object sender, EventArgs e)
        {
            FirstIndex--;
            if (FirstIndex <= 0)
            {
                FirstIndex = 0;
                btnPrevDangDi.Enabled = false;

            }
            btnNextDangDi.Enabled = true;
            LoadButtonDSDangDi();
        }
        private void btnNextDangDi_Click(object sender, EventArgs e)
        {
            FirstIndex++;
            MaxPage = FirstIndex * PageSize + PageSize;
            if (MaxPage >= lstCD.Count)
            {
                btnNextDangDi.Enabled = false;
                LoadButtonDSDangDi();
            }
            else
            {
                LoadButtonDSDangDi();
            }
            btnPrevDangDi.Enabled = true;

        }
        private void btnPrevDaDi_Click(object sender, EventArgs e)
        {
            FirstIndexDD--;
            if (FirstIndexDD <= 0)
            {
                FirstIndexDD = 0;
                btnPrevDaDi.Enabled = false;

            }
            btnNextDaDi.Enabled = true;
            LoadButtonDSDaDi();
        }

        private void btnNextDaDi_Click(object sender, EventArgs e)
        {
            FirstIndexDD++;
            MaxPageDD = FirstIndexDD * PageSizeDD + PageSizeDD;
            if (MaxPageDD >= lstCD.Count)
            {
                btnNextDaDi.Enabled = false;
                LoadButtonDSDaDi();
            }
            else
            {
                LoadButtonDSDaDi();
            }
            btnPrevDaDi.Enabled = true;
        }
    }
}
