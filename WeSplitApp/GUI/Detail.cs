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
    public partial class frmDetail : Form
    {
        /// <summary>
        /// Danh sách chuyến đi
        /// </summary>
        private List<ChuyenDi> lstCD = new List<ChuyenDi>();
        /// <summary>
        /// Danh sách Thành viên của chuyến đi
        /// </summary>
        private List<ThanhVien> lstThanhVien = new List<ThanhVien>();
        /// <summary>
        /// Danh sách địa điểm của chuyến đi
        /// </summary>
        private List<DiaDiem> lstDiaDiem = new List<DiaDiem>();
        /// <summary>
        /// Danh sách thu chi của chuyến đi
        /// </summary>
        private List<ThuChi> lstThuChi = new List<ThuChi>();
        string maCD;
        public frmDetail(string name)
        {
            InitializeComponent();
            lstCD = DataProcess.getListChuyenDi();
            lstThanhVien = DataProcess.getListThanhVien();
            lstDiaDiem = DataProcess.getListDiaDiem();
            lstThuChi = DataProcess.getListThuChi();
            maCD = name;
            LoadFormDetail(maCD);
        }
        /// <summary>
        /// Hàm load form Detail
        /// </summary>
        /// <param name="maCD"></param>
        private void LoadFormDetail(string maCD)
        {
            
            List<ThanhVien> lstTVCD = new List<ThanhVien>();
            List<DiaDiem> lstDDCD = new List<DiaDiem>();
            List<ThuChi> lstTCCD = new List<ThuChi>();
            lstTVCD = getListTV();
            lstDDCD = getListDD();
            lstTCCD = getListTC();
            dgvDSTV.DataSource = lstTVCD;
            dgvDSDD.DataSource = lstDDCD;
            dgvDSTC.DataSource = lstTCCD;
            string tenCD = getTenCD();
            lbChuyenDi.Text = "Chi tiết Chuyến đi " + tenCD;
            int tong = tongTien(lstTCCD);
            int tienTV = tong / lstTVCD.Count;
            txtTongChiPhi.Text = tong.ToString();
            txtTienTVDong.Text = tienTV.ToString();
        }
        /// <summary>
        /// Lấy danh sách thành viên của chuyến đi cần xem chi tiết
        /// </summary>
        /// <param name="maCD"></param>
        /// <returns></returns>
        private List<ThanhVien> getListTV()
        {
            List<ThanhVien> lstTVCD = new List<ThanhVien>();
            for (int i = 0; i < lstThanhVien.Count; i++)
            {
                if (lstThanhVien[i].maCD == maCD)
                {
                    lstTVCD.Add(lstThanhVien[i]);
                }
            }
            return lstTVCD;
        }
        /// <summary>
        /// Lấy danh sách dịa điểm của chuyến đi cần xem chi tiết
        /// </summary>
        /// <param name="maCD"></param>
        /// <returns></returns>
        private List<DiaDiem> getListDD()
        {
            List<DiaDiem> lstDDCD = new List<DiaDiem>();
            for(int i = 0; i < lstDiaDiem.Count; i++)
            {
                if(lstDiaDiem[i].maCD == maCD)
                {
                    lstDDCD.Add(lstDiaDiem[i]);
                }
            }
            return lstDDCD;
        }
        /// <summary>
        /// Lấy danh sách thu chi của chuyến đi cần xem chi tiết
        /// </summary>
        /// <param name="maCD"></param>
        /// <returns></returns>
        private List<ThuChi> getListTC()
        {
            List<ThuChi> lstTCCD = new List<ThuChi>();
            for(int i = 0; i < lstThuChi.Count; i++)
            {
                if(lstThuChi[i].maCD == maCD)
                {
                    lstTCCD.Add(lstThuChi[i]);
                }
            }
            return lstTCCD;
        }
        /// <summary>
        /// Lấy tên chuyến đi
        /// </summary>
        /// <param name="maCD"></param>
        /// <returns></returns>
        private string getTenCD()
        {
            string ten = null;
            for(int i  = 0; i < lstCD.Count; i++)
            {
                if (lstCD[i].maCD == maCD)
                {
                    ten = lstCD[i].tenCD;
                }
            }
            return ten;
        }
        private int tongTien(List<ThuChi> lstTCCD)
        {
            int tong = 0;
            for(int i = 0; i < lstTCCD.Count; i++)
            {
                tong += lstTCCD[i].soTien;
            }
            return tong;
        }

        private void btnUpdateDiaDiem_Click(object sender, EventArgs e)
        {
            frmUpdateDiaDiem frm = new frmUpdateDiaDiem(maCD);
            frm.Show();
        }

        private void btnUpdateThanhVien_Click(object sender, EventArgs e)
        {
            frmUpdateThanhVien frm = new frmUpdateThanhVien(maCD);
            frm.Show();
        }

        private void btnUpdateThuChi_Click(object sender, EventArgs e)
        {
            frmUpdateThuChi frm = new frmUpdateThuChi(maCD);
            frm.Show();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
