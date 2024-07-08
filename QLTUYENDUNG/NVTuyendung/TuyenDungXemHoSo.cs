using QLTUYENDUNG.DAO;
using System;
using System.Data;
using System.Windows.Forms;

namespace QLTUYENDUNG.NVTuyendung
{
    public partial class TuyenDungXemHoSo : Form
    {
        private UngVienDAO ungVienDAO = new UngVienDAO();
        public TuyenDungXemHoSo(string strTextbox)
        {
            InitializeComponent();
            textBox1.Text = strTextbox;
        }

        private void TuyenDungXemHoSo_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable table = ungVienDAO.GetUngVienData(textBox1.Text);
                dataGridView1.DataSource = table;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private DoanhNghiepDAO doanhNghiepDAO = new DoanhNghiepDAO();
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable table = doanhNghiepDAO.GetDoanhNghiepData(textBox1.Text);
                dataGridView2.DataSource = table;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = dataGridView1.CurrentRow.Index;
            textBox2.Text = dataGridView1.Rows[i].Cells[0].Value.ToString();
            textBox3.Text = dataGridView1.Rows[i].Cells[1].Value.ToString();
            textBox4.Text = dataGridView1.Rows[i].Cells[2].Value.ToString();
            textBox7.Text = dataGridView1.Rows[i].Cells[3].Value.ToString();
            textBox6.Text = dataGridView1.Rows[i].Cells[4].Value.ToString();
            textBox10.Text = dataGridView1.Rows[i].Cells[5].Value.ToString();
            textBox5.Text = dataGridView1.Rows[i].Cells[6].Value.ToString();
            textBox9.Text = dataGridView1.Rows[i].Cells[7].Value.ToString();
            textBox8.Text = dataGridView1.Rows[i].Cells[8].Value.ToString();
            textBox13.Text = dataGridView1.Rows[i].Cells[9].Value.ToString();
            textBox12.Text = dataGridView1.Rows[i].Cells[10].Value.ToString();
            comboBox1.Text = dataGridView1.Rows[i].Cells[11].Value.ToString();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                ungVienDAO.UpdateTinhTrang(textBox2.Text, comboBox1.Text);
                DataTable table = ungVienDAO.GetUngVienData(textBox1.Text);
                dataGridView1.DataSource = table;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
