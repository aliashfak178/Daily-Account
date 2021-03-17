using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Utility;

namespace Daily_Account
{
    public partial class Suppliers : Form
    {
        public Suppliers()
        {
            InitializeComponent();
        }

        private void Suppliers_Load(object sender, EventArgs e)
        {
            LoadDataIntoGridView();
        }

        private void LoadDataIntoGridView()
        {
            SupplierDataGridView.DataSource = GetAllData();
        }


        private DataTable DtSupplier;
        private DataTable GetAllData()
        {
            DtSupplier = new DataTable();
            string connString = DBCofiguration.ConnectionString;
            using (SqlConnection conn = new SqlConnection(connString))
            {
                using (SqlCommand cmd = new SqlCommand("usp_GetAllSupplers", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    DtSupplier.Load(reader);
                }
            }
            return DtSupplier;
        }
        private void SupplierDataGridView_DoubleClick(object sender, EventArgs e)
        {
            int row = SupplierDataGridView.Rows.GetFirstRow(DataGridViewElementStates.Selected);
            int Sample = (int)SupplierDataGridView.Rows[row].Cells["ID"].Value;

            UpdateSuppiers US = new UpdateSuppiers(Sample);
            US.ShowDialog();
        }

        private void FilterButton_Click(object sender, EventArgs e)
        {
            DataView DtView = DtSupplier.DefaultView;
            DtView.RowFilter = "Supplier_Name LIKE '%" + SearchTextBox.Text + "%'";
        }
    }
}
