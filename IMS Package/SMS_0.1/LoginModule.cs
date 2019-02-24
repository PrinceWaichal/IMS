using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace SMS_0._1
{
    public partial class LoginModule : SMS_0._1.BaseFormApplication
    {
        public LoginModule()
        {
            InitializeComponent();
        }

        private void LoadModule(object sender, EventArgs e)
        {
            UsernameBox.Focus();
            ServerInfo.mySQLConnect.Open();
        }

        MySqlCommand MSQLC = new MySqlCommand();

        private void LoginClick(object sender, EventArgs e)
        {
            try
            {
                if (RadioAdmin.Checked == true)
                {
                    MSQLC.CommandText = "Select * from sms.adminusermaster " +
                            "where adminname = '" + UsernameBox.Text + "' and adminpass = '" + PasswordBox.Text + "'";
                    MSQLC.Connection = ServerInfo.mySQLConnect;
                    MySqlDataReader Read = MSQLC.ExecuteReader();
                    if (Read.Read())
                    {
                        ServerInfo.mySQLConnect.Close();
                       AdminModule AdMod = new AdminModule();
                        this.Hide();
                        AdMod.Show();
                    }
                    else
                    {
                        ServerInfo.mySQLConnect.Close();
                        MessageBox.Show("Sorry, input DID NOT match with the database\n" +
                            "Application Will now Close", "Wrong Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        this.Close();
                    }
                }

                else if (RadioTeach.Checked == true)
                {
                    MSQLC.CommandText = "Select * from sms.teacherusermaster " +
                            "where teachname = '" + UsernameBox.Text + "' and teachpassword = '" + PasswordBox.Text + "'";
                    MSQLC.Connection = ServerInfo.mySQLConnect;
                    MySqlDataReader Read = MSQLC.ExecuteReader();
                    if (Read.Read())
                    {
                        ServerInfo.mySQLConnect.Close();
                       TeacherModule TeachMod = new TeacherModule();
                        this.Hide();
                        TeachMod.Show();
                    }
                    else
                    {
                        ServerInfo.mySQLConnect.Close();
                        MessageBox.Show("Sorry, input DID NOT match with the database\n" +
                            "Application Will now Close", "Wrong Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        this.Close();
                    }
                }

                else if (RadioStudent.Checked == true)
                {
                    MSQLC.CommandText = "Select * from sms.studentusermaster " +
                            "where studname = '" + UsernameBox.Text + "' and studpass = '" + PasswordBox.Text + "'";
                    MSQLC.Connection = ServerInfo.mySQLConnect;
                    MySqlDataReader Read = MSQLC.ExecuteReader();
                    if (Read.Read())
                    {
                        ServerInfo.mySQLConnect.Close();
                        StudentModule StudMod = new StudentModule();
                        this.Hide();
                        StudMod.Show();
                    }
                    else
                    {
                        ServerInfo.mySQLConnect.Close();
                        MessageBox.Show("Sorry, input DID NOT match with the database\n" +
                            "Application Will now Close", "Wrong Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        this.Close();
                    }
                }

                else
                {
                    MessageBox.Show("You must select one login category and then try again",
                        "No Category Selected", MessageBoxButtons.RetryCancel,
                        MessageBoxIcon.Hand);
                    UsernameBox.Clear();
                    PasswordBox.Clear();
                }
            }

            catch (MySqlException Exception)
            {
                MessageBox.Show(Exception.Message,"Error Occurred", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void RegsiterClick(object sender, EventArgs e)
        {
            this.Hide();
            RegistrationModule RegMod = new RegistrationModule();
            RegMod.Show();
        }

        private void ForgotPassClick(object sender, EventArgs e)
        {
            this.Hide();
            ForgotPasswordModule ForgePassMod = new ForgotPasswordModule();
            ForgePassMod.Show();
        }
    }
}
