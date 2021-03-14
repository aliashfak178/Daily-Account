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
    public partial class AllSales : Form
    {
        public AllSales()
        {
            InitializeComponent();
        }

        private void FilterButton_Click(object sender, EventArgs e)
        {
            if ((FilterComboBox.SelectedIndex == -1) || ((SearchTextBox.Text.Trim() == string.Empty)))
            {
                MessageBox.Show("Please Select Filter Type OR Enter The Text", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DataView Dt_View = Dt_Sales.DefaultView;
                if(FilterComboBox.SelectedIndex == 0)
                {
                    Dt_View.RowFilter = "Bill_No LIKE '%" + SearchTextBox.Text + "%'";
                }
                else if(FilterComboBox.SelectedIndex == 1)
                {
                    Dt_View.RowFilter = "Recever_Name LIKE '%" + SearchTextBox.Text + "%'";
                }
                else if(FilterComboBox.SelectedIndex == 2)
                {
                    Dt_View.RowFilter = "Date LIKE '%" + SearchTextBox.Text + "%'";
                }
            }
        }

        private void AllSales_Load(object sender, EventArgs e)
        {
            SalesDataGridView.DataSource = GetAllSales();
        }

        private DataTable Dt_Sales;
        private DataTable GetAllSales()
        {
            Dt_Sales = new DataTable();
            string connString = DBCofiguration.ConnectionString;
            using (SqlConnection conn = new SqlConnection(connString))
            {
                using (SqlCommand cmd = new SqlCommand("usp_DisplayAllSales", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    Dt_Sales.Load(reader);
                }
            }
            return Dt_Sales;
        }
    }
}
