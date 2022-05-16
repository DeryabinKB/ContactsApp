using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ContactsApp.Model;


namespace ContactsApp.View
{
    public partial class MainForm : Form
    {
        private Project _project = new Project();
        public MainForm()
        {
            InitializeComponent();
        }

        private void UpdateListBox()
        {
            ContactsListBox.Items.Clear();
            foreach (Contact contact in _project.Contacts)
            {
                ContactsListBox.Items.Add(contact.Name);
            }
        }

        private void AddContact()
        {
            var randomNames = new List<string>
            {
                "Даниил","Максим","Керилл","Алехандро"
                ,"Фёдр","Пётр"
            };
            var randomSurnames = new List<string>
            {
                "Абрамов","Бериллов","Фёдоров",
                "Семёнов","Константинов"
            };
            //var randomPhoneNumbers = new List<string>
            //{
            //"78005553535","79531239746","79135578913"
            //};
            var randomEmails = new List<string>
            {
                "aaabramov@mail.ru",
                "petrketr@gmail.com",
                "berillii@inbox.ru",
                "ker124@mail.ru",
                "holymail@gmail.com",
                "maxxx123@mail.ru",
                "ded@inbox.ru"
            };
            var randomVkId = new List<string>
            {
                "id845625","kein","berilliin1","heeeeyyy"
            };
            Random random = new Random();
            Contact contact = new Contact(randomNames[random.Next(randomNames.Count)],
                randomSurnames[random.Next(randomSurnames.Count)],
                new PhoneNumber(79534599771),
                //randomPhoneNumbers[random.Next(randomPhoneNumbers.Count)],
                new DateTime(random.Next(1980,2022)),
                randomEmails[random.Next(randomEmails.Count)],
                randomVkId[random.Next(randomVkId.Count)]);
            _project.Contacts.Add(contact);
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

        private void aboutStripMenu_Click(object sender, EventArgs e)
        {
            AboutForm newForm = new AboutForm();
            newForm.Show();
        }

        private void contactCreatePictureBox_Click(object sender, EventArgs e)
        {
            EditForm newForm = new EditForm();
            newForm.Show();
        }

        private void contactEditPictureBox_Click(object sender, EventArgs e)
        {
            EditForm newForm = new EditForm();
            newForm.Show();
        }
    }
}
