using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Utility;

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
            

            if (ValidateLogin())
            {
                bool IsUserNameCurrect, IsPasswordCurrect;
                GetIsUserLoginCurrect(out IsUserNameCurrect, out IsPasswordCurrect);
                if (IsUserNameCurrect && IsPasswordCurrect)
                {
                    OpenDashBoard("Addmin");
                }
                else
                {
                    if (!IsUserNameCurrect)
                    {
                        MessageBox.Show("User Name is Not Currect.", "Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("Password is Not Currect.", "Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    clearTextBoxes();
                }
                   
            }
        }

        private void clearTextBoxes()
        {
            UserNameTextBox.Clear();
            PasswordTextBox.Clear();
            UserNameTextBox.Focus();
        }

        private void GetIsUserLoginCurrect(out bool isUserNameCurrect, out bool isPasswordCurrect)
        {
            string connString = DBCofiguration.ConnectionString;
            using(SqlConnection conn= new SqlConnection(connString))
            {
                using(SqlCommand cmd=new SqlCommand("usp_UserChackLoginDetails", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    conn.Open();

                    //output parameters
                    cmd.Parameters.Add("@IsUserNameCurrect", SqlDbType.Bit).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("@IsPasswordCurrect", SqlDbType.Bit).Direction = ParameterDirection.Output;

                    //parameters
                    cmd.Parameters.AddWithValue("@UserName", UserNameTextBox.Text);
                    cmd.Parameters.AddWithValue("@Password", PasswordTextBox.Text);

                    //Execute The Command
                    cmd.ExecuteNonQuery();

                    //Passed Parameter's Values From Db
                    isUserNameCurrect = (bool)cmd.Parameters["@IsUserNameCurrect"].Value;
                    isPasswordCurrect = (bool)cmd.Parameters["@IsPasswordCurrect"].Value;
                }
            }
        }

        private bool ValidateLogin()
        {
            if(UserNameTextBox.Text.Trim()==string.Empty)
            {
                DisplayMessage("Please Enter UserName First");
                return false;
            }
            else if (PasswordTextBox.Text.Trim() == string.Empty)
            {
                DisplayMessage("Please Enter Password First");
                return false;
            }
            return true;
        }

        private void DisplayMessage(string Msg)
        {
            MessageBox.Show(Msg, "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void OpenDashBoard(String user)
        {
            DashBoard DB = new DashBoard(user);
            DB.Show();
            this.Hide();
        }
    }
}
