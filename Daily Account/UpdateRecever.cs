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
    public partial class UpdateRecever : Form
    {
        private int ReceverID;
        public UpdateRecever(int ID)
        {
            InitializeComponent();
            ReceverID = ID;
        }
    }
}
