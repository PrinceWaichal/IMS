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

        private bool Validate()
        {

        }

        private void SubmitClick(object sender, EventArgs e)
        {
            ServerInfo.mySQLConnect.Open();
            if (rbutTeacher.Checked == true)
            {
                if(Validate)
                {

                }
                else
                {
                    MessageBox.Show("You have not entered valid details","Invalid Input"
                        , MessageBoxButtons.RetryCancel, MessageBoxIcon.Exclamation);
                }
            }
            else if (rbutStudent.Checked == true)
            {
                if(Validate)
                {
                    int pin = Convert.ToInt32(PinCodeTextBox.Text);
                    int mobile = Convert.ToInt32(MobileTextBox.Text);

                    if(tbLastNam.Text == "Last Name" || tbLastNam.Text == "")
                    {
                        MessageBox.Show("Forgot to Enter Last Name?", "Missing Last Name"
                            , MessageBoxButtons.YesNo, MessageBoxIcon.Hand);
                    }
                    else if(tbFirstName.Text == "First Name" || tbFirstName.Text == "")
                    {
                        MessageBox.Show("Forgot to Enter First Name?", "Missing First Name"
                            , MessageBoxButtons.YesNo, MessageBoxIcon.Hand);
                    }
                    else if (tbMiddleName.Text == "Middle Name" || tbMiddleName.Text == "")
                    {
                        MessageBox.Show("Forgot to Enter Middle Name?", "Missing Middle Name"
                            , MessageBoxButtons.YesNo, MessageBoxIcon.Hand);
                    }
                    else if (DateofBirth.Value == DateTime.Today)
                    {
                        MessageBox.Show("Forgot to Enter Birth Date?", "Wrong Birth Date"
                            , MessageBoxButtons.YesNo, MessageBoxIcon.Hand);
                    }
                    else if (GenderCombo.Text == "Select" || GenderCombo.Text == "")
                    {
                        MessageBox.Show("Forgot to Select Gender?", "Gender Error"
                            , MessageBoxButtons.YesNo, MessageBoxIcon.Hand);
                    }
                    else if (AddressBox.Text == "" || AddressBox.TextLength > 6)
                    {
                        MessageBox.Show("Forgot to Enter Address?", "Address Error"
                            , MessageBoxButtons.YesNo, MessageBoxIcon.Hand);
                    }
                    else if (CityBox.Text == "")
                    {
                        MessageBox.Show("Forgot to Enter City?", "City Error"
                            , MessageBoxButtons.YesNo, MessageBoxIcon.Hand);
                    }
                    else if (pin != 6)
                    {
                        MessageBox.Show("Forgot to Enter PIN or Wrongly Entered?", "PIN Error"
                            , MessageBoxButtons.YesNo, MessageBoxIcon.Hand);
                    }
                    else if (StateTextBox.Text == "")
                    {
                        MessageBox.Show("Forgot to Enter State?", "State Error"
                            , MessageBoxButtons.YesNo, MessageBoxIcon.Hand);
                    }
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

        private void BackClick(object sender, EventArgs e)
        {
            ServerInfo.mySQLConnect.Close();
            this.Hide();
            LoginModule LogMod = new _1.LoginModule();
            LogMod.Show();
        }
    }
}
