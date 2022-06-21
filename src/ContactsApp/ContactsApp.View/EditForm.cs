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
        /// <summary>
        /// Создание экземпляра контакта.
        /// </summary>
        public Contact _contact = new Contact(" ", " ", new PhoneNumber(7),
                new DateTime(2001, 06, 07), " ", " ");

        /// <summary>
        /// Цвет поля при корректном вводе.
        /// </summary>
        private Color correctColor = Color.White; 

        /// <summary>
        /// Цвет поля при некорректном вводе.
        /// </summary>
        private Color incorrectColor = Color.LightPink;

        /// <summary>
        /// Сеттер и геттер контакта.
        /// </summary>
        public Contact Contact
        { 
            get 
            { 
                return _contact; 
            }
            set
            {
                _contact = value;
            }
        }

        /// <summary>
        /// Тексты ошибки фамилии.
        /// </summary>
        private string _surnameError;

        /// <summary>
        /// Тексты ошибки имени.
        /// </summary>
        private string _nameError;

        /// <summary>
        /// Тексты ошибки фамилии.
        /// </summary>
        private string _phoneNumberError;

        /// <summary>
        /// Тексты ошибки дня рождения.
        /// </summary>
        private string _birthdayError;

        /// <summary>
        /// Тексты ошибки поля мэйл.
        /// </summary>
        private string _emailError;

        /// <summary>
        /// Тексты ошибки вк айди.
        /// </summary>
        private string _vkIdError;

        public ContactForm()
        {

            InitializeComponent();
            UpdateForm();
        }

        /// <summary>
        /// Проверка полей на корректность ввода.
        /// </summary>
        /// <returns>Если всё введено корректно, то не выводится ничего, в случае ошибки
        /// выводится поля, в которых ошибка допущена.</returns>
        private bool CheckFormOnErrors()
        {
            string errorText = string.Empty;

            if (_surnameError != string.Empty)
            {
                errorText = errorText + "|| Incorrect surname ||\n";
            }
            
            if (_nameError != string.Empty)
            {
                errorText = errorText + "|| Incorrect name ||\n";
            }
            
            if (_phoneNumberError != string.Empty)
            {
                errorText = errorText + "|| Incorrect number ||\n";
            }
            
            if (_birthdayError != string.Empty)
            {
                errorText = errorText + "|| Incorrect birthday ||\n";
            }
            
            if (_emailError != string.Empty)
            {
                errorText = errorText + "|| Incorrect mail ||\n";
            }
            
            if (_vkIdError != string.Empty)
            {
                errorText = errorText + "|| Incorrect vkId ||\n";
            }
            if (errorText == string.Empty)
            {
                return true;
            }
            else 
            {
                MessageBox.Show(errorText);
                return false;
            }
        }

        /// <summary>
        /// Обновление информации в форме.
        /// </summary>
        public void UpdateForm()
        {
            SurnameEditTextBox.Text = _contact.Surname;
            NameEditTextBox.Text = _contact.Name;
            BirthdayDayEditTimePicker.Value = _contact.Birthday;
            PhoneEditTextBox.Text = "78005553537";
            MailEditTextBox.Text = _contact.Email;
            VkEditTextBox.Text = _contact.VkId;
        }

        /// <summary>
        /// Обработка нажатия кнопки OK.
        /// </summary>
        private void EditFormOKButton_Click(object sender, EventArgs e)
        {
            if (CheckFormOnErrors() == true)
            {
                DialogResult = DialogResult.OK;
                UpdateForm();
                Close();
            }
        }

        /// <summary>
        /// Обработка нажатия кнопки Cancel.
        /// </summary>
        private void EditFormCancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// Изменение данных в контакте при изменении поля фамилии.
        /// </summary>
        private void SurnameEditTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _contact.Surname = SurnameEditTextBox.Text;
                SurnameEditTextBox.BackColor = correctColor;
                _surnameError = string.Empty;
            }
            catch(ArgumentException exception)
            {
                SurnameEditTextBox.BackColor = incorrectColor;
                _surnameError = exception.Message;
            }
            
        }

        /// <summary>
        /// Изменение данных в контакте при изменении поля имени.
        /// </summary>
        private void NameEditTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _contact.Name = NameEditTextBox.Text;
                NameEditTextBox.BackColor = correctColor;
                _nameError = string.Empty;
            }
            catch (ArgumentException exception)
            {
                NameEditTextBox.BackColor = incorrectColor;
                _nameError= exception.Message;
            }
        }

        /// <summary>
        /// Изменение данных в контакте при изменении поля даты рождения.
        /// </summary>>
        private void BirthdayDayEditTimePicker_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                _contact.Birthday = BirthdayDayEditTimePicker.Value;
                BirthdayDayEditTimePicker.BackColor = correctColor;
                _birthdayError = string.Empty;
            }
            catch (ArgumentException exception)
            {
                BirthdayDayEditTimePicker.BackColor = incorrectColor;
                _birthdayError = exception.Message;
            }
        }

        /// <summary>
        /// Изменение данных в контакте при изменении поля номера телефона.
        /// </summary>
        private void PhoneEditTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _contact.Number.Number = Convert.ToInt64(PhoneEditTextBox.Text);
                PhoneEditTextBox.BackColor = correctColor;
                _phoneNumberError = string.Empty;
            }
            catch (System.FormatException exception)
            {
                PhoneEditTextBox.BackColor = incorrectColor;
                _phoneNumberError= "Length of number must be less then 11 symbols and should start from 7";
            }
            catch (ArgumentException exception)
            {
                PhoneEditTextBox.BackColor = incorrectColor;
                _phoneNumberError = exception.Message;
            }
        }

        /// <summary>
        /// Изменение данных в контакте при изменении поля мэйла.
        /// </summary>
        private void MailEditTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _contact.Email = MailEditTextBox.Text;
                MailEditTextBox.BackColor = correctColor;
                _emailError = string.Empty;
            }
            catch (ArgumentException exception)
            {
                MailEditTextBox.BackColor = incorrectColor;
                _emailError= exception.Message;
            }
        }

        /// <summary>
        /// Изменение данных в контакте при изменении поля айди вк.
        /// </summary>
        private void VkEditTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _contact.VkId = VkEditTextBox.Text;
                VkEditTextBox.BackColor = correctColor;
                _vkIdError = string.Empty;
            }
            catch (ArgumentException exception)
            {
                VkEditTextBox.BackColor = incorrectColor;
                _vkIdError= exception.Message;
            }
        }

        /// <summary>
        /// Функция обновления данных контакта. 
        /// </summary>
        public void UpdateContact()
        {
            _contact.Surname = SurnameEditTextBox.Text;
            _contact.Name = NameEditTextBox.Text;
            _contact.Birthday = BirthdayDayEditTimePicker.Value;
            _contact.Number.Number = Convert.ToInt64(PhoneEditTextBox.Text);
            _contact.Email = MailEditTextBox.Text;
            _contact.VkId = VkEditTextBox.Text;

        }
    }
}
