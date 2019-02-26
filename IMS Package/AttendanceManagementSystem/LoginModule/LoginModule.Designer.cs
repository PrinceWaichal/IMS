namespace AttendanceManagementSystem.LoginModule
{
    partial class LoginModule
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
            this.GroupBox = new System.Windows.Forms.GroupBox();
            this.LoginButton = new System.Windows.Forms.Button();
            this.PasswordBox = new System.Windows.Forms.TextBox();
            this.UsernameBox = new System.Windows.Forms.TextBox();
            this.ForgotLinkLabel = new System.Windows.Forms.LinkLabel();
            this.UserNameLabel = new System.Windows.Forms.Label();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.UsertypeCombo = new System.Windows.Forms.ComboBox();
            this.UserTypeLabel = new System.Windows.Forms.Label();
            this.GroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // GroupBox
            // 
            this.GroupBox.Controls.Add(this.UsertypeCombo);
            this.GroupBox.Controls.Add(this.LoginButton);
            this.GroupBox.Controls.Add(this.PasswordBox);
            this.GroupBox.Controls.Add(this.UsernameBox);
            this.GroupBox.Controls.Add(this.ForgotLinkLabel);
            this.GroupBox.Controls.Add(this.UserTypeLabel);
            this.GroupBox.Controls.Add(this.UserNameLabel);
            this.GroupBox.Controls.Add(this.PasswordLabel);
            this.GroupBox.Location = new System.Drawing.Point(346, 271);
            this.GroupBox.Name = "GroupBox";
            this.GroupBox.Size = new System.Drawing.Size(492, 184);
            this.GroupBox.TabIndex = 11;
            this.GroupBox.TabStop = false;
            this.GroupBox.Text = "Login Panel";
            // 
            // LoginButton
            // 
            this.LoginButton.Location = new System.Drawing.Point(369, 134);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(75, 23);
            this.LoginButton.TabIndex = 5;
            this.LoginButton.Text = "Login";
            this.LoginButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.LoginButton.UseVisualStyleBackColor = true;
            this.LoginButton.Click += new System.EventHandler(this.LoginClick);
            // 
            // PasswordBox
            // 
            this.PasswordBox.Enabled = false;
            this.PasswordBox.Location = new System.Drawing.Point(301, 88);
            this.PasswordBox.Name = "PasswordBox";
            this.PasswordBox.Size = new System.Drawing.Size(143, 22);
            this.PasswordBox.TabIndex = 4;
            // 
            // UsernameBox
            // 
            this.UsernameBox.Enabled = false;
            this.UsernameBox.Location = new System.Drawing.Point(301, 51);
            this.UsernameBox.Name = "UsernameBox";
            this.UsernameBox.Size = new System.Drawing.Size(143, 22);
            this.UsernameBox.TabIndex = 3;
            // 
            // ForgotLinkLabel
            // 
            this.ForgotLinkLabel.AutoSize = true;
            this.ForgotLinkLabel.LinkColor = System.Drawing.Color.LightSeaGreen;
            this.ForgotLinkLabel.Location = new System.Drawing.Point(118, 134);
            this.ForgotLinkLabel.Name = "ForgotLinkLabel";
            this.ForgotLinkLabel.Size = new System.Drawing.Size(103, 15);
            this.ForgotLinkLabel.TabIndex = 7;
            this.ForgotLinkLabel.TabStop = true;
            this.ForgotLinkLabel.Text = "Forgot Password";
            this.ForgotLinkLabel.VisitedLinkColor = System.Drawing.Color.SpringGreen;
            this.ForgotLinkLabel.Click += new System.EventHandler(this.ForgotClick);
            // 
            // UserNameLabel
            // 
            this.UserNameLabel.AutoSize = true;
            this.UserNameLabel.Location = new System.Drawing.Point(118, 54);
            this.UserNameLabel.Name = "UserNameLabel";
            this.UserNameLabel.Size = new System.Drawing.Size(104, 15);
            this.UserNameLabel.TabIndex = 8;
            this.UserNameLabel.Text = "Enter Username";
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.Location = new System.Drawing.Point(118, 91);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(98, 15);
            this.PasswordLabel.TabIndex = 9;
            this.PasswordLabel.Text = "Enter Password";
            // 
            // UsertypeCombo
            // 
            this.UsertypeCombo.FormattingEnabled = true;
            this.UsertypeCombo.Items.AddRange(new object[] {
            "Admin",
            "Student",
            "Teacher"});
            this.UsertypeCombo.Location = new System.Drawing.Point(301, 17);
            this.UsertypeCombo.Name = "UsertypeCombo";
            this.UsertypeCombo.Size = new System.Drawing.Size(143, 23);
            this.UsertypeCombo.TabIndex = 10;
            this.UsertypeCombo.Text = "Select";
            this.UsertypeCombo.SelectedIndexChanged += new System.EventHandler(this.UsertypeIndexChange);
            // 
            // UserTypeLabel
            // 
            this.UserTypeLabel.AutoSize = true;
            this.UserTypeLabel.Location = new System.Drawing.Point(118, 20);
            this.UserTypeLabel.Name = "UserTypeLabel";
            this.UserTypeLabel.Size = new System.Drawing.Size(68, 15);
            this.UserTypeLabel.TabIndex = 8;
            this.UserTypeLabel.Text = "User Type";
            // 
            // LoginModule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.ClientSize = new System.Drawing.Size(1184, 727);
            this.Controls.Add(this.GroupBox);
            this.Name = "LoginModule";
            this.Controls.SetChildIndex(this.GroupBox, 0);
            this.GroupBox.ResumeLayout(false);
            this.GroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox GroupBox;
        private System.Windows.Forms.Button LoginButton;
        private System.Windows.Forms.TextBox PasswordBox;
        private System.Windows.Forms.TextBox UsernameBox;
        private System.Windows.Forms.LinkLabel ForgotLinkLabel;
        private System.Windows.Forms.Label UserNameLabel;
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.ComboBox UsertypeCombo;
        private System.Windows.Forms.Label UserTypeLabel;
    }
}
