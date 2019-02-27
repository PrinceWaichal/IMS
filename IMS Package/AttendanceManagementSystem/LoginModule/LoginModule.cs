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
            if(UsernameBox.Text != "" && PasswordBox.Text != "")
            {
                try
                {
                    ServerInfo.Connect.Open();
                    mysqlc.Connection = ServerInfo.Connect;
                    mysqlc.CommandText = "select Id, UserType, Password from dbo.UserMaster where Id = '"+UsernameBox.Text+"' and UserType = '"+UsertypeCombo.Text+"' and Password = '"+PasswordBox.Text+"' ";
                    mysqlc.ExecuteNonQuery();

                    SqlDataReader reader = mysqlc.ExecuteReader(CommandBehavior.CloseConnection);

                    if(reader.Read() == true)
                    {
                        MessageBox.Show("You have sucessfully logged in","Login Successful"
                            ,MessageBoxButtons.OKCancel,MessageBoxIcon.Information);
                        this.Hide();
                        if(UsertypeCombo.Text == "Teacher")
                        {
                            SessionModule.TeacherSessionModule TeachMod = new SessionModule.TeacherSessionModule();
                            TeachMod.Show();
                        }
                        else if(UsertypeCombo.Text == "Student")
                        {
                            SessionModule.StudentSessionModule StudMod = new SessionModule.StudentSessionModule();
                            StudMod.Show();
                        }
                        else
                        {
                            MessageBox.Show("Something Went Wrong", "Logincal Error",
                                MessageBoxButtons.OKCancel, MessageBoxIcon.Hand);
                        }
                    }
                }
                catch (SqlException error)
                {
                    MessageBox.Show(error.Message, "Unexpected Error Ocurred", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    ServerInfo.Connect.Close();
                }
            }
            else
            {
                MessageBox.Show("Entered details dont match with database\nTry Again", "Invalid ID & Pass", 
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Hand);
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
