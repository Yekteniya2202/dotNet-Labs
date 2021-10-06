using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace Lab_6_CL.Exception
{
    [Serializable]
    public class InvalidBranchException : System.Exception
    {
        public InvalidBranchException()
        {
        }

        public InvalidBranchException(string message) : base(message)
        {
        }

        public InvalidBranchException(string message, System.Exception inner) : base(message, inner)
        {
        }

        protected InvalidBranchException(
            SerializationInfo info,
            StreamingContext context) : base(info, context)
        {
        }
    }
}

