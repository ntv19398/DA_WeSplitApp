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
    public partial class frmUpdateDiaDiem : Form
    {
        /// <summary>
        /// Danh sách địa điểm của chuyến đi
        /// </summary>
        private List<DiaDiem> lstDiaDiem = new List<DiaDiem>();
        private static string _macd;
        public frmUpdateDiaDiem()
        {
            InitializeComponent();
        }

        public frmUpdateDiaDiem(string maCD)
        {
            InitializeComponent();
            _macd = maCD;
            lstDiaDiem = DataProcess.getListDiaDiem();
            lbTitle.Text = "Cập nhật danh sách Địa điểm";
            LoadFormUpdateDiaDiem();
            dgvDiaDiem.RowHeadersVisible = false;
        }
        /// <summary>
        /// Hàm load form Update Địa điểm
        /// </summary>
        /// <param name="maCD"></param>
        private void LoadFormUpdateDiaDiem()
        {
            List<DiaDiem> lstDDCD = new List<DiaDiem>();
            lstDDCD = getListDD();
            dgvDiaDiem.DataSource = lstDDCD;
        }
        /// <summary>
        /// Lấy danh sách dịa điểm của chuyến đi cần xem chi tiết
        /// </summary>
        /// <param name="maCD"></param>
        /// <returns></returns>
        private List<DiaDiem> getListDD()
        {
            List<DiaDiem> lstDDCD = new List<DiaDiem>();
            for (int i = 0; i < lstDiaDiem.Count; i++)
            {
                if (lstDiaDiem[i].maCD == _macd)
                {
                    lstDDCD.Add(lstDiaDiem[i]);
                }
            }
            return lstDDCD;
        }

        private void dgvDiaDiem_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvDiaDiem.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                dgvDiaDiem.CurrentRow.Selected = true;
                txtMaCD.Text = dgvDiaDiem.Rows[e.RowIndex].Cells["maCD"].FormattedValue.ToString();
                txtMaDD.Text = dgvDiaDiem.Rows[e.RowIndex].Cells["maDD"].FormattedValue.ToString();
                txtTenDD.Text = dgvDiaDiem.Rows[e.RowIndex].Cells["tenDD"].FormattedValue.ToString();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            DiaDiem dd = new DiaDiem();
            bool check = true;
            dd.maCD = txtMaCD.Text.ToString();
            dd.maDD = txtMaDD.Text.ToString();
            dd.tenDD = txtTenDD.Text.ToString();
            for (int i = 0; i < lstDiaDiem.Count; i++)
            {
                if (lstDiaDiem[i].maDD == dd.maDD && lstDiaDiem[i].maCD == dd.maCD)
                {
                    MessageBox.Show("Mã địa điểm bị trùng", "Thông báo");
                    check = false;
                }
            }
            if (check == true)
            {
                lstDiaDiem.Add(dd);
                LoadFormUpdateDiaDiem();
                using (var file = new StreamWriter("DiaDiem.txt"))
                {
                    for (int i = 0; i < lstDiaDiem.Count; i++)
                    {
                        string str = lstDiaDiem[i].maCD + "\t" + lstDiaDiem[i].maDD + "\t" + lstDiaDiem[i].tenDD;
                        file.WriteLine(str);
                    }
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < lstDiaDiem.Count; i++)
            {
                if (lstDiaDiem[i].maCD == txtMaCD.Text.ToString() && lstDiaDiem[i].maDD == txtMaDD.Text.ToString())
                {
                    lstDiaDiem.Remove(lstDiaDiem[i]);
                }
                LoadFormUpdateDiaDiem();
            }
            using (var file = new StreamWriter("DiaDiem.txt"))
            {
                for (int i = 0; i < lstDiaDiem.Count; i++)
                {
                    string str = lstDiaDiem[i].maCD + "\t" + lstDiaDiem[i].maDD + "\t" + lstDiaDiem[i].tenDD;
                    file.WriteLine(str);
                }
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < lstDiaDiem.Count; i++)
            {
                if (lstDiaDiem[i].maCD == txtMaCD.Text.ToString() && lstDiaDiem[i].maDD == txtMaDD.Text.ToString())
                {
                    lstDiaDiem[i].tenDD = txtTenDD.Text.ToString();
                }
                LoadFormUpdateDiaDiem();
            }
            using (var file = new StreamWriter("DiaDiem.txt"))
            {
                for (int i = 0; i < lstDiaDiem.Count; i++)
                {
                    string str = lstDiaDiem[i].maCD + "\t" + lstDiaDiem[i].maDD + "\t" + lstDiaDiem[i].tenDD;
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

        private void frmUpdateDiaDiem_FormClosing(object sender, FormClosingEventArgs e)
        {
            frmDetail frm = new frmDetail(_macd);
            frm.Show();
            this.Hide();
        }
    }
}
