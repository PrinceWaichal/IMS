﻿using System.Windows.Forms;

namespace _1___Software_Package.FormPages._3___DataEntry
{
    public partial class DataEntry_Marks : Form
    {
        public DataEntry_Marks()
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
            _3___DataEntry.DataEntry_Marks marks = new DataEntry_Marks();
            marks.Show();
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

        private void Books_Click(object sender, System.EventArgs e)
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
            //Loging out User
        }

        private void Submit_Click(object sender, System.EventArgs e)
        {
            //Doing Validation
        }
    }
}
