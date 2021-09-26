using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsuranseCompanyCL
{
    public class InsuranseBranch : IValidatable
    {
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
        }

        public InsuranseBranch(string name, string address, string phoneNumber)
        {
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
            return $"Наименование филиала - {Name}\r\n" +
                $"Адрес филиала - {Address}\r\n" +
                $"Телефонный номер филиала - {PhoneNumber}\r\n";
        }
    }
}
