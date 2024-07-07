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
    public partial class FUuDai : Form
    {
        public List<string> selections;
        public FUuDai(List<string> idUuDai)
        {
            InitializeComponent();
            this.selections = idUuDai;
            try
            {
                loadData();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error at FUuDai constructor, cannot load data: " + ex.Message);
                MessageBox.Show("Cannot load data", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        private void btnChon_Click(object sender, EventArgs e)
        {
            selections.Clear();
            foreach (DataGridViewRow row in dataGridViewUuDai.Rows)
            {
                DataGridViewCheckBoxCell checkBoxCell = row.Cells["checkBoxColumn"] as DataGridViewCheckBoxCell;
                if (Convert.ToBoolean(checkBoxCell.Value) == true)
                    selections.Add(row.Cells[0].Value.ToString());
            }
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private async void loadData()
        {
            await Task.Run(() => dataGridViewUuDai.DataSource = UuDai.getAllUuDai());

            DataGridViewCheckBoxColumn checkBoxColumn = new DataGridViewCheckBoxColumn();

            checkBoxColumn.HeaderText = "Select";
            checkBoxColumn.Name = "checkBoxColumn";
            checkBoxColumn.DataPropertyName = "checkBoxColumn";
            checkBoxColumn.ReadOnly = false;

            // Thiết lập ReadOnly cho các cột không phải checkbox
            foreach (DataGridViewColumn column in dataGridViewUuDai.Columns)
            {
                if (column.Name != "checkBoxColumn")  // Thay "checkBoxColumn" bằng tên của cột checkbox
                {
                    column.ReadOnly = true;
                }
            }

            // Thêm checkbox vào DataGridView
            dataGridViewUuDai.Columns.Add(checkBoxColumn);

            if (dataGridViewUuDai == null || dataGridViewUuDai.Rows.Count <= 0) return;

            dataGridViewUuDai.ClearSelection();

            foreach (DataGridViewRow row in dataGridViewUuDai.Rows)
            {
                DataGridViewCheckBoxCell checkBoxCell = row.Cells["checkBoxColumn"] as DataGridViewCheckBoxCell;
                string rowId = row.Cells["IDUuDai"].Value.ToString();
                if (selections.Contains(rowId))
                {
                    checkBoxCell.Value = true;
                }
            }
        }
    }
}
