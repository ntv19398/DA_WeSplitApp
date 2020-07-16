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
    public partial class frmHomeScreen : Form
    {
        List<ChuyenDi> lstCD = new List<ChuyenDi>();
        public frmHomeScreen()
        {
            InitializeComponent();
            Load();
        }
        void Load()
        {
            List<ChuyenDi> lstCD = DataProcess.getListChuyenDi();
        }
    }
}
