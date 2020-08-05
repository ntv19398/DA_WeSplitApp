using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WeSplitApp.Sources;

namespace WeSplitApp.GUI
{
    public partial class frmUpdateThanhVien : Form
    {

        /// <summary>
        /// Danh sách thành viên của chuyến đi
        /// </summary>
        private List<ThanhVien> lstThanhVien = new List<ThanhVien>();
        private string _macd;
        public frmUpdateThanhVien()
        {
            InitializeComponent();
        }

        public frmUpdateThanhVien(string maCD)
        {
            InitializeComponent();
            _macd = maCD;
            lstThanhVien = DataProcess.getListThanhVien();
            lbTitle.Text = "Cập nhật danh sách Thành viên";
            LoadFormUpdateThanhVien();
        }
        /// <summary>
        /// Hàm load form Update Thành viên
        /// </summary>
        /// <param name="maCD"></param>
        private void LoadFormUpdateThanhVien()
        {
            List<ThanhVien> lstTVCD = new List<ThanhVien>();
            lstTVCD = getListTV();
            dgvThanhVien.DataSource = lstTVCD;
            dgvThanhVien.RowHeadersVisible = false;
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
                if (lstThanhVien[i].maCD == _macd)
                {
                    lstTVCD.Add(lstThanhVien[i]);
                }
            }
            return lstTVCD;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            bool check = true;
            ThanhVien tv = new ThanhVien();
            tv.maCD = txtMaCD.Text.ToString();
            tv.maTV = txtMaTV.Text.ToString();
            tv.tenTV = txtTenTV.Text.ToString();
            for (int i = 0; i < lstThanhVien.Count; i++)
            {
                if (lstThanhVien[i].maTV == tv.maTV && lstThanhVien[i].maCD == tv.maCD)
                {
                    MessageBox.Show("Mã thành viên bị trùng", "Thông báo");
                    check = false;
                    break;
                }
            }
            if (check == true)
            {
                lstThanhVien.Add(tv);
                LoadFormUpdateThanhVien();
                using (var file = new StreamWriter("ThanhVien.txt"))
                {
                    for (int i = 0; i < lstThanhVien.Count; i++)
                    {
                        string str = lstThanhVien[i].maCD + "\t" + lstThanhVien[i].maTV + "\t" + lstThanhVien[i].tenTV;
                        file.WriteLine(str);
                    }
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < lstThanhVien.Count; i++)
            {
                if (lstThanhVien[i].maCD == txtMaCD.Text.ToString() && lstThanhVien[i].maTV == txtMaTV.Text.ToString())
                {
                    lstThanhVien.Remove(lstThanhVien[i]);
                }
                LoadFormUpdateThanhVien();
            }
            using (var file = new StreamWriter("ThanhVien.txt"))
            {
                for (int i = 0; i < lstThanhVien.Count; i++)
                {
                    string str = lstThanhVien[i].maCD + "\t" + lstThanhVien[i].maTV + "\t" + lstThanhVien[i].tenTV;
                    file.WriteLine(str);
                }
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < lstThanhVien.Count; i++)
            {
                if (lstThanhVien[i].maCD == txtMaCD.Text.ToString() && lstThanhVien[i].maTV == txtMaTV.Text.ToString())
                {
                    lstThanhVien[i].tenTV = txtTenTV.Text.ToString();
                }
                LoadFormUpdateThanhVien();
            }
            using (var file = new StreamWriter("ThanhVien.txt"))
            {
                for (int i = 0; i < lstThanhVien.Count; i++)
                {
                    string str = lstThanhVien[i].maCD + "\t" + lstThanhVien[i].maTV + "\t" + lstThanhVien[i].tenTV;
                    file.WriteLine(str);
                }
            }
        }

        private void dgvThanhVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvThanhVien.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                dgvThanhVien.CurrentRow.Selected = true;
                txtMaCD.Text = dgvThanhVien.Rows[e.RowIndex].Cells["maCD"].FormattedValue.ToString();
                txtMaTV.Text = dgvThanhVien.Rows[e.RowIndex].Cells["maTV"].FormattedValue.ToString();
                txtTenTV.Text = dgvThanhVien.Rows[e.RowIndex].Cells["tenTV"].FormattedValue.ToString();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            frmDetail frm = new frmDetail(_macd);
            frm.Show();
            this.Hide();
        }

        private void frmUpdateThanhVien_FormClosing(object sender, FormClosingEventArgs e)
        {
            frmDetail frm = new frmDetail(_macd);
            frm.Show();
            this.Hide();
        }
    }
}
