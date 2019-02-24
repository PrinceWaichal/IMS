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

            }
            else if(LoginBox.Text == "Student Login")
            {

            }
            else if(LoginBox.Text == "Teacher Login")
            {

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

            }
            else if (RegistrationBox.Text == "Teacher Registration")
            {
            }
            else
            {
                MessageBox.Show("Looks like you have made a wrong selection", "Wrong Selection",
                    MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }
    }
}
