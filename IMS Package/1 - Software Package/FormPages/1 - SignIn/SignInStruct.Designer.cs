﻿namespace _1___Software_Package.FormPages
{
    partial class SignIn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignIn));
            this.CentralContainerLogin = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.IDContainer = new System.Windows.Forms.SplitContainer();
            this.UserNameLabel = new System.Windows.Forms.Label();
            this.PasswordConatiner = new System.Windows.Forms.SplitContainer();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.LoginButton = new System.Windows.Forms.Button();
            this.ButtonPanel = new System.Windows.Forms.TableLayoutPanel();
            this.AdminButton = new System.Windows.Forms.Button();
            this.StudentButton = new System.Windows.Forms.Button();
            this.TeacherButton = new System.Windows.Forms.Button();
            this.OfficeStaffButton = new System.Windows.Forms.Button();
            this.LibStaffButton = new System.Windows.Forms.Button();
            this.SignUpButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.CentralContainerLogin.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IDContainer)).BeginInit();
            this.IDContainer.Panel1.SuspendLayout();
            this.IDContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PasswordConatiner)).BeginInit();
            this.PasswordConatiner.Panel1.SuspendLayout();
            this.PasswordConatiner.SuspendLayout();
            this.ButtonPanel.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // CentralContainerLogin
            // 
            this.CentralContainerLogin.Controls.Add(this.tableLayoutPanel2);
            this.CentralContainerLogin.Controls.Add(this.ButtonPanel);
            this.CentralContainerLogin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CentralContainerLogin.Location = new System.Drawing.Point(0, 26);
            this.CentralContainerLogin.Name = "CentralContainerLogin";
            this.CentralContainerLogin.Size = new System.Drawing.Size(991, 571);
            this.CentralContainerLogin.TabIndex = 8;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.IDContainer, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.PasswordConatiner, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.LoginButton, 0, 3);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(200, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 4;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(791, 571);
            this.tableLayoutPanel2.TabIndex = 5;
            // 
            // IDContainer
            // 
            this.IDContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.IDContainer.Location = new System.Drawing.Point(3, 145);
            this.IDContainer.Name = "IDContainer";
            // 
            // IDContainer.Panel1
            // 
            this.IDContainer.Panel1.Controls.Add(this.UserNameLabel);
            this.IDContainer.Size = new System.Drawing.Size(785, 136);
            this.IDContainer.SplitterDistance = 261;
            this.IDContainer.TabIndex = 0;
            // 
            // UserNameLabel
            // 
            this.UserNameLabel.AutoSize = true;
            this.UserNameLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UserNameLabel.Location = new System.Drawing.Point(0, 0);
            this.UserNameLabel.Name = "UserNameLabel";
            this.UserNameLabel.Size = new System.Drawing.Size(55, 13);
            this.UserNameLabel.TabIndex = 0;
            this.UserNameLabel.Text = "Username";
            // 
            // PasswordConatiner
            // 
            this.PasswordConatiner.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PasswordConatiner.Location = new System.Drawing.Point(3, 287);
            this.PasswordConatiner.Name = "PasswordConatiner";
            // 
            // PasswordConatiner.Panel1
            // 
            this.PasswordConatiner.Panel1.Controls.Add(this.PasswordLabel);
            this.PasswordConatiner.Size = new System.Drawing.Size(785, 136);
            this.PasswordConatiner.SplitterDistance = 261;
            this.PasswordConatiner.TabIndex = 1;
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PasswordLabel.Location = new System.Drawing.Point(0, 0);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(53, 13);
            this.PasswordLabel.TabIndex = 0;
            this.PasswordLabel.Text = "Password";
            this.PasswordLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LoginButton
            // 
            this.LoginButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LoginButton.Location = new System.Drawing.Point(3, 429);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(785, 139);
            this.LoginButton.TabIndex = 2;
            this.LoginButton.Text = "Login";
            this.LoginButton.UseVisualStyleBackColor = true;
            // 
            // ButtonPanel
            // 
            this.ButtonPanel.ColumnCount = 1;
            this.ButtonPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.ButtonPanel.Controls.Add(this.AdminButton, 0, 0);
            this.ButtonPanel.Controls.Add(this.StudentButton, 0, 1);
            this.ButtonPanel.Controls.Add(this.TeacherButton, 0, 2);
            this.ButtonPanel.Controls.Add(this.OfficeStaffButton, 0, 3);
            this.ButtonPanel.Controls.Add(this.LibStaffButton, 0, 4);
            this.ButtonPanel.Controls.Add(this.SignUpButton, 0, 5);
            this.ButtonPanel.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.ButtonPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.ButtonPanel.Location = new System.Drawing.Point(0, 0);
            this.ButtonPanel.Name = "ButtonPanel";
            this.ButtonPanel.RowCount = 6;
            this.ButtonPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.ButtonPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.ButtonPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.ButtonPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.ButtonPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.ButtonPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.ButtonPanel.Size = new System.Drawing.Size(200, 571);
            this.ButtonPanel.TabIndex = 4;
            // 
            // AdminButton
            // 
            this.AdminButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AdminButton.Location = new System.Drawing.Point(3, 3);
            this.AdminButton.Name = "AdminButton";
            this.AdminButton.Size = new System.Drawing.Size(194, 89);
            this.AdminButton.TabIndex = 3;
            this.AdminButton.Text = "Admin Login";
            this.AdminButton.UseVisualStyleBackColor = true;
            // 
            // StudentButton
            // 
            this.StudentButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.StudentButton.Location = new System.Drawing.Point(3, 98);
            this.StudentButton.Name = "StudentButton";
            this.StudentButton.Size = new System.Drawing.Size(194, 89);
            this.StudentButton.TabIndex = 4;
            this.StudentButton.Text = "Student Login";
            this.StudentButton.UseVisualStyleBackColor = true;
            // 
            // TeacherButton
            // 
            this.TeacherButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TeacherButton.Location = new System.Drawing.Point(3, 193);
            this.TeacherButton.Name = "TeacherButton";
            this.TeacherButton.Size = new System.Drawing.Size(194, 89);
            this.TeacherButton.TabIndex = 5;
            this.TeacherButton.Text = "Teachers Login";
            this.TeacherButton.UseVisualStyleBackColor = true;
            // 
            // OfficeStaffButton
            // 
            this.OfficeStaffButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OfficeStaffButton.Location = new System.Drawing.Point(3, 288);
            this.OfficeStaffButton.Name = "OfficeStaffButton";
            this.OfficeStaffButton.Size = new System.Drawing.Size(194, 89);
            this.OfficeStaffButton.TabIndex = 6;
            this.OfficeStaffButton.Text = "Office Staff Login";
            this.OfficeStaffButton.UseVisualStyleBackColor = true;
            // 
            // LibStaffButton
            // 
            this.LibStaffButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LibStaffButton.Location = new System.Drawing.Point(3, 383);
            this.LibStaffButton.Name = "LibStaffButton";
            this.LibStaffButton.Size = new System.Drawing.Size(194, 89);
            this.LibStaffButton.TabIndex = 7;
            this.LibStaffButton.Text = "Library Staff Login";
            this.LibStaffButton.UseVisualStyleBackColor = true;
            // 
            // SignUpButton
            // 
            this.SignUpButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SignUpButton.Location = new System.Drawing.Point(3, 478);
            this.SignUpButton.Name = "SignUpButton";
            this.SignUpButton.Size = new System.Drawing.Size(194, 90);
            this.SignUpButton.TabIndex = 8;
            this.SignUpButton.Text = "Sign Up Page";
            this.SignUpButton.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.linkLabel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.linkLabel2, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 597);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(991, 31);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.linkLabel1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.linkLabel1.Location = new System.Drawing.Point(3, 0);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(489, 31);
            this.linkLabel1.TabIndex = 0;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "About Us";
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.linkLabel2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.linkLabel2.Location = new System.Drawing.Point(498, 0);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(490, 31);
            this.linkLabel2.TabIndex = 0;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "Help And Feedback";
            // 
            // panel1
            // 
            this.panel1.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(991, 26);
            this.panel1.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Lucida Calligraphy", 18.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label1.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(308, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Student Management System";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SignIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(991, 628);
            this.Controls.Add(this.CentralContainerLogin);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SignIn";
            this.Text = "Sign In Window";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.CentralContainerLogin.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.IDContainer.Panel1.ResumeLayout(false);
            this.IDContainer.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IDContainer)).EndInit();
            this.IDContainer.ResumeLayout(false);
            this.PasswordConatiner.Panel1.ResumeLayout(false);
            this.PasswordConatiner.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PasswordConatiner)).EndInit();
            this.PasswordConatiner.ResumeLayout(false);
            this.ButtonPanel.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel CentralContainerLogin;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel ButtonPanel;
        private System.Windows.Forms.Button AdminButton;
        private System.Windows.Forms.Button StudentButton;
        private System.Windows.Forms.Button TeacherButton;
        private System.Windows.Forms.Button OfficeStaffButton;
        private System.Windows.Forms.Button LibStaffButton;
        private System.Windows.Forms.Button SignUpButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.SplitContainer IDContainer;
        private System.Windows.Forms.SplitContainer PasswordConatiner;
        private System.Windows.Forms.Button LoginButton;
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.Label UserNameLabel;
    }
}