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
    public partial class LoginModule : AttendanceManagementSystem.BaseFormApp
    {
        public LoginModule()
        {
            InitializeComponent();
        }

        private void UsertypeIndexChange(object sender, EventArgs e)
        {
            if (UsertypeCombo.Text == "Admin")
            {
                UsernameBox.Enabled = true;
                PasswordBox.Enabled = true;
            }
            else if (UsertypeCombo.Text == "Student")
            {
                UsernameBox.Enabled = true;
                PasswordBox.Enabled = true;
            }
            else if (UsertypeCombo.Text == "Teacher")
            {
                UsernameBox.Enabled = true;
                PasswordBox.Enabled = true;
            }
            else
            {
                MessageBox.Show("You have made inappropriate selection", "Invalid Selection",
                    MessageBoxButtons.RetryCancel, MessageBoxIcon.Asterisk);
            }
        }

        SqlCommand mysqlc = new SqlCommand();

        private void LoginClick(object sender, EventArgs e)
        {
            
            try
            {
                
            }
            catch (MySqlException error)
            {
                MessageBox.Show(error.Message, "Unexpected Error Ocurred", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void ForgotClick(object sender, EventArgs e)
        {
            
            ForgotPasswordModule ForgeMod = new ForgotPasswordModule();
            this.Hide();
            ForgeMod.Show();
        }

    }
}
