using QLTUYENDUNG.DAO;
using System;
using System.Data;
using System.Windows.Forms;

namespace QLTUYENDUNG.NVTuyendung
{
    public partial class TuyenDungHome : Form
    {
        private DoanhNghiepDAO doanhNghiepDAO = new DoanhNghiepDAO();
        public TuyenDungHome()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable table = doanhNghiepDAO.GetAllDoanhNghiep();
                dataGridView1.DataSource = table;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = dataGridView1.CurrentRow.Index;
            textBox1.Text = dataGridView1.Rows[i].Cells[0].Value.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            TuyenDungXemHoSo frm2 = new TuyenDungXemHoSo(textBox1.Text);
            frm2.ShowDialog();
            frm2 = null;
            this.Show();
        }
    }
}
