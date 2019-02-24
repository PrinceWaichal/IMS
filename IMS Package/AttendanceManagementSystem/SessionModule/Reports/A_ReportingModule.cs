using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AttendanceManagementSystem.SessionModule.Reports
{
    public partial class A_ReportingModule : AttendanceManagementSystem.BaseFormApp
    {
        public A_ReportingModule()
        {
            InitializeComponent();
        }

        private void AddClick(object sender, EventArgs e)
        {
            ServerInfo.Connect.Close();
            SessionModule.AddMenu.AddMenuModule AdMod = new AddMenu.AddMenuModule();
            this.Hide();
            AdMod.Show();
        }

        private void EntryClick(object sender, EventArgs e)
        {
            ServerInfo.Connect.Close();
            SessionModule.DataEntry.A_AddAttendance Entry = new DataEntry.A_AddAttendance();
            this.Hide();
            Entry.Show();
        }

        private void ModifyClick(object sender, EventArgs e)
        {
            ServerInfo.Connect.Close();
            SessionModule.DataEntry.ModifyAttendance ModAttend = new DataEntry.ModifyAttendance();
            this.Hide();
            ModAttend.Show();
        }

        private void ReportsClick(object sender, EventArgs e)
        {
            ServerInfo.Connect.Close();
            SessionModule.Reports.A_ReportingModule RepMod = new Reports.A_ReportingModule();
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
