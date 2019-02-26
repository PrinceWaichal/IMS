using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data.SqlClient;

namespace AttendanceManagementSystem.LoginModule
{
    public partial class ForgotPasswordModule : AttendanceManagementSystem.BaseFormApp
    {
        public ForgotPasswordModule()
        {
            InitializeComponent();
        }

        SqlCommand mysqlc = new SqlCommand();

        private void CheckClick(object sender, EventArgs e)
        {
            ServerInfo.Connect.Open();
            try
            {
                
            }
            catch
            {
                MessageBox.Show("", "Unexpected Error Encountered",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                ServerInfo.Connect.Close();
            }
        }

        private void ResetClick(object sender, EventArgs e)
        {

        }

        private void RegisterClick(object sender, EventArgs e)
        {

        }
    }
}
