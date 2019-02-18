using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data;

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
            if (AdminID.Text=="")
            {
                MessageBox.Show("You have not entered Username");
                AdminID.Focus();
            }

            else if(AdminPass.Text == "")
            {
                MessageBox.Show("You have not entered Password");
                AdminPass.Focus();
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
                    MySQLCommand.CommandText = "Select count(*) from UserMaster Where UserName = ' " + AdminID.Text + " ' " +
                        "and UserPassword = ' " + AdminPass.Text + " ' ";
                    MySQLCommand.ExecuteNonQuery();

                    MySqlDataAdapter MySQLDataAdapt = new MySqlDataAdapter(MySQLCommand);

                    //Creating a new Data Table
                    DataTable DatTable = new DataTable();

                    MySQLDataAdapt.Fill(DatTable);

                    int i = Convert.ToInt32(DatTable.Rows.Count.ToString());

                    if(i == 0)
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
        
        private void OnLoadSetFocus(object sender, EventArgs e)
        {
            AdminID.Focus();
        }
    }
}
