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
    public partial class AddPriceForm : Form
    {
        public AddPriceForm()
        {
            InitializeComponent();
        }

        private void AddItemButton_Click_1(object sender, EventArgs e)
        {
            if(!(ItemNameTextBox.Text.Trim() == string.Empty))
            {
                DialogResult result = MessageBox.Show("Are You Realy Want To Add This Record ?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    AddItemRecord(ItemNameTextBox.Text);
                }
            }
            else
            {
                MessageBox.Show("Please Enter An Item Name First","Validation Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            
        }
        private void AddItemRecord(string text)
        {
            string connString = DBCofiguration.ConnectionString;
            using (SqlConnection conn=new SqlConnection(connString))
            {
                using (SqlCommand cmd =new SqlCommand("usp_InsertItems", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    conn.Open();

                    cmd.Parameters.AddWithValue("@ItemName", text);
                    cmd.ExecuteNonQuery();
                }
            }

            MessageBox.Show("Record Added Successfully","Success",MessageBoxButtons.OK,MessageBoxIcon.Information);
            this.Close();
        }
    }
}
