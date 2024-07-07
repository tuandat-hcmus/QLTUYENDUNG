using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLTUYENDUNG.DAO; 

namespace QLTUYENDUNG.NVTieptan
{
    public partial class TiepTanHome : Form
    {
        private string userFullName; 
        public void setUserFulName(string fulName)
        {
            userFullName = fulName;
        }
        public TiepTanHome()
        {
            InitializeComponent();
        }

        private void TiepTanHome_Load(object sender, EventArgs e)
        {
            compsDataGrid.Rows.Clear();
            membersDataGrid.Rows.Clear();
            DataTable comps = DoanhNghiepDAO.getAllDoanhNghiep();
            DataTable members = UngVienDAO.getAllUngVien();
            compsDataGrid.DataSource = comps;
            membersDataGrid.DataSource = members;
            userNameBox.Text = userFullName;
        }

        private void signInMemberBtn_Click(object sender, EventArgs e)
        {
            tiepTanTab.SelectedIndex = 0;
        }

        private void signInCompBtn_Click(object sender, EventArgs e)
        {
            tiepTanTab.SelectedIndex = 1;
        }

        private void getMemberListBtn_Click(object sender, EventArgs e)
        {
            tiepTanTab.SelectedIndex = 2;
        }

        private void getCompListBtn_Click(object sender, EventArgs e)
        {
            tiepTanTab.SelectedIndex = 3;
        }

        private void dangKiUVBtn_Click(object sender, EventArgs e)
        {
            string ten = tenUngVienBox.Text;
            string sdt = sdtUngVienBox.Text;
            string diaChi = diaChiUngVienBox.Text;
            string email = emailUngVienBox.Text;
            string cccd = cccdUngVienBox.Text;
            bool isMale = isMaleBtn.Checked;
            bool isFemale = isFemaleBtn.Checked;
            if(string.IsNullOrWhiteSpace(ten) || string.IsNullOrWhiteSpace(sdt) || string.IsNullOrWhiteSpace(diaChi) || string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(cccd) || (!isFemale && !isMale))
            {
                MessageBox.Show("Missing field!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if(!Regex.Match(sdt, @"^(0?)(3[2-9]|5[6|8|9]|7[0|6-9]|8[0-6|8|9]|9[0-4|6-9])[0-9]{7}$").Success)
                {
                    MessageBox.Show("Invalid phone number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if(!Regex.Match(email, @"^[\w-\.]+@([\w-]+\.)+[\w-]{2,4}$").Success)
                {
                    MessageBox.Show("Invalid email", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if(!Regex.Match(cccd, @"^\d{12}$").Success)
                {
                    MessageBox.Show("Invalid CCCD", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                { 
                    string GioiTinh = isMale ? "Nam" : "Nữ";
                    int rowCount = UngVienDAO.insertUngVien(ten, email, sdt, cccd, diaChi, GioiTinh);
                    if(rowCount > 0)
                    {
                        MessageBox.Show("Insert successfully!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        clearInput();
                    }
                    else
                    {
                        MessageBox.Show("Insert failed!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    Console.WriteLine(rowCount + " inserted to UNGVIEN");
                }
            }
        }

        private void tiepTanTab_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable comps = DoanhNghiepDAO.getAllDoanhNghiep();
            DataTable members = UngVienDAO.getAllUngVien();
            compsDataGrid.DataSource = comps;
            membersDataGrid.DataSource = members;
        }

        private void dangKiDNBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tenCongTyBox.Text) || string.IsNullOrEmpty(idThueBox.Text)
                || string.IsNullOrEmpty(diaChiCtyBox.Text) || string.IsNullOrEmpty(emailLienHeBox.Text) || string.IsNullOrEmpty(nguoiDaiDienBox.Text))
            {
                MessageBox.Show("Không được để trống.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            string Ten = tenCongTyBox.Text;
            string TaxID = idThueBox.Text;
            string DiaChi = diaChiCtyBox.Text;
            string Email = emailLienHeBox.Text;
            string NguoiDaiDien = nguoiDaiDienBox.Text;
            if (!Regex.Match(Email, @"^[\w-\.]+@([\w-]+\.)+[\w-]{2,4}$").Success)
            {
                MessageBox.Show("Invalid email", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            bool isSuccess = DoanhNghiepDAO.AddDoanhNghiep(Ten, Email, DiaChi, TaxID, NguoiDaiDien);
            if (isSuccess)
            {
                MessageBox.Show("Thành công.");
                tenCongTyBox.Text = string.Empty;
                idThueBox.Text = string.Empty;
                diaChiCtyBox.Text = string.Empty;
                emailLienHeBox.Text = string.Empty;
                nguoiDaiDienBox.Text = string.Empty;
            }
            else
            {
                MessageBox.Show("Thêm doanh nghiệp thất bại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void clearInput()
        {
            tenUngVienBox.Text = "";
            sdtUngVienBox.Text = "";
            diaChiUngVienBox.Text = "";
            emailUngVienBox.Text = "";
            cccdUngVienBox.Text = "";
            isMaleBtn.Checked = false;
            isFemaleBtn.Checked = false;
        }
    }
}
