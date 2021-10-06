using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace Lab_6_CL.Exception
{
    [Serializable]
    public class InvalidTypeException : System.Exception
    {
        public InvalidTypeException()
        {
        }

        public InvalidTypeException(string message) : base(message)
        {
        }

        public InvalidTypeException(string message, System.Exception inner) : base(message, inner)
        {
        }

        protected InvalidTypeException(
            SerializationInfo info,
            StreamingContext context) : base(info, context)
        {
        }
    }
}
