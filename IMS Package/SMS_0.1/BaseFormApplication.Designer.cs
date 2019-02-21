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
            this.LoginMenu = new System.Windows.Forms.ToolStripComboBox();
            this.RegistrationMenu = new System.Windows.Forms.ToolStripComboBox();
            this.ReportsMenu = new System.Windows.Forms.ToolStripComboBox();
            this.MenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuStrip
            // 
            this.MenuStrip.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar;
            this.MenuStrip.BackColor = System.Drawing.Color.Linen;
            this.MenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.LoginMenu,
            this.RegistrationMenu,
            this.ReportsMenu});
            resources.ApplyResources(this.MenuStrip, "MenuStrip");
            this.MenuStrip.Name = "MenuStrip";
            this.MenuStrip.ShowItemToolTips = true;
            // 
            // LoginMenu
            // 
            this.LoginMenu.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuItem;
            this.LoginMenu.AutoToolTip = true;
            this.LoginMenu.BackColor = System.Drawing.Color.Linen;
            this.LoginMenu.DropDownHeight = 100;
            resources.ApplyResources(this.LoginMenu, "LoginMenu");
            this.LoginMenu.Name = "LoginMenu";
            this.LoginMenu.Sorted = true;
            // 
            // RegistrationMenu
            // 
            this.RegistrationMenu.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuItem;
            this.RegistrationMenu.AutoToolTip = true;
            this.RegistrationMenu.BackColor = System.Drawing.Color.Linen;
            this.RegistrationMenu.DropDownHeight = 100;
            resources.ApplyResources(this.RegistrationMenu, "RegistrationMenu");
            this.RegistrationMenu.Name = "RegistrationMenu";
            this.RegistrationMenu.Sorted = true;
            // 
            // ReportsMenu
            // 
            this.ReportsMenu.AutoToolTip = true;
            this.ReportsMenu.BackColor = System.Drawing.Color.Linen;
            this.ReportsMenu.DropDownHeight = 100;
            this.ReportsMenu.DropDownWidth = 100;
            resources.ApplyResources(this.ReportsMenu, "ReportsMenu");
            this.ReportsMenu.Name = "ReportsMenu";
            this.ReportsMenu.Sorted = true;
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
        private System.Windows.Forms.ToolStripComboBox LoginMenu;
        private System.Windows.Forms.ToolStripComboBox RegistrationMenu;
        private System.Windows.Forms.ToolStripComboBox ReportsMenu;
    }
}