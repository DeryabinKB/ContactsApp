using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactsApp.Model
{
	class PhoneNumber
	{
		private long int _number;

		/// <summary>
		/// Ограничение длины поля мобильный телефон.
		/// </summary>
		private const int _numberLengthLimit = 11;

		/// <summary>
		/// Возврат или задание значения поля номер.
		/// </summary>
		public long	Number
        {
			get 
			{
				return this._number;
			}
			set
            {
				if (value.ToString().Length>_numberLengthLimit || !value.ToString().StartsWith("7"))
                {
					throw new ArgumentException();
                }
				this._number = value;
            }
        }

		/// <summary>
		/// Конструктор номера.
		/// </summary>
		/// <param name="number">Номер телефона контакта.</param>
		public PhoneNumber(long int number)
        {
			this._number = number;
        }

		PhoneNumber(23);
	}
}
