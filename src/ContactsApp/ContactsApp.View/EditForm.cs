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
    public partial class ContactForm : Form
    {

        private Contact _contact = new Contact("Kein", "Brawn", new PhoneNumber(79534599771),
                new DateTime(2001, 06, 07), "ffff@mail.ru", "vkidddd");

        private void UpdateForm()
        {
            SurnameEditTextBox.Text = _contact.Surname;
            NameEditTextBox.Text = _contact.Name;
            BirthdayDayEditTimePicker.Value = _contact.Birthday;
            PhoneEditTextBox.Text = "78005553537";
            MailEditTextBox.Text = _contact.Email;
            VkEditTextBox.Text = _contact.VkId;
        }

        public ContactForm()
        {
            InitializeComponent();
            UpdateForm();
        }

        private void EditFormOKButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void EditFormCancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
