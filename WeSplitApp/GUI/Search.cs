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
    public partial class frmSearch : Form
    {
        private List<ChuyenDi> lstChuyenDi = new List<ChuyenDi>();
        private List<DiaDiem> lstDiaDiem = new List<DiaDiem>();
        private List<ThanhVien> lstThanhVien = new List<ThanhVien>();
        string _search;
        public frmSearch()
        {
            InitializeComponent();
        }

        public frmSearch(string search)
        {
            InitializeComponent();
            _search = search;
            lstChuyenDi = DataProcess.getListChuyenDi();
            lstThanhVien = DataProcess.getListThanhVien();
            lstDiaDiem = DataProcess.getListDiaDiem();
            LoadResult();
        }
        private void LoadResult()
        {
            int flag = 0;
            for(int i = 0; i < lstThanhVien.Count; i++)
            {
                if (lstThanhVien[i].tenTV.Contains(_search))
                {
                    for (int j = 0; j < lstChuyenDi.Count; j++)
                    {
                        if (lstChuyenDi[j].maCD == lstThanhVien[i].maCD)
                        {
                            Button btn = addButton(lstChuyenDi[j].maCD, lstChuyenDi[j].tenCD, lstChuyenDi[j].urlImage);
                            flpSearch.Controls.Add(btn);
                            btn.Click += new System.EventHandler(this.button_Click);
                            flag++;
                        }
                    }
                }
            }
            if(flag == 0)
            {
                for (int i = 0; i < lstDiaDiem.Count; i++)
                {
                    if (lstDiaDiem[i].tenDD.Contains(_search))
                    {
                        for (int j = 0; j < lstChuyenDi.Count; j++)
                        {
                            if (lstChuyenDi[j].maCD == lstDiaDiem[i].maCD)
                            {
                                Button btn = addButton(lstChuyenDi[j].maCD, lstChuyenDi[j].tenCD, lstChuyenDi[j].urlImage);
                                flpSearch.Controls.Add(btn);
                                btn.Click += new System.EventHandler(this.button_Click);
                            }
                        }
                    }
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

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
