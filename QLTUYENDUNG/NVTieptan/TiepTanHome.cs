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
using System.Data.SqlClient;

namespace QLTUYENDUNG.NVTieptan
{
    public partial class TiepTanHome : Form
    {
        private DoanhNghiepDAO doanhNghiepService;
        public TiepTanHome()
        {
            InitializeComponent();
            doanhNghiepService = new DoanhNghiepDAO();

        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

      /*  private void btnDangkyDN_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(txtCompany.Text) || string.IsNullOrEmpty(txtTaxNumber.Text)
                || string.IsNullOrEmpty(txtAddress.Text) || string.IsNullOrEmpty(txtEmail.Text) || string.IsNullOrEmpty(txtRepresentative.Text))
            {
                MessageBox.Show("Không được để trống.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var isSuccess = doanhNghiepService.AddDoanhNghiep(new DTO.DoanhNghiep()
            {
                Name = txtCompany.Text,
                TaxNumber = txtTaxNumber.Text,
                Address = txtAddress.Text,
                Email = txtEmail.Text,
                Representative = txtRepresentative.Text,
            });

            if (isSuccess)
            {
                MessageBox.Show("Thành công.");
                txtCompany.Text = string.Empty;
                txtTaxNumber.Text = string.Empty;
                txtAddress.Text = string.Empty;
                txtEmail.Text = string.Empty;
                txtRepresentative.Text = string.Empty;
            }
            else
            {
                MessageBox.Show("Thêm doanh nghiệp thất bại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
*/
        private void groupBox8_Enter(object sender, EventArgs e)
        {

        }

       /* private void LoadDoanhNghiepData()
        {
            DataTable doanhNghiepData = doanhNghiepService.GetDoanhNghiepData();
            dataGridViewDN.DataSource = doanhNghiepData;
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (NVTT.SelectedTab == tabPage3)
            {
                LoadDoanhNghiepData();
            }
        }*/

        private void btnListDn_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            string connectionString = "Data Source=desktop-sa0fl96;Initial Catalog=QLTUYENDUNG;Integrated Security=True";
            string query = "SELECT IDDoanhNghiep, Ten, Email, DiaChi, TaxID, NguoiDaiDien FROM DOANHNGHIEP";

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    try
                    {
                        con.Open();
                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        dataGridViewDN.DataSource = dt;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
            }
        }

        private void dataGridDN_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            

            
        }

        private void groupBox8_Enter_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string id = txtSearchIDDN.Text.Trim();

            // Check if the ID textbox is empty
            if (string.IsNullOrEmpty(id))
            {
                MessageBox.Show("Vui lòng nhập mã số doanh nghiệp để tìm kiếm.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return; // Exit the method early if textbox is empty
            }

            DataTable table = doanhNghiepService.GetDoanhNghiepById(id);

            if (table.Rows.Count > 0)
            {
                dataGridViewDN.DataSource = table;
            }
            else
            {
                dataGridViewDN.DataSource = null; // Clear previous data if no results found
                MessageBox.Show("Không tìm thấy doanh nghiệp có mã số này.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }



        private void btnDangkyDN_Click_1(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(txtCompany.Text) || string.IsNullOrEmpty(txtTaxNumber.Text)
                || string.IsNullOrEmpty(txtAddress.Text) || string.IsNullOrEmpty(txtEmail.Text) || string.IsNullOrEmpty(txtRepresentative.Text))
            {
                MessageBox.Show("Không được để trống.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var isSuccess = doanhNghiepService.AddDoanhNghiep(new DTO.DoanhNghiep()
            {
                Name = txtCompany.Text,
                TaxNumber = txtTaxNumber.Text,
                Address = txtAddress.Text,
                Email = txtEmail.Text,
                Representative = txtRepresentative.Text,
            });

            if (isSuccess)
            {
                MessageBox.Show("Thành công.");
                txtCompany.Text = string.Empty;
                txtTaxNumber.Text = string.Empty;
                txtAddress.Text = string.Empty;
                txtEmail.Text = string.Empty;
                txtRepresentative.Text = string.Empty;
            }
            else
            {
                MessageBox.Show("Thêm doanh nghiệp thất bại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtAddress_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
