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
                return;
            }
            if (selectedItem == "Берилов")
            {
                SurnameTextBox.Text = "Берилов";
                NameTextBox.Text = "Максим";
                BirthdayDayTimePicker.Value = new DateTime(1999, 5, 12);
                PhoneTextBox.Text = "+78005553535";
                MailTextBox.Text = "ber@gmail.com";
                VkTextBox.Text = "id1234566";
                return;
            }
            if (selectedItem == "Семёнов")
            {
                SurnameTextBox.Text = "Семёнов";
                NameTextBox.Text = "Кирилл";
                BirthdayDayTimePicker.Value = new DateTime(2003, 2, 1);
                PhoneTextBox.Text = "+78005553535";
                MailTextBox.Text = "verf@inbox.ru";
                VkTextBox.Text = "id1234566";
                return;
            }

        }

        private void aboutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AboutForm newForm = new AboutForm();
            newForm.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            EditForm newForm = new EditForm();
            newForm.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            EditForm newForm = new EditForm();
            newForm.Show();
        }
    }
}
