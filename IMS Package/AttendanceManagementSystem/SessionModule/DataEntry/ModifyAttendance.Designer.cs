namespace AttendanceManagementSystem.SessionModule.DataEntry
{
    partial class ModifyAttendance
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModifyAttendance));
            this.ToolStrip = new System.Windows.Forms.ToolStrip();
            this.AddDetails = new System.Windows.Forms.ToolStripButton();
            this.DataEntry = new System.Windows.Forms.ToolStripButton();
            this.ModifyEntry = new System.Windows.Forms.ToolStripButton();
            this.Reports = new System.Windows.Forms.ToolStripButton();
            this.Logout = new System.Windows.Forms.ToolStripButton();
            this.Panel = new System.Windows.Forms.Panel();
            this.UpdateButton = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            this.AttendanceGridView = new System.Windows.Forms.DataGridView();
            this.ClassGroup = new System.Windows.Forms.GroupBox();
            this.TableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.SubjectCombo = new System.Windows.Forms.ComboBox();
            this.SubjectLabel = new System.Windows.Forms.Label();
            this.DateLabel = new System.Windows.Forms.Label();
            this.SemesterLabel = new System.Windows.Forms.Label();
            this.ClassLabel = new System.Windows.Forms.Label();
            this.CourseLabel = new System.Windows.Forms.Label();
            this.YearLabel = new System.Windows.Forms.Label();
            this.CourseCombo = new System.Windows.Forms.ComboBox();
            this.YearCombo = new System.Windows.Forms.ComboBox();
            this.ClassCombo = new System.Windows.Forms.ComboBox();
            this.SemesterCombo = new System.Windows.Forms.ComboBox();
            this.DatePicker = new System.Windows.Forms.DateTimePicker();
            this.ToolStrip.SuspendLayout();
            this.Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AttendanceGridView)).BeginInit();
            this.ClassGroup.SuspendLayout();
            this.TableLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // ToolStrip
            // 
            this.ToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddDetails,
            this.DataEntry,
            this.ModifyEntry,
            this.Reports,
            this.Logout});
            this.ToolStrip.Location = new System.Drawing.Point(0, 24);
            this.ToolStrip.Name = "ToolStrip";
            this.ToolStrip.Size = new System.Drawing.Size(1184, 25);
            this.ToolStrip.TabIndex = 5;
            this.ToolStrip.Text = "ToolStrip";
            // 
            // AddDetails
            // 
            this.AddDetails.Image = ((System.Drawing.Image)(resources.GetObject("AddDetails.Image")));
            this.AddDetails.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.AddDetails.Name = "AddDetails";
            this.AddDetails.Size = new System.Drawing.Size(87, 22);
            this.AddDetails.Text = "Add Details";
            this.AddDetails.ToolTipText = "Click to Add Course Details";
            this.AddDetails.Click += new System.EventHandler(this.AddClick);
            // 
            // DataEntry
            // 
            this.DataEntry.Image = ((System.Drawing.Image)(resources.GetObject("DataEntry.Image")));
            this.DataEntry.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.DataEntry.Name = "DataEntry";
            this.DataEntry.Size = new System.Drawing.Size(81, 22);
            this.DataEntry.Text = "Data Entry";
            this.DataEntry.ToolTipText = "Click to Enter Data";
            this.DataEntry.Click += new System.EventHandler(this.EntryClick);
            // 
            // ModifyEntry
            // 
            this.ModifyEntry.Image = ((System.Drawing.Image)(resources.GetObject("ModifyEntry.Image")));
            this.ModifyEntry.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ModifyEntry.Name = "ModifyEntry";
            this.ModifyEntry.Size = new System.Drawing.Size(95, 22);
            this.ModifyEntry.Text = "Modify Entry";
            this.ModifyEntry.ToolTipText = "Click to Modify / Update Entry";
            this.ModifyEntry.Click += new System.EventHandler(this.ModifyClick);
            // 
            // Reports
            // 
            this.Reports.Image = ((System.Drawing.Image)(resources.GetObject("Reports.Image")));
            this.Reports.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Reports.Name = "Reports";
            this.Reports.Size = new System.Drawing.Size(67, 22);
            this.Reports.Text = "Reports";
            this.Reports.ToolTipText = "Click to view Reports";
            this.Reports.Click += new System.EventHandler(this.ReportsClick);
            // 
            // Logout
            // 
            this.Logout.Image = ((System.Drawing.Image)(resources.GetObject("Logout.Image")));
            this.Logout.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Logout.Name = "Logout";
            this.Logout.Size = new System.Drawing.Size(65, 22);
            this.Logout.Text = "Logout";
            this.Logout.ToolTipText = "Click to Logout of System";
            this.Logout.Click += new System.EventHandler(this.LogoutClick);
            // 
            // Panel
            // 
            this.Panel.AutoScroll = true;
            this.Panel.AutoSize = true;
            this.Panel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Panel.Controls.Add(this.UpdateButton);
            this.Panel.Controls.Add(this.ClearButton);
            this.Panel.Controls.Add(this.AttendanceGridView);
            this.Panel.Controls.Add(this.ClassGroup);
            this.Panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel.Location = new System.Drawing.Point(0, 49);
            this.Panel.Name = "Panel";
            this.Panel.Size = new System.Drawing.Size(1184, 652);
            this.Panel.TabIndex = 7;
            // 
            // UpdateButton
            // 
            this.UpdateButton.Location = new System.Drawing.Point(850, 606);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(75, 23);
            this.UpdateButton.TabIndex = 3;
            this.UpdateButton.Text = "Update";
            this.UpdateButton.UseVisualStyleBackColor = true;
            // 
            // ClearButton
            // 
            this.ClearButton.Location = new System.Drawing.Point(723, 606);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(75, 23);
            this.ClearButton.TabIndex = 2;
            this.ClearButton.Text = "Clear";
            this.ClearButton.UseVisualStyleBackColor = true;
            // 
            // AttendanceGridView
            // 
            this.AttendanceGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AttendanceGridView.Location = new System.Drawing.Point(125, 112);
            this.AttendanceGridView.Name = "AttendanceGridView";
            this.AttendanceGridView.Size = new System.Drawing.Size(800, 475);
            this.AttendanceGridView.TabIndex = 1;
            // 
            // ClassGroup
            // 
            this.ClassGroup.Controls.Add(this.TableLayoutPanel);
            this.ClassGroup.Location = new System.Drawing.Point(125, 31);
            this.ClassGroup.Name = "ClassGroup";
            this.ClassGroup.Size = new System.Drawing.Size(800, 75);
            this.ClassGroup.TabIndex = 0;
            this.ClassGroup.TabStop = false;
            this.ClassGroup.Text = "Select Details";
            // 
            // TableLayoutPanel
            // 
            this.TableLayoutPanel.ColumnCount = 6;
            this.TableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.TableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.TableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.TableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.TableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.TableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.TableLayoutPanel.Controls.Add(this.SubjectCombo, 5, 1);
            this.TableLayoutPanel.Controls.Add(this.SubjectLabel, 5, 0);
            this.TableLayoutPanel.Controls.Add(this.DateLabel, 4, 0);
            this.TableLayoutPanel.Controls.Add(this.SemesterLabel, 3, 0);
            this.TableLayoutPanel.Controls.Add(this.ClassLabel, 2, 0);
            this.TableLayoutPanel.Controls.Add(this.CourseLabel, 0, 0);
            this.TableLayoutPanel.Controls.Add(this.YearLabel, 1, 0);
            this.TableLayoutPanel.Controls.Add(this.CourseCombo, 0, 1);
            this.TableLayoutPanel.Controls.Add(this.YearCombo, 1, 1);
            this.TableLayoutPanel.Controls.Add(this.ClassCombo, 2, 1);
            this.TableLayoutPanel.Controls.Add(this.SemesterCombo, 3, 1);
            this.TableLayoutPanel.Controls.Add(this.DatePicker, 4, 1);
            this.TableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TableLayoutPanel.Location = new System.Drawing.Point(3, 18);
            this.TableLayoutPanel.Name = "TableLayoutPanel";
            this.TableLayoutPanel.RowCount = 2;
            this.TableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TableLayoutPanel.Size = new System.Drawing.Size(794, 54);
            this.TableLayoutPanel.TabIndex = 0;
            // 
            // SubjectCombo
            // 
            this.SubjectCombo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SubjectCombo.FormattingEnabled = true;
            this.SubjectCombo.Location = new System.Drawing.Point(663, 30);
            this.SubjectCombo.Name = "SubjectCombo";
            this.SubjectCombo.Size = new System.Drawing.Size(128, 23);
            this.SubjectCombo.TabIndex = 1;
            this.SubjectCombo.Text = "Select";
            // 
            // SubjectLabel
            // 
            this.SubjectLabel.AutoSize = true;
            this.SubjectLabel.Location = new System.Drawing.Point(663, 0);
            this.SubjectLabel.Name = "SubjectLabel";
            this.SubjectLabel.Size = new System.Drawing.Size(49, 15);
            this.SubjectLabel.TabIndex = 5;
            this.SubjectLabel.Text = "Subject";
            // 
            // DateLabel
            // 
            this.DateLabel.AutoSize = true;
            this.DateLabel.Location = new System.Drawing.Point(531, 0);
            this.DateLabel.Name = "DateLabel";
            this.DateLabel.Size = new System.Drawing.Size(36, 15);
            this.DateLabel.TabIndex = 4;
            this.DateLabel.Text = "Date";
            // 
            // SemesterLabel
            // 
            this.SemesterLabel.AutoSize = true;
            this.SemesterLabel.Location = new System.Drawing.Point(399, 0);
            this.SemesterLabel.Name = "SemesterLabel";
            this.SemesterLabel.Size = new System.Drawing.Size(58, 15);
            this.SemesterLabel.TabIndex = 3;
            this.SemesterLabel.Text = "Semester";
            // 
            // ClassLabel
            // 
            this.ClassLabel.AutoSize = true;
            this.ClassLabel.Location = new System.Drawing.Point(267, 0);
            this.ClassLabel.Name = "ClassLabel";
            this.ClassLabel.Size = new System.Drawing.Size(36, 15);
            this.ClassLabel.TabIndex = 2;
            this.ClassLabel.Text = "Class";
            // 
            // CourseLabel
            // 
            this.CourseLabel.AutoSize = true;
            this.CourseLabel.Location = new System.Drawing.Point(3, 0);
            this.CourseLabel.Name = "CourseLabel";
            this.CourseLabel.Size = new System.Drawing.Size(46, 15);
            this.CourseLabel.TabIndex = 0;
            this.CourseLabel.Text = "Course";
            // 
            // YearLabel
            // 
            this.YearLabel.AutoSize = true;
            this.YearLabel.Location = new System.Drawing.Point(135, 0);
            this.YearLabel.Name = "YearLabel";
            this.YearLabel.Size = new System.Drawing.Size(35, 15);
            this.YearLabel.TabIndex = 1;
            this.YearLabel.Text = "Year";
            // 
            // CourseCombo
            // 
            this.CourseCombo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CourseCombo.FormattingEnabled = true;
            this.CourseCombo.Location = new System.Drawing.Point(3, 30);
            this.CourseCombo.Name = "CourseCombo";
            this.CourseCombo.Size = new System.Drawing.Size(126, 23);
            this.CourseCombo.TabIndex = 6;
            this.CourseCombo.Text = "Select";
            // 
            // YearCombo
            // 
            this.YearCombo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.YearCombo.FormattingEnabled = true;
            this.YearCombo.Location = new System.Drawing.Point(135, 30);
            this.YearCombo.Name = "YearCombo";
            this.YearCombo.Size = new System.Drawing.Size(126, 23);
            this.YearCombo.TabIndex = 7;
            this.YearCombo.Text = "Select";
            // 
            // ClassCombo
            // 
            this.ClassCombo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ClassCombo.FormattingEnabled = true;
            this.ClassCombo.Location = new System.Drawing.Point(267, 30);
            this.ClassCombo.Name = "ClassCombo";
            this.ClassCombo.Size = new System.Drawing.Size(126, 23);
            this.ClassCombo.TabIndex = 8;
            this.ClassCombo.Text = "Select";
            // 
            // SemesterCombo
            // 
            this.SemesterCombo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SemesterCombo.FormattingEnabled = true;
            this.SemesterCombo.Location = new System.Drawing.Point(399, 30);
            this.SemesterCombo.Name = "SemesterCombo";
            this.SemesterCombo.Size = new System.Drawing.Size(126, 23);
            this.SemesterCombo.TabIndex = 9;
            this.SemesterCombo.Text = "Select";
            // 
            // DatePicker
            // 
            this.DatePicker.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DatePicker.Location = new System.Drawing.Point(531, 30);
            this.DatePicker.Name = "DatePicker";
            this.DatePicker.Size = new System.Drawing.Size(126, 22);
            this.DatePicker.TabIndex = 10;
            // 
            // ModifyAttendance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.ClientSize = new System.Drawing.Size(1184, 727);
            this.Controls.Add(this.Panel);
            this.Controls.Add(this.ToolStrip);
            this.Name = "ModifyAttendance";
            this.Controls.SetChildIndex(this.ToolStrip, 0);
            this.Controls.SetChildIndex(this.Panel, 0);
            this.ToolStrip.ResumeLayout(false);
            this.ToolStrip.PerformLayout();
            this.Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.AttendanceGridView)).EndInit();
            this.ClassGroup.ResumeLayout(false);
            this.TableLayoutPanel.ResumeLayout(false);
            this.TableLayoutPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip ToolStrip;
        private System.Windows.Forms.ToolStripButton AddDetails;
        private System.Windows.Forms.ToolStripButton DataEntry;
        private System.Windows.Forms.ToolStripButton ModifyEntry;
        private System.Windows.Forms.ToolStripButton Logout;
        private System.Windows.Forms.ToolStripButton Reports;
        private System.Windows.Forms.Panel Panel;
        private System.Windows.Forms.Button UpdateButton;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.DataGridView AttendanceGridView;
        private System.Windows.Forms.GroupBox ClassGroup;
        private System.Windows.Forms.TableLayoutPanel TableLayoutPanel;
        private System.Windows.Forms.ComboBox SubjectCombo;
        private System.Windows.Forms.Label SubjectLabel;
        private System.Windows.Forms.Label DateLabel;
        private System.Windows.Forms.Label SemesterLabel;
        private System.Windows.Forms.Label ClassLabel;
        private System.Windows.Forms.Label CourseLabel;
        private System.Windows.Forms.Label YearLabel;
        private System.Windows.Forms.ComboBox CourseCombo;
        private System.Windows.Forms.ComboBox YearCombo;
        private System.Windows.Forms.ComboBox ClassCombo;
        private System.Windows.Forms.ComboBox SemesterCombo;
        private System.Windows.Forms.DateTimePicker DatePicker;
    }
}
