using System.Windows.Forms;

namespace _1___Software_Package.FormPages._3___DataEntry
{
    public partial class DataEntry_Attendance : Form
    {
        public DataEntry_Attendance()
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
            //Doing Validation & Storing Data in Database
            if (dateTimeAttendenceDay.Text == "")
            {
                MessageBox.Show("Please enter date", "Enter date", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }
            if (comboxAttendCourseName.Text == "")
            {
                MessageBox.Show("Please enter Course", "Enter Course", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }
            if (ComboxAttendClass.Text == "")
            {
                MessageBox.Show("Please enter Class", "Enter Class", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }
            if (checkBoxSpecialHoliday.Checked == false || checkBoxSunday.Checked == false)
            {
                MessageBox.Show("Please select a occassion", "Enter occassion", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }
            //connect
        }
    }
}
