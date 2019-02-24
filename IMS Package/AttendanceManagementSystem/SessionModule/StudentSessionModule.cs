using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AttendanceManagementSystem.SessionModule
{
    public partial class StudentSessionModule : AttendanceManagementSystem.BaseFormApp
    {
        public StudentSessionModule()
        {
            InitializeComponent();
        }

        private void LogoutClick(object sender, EventArgs e)
        {
            ServerInfo.Connect.Close();
            BaseFormApp BFA = new BaseFormApp();
            this.Hide();
            BFA.Show();
        }

        private void ReportsClick(object sender, EventArgs e)
        {
            ServerInfo.Connect.Close();
            SessionModule.Reports.S_ReportingModule RepMod = new Reports.S_ReportingModule();
            this.Hide();
            RepMod.Show();
        }
    }
}
