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
        }

        MySqlCommand MSQLC = new MySqlCommand();

        private void LoginClick(object sender, EventArgs e)
        {
            if(RadioAdmin.Checked == true)
            {
                ServerInfo.mySQLConnect.Open();
                MSQLC.CommandText = "Select * from sms.adminusermaster " +
                        "where adminname = '" + UsernameBox.Text + "' and adminpass = '" + PasswordBox.Text + "'";
                MSQLC.Connection = ServerInfo.mySQLConnect;
                MySqlDataReader Read = MSQLC.ExecuteReader();
                if (Read.Read())
                {
                    ServerInfo.mySQLConnect.Close();
                 //   ReportsModule RepMod = new ReportsModule();
                    this.Hide();
                  //  RepMod.Show();
                }
                else
                {
                    ServerInfo.mySQLConnect.Close();
                    MessageBox.Show("Sorry, input DID NOT match with the database\n" +
                        "Application Will now Close", "Wrong Input",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    this.Close();
                }
            }

            else if(RadioTeach.Checked == true)
            {
                ServerInfo.mySQLConnect.Open();
                MSQLC.CommandText = "Select * from sms.teacherusermaster " +
                        "where adminname = '" + UsernameBox.Text + "' and adminpass = '" + PasswordBox.Text + "'";
                MSQLC.Connection = ServerInfo.mySQLConnect;
                MySqlDataReader Read = MSQLC.ExecuteReader();
                if (Read.Read())
                {
                    ServerInfo.mySQLConnect.Close();
                 //   ReportsModule RepMod = new ReportsModule();
                    this.Hide();
                //    RepMod.Show();
                }
                else
                {
                    ServerInfo.mySQLConnect.Close();
                    MessageBox.Show("Sorry, input DID NOT match with the database\n" +
                        "Application Will now Close", "Wrong Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                }
            }

            else if(RadioStudent.Checked == true)
            {
                ServerInfo.mySQLConnect.Open();
                MSQLC.CommandText = "Select * from sms.studentusermaster " +
                        "where adminname = '" + UsernameBox.Text + "' and adminpass = '" + PasswordBox.Text + "'";
                MSQLC.Connection = ServerInfo.mySQLConnect;
                MySqlDataReader Read = MSQLC.ExecuteReader();
                if (Read.Read())
                {
                    ServerInfo.mySQLConnect.Close();
              //      ReportsModule RepMod = new ReportsModule();
                    this.Hide();
                //    RepMod.Show();
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
