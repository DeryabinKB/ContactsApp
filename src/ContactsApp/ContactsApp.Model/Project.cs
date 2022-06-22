using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactsApp.Model
{
    /// <summary>
    /// ����� ������.
    /// </summary>
    public class Project
    {
        /// <summary>
        /// ������ ���� ���������.
        /// </summary>
        public List<Contact> Contacts { get; set; } = new List<Contact>();

        /// <summary>
        /// ��������� �������� �� �������.
        /// </summary>
        /// <returns></returns>
        public List<Contact> SortBySurname()
        {
            List<Contact> newList = Contacts.OrderBy(contact => contact.Surname).ToList();
            return newList;
        }

        /// <summary>
        /// ������������ ����� ��������� �� �������.
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