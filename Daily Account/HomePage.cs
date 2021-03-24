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
    public partial class HomePage : Form
    {
        public HomePage()
        {
            InitializeComponent();
        }

        private void HomePage_Load(object sender, EventArgs e)
        {
            LoadComboBox();

            LoadPurchaseSalesAmount(); 
        }

        private void LoadComboBox()
        {
            FilterComboBox.DataSource = GetAllYear();
            FilterComboBox.DisplayMember = "Years";
            FilterComboBox.SelectedIndex = -1;
        }

        private void LoadPurchaseSalesAmount()
        {
            DataTable DtAmount = LoadPurchaseAndSalesAmmount();
            DataRow row = DtAmount.Rows[0];

            TotalPurchaseAmountLabel.Text = row["Purchase"].ToString();
            TotalSalesAmountLabel.Text = row["Sales"].ToString();
        }

        private DataTable GetAllYear()
        {
            DataTable Dt_Year = new DataTable();
            string connString = DBCofiguration.ConnectionString;
            using (SqlConnection conn = new SqlConnection(connString))
            {
                using (SqlCommand cmd = new SqlCommand("usp_GetAllYears", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    conn.Open();

                    SqlDataReader reader = cmd.ExecuteReader();
                    Dt_Year.Load(reader);
                }
            }
            return Dt_Year;
        }

        private DataTable LoadPurchaseAndSalesAmmount()
        {
            DataTable Dt_Records = new DataTable();
            string connString = DBCofiguration.ConnectionString;
            using (SqlConnection conn = new SqlConnection(connString))
            {
                using (SqlCommand cmd=new SqlCommand("usp_LoadAllAmounts", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    conn.Open();

                    SqlDataReader reader = cmd.ExecuteReader();
                    Dt_Records.Load(reader);
                }
            }

            return Dt_Records;
        }

       
        
        private DataTable GetPurchaseSales()
        {
            
            DataTable Dt_Records = new DataTable();
            string connString = DBCofiguration.ConnectionString;
            using (SqlConnection conn = new SqlConnection(connString))
            {
                using (SqlCommand cmd = new SqlCommand("usp_GetAmountByYear", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    conn.Open();
                    cmd.Parameters.AddWithValue("@Year", FilterComboBox.Text);

                    SqlDataReader reader = cmd.ExecuteReader();
                    Dt_Records.Load(reader);
                }
            }

            return Dt_Records;
        }

        private void GetPurchaseSaleByYear()
        {
            DataTable Dt_PurchaseSales = GetPurchaseSales();
            DataRow row = Dt_PurchaseSales.Rows[0];

            TotalPurchaseAmountLabel.Text = row["Purchase"].ToString();
            TotalSalesAmountLabel.Text = row["Sales"].ToString();
        }

        private void FilterButton_Click(object sender, EventArgs e)
        {
            if(isValidate())
            {
                GetPurchaseSaleByYear();
            }
        }

        private bool isValidate()
        {
            if(FilterComboBox.SelectedIndex == -1)
            {
                MessageBox.Show("Please Select Year Before Filtering", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
    }
}
