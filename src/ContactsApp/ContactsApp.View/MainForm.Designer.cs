namespace ContactsApp.View
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.MenuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.addContactToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.editContactToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.removeContactToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.FindLable = new System.Windows.Forms.Label();
            this.ContactsListBox = new System.Windows.Forms.ListBox();
            this.FindTextBox = new System.Windows.Forms.TextBox();
            this.SurnameLabel = new System.Windows.Forms.Label();
            this.SurnameTextBox = new System.Windows.Forms.TextBox();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.NameLabel = new System.Windows.Forms.Label();
            this.BirthdayDateTimePicker = new System.Windows.Forms.Label();
            this.VkTextBox = new System.Windows.Forms.TextBox();
            this.MailTextBox = new System.Windows.Forms.TextBox();
            this.PhoneTextBox = new System.Windows.Forms.TextBox();
            this.VkLable = new System.Windows.Forms.Label();
            this.MailLable = new System.Windows.Forms.Label();
            this.PhoneLable = new System.Windows.Forms.Label();
            this.BirthdayDayTimePicker = new System.Windows.Forms.DateTimePicker();
            this.ContactCreatePictureBox = new System.Windows.Forms.PictureBox();
            this.ContactEditPictureBox = new System.Windows.Forms.PictureBox();
            this.ContactDeletePictureBox = new System.Windows.Forms.PictureBox();
            this.MenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ContactCreatePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ContactEditPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ContactDeletePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // MenuStrip
            // 
            this.MenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem1,
            this.editToolStripMenuItem1,
            this.helpToolStripMenuItem1});
            this.MenuStrip.Location = new System.Drawing.Point(0, 0);
            this.MenuStrip.Name = "MenuStrip";
            this.MenuStrip.Size = new System.Drawing.Size(908, 24);
            this.MenuStrip.TabIndex = 1;
            this.MenuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem1
            // 
            this.fileToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem1});
            this.fileToolStripMenuItem1.Name = "fileToolStripMenuItem1";
            this.fileToolStripMenuItem1.Size = new System.Drawing.Size(38, 20);
            this.fileToolStripMenuItem1.Text = "File";
            // 
            // exitToolStripMenuItem1
            // 
            this.exitToolStripMenuItem1.Name = "exitToolStripMenuItem1";
            this.exitToolStripMenuItem1.Size = new System.Drawing.Size(95, 22);
            this.exitToolStripMenuItem1.Text = "Exit";
            // 
            // editToolStripMenuItem1
            // 
            this.editToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addContactToolStripMenuItem1,
            this.editContactToolStripMenuItem1,
            this.removeContactToolStripMenuItem1});
            this.editToolStripMenuItem1.Name = "editToolStripMenuItem1";
            this.editToolStripMenuItem1.Size = new System.Drawing.Size(40, 20);
            this.editToolStripMenuItem1.Text = "Edit";
            // 
            // addContactToolStripMenuItem1
            // 
            this.addContactToolStripMenuItem1.Name = "addContactToolStripMenuItem1";
            this.addContactToolStripMenuItem1.Size = new System.Drawing.Size(167, 22);
            this.addContactToolStripMenuItem1.Text = "Add Contact";
            // 
            // editContactToolStripMenuItem1
            // 
            this.editContactToolStripMenuItem1.Name = "editContactToolStripMenuItem1";
            this.editContactToolStripMenuItem1.Size = new System.Drawing.Size(167, 22);
            this.editContactToolStripMenuItem1.Text = "Edit Contact";
            // 
            // removeContactToolStripMenuItem1
            // 
            this.removeContactToolStripMenuItem1.Name = "removeContactToolStripMenuItem1";
            this.removeContactToolStripMenuItem1.Size = new System.Drawing.Size(167, 22);
            this.removeContactToolStripMenuItem1.Text = "Remove Contact";
            // 
            // helpToolStripMenuItem1
            // 
            this.helpToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem1});
            this.helpToolStripMenuItem1.Name = "helpToolStripMenuItem1";
            this.helpToolStripMenuItem1.Size = new System.Drawing.Size(45, 20);
            this.helpToolStripMenuItem1.Text = "Help";
            // 
            // aboutToolStripMenuItem1
            // 
            this.aboutToolStripMenuItem1.Name = "aboutToolStripMenuItem1";
            this.aboutToolStripMenuItem1.Size = new System.Drawing.Size(108, 22);
            this.aboutToolStripMenuItem1.Text = "About";
            this.aboutToolStripMenuItem1.Click += new System.EventHandler(this.aboutToolStripMenuItem1_Click);
            // 
            // FindLable
            // 
            this.FindLable.AutoSize = true;
            this.FindLable.Location = new System.Drawing.Point(12, 33);
            this.FindLable.Name = "FindLable";
            this.FindLable.Size = new System.Drawing.Size(32, 13);
            this.FindLable.TabIndex = 2;
            this.FindLable.Text = "Find:";
            // 
            // ContactsListBox
            // 
            this.ContactsListBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.ContactsListBox.FormattingEnabled = true;
            this.ContactsListBox.IntegralHeight = false;
            this.ContactsListBox.Items.AddRange(new object[] {
            "Абрамов",
            "Берилов",
            "Семёнов"});
            this.ContactsListBox.Location = new System.Drawing.Point(12, 58);
            this.ContactsListBox.Name = "ContactsListBox";
            this.ContactsListBox.Size = new System.Drawing.Size(214, 429);
            this.ContactsListBox.TabIndex = 3;
            this.ContactsListBox.SelectedIndexChanged += new System.EventHandler(this.ContactsListBox_SelectedIndexChanged);
            // 
            // FindTextBox
            // 
            this.FindTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.FindTextBox.Location = new System.Drawing.Point(50, 30);
            this.FindTextBox.Name = "FindTextBox";
            this.FindTextBox.Size = new System.Drawing.Size(176, 22);
            this.FindTextBox.TabIndex = 4;
            // 
            // SurnameLabel
            // 
            this.SurnameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SurnameLabel.AutoSize = true;
            this.SurnameLabel.Location = new System.Drawing.Point(260, 33);
            this.SurnameLabel.Name = "SurnameLabel";
            this.SurnameLabel.Size = new System.Drawing.Size(54, 13);
            this.SurnameLabel.TabIndex = 5;
            this.SurnameLabel.Text = "Surname:";
            // 
            // SurnameTextBox
            // 
            this.SurnameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SurnameTextBox.Location = new System.Drawing.Point(320, 30);
            this.SurnameTextBox.Name = "SurnameTextBox";
            this.SurnameTextBox.Size = new System.Drawing.Size(576, 22);
            this.SurnameTextBox.TabIndex = 6;
            // 
            // NameTextBox
            // 
            this.NameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NameTextBox.Location = new System.Drawing.Point(320, 58);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(576, 22);
            this.NameTextBox.TabIndex = 7;
            // 
            // NameLabel
            // 
            this.NameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(274, 61);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(40, 13);
            this.NameLabel.TabIndex = 9;
            this.NameLabel.Text = "Name:";
            // 
            // BirthdayDateTimePicker
            // 
            this.BirthdayDateTimePicker.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BirthdayDateTimePicker.AutoSize = true;
            this.BirthdayDateTimePicker.Location = new System.Drawing.Point(261, 93);
            this.BirthdayDateTimePicker.Name = "BirthdayDateTimePicker";
            this.BirthdayDateTimePicker.Size = new System.Drawing.Size(53, 13);
            this.BirthdayDateTimePicker.TabIndex = 10;
            this.BirthdayDateTimePicker.Text = "Birthday:";
            // 
            // VkTextBox
            // 
            this.VkTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.VkTextBox.Location = new System.Drawing.Point(320, 170);
            this.VkTextBox.Name = "VkTextBox";
            this.VkTextBox.Size = new System.Drawing.Size(576, 22);
            this.VkTextBox.TabIndex = 11;
            // 
            // MailTextBox
            // 
            this.MailTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MailTextBox.Location = new System.Drawing.Point(320, 142);
            this.MailTextBox.Name = "MailTextBox";
            this.MailTextBox.Size = new System.Drawing.Size(576, 22);
            this.MailTextBox.TabIndex = 12;
            // 
            // PhoneTextBox
            // 
            this.PhoneTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PhoneTextBox.Location = new System.Drawing.Point(320, 114);
            this.PhoneTextBox.Name = "PhoneTextBox";
            this.PhoneTextBox.Size = new System.Drawing.Size(576, 22);
            this.PhoneTextBox.TabIndex = 13;
            // 
            // VkLable
            // 
            this.VkLable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.VkLable.AutoSize = true;
            this.VkLable.Location = new System.Drawing.Point(267, 173);
            this.VkLable.Name = "VkLable";
            this.VkLable.Size = new System.Drawing.Size(47, 13);
            this.VkLable.TabIndex = 14;
            this.VkLable.Text = "vk.com:";
            // 
            // MailLable
            // 
            this.MailLable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MailLable.AutoSize = true;
            this.MailLable.Location = new System.Drawing.Point(272, 145);
            this.MailLable.Name = "MailLable";
            this.MailLable.Size = new System.Drawing.Size(42, 13);
            this.MailLable.TabIndex = 15;
            this.MailLable.Text = "E-mail:";
            // 
            // PhoneLable
            // 
            this.PhoneLable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PhoneLable.AutoSize = true;
            this.PhoneLable.Location = new System.Drawing.Point(273, 117);
            this.PhoneLable.Name = "PhoneLable";
            this.PhoneLable.Size = new System.Drawing.Size(41, 13);
            this.PhoneLable.TabIndex = 16;
            this.PhoneLable.Text = "Phone:";
            // 
            // BirthdayDayTimePicker
            // 
            this.BirthdayDayTimePicker.Location = new System.Drawing.Point(320, 86);
            this.BirthdayDayTimePicker.Name = "BirthdayDayTimePicker";
            this.BirthdayDayTimePicker.Size = new System.Drawing.Size(125, 22);
            this.BirthdayDayTimePicker.TabIndex = 17;
            this.BirthdayDayTimePicker.Value = new System.DateTime(2022, 3, 14, 0, 0, 0, 0);
            // 
            // ContactCreatePictureBox
            // 
            this.ContactCreatePictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ContactCreatePictureBox.Image = ((System.Drawing.Image)(resources.GetObject("ContactCreatePictureBox.Image")));
            this.ContactCreatePictureBox.Location = new System.Drawing.Point(12, 493);
            this.ContactCreatePictureBox.Name = "ContactCreatePictureBox";
            this.ContactCreatePictureBox.Size = new System.Drawing.Size(19, 20);
            this.ContactCreatePictureBox.TabIndex = 18;
            this.ContactCreatePictureBox.TabStop = false;
            this.ContactCreatePictureBox.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // ContactEditPictureBox
            // 
            this.ContactEditPictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ContactEditPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("ContactEditPictureBox.Image")));
            this.ContactEditPictureBox.Location = new System.Drawing.Point(37, 493);
            this.ContactEditPictureBox.Name = "ContactEditPictureBox";
            this.ContactEditPictureBox.Size = new System.Drawing.Size(20, 21);
            this.ContactEditPictureBox.TabIndex = 20;
            this.ContactEditPictureBox.TabStop = false;
            this.ContactEditPictureBox.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // ContactDeletePictureBox
            // 
            this.ContactDeletePictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ContactDeletePictureBox.Image = ((System.Drawing.Image)(resources.GetObject("ContactDeletePictureBox.Image")));
            this.ContactDeletePictureBox.Location = new System.Drawing.Point(63, 493);
            this.ContactDeletePictureBox.Name = "ContactDeletePictureBox";
            this.ContactDeletePictureBox.Size = new System.Drawing.Size(21, 21);
            this.ContactDeletePictureBox.TabIndex = 21;
            this.ContactDeletePictureBox.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(908, 525);
            this.Controls.Add(this.ContactDeletePictureBox);
            this.Controls.Add(this.ContactEditPictureBox);
            this.Controls.Add(this.ContactCreatePictureBox);
            this.Controls.Add(this.BirthdayDayTimePicker);
            this.Controls.Add(this.PhoneLable);
            this.Controls.Add(this.MailLable);
            this.Controls.Add(this.VkLable);
            this.Controls.Add(this.PhoneTextBox);
            this.Controls.Add(this.MailTextBox);
            this.Controls.Add(this.VkTextBox);
            this.Controls.Add(this.BirthdayDateTimePicker);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.NameTextBox);
            this.Controls.Add(this.SurnameTextBox);
            this.Controls.Add(this.SurnameLabel);
            this.Controls.Add(this.FindTextBox);
            this.Controls.Add(this.ContactsListBox);
            this.Controls.Add(this.FindLable);
            this.Controls.Add(this.MenuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.MenuStrip;
            this.MinimumSize = new System.Drawing.Size(474, 237);
            this.Name = "MainForm";
            this.Text = "ContactsApp";
            this.MenuStrip.ResumeLayout(false);
            this.MenuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ContactCreatePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ContactEditPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ContactDeletePictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip MenuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem addContactToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem editContactToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem removeContactToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem1;
        private System.Windows.Forms.Label FindLable;
        private System.Windows.Forms.ListBox ContactsListBox;
        private System.Windows.Forms.TextBox FindTextBox;
        private System.Windows.Forms.Label SurnameLabel;
        private System.Windows.Forms.TextBox SurnameTextBox;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label BirthdayDateTimePicker;
        private System.Windows.Forms.TextBox VkTextBox;
        private System.Windows.Forms.TextBox MailTextBox;
        private System.Windows.Forms.TextBox PhoneTextBox;
        private System.Windows.Forms.Label VkLable;
        private System.Windows.Forms.Label MailLable;
        private System.Windows.Forms.Label PhoneLable;
        private System.Windows.Forms.DateTimePicker BirthdayDayTimePicker;
        private System.Windows.Forms.PictureBox ContactCreatePictureBox;
        private System.Windows.Forms.PictureBox ContactEditPictureBox;
        private System.Windows.Forms.PictureBox ContactDeletePictureBox;
    }
}

