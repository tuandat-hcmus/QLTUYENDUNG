using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLTUYENDUNG
{
    public partial class HomePage : Form
    {
        private string username, accountType;
        public HomePage(string username, string accountType)
        {
            this.username = username;
            this.accountType = accountType;
            InitializeComponent();

            label1.Text = username; label2.Text = accountType;
        }
    }
}
