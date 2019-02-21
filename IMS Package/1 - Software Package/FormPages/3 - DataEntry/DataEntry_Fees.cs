using System.Windows.Forms;

namespace _1___Software_Package.FormPages._3___DataEntry
{
    public partial class DataEntry_Fees : Form
    {
        public DataEntry_Fees()
        {
            InitializeComponent();
        }

        private void Reports_Click(object sender, System.EventArgs e)
        {
            MessageBox.Show("", "Under Development", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Attend_Click(object sender, System.EventArgs e)
        {
            this.Hide();
            _3___DataEntry.DataEntry_Attendance attend = new DataEntry_Attendance();
            attend.Show();
        }

        private void Marks_Click(object sender, System.EventArgs e)
        {
            this.Hide();
            _3___DataEntry.DataEntry_Marks mark = new DataEntry_Marks();
            mark.Show();
        }

        private void Activity_Click(object sender, System.EventArgs e)
        {
            this.Hide();
            _3___DataEntry.DataEntry_Activities active = new DataEntry_Activities();
            active.Show();
        }

        private void Fees_Click(object sender, System.EventArgs e)
        {
            this.Hide();
            _3___DataEntry.DataEntry_Fees fee = new DataEntry_Fees();
            fee.Show();
        }

        private void Book_Click(object sender, System.EventArgs e)
        {
            this.Hide();
            _3___DataEntry.DataEntry_Books book = new DataEntry_Books();
            book.Show();
        }

        private void Schdl_Click(object sender, System.EventArgs e)
        {
            this.Hide();
            _3___DataEntry.DataEntry_Schedule schdl = new DataEntry_Schedule();
            schdl.Show();
        }

        private void Exam_Clicks(object sender, System.EventArgs e)
        {
            this.Hide();
            _3___DataEntry.DataEntry_Exams exam = new DataEntry_Exams();
            exam.Show();
        }

        private void LogOut_Click(object sender, System.EventArgs e)
        {
            //Logging out User
        }

        private void Submit_Click(object sender, System.EventArgs e)
        {
            //Doing Validation
            if (radioButFeePendingYes.Checked == true)
            {
                if (textTotalFees.Text == "")
                {
                    MessageBox.Show("Please fill total fees", "Fees", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                }
                else if (textFeesPaid.Text == "")
                {
                    MessageBox.Show("Please fill fee paid", "Fees", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                }
                else if (textRemainingFees.Text == "")
                {
                    MessageBox.Show("Please fill Remaining fees", "Fees", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                }
            }
            if (radioButScholarshipEligib.Checked == true)
            {
                if (textScholarshipName.Text == "")
                {
                    MessageBox.Show("Please fill Scholarship Name", "Scholarship", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                }
                else if (textFeesPaid.Text == "")
                {
                    MessageBox.Show("Please fill Scholarship Amount", "Scholarship", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                }
            }
        }
    }
}
