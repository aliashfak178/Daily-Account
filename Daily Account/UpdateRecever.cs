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
    public partial class UpdateRecever : Form
    {
        private int ReceverID;
        public UpdateRecever(int ID)
        {
            InitializeComponent();
            ReceverID = ID;
        }

        private void UpdateRecever_Load(object sender, EventArgs e)
        {
            StoreAndUD_Record();
        }

        private void StoreAndUD_Record()
        {
            DataTable DtReceverRecord = GetRecevers();
            DataRow row = DtReceverRecord.Rows[0];

            ReceverName_TextBox.Text = row["Supplier Name"].ToString();
            EmailTextBox.Text = row["Supplier Email"].ToString();
            StateTextBox.Text = row["Supplier State"].ToString();
            CityTextBox.Text = row["Supplier City"].ToString();
            PinCodeTextBox.Text = row["Supplier PinCode"].ToString();
            BankNameTextBox.Text = row["Supplier BankName"].ToString();
            IFSCCodeTextBox.Text = row["Supplier IFSC_Code"].ToString();
            AC_NoTextBox.Text = row["Supplier AccountNo"].ToString();
            PhoneTextBox.Text = row["Supplier PhoneNo"].ToString();
            GSTINTextBox.Text = row["Supplier GSTIN"].ToString();
            AddressRichTextBox.Text = row["Supplier Address"].ToString();

        }

        private DataTable GetRecevers()
        {
            DataTable Dt_Suppliers = new DataTable();
            string connString = DBCofiguration.ConnectionString;
            using (SqlConnection conn = new SqlConnection(connString))
            {
                using (SqlCommand cmd = new SqlCommand("usp_GetReceverRecordForUpdate", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    conn.Open();
                    cmd.Parameters.AddWithValue("@ReceverID", ReceverID);
                    SqlDataReader reader = cmd.ExecuteReader();
                    Dt_Suppliers.Load(reader);
                }
            }
            return Dt_Suppliers;
        }
    }
}
