using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace Lab_6_CL.Exception
{
    [Serializable]
    public class InvalidContractException : System.Exception
    {
        public InvalidContractException()
        {
        }

        public InvalidContractException(string message) : base(message)
        {
        }

        public InvalidContractException(string message, System.Exception inner) : base(message, inner)
        {
        }

        protected InvalidContractException(
            SerializationInfo info,
            StreamingContext context) : base(info, context)
        {
        }
    }
}
