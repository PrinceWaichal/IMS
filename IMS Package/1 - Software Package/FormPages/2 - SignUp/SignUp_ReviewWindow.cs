using System.Windows.Forms;

namespace _1___Software_Package.FormPages._2___SignUp
{
    public partial class SignUpReviewWindow : Form
    {
        public SignUpReviewWindow()
        {
            InitializeComponent();
        }

        private void splitContainer2_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void splitContainer2_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Prime_Click(object sender, System.EventArgs e)
        {
            this.Hide();
            SignUp_PrimaryDetails prime = new SignUp_PrimaryDetails();
            prime.Show();
        }

        private void Edu_Click(object sender, System.EventArgs e)
        {
            this.Hide();
            SignUp_EducationalDetails edu = new SignUp_EducationalDetails();
            edu.Show();
        }

        private void Misc_Click(object sender, System.EventArgs e)
        {
            this.Hide();
            SignUp_MiscDetails misc = new SignUp_MiscDetails();
            misc.Show();
        }

        private void Files_Click(object sender, System.EventArgs e)
        {
            this.Hide();
            _2___SignUp.SignUpUploadFileWindow files = new SignUpUploadFileWindow();
            files.Show();
        }

        private void Rev_Click(object sender, System.EventArgs e)
        {
            this.Hide();
            _2___SignUp.SignUpReviewWindow rev = new SignUpReviewWindow();
            rev.Show();
        }

        private void Login_Click(object sender, System.EventArgs e)
        {
            this.Hide();
            _1___SignIn.StudentLoginWindow stud = new _1___SignIn.StudentLoginWindow();
            stud.Show();
        }

        private void Submit_Click(object sender, System.EventArgs e)
        {
            //Doing Validation
        }
    }
}
