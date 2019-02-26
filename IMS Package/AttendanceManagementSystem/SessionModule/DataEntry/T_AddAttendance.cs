using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace AttendanceManagementSystem.SessionModule.DataEntry
{
    public partial class T_AddAttendance : AttendanceManagementSystem.BaseFormApp
    {
        public T_AddAttendance()
        {
            InitializeComponent();
        }

        private void EntryClick(object sender, EventArgs e)
        {
            ServerInfo.Connect.Close();
            SessionModule.DataEntry.T_AddAttendance EntryMod = new DataEntry.T_AddAttendance();
            this.Hide();
            EntryMod.Show();
        }

        private void ReportsClick(object sender, EventArgs e)
        {
            ServerInfo.Connect.Close();
            SessionModule.Reports.T_ReportingModule RepMod = new Reports.T_ReportingModule();
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
