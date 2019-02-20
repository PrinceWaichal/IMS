using System;
using System.Windows.Forms;
using System.Data;
using MySql.Data.MySqlClient;

namespace _1___Software_Package.FormPages._1___SignIn
{
    public partial class StudentLoginWindow : Form
    {
        public StudentLoginWindow()
        {
            InitializeComponent();
        }

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
            if (StudID.Text == "")
            {
                MessageBox.Show("You have not entered Username");
                StudID.Focus();
            }

            else if (StudPass.Text == "")
            {
                MessageBox.Show("You have not entered Password");
                StudPass.Focus();
            }

            else
            {
                try
                {
                    //Opening Connection
                    ServerInfo.MySQLConnect.Open();

                    //Creating objects
                    MySqlCommand MySQLCommand = new MySqlCommand();

                    //Connecting the Command
                    MySQLCommand.Connection = ServerInfo.MySQLConnect;

                    //Passing MySQL Statement
                    MySQLCommand.CommandText = "Select count(*) from UserMaster Where UserName = ' " + StudID.Text + " ' " +
                        "and UserPassword = ' " + StudPass.Text + " ' ";
                    MySQLCommand.ExecuteNonQuery();

                    MySqlDataAdapter MySQLDataAdapt = new MySqlDataAdapter(MySQLCommand);

                    //Creating a new Data Table
                    DataTable DatTable = new DataTable();

                    MySQLDataAdapt.Fill(DatTable);

                    int i = Convert.ToInt32(DatTable.Rows.Count.ToString());

                    if (i == 0)
                    {
                        MessageBox.Show("Wrong Input");
                    }
                    else
                    {
                        this.Hide();
                        _3___DataEntry.DataEntry_Activities dataEntry_Act = new _3___DataEntry.DataEntry_Activities();
                        dataEntry_Act.Show();
                    }
                    // MessageBox.Show("Successful Connection");
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
}
