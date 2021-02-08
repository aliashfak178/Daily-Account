using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Daily_Account
{
    public partial class DashBoard : Form
    {
        public String User;
        public DashBoard(String user)
        {
            InitializeComponent();
            User = user;
        }

        private void DashBoard_Load(object sender, EventArgs e)
        {
            VisiblePanelFalse();
            OpenChildForm(new HomePage());
        }

        private void VisiblePanelFalse()
        {
            PurchasePanel.Visible = false;
            SalesPanel.Visible = false;
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private Form ActiveForm = null;
        private void OpenChildForm(Form ChildForm)
        {
            if (ActiveForm != null)
                ActiveForm.Close();
            ActiveForm = ChildForm;
            ChildForm.TopLevel = false;
            ChildForm.FormBorderStyle = FormBorderStyle.None;
            ChildForm.Dock = DockStyle.Fill;
            DashBoardPanel.Controls.Add(ChildForm);
            DashBoardPanel.Tag = ChildForm;
            ChildForm.BringToFront();
            ChildForm.Show();
        }

        private void PurchaseButton_Click(object sender, EventArgs e)
        {
            //OpenChildForm(new PurchaseForm());
            VisiblePanelFalse();
            PurchasePanel.Visible = true;
        }

        private void SalesButton_Click(object sender, EventArgs e)
        {
            VisiblePanelFalse();
            SalesPanel.Visible = true;
        }

        private void HomeButton_Click(object sender, EventArgs e)
        {
            OpenChildForm(new HomePage());
            VisiblePanelFalse();
        }

        private void StockButton_Click(object sender, EventArgs e)
        {
            VisiblePanelFalse();
        }

        private void StatisticsButton_Click(object sender, EventArgs e)
        {
            VisiblePanelFalse();
        }

        private void ReportButton_Click(object sender, EventArgs e)
        {
            VisiblePanelFalse();
        }

        private void AddPurchaseButton_Click(object sender, EventArgs e)
        {
            OpenChildForm(new AddPurchase());
            VisiblePanelFalse();
        }

        private void DisplayPurchaseButton_Click(object sender, EventArgs e)
        {
            OpenChildForm(new AllPurchases());
            VisiblePanelFalse();
        }

        private void UpdateRecordsButton_Click(object sender, EventArgs e)
        {
            OpenChildForm(new UpdatePurchases());
            VisiblePanelFalse();
            
        }

        private void DeletePurchaseButton_Click(object sender, EventArgs e)
        {
            OpenChildForm(new DeletePurchases());
            VisiblePanelFalse();
        }

        private void AddSalesButton_Click(object sender, EventArgs e)
        {
            OpenChildForm(new AddSales());
            VisiblePanelFalse();
        }

        private void DisplaySalesButton_Click(object sender, EventArgs e)
        {
            OpenChildForm(new AllSales());
            VisiblePanelFalse();
        }

        private void UpdateSalesButton_Click(object sender, EventArgs e)
        {
            OpenChildForm(new UpdateSales());
            VisiblePanelFalse();
        }

        private void DeleteSalesButton_Click(object sender, EventArgs e)
        {
            OpenChildForm(new DeleteSales());
            VisiblePanelFalse();
        }
    }
}
