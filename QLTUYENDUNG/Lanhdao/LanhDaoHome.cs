using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLTUYENDUNG.Lanhdao
{
    public partial class LanhDaoHome : Form
    {
        public LanhDaoHome()
        {
            InitializeComponent();
        }

        private void btnGiaHanHD_Click(object sender, EventArgs e)
        {
            FDSGiaHanBLD fDSGiaHanBLD = new FDSGiaHanBLD();
            fDSGiaHanBLD.ShowDialog();
        }
    }
}
