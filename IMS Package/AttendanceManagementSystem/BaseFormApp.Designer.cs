﻿namespace AttendanceManagementSystem
{
    partial class BaseFormApp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BaseFormApp));
            this.MenuStrip = new System.Windows.Forms.MenuStrip();
            this.Login = new System.Windows.Forms.ToolStripMenuItem();
            this.Registration = new System.Windows.Forms.ToolStripMenuItem();
            this.StatusStrip = new System.Windows.Forms.StatusStrip();
            this.MenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuStrip
            // 
            this.MenuStrip.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar;
            this.MenuStrip.BackColor = System.Drawing.Color.Linen;
            this.MenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Login,
            this.Registration});
            resources.ApplyResources(this.MenuStrip, "MenuStrip");
            this.MenuStrip.Name = "MenuStrip";
            // 
            // Login
            // 
            this.Login.AutoToolTip = true;
            resources.ApplyResources(this.Login, "Login");
            this.Login.Name = "Login";
            this.Login.Click += new System.EventHandler(this.LoginClick);
            // 
            // Registration
            // 
            this.Registration.AutoToolTip = true;
            resources.ApplyResources(this.Registration, "Registration");
            this.Registration.Name = "Registration";
            this.Registration.Click += new System.EventHandler(this.RegisterClick);
            // 
            // StatusStrip
            // 
            this.StatusStrip.AccessibleRole = System.Windows.Forms.AccessibleRole.StatusBar;
            resources.ApplyResources(this.StatusStrip, "StatusStrip");
            this.StatusStrip.Name = "StatusStrip";
            // 
            // BaseFormApp
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.Controls.Add(this.StatusStrip);
            this.Controls.Add(this.MenuStrip);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.MenuStrip;
            this.Name = "BaseFormApp";
            this.MenuStrip.ResumeLayout(false);
            this.MenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MenuStrip;
        private System.Windows.Forms.StatusStrip StatusStrip;
        private System.Windows.Forms.ToolStripMenuItem Login;
        private System.Windows.Forms.ToolStripMenuItem Registration;
    }
}