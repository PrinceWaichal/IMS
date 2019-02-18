using System;
using System.Windows.Forms;
using System.Data;
using MySql.Data.MySqlClient;

namespace _1___Software_Package.FormPages._1___SignIn
{
    public partial class LibraryStaffLogin : Form
    {
        public LibraryStaffLogin()
        {
            InitializeComponent();
        }

        private void LSAdminLogin(object sender, EventArgs e)
        {
            this.Hide();
            FormPages._1___SignIn.AdminLoginWindow AdminLogin = new AdminLoginWindow();
            AdminLogin.Show();
        }

        private void LSStudLogin(object sender, EventArgs e)
        {
            this.Hide();
            FormPages._1___SignIn.StudentLoginWindow StudLogin = new StudentLoginWindow();
            StudLogin.Show();
        }

        private void LSTeachLogin(object sender, EventArgs e)
        {
            this.Hide();
            FormPages._1___SignIn.TeachersLoginWindow TeachLogin = new TeachersLoginWindow();
            TeachLogin.Show();
        }

        private void LSOfficeLogin(object sender, EventArgs e)
        {
            this.Hide();
            FormPages._1___SignIn.OfficeStaffLoginWindow OfficeLogin = new OfficeStaffLoginWindow();
            OfficeLogin.Show();
        }

        private void LSLibLogin(object sender, EventArgs e)
        {
            this.Hide();
            FormPages._1___SignIn.LibraryStaffLogin LibLogin = new LibraryStaffLogin();
            LibLogin.Show();
        }

        private void LSSignUp(object sender, EventArgs e)
        {
            this.Hide();
            FormPages.SignUp_PrimaryDetails SignUp = new SignUp_PrimaryDetails();
            SignUp.Show();
        }

        private void LSLogin(object sender, EventArgs e)
        {
            //Do Validation
            //Do Validatation
            if (LibID.Text == "")
            {
                MessageBox.Show("You have not entered Username");
                LibID.Focus();
            }

            else if (LibPass.Text == "")
            {
                MessageBox.Show("You have not entered Password");
                LibPass.Focus();
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
                    MySQLCommand.CommandText = "Select count(*) from UserMaster Where UserName = ' " + LibID.Text + " ' " +
                        "and UserPassword = ' " + LibPass.Text + " ' ";
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
                        _3___DataEntry.DataEntry_Marks dataEntry_Marks = new _3___DataEntry.DataEntry_Marks();
                        dataEntry_Marks.Show();
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
