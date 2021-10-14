using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsuranseCompanyCL
{
    [Serializable]
    public class InsuranseBranch : IValidatable
    {
        private static int _newNumber = 0;
        public static int NewNumber
        {
            get
            {
                _newNumber++;
                return _newNumber;
            }
            set
            {
                _newNumber = value;
            }
        }
        public int Number { get; set; }
        /// <summary>
        /// Наименование филиала
        /// </summary>
        public string Name { get; set; } = "";
        /// <summary>
        /// Адрес филиала
        /// </summary>
        public string Address { get; set; } = "";
        /// <summary>
        /// Телефонный номер филиала
        /// </summary>
        public string PhoneNumber { get; set; } = "";
        public InsuranseBranch()
        {
            Number = NewNumber;
        }

        public InsuranseBranch(string name, string address, string phoneNumber)
        {
            Number = NewNumber;
            Name = name;
            Address = address;
            PhoneNumber = phoneNumber;
        }
        public bool IsValid
        {
            get
            {
                if (string.IsNullOrWhiteSpace(Name) ||
                    string.IsNullOrWhiteSpace(Address) ||
                    string.IsNullOrWhiteSpace(PhoneNumber))
                    return false;
                return true;
            }
        }
        public override string ToString()
        {
            return Name;
        }
    }
}
