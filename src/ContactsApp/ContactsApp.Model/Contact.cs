using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactsApp.Model
{
    /// <summary>
    /// Класс контакт.
    /// </summary>
    public class Contact : ICloneable
    {
        /// <summary>
        /// Фамилия контакта.
        /// </summary>
        private string _surname;

        /// <summary>
        /// Имя контакта.
        /// </summary>
        private string _name;

        /// <summary>
        /// Дата рождения контакта.
        /// </summary>
        private DateTime _birthday;

        /// <summary>
        /// Номер контакта.
        /// </summary>
        private PhoneNumber _phoneNumber;

        /// <summary>
        /// Почтовый адрес контакта. 
        /// </summary>
        private string _email;

        /// <summary>
        /// Ограничение длины полей: фамилия, имя, мэйл. 
        /// </summary>
        public const int _letterLengthLimit = 50;

        /// <summary>
        /// Айди Вконтакте контакта.
        /// </summary>
        private string _vkId;

        /// <summary>
        /// Ограничение длины поля вк айди.
        /// </summary>
        public const int _vkIdLengthLimit = 15;

        /// <summary>
        /// Возврат или задание значения поля Фамилия.
        /// </summary>
        public string Surname
        {
            get 
            { 
                return _surname; 
            }
            set
            {
                if (value.Length > _letterLengthLimit || value.Length == 0)
                {
                    throw new ArgumentException();
                }
                _surname = value;
            }
        }

        /// <summary>
        /// Возврат или задание значения поля Имя.
        /// </summary>
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                if (value.Length> _letterLengthLimit || value.Length == 0)
                {
                    throw new ArgumentException();
                }
                _name = value;
            }
        }

        /// <summary>
        /// Возврат или задание значения поля Дата рождения.
        /// </summary>
        public DateTime Birthday
        {
            get
            { 
                return _birthday; 
            }
        set
            {
                if (value.Year < 1900 || value > DateTime.Now)
                {
                    throw new ArgumentException();
                }
                _birthday = value;
            }
        }

        /// <summary>
        /// Возврат или задание значения поля Мэйл.
        /// </summary>
        public string Email
        {
            get 
            { 
                return _email; 
            }
            set
            {
                if (value.Length>_letterLengthLimit || value.Length == 0)
                {
                    throw new ArgumentException();
                }
                _email = value;
            }
        }

        /// <summary>
        /// Возврат или задание значения поля Вк айди.
        /// </summary>
        public string VkId
        {
            get 
            { 
                return _vkId; 
            }
            set
            {
                if (value.Length > _vkIdLengthLimit ||value.Length == 0)
                {
                    throw new ArgumentException();
                }
                _vkId = value;
            }
        }

        /// <summary>
        /// Конструктор контактов.
        /// </summary>
        public Contact(string name, string surname, PhoneNumber phoneNumber,
            DateTime birthday, string email, string vkId)
        {
            this.Name = name;
            this.Surname = surname;
            this.PhoneNumber = phoneNumber;
            this.Birthday = birthday;
            this.Email = email;
            this.VkId = vkId;
        }

        /// <summary>
        /// Функция для создания копии объектов.
        /// </summary>
        object ICloneable.Clone()
        {
            return new Contact(this.Name, this.Surname,
                new PhoneNumber(this.PhoneNumber.Number), this.Birthday,
                this.Email, this.VkId);
        }
    }
}