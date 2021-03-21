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
            FilterByYearComboBox.DataSource = GetAllYear();
            FilterByYearComboBox.DisplayMember = "Years";
            FilterByYearComboBox.SelectedIndex = -1;
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

        private void FilterByYearComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetPurchaseSaleByYear();
        }

        private void GetPurchaseSaleByYear()
        {
            DataTable Dt_PurchaseSales = GetPurchaseSales();
            DataRow row = Dt_PurchaseSales.Rows[0];

            TotalPurchaseAmountLabel.Text = row["Purchase"].ToString();
            TotalSalesAmountLabel.Text = row["Sales"].ToString();
        }
        
        private DataTable GetPurchaseSales()
        {
            int year = int.Parse(FilterByYearComboBox.Text);
            DataTable Dt_Records = new DataTable();
            string connString = DBCofiguration.ConnectionString;
            using (SqlConnection conn = new SqlConnection(connString))
            {
                using (SqlCommand cmd = new SqlCommand("usp_GetAmountByYear", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    conn.Open();
                    cmd.Parameters.AddWithValue("@Year", year);

                    SqlDataReader reader = cmd.ExecuteReader();
                    Dt_Records.Load(reader);
                }
            }

            return Dt_Records;
        }
    }
}
