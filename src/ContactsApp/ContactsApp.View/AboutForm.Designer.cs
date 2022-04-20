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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutForm));
            this.AppNameLable = new System.Windows.Forms.Label();
            this.VersionLable = new System.Windows.Forms.Label();
            this.AuthorLable = new System.Windows.Forms.Label();
            this.FeedbackMailLable = new System.Windows.Forms.Label();
            this.GithubLable = new System.Windows.Forms.Label();
            this.MailLinkLable = new System.Windows.Forms.LinkLabel();
            this.GitLinkLable = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // AppNameLable
            // 
            this.AppNameLable.AutoSize = true;
            this.AppNameLable.Font = new System.Drawing.Font("Segoe UI Semibold", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AppNameLable.Location = new System.Drawing.Point(12, 9);
            this.AppNameLable.Name = "AppNameLable";
            this.AppNameLable.Size = new System.Drawing.Size(194, 41);
            this.AppNameLable.TabIndex = 0;
            this.AppNameLable.Text = "ContactsApp";
            // 
            // VersionLable
            // 
            this.VersionLable.AutoSize = true;
            this.VersionLable.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.VersionLable.Location = new System.Drawing.Point(14, 50);
            this.VersionLable.Name = "VersionLable";
            this.VersionLable.Size = new System.Drawing.Size(77, 30);
            this.VersionLable.TabIndex = 1;
            this.VersionLable.Text = "v. 1.0.0";
            // 
            // AuthorLable
            // 
            this.AuthorLable.AutoSize = true;
            this.AuthorLable.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AuthorLable.Location = new System.Drawing.Point(15, 120);
            this.AuthorLable.Name = "AuthorLable";
            this.AuthorLable.Size = new System.Drawing.Size(182, 21);
            this.AuthorLable.TabIndex = 2;
            this.AuthorLable.Text = "Author: Deryabin Nikita";
            // 
            // FeedbackMailLable
            // 
            this.FeedbackMailLable.AutoSize = true;
            this.FeedbackMailLable.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FeedbackMailLable.Location = new System.Drawing.Point(15, 188);
            this.FeedbackMailLable.Name = "FeedbackMailLable";
            this.FeedbackMailLable.Size = new System.Drawing.Size(158, 21);
            this.FeedbackMailLable.TabIndex = 3;
            this.FeedbackMailLable.Text = "e-mail for feedback:";
            // 
            // GithubLable
            // 
            this.GithubLable.AutoSize = true;
            this.GithubLable.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GithubLable.Location = new System.Drawing.Point(15, 222);
            this.GithubLable.Name = "GithubLable";
            this.GithubLable.Size = new System.Drawing.Size(66, 21);
            this.GithubLable.TabIndex = 4;
            this.GithubLable.Text = "GitHub:";
            // 
            // MailLinkLable
            // 
            this.MailLinkLable.AutoSize = true;
            this.MailLinkLable.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MailLinkLable.Location = new System.Drawing.Point(179, 188);
            this.MailLinkLable.Name = "MailLinkLable";
            this.MailLinkLable.Size = new System.Drawing.Size(187, 21);
            this.MailLinkLable.TabIndex = 5;
            this.MailLinkLable.TabStop = true;
            this.MailLinkLable.Text = "deryabin.2001@inbox.ru";
            // 
            // GitLinkLable
            // 
            this.GitLinkLable.AutoSize = true;
            this.GitLinkLable.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GitLinkLable.Location = new System.Drawing.Point(87, 222);
            this.GitLinkLable.Name = "GitLinkLable";
            this.GitLinkLable.Size = new System.Drawing.Size(96, 21);
            this.GitLinkLable.TabIndex = 6;
            this.GitLinkLable.TabStop = true;
            this.GitLinkLable.Text = "DeryabinKB";
            // 
            // AboutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 307);
            this.Controls.Add(this.GitLinkLable);
            this.Controls.Add(this.MailLinkLable);
            this.Controls.Add(this.GithubLable);
            this.Controls.Add(this.FeedbackMailLable);
            this.Controls.Add(this.AuthorLable);
            this.Controls.Add(this.VersionLable);
            this.Controls.Add(this.AppNameLable);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(452, 346);
            this.MinimumSize = new System.Drawing.Size(452, 346);
            this.Name = "AboutForm";
            this.Text = "About";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label AppNameLable;
        private System.Windows.Forms.Label VersionLable;
        private System.Windows.Forms.Label AuthorLable;
        private System.Windows.Forms.Label FeedbackMailLable;
        private System.Windows.Forms.Label GithubLable;
        private System.Windows.Forms.LinkLabel MailLinkLable;
        private System.Windows.Forms.LinkLabel GitLinkLable;
    }
}