using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactsApp.Model
{
    /// <summary>
    /// Класс Проект.
    /// </summary>
    public class Project
    {
        /// <summary>
        /// Список всех контактов.
        /// </summary>
        public List<Contact> Contacts { get; set; } = new List<Contact>();

        /// <summary>
        /// Сортирует контакты по фамилии.
        /// </summary>
        /// <returns></returns>
        public List<Contact> SortBySurname()
        {
            List<Contact> newList = Contacts.OrderBy(contact => contact.Surname).ToList();
            return newList;
        }

        /// <summary>
        /// Осуществляет поиск контактов по фамилии.
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public List<Contact> SearchBySurname(string value)
        {
            return Contacts.Where(contact => contact.Surname.
            ToLower().Contains(value.ToLower())).ToList();
        }
    }
}