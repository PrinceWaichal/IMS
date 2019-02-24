using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace SMS_0._1
{
    public partial class RegistrationModule : SMS_0._1.BaseFormApplication
    {
        public RegistrationModule()
        {
            InitializeComponent();
        }

        private void RegModLoad(object sender, EventArgs e)
        {
            tbLastNam.Focus();
        }

        public new bool Validate()
        {
            int pin = Convert.ToInt32(PinCodeTextBox.Text);
            int mobile = Convert.ToInt32(MobileTextBox.Text);
            int aadhar = Convert.ToInt32(tbAddharNo.Text);

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
            else if (DateofBirth.Value == DateTime.Today)
            {
                MessageBox.Show("Forgot to Enter Birth Date?", "Wrong Birth Date"
                    , MessageBoxButtons.YesNo, MessageBoxIcon.Hand);
                return false;
            }
            else if (GenderCombo.Text == "Select" || GenderCombo.Text == "")
            {
                MessageBox.Show("Forgot to Select Gender?", "Gender Error"
                    , MessageBoxButtons.YesNo, MessageBoxIcon.Hand);
                return false;
            }
            else if (AddressBox.Text == "" || AddressBox.TextLength > 6)
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
            else if (pin != 6)
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
            else if (mobile != 10)
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

            else if (cbGraduDetails.Text == "Select" || cbGraduDetails.Text == "")
            {
                MessageBox.Show("Forgot to Select Graduation University?", "Graduation University Error"
                    , MessageBoxButtons.YesNo, MessageBoxIcon.Hand);
                return false;
            }
            else if (cbCollege.Text == "Select" || cbCollege.Text == "")
            {
                MessageBox.Show("Forgot to Select Graduation School?", "Graudation School Error"
                    , MessageBoxButtons.YesNo, MessageBoxIcon.Hand);
                return false;
            }
            else if (tbPContactNo.Text == "")
            {
                MessageBox.Show("Did you forget to enter Parent's Mobile?", "Parent Contact Error",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Hand);
                return false;
            }
            else if (aadhar != 12)
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

        private void SubmitClick(object sender, EventArgs e)
        {
            ServerInfo.mySQLConnect.Open();
            try
            {
                if (rbutTeacher.Checked == true)
                {
                    if (Validate())
                    {

                    }
                    else
                    {
                        MessageBox.Show("You have not entered valid details", "Invalid Input"
                            , MessageBoxButtons.RetryCancel, MessageBoxIcon.Exclamation);
                    }
                }
                else if (rbutStudent.Checked == true)
                {
                    if (Validate())
                    {

                    }
                    else
                    {
                        MessageBox.Show("You have not entered valid details", "Invalid Input"
                            , MessageBoxButtons.RetryCancel, MessageBoxIcon.Exclamation);
                    }
                }
                else
                {
                    MessageBox.Show("Registration Type Not Selected", "Unknown Category",
                        MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    rbutTeacher.Focus();
                    ServerInfo.mySQLConnect.Close();
                }
            }
            catch (MySqlException error)
            {
                MessageBox.Show(error.Message, "Unexpcted Event Occurred",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                ServerInfo.mySQLConnect.Close();
            }
        }

        private void BackClick(object sender, EventArgs e)
        {
            ServerInfo.mySQLConnect.Close();
            this.Hide();
            LoginModule LogMod = new _1.LoginModule();
            LogMod.Show();
        }
    }
}
