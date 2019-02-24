namespace AttendanceManagementSystem.LoginModule
{
    partial class TeacherLoginModule
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
            this.GroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // GroupBox
            // 
            this.GroupBox.Controls.Add(this.LoginButton);
            this.GroupBox.Controls.Add(this.PasswordBox);
            this.GroupBox.Controls.Add(this.UsernameBox);
            this.GroupBox.Controls.Add(this.ForgotLinkLabel);
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
            this.PasswordBox.Location = new System.Drawing.Point(301, 88);
            this.PasswordBox.Name = "PasswordBox";
            this.PasswordBox.Size = new System.Drawing.Size(143, 22);
            this.PasswordBox.TabIndex = 4;
            // 
            // UsernameBox
            // 
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
            this.UserNameLabel.Location = new System.Drawing.Point(117, 51);
            this.UserNameLabel.Name = "UserNameLabel";
            this.UserNameLabel.Size = new System.Drawing.Size(104, 15);
            this.UserNameLabel.TabIndex = 8;
            this.UserNameLabel.Text = "Enter Username";
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.Location = new System.Drawing.Point(123, 91);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(98, 15);
            this.PasswordLabel.TabIndex = 9;
            this.PasswordLabel.Text = "Enter Password";
            // 
            // TeacherLoginModule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.ClientSize = new System.Drawing.Size(1184, 727);
            this.Controls.Add(this.GroupBox);
            this.Name = "TeacherLoginModule";
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
    }
}
