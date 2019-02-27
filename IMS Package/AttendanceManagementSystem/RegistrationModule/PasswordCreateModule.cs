using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace AttendanceManagementSystem.RegistrationModule
{
    public partial class PasswordCreateModule : AttendanceManagementSystem.BaseFormApp
    {
        public PasswordCreateModule()
        {
            InitializeComponent();
        }

        SqlCommand sqlcom = new SqlCommand();

        private void PassCrtModLoad(object sender, EventArgs e)
        {
            tbPassword.Focus();
            SqlCommand sqlcom = new SqlCommand();
            Int32 count = 201900001;

            sqlcom.CommandText = "Select Max(Id) from dbo.UserMaster";

            try
            {
                ServerInfo.Connect.Close();
                ServerInfo.Connect.Open();
                sqlcom.Connection = ServerInfo.Connect;
                count = (Int32)sqlcom.ExecuteScalar();
            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message, "Connection Error",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            finally
            {
                ServerInfo.Connect.Close();
            }
            tbUserName.Text = Convert.ToString(count);
        }

        private void SubmitClick(object sender, EventArgs e)
        {
            if(tbPassword.Text == labConfirmPassw.Text)
            {
                sqlcom.CommandType = CommandType.Text;
                try
                {
                    ServerInfo.Connect.Close();
                    ServerInfo.Connect.Open();
                    sqlcom.Connection = ServerInfo.Connect;
                    sqlcom.CommandText =
                        "insert into dbo.UserMaster (Password) values (' " + tbPassword.Text + " ');";
                    sqlcom.ExecuteNonQuery();
                    MessageBox.Show("You have registered successfully\nLogin Now!!!", 
                        "Successful Registration",
                        MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                    this.Hide();
                    LoginModule.LoginModule LogMod = new LoginModule.LoginModule();
                    LogMod.Show();
                }
                catch(SqlException error)
                {
                    MessageBox.Show(error.Message, "Connection Error",
                        MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                }
                finally
                {
                    ServerInfo.Connect.Close();
                }
            }
            else
            {
                MessageBox.Show("Oops, your passwords do NOT MATCH", "Password Error",
                    MessageBoxButtons.RetryCancel, MessageBoxIcon.Exclamation);
            }
        }
    }
}
