namespace SMS_0._1
{
    partial class DataEntryModule
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DataEntryModule));
            this.ToolStrip = new System.Windows.Forms.ToolStrip();
            this.EnterData = new System.Windows.Forms.ToolStripButton();
            this.Reports = new System.Windows.Forms.ToolStripButton();
            this.LogOut = new System.Windows.Forms.ToolStripButton();
            this.AttendanceGroup = new System.Windows.Forms.GroupBox();
            this.CourseLabel = new System.Windows.Forms.Label();
            this.CourseCombo = new System.Windows.Forms.ComboBox();
            this.CourseContain = new System.Windows.Forms.SplitContainer();
            this.YearContain = new System.Windows.Forms.SplitContainer();
            this.YearLabel = new System.Windows.Forms.Label();
            this.YearCombo = new System.Windows.Forms.ComboBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.ClassLabel = new System.Windows.Forms.Label();
            this.ClassCombo = new System.Windows.Forms.ComboBox();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.SemesterLabel = new System.Windows.Forms.Label();
            this.SemesterCombo = new System.Windows.Forms.ComboBox();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.DateLabel = new System.Windows.Forms.Label();
            this.splitContainer4 = new System.Windows.Forms.SplitContainer();
            this.SubjectLabel = new System.Windows.Forms.Label();
            this.SubjectCombo = new System.Windows.Forms.ComboBox();
            this.AttendanceGrid = new System.Windows.Forms.DataGridView();
            this.DatePicker = new System.Windows.Forms.DateTimePicker();
            this.ToolStrip.SuspendLayout();
            this.AttendanceGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CourseContain)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.CourseContain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.YearContain)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.YearContain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).BeginInit();
            this.splitContainer4.Panel1.SuspendLayout();
            this.splitContainer4.Panel2.SuspendLayout();
            this.splitContainer4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AttendanceGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // ToolStrip
            // 
            this.ToolStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.EnterData,
            this.Reports,
            this.LogOut});
            this.ToolStrip.Location = new System.Drawing.Point(0, 0);
            this.ToolStrip.Name = "ToolStrip";
            this.ToolStrip.Size = new System.Drawing.Size(896, 27);
            this.ToolStrip.TabIndex = 2;
            this.ToolStrip.Text = "toolStrip1";
            // 
            // EnterData
            // 
            this.EnterData.Image = ((System.Drawing.Image)(resources.GetObject("EnterData.Image")));
            this.EnterData.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.EnterData.Name = "EnterData";
            this.EnterData.Size = new System.Drawing.Size(85, 24);
            this.EnterData.Text = "Data Entry";
            this.EnterData.ToolTipText = "Click to Enter Attendance Details";
            // 
            // Reports
            // 
            this.Reports.Image = ((System.Drawing.Image)(resources.GetObject("Reports.Image")));
            this.Reports.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Reports.Name = "Reports";
            this.Reports.Size = new System.Drawing.Size(71, 24);
            this.Reports.Text = "Reports";
            this.Reports.ToolTipText = "Click to View Reports";
            // 
            // LogOut
            // 
            this.LogOut.Image = ((System.Drawing.Image)(resources.GetObject("LogOut.Image")));
            this.LogOut.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.LogOut.Name = "LogOut";
            this.LogOut.Size = new System.Drawing.Size(74, 24);
            this.LogOut.Text = "Log Out";
            this.LogOut.ToolTipText = "Click to Log Out of System";
            // 
            // AttendanceGroup
            // 
            this.AttendanceGroup.Controls.Add(this.AttendanceGrid);
            this.AttendanceGroup.Controls.Add(this.YearContain);
            this.AttendanceGroup.Controls.Add(this.splitContainer2);
            this.AttendanceGroup.Controls.Add(this.splitContainer4);
            this.AttendanceGroup.Controls.Add(this.splitContainer3);
            this.AttendanceGroup.Controls.Add(this.splitContainer1);
            this.AttendanceGroup.Controls.Add(this.CourseContain);
            this.AttendanceGroup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AttendanceGroup.Location = new System.Drawing.Point(0, 27);
            this.AttendanceGroup.Name = "AttendanceGroup";
            this.AttendanceGroup.Size = new System.Drawing.Size(896, 408);
            this.AttendanceGroup.TabIndex = 3;
            this.AttendanceGroup.TabStop = false;
            this.AttendanceGroup.Text = "Attendance Entry";
            // 
            // CourseLabel
            // 
            this.CourseLabel.AutoSize = true;
            this.CourseLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CourseLabel.Location = new System.Drawing.Point(0, 0);
            this.CourseLabel.Name = "CourseLabel";
            this.CourseLabel.Size = new System.Drawing.Size(94, 15);
            this.CourseLabel.TabIndex = 0;
            this.CourseLabel.Text = "Select a Course";
            // 
            // CourseCombo
            // 
            this.CourseCombo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CourseCombo.FormattingEnabled = true;
            this.CourseCombo.Location = new System.Drawing.Point(0, 0);
            this.CourseCombo.Name = "CourseCombo";
            this.CourseCombo.Size = new System.Drawing.Size(192, 23);
            this.CourseCombo.TabIndex = 1;
            // 
            // CourseContain
            // 
            this.CourseContain.Location = new System.Drawing.Point(15, 89);
            this.CourseContain.Name = "CourseContain";
            // 
            // CourseContain.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.CourseLabel);
            // 
            // CourseContain.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.CourseCombo);
            this.CourseContain.Size = new System.Drawing.Size(293, 26);
            this.CourseContain.SplitterDistance = 97;
            this.CourseContain.TabIndex = 2;
            // 
            // YearContain
            // 
            this.YearContain.Location = new System.Drawing.Point(314, 89);
            this.YearContain.Name = "YearContain";
            // 
            // YearContain.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.YearLabel);
            // 
            // YearContain.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.YearCombo);
            this.YearContain.Size = new System.Drawing.Size(293, 26);
            this.YearContain.SplitterDistance = 97;
            this.YearContain.TabIndex = 2;
            // 
            // YearLabel
            // 
            this.YearLabel.AutoSize = true;
            this.YearLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.YearLabel.Location = new System.Drawing.Point(0, 0);
            this.YearLabel.Name = "YearLabel";
            this.YearLabel.Size = new System.Drawing.Size(83, 15);
            this.YearLabel.TabIndex = 0;
            this.YearLabel.Text = "Select a Year";
            // 
            // YearCombo
            // 
            this.YearCombo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.YearCombo.FormattingEnabled = true;
            this.YearCombo.Location = new System.Drawing.Point(0, 0);
            this.YearCombo.Name = "YearCombo";
            this.YearCombo.Size = new System.Drawing.Size(192, 23);
            this.YearCombo.TabIndex = 1;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Location = new System.Drawing.Point(15, 121);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.ClassLabel);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.ClassCombo);
            this.splitContainer1.Size = new System.Drawing.Size(293, 26);
            this.splitContainer1.SplitterDistance = 97;
            this.splitContainer1.TabIndex = 2;
            // 
            // ClassLabel
            // 
            this.ClassLabel.AutoSize = true;
            this.ClassLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ClassLabel.Location = new System.Drawing.Point(0, 0);
            this.ClassLabel.Name = "ClassLabel";
            this.ClassLabel.Size = new System.Drawing.Size(84, 15);
            this.ClassLabel.TabIndex = 0;
            this.ClassLabel.Text = "Select a Class";
            // 
            // ClassCombo
            // 
            this.ClassCombo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ClassCombo.FormattingEnabled = true;
            this.ClassCombo.Location = new System.Drawing.Point(0, 0);
            this.ClassCombo.Name = "ClassCombo";
            this.ClassCombo.Size = new System.Drawing.Size(192, 23);
            this.ClassCombo.TabIndex = 1;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Location = new System.Drawing.Point(314, 121);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.SemesterLabel);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.SemesterCombo);
            this.splitContainer2.Size = new System.Drawing.Size(293, 26);
            this.splitContainer2.SplitterDistance = 97;
            this.splitContainer2.TabIndex = 2;
            // 
            // SemesterLabel
            // 
            this.SemesterLabel.AutoSize = true;
            this.SemesterLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SemesterLabel.Location = new System.Drawing.Point(0, 0);
            this.SemesterLabel.Name = "SemesterLabel";
            this.SemesterLabel.Size = new System.Drawing.Size(78, 15);
            this.SemesterLabel.TabIndex = 0;
            this.SemesterLabel.Text = "Select a Sem";
            // 
            // SemesterCombo
            // 
            this.SemesterCombo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SemesterCombo.FormattingEnabled = true;
            this.SemesterCombo.Location = new System.Drawing.Point(0, 0);
            this.SemesterCombo.Name = "SemesterCombo";
            this.SemesterCombo.Size = new System.Drawing.Size(192, 23);
            this.SemesterCombo.TabIndex = 1;
            // 
            // splitContainer3
            // 
            this.splitContainer3.Location = new System.Drawing.Point(15, 151);
            this.splitContainer3.Name = "splitContainer3";
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.DateLabel);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.DatePicker);
            this.splitContainer3.Size = new System.Drawing.Size(293, 26);
            this.splitContainer3.SplitterDistance = 97;
            this.splitContainer3.TabIndex = 2;
            // 
            // DateLabel
            // 
            this.DateLabel.AutoSize = true;
            this.DateLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DateLabel.Location = new System.Drawing.Point(0, 0);
            this.DateLabel.Name = "DateLabel";
            this.DateLabel.Size = new System.Drawing.Size(95, 15);
            this.DateLabel.TabIndex = 0;
            this.DateLabel.Text = "Select the Date";
            // 
            // splitContainer4
            // 
            this.splitContainer4.Location = new System.Drawing.Point(314, 151);
            this.splitContainer4.Name = "splitContainer4";
            // 
            // splitContainer4.Panel1
            // 
            this.splitContainer4.Panel1.Controls.Add(this.SubjectLabel);
            // 
            // splitContainer4.Panel2
            // 
            this.splitContainer4.Panel2.Controls.Add(this.SubjectCombo);
            this.splitContainer4.Size = new System.Drawing.Size(293, 26);
            this.splitContainer4.SplitterDistance = 97;
            this.splitContainer4.TabIndex = 2;
            // 
            // SubjectLabel
            // 
            this.SubjectLabel.AutoSize = true;
            this.SubjectLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SubjectLabel.Location = new System.Drawing.Point(0, 0);
            this.SubjectLabel.Name = "SubjectLabel";
            this.SubjectLabel.Size = new System.Drawing.Size(97, 15);
            this.SubjectLabel.TabIndex = 0;
            this.SubjectLabel.Text = "Select a Subject";
            // 
            // SubjectCombo
            // 
            this.SubjectCombo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SubjectCombo.FormattingEnabled = true;
            this.SubjectCombo.Location = new System.Drawing.Point(0, 0);
            this.SubjectCombo.Name = "SubjectCombo";
            this.SubjectCombo.Size = new System.Drawing.Size(192, 23);
            this.SubjectCombo.TabIndex = 1;
            // 
            // AttendanceGrid
            // 
            this.AttendanceGrid.AllowUserToDeleteRows = false;
            this.AttendanceGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AttendanceGrid.Location = new System.Drawing.Point(12, 201);
            this.AttendanceGrid.Name = "AttendanceGrid";
            this.AttendanceGrid.Size = new System.Drawing.Size(592, 150);
            this.AttendanceGrid.TabIndex = 3;
            // 
            // DatePicker
            // 
            this.DatePicker.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DatePicker.Location = new System.Drawing.Point(0, 0);
            this.DatePicker.Name = "DatePicker";
            this.DatePicker.Size = new System.Drawing.Size(192, 22);
            this.DatePicker.TabIndex = 0;
            // 
            // DataEntryModule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.ClientSize = new System.Drawing.Size(896, 435);
            this.Controls.Add(this.AttendanceGroup);
            this.Controls.Add(this.ToolStrip);
            this.Name = "DataEntryModule";
            this.Controls.SetChildIndex(this.ToolStrip, 0);
            this.Controls.SetChildIndex(this.AttendanceGroup, 0);
            this.ToolStrip.ResumeLayout(false);
            this.ToolStrip.PerformLayout();
            this.AttendanceGroup.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.CourseContain)).EndInit();
            this.CourseContain.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.YearContain)).EndInit();
            this.YearContain.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel1.PerformLayout();
            this.splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            this.splitContainer4.Panel1.ResumeLayout(false);
            this.splitContainer4.Panel1.PerformLayout();
            this.splitContainer4.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).EndInit();
            this.splitContainer4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.AttendanceGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip ToolStrip;
        private System.Windows.Forms.ToolStripButton EnterData;
        private System.Windows.Forms.ToolStripButton Reports;
        private System.Windows.Forms.ToolStripButton LogOut;
        private System.Windows.Forms.GroupBox AttendanceGroup;
        private System.Windows.Forms.SplitContainer YearContain;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.Label SemesterLabel;
        private System.Windows.Forms.ComboBox SemesterCombo;
        private System.Windows.Forms.Label YearLabel;
        private System.Windows.Forms.ComboBox YearCombo;
        private System.Windows.Forms.SplitContainer splitContainer4;
        private System.Windows.Forms.Label SubjectLabel;
        private System.Windows.Forms.ComboBox SubjectCombo;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.Label DateLabel;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label ClassLabel;
        private System.Windows.Forms.ComboBox ClassCombo;
        private System.Windows.Forms.SplitContainer CourseContain;
        private System.Windows.Forms.Label CourseLabel;
        private System.Windows.Forms.ComboBox CourseCombo;
        private System.Windows.Forms.DataGridView AttendanceGrid;
        private System.Windows.Forms.DateTimePicker DatePicker;
    }
}
