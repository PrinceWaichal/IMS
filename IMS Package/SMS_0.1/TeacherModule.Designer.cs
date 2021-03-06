﻿namespace SMS_0._1
{
    partial class TeacherModule
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TeacherModule));
            this.ToolStrip = new System.Windows.Forms.ToolStrip();
            this.EnterData = new System.Windows.Forms.ToolStripButton();
            this.Reports = new System.Windows.Forms.ToolStripButton();
            this.LogOut = new System.Windows.Forms.ToolStripButton();
            this.ToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // ToolStrip
            // 
            this.ToolStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.EnterData,
            this.Reports,
            this.LogOut});
            this.ToolStrip.Location = new System.Drawing.Point(0, 28);
            this.ToolStrip.Name = "ToolStrip";
            this.ToolStrip.Size = new System.Drawing.Size(896, 27);
            this.ToolStrip.TabIndex = 1;
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
            this.EnterData.Click += new System.EventHandler(this.DataEntryClick);
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
            this.LogOut.Size = new System.Drawing.Size(74, 24);
            this.LogOut.Text = "Log Out";
            this.LogOut.ToolTipText = "Click to Log Out of System";
            this.LogOut.Click += new System.EventHandler(this.LogoutClick);
            // 
            // TeacherModule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.ClientSize = new System.Drawing.Size(896, 435);
            this.Controls.Add(this.ToolStrip);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "TeacherModule";
            this.Text = "Attendance Management System";
            this.Load += new System.EventHandler(this.TeachModLoad);
            this.Controls.SetChildIndex(this.ToolStrip, 0);
            this.ToolStrip.ResumeLayout(false);
            this.ToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip ToolStrip;
        private System.Windows.Forms.ToolStripButton EnterData;
        private System.Windows.Forms.ToolStripButton Reports;
        private System.Windows.Forms.ToolStripButton LogOut;
    }
}
