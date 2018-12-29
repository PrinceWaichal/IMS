namespace _1___Software_Package
{
    partial class SignInForm
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
            this.LoginTblPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.StudentLoginLabel = new System.Windows.Forms.Label();
            this.IDContainer = new System.Windows.Forms.SplitContainer();
            this.StudUsernameLabel = new System.Windows.Forms.Label();
            this.LoginID = new System.Windows.Forms.TextBox();
            this.PwdContainer = new System.Windows.Forms.SplitContainer();
            this.StudPassLabel = new System.Windows.Forms.Label();
            this.LoginPass = new System.Windows.Forms.TextBox();
            this.StudLoginBtn = new System.Windows.Forms.Button();
            this.LoginTblPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IDContainer)).BeginInit();
            this.IDContainer.Panel1.SuspendLayout();
            this.IDContainer.Panel2.SuspendLayout();
            this.IDContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PwdContainer)).BeginInit();
            this.PwdContainer.Panel1.SuspendLayout();
            this.PwdContainer.Panel2.SuspendLayout();
            this.PwdContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // LoginTblPanel1
            // 
            this.LoginTblPanel1.ColumnCount = 1;
            this.LoginTblPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.LoginTblPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.LoginTblPanel1.Controls.Add(this.StudentLoginLabel, 0, 0);
            this.LoginTblPanel1.Controls.Add(this.IDContainer, 0, 1);
            this.LoginTblPanel1.Controls.Add(this.PwdContainer, 0, 2);
            this.LoginTblPanel1.Controls.Add(this.StudLoginBtn, 0, 3);
            this.LoginTblPanel1.Location = new System.Drawing.Point(250, 250);
            this.LoginTblPanel1.Name = "LoginTblPanel1";
            this.LoginTblPanel1.RowCount = 4;
            this.LoginTblPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.LoginTblPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.LoginTblPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.LoginTblPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.LoginTblPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.LoginTblPanel1.Size = new System.Drawing.Size(300, 200);
            this.LoginTblPanel1.TabIndex = 3;
            // 
            // StudentLoginLabel
            // 
            this.StudentLoginLabel.AutoSize = true;
            this.StudentLoginLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.StudentLoginLabel.CausesValidation = false;
            this.StudentLoginLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.StudentLoginLabel.Font = new System.Drawing.Font("Lucida Calligraphy", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StudentLoginLabel.Location = new System.Drawing.Point(3, 0);
            this.StudentLoginLabel.Name = "StudentLoginLabel";
            this.StudentLoginLabel.Size = new System.Drawing.Size(294, 50);
            this.StudentLoginLabel.TabIndex = 0;
            this.StudentLoginLabel.Text = "Login";
            this.StudentLoginLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // IDContainer
            // 
            this.IDContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.IDContainer.Location = new System.Drawing.Point(3, 53);
            this.IDContainer.Name = "IDContainer";
            // 
            // IDContainer.Panel1
            // 
            this.IDContainer.Panel1.Controls.Add(this.StudUsernameLabel);
            // 
            // IDContainer.Panel2
            // 
            this.IDContainer.Panel2.Controls.Add(this.LoginID);
            this.IDContainer.Size = new System.Drawing.Size(294, 44);
            this.IDContainer.SplitterDistance = 98;
            this.IDContainer.TabIndex = 1;
            // 
            // StudUsernameLabel
            // 
            this.StudUsernameLabel.AutoSize = true;
            this.StudUsernameLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.StudUsernameLabel.Location = new System.Drawing.Point(0, 0);
            this.StudUsernameLabel.Name = "StudUsernameLabel";
            this.StudUsernameLabel.Size = new System.Drawing.Size(55, 13);
            this.StudUsernameLabel.TabIndex = 0;
            this.StudUsernameLabel.Text = "Username";
            this.StudUsernameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LoginID
            // 
            this.LoginID.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LoginID.Location = new System.Drawing.Point(0, 0);
            this.LoginID.Name = "LoginID";
            this.LoginID.Size = new System.Drawing.Size(192, 20);
            this.LoginID.TabIndex = 0;
            // 
            // PwdContainer
            // 
            this.PwdContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PwdContainer.Location = new System.Drawing.Point(3, 103);
            this.PwdContainer.Name = "PwdContainer";
            // 
            // PwdContainer.Panel1
            // 
            this.PwdContainer.Panel1.Controls.Add(this.StudPassLabel);
            // 
            // PwdContainer.Panel2
            // 
            this.PwdContainer.Panel2.Controls.Add(this.LoginPass);
            this.PwdContainer.Size = new System.Drawing.Size(294, 44);
            this.PwdContainer.SplitterDistance = 98;
            this.PwdContainer.TabIndex = 2;
            // 
            // StudPassLabel
            // 
            this.StudPassLabel.AutoSize = true;
            this.StudPassLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.StudPassLabel.Location = new System.Drawing.Point(0, 0);
            this.StudPassLabel.Name = "StudPassLabel";
            this.StudPassLabel.Size = new System.Drawing.Size(53, 13);
            this.StudPassLabel.TabIndex = 0;
            this.StudPassLabel.Text = "Password";
            this.StudPassLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LoginPass
            // 
            this.LoginPass.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LoginPass.Location = new System.Drawing.Point(0, 0);
            this.LoginPass.Name = "LoginPass";
            this.LoginPass.Size = new System.Drawing.Size(192, 20);
            this.LoginPass.TabIndex = 0;
            // 
            // StudLoginBtn
            // 
            this.StudLoginBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.StudLoginBtn.Location = new System.Drawing.Point(3, 153);
            this.StudLoginBtn.Name = "StudLoginBtn";
            this.StudLoginBtn.Size = new System.Drawing.Size(294, 44);
            this.StudLoginBtn.TabIndex = 3;
            this.StudLoginBtn.Text = "Login";
            this.StudLoginBtn.UseVisualStyleBackColor = true;
            // 
            // SignInForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(1164, 661);
            this.Controls.Add(this.LoginTblPanel1);
            this.Name = "SignInForm";
            this.Controls.SetChildIndex(this.LoginTblPanel1, 0);
            this.LoginTblPanel1.ResumeLayout(false);
            this.LoginTblPanel1.PerformLayout();
            this.IDContainer.Panel1.ResumeLayout(false);
            this.IDContainer.Panel1.PerformLayout();
            this.IDContainer.Panel2.ResumeLayout(false);
            this.IDContainer.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IDContainer)).EndInit();
            this.IDContainer.ResumeLayout(false);
            this.PwdContainer.Panel1.ResumeLayout(false);
            this.PwdContainer.Panel1.PerformLayout();
            this.PwdContainer.Panel2.ResumeLayout(false);
            this.PwdContainer.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PwdContainer)).EndInit();
            this.PwdContainer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel LoginTblPanel1;
        private System.Windows.Forms.Label StudentLoginLabel;
        private System.Windows.Forms.SplitContainer IDContainer;
        private System.Windows.Forms.SplitContainer PwdContainer;
        private System.Windows.Forms.Button StudLoginBtn;
        private System.Windows.Forms.Label StudUsernameLabel;
        private System.Windows.Forms.TextBox LoginID;
        private System.Windows.Forms.Label StudPassLabel;
        private System.Windows.Forms.TextBox LoginPass;
    }
}
