using QLTUYENDUNG.DTO;
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

namespace QLTUYENDUNG.Lanhdao
{
    public partial class FDSGiaHanBLD : Form
    {
        private List<string> idUuDai { get; set; }
        private List<string> tempIdUuDai { get; set;}
        private bool isTextBoxMaHDLeaveHandled = false;
        public FDSGiaHanBLD()
        {
            InitializeComponent();
        }

        private async void textBoxMaHD_Leave(object sender, EventArgs e)
        {
            string maHD = textBoxMaHD.Text;
            if (string.IsNullOrEmpty(maHD)) return;

            if (StringChecker.hasSpecialCharacters(maHD))
            {
                MessageBox.Show("Vui lòng nhập đúng và và không chứa kí tự đặt biệt! ", "Error",  MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!await Task.Run(() => getTTDT(maHD)))
            {
                btnHuy_Click(sender, e);
            }
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            FTimHD fTimHD = new FTimHD();
            if (fTimHD.ShowDialog() == DialogResult.OK)
            {
                string received = fTimHD.returnedIdTTDT;
                getTTDT(received);
            }
        }

        private bool getTTDT(string id)
        {
            TTDT ttdt = TTDT.getTTDTHetHanbyID(id);
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

            dataGridViewDSUV.DataSource = PhieuDangKyUngTuyen.getPhieuDKbyIDTTDTDataTable(id);
            // Danh sách các ưu đãi hiện có
            idUuDai = UuDai.getIdUuDaibyIDTTDList(id);
            // Copy
            tempIdUuDai = new List<string>(idUuDai);

            btnHuy.Enabled = true;
            btnUuDai.Enabled = true;
            btnGuiDS.Enabled = true;

            return true;
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            btnHuy.Enabled = false;
            btnUuDai.Enabled = false;
            btnGuiDS.Enabled = false;

            textBoxMaHD.Text = "";
            textBoxTenDN.Text = "";
            textBoxThoiGianDT.Text = "";
            textBoxHinhThucDT.Text = "";
            textBoxNgayHH.Text = "";
            textBoxTT.Text = "";
            textBoxGhiChu.Text = "";

            dataGridViewDSUV.DataSource = null;
        }

        private void btnUuDai_Click(object sender, EventArgs e)
        {
            FUuDai fUuDai = new FUuDai(tempIdUuDai);

            if (fUuDai.ShowDialog() == DialogResult.OK)
            {
                this.tempIdUuDai = fUuDai.selections;
            }
        }

        private void btnGuiDS_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show($"Yêu cầu gia hạn hợp đồng này ?", "Question", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                // Tập các id ưu đãi có trong idUuDai (cũ) nhưng không có trong tempIdUuDai (mới)
                List<string> deleted = idUuDai.Except(tempIdUuDai).ToList();
                // Tập các id ưu đãi có trong tempIdUuDai (mới) nhưng không có trong idUuDai (cũ)
                List<string> inserted = tempIdUuDai.Except(idUuDai).ToList();

                int i = UuDai.insertCTUuDaibyIDTTDT(textBoxMaHD.Text, inserted);
                int j = UuDai.deleteCTUuDaibyIDTTDT(textBoxMaHD.Text, deleted);
                
                int n = TTDT.updateTinhTrangTTDT(new List<string> { textBoxMaHD.Text }, 1);


                if (n > 0)
                {
                    MessageBox.Show($"{n} thông tin đã được gửi !", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Lỗi!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                btnHuy_Click(sender, e);
            }
            else
            {
                return;
            }
            
        }

        private void textBoxTenDN_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxMaHD_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
