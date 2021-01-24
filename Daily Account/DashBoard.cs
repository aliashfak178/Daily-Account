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
        String User;
        public DashBoard(String user)
        {
            InitializeComponent();
            User = user;
        }

        private void DashBoard_Load(object sender, EventArgs e)
        {

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
            OpenChildForm(new PurchaseForm());
        }
    }
}
