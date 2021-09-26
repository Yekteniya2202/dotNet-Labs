using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsuranseCompanyCL
{
    interface IValidatable
    {
        public bool IsValid { get; }
    }
}
