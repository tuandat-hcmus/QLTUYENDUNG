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
    public partial class PhongPhapLyHome : Form
    {
        public PhongPhapLyHome()
        {
            InitializeComponent();
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            FThongKeDS fThongKeDS = new FThongKeDS();
            fThongKeDS.ShowDialog();
        }

        private void btnGiaHan_Click(object sender, EventArgs e)
        {
            FGiaHanHD fGiaHanHD = new FGiaHanHD();
            fGiaHanHD.ShowDialog();
        }
    }
}
