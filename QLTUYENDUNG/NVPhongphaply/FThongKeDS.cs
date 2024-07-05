using QLTUYENDUNG.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLTUYENDUNG.NVPhongphaply
{
    public partial class FThongKeDS : Form
    {
        public FThongKeDS()
        {
            InitializeComponent();
            comboBoxNgay.SelectedIndex = 0;
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            int idx = comboBoxNgay.SelectedIndex;
            int ngay;
            switch (idx)
            {
                case 1: 
                    ngay = 7; 
                    break;
                case 2: 
                    ngay = 14;
                    break;
                default:
                    ngay = 3;
                    break;
            }
            dataGridViewDSDN.DataSource = TTDT.getTTDTHetHanDataTable(ngay);
            if (dataGridViewDSDN.Rows.Count > 0) btnGuiDS.Enabled = true;
            else btnGuiDS.Enabled = false;
        }

        private void btnGuiDS_Click(object sender, EventArgs e)
        {

        }
    }
}
