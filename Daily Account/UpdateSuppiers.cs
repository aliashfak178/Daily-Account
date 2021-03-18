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
    public partial class UpdateSuppiers : Form
    {
        private int SupplierID;
        public UpdateSuppiers(int ID)
        {
            InitializeComponent();
            SupplierID = ID;
        }

        private void UpdateSuppiers_Load(object sender, EventArgs e)
        {
            StoreAndUD_Record();
        }

        private void StoreAndUD_Record()
        {
            DataTable DtSupplierRecord = GetSuppliers();
            DataRow row = DtSupplierRecord.Rows[0];

            SupplierName_TextBox.Text = row["Supplier Name"].ToString();
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

        private DataTable GetSuppliers()
        {
            DataTable Dt_Supplier = new DataTable();
            string connString = DBCofiguration.ConnectionString;
            using (SqlConnection conn = new SqlConnection(connString))
            {
                using (SqlCommand cmd = new SqlCommand("usp_GetSupplierRecordForUpdate", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    conn.Open();
                    cmd.Parameters.AddWithValue("@SupplierID", SupplierID);
                    SqlDataReader reader = cmd.ExecuteReader();
                    Dt_Supplier.Load(reader);
                }
            }
            return Dt_Supplier;
        }

        private void UpdateSuppierButton_Click(object sender, EventArgs e)
        {
            if(IsValidated())
            {
                DialogResult result = MessageBox.Show("Are You Really Want To Update This Record","Confirm",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
                if(result == DialogResult.Yes)
                {
                    UpdateSupplier(SupplierID);
                    MessageBox.Show("Record Updated Successfully", "Successed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }     
            }    
        }

        private bool IsValidated()
        {
            if(SupplierName_TextBox.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Enter Supplier Name First", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if(StateTextBox.Text.Trim()==string.Empty)
            {
                MessageBox.Show("Enter State First", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if(CityTextBox.Text.Trim()==string.Empty)
            {
                MessageBox.Show("Enter City First", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private void UpdateSupplier(int supplierID)
        {
            string connString = DBCofiguration.ConnectionString;
            using (SqlConnection conn=new SqlConnection(connString))
            {
                using (SqlCommand cmd=new SqlCommand("usp_UpdateSupplier", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    conn.Open();

                    cmd.Parameters.AddWithValue("@supplierID", supplierID);
                    cmd.Parameters.AddWithValue("@SupplierName", SupplierName_TextBox.Text);
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

        private void DeleteSupplierButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are You Really Want To Update This Record", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(result == DialogResult.Yes)
            {
                DeleteThisRecord();
                MessageBox.Show("Record Deleted Successfully", "Successed", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }    

        }

        private void DeleteThisRecord()
        {
            string connString = DBCofiguration.ConnectionString;
            using (SqlConnection conn = new SqlConnection(connString))
            {
                using (SqlCommand cmd = new SqlCommand("usp_DeleteSupplier", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    conn.Open();

                    cmd.Parameters.AddWithValue("@supplierID", SupplierID);
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
