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
    public partial class Recevers : Form
    {
        public Recevers()
        {
            InitializeComponent();
        }

        private void Recevers_Load(object sender, EventArgs e)
        {
            LoadDataIntoGridView();
        }

        private void LoadDataIntoGridView()
        {
            ReceverDataGridView.DataSource = GetAllRecever();
        }
        private DataTable DtRecever;
        private DataTable GetAllRecever()
        {
            DtRecever = new DataTable();
            string connString = DBCofiguration.ConnectionString;
            using (SqlConnection conn = new SqlConnection(connString))
            {
                using (SqlCommand cmd = new SqlCommand("usp_GetAllRecevers", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    DtRecever.Load(reader);
                }
            }
            return DtRecever;
        }

        private void ReceverDataGridView_DoubleClick(object sender, EventArgs e)
        {
            int row = ReceverDataGridView.Rows.GetFirstRow(DataGridViewElementStates.Selected);
            int ID = (int)ReceverDataGridView.Rows[row].Cells["ID"].Value;

            UpdateRecever UR=new UpdateRecever(ID);
            UR.ShowDialog();
        }
    }
}
