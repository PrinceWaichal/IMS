using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace _1___Software_Package.FormPages._1___SignIn
{
    public partial class AdminLoginWindow : Form
    {
        public AdminLoginWindow()
        {
            InitializeComponent();
        }
        
        private void LibLogin(object sender, EventArgs e)
        {
            this.Hide();
            FormPages._1___SignIn.LibraryStaffLogin LibLogin = new LibraryStaffLogin();
            LibLogin.Show();
        }

        private void SignUp(object sender, EventArgs e)
        {
            this.Hide();
            FormPages.SignUp_PrimaryDetails SignUp = new SignUp_PrimaryDetails();
            SignUp.Show();
        }

        private void ALAdminLogin(object sender, EventArgs e)
        {
            this.Hide();
            FormPages._1___SignIn.AdminLoginWindow AdminLogin = new AdminLoginWindow();
            AdminLogin.Show();
        }

        private void ALStudLogin(object sender, EventArgs e)
        {
            this.Hide();
            FormPages._1___SignIn.StudentLoginWindow StudLogin = new StudentLoginWindow();
            StudLogin.Show();
        }

        private void ALTeachLogin(object sender, EventArgs e)
        {
            this.Hide();
            FormPages._1___SignIn.TeachersLoginWindow TeachLogin = new TeachersLoginWindow();
            TeachLogin.Show();
        }

        private void ALOfficeLogin(object sender, EventArgs e)
        {
            this.Hide();
            FormPages._1___SignIn.OfficeStaffLoginWindow OfficeLogin = new OfficeStaffLoginWindow();
            OfficeLogin.Show();
        }

        private void AdminSignIn(object sender, EventArgs e)
        {
            //Do Validatation
            try
            {
                ServerInfo.MySQLConnect.Open();
                ServerInfo.MySQLCommand.Connection = ServerInfo.MySQLConnect;
                ServerInfo.MySQLCommand.CommandText = "Select * from usermaster";
                MessageBox.Show("Successful Connection");
            }
            catch
            {
                MessageBox.Show("Failed to Connect");
            }
            finally
            {
                ServerInfo.MySQLConnect.Close();
            }
        }
    }
}
