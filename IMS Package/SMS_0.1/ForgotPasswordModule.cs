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
    public partial class ForgotPasswordModule : SMS_0._1.BaseFormApplication
    {
        public ForgotPasswordModule()
        {
            InitializeComponent();
        }

        private void ForgotPasswordModule_Load(object sender, EventArgs e)
        {
            UsernameBox.Focus();
            ServerInfo.mySQLConnect.Open();
        }

        private void CheckClick(object sender, EventArgs e)
        {
            MySqlCommand mySQLCommand = new MySqlCommand();

        }

        private void ResetClick(object sender, EventArgs e)
        {

        }

        private void RegisterClick(object sender, EventArgs e)
        {
            this.Hide();
            RegistrationModule RegMod = new RegistrationModule();
            RegMod.Show();
        }
    }
}
