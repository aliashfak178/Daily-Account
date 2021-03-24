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
    public partial class StatisticsForm : Form
    {
        public StatisticsForm()
        {
            InitializeComponent();
        }

        private void StatisticsForm_Load(object sender, EventArgs e)
        {
            LoadComboBox();
            LoadAllCharts();
        }

        private void LoadAllCharts()
        {
            PurchaseChart.DataSource = GetData();
            PurchaseChart.Series["Series1"].XValueMember = "Year";
            PurchaseChart.Series["Series1"].YValueMembers = "Purchase Amount";

            SalesChart.DataSource = GetSales();
            SalesChart.Series["Series1"].XValueMember = "Year";
            SalesChart.Series["Series1"].YValueMembers = "Sales Amount";

            PurchaseSalesPiChart.DataSource = GetPiChart();
            PurchaseSalesPiChart.Series["Series1"].XValueMember = "PS";
            PurchaseSalesPiChart.Series["Series1"].YValueMembers = "Total";
        }

        private DataTable GetPiChart()
        {
            DataTable Dt_GetData = new DataTable();
            string connString = DBCofiguration.ConnectionString;
            using (SqlConnection conn = new SqlConnection(connString))
            {
                using (SqlCommand cmd = new SqlCommand("usp_DisplayPiChart", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    conn.Open();

                    SqlDataReader reader = cmd.ExecuteReader();
                    Dt_GetData.Load(reader);
                }
            }
            return Dt_GetData;
        }

        private DataTable GetSales()
        {
            DataTable Dt_Sales = new DataTable();
            string connString = DBCofiguration.ConnectionString;
            using (SqlConnection conn = new SqlConnection(connString))
            {
                using (SqlCommand cmd = new SqlCommand("usp_DisplaySalesChart", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    conn.Open();

                    SqlDataReader reader = cmd.ExecuteReader();
                    Dt_Sales.Load(reader);
                }
            }
            return Dt_Sales;
        }

        private DataTable GetData()
        {
            DataTable Dt_PurchaseData = new DataTable();
            string connString = DBCofiguration.ConnectionString;
            using (SqlConnection conn = new SqlConnection(connString))
            {
                using (SqlCommand cmd = new SqlCommand("usp_DisplayPurchaseChart", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    conn.Open();

                    SqlDataReader reader = cmd.ExecuteReader();
                    Dt_PurchaseData.Load(reader);
                }
            }
            return Dt_PurchaseData;
        }

        private void LoadComboBox()
        {
            FilterByYearComboBox.DataSource = GetAllYear();
            FilterByYearComboBox.DisplayMember = "Years";
            FilterByYearComboBox.SelectedIndex = -1;
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

        private void FilterButton_Click(object sender, EventArgs e)
        {
            if(isValidated())
            {
                UpdateAllCharts();
            }
        }

        private void UpdateAllCharts()
        {
            int Year = int.Parse(FilterByYearComboBox.Text);
            PurchaseChart.DataSource = GetDataByYear(Year);
            PurchaseChart.Series["Series1"].Points.Clear();
            PurchaseChart.Series["Series1"].XValueMember = "Year";
            PurchaseChart.Series["Series1"].YValueMembers = "Purchase Amount";

            SalesChart.DataSource = GetSalesByYear(Year);
            SalesChart.Series["Series1"].Points.Clear();
            SalesChart.Series["Series1"].XValueMember = "Year";
            SalesChart.Series["Series1"].YValueMembers = "Sales Amount";

            PurchaseSalesPiChart.DataSource = GetPiChartByYear(Year);
            PurchaseSalesPiChart.Series["Series1"].Points.Clear();
            PurchaseSalesPiChart.Series["Series1"].XValueMember = "PS";
            PurchaseSalesPiChart.Series["Series1"].YValueMembers = "Total";
        }

        private DataTable GetPiChartByYear(int year)
        {
            DataTable Dt_PiChart = new DataTable();
            string connString = DBCofiguration.ConnectionString;
            using (SqlConnection conn = new SqlConnection(connString))
            {
                using (SqlCommand cmd = new SqlCommand("usp_GetPiChartByYear", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    conn.Open();

                    cmd.Parameters.AddWithValue("@Year", year);

                    SqlDataReader reader = cmd.ExecuteReader();
                    Dt_PiChart.Load(reader);
                }
            }
            return Dt_PiChart;
        }

        private DataTable GetSalesByYear(int year)
        {
            DataTable Dt_SalesChart = new DataTable();
            string connString = DBCofiguration.ConnectionString;
            using (SqlConnection conn = new SqlConnection(connString))
            {
                using (SqlCommand cmd = new SqlCommand("usp_GetSalesChartByYear", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    conn.Open();

                    cmd.Parameters.AddWithValue("@Year", year);

                    SqlDataReader reader = cmd.ExecuteReader();
                    Dt_SalesChart.Load(reader);
                }
            }
            return Dt_SalesChart;
        }

        private DataTable GetDataByYear(int year)
        {
            DataTable Dt_PurchaseChart = new DataTable();
            string connString = DBCofiguration.ConnectionString;
            using (SqlConnection conn = new SqlConnection(connString))
            {
                using (SqlCommand cmd = new SqlCommand("usp_GetPurchaseChartByYear", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    conn.Open();

                    cmd.Parameters.AddWithValue("@Year", year);

                    SqlDataReader reader = cmd.ExecuteReader();
                    Dt_PurchaseChart.Load(reader);
                }
            }
            return Dt_PurchaseChart;
        }

        private bool isValidated()
        {
            if(FilterByYearComboBox.SelectedIndex == -1)
            {
                MessageBox.Show("Please Select Year Before Filtering Chart","Validation Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
    }
}
