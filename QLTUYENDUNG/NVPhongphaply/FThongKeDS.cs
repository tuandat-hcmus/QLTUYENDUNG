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
            comboBoxTT.SelectedIndex = 0;
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
                case 3:
                    ngay = 100;
                    break;
                default:
                    ngay = 3;
                    break;
            }
            // Tình trạng thông tin đăng tuyển (đã gửi, chưa gửi, tất cả)
            int idxTT = comboBoxTT.SelectedIndex;

            dataGridViewDSDN.DataSource = TTDT.getTTDTHetHanDataTable(ngay, idxTT);

            if (dataGridViewDSDN.Rows.Count > 0 && idxTT != 1) 
                btnGuiDS.Enabled = true;
            else btnGuiDS.Enabled = false;
        }

        private void btnGuiDS_Click(object sender, EventArgs e)
        {
            List<string> listId = new List<string>();
            foreach (DataGridViewRow dataRow in dataGridViewDSDN.Rows)
            {
                listId.Add(Convert.ToString(dataRow.Cells["IDTTDT"].Value));
            }
            int n = TTDT.updateTinhTrangTTDT(listId);
            if (n > 0)
            {
                MessageBox.Show($"{n} thông tin đã được gửi !", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Lỗi!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
