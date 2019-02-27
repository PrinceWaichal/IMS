using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data.SqlClient;

namespace AttendanceManagementSystem.RegistrationModule
{
    public partial class RegistrationModule : AttendanceManagementSystem.BaseFormApp
    {
        public RegistrationModule()
        {
            InitializeComponent();
        }

        SqlCommand mysqlcom = new SqlCommand();

        public static int ID()
        {
            SqlCommand sqlcom = new SqlCommand();
            Int32 count=201900001;

            sqlcom.CommandText = "Select Max(Id) from dbo.UserMaster";

            try
            {
                ServerInfo.Connect.Open();
                sqlcom.Connection = ServerInfo.Connect;
                count = (Int32) sqlcom.ExecuteScalar();
                count++;
            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message, "Connection Error",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            finally
            {
                ServerInfo.Connect.Close();
            }
            return count;
        }

        public new bool Validate()
        {
            if (UserTypeCombo.Text == "Teacher")
            {
                if (cbGraduDetails.Text == "Select" || cbGraduDetails.Text == "")
                {
                    MessageBox.Show("Forgot to Select Graduation University?", "Graduation University Error"
                        , MessageBoxButtons.YesNo, MessageBoxIcon.Hand);
                    return false;
                }

                else if (cbCollege.Text == "Select" || cbCollege.Text == "")
                {
                    MessageBox.Show("Forgot to Select Graduation Institution?", "Graduation Institution Error"
                        , MessageBoxButtons.YesNo, MessageBoxIcon.Hand);
                    return false;
                }
            }

            else if (UserTypeCombo.Text == "Student")
            {
                if (CourseCombo.Text == "Select" || CourseCombo.Text == "")
                {
                    MessageBox.Show("Forgot to Select Course?", "Course Error"
                        , MessageBoxButtons.YesNo, MessageBoxIcon.Hand);
                    return false;
                }
            }

            if (tbLastNam.Text == "Last Name" || tbLastNam.Text == "")
            {
                MessageBox.Show("Forgot to Enter Last Name?", "Missing Last Name"
                    , MessageBoxButtons.YesNo, MessageBoxIcon.Hand);
                return false;
            }

            else if (tbFirstName.Text == "First Name" || tbFirstName.Text == "")
            {
                MessageBox.Show("Forgot to Enter First Name?", "Missing First Name"
                    , MessageBoxButtons.YesNo, MessageBoxIcon.Hand);
                return false;
            }

            else if (tbMiddleName.Text == "Middle Name" || tbMiddleName.Text == "")
            {
                MessageBox.Show("Forgot to Enter Middle Name?", "Missing Middle Name"
                    , MessageBoxButtons.YesNo, MessageBoxIcon.Hand);
                return false;
            }

            else if (GenderCombo.Text == "Select" || GenderCombo.Text == "")
            {
                MessageBox.Show("Forgot to Select Gender?", "Gender Error"
                    , MessageBoxButtons.YesNo, MessageBoxIcon.Hand);
                return false;
            }

            else if (AddressBox.Text == "" || AddressBox.TextLength < 6)
            {
                MessageBox.Show("Forgot to Enter Address?", "Address Error"
                    , MessageBoxButtons.YesNo, MessageBoxIcon.Hand);
                return false;
            }

            else if (CityBox.Text == "")
            {
                MessageBox.Show("Forgot to Enter City?", "City Error"
                    , MessageBoxButtons.YesNo, MessageBoxIcon.Hand);
                return false;
            }

            else if (PinCodeTextBox.TextLength != 6)
            {
                MessageBox.Show("Forgot to Enter PIN or Wrongly Entered?", "PIN Error"
                    , MessageBoxButtons.YesNo, MessageBoxIcon.Hand);
                return false;
            }

            else if (StateTextBox.Text == "")
            {
                MessageBox.Show("Forgot to Enter State?", "State Error"
                    , MessageBoxButtons.YesNo, MessageBoxIcon.Hand);
                return false;
            }

            else if (MobileTextBox.TextLength != 10)
            {
                MessageBox.Show("Forgot to Enter Mobile or Wrongly Entered?", "Mobile Error"
                    , MessageBoxButtons.YesNo, MessageBoxIcon.Hand);
                return false;
            }

            else if (cbSSC_University.Text == "Select" || cbSSC_University.Text == "")
            {
                MessageBox.Show("Forgot to Select SSC University?", "SSC University Error"
                    , MessageBoxButtons.YesNo, MessageBoxIcon.Hand);
                return false;
            }

            else if (cbSSC_School.Text == "Select" || cbSSC_School.Text == "")
            {
                MessageBox.Show("Forgot to Select SSC School?", "SSC School Error"
                    , MessageBoxButtons.YesNo, MessageBoxIcon.Hand);
                return false;
            }

            else if (cbHSCuniversity.Text == "Select" || cbHSCuniversity.Text == "")
            {
                MessageBox.Show("Forgot to Select HSC University?", "HSC University Error"
                    , MessageBoxButtons.YesNo, MessageBoxIcon.Hand);
                return false;
            }

            else if (cbHSC_School.Text == "Select" || cbHSC_School.Text == "")
            {
                MessageBox.Show("Forgot to Select HSC School?", "HSC School Error"
                    , MessageBoxButtons.YesNo, MessageBoxIcon.Hand);
                return false;
            }

            else if (tbPContactNo.TextLength != 10)
            {
                MessageBox.Show("Did you forget to enter Parent's Mobile?", "Parent Contact Error",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Hand);
                return false;
            }

            else if (tbAddharNo.TextLength != 12)
            {
                MessageBox.Show("Did you forget to enter Valid Aadhar?", "Aadhar Number Error",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Hand);
                return false;
            }

            else if (cbCategory.Text == "Select" || cbCategory.Text == "")
            {
                MessageBox.Show("Did you forget to select Category?", "Category Error",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Hand);
                return false;
            }

            else if (cbMarried.Text == "Select" || cbMarried.Text == "")
            {
                MessageBox.Show("Did you forget to select Married Status?", "Married Error",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Hand);
                return false;
            }

            else if (cbRelig.Text == "Select" || cbRelig.Text == "")
            {
                MessageBox.Show("Did you forget to select Religion?", "Religion Error",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Hand);
                return false;
            }

            

            else
                return true;
        }

        private void UserTypeIndexChange(object sender, EventArgs e)
        {
            if (UserTypeCombo.Text == "Student")
            {
                CourseCombo.Enabled = true;
                cbGraduDetails.Enabled = false;
                cbCollege.Enabled = false;
            }
            else if (UserTypeCombo.Text == "Teacher")
            {
                cbGraduDetails.Enabled = true;
                cbCollege.Enabled = true;
                CourseCombo.Enabled = false;
            }
            else
            {
                MessageBox.Show("You must select a user type", "Invalid User Type",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void BackClick(object sender, EventArgs e)
        {
            ServerInfo.Connect.Close();
            BaseFormApp BFA = new BaseFormApp();
            BFA.Show();
        }

        private void SubmitClick(object sender, EventArgs e)
        {
            int id = ID();

            if (Validate())
            {
                mysqlcom.CommandType = CommandType.Text;
                try
                {
                    ServerInfo.Connect.Open();
                    mysqlcom.Connection = ServerInfo.Connect;

                    if (UserTypeCombo.Text == "Teacher")
                    {
                        mysqlcom.CommandText = "INSERT INTO UserMaster values('"+id+"', " +
                        "'" + tbLastNam.Text + "', ' " + tbFirstName.Text + " ', ' " + tbMiddleName.Text + " ' ," +
                        " '" + GenderCombo.Text + "', '" + AddressBox.Text + "', '" + CityBox.Text + "', " +
                        "'" + PinCodeTextBox.Text + "','" + StateTextBox.Text + "','" + MobileTextBox.Text + "'," +
                        "'" + EmailBox.Text + "', '" + cbSSC_University.Text + "', '" + cbSSC_School.Text + "'," +
                        "'" + cbHSCuniversity.Text + "','" + cbHSC_School.Text + "', '" + cbGraduDetails.Text + "'," +
                        "'" + cbCollege.Text + "', '" + tbPContactNo.Text + "', '" + tbAddharNo.Text + "', " +
                        "'" + cbMarried.Text + "', '" + cbPhysicalDisab.Text + "', '" + cbCategory.Text + "'," +
                        "'" + cbRelig.Text + "', '', '', '', 'Teacher',''" +
                        ")";
                    }
                    else
                    {
                        mysqlcom.CommandText = "INSERT INTO UserMaster values('"+id+"'," +
                        " '" + tbLastNam.Text + "', ' " + tbFirstName.Text + " ', ' " + tbMiddleName.Text + " ' ," +
                        " '" + GenderCombo.Text + "', '" + AddressBox.Text + "', '" + CityBox.Text + "', " +
                        " '" + PinCodeTextBox.Text + "','" + StateTextBox.Text + "','" + MobileTextBox.Text + "'," +
                        " '" + EmailBox.Text + "', '" + cbSSC_University.Text + "', '" + cbSSC_School.Text + "'," +
                        " '" + cbHSCuniversity.Text + "','" + cbHSC_School.Text + "', ''," +
                        " '', '" + tbPContactNo.Text + "', '" + tbAddharNo.Text + "', " +
                        " '" + cbMarried.Text + "', '" + cbPhysicalDisab.Text + "', '" + cbCategory.Text + "'," +
                        " '" + cbRelig.Text + "', ' " + CourseCombo.Text + " ','', '','Student',''" +
                        ")";
                    }
                    mysqlcom.ExecuteNonQuery();

                    PasswordCreateModule PassMod = new PasswordCreateModule();
                    PassMod.Show();
                }
                catch (SqlException error)
                {
                    MessageBox.Show(error.Message, "Connection Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                }
                finally
                {
                    ServerInfo.Connect.Close();
                    this.Hide();
                }
            }
            else
            {
                MessageBox.Show("Details Validation Failed", "Internal Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void RegistrationModule_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'aMSDBDataSet.CourseTable' table. You can move, or remove it, as needed.
            this.courseTableTableAdapter.Fill(this.aMSDBDataSet.CourseTable);

        }
    }
}
