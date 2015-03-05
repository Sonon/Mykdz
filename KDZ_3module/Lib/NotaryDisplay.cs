using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lib
{
    public class NotaryDisplay
    {
        private Notary MainObj;
        public NotaryDisplay(int number, Notary objToContainer)
        {
            Номер = number.ToString();
            MainObj = objToContainer;
        }
        public string Номер
        { get; set; }
        public string Имя
        {
            get
            {
                return MainObj.GetFullName;
            }
        }
        public string Телефон
        {
            get
            {
                return MainObj.GetPhoneNumber;
            }
        }
        public string Адрес
        {
            get
            {
                return MainObj.GetAddress;
            }
        }
        public string Метро
        {
            get
            {
                return MainObj.GetMetrostations;
            }
        }
    }
}
