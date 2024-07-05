using QLTUYENDUNG.DAO;
using QLTUYENDUNG.DTO;
using QLTUYENDUNG.Util;
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
using QLTUYENDUNG.NVTieptan;
using QLTUYENDUNG.NVPhongphaply;
using QLTUYENDUNG.NVDangtuyen;
using QLTUYENDUNG.Lanhdao;

namespace QLTUYENDUNG
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void loginExitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            string username = usernameBox.Text;
            string password = passwordBox.Text;

            if (String.IsNullOrEmpty(username) || String.IsNullOrEmpty(password))
            {
                MessageBox.Show("Empty username or password!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (UserService.login(username, password))
            {
                string accountType = UserService.getAccountType(username);
                if (!String.IsNullOrEmpty(accountType))
                {
                    this.Hide();
                    if(accountType == "NVTT")
                    {
                        TiepTanHome homePage = new TiepTanHome();
                        homePage.ShowDialog();
                    }
                    else if (accountType == "NVPL")
                    {
                        PhongPhapLyHome homePage = new PhongPhapLyHome();
                        homePage.ShowDialog();
                    }   
                    else if (accountType == "NVDT")
                    {
                        DangTuyenHome homePage = new DangTuyenHome();
                        homePage.ShowDialog();
                    }
                    else if (accountType == "NVTD")
                    {
                        DangTuyenHome homePage = new DangTuyenHome();
                        homePage.ShowDialog();
                    }
                    else if (accountType == "BLD")
                    {
                        LanhDaoHome homePage = new LanhDaoHome();
                        homePage.ShowDialog();  
                    }
                 
                    this.Show();
                }
            }
            else
            {
                MessageBox.Show("Invalid username or password!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void usernameBox_Leave(object sender, EventArgs e)
        {
            if (StringChecker.hasSpecialCharacters(usernameBox.Text))
            {
                MessageBox.Show("Contain special character!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                usernameBox.Select();
            }
        }
    }
}
