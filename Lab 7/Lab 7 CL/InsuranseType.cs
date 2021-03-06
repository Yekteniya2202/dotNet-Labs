using System;

namespace InsuranseCompanyCL
{
    public class InsuranseType : IValidatable
    {
        /// <summary>
        /// Тип страхования
        /// </summary>
        public string InsuranseName { get; set; } = "";

        private static int _newNumber = 0;
        private static int NewNumber
        {
            get
            {
                _newNumber++;
                return _newNumber;
            }
        }

        public int Number { get; }

        public InsuranseType(string insuranseName)
        {
            InsuranseName = insuranseName;
            Number = NewNumber;
        }

        public InsuranseType()
        {

            Number = NewNumber;
        }

        public InsuranseType(InsuranseType type)
        {

            Number = type.Number;
            InsuranseName = type.InsuranseName;
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
