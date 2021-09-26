using System;

namespace InsuranseCompanyCL
{
    public class InsuranceType : IValidatable
    {
        /// <summary>
        /// Тип страхования
        /// </summary>
        public string InsuranseName { get; set; } = "";
        public InsuranceType()
        {

        }

        public InsuranceType(string insuranseName)
        {
            InsuranseName = insuranseName;
        }

        public bool IsValid { 
            get
            {
                return string.IsNullOrWhiteSpace(InsuranseName) == false;
            }
        }


        public override string ToString()
        {
            return InsuranseName;
        }
    }
}
