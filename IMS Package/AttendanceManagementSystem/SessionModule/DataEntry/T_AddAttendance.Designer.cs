namespace AttendanceManagementSystem.SessionModule.DataEntry
{
    partial class T_AddAttendance
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(T_AddAttendance));
            this.ToolStrip = new System.Windows.Forms.ToolStrip();
            this.DataEntry = new System.Windows.Forms.ToolStripButton();
            this.Reports = new System.Windows.Forms.ToolStripButton();
            this.LogOut = new System.Windows.Forms.ToolStripButton();
            this.Panel = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.Add = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            this.Update = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.CourseDataGridView = new System.Windows.Forms.DataGridView();
            this.courseTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aMSDBDataSet = new AttendanceManagementSystem.DatabseFiles.AMSDBDataSet();
            this.courseTableTableAdapter = new AttendanceManagementSystem.DatabseFiles.AMSDBDataSetTableAdapters.CourseTableTableAdapter();
            this.labFees = new System.Windows.Forms.Label();
            this.labDuration = new System.Windows.Forms.Label();
            this.labDescriptioin = new System.Windows.Forms.Label();
            this.labNameCourse = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.CourseName = new System.Windows.Forms.TextBox();
            this.CourseDescription = new System.Windows.Forms.TextBox();
            this.CourseDuration = new System.Windows.Forms.TextBox();
            this.Fees = new System.Windows.Forms.TextBox();
            this.ToolStrip.SuspendLayout();
            this.Panel.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CourseDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aMSDBDataSet)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ToolStrip
            // 
            this.ToolStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.DataEntry,
            this.Reports,
            this.LogOut});
            this.ToolStrip.Location = new System.Drawing.Point(0, 24);
            this.ToolStrip.Name = "ToolStrip";
            this.ToolStrip.Size = new System.Drawing.Size(1078, 27);
            this.ToolStrip.TabIndex = 5;
            this.ToolStrip.Text = "ToolStrip";
            // 
            // DataEntry
            // 
            this.DataEntry.Image = ((System.Drawing.Image)(resources.GetObject("DataEntry.Image")));
            this.DataEntry.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.DataEntry.Name = "DataEntry";
            this.DataEntry.Size = new System.Drawing.Size(85, 24);
            this.DataEntry.Text = "Data Entry";
            this.DataEntry.ToolTipText = "Click to Enter Data";
            this.DataEntry.Click += new System.EventHandler(this.EntryClick);
            // 
            // Reports
            // 
            this.Reports.Image = ((System.Drawing.Image)(resources.GetObject("Reports.Image")));
            this.Reports.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Reports.Name = "Reports";
            this.Reports.Size = new System.Drawing.Size(71, 24);
            this.Reports.Text = "Reports";
            this.Reports.ToolTipText = "Click to View Reports";
            this.Reports.Click += new System.EventHandler(this.ReportsClick);
            // 
            // LogOut
            // 
            this.LogOut.Image = ((System.Drawing.Image)(resources.GetObject("LogOut.Image")));
            this.LogOut.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.LogOut.Name = "LogOut";
            this.LogOut.Size = new System.Drawing.Size(69, 24);
            this.LogOut.Text = "Logout";
            this.LogOut.ToolTipText = "Click to log out of system";
            this.LogOut.Click += new System.EventHandler(this.LogoutClick);
            // 
            // Panel
            // 
            this.Panel.AutoScroll = true;
            this.Panel.AutoSize = true;
            this.Panel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Panel.Controls.Add(this.tableLayoutPanel2);
            this.Panel.Controls.Add(this.groupBox2);
            this.Panel.Controls.Add(this.CourseDataGridView);
            this.Panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel.Location = new System.Drawing.Point(0, 51);
            this.Panel.Name = "Panel";
            this.Panel.Size = new System.Drawing.Size(1078, 521);
            this.Panel.TabIndex = 6;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.Controls.Add(this.Add, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.Delete, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.Update, 1, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(549, 225);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(290, 30);
            this.tableLayoutPanel2.TabIndex = 9;
            // 
            // Add
            // 
            this.Add.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Add.Location = new System.Drawing.Point(2, 2);
            this.Add.Margin = new System.Windows.Forms.Padding(2);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(92, 26);
            this.Add.TabIndex = 8;
            this.Add.Text = "Add";
            this.Add.UseVisualStyleBackColor = true;
            // 
            // Delete
            // 
            this.Delete.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Delete.Location = new System.Drawing.Point(194, 2);
            this.Delete.Margin = new System.Windows.Forms.Padding(2);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(94, 26);
            this.Delete.TabIndex = 8;
            this.Delete.Text = "Delete";
            this.Delete.UseVisualStyleBackColor = true;
            // 
            // Update
            // 
            this.Update.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Update.Location = new System.Drawing.Point(98, 2);
            this.Update.Margin = new System.Windows.Forms.Padding(2);
            this.Update.Name = "Update";
            this.Update.Size = new System.Drawing.Size(92, 26);
            this.Update.TabIndex = 8;
            this.Update.Text = "Update";
            this.Update.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tableLayoutPanel1);
            this.groupBox2.Location = new System.Drawing.Point(527, 68);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(322, 140);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Course details";
            // 
            // CourseDataGridView
            // 
            this.CourseDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CourseDataGridView.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.courseTableBindingSource, "CourseName", true));
            this.CourseDataGridView.Location = new System.Drawing.Point(27, 68);
            this.CourseDataGridView.Name = "CourseDataGridView";
            this.CourseDataGridView.Size = new System.Drawing.Size(462, 450);
            this.CourseDataGridView.TabIndex = 1;
            // 
            // courseTableBindingSource
            // 
            this.courseTableBindingSource.DataMember = "CourseTable";
            this.courseTableBindingSource.DataSource = this.aMSDBDataSet;
            // 
            // aMSDBDataSet
            // 
            this.aMSDBDataSet.DataSetName = "AMSDBDataSet";
            this.aMSDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // courseTableTableAdapter
            // 
            this.courseTableTableAdapter.ClearBeforeFill = true;
            // 
            // labFees
            // 
            this.labFees.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labFees.AutoSize = true;
            this.labFees.Location = new System.Drawing.Point(2, 90);
            this.labFees.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labFees.Name = "labFees";
            this.labFees.Size = new System.Drawing.Size(32, 15);
            this.labFees.TabIndex = 0;
            this.labFees.Text = "Fees";
            // 
            // labDuration
            // 
            this.labDuration.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labDuration.AutoSize = true;
            this.labDuration.Location = new System.Drawing.Point(2, 62);
            this.labDuration.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labDuration.Name = "labDuration";
            this.labDuration.Size = new System.Drawing.Size(140, 15);
            this.labDuration.TabIndex = 0;
            this.labDuration.Text = "Duration of the course";
            // 
            // labDescriptioin
            // 
            this.labDescriptioin.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labDescriptioin.AutoSize = true;
            this.labDescriptioin.Location = new System.Drawing.Point(2, 34);
            this.labDescriptioin.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labDescriptioin.Name = "labDescriptioin";
            this.labDescriptioin.Size = new System.Drawing.Size(75, 15);
            this.labDescriptioin.TabIndex = 0;
            this.labDescriptioin.Text = "Description";
            // 
            // labNameCourse
            // 
            this.labNameCourse.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labNameCourse.AutoSize = true;
            this.labNameCourse.Location = new System.Drawing.Point(2, 6);
            this.labNameCourse.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labNameCourse.Name = "labNameCourse";
            this.labNameCourse.Size = new System.Drawing.Size(98, 15);
            this.labNameCourse.TabIndex = 0;
            this.labNameCourse.Text = "Name of course";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.labNameCourse, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.labDescriptioin, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.labDuration, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.labFees, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.CourseName, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.CourseDescription, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.CourseDuration, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.Fees, 1, 3);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(16, 20);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(298, 112);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // CourseName
            // 
            this.CourseName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CourseName.Location = new System.Drawing.Point(152, 3);
            this.CourseName.Name = "CourseName";
            this.CourseName.Size = new System.Drawing.Size(143, 22);
            this.CourseName.TabIndex = 1;
            // 
            // CourseDescription
            // 
            this.CourseDescription.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CourseDescription.Location = new System.Drawing.Point(152, 31);
            this.CourseDescription.Name = "CourseDescription";
            this.CourseDescription.Size = new System.Drawing.Size(143, 22);
            this.CourseDescription.TabIndex = 2;
            // 
            // CourseDuration
            // 
            this.CourseDuration.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CourseDuration.Location = new System.Drawing.Point(152, 59);
            this.CourseDuration.Name = "CourseDuration";
            this.CourseDuration.Size = new System.Drawing.Size(143, 22);
            this.CourseDuration.TabIndex = 3;
            // 
            // Fees
            // 
            this.Fees.AccessibleRole = System.Windows.Forms.AccessibleRole.Document;
            this.Fees.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Fees.Location = new System.Drawing.Point(152, 87);
            this.Fees.Name = "Fees";
            this.Fees.Size = new System.Drawing.Size(143, 22);
            this.Fees.TabIndex = 4;
            // 
            // T_AddAttendance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.ClientSize = new System.Drawing.Size(1078, 594);
            this.Controls.Add(this.Panel);
            this.Controls.Add(this.ToolStrip);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(1094, 621);
            this.Name = "T_AddAttendance";
            this.Load += new System.EventHandler(this.T_AddAttendance_Load);
            this.Controls.SetChildIndex(this.ToolStrip, 0);
            this.Controls.SetChildIndex(this.Panel, 0);
            this.ToolStrip.ResumeLayout(false);
            this.ToolStrip.PerformLayout();
            this.Panel.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.CourseDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aMSDBDataSet)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip ToolStrip;
        private System.Windows.Forms.ToolStripButton DataEntry;
        private System.Windows.Forms.ToolStripButton Reports;
        private System.Windows.Forms.ToolStripButton LogOut;
        private System.Windows.Forms.Panel Panel;
        private System.Windows.Forms.DataGridView CourseDataGridView;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Button Update;
        private System.Windows.Forms.GroupBox groupBox2;
        private DatabseFiles.AMSDBDataSet aMSDBDataSet;
        private System.Windows.Forms.BindingSource courseTableBindingSource;
        private DatabseFiles.AMSDBDataSetTableAdapters.CourseTableTableAdapter courseTableTableAdapter;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label labNameCourse;
        private System.Windows.Forms.Label labDescriptioin;
        private System.Windows.Forms.Label labDuration;
        private System.Windows.Forms.Label labFees;
        private System.Windows.Forms.TextBox CourseName;
        private System.Windows.Forms.TextBox CourseDescription;
        private System.Windows.Forms.TextBox CourseDuration;
        private System.Windows.Forms.TextBox Fees;
    }
}
