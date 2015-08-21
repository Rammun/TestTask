using System;
using System.Runtime.Serialization;

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
