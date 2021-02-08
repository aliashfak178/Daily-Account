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

        private DataTable GetAllPurchase()
        {
            DataTable DtPurchase = new DataTable();
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
    }
}
