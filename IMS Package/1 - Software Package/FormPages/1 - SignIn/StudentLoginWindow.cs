using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace _1___Software_Package.FormPages._1___SignIn
{
    public partial class StudentLoginWindow : Form
    {
        public StudentLoginWindow()
        {
            InitializeComponent();
        }

        MySqlConnection mySQLConnection = new
                MySqlConnection("server=localhost;user id=root;password=root;" +
             "persistsecurityinfo=True;database=MastersSchema");

        private void SLAdminLogin(object sender, EventArgs e)
        {
            this.Hide();
            FormPages._1___SignIn.AdminLoginWindow AdminLogin = new AdminLoginWindow();
            AdminLogin.Show();
        }

        private void SLStudLogin(object sender, EventArgs e)
        {
            this.Hide();
            FormPages._1___SignIn.StudentLoginWindow StudLogin = new StudentLoginWindow();
            StudLogin.Show();
        }

        private void SLTeachLogin(object sender, EventArgs e)
        {
            this.Hide();
            FormPages._1___SignIn.TeachersLoginWindow TeachLogin = new TeachersLoginWindow();
            TeachLogin.Show();
        }

        private void SLOfficeLogin(object sender, EventArgs e)
        {
            this.Hide();
            FormPages._1___SignIn.OfficeStaffLoginWindow OfficeLogin = new OfficeStaffLoginWindow();
            OfficeLogin.Show();
        }

        private void SLLibLogin(object sender, EventArgs e)
        {
            this.Hide();
            FormPages._1___SignIn.LibraryStaffLogin LibLogin = new LibraryStaffLogin();
            LibLogin.Show();
        }

        private void SLSignUp(object sender, EventArgs e)
        {
            this.Hide();
            FormPages.SignUp_PrimaryDetails SignUp = new SignUp_PrimaryDetails();
            SignUp.Show();
        }

        private void SLLoginButton(object sender, EventArgs e)
        {
            //Do Validation
            try
            {
                mySQLConnection.Open();
                MessageBox.Show("Successful Connection");
            }
            catch
            {
                MessageBox.Show("Failed to Connect");
            }
        }
    }
}
