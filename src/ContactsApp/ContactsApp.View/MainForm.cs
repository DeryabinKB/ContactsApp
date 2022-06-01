using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContactsApp.View
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Показ другого контакта.
        /// </summary>
        private void ContactsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedItem;
            selectedItem = ContactsListBox.SelectedItem.ToString();
            if (selectedItem == "Абрамов")
            {
                SurnameTextBox.Text = "Абрамов";
                NameTextBox.Text = "Даниил";
                BirthdayDayTimePicker.Value = new DateTime(2001, 7, 6);
                PhoneTextBox.Text = "+78005553535";
                MailTextBox.Text = "abram@mail.ru";
                VkTextBox.Text = "id0000000";
            }
            if (selectedItem == "Берилов")
            {
                SurnameTextBox.Text = "Берилов";
                NameTextBox.Text = "Максим";
                BirthdayDayTimePicker.Value = new DateTime(1999, 5, 12);
                PhoneTextBox.Text = "+78905553535";
                MailTextBox.Text = "ber@gmail.com";
                VkTextBox.Text = "ididididid";
            }
            if (selectedItem == "Семёнов")
            {
                SurnameTextBox.Text = "Семёнов";
                NameTextBox.Text = "Кирилл";
                BirthdayDayTimePicker.Value = new DateTime(2003, 2, 1);
                PhoneTextBox.Text = "+78505553535";
                MailTextBox.Text = "verf@inbox.ru";
                VkTextBox.Text = "idddiiiii";
            }

        }

        /// <summary>
        /// Открытие окна About через верхнее меню.
        /// </summary>
        private void aboutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AboutForm newForm = new AboutForm();
            newForm.Show();
        }

        /// <summary>
        /// Открытие формы создания контакта.
        /// </summary>
        private void ContactCreatePictureBox_Click(object sender, EventArgs e)
        {
            EditForm newForm = new EditForm();
            newForm.Show();
        }

        /// <summary>
        /// Открытие формы изменения контакта.
        /// </summary>
        private void ContactEditpictureBox_Click(object sender, EventArgs e)
        {
            EditForm newForm = new EditForm();
            newForm.Show();
        }
    }
}
