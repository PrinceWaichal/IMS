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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(T_AddAttendance));
            this.ToolStrip = new System.Windows.Forms.ToolStrip();
            this.DataEntry = new System.Windows.Forms.ToolStripButton();
            this.Reports = new System.Windows.Forms.ToolStripButton();
            this.LogOut = new System.Windows.Forms.ToolStripButton();
            this.Panel = new System.Windows.Forms.Panel();
            this.CourseDataGridView = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.labNameCourse = new System.Windows.Forms.Label();
            this.labDuration = new System.Windows.Forms.Label();
            this.labDescriptioin = new System.Windows.Forms.Label();
            this.labFees = new System.Windows.Forms.Label();
            this.cbNameCourse = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.cbDescription = new System.Windows.Forms.ComboBox();
            this.cbDuration = new System.Windows.Forms.ComboBox();
            this.cbFees = new System.Windows.Forms.ComboBox();
            this.Delete = new System.Windows.Forms.Button();
            this.Update = new System.Windows.Forms.Button();
            this.Add = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.ToolStrip.SuspendLayout();
            this.Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CourseDataGridView)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // ToolStrip
            // 
            this.ToolStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.DataEntry,
            this.Reports,
            this.LogOut});
            this.ToolStrip.Location = new System.Drawing.Point(0, 28);
            this.ToolStrip.Name = "ToolStrip";
            this.ToolStrip.Size = new System.Drawing.Size(1848, 27);
            this.ToolStrip.TabIndex = 5;
            this.ToolStrip.Text = "ToolStrip";
            // 
            // DataEntry
            // 
            this.DataEntry.Image = ((System.Drawing.Image)(resources.GetObject("DataEntry.Image")));
            this.DataEntry.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.DataEntry.Name = "DataEntry";
            this.DataEntry.Size = new System.Drawing.Size(102, 24);
            this.DataEntry.Text = "Data Entry";
            this.DataEntry.ToolTipText = "Click to Enter Data";
            this.DataEntry.Click += new System.EventHandler(this.EntryClick);
            // 
            // Reports
            // 
            this.Reports.Image = ((System.Drawing.Image)(resources.GetObject("Reports.Image")));
            this.Reports.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Reports.Name = "Reports";
            this.Reports.Size = new System.Drawing.Size(84, 24);
            this.Reports.Text = "Reports";
            this.Reports.ToolTipText = "Click to View Reports";
            this.Reports.Click += new System.EventHandler(this.ReportsClick);
            // 
            // LogOut
            // 
            this.LogOut.Image = ((System.Drawing.Image)(resources.GetObject("LogOut.Image")));
            this.LogOut.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.LogOut.Name = "LogOut";
            this.LogOut.Size = new System.Drawing.Size(80, 24);
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
            this.Panel.Location = new System.Drawing.Point(0, 55);
            this.Panel.Margin = new System.Windows.Forms.Padding(4);
            this.Panel.Name = "Panel";
            this.Panel.Size = new System.Drawing.Size(1848, 888);
            this.Panel.TabIndex = 6;
            // 
            // CourseDataGridView
            // 
            this.CourseDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CourseDataGridView.Location = new System.Drawing.Point(34, 85);
            this.CourseDataGridView.Margin = new System.Windows.Forms.Padding(4);
            this.CourseDataGridView.Name = "CourseDataGridView";
            this.CourseDataGridView.Size = new System.Drawing.Size(578, 563);
            this.CourseDataGridView.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tableLayoutPanel1);
            this.groupBox2.Location = new System.Drawing.Point(659, 85);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(402, 175);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Course details";
            // 
            // labNameCourse
            // 
            this.labNameCourse.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labNameCourse.AutoSize = true;
            this.labNameCourse.Location = new System.Drawing.Point(3, 8);
            this.labNameCourse.Name = "labNameCourse";
            this.labNameCourse.Size = new System.Drawing.Size(126, 19);
            this.labNameCourse.TabIndex = 0;
            this.labNameCourse.Text = "Name of course";
            // 
            // labDuration
            // 
            this.labDuration.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labDuration.AutoSize = true;
            this.labDuration.Location = new System.Drawing.Point(3, 78);
            this.labDuration.Name = "labDuration";
            this.labDuration.Size = new System.Drawing.Size(179, 19);
            this.labDuration.TabIndex = 0;
            this.labDuration.Text = "Duration of the course";
            // 
            // labDescriptioin
            // 
            this.labDescriptioin.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labDescriptioin.AutoSize = true;
            this.labDescriptioin.Location = new System.Drawing.Point(3, 43);
            this.labDescriptioin.Name = "labDescriptioin";
            this.labDescriptioin.Size = new System.Drawing.Size(96, 19);
            this.labDescriptioin.TabIndex = 0;
            this.labDescriptioin.Text = "Description";
            // 
            // labFees
            // 
            this.labFees.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labFees.AutoSize = true;
            this.labFees.Location = new System.Drawing.Point(3, 113);
            this.labFees.Name = "labFees";
            this.labFees.Size = new System.Drawing.Size(42, 19);
            this.labFees.TabIndex = 0;
            this.labFees.Text = "Fees";
            // 
            // cbNameCourse
            // 
            this.cbNameCourse.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbNameCourse.FormattingEnabled = true;
            this.cbNameCourse.Location = new System.Drawing.Point(189, 3);
            this.cbNameCourse.Name = "cbNameCourse";
            this.cbNameCourse.Size = new System.Drawing.Size(181, 27);
            this.cbNameCourse.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.labNameCourse, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.cbNameCourse, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.labDescriptioin, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.labDuration, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.labFees, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.cbDescription, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.cbDuration, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.cbFees, 1, 3);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(20, 25);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(373, 140);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // cbDescription
            // 
            this.cbDescription.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbDescription.FormattingEnabled = true;
            this.cbDescription.Location = new System.Drawing.Point(189, 38);
            this.cbDescription.Name = "cbDescription";
            this.cbDescription.Size = new System.Drawing.Size(181, 27);
            this.cbDescription.TabIndex = 1;
            // 
            // cbDuration
            // 
            this.cbDuration.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbDuration.FormattingEnabled = true;
            this.cbDuration.Location = new System.Drawing.Point(189, 73);
            this.cbDuration.Name = "cbDuration";
            this.cbDuration.Size = new System.Drawing.Size(181, 27);
            this.cbDuration.TabIndex = 1;
            // 
            // cbFees
            // 
            this.cbFees.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbFees.FormattingEnabled = true;
            this.cbFees.Location = new System.Drawing.Point(189, 108);
            this.cbFees.Name = "cbFees";
            this.cbFees.Size = new System.Drawing.Size(181, 27);
            this.cbFees.TabIndex = 1;
            // 
            // Delete
            // 
            this.Delete.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Delete.Location = new System.Drawing.Point(243, 3);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(117, 31);
            this.Delete.TabIndex = 8;
            this.Delete.Text = "Delete";
            this.Delete.UseVisualStyleBackColor = true;
            // 
            // Update
            // 
            this.Update.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Update.Location = new System.Drawing.Point(123, 3);
            this.Update.Name = "Update";
            this.Update.Size = new System.Drawing.Size(114, 31);
            this.Update.TabIndex = 8;
            this.Update.Text = "Update";
            this.Update.UseVisualStyleBackColor = true;
            // 
            // Add
            // 
            this.Add.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Add.Location = new System.Drawing.Point(3, 3);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(114, 31);
            this.Add.TabIndex = 8;
            this.Add.Text = "Add";
            this.Add.UseVisualStyleBackColor = true;
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
            this.tableLayoutPanel2.Location = new System.Drawing.Point(686, 281);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(363, 37);
            this.tableLayoutPanel2.TabIndex = 9;
            // 
            // T_AddAttendance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.ClientSize = new System.Drawing.Size(1848, 981);
            this.Controls.Add(this.Panel);
            this.Controls.Add(this.ToolStrip);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MinimumSize = new System.Drawing.Size(1866, 1028);
            this.Name = "T_AddAttendance";
            this.Controls.SetChildIndex(this.ToolStrip, 0);
            this.Controls.SetChildIndex(this.Panel, 0);
            this.ToolStrip.ResumeLayout(false);
            this.ToolStrip.PerformLayout();
            this.Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.CourseDataGridView)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
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
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label labNameCourse;
        private System.Windows.Forms.ComboBox cbNameCourse;
        private System.Windows.Forms.Label labDescriptioin;
        private System.Windows.Forms.Label labDuration;
        private System.Windows.Forms.Label labFees;
        private System.Windows.Forms.ComboBox cbDescription;
        private System.Windows.Forms.ComboBox cbDuration;
        private System.Windows.Forms.ComboBox cbFees;
    }
}
