namespace WindowsFormsApplication1
{
    partial class IMS
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
            this.SubmitButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.Date = new System.Windows.Forms.DateTimePicker();
            this.IDLabel = new System.Windows.Forms.Label();
            this.Name = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.Gender = new System.Windows.Forms.Label();
            this.BDate = new System.Windows.Forms.Label();
            this.Number = new System.Windows.Forms.Label();
            this.MobileText = new System.Windows.Forms.TextBox();
            this.NameText = new System.Windows.Forms.TextBox();
            this.IDText = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // SubmitButton
            // 
            this.SubmitButton.Location = new System.Drawing.Point(514, 324);
            this.SubmitButton.Name = "SubmitButton";
            this.SubmitButton.Size = new System.Drawing.Size(75, 23);
            this.SubmitButton.TabIndex = 0;
            this.SubmitButton.Text = "Submit";
            this.SubmitButton.UseVisualStyleBackColor = true;
            this.SubmitButton.Click += new System.EventHandler(this.SubmitButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(434, 324);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(75, 23);
            this.CancelButton.TabIndex = 0;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            // 
            // Date
            // 
            this.Date.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Date.Location = new System.Drawing.Point(140, 168);
            this.Date.Name = "Date";
            this.Date.Size = new System.Drawing.Size(180, 20);
            this.Date.TabIndex = 4;
            // 
            // IDLabel
            // 
            this.IDLabel.AutoSize = true;
            this.IDLabel.Location = new System.Drawing.Point(3, 0);
            this.IDLabel.Name = "IDLabel";
            this.IDLabel.Size = new System.Drawing.Size(86, 13);
            this.IDLabel.TabIndex = 3;
            this.IDLabel.Text = "Enter ID Number";
            // 
            // Name
            // 
            this.Name.AutoSize = true;
            this.Name.Location = new System.Drawing.Point(3, 55);
            this.Name.Name = "Name";
            this.Name.Size = new System.Drawing.Size(88, 13);
            this.Name.TabIndex = 3;
            this.Name.Text = "Enter Your Name";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.listBox1, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.Gender, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.Date, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.IDLabel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.Name, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.BDate, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.Number, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.MobileText, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.NameText, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.IDText, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(15, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 55F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 58F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 83F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(574, 306);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // listBox1
            // 
            this.listBox1.DisplayMember = "Male";
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Other",
            "Prefer Not To Say"});
            this.listBox1.Location = new System.Drawing.Point(140, 226);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(321, 69);
            this.listBox1.TabIndex = 6;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // Gender
            // 
            this.Gender.AutoSize = true;
            this.Gender.Location = new System.Drawing.Point(3, 223);
            this.Gender.Name = "Gender";
            this.Gender.Size = new System.Drawing.Size(100, 13);
            this.Gender.TabIndex = 3;
            this.Gender.Text = "Select Your Gender";
            // 
            // BDate
            // 
            this.BDate.AutoSize = true;
            this.BDate.Location = new System.Drawing.Point(3, 165);
            this.BDate.Name = "BDate";
            this.BDate.Size = new System.Drawing.Size(107, 13);
            this.BDate.TabIndex = 2;
            this.BDate.Text = "Select Your Birthdate";
            this.BDate.Click += new System.EventHandler(this.label1_Click);
            // 
            // Number
            // 
            this.Number.AutoSize = true;
            this.Number.Location = new System.Drawing.Point(3, 110);
            this.Number.Name = "Number";
            this.Number.Size = new System.Drawing.Size(131, 13);
            this.Number.TabIndex = 3;
            this.Number.Text = "Enter Your Mobile Number";
            // 
            // MobileText
            // 
            this.MobileText.Location = new System.Drawing.Point(140, 113);
            this.MobileText.Name = "MobileText";
            this.MobileText.Size = new System.Drawing.Size(100, 20);
            this.MobileText.TabIndex = 3;
            // 
            // NameText
            // 
            this.NameText.Location = new System.Drawing.Point(140, 58);
            this.NameText.Name = "NameText";
            this.NameText.Size = new System.Drawing.Size(100, 20);
            this.NameText.TabIndex = 2;
            // 
            // IDText
            // 
            this.IDText.Location = new System.Drawing.Point(140, 3);
            this.IDText.Name = "IDText";
            this.IDText.ReadOnly = true;
            this.IDText.Size = new System.Drawing.Size(100, 20);
            this.IDText.TabIndex = 1;
            // 
            // IMS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 359);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.SubmitButton);
            this.MinimumSize = new System.Drawing.Size(200, 200);
            this.Name = "IMS";
            this.Text = "Student Management System";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button SubmitButton;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.DateTimePicker Date;
        private System.Windows.Forms.Label IDLabel;
        private System.Windows.Forms.Label Name;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label Gender;
        private System.Windows.Forms.Label BDate;
        private System.Windows.Forms.Label Number;
        private System.Windows.Forms.TextBox MobileText;
        private System.Windows.Forms.TextBox NameText;
        private System.Windows.Forms.TextBox IDText;
    }
}

