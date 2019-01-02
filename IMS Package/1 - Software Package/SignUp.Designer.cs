namespace _1___Software_Package
{
    partial class SignUp
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
            this.PrimeDetails = new System.Windows.Forms.Button();
            this.EduDetailsBtn = new System.Windows.Forms.Button();
            this.OthDetailsBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // PrimeDetails
            // 
            this.PrimeDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PrimeDetails.Location = new System.Drawing.Point(3, 3);
            this.PrimeDetails.Name = "PrimeDetails";
            this.PrimeDetails.Size = new System.Drawing.Size(194, 83);
            this.PrimeDetails.TabIndex = 0;
            this.PrimeDetails.Text = "Primary Details";
            this.PrimeDetails.UseVisualStyleBackColor = true;
            // 
            // EduDetailsBtn
            // 
            this.EduDetailsBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EduDetailsBtn.Location = new System.Drawing.Point(3, 92);
            this.EduDetailsBtn.Name = "EduDetailsBtn";
            this.EduDetailsBtn.Size = new System.Drawing.Size(194, 83);
            this.EduDetailsBtn.TabIndex = 1;
            this.EduDetailsBtn.Text = "Educational Details";
            this.EduDetailsBtn.UseVisualStyleBackColor = true;
            // 
            // OthDetailsBtn
            // 
            this.OthDetailsBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OthDetailsBtn.Location = new System.Drawing.Point(3, 181);
            this.OthDetailsBtn.Name = "OthDetailsBtn";
            this.OthDetailsBtn.Size = new System.Drawing.Size(194, 83);
            this.OthDetailsBtn.TabIndex = 2;
            this.OthDetailsBtn.Text = "Other Details";
            this.OthDetailsBtn.UseVisualStyleBackColor = true;
            // 
            // SignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(999, 595);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "SignUp";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button PrimeDetails;
        private System.Windows.Forms.Button EduDetailsBtn;
        private System.Windows.Forms.Button OthDetailsBtn;
    }
}
