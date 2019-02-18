using System.Windows.Forms;

namespace _1___Software_Package.FormPages._2___SignUp
{
    public partial class SignUpUploadFileWindow : Form
    {
        public SignUpUploadFileWindow()
        {
            InitializeComponent();
        }

        private void OnLoad(object sender, System.EventArgs e)
        {
            MessageBox.Show("", "Under Development",MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void Login_Click(object sender, System.EventArgs e)
        {
            this.Hide();
            _1___SignIn.StudentLoginWindow stud = new _1___SignIn.StudentLoginWindow();
            this.Show();
        }
    }
}
