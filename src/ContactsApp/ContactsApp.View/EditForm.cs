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

        private Contact _contact = new Contact(" ", " ", new PhoneNumber(7),
                new DateTime(2001, 06, 07), " ", " ");
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
        /// Тексты ошибок.
        /// </summary>
        private string _surnameError;
        private string _nameError;
        private string _phoneNumberError;
        private string _birthdayError;
        private string _emailError;
        private string _vkIdError;

        public ContactForm()
        {
            _contact = new Contact(" ", " ", new PhoneNumber(7),
                new DateTime(2001, 06, 07), " ", " ");
            InitializeComponent();
            UpdateForm();
        }

        /// <summary>
        /// Проверка полей на корректность ввода
        /// </summary>
        /// <returns></returns>
        private bool CheckFormOnErrors()
        {
            if (_surnameError != string.Empty)
            {
                MessageBox.Show(_surnameError);
                return false;
            }
            
            if (_nameError != string.Empty)
            {
                MessageBox.Show(_nameError);
                return false;
            }
            
            if (_phoneNumberError != string.Empty)
            {
                MessageBox.Show(_phoneNumberError);
                return false;
            }
            
            if (_birthdayError != string.Empty)
            {
                MessageBox.Show(_birthdayError);
                return false;
            }
            
            if (_emailError != string.Empty)
            {
                MessageBox.Show(_emailError);
                return false;
            }
            
            if (_vkIdError != string.Empty)
            {
                MessageBox.Show(_vkIdError);
                return false;
            }
            if (_surnameError == string.Empty)
            {
                return true;
            }

            return true;
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
                SurnameEditTextBox.BackColor = Color.White;
                _surnameError = string.Empty;
            }
            catch(ArgumentException exception)
            {
                SurnameEditTextBox.BackColor = Color.LightPink;
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
                NameEditTextBox.BackColor = Color.White;
                _nameError = string.Empty;
            }
            catch (ArgumentException exception)
            {
                NameEditTextBox.BackColor = Color.LightPink;
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
                BirthdayDayEditTimePicker.BackColor = Color.White;
                _birthdayError = string.Empty;
            }
            catch (ArgumentException exception)
            {
                BirthdayDayEditTimePicker.BackColor = Color.LightPink;
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
                PhoneEditTextBox.BackColor = Color.White;
                _phoneNumberError = string.Empty;
            }
            catch (System.FormatException exception)
            {
                PhoneEditTextBox.BackColor = Color.LightPink;
                _phoneNumberError= "Некорректный номер. Он должен начинаться с 7 и быть меньше 11 символов";
            }
            catch (ArgumentException exception)
            {
                PhoneEditTextBox.BackColor = Color.LightPink;
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
                MailEditTextBox.BackColor = Color.White;
                _emailError = string.Empty;
            }
            catch (ArgumentException exception)
            {
                MailEditTextBox.BackColor = Color.LightPink;
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
                VkEditTextBox.BackColor = Color.White;
                _vkIdError = string.Empty;
            }
            catch (ArgumentException exception)
            {
                VkEditTextBox.BackColor = Color.LightPink;
                _vkIdError= exception.Message;
            }
        }


        /// <summary>
        /// В данной функции нет нужды, т.к.
        /// всё обновляется в другом месте
        /// </summary>
        //public void UpdateContact()
        //{
        //    _contact.Surname = SurnameEditTextBox.Text;
        //    _contact.Name = NameEditTextBox.Text;
        //    _contact.Birthday = BirthdayDayEditTimePicker.Value;
        //    _contact.Number.Number = Convert.ToInt64(PhoneEditTextBox.Text);
        //    _contact.Email = MailEditTextBox.Text;
        //    _contact.VkId= VkEditTextBox.Text;

        //}
    }
}
