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
    public partial class AllStocks : Form
    {
        public AllStocks()
        {
            InitializeComponent();
        }

        private void AllStocks_Load(object sender, EventArgs e)
        {
            StocksDataGridView.DataSource = GetAllStocks();
        }

        private DataTable GetAllStocks()
        {
            DataTable Dt_Stocks = new DataTable();
            string connString = DBCofiguration.ConnectionString;
            using (SqlConnection conn = new SqlConnection(connString))
            {
                using (SqlCommand cmd = new SqlCommand("usp_DisplayAllStocks", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    Dt_Stocks.Load(reader);
                }
            }
            return Dt_Stocks;
        }

        private void StocksDataGridView_DoubleClick(object sender, EventArgs e)
        {
            int row = StocksDataGridView.Rows.GetFirstRow(DataGridViewElementStates.Selected);
            int ID = (int)StocksDataGridView.Rows[row].Cells["Stock ID"].Value;
            //MessageBox.Show(ID.ToString());

            Update_Stock US = new Update_Stock(ID);
            US.ShowDialog();
        }
    }
}
