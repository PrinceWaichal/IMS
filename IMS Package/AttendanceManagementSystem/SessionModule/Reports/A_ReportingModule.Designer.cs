namespace AttendanceManagementSystem.SessionModule.Reports
{
    partial class A_ReportingModule
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(A_ReportingModule));
            this.ToolStrip = new System.Windows.Forms.ToolStrip();
            this.AddDetails = new System.Windows.Forms.ToolStripButton();
            this.DataEntry = new System.Windows.Forms.ToolStripButton();
            this.ModifyEntry = new System.Windows.Forms.ToolStripButton();
            this.Reports = new System.Windows.Forms.ToolStripButton();
            this.Logout = new System.Windows.Forms.ToolStripButton();
            this.ToolStrip.SuspendLayout();
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
            this.ToolStrip.Location = new System.Drawing.Point(0, 27);
            this.ToolStrip.Name = "ToolStrip";
            this.ToolStrip.Size = new System.Drawing.Size(784, 25);
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
            // A_ReportingModule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.ClientSize = new System.Drawing.Size(784, 361);
            this.Controls.Add(this.ToolStrip);
            this.Name = "A_ReportingModule";
            this.Controls.SetChildIndex(this.ToolStrip, 0);
            this.ToolStrip.ResumeLayout(false);
            this.ToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip ToolStrip;
        private System.Windows.Forms.ToolStripButton AddDetails;
        private System.Windows.Forms.ToolStripButton DataEntry;
        private System.Windows.Forms.ToolStripButton ModifyEntry;
        private System.Windows.Forms.ToolStripButton Reports;
        private System.Windows.Forms.ToolStripButton Logout;
    }
}
