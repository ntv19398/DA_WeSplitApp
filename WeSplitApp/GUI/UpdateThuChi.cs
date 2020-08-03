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
            tc.maCD = txtMaCD.Text.ToString();
            tc.maTC = txtMaTC.Text.ToString();
            tc.tenKhoanThu = txtTenKhoanThu.Text.ToString();
            tc.soTien = Int32.Parse(txtSoTien.Text.ToString());
            lstThuChi.Add(tc);
            LoadFormUpdateThuChi();
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
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
