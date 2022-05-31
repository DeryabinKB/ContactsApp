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
        private string _surnameError;
        private string _nameError;
        private string _phoneNumberError;
        private string _birthdayError;
        private string _emailError;
        private string _vkIdError;

        private bool CheckFromOnErrors()
        {
            if (_surnameError != null)
            {
                MessageBox.Show(_surnameError);
                return false;
            }
            else if (_surnameError == null)
            {
                return false;
            }
            else if (_nameError != null)
            {
                MessageBox.Show(_nameError);
                return false;
            }
            else if (_nameError == null)
            {
                return true;
            }
            else if (_phoneNumberError != null)
            {
                MessageBox.Show(_phoneNumberError);
                return false;
            }
            else if (_phoneNumberError == null)
            {
                return true;
            }
            else if (_birthdayError != null)
            {
                MessageBox.Show(_birthdayError);
                return false;
            }
            else if (_birthdayError == null)
            {
                return true;
            }
            else if (_emailError != null)
            {
                MessageBox.Show(_emailError);
                return false;
            }
            else if (_emailError == null)
            {
                return true;
            }
            else if (_vkIdError != null)
            {
                MessageBox.Show(_vkIdError);
                return false;
            }
            else if (_vkIdError == null)
            {
                return true;
            }
            return true;
        }

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
            if (CheckFromOnErrors() == true)
            {
                Close();
            }
            
        }

        private void EditFormCancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void SurnameEditTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _contact.Surname = SurnameEditTextBox.Text;
                SurnameEditTextBox.BackColor = Color.White;
                _surnameError = string.Empty;
            }
            catch(ArgumentException exception)
            {
                SurnameEditTextBox.BackColor = Color.LightPink;
                _surnameError = exception.Message;
            }
            
        }

        private void NameEditTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _contact.Name = NameEditTextBox.Text;
                NameEditTextBox.BackColor = Color.White;
                _nameError = string.Empty;
            }
            catch (ArgumentException exception)
            {
                NameEditTextBox.BackColor = Color.LightPink;
                _nameError= exception.Message;
            }
        }

        private void BirthdayDayEditTimePicker_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                _contact.Birthday = BirthdayDayEditTimePicker.Value;
                BirthdayDayEditTimePicker.BackColor = Color.White;
                _birthdayError = string.Empty;
            }
            catch (ArgumentException exception)
            {
                BirthdayDayEditTimePicker.BackColor = Color.LightPink;
                _birthdayError= exception.Message;
            }
        }

        private void PhoneEditTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _contact.Number.Number = Convert.ToInt64(PhoneEditTextBox.Text);
                PhoneEditTextBox.BackColor = Color.White;
                _phoneNumberError = string.Empty;
            }
            catch (ArgumentException exception)
            {
                NameEditTextBox.BackColor = Color.LightPink;
                _phoneNumberError= exception.Message;
            }
        }

        private void MailEditTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _contact.Email = MailEditTextBox.Text;
                MailEditTextBox.BackColor = Color.White;
                _emailError = string.Empty;
            }
            catch (ArgumentException exception)
            {
                MailEditTextBox.BackColor = Color.LightPink;
                _emailError= exception.Message;
            }
        }

        private void VkEditTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _contact.VkId = VkEditTextBox.Text;
                VkEditTextBox.BackColor = Color.White;
                _vkIdError = string.Empty;
            }
            catch (ArgumentException exception)
            {
                VkEditTextBox.BackColor = Color.LightPink;
                _vkIdError= exception.Message;
            }
        }
    }
}
