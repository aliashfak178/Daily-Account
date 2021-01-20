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
            label1.Text = User;
        }
    }
}
