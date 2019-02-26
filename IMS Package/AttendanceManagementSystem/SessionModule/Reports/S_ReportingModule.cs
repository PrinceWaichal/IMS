using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace AttendanceManagementSystem.SessionModule.Reports
{
    public partial class S_ReportingModule : AttendanceManagementSystem.BaseFormApp
    {
        public S_ReportingModule()
        {
            InitializeComponent();
        }

        private void ReportsClick(object sender, EventArgs e)
        {
            ServerInfo.Connect.Close();
            SessionModule.Reports.S_ReportingModule RepMod = new S_ReportingModule();
            this.Hide();
            RepMod.Show();
        }

        private void LogoutClick(object sender, EventArgs e)
        {
            ServerInfo.Connect.Close();
            BaseFormApp BFA = new BaseFormApp();
            this.Hide();
            BFA.Show();
        }
    }
}
