using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactsApp.Model
{
	public class PhoneNumber
	{
		private double _number;

		/// <summary>
		/// Ограничение длины поля мобильный телефон.
		/// </summary>
		private const int _numberLengthLimit = 11;

		/// <summary>
		/// Возврат или задание значения поля номер.
		/// </summary>
		public double Number
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
        /// Создание экземпляра телефонного номера.
        /// </summary>
        /// <param name="number">Номер телефона контакта.</param>
        public PhoneNumber(double number)
        {
			this._number = number;
        }
	}
}
