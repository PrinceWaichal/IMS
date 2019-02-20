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
            //SSC
            if (textUniverSSC.Text == "")
            {
                MessageBox.Show("You have not entered SSC University", "SSC Missing University", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }
            else if(textSchColleNamSSC.Text == "")
            {
                MessageBox.Show("You have not entered SSC Institute Name","SSC Missing Institute",MessageBoxButtons.RetryCancel,MessageBoxIcon.Error);
            }
            else if(textMaxMarkSSC.Text == "" || textMaxMarkSSC.TextLength > 10)
            {
                MessageBox.Show("You have either not entered or given wrong maximum SSC marks", "SSC Maximum Marks Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }
            else if(textMarkObtainSSC.Text == "" || textMarkObtainSSC.TextLength > 4)
            {
                MessageBox.Show("You have either not entered or given wrong obtained SSC marks", "SSC Obtained Marks Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }
            //HSC
            else if (textUniversHSC.Text == "")
            {
                MessageBox.Show("You have not entered HSC University", "HSC Missing University", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }
            else if (textSchColleNamHSC.Text == "")
            {
                MessageBox.Show("You have not entered HSC Institute Name", "HSC Missing Institute", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }
            else if (textMaxMarkHSC.Text == "" || textMaxMarkHSC.TextLength > 10)
            {
                MessageBox.Show("You have either not entered or given wrong maximum HSC marks", "HSC Maximum Marks Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }
            else if (textMarkObtainHSC.Text == "" || textMarkObtainHSC.TextLength > 4)
            {
                MessageBox.Show("You have either not entered or given wrong obtained HSC marks", "HSC Obtained Marks Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }
            //Graduate
            //FY
            else if (textUniverFY_UG.Text == "")
            {
                MessageBox.Show("You have not entered Graduation_FY University", "UG_FY Missing University", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }
            else if (textColleNamFY_UG.Text == "")
            {
                MessageBox.Show("You have not entered Graduation_FY Institute Name", "UG_FY Missing Institute", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }
            else if (textMaxMarkFY_UG.Text == "" || textMaxMarkFY_UG.TextLength > 10)
            {
                MessageBox.Show("You have either not entered or given wrong maximum Graduation_FY marks", "UG_FY Maximum Marks Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }
            else if (textMarkObtainFY_UG.Text == "" || textMarkObtainFY_UG.TextLength > 4)
            {
                MessageBox.Show("You have either not entered or given wrong obtained Graduation_FY marks", "UG_FY Obtained Marks Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }

            //SY
            else if (textUniverSY_UG.Text == "")
            {
                MessageBox.Show("You have not entered Graduation_SY University", "UG_SY Missing University", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }
            else if (textColleNamSY_UG.Text == "")
            {
                MessageBox.Show("You have not entered Graduation_SY Institute Name", "UG_SY Missing Institute", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }
            else if (textMaxMarkSY_UG.Text == "" || textMaxMarkSY_UG.TextLength > 10)
            {
                MessageBox.Show("You have either not entered or given wrong maximum Graduation_SY marks", "UG_SY Maximum Marks Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }
            else if (textMarkObtainSY_UG.Text == "" || textMarkObtainSY_UG.TextLength > 4)
            {
                MessageBox.Show("You have either not entered or given wrong obtained Graduation_SY marks", "UG_SY Obtained Marks Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }

            //TY
            else if (textUniverTY_UG.Text == "")
            {
                MessageBox.Show("You have not entered Graduation_TY University", "UG_TY Missing University", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }
            else if (textColleNamTY_UG.Text == "")
            {
                MessageBox.Show("You have not entered Graduation_TY Institute Name", "UG_TY Missing Institute", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }
            else if (textMaxMarkTY_UG.Text == "" || textMaxMarkTY_UG.TextLength > 10)
            {
                MessageBox.Show("You have either not entered or given wrong maximum Graduation_FY marks", "UG_FY Maximum Marks Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }
            else if (textMarkObtainTY_UG.Text == "" || textMarkObtainTY_UG.TextLength > 4)
            {
                MessageBox.Show("You have either not entered or given wrong obtained Graduation_FY marks", "UG_FY Obtained Marks Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }
            //PostGraduate
            //FY
            else if (textUniverFY_PG.Text == "")
            {
                MessageBox.Show("You have not entered Post-Graduation_FY University", "PG_FY Missing University", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }
            else if (textColleNamFY_PG.Text == "")
            {
                MessageBox.Show("You have not entered Post-Graduation_FY Institute Name", "PG_FY Missing Institute", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }
            else if (textMaxMarkFY_PG.Text == "" || textMaxMarkFY_PG.TextLength > 10)
            {
                MessageBox.Show("You have either not entered or given wrong maximum Post-Graduation_FY marks", "PG_FY Maximum Marks Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }
            else if (textMarkObtainFY_PG.Text == "" || textMarkObtainFY_PG.TextLength > 4)
            {
                MessageBox.Show("You have either not entered or given wrong obtained Post-Graduation_FY marks", "PG_FY Obtained Marks Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }
            //SY
            else if (textUniverSY_PG.Text == "")
            {
                MessageBox.Show("You have not entered Post-Graduation_SY University", "PG_SY Missing University", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }
            else if (textColleNamSY_PG.Text == "")
            {
                MessageBox.Show("You have not entered Post-Graduation_SY Institute Name", "PG_SY Missing Institute", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }
            else if (textMaxMarkSY_PG.Text == "" || textMaxMarkSY_PG.TextLength > 10)
            {
                MessageBox.Show("You have either not entered or given wrong maximum Post-Graduation_SY marks", "PG_SY Maximum Marks Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }
            else if (textMarkObtainSY_PG.Text == "" || textMarkObtainSY_PG.TextLength > 4)
            {
                MessageBox.Show("You have either not entered or given wrong obtained Post-Graduation_SY marks", "PG_SY Obtained Marks Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }
            //TY
            else if (textUniverTY_PG.Text == "")
            {
                MessageBox.Show("You have not entered Post-Graduation_TY University", "PG_TY Missing University", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }
            else if (textColleNamTY_PG.Text == "")
            {
                MessageBox.Show("You have not entered Post-Graduation_TY Institute Name", "PG_TY Missing Institute", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }
            else if (textMaxMarkTY_PG.Text == "" || textMaxMarkTY_PG.TextLength > 10)
            {
                MessageBox.Show("You have either not entered or given wrong maximum Post-Graduation_TY marks", "PG_TY Maximum Marks Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }
            else if (textMarkObtainTY_PG.Text == "" || textMarkObtainTY_PG.TextLength > 4)
            {
                MessageBox.Show("You have either not entered or given wrong obtained Post-Graduation_TY marks", "PG_TY Obtained Marks Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }

            else
            {
                //Connect & Insert
            }
        }
    }
}
