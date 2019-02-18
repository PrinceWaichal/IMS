using System.Windows.Forms;

namespace _1___Software_Package.FormPages
{
    public partial class SignUp_EducationalDetails : Form
    {
        public SignUp_EducationalDetails()
        {
            InitializeComponent();
        }

        private void PrimaryDetailsClick(object sender, System.EventArgs e)
        {
            this.Hide();
            SignUp_PrimaryDetails signUp_Primary = new SignUp_PrimaryDetails();
            signUp_Primary.Show();
        }

        private void EdDet_Click(object sender, System.EventArgs e)
        {
            this.Hide();
            SignUp_EducationalDetails educationalDetails = new SignUp_EducationalDetails();
            educationalDetails.Show();
        }

        private void MiscDet_Click(object sender, System.EventArgs e)
        {
            this.Hide();
            SignUp_MiscDetails miscDetails = new SignUp_MiscDetails();
            miscDetails.Show();
        }

        private void Files_Click(object sender, System.EventArgs e)
        {
            this.Hide();
            _2___SignUp.SignUpUploadFileWindow fileWindow = new _2___SignUp.SignUpUploadFileWindow();
            fileWindow.Show();
        }

        private void ReviewApp_Click(object sender, System.EventArgs e)
        {
            this.Hide();
            _2___SignUp.SignUpReviewWindow ReviewWin = new _2___SignUp.SignUpReviewWindow();
            ReviewWin.Show();
        }

        private void Login_Click(object sender, System.EventArgs e)
        {
            this.Hide();
            _1___SignIn.StudentLoginWindow loginwindow = new _1___SignIn.StudentLoginWindow();
            loginwindow.Show();
        }

        private void Validate_Cick(object sender, System.EventArgs e)
        {
            //Doing validation
        }
    }
}
