using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Daily_Account
{
    public partial class AddPurchase : Form
    {
        public AddPurchase()
        {
            InitializeComponent();
        }

        private void InvoiceTypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(InvoiceTypeComboBox.SelectedIndex == 1)
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

        private void AddPurchaseButton_Click(object sender, EventArgs e)
        {

        }
    }
}
