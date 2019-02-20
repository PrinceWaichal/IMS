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
            if (texMiscGLastName.Text == "Last Name" || texMiscGLastName.Text == "")
            {
                MessageBox.Show("You have not entered Guardians Last Name", "Missing Last Name", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }
            else if (texMiscGFirstNam.Text == "First Name" || texMiscGFirstNam.Text == "")
            {
                MessageBox.Show("You have not entered Guardians First Name", "Missing First Name", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }
            else if (texMiscGMiddleNam.Text == "Middle Name" || texMiscGMiddleNam.Text == "")
            {
                MessageBox.Show("You have not entered Guardians Middle Name", "Missing Middle Name", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }
            else if (texMiscMLastNam.Text == "Last Name" || texMiscMLastNam.Text == "")
            {
                MessageBox.Show("You have not entered Mother's Last Name", "Missing Last Name", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }
            else if (texMiscMFirstNam.Text == "First Name" || texMiscMFirstNam.Text == "")
            {
                MessageBox.Show("You have not entered Mother's First Name", "Missing First Name", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }
            else if (texMiscMMiddleNam.Text == "Middle Name" || texMiscMMiddleNam.Text == "")
            {
                MessageBox.Show("You have not entered Mother's Middle Name", "Missing Middle Name", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }
            else if (texMiscPContNo.Text == "")
            {
                MessageBox.Show("You have not entered Parents contact number properly", "Missing Parents contact number", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }
            else if (texMiscPContNo.Text.Length != 10)
            {
                MessageBox.Show("You have not entered parents contact number properly ", "Missing Parents contact number", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }
            else if (BoxMiscCategory.Text == "")
            {
                MessageBox.Show("You have not selected any category", "Missing category", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }
            else if (texMiscAdharNo.Text == "")
            {
                MessageBox.Show("You have not entered Aadhar number", "Missing Asdhar number", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }
            else if (texMiscAdharNo.Text.Length != 12)
            {
                MessageBox.Show("You have entered Aadhar number incorrectly", "Missing Aadhar number", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }
            else if (BoxMiscPhyDisab.Text == "")
            {
                MessageBox.Show("You have not selected any option", "Missing physical ability status", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }
            else if (BoxMiscCast.Text == "")
            {
                MessageBox.Show("You have not entered cast from list", "Missing cast option ", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }
            else if (BoxMiscMariralStat.Text == "")
            {
                MessageBox.Show("You have not entered Marital status", "Missing option for Marital status", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }
            else if (comBoxMiscReligion.Text == "")
            {
                MessageBox.Show("You have not entered Religion", "Missing option for Religion", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }
            else if (texMiscCourseName1.Text == "")
            {
                MessageBox.Show("You have not enterd any course name"," Missing course.",MessageBoxButtons.RetryCancel,MessageBoxIcon.Error);
            }
            else if (texMiscCourseName1.Text != "")
            {
                if (textMiscScore1.Text=="")
                {
                    MessageBox.Show("You have not entered score for respective course ", "Missing your score.", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                }
            }
            else if (textMiscWorkPlace1.Text !="")
            {
                if(textMiscJobStatus1.Text=="")
                {
                    MessageBox.Show("You have not entered status for your work place","Missing Work place status",MessageBoxButtons.RetryCancel,MessageBoxIcon.Error);
                }
            }

            else if (textMiscWorkPlace1.Text != "")
            {
                if (textMiscJobStatus1.Text != "")
                {
                    if (textMiscYearExperiance1.Text == "")
                    {
                        MessageBox.Show("You have not entered years of your work experiance", "Missing years of work experiance", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                    }

                }
            }
           
        }
    }
}
