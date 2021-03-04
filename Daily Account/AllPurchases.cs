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
    public partial class AllPurchases : Form
    {
        public AllPurchases()
        {
            InitializeComponent();
        }

        private void AllPurchases_Load(object sender, EventArgs e)
        {
            PurchaseDataGridView.DataSource = GetAllPurchase();
        }

        private DataTable DtPurchase;
        private DataTable GetAllPurchase()
        {
            DtPurchase = new DataTable();
            string connString = DBCofiguration.ConnectionString;
            using (SqlConnection conn = new SqlConnection(connString))
            {
                using (SqlCommand cmd = new SqlCommand("usp_DisplayAllPurchase", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    DtPurchase.Load(reader);
                }
            }
            return DtPurchase;
        }

        private void FilterButton_Click(object sender, EventArgs e)
        {
            if((FilterComboBox.SelectedIndex==-1) || ((SearchTextBox.Text.Trim()==string.Empty)))
            {
                MessageBox.Show("Please Select Filter Type OR Enter The Text", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DataView DtView = DtPurchase.DefaultView;
                if (FilterComboBox.SelectedIndex == 0)
                {
                    DtView.RowFilter = "Bill_No LIKE '%" + SearchTextBox.Text +"%'";
                }
                else if (FilterComboBox.SelectedIndex == 1)
                {
                    DtView.RowFilter = "Supplier_Name LIKE '%" + SearchTextBox.Text + "%'";
                }
                else if (FilterComboBox.SelectedIndex == 2)
                {
                    DtView.RowFilter = "Date LIKE '%" + SearchTextBox.Text + "%'";
                }
            }
        }

        private void FilterComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (FilterComboBox.SelectedIndex == 0)
            {
                SearchLabel.Text = "Bill No.";
            }
            else if(FilterComboBox.SelectedIndex == 1)
            {
                SearchLabel.Text = "Supplier Name";
            }
            else if (FilterComboBox.SelectedIndex == 2)
            {
                SearchLabel.Text = "Date";
            }
            PurchaseDataGridView.DataSource = GetAllPurchase();
            SearchTextBox.Clear();
        }
    }
}
