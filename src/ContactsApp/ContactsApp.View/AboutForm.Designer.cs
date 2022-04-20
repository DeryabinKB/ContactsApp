namespace ContactsApp.View
{
    partial class AboutForm
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
            this.AppName = new System.Windows.Forms.Label();
            this.Version = new System.Windows.Forms.Label();
            this.Author = new System.Windows.Forms.Label();
            this.FeedbackMail = new System.Windows.Forms.Label();
            this.Github = new System.Windows.Forms.Label();
            this.MailLink = new System.Windows.Forms.LinkLabel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // AppName
            // 
            this.AppName.AutoSize = true;
            this.AppName.Font = new System.Drawing.Font("Segoe UI Semibold", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AppName.Location = new System.Drawing.Point(12, 9);
            this.AppName.Name = "AppName";
            this.AppName.Size = new System.Drawing.Size(194, 41);
            this.AppName.TabIndex = 0;
            this.AppName.Text = "ContactsApp";
            // 
            // Version
            // 
            this.Version.AutoSize = true;
            this.Version.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Version.Location = new System.Drawing.Point(14, 50);
            this.Version.Name = "Version";
            this.Version.Size = new System.Drawing.Size(77, 30);
            this.Version.TabIndex = 1;
            this.Version.Text = "v. 1.0.0";
            // 
            // Author
            // 
            this.Author.AutoSize = true;
            this.Author.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Author.Location = new System.Drawing.Point(15, 120);
            this.Author.Name = "Author";
            this.Author.Size = new System.Drawing.Size(182, 21);
            this.Author.TabIndex = 2;
            this.Author.Text = "Author: Deryabin Nikita";
            // 
            // FeedbackMail
            // 
            this.FeedbackMail.AutoSize = true;
            this.FeedbackMail.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FeedbackMail.Location = new System.Drawing.Point(15, 188);
            this.FeedbackMail.Name = "FeedbackMail";
            this.FeedbackMail.Size = new System.Drawing.Size(158, 21);
            this.FeedbackMail.TabIndex = 3;
            this.FeedbackMail.Text = "e-mail for feedback:";
            // 
            // Github
            // 
            this.Github.AutoSize = true;
            this.Github.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Github.Location = new System.Drawing.Point(15, 222);
            this.Github.Name = "Github";
            this.Github.Size = new System.Drawing.Size(66, 21);
            this.Github.TabIndex = 4;
            this.Github.Text = "GitHub:";
            // 
            // MailLink
            // 
            this.MailLink.AutoSize = true;
            this.MailLink.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MailLink.Location = new System.Drawing.Point(179, 188);
            this.MailLink.Name = "MailLink";
            this.MailLink.Size = new System.Drawing.Size(187, 21);
            this.MailLink.TabIndex = 5;
            this.MailLink.TabStop = true;
            this.MailLink.Text = "deryabin.2001@inbox.ru";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.linkLabel1.Location = new System.Drawing.Point(87, 222);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(96, 21);
            this.linkLabel1.TabIndex = 6;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "DeryabinKB";
            // 
            // AboutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 307);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.MailLink);
            this.Controls.Add(this.Github);
            this.Controls.Add(this.FeedbackMail);
            this.Controls.Add(this.Author);
            this.Controls.Add(this.Version);
            this.Controls.Add(this.AppName);
            this.MaximumSize = new System.Drawing.Size(452, 346);
            this.MinimumSize = new System.Drawing.Size(452, 346);
            this.Name = "AboutForm";
            this.Text = "About";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label AppName;
        private System.Windows.Forms.Label Version;
        private System.Windows.Forms.Label Author;
        private System.Windows.Forms.Label FeedbackMail;
        private System.Windows.Forms.Label Github;
        private System.Windows.Forms.LinkLabel MailLink;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}