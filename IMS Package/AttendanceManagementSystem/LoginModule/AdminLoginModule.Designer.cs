namespace AttendanceManagementSystem.LoginModule
{
    partial class AdminLoginModule
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
            this.RadioAdmin = new System.Windows.Forms.RadioButton();
            this.RadioTeach = new System.Windows.Forms.RadioButton();
            this.PasswordBox = new System.Windows.Forms.TextBox();
            this.RadioStudent = new System.Windows.Forms.RadioButton();
            this.UsernameBox = new System.Windows.Forms.TextBox();
            this.ForgotLinkLabel = new System.Windows.Forms.LinkLabel();
            this.UserNameLabel = new System.Windows.Forms.Label();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.HomeButton = new System.Windows.Forms.Button();
            this.GroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // GroupBox
            // 
            this.GroupBox.Controls.Add(this.LoginButton);
            this.GroupBox.Controls.Add(this.RadioAdmin);
            this.GroupBox.Controls.Add(this.RadioTeach);
            this.GroupBox.Controls.Add(this.PasswordBox);
            this.GroupBox.Controls.Add(this.RadioStudent);
            this.GroupBox.Controls.Add(this.UsernameBox);
            this.GroupBox.Controls.Add(this.ForgotLinkLabel);
            this.GroupBox.Controls.Add(this.UserNameLabel);
            this.GroupBox.Controls.Add(this.PasswordLabel);
            this.GroupBox.Controls.Add(this.HomeButton);
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
            // 
            // RadioAdmin
            // 
            this.RadioAdmin.AutoSize = true;
            this.RadioAdmin.Location = new System.Drawing.Point(14, 21);
            this.RadioAdmin.Name = "RadioAdmin";
            this.RadioAdmin.Size = new System.Drawing.Size(102, 19);
            this.RadioAdmin.TabIndex = 0;
            this.RadioAdmin.TabStop = true;
            this.RadioAdmin.Text = "Admin Login";
            this.RadioAdmin.UseVisualStyleBackColor = true;
            // 
            // RadioTeach
            // 
            this.RadioTeach.AutoSize = true;
            this.RadioTeach.Location = new System.Drawing.Point(204, 21);
            this.RadioTeach.Name = "RadioTeach";
            this.RadioTeach.Size = new System.Drawing.Size(107, 19);
            this.RadioTeach.TabIndex = 1;
            this.RadioTeach.TabStop = true;
            this.RadioTeach.Text = "Teacher Login";
            this.RadioTeach.UseVisualStyleBackColor = true;
            // 
            // PasswordBox
            // 
            this.PasswordBox.Location = new System.Drawing.Point(301, 88);
            this.PasswordBox.Name = "PasswordBox";
            this.PasswordBox.Size = new System.Drawing.Size(143, 22);
            this.PasswordBox.TabIndex = 4;
            // 
            // RadioStudent
            // 
            this.RadioStudent.AutoSize = true;
            this.RadioStudent.Location = new System.Drawing.Point(384, 21);
            this.RadioStudent.Name = "RadioStudent";
            this.RadioStudent.Size = new System.Drawing.Size(106, 19);
            this.RadioStudent.TabIndex = 2;
            this.RadioStudent.TabStop = true;
            this.RadioStudent.Text = "Student Login";
            this.RadioStudent.UseVisualStyleBackColor = true;
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
            this.ForgotLinkLabel.Location = new System.Drawing.Point(18, 134);
            this.ForgotLinkLabel.Name = "ForgotLinkLabel";
            this.ForgotLinkLabel.Size = new System.Drawing.Size(103, 15);
            this.ForgotLinkLabel.TabIndex = 7;
            this.ForgotLinkLabel.TabStop = true;
            this.ForgotLinkLabel.Text = "Forgot Password";
            this.ForgotLinkLabel.VisitedLinkColor = System.Drawing.Color.SpringGreen;
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
            // HomeButton
            // 
            this.HomeButton.Location = new System.Drawing.Point(204, 134);
            this.HomeButton.Name = "HomeButton";
            this.HomeButton.Size = new System.Drawing.Size(75, 23);
            this.HomeButton.TabIndex = 6;
            this.HomeButton.Text = "Register";
            this.HomeButton.UseVisualStyleBackColor = true;
            // 
            // AdminLoginModule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.ClientSize = new System.Drawing.Size(1184, 727);
            this.Controls.Add(this.GroupBox);
            this.Name = "AdminLoginModule";
            this.Controls.SetChildIndex(this.GroupBox, 0);
            this.GroupBox.ResumeLayout(false);
            this.GroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox GroupBox;
        private System.Windows.Forms.Button LoginButton;
        private System.Windows.Forms.RadioButton RadioAdmin;
        private System.Windows.Forms.RadioButton RadioTeach;
        private System.Windows.Forms.TextBox PasswordBox;
        private System.Windows.Forms.RadioButton RadioStudent;
        private System.Windows.Forms.TextBox UsernameBox;
        private System.Windows.Forms.LinkLabel ForgotLinkLabel;
        private System.Windows.Forms.Label UserNameLabel;
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.Button HomeButton;
    }
}
