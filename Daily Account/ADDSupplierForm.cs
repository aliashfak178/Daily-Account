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
    public partial class ADDSupplierForm : Form
    {
        public ADDSupplierForm()
        {
            InitializeComponent();
        }

        private void AddSuppierButton_Click(object sender, EventArgs e)
        {
            if(FormValidated())
            {
                MessageBox.Show("Suucess", "Suucess",MessageBoxButtons.OK , MessageBoxIcon.Information);
            }
        }

        private bool FormValidated()
        {
            if(SupplierName_TextBox.Text.Trim() == string.Empty)
            {
                ShowMessage("Add Supplier Name First", "Validation Error");
                return false;
            }
            else if(StateTextBox.Text.Trim() == string.Empty)
            {
                ShowMessage("Add State First", "Validation Error");
                return false;
            }
            else if(CityTextBox.Text.Trim() == string.Empty)
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
    }
}
