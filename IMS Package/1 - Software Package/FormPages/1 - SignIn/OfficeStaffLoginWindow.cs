using System;
using System.Windows.Forms;
using System.Data;
using MySql.Data.MySqlClient;

namespace _1___Software_Package.FormPages._1___SignIn
{
    public partial class OfficeStaffLoginWindow : Form
    {
        public OfficeStaffLoginWindow()
        {
            InitializeComponent();
        }

        private void OSAdminLogin(object sender, EventArgs e)
        {
            this.Hide();
            FormPages._1___SignIn.AdminLoginWindow AdminLogin = new AdminLoginWindow();
            AdminLogin.Show();
        }

        private void OSStudLogin(object sender, EventArgs e)
        {
            this.Hide();
            FormPages._1___SignIn.StudentLoginWindow StudLogin = new StudentLoginWindow();
            StudLogin.Show();
        }

        private void OSTeachLogin(object sender, EventArgs e)
        {
            this.Hide();
            FormPages._1___SignIn.TeachersLoginWindow TeachLogin = new TeachersLoginWindow();
            TeachLogin.Show();
        }

        private void OSOfficeLogin(object sender, EventArgs e)
        {
            this.Hide();
            FormPages._1___SignIn.OfficeStaffLoginWindow OfficeLogin = new OfficeStaffLoginWindow();
            OfficeLogin.Show();
        }

        private void OSLibLogin(object sender, EventArgs e)
        {
            this.Hide();
            FormPages._1___SignIn.LibraryStaffLogin LibLogin = new LibraryStaffLogin();
            LibLogin.Show();
        }

        private void OSSignUp(object sender, EventArgs e)
        {
            this.Hide();
            FormPages.SignUp_PrimaryDetails SignUp = new SignUp_PrimaryDetails();
            SignUp.Show();
        }

        private void OSLogin(object sender, EventArgs e)
        {
            //Do Validation
            if (OfcID.Text == "")
            {
                MessageBox.Show("You have not entered Username");
                OfcID.Focus();
            }

            else if (OfcPass.Text == "")
            {
                MessageBox.Show("You have not entered Password");
                OfcPass.Focus();
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
                    MySQLCommand.CommandText = "Select count(*) from UserMaster Where UserName = ' " + OfcID.Text + " ' " +
                        "and UserPassword = ' " + OfcPass.Text + " ' ";
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
