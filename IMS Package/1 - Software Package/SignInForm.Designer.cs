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
            this.PwdContainer = new System.Windows.Forms.SplitContainer();
            this.button1 = new System.Windows.Forms.Button();
            this.LoginTblPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IDContainer)).BeginInit();
            this.IDContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PwdContainer)).BeginInit();
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
            this.LoginTblPanel1.Controls.Add(this.button1, 0, 3);
            this.LoginTblPanel1.Location = new System.Drawing.Point(64, 88);
            this.LoginTblPanel1.Name = "LoginTblPanel1";
            this.LoginTblPanel1.RowCount = 4;
            this.LoginTblPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.LoginTblPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.LoginTblPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.LoginTblPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
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
            this.StudentLoginLabel.Text = "Student Login";
            this.StudentLoginLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // IDContainer
            // 
            this.IDContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.IDContainer.Location = new System.Drawing.Point(3, 53);
            this.IDContainer.Name = "IDContainer";
            this.IDContainer.Size = new System.Drawing.Size(294, 44);
            this.IDContainer.SplitterDistance = 98;
            this.IDContainer.TabIndex = 1;
            // 
            // PwdContainer
            // 
            this.PwdContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PwdContainer.Location = new System.Drawing.Point(3, 103);
            this.PwdContainer.Name = "PwdContainer";
            this.PwdContainer.Size = new System.Drawing.Size(294, 44);
            this.PwdContainer.SplitterDistance = 98;
            this.PwdContainer.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button1.Location = new System.Drawing.Point(3, 153);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(294, 44);
            this.button1.TabIndex = 3;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // SignInForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(1151, 549);
            this.Controls.Add(this.LoginTblPanel1);
            this.Name = "SignInForm";
            this.Controls.SetChildIndex(this.LoginTblPanel1, 0);
            this.LoginTblPanel1.ResumeLayout(false);
            this.LoginTblPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IDContainer)).EndInit();
            this.IDContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PwdContainer)).EndInit();
            this.PwdContainer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel LoginTblPanel1;
        private System.Windows.Forms.Label StudentLoginLabel;
        private System.Windows.Forms.SplitContainer IDContainer;
        private System.Windows.Forms.SplitContainer PwdContainer;
        private System.Windows.Forms.Button button1;
    }
}
