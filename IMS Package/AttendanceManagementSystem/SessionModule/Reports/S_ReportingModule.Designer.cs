namespace AttendanceManagementSystem.SessionModule.Reports
{
    partial class S_ReportingModule
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(S_ReportingModule));
            this.ToolStrip = new System.Windows.Forms.ToolStrip();
            this.ReportsButton = new System.Windows.Forms.ToolStripButton();
            this.LogoutButton = new System.Windows.Forms.ToolStripButton();
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.ToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // ToolStrip
            // 
            this.ToolStrip.AccessibleRole = System.Windows.Forms.AccessibleRole.ToolTip;
            this.ToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ReportsButton,
            this.LogoutButton});
            this.ToolStrip.Location = new System.Drawing.Point(0, 27);
            this.ToolStrip.Name = "ToolStrip";
            this.ToolStrip.Size = new System.Drawing.Size(1184, 25);
            this.ToolStrip.TabIndex = 4;
            this.ToolStrip.Text = "Tools";
            // 
            // ReportsButton
            // 
            this.ReportsButton.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuItem;
            this.ReportsButton.Image = ((System.Drawing.Image)(resources.GetObject("ReportsButton.Image")));
            this.ReportsButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ReportsButton.Name = "ReportsButton";
            this.ReportsButton.Size = new System.Drawing.Size(67, 22);
            this.ReportsButton.Text = "Reports";
            this.ReportsButton.ToolTipText = "Click to View Report";
            this.ReportsButton.Click += new System.EventHandler(this.ReportsClick);
            // 
            // LogoutButton
            // 
            this.LogoutButton.Image = ((System.Drawing.Image)(resources.GetObject("LogoutButton.Image")));
            this.LogoutButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.LogoutButton.Name = "LogoutButton";
            this.LogoutButton.Size = new System.Drawing.Size(65, 22);
            this.LogoutButton.Text = "Logout";
            this.LogoutButton.ToolTipText = "Click ot Log Out of system";
            this.LogoutButton.Click += new System.EventHandler(this.LogoutClick);
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = -1;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportViewer1.Location = new System.Drawing.Point(0, 52);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.Size = new System.Drawing.Size(1184, 649);
            this.crystalReportViewer1.TabIndex = 5;
            // 
            // S_ReportingModule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.ClientSize = new System.Drawing.Size(1184, 727);
            this.Controls.Add(this.crystalReportViewer1);
            this.Controls.Add(this.ToolStrip);
            this.Name = "S_ReportingModule";
            this.Controls.SetChildIndex(this.ToolStrip, 0);
            this.Controls.SetChildIndex(this.crystalReportViewer1, 0);
            this.ToolStrip.ResumeLayout(false);
            this.ToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip ToolStrip;
        private System.Windows.Forms.ToolStripButton ReportsButton;
        private System.Windows.Forms.ToolStripButton LogoutButton;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
    }
}
