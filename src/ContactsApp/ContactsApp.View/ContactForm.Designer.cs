namespace ContactsApp.View
{
    partial class ContactForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ContactForm));
            this.BirthdayDayEditTimePicker = new System.Windows.Forms.DateTimePicker();
            this.PhoneLabel = new System.Windows.Forms.Label();
            this.MailLabel = new System.Windows.Forms.Label();
            this.VkLabel = new System.Windows.Forms.Label();
            this.PhoneEditTextBox = new System.Windows.Forms.TextBox();
            this.MailEditTextBox = new System.Windows.Forms.TextBox();
            this.VkEditTextBox = new System.Windows.Forms.TextBox();
            this.BirthdayDateTimePicker = new System.Windows.Forms.Label();
            this.NameLabel = new System.Windows.Forms.Label();
            this.NameEditTextBox = new System.Windows.Forms.TextBox();
            this.SurnameEditTextBox = new System.Windows.Forms.TextBox();
            this.SurnameLabel = new System.Windows.Forms.Label();
            this.EditFormOKButton = new System.Windows.Forms.Button();
            this.EditFormCancelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BirthdayDayEditTimePicker
            // 
            this.BirthdayDayEditTimePicker.Location = new System.Drawing.Point(84, 69);
            this.BirthdayDayEditTimePicker.Name = "BirthdayDayEditTimePicker";
            this.BirthdayDayEditTimePicker.Size = new System.Drawing.Size(125, 22);
            this.BirthdayDayEditTimePicker.TabIndex = 29;
            this.BirthdayDayEditTimePicker.Value = new System.DateTime(2022, 3, 14, 0, 0, 0, 0);
            this.BirthdayDayEditTimePicker.ValueChanged += new System.EventHandler(this.BirthdayDayEditTimePicker_ValueChanged);
            // 
            // PhoneLabel
            // 
            this.PhoneLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PhoneLabel.AutoSize = true;
            this.PhoneLabel.Location = new System.Drawing.Point(36, 99);
            this.PhoneLabel.Name = "PhoneLabel";
            this.PhoneLabel.Size = new System.Drawing.Size(41, 13);
            this.PhoneLabel.TabIndex = 28;
            this.PhoneLabel.Text = "Phone:";
            // 
            // MailLabel
            // 
            this.MailLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MailLabel.AutoSize = true;
            this.MailLabel.Location = new System.Drawing.Point(35, 127);
            this.MailLabel.Name = "MailLabel";
            this.MailLabel.Size = new System.Drawing.Size(42, 13);
            this.MailLabel.TabIndex = 27;
            this.MailLabel.Text = "E-mail:";
            // 
            // VkLabel
            // 
            this.VkLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.VkLabel.AutoSize = true;
            this.VkLabel.Location = new System.Drawing.Point(30, 155);
            this.VkLabel.Name = "VkLabel";
            this.VkLabel.Size = new System.Drawing.Size(47, 13);
            this.VkLabel.TabIndex = 26;
            this.VkLabel.Text = "vk.com:";
            // 
            // PhoneEditTextBox
            // 
            this.PhoneEditTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PhoneEditTextBox.Location = new System.Drawing.Point(83, 96);
            this.PhoneEditTextBox.Name = "PhoneEditTextBox";
            this.PhoneEditTextBox.Size = new System.Drawing.Size(559, 22);
            this.PhoneEditTextBox.TabIndex = 25;
            this.PhoneEditTextBox.TextChanged += new System.EventHandler(this.PhoneEditTextBox_TextChanged);
            // 
            // MailEditTextBox
            // 
            this.MailEditTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MailEditTextBox.Location = new System.Drawing.Point(83, 124);
            this.MailEditTextBox.Name = "MailEditTextBox";
            this.MailEditTextBox.Size = new System.Drawing.Size(559, 22);
            this.MailEditTextBox.TabIndex = 24;
            this.MailEditTextBox.TextChanged += new System.EventHandler(this.MailEditTextBox_TextChanged);
            // 
            // VkEditTextBox
            // 
            this.VkEditTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.VkEditTextBox.Location = new System.Drawing.Point(83, 152);
            this.VkEditTextBox.Name = "VkEditTextBox";
            this.VkEditTextBox.Size = new System.Drawing.Size(559, 22);
            this.VkEditTextBox.TabIndex = 23;
            this.VkEditTextBox.TextChanged += new System.EventHandler(this.VkEditTextBox_TextChanged);
            // 
            // BirthdayDateTimePicker
            // 
            this.BirthdayDateTimePicker.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BirthdayDateTimePicker.AutoSize = true;
            this.BirthdayDateTimePicker.Location = new System.Drawing.Point(24, 73);
            this.BirthdayDateTimePicker.Name = "BirthdayDateTimePicker";
            this.BirthdayDateTimePicker.Size = new System.Drawing.Size(53, 13);
            this.BirthdayDateTimePicker.TabIndex = 22;
            this.BirthdayDateTimePicker.Text = "Birthday:";
            // 
            // NameLabel
            // 
            this.NameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(37, 43);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(40, 13);
            this.NameLabel.TabIndex = 21;
            this.NameLabel.Text = "Name:";
            // 
            // NameEditTextBox
            // 
            this.NameEditTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NameEditTextBox.Location = new System.Drawing.Point(83, 40);
            this.NameEditTextBox.Name = "NameEditTextBox";
            this.NameEditTextBox.Size = new System.Drawing.Size(559, 22);
            this.NameEditTextBox.TabIndex = 20;
            this.NameEditTextBox.TextChanged += new System.EventHandler(this.NameEditTextBox_TextChanged);
            // 
            // SurnameEditTextBox
            // 
            this.SurnameEditTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SurnameEditTextBox.Location = new System.Drawing.Point(83, 12);
            this.SurnameEditTextBox.Name = "SurnameEditTextBox";
            this.SurnameEditTextBox.Size = new System.Drawing.Size(559, 22);
            this.SurnameEditTextBox.TabIndex = 19;
            this.SurnameEditTextBox.TextChanged += new System.EventHandler(this.SurnameEditTextBox_TextChanged);
            // 
            // SurnameLabel
            // 
            this.SurnameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SurnameLabel.AutoSize = true;
            this.SurnameLabel.Location = new System.Drawing.Point(23, 15);
            this.SurnameLabel.Name = "SurnameLabel";
            this.SurnameLabel.Size = new System.Drawing.Size(54, 13);
            this.SurnameLabel.TabIndex = 18;
            this.SurnameLabel.Text = "Surname:";
            // 
            // EditFormOKButton
            // 
            this.EditFormOKButton.Location = new System.Drawing.Point(486, 180);
            this.EditFormOKButton.Name = "EditFormOKButton";
            this.EditFormOKButton.Size = new System.Drawing.Size(75, 23);
            this.EditFormOKButton.TabIndex = 30;
            this.EditFormOKButton.Text = "OK";
            this.EditFormOKButton.UseVisualStyleBackColor = true;
            this.EditFormOKButton.Click += new System.EventHandler(this.EditFormOKButton_Click);
            // 
            // EditFormCancelButton
            // 
            this.EditFormCancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.EditFormCancelButton.Location = new System.Drawing.Point(567, 180);
            this.EditFormCancelButton.Name = "EditFormCancelButton";
            this.EditFormCancelButton.Size = new System.Drawing.Size(75, 23);
            this.EditFormCancelButton.TabIndex = 31;
            this.EditFormCancelButton.Text = "Cancel";
            this.EditFormCancelButton.UseVisualStyleBackColor = true;
            this.EditFormCancelButton.Click += new System.EventHandler(this.EditFormCancelButton_Click);
            // 
            // ContactForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(654, 215);
            this.Controls.Add(this.EditFormCancelButton);
            this.Controls.Add(this.EditFormOKButton);
            this.Controls.Add(this.BirthdayDayEditTimePicker);
            this.Controls.Add(this.PhoneLabel);
            this.Controls.Add(this.MailLabel);
            this.Controls.Add(this.VkLabel);
            this.Controls.Add(this.PhoneEditTextBox);
            this.Controls.Add(this.MailEditTextBox);
            this.Controls.Add(this.VkEditTextBox);
            this.Controls.Add(this.BirthdayDateTimePicker);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.NameEditTextBox);
            this.Controls.Add(this.SurnameEditTextBox);
            this.Controls.Add(this.SurnameLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(670, 254);
            this.MinimumSize = new System.Drawing.Size(670, 254);
            this.Name = "ContactForm";
            this.Text = "Contact Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker BirthdayDayEditTimePicker;
        private System.Windows.Forms.Label PhoneLabel;
        private System.Windows.Forms.Label MailLabel;
        private System.Windows.Forms.Label VkLabel;
        private System.Windows.Forms.TextBox PhoneEditTextBox;
        private System.Windows.Forms.TextBox MailEditTextBox;
        private System.Windows.Forms.TextBox VkEditTextBox;
        private System.Windows.Forms.Label BirthdayDateTimePicker;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.TextBox NameEditTextBox;
        private System.Windows.Forms.TextBox SurnameEditTextBox;
        private System.Windows.Forms.Label SurnameLabel;
        private System.Windows.Forms.Button EditFormOKButton;
        private System.Windows.Forms.Button EditFormCancelButton;
    }
}