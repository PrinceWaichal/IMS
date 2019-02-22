namespace SMS_0._1
{
    partial class BaseFormApplication
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BaseFormApplication));
            this.MenuStrip = new System.Windows.Forms.MenuStrip();
            this.Login = new System.Windows.Forms.ToolStripMenuItem();
            this.Registration = new System.Windows.Forms.ToolStripMenuItem();
            this.Reports = new System.Windows.Forms.ToolStripMenuItem();
            this.Input = new System.Windows.Forms.ToolStripComboBox();
            this.MenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuStrip
            // 
            this.MenuStrip.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar;
            this.MenuStrip.BackColor = System.Drawing.Color.Linen;
            this.MenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.MenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Login,
            this.Registration,
            this.Input,
            this.Reports});
            resources.ApplyResources(this.MenuStrip, "MenuStrip");
            this.MenuStrip.Name = "MenuStrip";
            this.MenuStrip.ShowItemToolTips = true;
            // 
            // Login
            // 
            this.Login.AutoToolTip = true;
            this.Login.Name = "Login";
            resources.ApplyResources(this.Login, "Login");
            this.Login.Click += new System.EventHandler(this.Login_Click);
            // 
            // Registration
            // 
            this.Registration.AutoToolTip = true;
            this.Registration.Name = "Registration";
            resources.ApplyResources(this.Registration, "Registration");
            this.Registration.Click += new System.EventHandler(this.Registration_Click);
            // 
            // Reports
            // 
            this.Reports.AutoToolTip = true;
            this.Reports.Name = "Reports";
            resources.ApplyResources(this.Reports, "Reports");
            // 
            // Input
            // 
            this.Input.AutoToolTip = true;
            this.Input.BackColor = System.Drawing.Color.Linen;
            this.Input.Name = "Input";
            resources.ApplyResources(this.Input, "Input");
            this.Input.Sorted = true;
            // 
            // BaseFormApplication
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.Window;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.Controls.Add(this.MenuStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.MenuStrip;
            this.Name = "BaseFormApplication";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.MenuStrip.ResumeLayout(false);
            this.MenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MenuStrip;
        private System.Windows.Forms.ToolStripMenuItem Login;
        private System.Windows.Forms.ToolStripMenuItem Registration;
        private System.Windows.Forms.ToolStripComboBox Input;
        private System.Windows.Forms.ToolStripMenuItem Reports;
    }
}