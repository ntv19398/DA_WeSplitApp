﻿using System;
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
    public partial class frmUpdateThuChi : Form
    {
        /// <summary>
        /// Danh sách thành viên của chuyến đi
        /// </summary>
        private List<ThuChi> lstThuChi = new List<ThuChi>();
        private string _macd;
        public frmUpdateThuChi()
        {
            InitializeComponent();
        }

        public frmUpdateThuChi(string maCD)
        {
            InitializeComponent();
            _macd = maCD;
            lstThuChi = DataProcess.getListThuChi();
            LoadFormUpdateThuChi();
        }
        /// <summary>
        /// Hàm load form Update Thu chi
        /// </summary>
        /// <param name="maCD"></param>
        private void LoadFormUpdateThuChi()
        {
            List<ThuChi> lstTCCD = new List<ThuChi>();
            lstTCCD = getListTC();
            lbTitle.Text = "Cập nhật danh sách các khoản thu chi";
            dgvThuChi.DataSource = lstTCCD;
            dgvThuChi.RowHeadersVisible = false;
        }
        /// <summary>
        /// Lấy danh sách thu chu của chuyến đi cần xem chi tiết
        /// </summary>
        /// <param name="maCD"></param>
        /// <returns></returns>
        private List<ThuChi> getListTC()
        {
            List<ThuChi> lstTCCD = new List<ThuChi>();
            for (int i = 0; i < lstThuChi.Count; i++)
            {
                if (lstThuChi[i].maCD == _macd)
                {
                    lstTCCD.Add(lstThuChi[i]);
                }
            }
            return lstTCCD;
        }

        private void dgvThuChi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvThuChi.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                dgvThuChi.CurrentRow.Selected = true;
                txtMaCD.Text = dgvThuChi.Rows[e.RowIndex].Cells["maCD"].FormattedValue.ToString();
                txtMaTC.Text = dgvThuChi.Rows[e.RowIndex].Cells["maTC"].FormattedValue.ToString();
                txtTenKhoanThu.Text = dgvThuChi.Rows[e.RowIndex].Cells["tenKhoanThu"].FormattedValue.ToString();
                txtSoTien.Text = dgvThuChi.Rows[e.RowIndex].Cells["soTien"].FormattedValue.ToString();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ThuChi tc = new ThuChi();
            bool check = true;
            tc.maCD = txtMaCD.Text.ToString();
            tc.maTC = txtMaTC.Text.ToString();
            tc.tenKhoanThu = txtTenKhoanThu.Text.ToString();
            tc.soTien = Int32.Parse(txtSoTien.Text.ToString());
            for (int i = 0; i < lstThuChi.Count; i++)
            {
                if (lstThuChi[i].maTC == tc.maTC && lstThuChi[i].maCD == tc.maCD)
                {
                    MessageBox.Show("Mã thu chi bị trùng", "Thông báo");
                    check = false;
                    break;
                }
            }
            if (check == true)
            {
                lstThuChi.Add(tc);
                LoadFormUpdateThuChi();
                using (var file = new StreamWriter("ThuChi.txt"))
                {
                    for (int i = 0; i < lstThuChi.Count; i++)
                    {
                        string str = lstThuChi[i].maCD + "\t" + lstThuChi[i].maTC + "\t" + lstThuChi[i].tenKhoanThu + "\t" + lstThuChi[i].soTien.ToString();
                        file.WriteLine(str);
                    }
                }
            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < lstThuChi.Count; i++)
            {
                if (lstThuChi[i].maCD == txtMaCD.Text.ToString() && lstThuChi[i].maTC == txtMaTC.Text.ToString())
                {
                    lstThuChi.Remove(lstThuChi[i]);
                }
                LoadFormUpdateThuChi();
            }
            using (var file = new StreamWriter("ThuChi.txt"))
            {
                for (int i = 0; i < lstThuChi.Count; i++)
                {
                    string str = lstThuChi[i].maCD + "\t" + lstThuChi[i].maTC + "\t" + lstThuChi[i].tenKhoanThu + "\t" + lstThuChi[i].soTien.ToString();
                    file.WriteLine(str);
                }
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < lstThuChi.Count; i++)
            {
                if (lstThuChi[i].maCD == txtMaCD.Text.ToString() && lstThuChi[i].maTC == txtMaTC.Text.ToString())
                {
                    lstThuChi[i].tenKhoanThu = txtTenKhoanThu.Text.ToString();
                    lstThuChi[i].soTien = Int32.Parse(txtSoTien.Text.ToString());
                }
                LoadFormUpdateThuChi();
            }
            using (var file = new StreamWriter("ThuChi.txt"))
            {
                for (int i = 0; i < lstThuChi.Count; i++)
                {
                    string str = lstThuChi[i].maCD + "\t" + lstThuChi[i].maTC + "\t" + lstThuChi[i].tenKhoanThu + "\t" + lstThuChi[i].soTien.ToString();
                    file.WriteLine(str);
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            frmDetail frm = new frmDetail(_macd);
            frm.Show();
            this.Hide();
        }

        private void frmUpdateThuChi_FormClosing(object sender, FormClosingEventArgs e)
        {
            frmDetail frm = new frmDetail(_macd);
            frm.Show();
            this.Hide();
        }
    }
}
