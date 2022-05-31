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
		/// ����������� ����� ���� ��������� �������.
		/// </summary>
		private const int _numberLengthLimit = 11;

		/// <summary>
		/// ������� ��� ������� �������� ���� �����.
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
        /// �������� ���������� ����������� ������.
        /// </summary>
        /// <param name="number">����� �������� ��������.</param>
        public PhoneNumber(double number)
        {
			this._number = number;
        }
	}
}