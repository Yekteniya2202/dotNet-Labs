using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsuranseCompanyCL
{
    public class InsuranseContract : IValidatable
    {

        public InsuranseContract()
        {
            Number = NewNumber;
        }

        //Глубокое копирование
        public InsuranseContract(InsuranseContract contract)
        {
            Number = contract.Number;
            Branch = new InsuranseBranch(contract.Branch);
            InsuranceType = new InsuranseType(contract.InsuranceType);
        }
        public InsuranseContract(InsuranseType type, InsuranseBranch branch)
        {
            Number = NewNumber;
            Branch = branch;
            InsuranceType = type;
        }
        public InsuranseContract(InsuranseType type, InsuranseBranch branch, DateTime date) : this(type, branch)
        {
            Number = NewNumber;
            DateOfConclusion = date;
        }

        private static int _newNumber = 0;
        private static int NewNumber
        {
            get
            {
                _newNumber++;
                return _newNumber;
            }
        }
        /// <summary>
        /// Номер договора
        /// </summary>
        public int Number { get; }
        
        /// <summary>
        /// Дата заключения
        /// </summary>
        public DateTime DateOfConclusion { get; set; } = DateTime.Today;
        /// <summary>
        /// Сумма страхования
        /// </summary>
        public decimal Amount { get; set; } = 0;
        /// <summary>
        /// Тарифная ставка
        /// </summary>
        public decimal TarifRate { get; set; } = 0;
        /// <summary>
        /// Филиал
        /// </summary>
        public InsuranseBranch Branch { get; set; } = new InsuranseBranch();

        /// <summary>
        /// Вид страхования
        /// </summary>
        public InsuranseType InsuranceType { get; set; } = new InsuranseType();

        public bool IsValid
        {
            get
            {
                if (Number == 0 ||
                    Amount == 0 ||
                    TarifRate == 0 ||
                    Branch.IsValid == false ||
                    InsuranceType.IsValid == false)
                    return false;
                return true;
            }
        }

        public override string ToString()
        {
            return $"Номер договора - {Number}\r\n" +
                $"Дата заключения - {DateOfConclusion}\r\n" +
                $"Страховая сумма - {Amount}\r\n" +
                $"Тарифная ставка - {TarifRate}\r\n" +
                $"Филиал - {Branch}\r\n" +
                $"Вид страхования - {InsuranceType}";
        }

    }
}
