using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_7_CL.Serialization
{

    [Serializable]
    public class InsuranseContractSerializable 
    {


        /// <summary>
        /// Номер договора
        /// </summary>
        public int Number { get; set; }

        public int BranchNumber { get; set; }

        public int TypeNumber { get; set; }
        /// <summary>
        /// Дата заключения
        /// </summary>
        public DateTime DateOfConclusion { get; set; }
        /// <summary>
        /// Сумма страхования
        /// </summary>
        public decimal Amount { get; set; }
        /// <summary>
        /// Тарифная ставка
        /// </summary>
        public decimal TarifRate { get; set; }
        /// <summary>
        /// Филиал
        /// </summary>
    }
}
