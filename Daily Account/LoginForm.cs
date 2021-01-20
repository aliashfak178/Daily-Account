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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void GuestLoginLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OpenDashBoard("Guest");
        }
        private void LoginButton_Click(object sender, EventArgs e)
        {
            OpenDashBoard("Addmin");
        }
        private void OpenDashBoard(String user)
        {
            DashBoard DB = new DashBoard(user);
            DB.Show();
        }
    }
}
