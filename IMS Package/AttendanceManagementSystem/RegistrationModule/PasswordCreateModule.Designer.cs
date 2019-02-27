namespace AttendanceManagementSystem.RegistrationModule
{
    partial class PasswordCreateModule
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.SubmitButton = new System.Windows.Forms.Button();
            this.PasswordGroup = new System.Windows.Forms.GroupBox();
            this.PasswordTable = new System.Windows.Forms.TableLayoutPanel();
            this.labConfirmPassw = new System.Windows.Forms.Label();
            this.labCreatePassw = new System.Windows.Forms.Label();
            this.UsernameLabel = new System.Windows.Forms.Label();
            this.tbUserName = new System.Windows.Forms.TextBox();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.tbConfirmPassword = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.PasswordGroup.SuspendLayout();
            this.PasswordTable.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.SubmitButton);
            this.panel1.Controls.Add(this.PasswordGroup);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1184, 681);
            this.panel1.TabIndex = 4;
            // 
            // SubmitButton
            // 
            this.SubmitButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.SubmitButton.Location = new System.Drawing.Point(0, 658);
            this.SubmitButton.Name = "SubmitButton";
            this.SubmitButton.Size = new System.Drawing.Size(1184, 23);
            this.SubmitButton.TabIndex = 22;
            this.SubmitButton.Text = "Submit";
            this.SubmitButton.UseVisualStyleBackColor = true;
            this.SubmitButton.Click += new System.EventHandler(this.SubmitClick);
            // 
            // PasswordGroup
            // 
            this.PasswordGroup.Controls.Add(this.PasswordTable);
            this.PasswordGroup.Location = new System.Drawing.Point(444, 288);
            this.PasswordGroup.Name = "PasswordGroup";
            this.PasswordGroup.Size = new System.Drawing.Size(296, 100);
            this.PasswordGroup.TabIndex = 21;
            this.PasswordGroup.TabStop = false;
            this.PasswordGroup.Text = "Create Password";
            // 
            // PasswordTable
            // 
            this.PasswordTable.ColumnCount = 2;
            this.PasswordTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.PasswordTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.PasswordTable.Controls.Add(this.labConfirmPassw, 0, 2);
            this.PasswordTable.Controls.Add(this.labCreatePassw, 0, 1);
            this.PasswordTable.Controls.Add(this.UsernameLabel, 0, 0);
            this.PasswordTable.Controls.Add(this.tbUserName, 1, 0);
            this.PasswordTable.Controls.Add(this.tbPassword, 1, 1);
            this.PasswordTable.Controls.Add(this.tbConfirmPassword, 1, 2);
            this.PasswordTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PasswordTable.Location = new System.Drawing.Point(3, 18);
            this.PasswordTable.Margin = new System.Windows.Forms.Padding(2);
            this.PasswordTable.Name = "PasswordTable";
            this.PasswordTable.RowCount = 3;
            this.PasswordTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.PasswordTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.PasswordTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.PasswordTable.Size = new System.Drawing.Size(290, 79);
            this.PasswordTable.TabIndex = 17;
            // 
            // labConfirmPassw
            // 
            this.labConfirmPassw.AutoSize = true;
            this.labConfirmPassw.Location = new System.Drawing.Point(2, 52);
            this.labConfirmPassw.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labConfirmPassw.Name = "labConfirmPassw";
            this.labConfirmPassw.Size = new System.Drawing.Size(113, 15);
            this.labConfirmPassw.TabIndex = 8;
            this.labConfirmPassw.Text = "Confirm Password";
            // 
            // labCreatePassw
            // 
            this.labCreatePassw.AutoSize = true;
            this.labCreatePassw.Location = new System.Drawing.Point(2, 26);
            this.labCreatePassw.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labCreatePassw.Name = "labCreatePassw";
            this.labCreatePassw.Size = new System.Drawing.Size(103, 15);
            this.labCreatePassw.TabIndex = 9;
            this.labCreatePassw.Text = "Create Password";
            // 
            // UsernameLabel
            // 
            this.UsernameLabel.AutoSize = true;
            this.UsernameLabel.Location = new System.Drawing.Point(2, 0);
            this.UsernameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.UsernameLabel.Name = "UsernameLabel";
            this.UsernameLabel.Size = new System.Drawing.Size(88, 15);
            this.UsernameLabel.TabIndex = 8;
            this.UsernameLabel.Text = "Your User ID";
            // 
            // tbUserName
            // 
            this.tbUserName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbUserName.Location = new System.Drawing.Point(148, 3);
            this.tbUserName.Name = "tbUserName";
            this.tbUserName.ReadOnly = true;
            this.tbUserName.Size = new System.Drawing.Size(139, 22);
            this.tbUserName.TabIndex = 10;
            // 
            // tbPassword
            // 
            this.tbPassword.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbPassword.Location = new System.Drawing.Point(148, 29);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.PasswordChar = '*';
            this.tbPassword.Size = new System.Drawing.Size(139, 22);
            this.tbPassword.TabIndex = 11;
            // 
            // tbConfirmPassword
            // 
            this.tbConfirmPassword.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbConfirmPassword.Location = new System.Drawing.Point(148, 55);
            this.tbConfirmPassword.Name = "tbConfirmPassword";
            this.tbConfirmPassword.PasswordChar = '*';
            this.tbConfirmPassword.Size = new System.Drawing.Size(139, 22);
            this.tbConfirmPassword.TabIndex = 12;
            // 
            // PasswordCreateModule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.ClientSize = new System.Drawing.Size(1184, 727);
            this.Controls.Add(this.panel1);
            this.Name = "PasswordCreateModule";
            this.Load += new System.EventHandler(this.PassCrtModLoad);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.panel1.ResumeLayout(false);
            this.PasswordGroup.ResumeLayout(false);
            this.PasswordTable.ResumeLayout(false);
            this.PasswordTable.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox PasswordGroup;
        private System.Windows.Forms.TableLayoutPanel PasswordTable;
        private System.Windows.Forms.Label labConfirmPassw;
        private System.Windows.Forms.Label labCreatePassw;
        private System.Windows.Forms.Label UsernameLabel;
        private System.Windows.Forms.TextBox tbUserName;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.TextBox tbConfirmPassword;
        private System.Windows.Forms.Button SubmitButton;
    }
}
