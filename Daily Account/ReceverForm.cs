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
    public partial class ReceverForm : Form
    {
        public ReceverForm()
        {
            InitializeComponent();
        }

        private void AddReciverButton_Click(object sender, EventArgs e)
        {
            if (FormValidated())
            {
                DialogResult result = MessageBox.Show("Are You Really Want To Save The Record", "confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    AddRecord();
                    MessageBox.Show("Record Added Successflly in DataBase", "Success Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void AddRecord()
        {
            string connString = DBCofiguration.ConnectionString;
            using (SqlConnection conn = new SqlConnection(connString))
            {
                using (SqlCommand cmd = new SqlCommand("usp_InsertRecevers", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    conn.Open();

                    cmd.Parameters.AddWithValue("@SupplierName", ReceverName_TextBox.Text);
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

        private bool FormValidated()
        {
            if (ReceverName_TextBox.Text.Trim() == string.Empty)
            {
                ShowMessage("Add Supplier Name First", "Validation Error");
                return false;
            }
            else if (StateTextBox.Text.Trim() == string.Empty)
            {
                ShowMessage("Add State First", "Validation Error");
                return false;
            }
            else if (CityTextBox.Text.Trim() == string.Empty)
            {
                ShowMessage("Add City First", "Validation Error");
                return false;
            }
            return true;
        }

        private void ShowMessage(string v1, string v2)
        {
            MessageBox.Show(v1, v2, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void PinCodeTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && (!char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private void PhoneTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && (!char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
        }
    }
}
