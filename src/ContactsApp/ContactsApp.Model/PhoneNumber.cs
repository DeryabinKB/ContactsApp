using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactsApp.Model
{
	public class PhoneNumber
	{
		private long _number;

		/// <summary>
		/// Ограничение длины поля мобильный телефон.
		/// </summary>
		private const int _numberLengthLimit = 11;

		/// <summary>
		/// Возврат или задание значения поля номер.
		/// </summary>
		public long Number
        {
			get 
			{
				return this._number;
			}
			set
            {
				if (value.ToString().Length>_numberLengthLimit || !value.ToString().StartsWith("7"))
                {
					throw new ArgumentException("Длина номера должна быть меньше 11 символов и начинаться с 7");
                }
				this._number = value;
            }
        }

        /// <summary>
        /// Создание экземпляра телефонного номера.
        /// </summary>
        /// <param name="number">Номер телефона контакта.</param>
        public PhoneNumber(long number)
        {
			this._number = number;
        }
	}
}
