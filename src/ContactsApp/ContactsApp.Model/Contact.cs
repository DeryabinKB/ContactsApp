using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ContactsApp.Model
{
    /// <summary>
    /// ����� �������.
    /// </summary>
    public class Contact : ICloneable
    {
        /// <summary>
        /// ������� ��������.
        /// </summary>
        private string _surname;

        /// <summary>
        /// ��� ��������.
        /// </summary>
        private string _name;

        /// <summary>
        /// ���� �������� ��������.
        /// </summary>
        private DateTime _birthday;

        /// <summary>
        /// �������� ����� ��������. 
        /// </summary>
        private string _email;

        /// <summary>
        /// ����������� ����� �����: �������, ���, ����. 
        /// </summary>
        public const int _letterLengthLimit = 50;

        /// <summary>
        /// ���� ��������� ��������.
        /// </summary>
        private string _vkId;

        /// <summary>
        /// ����������� ����� ���� �� ����.
        /// </summary>
        public const int _vkIdLengthLimit = 15;

        public PhoneNumber Number { get; set; }

        /// <summary>
        /// ������� ��� ������� �������� ���� �������.
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
        /// ������� ��� ������� �������� ���� ���.
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
        /// ������� ��� ������� �������� ���� ���� ��������.
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
        /// ������� ��� ������� �������� ���� ����.
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
        /// ������� ��� ������� �������� ���� �� ����.
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
        /// ����������� ���������.
        /// </summary>
        /// <param name="name">��� ��������.</param>
        /// <param name="surname">������� ��������.</param>
        /// <param name="number">����� �������� ��������.</param>
        /// <param name="birthday">���� �������� ��������.</param>
        /// <param name="email">���� ��������.</param>
        /// <param name="vkId">VK id ��������.</param>
        public Contact(string name, string surname, PhoneNumber number,
            DateTime birthday, string email, string vkId)
        {
            this.Name = name;
            this.Surname = surname;
            this.Number = number;
            this.Birthday = birthday;
            this.Email = email;
            this.VkId = vkId;
        }

        /// <summary>
        /// ������� ��� �������� ����� ��������.
        /// </summary>
        object ICloneable.Clone()
        {
            return new Contact(this.Name, this.Surname,
                new PhoneNumber(this.Number.Number), this.Birthday,
                this.Email, this.VkId);
        }
    }
}