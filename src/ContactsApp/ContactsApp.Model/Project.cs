using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactsApp.Model
{
    /// <summary>
    /// ������.
    /// </summary>
    public class Project
    {
        /// <summary>
        /// ������ ���� ���������.
        /// </summary>
        public List<Contact> Contacts { set; get; } = new List<Contact>();
    }
}