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

        private void UpdateReciverButton_Click(object sender, EventArgs e)
        {
            if(IsValidated())
            {
                DialogResult result = MessageBox.Show("Are You Really Want To Update This Record","Confirm",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
                if(result == DialogResult.Yes)
                {
                    UpdateRecevers(ReceverID);
                    MessageBox.Show("Record Updated Successfully", "Successed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void UpdateRecevers(int receverID)
        {
            string connString = DBCofiguration.ConnectionString;
            using (SqlConnection conn = new SqlConnection(connString))
            {
                using (SqlCommand cmd = new SqlCommand("usp_UpdatedRecever", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    conn.Open();

                    cmd.Parameters.AddWithValue("@ReceverID", receverID);
                    cmd.Parameters.AddWithValue("@ReceverName", ReceverName_TextBox.Text);
                    cmd.Parameters.AddWithValue("@Email", EmailTextBox.Text);
                    cmd.Parameters.AddWithValue("@State", StateTextBox.Text);
                    cmd.Parameters.AddWithValue("@City", CityTextBox.Text);
                    cmd.Parameters.AddWithValue("@PinCode", PinCodeTextBox.Text);
                    cmd.Parameters.AddWithValue("@BankName", BankNameTextBox.Text);
                    cmd.Parameters.AddWithValue("@IFSCCode", IFSCCodeTextBox.Text);
                    cmd.Parameters.AddWithValue("@AccountNo", AC_NoTextBox.Text);
                    cmd.Parameters.AddWithValue("@Phone", PhoneTextBox.Text);
                    cmd.Parameters.AddWithValue("@GSTIN", GSTINTextBox.Text);
                    cmd.Parameters.AddWithValue("@Address", AddressRichTextBox.Text);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        private bool IsValidated()
        {
            if (ReceverName_TextBox.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Enter Supplier Name First", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (StateTextBox.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Enter State First", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (CityTextBox.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Enter City First", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private void DeleteReciverButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are You Really Want To Update This Record", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                DeleteThisRecord(ReceverID);
                MessageBox.Show("Record Deleted Successfully", "Successed", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void DeleteThisRecord(int receverID)
        {
            string connString = DBCofiguration.ConnectionString;
            using (SqlConnection conn = new SqlConnection(connString))
            {
                using (SqlCommand cmd = new SqlCommand("usp_DeleteRecever", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    conn.Open();

                    cmd.Parameters.AddWithValue("@ReceverID", receverID);
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
