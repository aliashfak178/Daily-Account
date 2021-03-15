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
    public partial class UpdateSales : Form
    {
        public UpdateSales()
        {
            InitializeComponent();
        }

        private void InvoiceTypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (InvoiceTypeComboBox.SelectedIndex == 1)
            {
                GSTNO_TextBox.Text = "N/A";
                GSTNO_TextBox.ReadOnly = true;
                GSTPer_ComboBox.SelectedIndex = 0;
                GSTPer_ComboBox.Enabled = false;
            }
            else
            {
                GSTNO_TextBox.Clear();
                GSTNO_TextBox.ReadOnly = false;
                GSTPer_ComboBox.Enabled = true;
                GSTPer_ComboBox.SelectedIndex = -1;
            }
        }

        private void UpdateSales_Load(object sender, EventArgs e)
        {
            LoadAllComboBoxes();
        }

        private void LoadAllComboBoxes()
        {
            Item_ComboBox.DataSource = GetAllItems();
            Item_ComboBox.DisplayMember = "Item_Name";
            Item_ComboBox.SelectedIndex = -1;

            Recever_ComboBox.DataSource = GetAllRecever();
            Recever_ComboBox.DisplayMember = "Recever_Name";
            Recever_ComboBox.SelectedIndex = -1;
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

        private DataTable GetAllRecever()
        {
            DataTable Dt_Recever = new DataTable();
            string connString = DBCofiguration.ConnectionString;
            using (SqlConnection conn = new SqlConnection(connString))
            {
                using (SqlCommand cmd = new SqlCommand("usp_GetAllRecever", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    Dt_Recever.Load(reader);
                }
            }
            return Dt_Recever;
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            if(BillNoTextBox.Text.Trim()==string.Empty)
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
            Recever_ComboBox.Text = row["Recever_Name"].ToString();
            SalesDate_DateTimePicker.Value = Convert.ToDateTime(row["Date"]);
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
                using (SqlCommand cmd = new SqlCommand("usp_GetSalesRecord", conn))
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
                using (SqlCommand cmd = new SqlCommand("usp_CheckSalesRecord", conn))
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

        private void ItemPriceTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && (!char.IsControl(e.KeyChar)) && (!char.IsPunctuation(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private void ShippigChargesTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && (!char.IsControl(e.KeyChar)) && (!char.IsPunctuation(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private void ItemPriceTextBox_TextChanged(object sender, EventArgs e)
        {
            TotalAmountTextBox.Text = GetTotalAmountValues(0);
        }

        private string GetTotalAmountValues(int v)
        {
            int temp;
            if (v == 0)
            {
                return ItemPriceTextBox.Text;
            }
            if (v == 1)
            {
                temp = int.Parse(ItemPriceTextBox.Text) * int.Parse(QuantityNumericUpDown.Value.ToString());
                return temp.ToString();
            }
            if (v == 2)
            {
                temp = int.Parse(ItemPriceTextBox.Text) * int.Parse(QuantityNumericUpDown.Value.ToString());
                int GST_Per = GetGSTPercent();
                int OnePer = temp / 100;
                int GST_Val = OnePer * GST_Per;
                return (temp + GST_Val).ToString();
            }
            if (v == 3)
            {
                temp = int.Parse(ItemPriceTextBox.Text) * int.Parse(QuantityNumericUpDown.Value.ToString());
                int GST_Per = GetGSTPercent();
                int OnePer = temp / 100;
                int GST_Val = OnePer * GST_Per;
                int Shipping = int.Parse(ShippigChargesTextBox.Text);
                return (temp + GST_Val + Shipping).ToString();
            }
            else
            {
                return "404";
            }
        }

        private int GetGSTPercent()
        {
            if (GSTPer_ComboBox.SelectedIndex == 1)
            {
                return 5;
            }
            else if (GSTPer_ComboBox.SelectedIndex == 2)
            {
                return 18;
            }
            else if (GSTPer_ComboBox.SelectedIndex == 3)
            {
                return 28;
            }
            else
            {
                return 0;
            }
        }

        private void QuantityNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            TotalAmountTextBox.Text = GetTotalAmountValues(1);
        }

        private void GSTPer_ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            TotalAmountTextBox.Text = GetTotalAmountValues(2);
        }

        private void ShippigChargesTextBox_TextChanged(object sender, EventArgs e)
        {
            if (ShippigChargesTextBox.Text.Trim() == string.Empty)
            {
                ShippigChargesTextBox.Text = "0";
            }
            TotalAmountTextBox.Text = GetTotalAmountValues(3);
        }

        private void UpdatedSalesButton_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                UpdateSale(BillNoTextBox.Text);
                DialogResult result = MessageBox.Show("Are You Really Want to Update This Record", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    MessageBox.Show("Record Updated Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void UpdateSale(string Bill__No)
        {
            string Bill_To;
            int Item_Percent = GetGSTPercent();
            int Total_Item_Price = int.Parse(ItemPriceTextBox.Text) * int.Parse(QuantityNumericUpDown.Value.ToString());
            if (CashRadioButton.Checked == true)
            {
                Bill_To = "Cash A/C";
            }
            else
            {
                Bill_To = "Clent A/C";
            }
            string connString = DBCofiguration.ConnectionString;
            using (SqlConnection conn = new SqlConnection(connString))
            {
                using (SqlCommand cmd = new SqlCommand("usp_UpdateSales", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    conn.Open();

                    cmd.Parameters.AddWithValue("@invoice_Type", InvoiceTypeComboBox.Text);
                    cmd.Parameters.AddWithValue("@Sales_bill_No", Bill__No);
                    cmd.Parameters.AddWithValue("@Recever_Name", Recever_ComboBox.Text);
                    cmd.Parameters.AddWithValue("@Sales_Date", SalesDate_DateTimePicker.Value);
                    cmd.Parameters.AddWithValue("@GSTIN", GSTNO_TextBox.Text);
                    cmd.Parameters.AddWithValue("@Item_Price", ItemPriceTextBox.Text);
                    cmd.Parameters.AddWithValue("@Sales_Item", Item_ComboBox.Text);
                    cmd.Parameters.AddWithValue("@Sales_Quantity", QuantityNumericUpDown.Value);
                    cmd.Parameters.AddWithValue("@GST_Per", Item_Percent);
                    cmd.Parameters.AddWithValue("@Shipping_Charges", ShippigChargesTextBox.Text);
                    cmd.Parameters.AddWithValue("@Total_Amount", TotalAmountTextBox.Text);
                    cmd.Parameters.AddWithValue("@Bill_To", Bill_To);
                    cmd.Parameters.AddWithValue("@Sales_Desc", DescTextBox.Text);
                    cmd.Parameters.AddWithValue("@Sales_Price", Total_Item_Price);

                    cmd.ExecuteNonQuery();
                }
            }
        }

        private bool ValidateForm()
        {
            if (InvoiceTypeComboBox.SelectedIndex == -1)
            {
                ShowErrorMessage("Please Select Any Invoise Type", "Validation Error");
                return false;
            }
            else if (BillNo_TextBox.Text.Trim() == string.Empty)
            {
                ShowErrorMessage("Please Enter Bill Number", "Validation Error");
                return false;
            }
            else if (Recever_ComboBox.SelectedIndex == -1)
            {
                ShowErrorMessage("Please Select Any Supplier Name", "Validation Error");
                return false;
            }
            else if (GSTNO_TextBox.Text.Trim() == string.Empty)
            {
                ShowErrorMessage("Plase Enter GST Number", "Validation Error");
                return false;
            }
            else if (ItemPriceTextBox.Text.Trim() == string.Empty)
            {
                ShowErrorMessage("Please Enter The Price", "Validation Error");
                return false;
            }
            else if (Item_ComboBox.SelectedIndex == -1)
            {
                ShowErrorMessage("Please Select Any Item", "Validation Error");
                return false;
            }
            else if (GSTPer_ComboBox.Text == string.Empty)
            {
                ShowErrorMessage("Please Select The GST Persent", "Validation Error");
                return false;
            }
            return true;
        }
    }
}
