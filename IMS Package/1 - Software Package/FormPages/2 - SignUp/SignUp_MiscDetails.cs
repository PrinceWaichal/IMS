using System.Windows.Forms;

namespace _1___Software_Package.FormPages
{
    public partial class SignUp_MiscDetails : Form
    {
        public SignUp_MiscDetails()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Primary_Click(object sender, System.EventArgs e)
        {
            this.Hide();
            SignUp_PrimaryDetails primaryDetails = new SignUp_PrimaryDetails();
            primaryDetails.Show();
        }

        private void Edu_Click(object sender, System.EventArgs e)
        {
            this.Hide();
            SignUp_EducationalDetails educationalDetails = new SignUp_EducationalDetails();
            educationalDetails.Show();
        }

        private void Misc_Click(object sender, System.EventArgs e)
        {
            this.Hide();
            SignUp_MiscDetails misdet = new SignUp_MiscDetails();
            misdet.Show();
        }

        private void Upload_Click(object sender, System.EventArgs e)
        {
            this.Hide();
            _2___SignUp.SignUpUploadFileWindow file = new _2___SignUp.SignUpUploadFileWindow();
            file.Show();
        }

        private void Review_Click(object sender, System.EventArgs e)
        {
            this.Hide();
            _2___SignUp.SignUpReviewWindow rev = new _2___SignUp.SignUpReviewWindow();
            rev.Show();
        }

        private void Login_Click(object sender, System.EventArgs e)
        {
            this.Hide();
            _1___SignIn.StudentLoginWindow stud = new _1___SignIn.StudentLoginWindow();
            stud.Show();
        }

        private void Validate_Click(object sender, System.EventArgs e)
        {
            //Doing validation
        }
    }
}
