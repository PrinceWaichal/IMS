using System;
using System.Windows.Forms;

namespace _1___Software_Package.FormPages
{
    public partial class SignUp_PrimaryDetails : Form
    {
        public SignUp_PrimaryDetails()
        {
            InitializeComponent();
        }

        private void SignUp_PrimaryDetails_Load(object sender, EventArgs e)
        {
            LastNameBox.Focus();
        }

        private void OpenLogin(object sender, EventArgs e)
        {
            this.Hide();
            // var StudSignIn = new _1___SignIn.StudentLoginWindow();
            // StudSignIn.Closed += (s, args) => this.Close(); // This is a lambda function
            //  StudSignIn.Show();
            _1___SignIn.StudentLoginWindow LogInWindow = new _1___SignIn.StudentLoginWindow();
            LogInWindow.Show();
        }

        private void splitContainer2_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void splitContainer2_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textEmail_Click(object sender, EventArgs e)
        {

        }

        private void MiddleNameBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textDOB_Click(object sender, EventArgs e)
        {

        }

        private void Primary_Click(object sender, EventArgs e)
        {
            this.Hide();
            SignUp_PrimaryDetails prime = new SignUp_PrimaryDetails();
            prime.Show();
        }

        private void Edu_Click(object sender, EventArgs e)
        {
            this.Hide();
            SignUp_EducationalDetails edu = new SignUp_EducationalDetails();
            edu.Show();
        }

        private void Misc_Click(object sender, EventArgs e)
        {
            this.Hide();
            SignUp_MiscDetails misc = new SignUp_MiscDetails();
            misc.Show();
        }

        private void Files_Click(object sender, EventArgs e)
        {
            this.Hide();
            _2___SignUp.SignUpUploadFileWindow files = new _2___SignUp.SignUpUploadFileWindow();
            files.Show();
        }

        private void Review_Click(object sender, EventArgs e)
        {
            this.Hide();
            _2___SignUp.SignUpReviewWindow rev = new _2___SignUp.SignUpReviewWindow();
            rev.Show();
        }

        private void Validate_Click(object sender, EventArgs e)
        {
            //Doing Validation
            if (LastNameBox.Text == "Last Name" || LastNameBox.Text == "")
            {
                MessageBox.Show("You have not Entered Your Last Name", "Missing Last Name", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }
            else if (FirstNameBox.Text == "First Name" || FirstNameBox.Text == "")
            {
                MessageBox.Show("You have not Entered Your First Name", "Missing First Name", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }
            else if (eMailAddBox.Text == "")
            {
                MessageBox.Show("You have not entered your email address", "Missing Email Address", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }
            else if (DomainComboBox.Text == "")
            {
                MessageBox.Show("You have not selected email domain", "Missing Email Domain", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }
            else if (BirthDatePicker.Value == DateTime.Today)
            {
                MessageBox.Show("Invalid Date Entered", "Wrong Date Input", MessageBoxButtons.RetryCancel);
            }
            else if (textGenderbox.Text == "")
            {
                MessageBox.Show("You have not Selected Gender", "Gender Missing", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }
            else if (textAdd1.Text == "")
            {
                MessageBox.Show("You have not entered your Address", "Missing Address", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }
            else if (textLandmark.Text == "")
            {
                MessageBox.Show("You have not entered your Landmark", "Missing Landmark", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }
            else if (textNationality.Text == "")
            {
                MessageBox.Show("You have not selected your Nationality", "Missing Naationality", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }
            else if (textState.Text == "")
            {
                MessageBox.Show("You have not selected your State", "Missing State", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }
            else if (textCity.Text == "")
            {
                MessageBox.Show("You have not selcted your City", "Missing City", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }
            else if (textPin.Text == "")
            {
                MessageBox.Show("You have not entered your PIN", "Missing PIN Code", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }
            else if (textPin.Text.Length != 6)
            {
                MessageBox.Show("Incorrect PIN Code", "Wrong PIN Code", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }
            else if (textMobile.Text == "" )
            {
                MessageBox.Show("You have not entered your Mobile Number", "Missing Mobile Number", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }
            else if(textMobile.Text.Length != 10)
            {
                MessageBox.Show("Incorrect Mobile Number", "Wrong Mobile Number", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }
            else
            {
                //Connection & Data Input Will be Here
            }
        }
    }
}
