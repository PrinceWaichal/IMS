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
    public partial class StudentModule : SMS_0._1.BaseFormApplication
    {
        public StudentModule()
        {
            InitializeComponent();
        }

        private void LogOutClick(object sender, EventArgs e)
        {
            ServerInfo.mySQLConnect.Close();
            this.Hide();
            BaseFormApplication Home = new BaseFormApplication();
            Home.Show();
        }

        private void ReportsClick(object sender, EventArgs e)
        {
            this.Hide();
            ReportModule RepMod = new ReportModule();
            RepMod.Show();
        }

        private void StudModLoad(object sender, EventArgs e)
        {

        }
    }
}
