namespace SMS_0._1
{
    partial class ForgotPasswordModule
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
            this.Panel = new System.Windows.Forms.Panel();
            this.PasswordRestGroupBox = new System.Windows.Forms.GroupBox();
            this.ResetButton = new System.Windows.Forms.Button();
            this.CheckButton = new System.Windows.Forms.Button();
            this.RadioAdmin = new System.Windows.Forms.RadioButton();
            this.RadioTeach = new System.Windows.Forms.RadioButton();
            this.ConfirmPasswordBox = new System.Windows.Forms.TextBox();
            this.PasswordBox = new System.Windows.Forms.TextBox();
            this.RadioStudent = new System.Windows.Forms.RadioButton();
            this.MobileTextBox = new System.Windows.Forms.TextBox();
            this.EmailTextBox = new System.Windows.Forms.TextBox();
            this.UsernameBox = new System.Windows.Forms.TextBox();
            this.MobileNumberLabel = new System.Windows.Forms.Label();
            this.MobileLabel = new System.Windows.Forms.Label();
            this.UserNameLabel = new System.Windows.Forms.Label();
            this.ConfirmPassLabel = new System.Windows.Forms.Label();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.HomeButton = new System.Windows.Forms.Button();
            this.Panel.SuspendLayout();
            this.PasswordRestGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // Panel
            // 
            this.Panel.Controls.Add(this.PasswordRestGroupBox);
            this.Panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel.Location = new System.Drawing.Point(0, 24);
            this.Panel.Name = "Panel";
            this.Panel.Size = new System.Drawing.Size(896, 411);
            this.Panel.TabIndex = 1;
            // 
            // PasswordRestGroupBox
            // 
            this.PasswordRestGroupBox.Controls.Add(this.ResetButton);
            this.PasswordRestGroupBox.Controls.Add(this.CheckButton);
            this.PasswordRestGroupBox.Controls.Add(this.RadioAdmin);
            this.PasswordRestGroupBox.Controls.Add(this.RadioTeach);
            this.PasswordRestGroupBox.Controls.Add(this.ConfirmPasswordBox);
            this.PasswordRestGroupBox.Controls.Add(this.PasswordBox);
            this.PasswordRestGroupBox.Controls.Add(this.RadioStudent);
            this.PasswordRestGroupBox.Controls.Add(this.MobileTextBox);
            this.PasswordRestGroupBox.Controls.Add(this.EmailTextBox);
            this.PasswordRestGroupBox.Controls.Add(this.UsernameBox);
            this.PasswordRestGroupBox.Controls.Add(this.MobileNumberLabel);
            this.PasswordRestGroupBox.Controls.Add(this.MobileLabel);
            this.PasswordRestGroupBox.Controls.Add(this.UserNameLabel);
            this.PasswordRestGroupBox.Controls.Add(this.ConfirmPassLabel);
            this.PasswordRestGroupBox.Controls.Add(this.PasswordLabel);
            this.PasswordRestGroupBox.Controls.Add(this.HomeButton);
            this.PasswordRestGroupBox.Location = new System.Drawing.Point(187, 68);
            this.PasswordRestGroupBox.Name = "PasswordRestGroupBox";
            this.PasswordRestGroupBox.Size = new System.Drawing.Size(468, 254);
            this.PasswordRestGroupBox.TabIndex = 11;
            this.PasswordRestGroupBox.TabStop = false;
            this.PasswordRestGroupBox.Text = "Forgot Password";
            // 
            // ResetButton
            // 
            this.ResetButton.Location = new System.Drawing.Point(367, 219);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(75, 23);
            this.ResetButton.TabIndex = 9;
            this.ResetButton.Text = "Reset";
            this.ResetButton.UseVisualStyleBackColor = true;
            this.ResetButton.Click += new System.EventHandler(this.ResetClick);
            // 
            // CheckButton
            // 
            this.CheckButton.Location = new System.Drawing.Point(367, 134);
            this.CheckButton.Name = "CheckButton";
            this.CheckButton.Size = new System.Drawing.Size(75, 23);
            this.CheckButton.TabIndex = 6;
            this.CheckButton.Text = "Check";
            this.CheckButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.CheckButton.UseVisualStyleBackColor = true;
            this.CheckButton.Click += new System.EventHandler(this.CheckClick);
            // 
            // RadioAdmin
            // 
            this.RadioAdmin.AutoSize = true;
            this.RadioAdmin.Location = new System.Drawing.Point(14, 21);
            this.RadioAdmin.Name = "RadioAdmin";
            this.RadioAdmin.Size = new System.Drawing.Size(66, 19);
            this.RadioAdmin.TabIndex = 0;
            this.RadioAdmin.TabStop = true;
            this.RadioAdmin.Text = "Admin";
            this.RadioAdmin.UseVisualStyleBackColor = true;
            // 
            // RadioTeach
            // 
            this.RadioTeach.AutoSize = true;
            this.RadioTeach.Location = new System.Drawing.Point(204, 21);
            this.RadioTeach.Name = "RadioTeach";
            this.RadioTeach.Size = new System.Drawing.Size(71, 19);
            this.RadioTeach.TabIndex = 1;
            this.RadioTeach.TabStop = true;
            this.RadioTeach.Text = "Teacher";
            this.RadioTeach.UseVisualStyleBackColor = true;
            // 
            // ConfirmPasswordBox
            // 
            this.ConfirmPasswordBox.Location = new System.Drawing.Point(299, 191);
            this.ConfirmPasswordBox.Name = "ConfirmPasswordBox";
            this.ConfirmPasswordBox.ReadOnly = true;
            this.ConfirmPasswordBox.Size = new System.Drawing.Size(143, 22);
            this.ConfirmPasswordBox.TabIndex = 8;
            // 
            // PasswordBox
            // 
            this.PasswordBox.Location = new System.Drawing.Point(299, 163);
            this.PasswordBox.Name = "PasswordBox";
            this.PasswordBox.ReadOnly = true;
            this.PasswordBox.Size = new System.Drawing.Size(143, 22);
            this.PasswordBox.TabIndex = 7;
            // 
            // RadioStudent
            // 
            this.RadioStudent.AutoSize = true;
            this.RadioStudent.Location = new System.Drawing.Point(372, 21);
            this.RadioStudent.Name = "RadioStudent";
            this.RadioStudent.Size = new System.Drawing.Size(70, 19);
            this.RadioStudent.TabIndex = 2;
            this.RadioStudent.TabStop = true;
            this.RadioStudent.Text = "Student";
            this.RadioStudent.UseVisualStyleBackColor = true;
            // 
            // MobileTextBox
            // 
            this.MobileTextBox.Location = new System.Drawing.Point(299, 106);
            this.MobileTextBox.Name = "MobileTextBox";
            this.MobileTextBox.Size = new System.Drawing.Size(143, 22);
            this.MobileTextBox.TabIndex = 5;
            // 
            // EmailTextBox
            // 
            this.EmailTextBox.Location = new System.Drawing.Point(299, 78);
            this.EmailTextBox.Name = "EmailTextBox";
            this.EmailTextBox.Size = new System.Drawing.Size(143, 22);
            this.EmailTextBox.TabIndex = 4;
            // 
            // UsernameBox
            // 
            this.UsernameBox.Location = new System.Drawing.Point(299, 50);
            this.UsernameBox.Name = "UsernameBox";
            this.UsernameBox.Size = new System.Drawing.Size(143, 22);
            this.UsernameBox.TabIndex = 3;
            // 
            // MobileNumberLabel
            // 
            this.MobileNumberLabel.AutoSize = true;
            this.MobileNumberLabel.Location = new System.Drawing.Point(115, 109);
            this.MobileNumberLabel.Name = "MobileNumberLabel";
            this.MobileNumberLabel.Size = new System.Drawing.Size(137, 15);
            this.MobileNumberLabel.TabIndex = 8;
            this.MobileNumberLabel.Text = "Enter Mobile Number";
            // 
            // MobileLabel
            // 
            this.MobileLabel.AutoSize = true;
            this.MobileLabel.Location = new System.Drawing.Point(115, 81);
            this.MobileLabel.Name = "MobileLabel";
            this.MobileLabel.Size = new System.Drawing.Size(129, 15);
            this.MobileLabel.TabIndex = 8;
            this.MobileLabel.Text = "Enter Email Address";
            // 
            // UserNameLabel
            // 
            this.UserNameLabel.AutoSize = true;
            this.UserNameLabel.Location = new System.Drawing.Point(115, 57);
            this.UserNameLabel.Name = "UserNameLabel";
            this.UserNameLabel.Size = new System.Drawing.Size(104, 15);
            this.UserNameLabel.TabIndex = 8;
            this.UserNameLabel.Text = "Enter Username";
            // 
            // ConfirmPassLabel
            // 
            this.ConfirmPassLabel.AutoSize = true;
            this.ConfirmPassLabel.Location = new System.Drawing.Point(115, 198);
            this.ConfirmPassLabel.Name = "ConfirmPassLabel";
            this.ConfirmPassLabel.Size = new System.Drawing.Size(144, 15);
            this.ConfirmPassLabel.TabIndex = 9;
            this.ConfirmPassLabel.Text = "Confirm New Password";
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.Location = new System.Drawing.Point(115, 170);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(129, 15);
            this.PasswordLabel.TabIndex = 9;
            this.PasswordLabel.Text = "Enter New Password";
            // 
            // HomeButton
            // 
            this.HomeButton.Location = new System.Drawing.Point(12, 219);
            this.HomeButton.Name = "HomeButton";
            this.HomeButton.Size = new System.Drawing.Size(75, 23);
            this.HomeButton.TabIndex = 10;
            this.HomeButton.Text = "Register";
            this.HomeButton.UseVisualStyleBackColor = true;
            this.HomeButton.Click += new System.EventHandler(this.RegisterClick);
            // 
            // ForgotPasswordModule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.ClientSize = new System.Drawing.Size(896, 435);
            this.Controls.Add(this.Panel);
            this.Name = "ForgotPasswordModule";
            this.Load += new System.EventHandler(this.ForgotPasswordModule_Load);
            this.Controls.SetChildIndex(this.Panel, 0);
            this.Panel.ResumeLayout(false);
            this.PasswordRestGroupBox.ResumeLayout(false);
            this.PasswordRestGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel Panel;
        private System.Windows.Forms.GroupBox PasswordRestGroupBox;
        private System.Windows.Forms.Button CheckButton;
        private System.Windows.Forms.RadioButton RadioAdmin;
        private System.Windows.Forms.RadioButton RadioTeach;
        private System.Windows.Forms.TextBox PasswordBox;
        private System.Windows.Forms.RadioButton RadioStudent;
        private System.Windows.Forms.TextBox MobileTextBox;
        private System.Windows.Forms.TextBox EmailTextBox;
        private System.Windows.Forms.TextBox UsernameBox;
        private System.Windows.Forms.Label MobileNumberLabel;
        private System.Windows.Forms.Label MobileLabel;
        private System.Windows.Forms.Label UserNameLabel;
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.Button HomeButton;
        private System.Windows.Forms.Button ResetButton;
        private System.Windows.Forms.TextBox ConfirmPasswordBox;
        private System.Windows.Forms.Label ConfirmPassLabel;
    }
}
