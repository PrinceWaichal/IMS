using System.Windows.Forms;

namespace _1___Software_Package.FormPages._3___DataEntry
{
    public partial class DataEntry_Activities : Form
    {
        public DataEntry_Activities()
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

        private void Mark_Click(object sender, System.EventArgs e)
        {
            this.Hide();
            _3___DataEntry.DataEntry_Marks marks = new DataEntry_Marks();
            marks.Show();
        }

        private void Activity_Click(object sender, System.EventArgs e)
        {
            this.Hide();
            _3___DataEntry.DataEntry_Activities activity = new DataEntry_Activities();
            activity.Show();
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

        private void Scdl_Click(object sender, System.EventArgs e)
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
            //Logging The USer Out of the SYstem
        }

        private void Submit_Click(object sender, System.EventArgs e)
        {
            //Inserting Data Into Database
        }
    }
}
