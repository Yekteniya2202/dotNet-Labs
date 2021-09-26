using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace InsuranseCompanyCL
{
    public static class InsuranseCompany
    {
        public static Dictionary<int, InsuranseType> Types { get; } = new Dictionary<int, InsuranseType>();

        public static Dictionary<int, InsuranseBranch> Branches { get; } = new Dictionary<int, InsuranseBranch>();

        public static List<InsuranseContract> Contracts { get; } = new List<InsuranseContract>();
    }
}
