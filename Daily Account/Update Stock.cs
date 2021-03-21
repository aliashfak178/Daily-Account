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
    public partial class Update_Stock : Form
    {
        private int StockID;
        public Update_Stock(int ID)
        {
            InitializeComponent();
            StockID = ID;
        }

        private void Update_Stock_Load(object sender, EventArgs e)
        {
            LoadRecord();
        }

        private void LoadRecord()
        {
            DataTable DtStock = GetRecord();
            DataRow row = DtStock.Rows[0];

            ItemNameTextBox.Text = row["Item Name"].ToString();
            QuantityTextBox.Text = row["Quantity"].ToString();
        }

        private DataTable GetRecord()
        {
            DataTable Dt_Stock = new DataTable();
            string connString = DBCofiguration.ConnectionString;
            using (SqlConnection conn = new SqlConnection(connString))
            {
                using (SqlCommand cmd = new SqlCommand("usp_GetStockById", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    conn.Open();
                    cmd.Parameters.AddWithValue("@StockID", StockID);
                    SqlDataReader reader = cmd.ExecuteReader();
                    Dt_Stock.Load(reader);
                }
            }
            return Dt_Stock;
        }

        private void UpdateRecordButton_Click(object sender, EventArgs e)
        {
            if(IsValidated())
            {
                DialogResult result = MessageBox.Show("Are You Really Want To Update This Stock Item", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if(result == DialogResult.Yes)
                {
                    UpdatedStock();
                    MessageBox.Show("Record Updated Successfully","Record Updated",MessageBoxButtons.OK,MessageBoxIcon.Information);
                }

            }
        }

        private void UpdatedStock()
        {
            int CurrentStock = int.Parse(QuantityTextBox.Text);
            int Used_Quantity = int.Parse(QuantityNumericUpDown.Value.ToString());
            int UpdatedQuantity = CurrentStock - Used_Quantity;
            string connString = DBCofiguration.ConnectionString;
            using (SqlConnection conn = new SqlConnection(connString))
            {
                using( SqlCommand cmd =new SqlCommand("usp_UpdateStockQuantity", conn))
                {
                    conn.Open();
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@StockID", StockID);
                    cmd.Parameters.AddWithValue("@UpdatedQuantity", UpdatedQuantity);

                    cmd.ExecuteNonQuery();
                }
            }
        }

        private bool IsValidated()
        {
            int CurrentStock = int.Parse(QuantityTextBox.Text);
            int Used_Quantity = int.Parse(QuantityNumericUpDown.Value.ToString());
            if(Used_Quantity > CurrentStock)
            {
                MessageBox.Show("Validation ERROR [Your Current Stock is Less Then Your Used Stock]", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
    }
}
