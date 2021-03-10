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
    public partial class DeletePurchases : Form
    {
        public DeletePurchases()
        {
            InitializeComponent();
        }
        private bool HavingRecordForm = false;


        private void SearchButton_Click(object sender, EventArgs e)
        {
            if (BillNoTextBox.Text.Trim() == string.Empty)
            {
                ShowErrorMessage("Please Enter Bill Number", "Validation Error");
            }
            else
            {
                bool RecordExist;
                GetRecordExist(out RecordExist);
                if (RecordExist)
                {
                    DisplayPurchaseRecord();
                    HavingRecordForm = true;
                }
                else
                {
                    MessageBox.Show("This Bill No is Not Exist In Your DataBase Try Again", "Record Not Exist", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void DisplayPurchaseRecord()
        {
            DataTable DtPurchaseInfo = GetPurchaseRecord(BillNoTextBox.Text);
            DataRow row = DtPurchaseInfo.Rows[0];

            InvoiceTypeComboBox.Text = row["Invoice Type"].ToString();
            BillNo_TextBox.Text = row["Bill_No"].ToString();
            Supplier_ComboBox.Text = row["Supplier_Name"].ToString();
            PurchaseDate_DateTimePicker.Value = Convert.ToDateTime(row["Date"]);
            GSTNO_TextBox.Text = row["GSTIN"].ToString();
            Item_ComboBox.Text = row["Item Name"].ToString();
            ItemPriceTextBox.Text = row["Item Price"].ToString();
            QuantityNumericUpDown.Value = Convert.ToDecimal(row["Quantity"]);
            TotalAmountTextBox.Text = row["Grand total"].ToString();
            GSTPer_ComboBox.Text = row["GST Percent"].ToString() + "%";
            ShippigChargesTextBox.Text = row["Shipping Charges"].ToString();
            DescTextBox.Text = row["Description"].ToString();
        }

        private DataTable GetPurchaseRecord(string Bill_No)
        {
            DataTable DtPurchase = new DataTable();
            string connString = DBCofiguration.ConnectionString;
            using (SqlConnection conn = new SqlConnection(connString))
            {
                using (SqlCommand cmd = new SqlCommand("usp_GetPurchaseRecord", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    conn.Open();
                    cmd.Parameters.AddWithValue("@bill_No_", Bill_No);

                    SqlDataReader reader = cmd.ExecuteReader();
                    DtPurchase.Load(reader);
                }
            }
            return DtPurchase;
        }

        private void GetRecordExist(out bool recordExist)
        {
            string connString = DBCofiguration.ConnectionString;
            using (SqlConnection conn = new SqlConnection(connString))
            {
                using (SqlCommand cmd = new SqlCommand("usp_CheckPurchaeRecord", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    conn.Open();

                    //output parameters
                    cmd.Parameters.Add("@ExistRecord", SqlDbType.Bit).Direction = ParameterDirection.Output;

                    //parameters
                    cmd.Parameters.AddWithValue("@BillNo", BillNoTextBox.Text);

                    //Execute The Command
                    cmd.ExecuteNonQuery();

                    //Passed Parameter's Values From Db
                    recordExist = (bool)cmd.Parameters["@ExistRecord"].Value;
                }
            }
        }

        private void ShowErrorMessage(string v1, string v2)
        {
            MessageBox.Show(v1, v2, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void DeletePurchases_Load(object sender, EventArgs e)
        {

            LoadAllComboBoxes();
        }

        private void LoadAllComboBoxes()
        {
            Item_ComboBox.DataSource = GetAllItems();
            Item_ComboBox.DisplayMember = "Item_Name";
            Item_ComboBox.SelectedIndex = -1;

            Supplier_ComboBox.DataSource = GetAllSuppierName();
            Supplier_ComboBox.DisplayMember = "Supplier_Name";
            Supplier_ComboBox.SelectedIndex = -1;
        }

        private DataTable GetAllItems()
        {
            DataTable Dt_Items = new DataTable();
            string connString = DBCofiguration.ConnectionString;
            using (SqlConnection conn = new SqlConnection(connString))
            {
                using (SqlCommand cmd = new SqlCommand("usp_GetAllItems", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    Dt_Items.Load(reader);
                }
            }
            return Dt_Items;
        }

        private DataTable GetAllSuppierName()
        {
            DataTable Dt_Suppliers = new DataTable();
            string connString = DBCofiguration.ConnectionString;
            using (SqlConnection conn = new SqlConnection(connString))
            {
                using (SqlCommand cmd = new SqlCommand("usp_GetAllSuppliers", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    Dt_Suppliers.Load(reader);
                }
            }
            return Dt_Suppliers;
        }

        private void DeletePurchaseButton_Click(object sender, EventArgs e)
        {
            if(HavingRecordForm)
            {
                DialogResult result = MessageBox.Show("Are You Really Want To Permanent Delete This Record", "User Verification", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if(result == DialogResult.Yes)
                {
                    DeletedThisRecoed(BillNo_TextBox.Text);
                    MessageBox.Show("Purchase Record Deleted Successfully", "Delete Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Please Search The Purchase Record First","Validation Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void DeletedThisRecoed(string billNo)
        {
            string ConnString = DBCofiguration.ConnectionString;
            using (SqlConnection conn = new SqlConnection(ConnString))
            {
                using (SqlCommand cmd = new SqlCommand("usp_DeletePurchaseRecord", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    conn.Open();

                    cmd.Parameters.AddWithValue("@Purchase_bill_No", billNo);
                    cmd.Parameters.AddWithValue("@ItemName", Item_ComboBox.Text);

                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
