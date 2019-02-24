﻿namespace SMS_0._1
{
    partial class AdminModule
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminModule));
            this.ToolStrip = new System.Windows.Forms.ToolStrip();
            this.EnterData = new System.Windows.Forms.ToolStripButton();
            this.Reports = new System.Windows.Forms.ToolStripButton();
            this.LogOut = new System.Windows.Forms.ToolStripButton();
            this.AddorModify = new System.Windows.Forms.ToolStripButton();
            this.ToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // ToolStrip
            // 
            this.ToolStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddorModify,
            this.EnterData,
            this.Reports,
            this.LogOut});
            this.ToolStrip.Location = new System.Drawing.Point(0, 30);
            this.ToolStrip.Name = "ToolStrip";
            this.ToolStrip.Size = new System.Drawing.Size(1120, 27);
            this.ToolStrip.TabIndex = 2;
            this.ToolStrip.Text = "toolStrip1";
            // 
            // EnterData
            // 
            this.EnterData.Image = ((System.Drawing.Image)(resources.GetObject("EnterData.Image")));
            this.EnterData.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.EnterData.Name = "EnterData";
            this.EnterData.Size = new System.Drawing.Size(102, 24);
            this.EnterData.Text = "Data Entry";
            this.EnterData.ToolTipText = "Click to Enter Attendance Details";
            this.EnterData.Click += new System.EventHandler(this.DataEntryClick);
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
            this.LogOut.Size = new System.Drawing.Size(86, 24);
            this.LogOut.Text = "Log Out";
            this.LogOut.ToolTipText = "Click to Log Out of System";
            this.LogOut.Click += new System.EventHandler(this.LogOutClick);
            // 
            // AddorModify
            // 
            this.AddorModify.Image = ((System.Drawing.Image)(resources.GetObject("AddorModify.Image")));
            this.AddorModify.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.AddorModify.Name = "AddorModify";
            this.AddorModify.Size = new System.Drawing.Size(130, 24);
            this.AddorModify.Text = "Add or Modify";
            this.AddorModify.ToolTipText = "Add or Modify Datatables";
            this.AddorModify.Click += new System.EventHandler(this.AddorModifyClick);
            // 
            // AdminModule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.ClientSize = new System.Drawing.Size(1120, 551);
            this.Controls.Add(this.ToolStrip);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "AdminModule";
            this.Load += new System.EventHandler(this.AdminModLoad);
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
        private System.Windows.Forms.ToolStripButton AddorModify;
    }
}
