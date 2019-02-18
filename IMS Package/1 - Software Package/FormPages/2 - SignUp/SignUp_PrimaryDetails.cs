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
        }
    }
}
