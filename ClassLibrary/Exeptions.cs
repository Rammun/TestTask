using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    [Serializable]
    public class InvalidTriangleExeption : Exception
    {
        public InvalidTriangleExeption() { }

        public InvalidTriangleExeption(string message) : base(message) { }

        public InvalidTriangleExeption(string message, Exception inner) : base(message, inner) { }

        protected InvalidTriangleExeption(SerializationInfo info, StreamingContext context) : base(info, context) { }
    }
}
