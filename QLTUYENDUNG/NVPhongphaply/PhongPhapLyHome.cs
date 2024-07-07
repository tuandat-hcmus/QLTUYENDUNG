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
    public partial class PhongPhapLyHome : Form
    {
        private Button current;
        public PhongPhapLyHome(string username)
        {
            InitializeComponent();
            userNameBox.Text = username;
            dataGridView.DataSource = DoanhNghiep.getAllDoanhNghiepDataTable();
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

        private void btnDN_Click(object sender, EventArgs e)
        {
            activateButton(sender);
            dataGridView.DataSource = DoanhNghiep.getAllDoanhNghiepDataTable();
        }

        private void btnNV_Click(object sender, EventArgs e)
        {
            activateButton(sender);
            dataGridView.DataSource = UserService.getAllNV();
        }

        private void btnHD_Click(object sender, EventArgs e)
        {
            activateButton(sender);
            dataGridView.DataSource = TTDT.getAllTTDT();
        }

        private void btnHoaDon_Click(object sender, EventArgs e)
        {
            activateButton(sender);
            dataGridView.DataSource = HoaDon.getAllHoaDon();
        }

        private void activateButton(object sender)
        {
            if (sender != null)
            {
                if (current != (Button)sender)
                {
                    deactivateButton();
                    current = (Button)sender;
                    current.BackColor = Color.DodgerBlue;
                }
            }
        }

        private void deactivateButton()
        {
            foreach (Control prevBtn in panelMenu.Controls)
            {
                if (prevBtn.GetType() == typeof(Button))
                {
                    prevBtn.BackColor = Color.FromArgb(40, 86, 182);
                }
            }
        }
    }
}
