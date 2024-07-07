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
        private DoanhNghiep dn = null;
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
            dn = null;
            TTDT ttdt = TTDT.getTTDTHetHanbyID(id, 1);
            if (ttdt == null)
            {
                MessageBox.Show("Mã hợp đồng không hợp lệ! ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            textBoxMaHD.Text = ttdt.idTTDT;
            dn = DoanhNghiep.getDoanhNghiepbyID(ttdt.idDoanhNghiep);
            if (dn != null)
                textBoxTenDN.Text = dn.Ten;
            textBoxThoiGianDT.Text = ttdt.thoiGianDt.ToString("dd/MM/yyyy");
            textBoxHinhThucDT.Text = ttdt.hinhThucDT;
            textBoxNgayHH.Text = ttdt.ngayHetHan.ToString("dd/MM/yyyy");
            textBoxTT.Text = ttdt.tinhTrang;
            textBoxGhiChu.Text = ttdt.ghiChu;

            dataGridViewDSUD.DataSource = UuDai.getUuDaibyIDTTDDataTable(textBoxMaHD.Text);

            btnHuy.Enabled = true;
            btnLienHe.Enabled = true;
            btnGiaHan.Enabled = true;

            return true;
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            btnHuy.Enabled = false;
            btnGiaHan.Enabled = false;
            btnLienHe.Enabled = false;

            textBoxMaHD.Text = "";
            textBoxTenDN.Text = "";
            textBoxThoiGianDT.Text = "";
            textBoxHinhThucDT.Text = "";
            textBoxNgayHH.Text = "";
            textBoxTT.Text = "";
            textBoxGhiChu.Text = "";
            this.dn = null;

            dataGridViewDSUD.DataSource = null;
        }

        private async void btnGiaHan_Click(object sender, EventArgs e)
        {
            int ngay = 0;
            FInput fInput = new FInput();
            if (fInput.ShowDialog() == DialogResult.OK)
            {
                ngay = fInput.output;
            }
            if (ngay > 0)
            {
                int n = 0;
                await Task.Run(() => n = TTDT.updateNgayHetHan(textBoxMaHD.Text, ngay));
                if (n > 0)
                {
                    MessageBox.Show($"{n} hàng được cập nhật", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Lỗi!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                btnHuy_Click(sender, e);
            }
        }

        private void btnLienHe_Click(object sender, EventArgs e)
        {
            if (dn != null)
            {
                FLienHe fLienHe = new FLienHe(dn.Email);
                fLienHe.ShowDialog();
            }
        }

        private void textBoxMaHD_Enter(object sender, EventArgs e)
        {
            btnHuy.Enabled = false;
            btnGiaHan.Enabled = false;
            btnLienHe.Enabled = false;
        }
    }
}
