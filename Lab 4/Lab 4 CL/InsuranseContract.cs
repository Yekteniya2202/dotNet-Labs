using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsuranseCompanyCL
{
    public class InsuranseContract : IValidatable
    {
        public InsuranseContract(InsuranseBranch branch)
        {
            Branch = branch;
        }

        /// <summary>
        /// Номер договора
        /// </summary>
        public int ContractNumber { get; set; } = 0;
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
        public InsuranceType InsuranceType { get; set; } = new InsuranceType();

        public bool IsValid
        {
            get
            {
                if (ContractNumber == 0 ||
                    DateOfConclusion == default ||
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
            return $"Номер договора - {ContractNumber}\r\n" +
                $"Дата заключения - {DateOfConclusion}\r\n" +
                $"Страховая сумма - {Amount}\r\n" +
                $"Тарифная ставка - {TarifRate}\r\n" +
                $"Вид страхования - {InsuranceType}";
        }



    }
}
