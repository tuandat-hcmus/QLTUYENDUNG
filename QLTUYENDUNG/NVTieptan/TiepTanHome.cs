using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLTUYENDUNG.DAO; 

namespace QLTUYENDUNG.NVTieptan
{
    public partial class TiepTanHome : Form
    {
        public TiepTanHome()
        {
            InitializeComponent();
        }

        private void TiepTanHome_Load(object sender, EventArgs e)
        {
            compsDataGrid.Rows.Clear();
            DataTable comps = DoanhNghiepDAO.getAllDoanhNghiep();
            compsDataGrid.DataSource = comps;
        }

        private void signInMemberBtn_Click(object sender, EventArgs e)
        {
            tiepTanTab.SelectedIndex = 0;
        }

        private void signInCompBtn_Click(object sender, EventArgs e)
        {
            tiepTanTab.SelectedIndex = 1;
        }

        private void getMemberListBtn_Click(object sender, EventArgs e)
        {
            tiepTanTab.SelectedIndex = 2;
        }

        private void getCompListBtn_Click(object sender, EventArgs e)
        {
            tiepTanTab.SelectedIndex = 3;
        }

        
    }
}
