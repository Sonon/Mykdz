using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lib
{
    public class Notary
    {
        private int _Number;
        private string FullName;
        private string PhoneNumber;
        private string Address;
        private string Metrostations;
        /// <summary>
        /// Возвращает номер нотариуса в списке
        /// </summary>
        public int Number
        {
            get
            {
                return _Number;
            }
            set
            {
                if (value >= 1)
                    _Number = value;
                else
                    throw new Exception("Значение не может бать меньше 1");
            }
        }
        /// <summary>
        /// Возвращает полное имя
        /// </summary>
        public string GetFullName
        {
            get
            {
                return FullName;
            }
        }
        /// <summary>
        /// Возвращает фамилию
        /// </summary>
        public string GetSecondName
        {
            get
            {
                string temp = "";
                int i = 0;
                while (i<FullName.Length && FullName[i] != ' ')
                {
                    temp += FullName[i];
                    i++;
                }
                return temp;
            }
        }
        /// <summary>
        /// Возвращает имя
        /// </summary>
        public string GetFirstName
        {
            get
            {
                try
                {
                    int i = 0;
                    while (FullName[i] != ' ')
                    {
                        i++;
                    }
                    i++;
                    if (i >= FullName.Length)
                        throw new Exception();
                    string temp = "";
                    while (i < FullName.Length && FullName[i] != ' ')
                    {
                        temp += FullName[i];
                        i++;
                    }
                    return temp;
                }
                catch(Exception)
                {
                    return "Имя не указано";
                }
            }
        }
        /// <summary>
        /// Возвращает отчество
        /// </summary>
        public string GetThirdName
        {
            get
            {
                try
                {
                    int i = 0;
                    while (FullName[i] != ' ')
                    {
                        i++;
                    }
                    i++;
                    while (FullName[i] != ' ')
                    {
                        i++;
                    }
                    i++;
                    if (i >= FullName.Length)
                        throw new Exception();
                    string temp = "";
                    while (i < FullName.Length && FullName[i] != ' ')
                    {
                        temp += FullName[i];
                        i++;
                    }
                    return temp;
                }
                catch (Exception)
                {
                    return "Отчество не указано";
                }
            }
        }
        /// <summary>
        /// Возвращает номер
        /// </summary>
        public string GetPhoneNumber
        {
            get
            {
                return PhoneNumber;
            }
        }
        /// <summary>
        /// Возвращает адрес
        /// </summary>
        public string GetAddress
        {
            get
            {
                return Address;
            }
        }
        /// <summary>
        /// Возвращает ближайшие станции метро
        /// </summary>
        public string GetMetrostations
        {
            get
            {
                return Metrostations;
            }
        }
        public Notary(int number, string fullName, string phoneNumber, string address, string metrostations)
        {
            _Number = number;
            FullName = fullName;
            PhoneNumber = phoneNumber;
            Address = address;
            Metrostations = metrostations;
        }
        public override string ToString()
        {
            return string.Format("{0}. Name: {1}, phone: {2}, address: {3}, metro: {4}", _Number, GetFullName, GetPhoneNumber, GetAddress, GetMetrostations);
        }
    }
}
