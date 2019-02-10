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
    }
}
