using System.Windows.Forms;

namespace _1___Software_Package.FormPages._3___DataEntry
{
    public partial class DataEntry_Exams : Form
    {
        public DataEntry_Exams()
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

        private void Schedule_Click(object sender, System.EventArgs e)
        {
            this.Hide();
            _3___DataEntry.DataEntry_Schedule schdl = new DataEntry_Schedule();
            schdl.Show();
        }

        private void Exam_Click(object sender, System.EventArgs e)
        {
            this.Hide();
            _3___DataEntry.DataEntry_Exams exam = new DataEntry_Exams();
            exam.Show();
        }

        private void LogOut_Click(object sender, System.EventArgs e)
        {
            //Logging out the user
        }

        private void Submit_Click(object sender, System.EventArgs e)
        {
            //Doing validation
            if (ComboxSemester.Text == "")
            {
                MessageBox.Show("You have not entered option for semester", "Missing semester", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }
            else if (ComboxCourse.Text == "")
            {
                MessageBox.Show("You have not entered option for course", "Missing course", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }
            else if (ComboxSubject.Text == "")
            {
                MessageBox.Show("You have not entered option for Subject", "Missing Subject", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }
            else if (comboxMonth.Text == "")
            {
                MessageBox.Show("You have not entered option for Month", "Missing Month", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }
            else if (radioButRegular.Checked == false && radioButRepeater.Checked == true)
            {
                MessageBox.Show("You have not entered status corrrectly","Missing status of your exam",MessageBoxButtons.RetryCancel,MessageBoxIcon.Error);
            }
            else
            {
               
            }
        }
    }
}
