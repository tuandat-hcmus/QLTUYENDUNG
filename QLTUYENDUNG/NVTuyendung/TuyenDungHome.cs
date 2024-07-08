using QLTUYENDUNG.DAO;
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

namespace QLTUYENDUNG.NVTuyendung
{
    public partial class TuyenDungHome : Form
    {
        public TuyenDungHome()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ThemHoSoTuyenDung themHoSoTuyenDung = new ThemHoSoTuyenDung();
            themHoSoTuyenDung.ShowDialog();
        }

        private void btnDN_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable table = DoanhNghiep.getAllDoanhNghiepDataTable();
                dataGridView1.DataSource = table;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnUV_Click(object sender, EventArgs e)
        {
            this.Hide();
            TuyenDungXemHoSo frm2 = new TuyenDungXemHoSo(textBox1.Text);
            frm2.ShowDialog();
            frm2 = null;
            this.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = dataGridView1.CurrentRow.Index;
            textBox1.Text = dataGridView1.Rows[i].Cells[0].Value.ToString();
        }
    }
}
