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
    public partial class RegistrationModule : SMS_0._1.BaseFormApplication
    {
        public RegistrationModule()
        {
            InitializeComponent();
        }

        private void RegModLoad(object sender, EventArgs e)
        {
            tbLastNam.Focus();
            ServerInfo.mySQLConnect.Open();
        }

        private void SubmitClick(object sender, EventArgs e)
        {
            if (rbutTeacher.Checked == true)
            {

            }
            else if (rbutStudent.Checked == true)
            {

            }
            else
            {
                MessageBox.Show("Registration Type Not Selected", "Unknown Category",
                    MessageBoxButtons.OK, MessageBoxIcon.Hand);
                rbutTeacher.Focus();
            }
        }

        private void BackClick(object sender, EventArgs e)
        {
            this.Hide();
            LoginModule LogMod = new _1.LoginModule();
            LogMod.Show();
        }
    }
}
