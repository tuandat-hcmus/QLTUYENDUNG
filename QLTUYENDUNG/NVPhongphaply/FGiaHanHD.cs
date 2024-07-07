using QLTUYENDUNG.DTO;
using QLTUYENDUNG.Lanhdao;
using QLTUYENDUNG.Utilities;
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
    public partial class FGiaHanHD : Form
    {
        public FGiaHanHD()
        {
            InitializeComponent();
        }

        private async void textBoxMaHD_Leave(object sender, EventArgs e)
        {
            string maHD = textBoxMaHD.Text;
            if (string.IsNullOrEmpty(maHD)) return;

            if (StringChecker.hasSpecialCharacters(maHD))
            {
                MessageBox.Show("Vui lòng nhập đúng và và không chứa kí tự đặt biệt! ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!await Task.Run(() => getTTDT(maHD)))
            {
                btnHuy_Click(sender, e);
            }
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            FTimPPL fTimHD = new FTimPPL();
            if (fTimHD.ShowDialog() == DialogResult.OK)
            {
                string received = fTimHD.returnedIdTTDT;
                getTTDT(received);
            }
        }

        private bool getTTDT(string id)
        {
            TTDT ttdt = TTDT.getTTDTHetHanbyID(id, 1);
            if (ttdt == null)
            {
                MessageBox.Show("Mã doanh nghiệp không hợp lệ! ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            textBoxMaHD.Text = ttdt.idTTDT;
            DoanhNghiep dn = DoanhNghiep.getDoanhNghiepbyID(ttdt.idDoanhNghiep);
            if (dn != null)
                textBoxTenDN.Text = dn.Ten;
            textBoxThoiGianDT.Text = ttdt.thoiGianDt.ToString("dd/MM/yyyy");
            textBoxHinhThucDT.Text = ttdt.hinhThucDT;
            textBoxNgayHH.Text = ttdt.ngayHetHan.ToString("dd/MM/yyyy");
            textBoxTT.Text = ttdt.tinhTrang;
            textBoxGhiChu.Text = ttdt.ghiChu;

            dataGridViewDSUD.DataSource = UuDai.getUuDaibyIDTTDDataTable(textBoxMaHD.Text);

            btnHuy.Enabled = true;
            

            return true;
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            btnHuy.Enabled = false;
            btnGiaHan.Enabled = false;

            textBoxMaHD.Text = "";
            textBoxTenDN.Text = "";
            textBoxThoiGianDT.Text = "";
            textBoxHinhThucDT.Text = "";
            textBoxNgayHH.Text = "";
            textBoxTT.Text = "";
            textBoxGhiChu.Text = "";

            dataGridViewDSUD.DataSource = null;
        }
    }
}
