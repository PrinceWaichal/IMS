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

        private void LoginIndexChange(object sender, EventArgs e)
        {
            if(LoginBox.Text == "Admin Login")
            {
                LoginModule.AdminLoginModule AdLog = new LoginModule.AdminLoginModule();
                this.Hide();
                AdLog.Show();
            }
            else if(LoginBox.Text == "Student Login")
            {
                LoginModule.StudentLoginModule StudLog = new LoginModule.StudentLoginModule();
                this.Hide();
                StudLog.Show();
            }
            else if(LoginBox.Text == "Teacher Login")
            {
                LoginModule.TeacherLoginModule TeachLogin = new LoginModule.TeacherLoginModule();
                this.Hide();
                TeachLogin.Show();
            }
            else
            {
                MessageBox.Show("Looks like you have made a wrong selection", "Wrong Selection",
                    MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void RegIndecChange(object sender, EventArgs e)
        {
            if (RegistrationBox.Text == "Student Registration")
            {
                RegistrationModule.StudentRegistrationModule StudReg = new RegistrationModule.StudentRegistrationModule();
                this.Hide();
                StudReg.Show();
            }
            else if (RegistrationBox.Text == "Teacher Registration")
            {
                RegistrationModule.TeacherRegistrationModule TeachMod = new RegistrationModule.TeacherRegistrationModule();
                this.Hide();
                TeachMod.Show();
            }
            else
            {
                MessageBox.Show("Looks like you have made a wrong selection", "Wrong Selection",
                    MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }
    }
}
