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

namespace QLTUYENDUNG.Lanhdao
{
    public partial class LanhDaoHome : Form
    {
        private Button current;
        public LanhDaoHome(string username)
        {
            InitializeComponent();
            userNameBox.Text = username;
            dataGridView.DataSource = DoanhNghiep.getAllDoanhNghiepDataTable();
        }

        private void btnGiaHanHD_Click(object sender, EventArgs e)
        {
            FDSGiaHanBLD fDSGiaHanBLD = new FDSGiaHanBLD();
            fDSGiaHanBLD.ShowDialog();
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

        private void btnUV_Click(object sender, EventArgs e)
        {
            activateButton(sender);
            dataGridView.DataSource = UngVien.getAllUV();
        }
    }
}
