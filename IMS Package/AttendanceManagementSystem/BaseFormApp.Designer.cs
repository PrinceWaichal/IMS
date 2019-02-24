namespace AttendanceManagementSystem
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
            this.LoginBox = new System.Windows.Forms.ToolStripComboBox();
            this.RegistrationBox = new System.Windows.Forms.ToolStripComboBox();
            this.StatusStrip = new System.Windows.Forms.StatusStrip();
            this.ProgressBar = new System.Windows.Forms.ToolStripProgressBar();
            this.MenuStrip.SuspendLayout();
            this.StatusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuStrip
            // 
            this.MenuStrip.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar;
            this.MenuStrip.BackColor = System.Drawing.Color.Linen;
            this.MenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.LoginBox,
            this.RegistrationBox});
            resources.ApplyResources(this.MenuStrip, "MenuStrip");
            this.MenuStrip.Name = "MenuStrip";
            // 
            // LoginBox
            // 
            this.LoginBox.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuItem;
            this.LoginBox.AutoToolTip = true;
            this.LoginBox.BackColor = System.Drawing.Color.Linen;
            this.LoginBox.Items.AddRange(new object[] {
            resources.GetString("LoginBox.Items"),
            resources.GetString("LoginBox.Items1"),
            resources.GetString("LoginBox.Items2")});
            this.LoginBox.Name = "LoginBox";
            resources.ApplyResources(this.LoginBox, "LoginBox");
            this.LoginBox.Sorted = true;
            this.LoginBox.SelectedIndexChanged += new System.EventHandler(this.LoginIndexChange);
            // 
            // RegistrationBox
            // 
            this.RegistrationBox.BackColor = System.Drawing.Color.Linen;
            this.RegistrationBox.Items.AddRange(new object[] {
            resources.GetString("RegistrationBox.Items"),
            resources.GetString("RegistrationBox.Items1")});
            this.RegistrationBox.Name = "RegistrationBox";
            resources.ApplyResources(this.RegistrationBox, "RegistrationBox");
            this.RegistrationBox.Sorted = true;
            this.RegistrationBox.SelectedIndexChanged += new System.EventHandler(this.RegIndecChange);
            // 
            // StatusStrip
            // 
            this.StatusStrip.AccessibleRole = System.Windows.Forms.AccessibleRole.StatusBar;
            this.StatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ProgressBar});
            resources.ApplyResources(this.StatusStrip, "StatusStrip");
            this.StatusStrip.Name = "StatusStrip";
            // 
            // ProgressBar
            // 
            this.ProgressBar.AccessibleRole = System.Windows.Forms.AccessibleRole.ProgressBar;
            this.ProgressBar.AutoToolTip = true;
            resources.ApplyResources(this.ProgressBar, "ProgressBar");
            this.ProgressBar.MarqueeAnimationSpeed = 90;
            this.ProgressBar.Minimum = 40;
            this.ProgressBar.Name = "ProgressBar";
            this.ProgressBar.Step = 5;
            this.ProgressBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.ProgressBar.Value = 40;
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
            this.StatusStrip.ResumeLayout(false);
            this.StatusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MenuStrip;
        private System.Windows.Forms.StatusStrip StatusStrip;
        private System.Windows.Forms.ToolStripComboBox LoginBox;
        private System.Windows.Forms.ToolStripComboBox RegistrationBox;
        private System.Windows.Forms.ToolStripProgressBar ProgressBar;
    }
}