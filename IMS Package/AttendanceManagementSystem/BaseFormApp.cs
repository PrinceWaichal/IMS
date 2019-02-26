using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace AttendanceManagementSystem
{
    public partial class BaseFormApp : Form
    {
        public BaseFormApp()
        {
            InitializeComponent();
        }

        private void LoginClick(object sender, EventArgs e)
        {
            this.Hide();
            LoginModule.LoginModule LogMod = new LoginModule.LoginModule();
            LogMod.Show();
        }

        private void RegisterClick(object sender, EventArgs e)
        {
            this.Hide();
            RegistrationModule.RegistrationModule RegMod = new RegistrationModule.RegistrationModule();
            RegMod.Show();
        }
    }
}
