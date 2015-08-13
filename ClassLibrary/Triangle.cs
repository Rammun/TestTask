using System;

namespace ClassLibrary
{
    public class Triangle : Figure
    {
        protected decimal a;
        protected decimal b;
        protected decimal c;

        public Triangle(decimal a, decimal b, decimal c)
        {
            this.a = a;
            this.b = b;
            this.c = c;

            if (!IsTriangle()) throw new InvalidTriangleExeption("Неверно заданы параметры треугольника!");
        }

        public decimal A { get { return a; } }
        public decimal B { get { return b; } }
        public decimal C { get { return c; } }

        public override decimal CalculateArea()
        {
            decimal p = (a + b + c) / 2m;
            return (decimal)Math.Sqrt((double)(p * (p - a) * (p - b) * (p - c)));
        }

        protected bool IsTriangle()
        {
            if (a + b > c && a + c > b && b + c > a) return true;
            return false;
        }
    }
}