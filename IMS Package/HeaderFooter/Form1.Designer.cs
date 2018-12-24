namespace HeaderFooter
{
    partial class BaseForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BaseForm));
            this.NameTextBox = new System.Windows.Forms.RichTextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.FeedbackTextBox = new System.Windows.Forms.RichTextBox();
            this.AbtUsTextBox = new System.Windows.Forms.RichTextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // NameTextBox
            // 
            this.NameTextBox.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.NameTextBox.CausesValidation = false;
            this.NameTextBox.Cursor = System.Windows.Forms.Cursors.Arrow;
            resources.ApplyResources(this.NameTextBox, "NameTextBox");
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.ReadOnly = true;
            this.NameTextBox.ShortcutsEnabled = false;
            this.NameTextBox.TabStop = false;
            // 
            // tableLayoutPanel1
            // 
            resources.ApplyResources(this.tableLayoutPanel1, "tableLayoutPanel1");
            this.tableLayoutPanel1.Controls.Add(this.FeedbackTextBox, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.AbtUsTextBox, 0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            // 
            // FeedbackTextBox
            // 
            this.FeedbackTextBox.Cursor = System.Windows.Forms.Cursors.Arrow;
            resources.ApplyResources(this.FeedbackTextBox, "FeedbackTextBox");
            this.FeedbackTextBox.Name = "FeedbackTextBox";
            this.FeedbackTextBox.ReadOnly = true;
            this.FeedbackTextBox.TabStop = false;
            // 
            // AbtUsTextBox
            // 
            this.AbtUsTextBox.Cursor = System.Windows.Forms.Cursors.No;
            this.AbtUsTextBox.DetectUrls = false;
            resources.ApplyResources(this.AbtUsTextBox, "AbtUsTextBox");
            this.AbtUsTextBox.Name = "AbtUsTextBox";
            this.AbtUsTextBox.ReadOnly = true;
            this.AbtUsTextBox.TabStop = false;
            // 
            // BaseForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.NameTextBox);
            this.Name = "BaseForm";
            this.TopMost = true;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox NameTextBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.RichTextBox FeedbackTextBox;
        private System.Windows.Forms.RichTextBox AbtUsTextBox;
    }
}

