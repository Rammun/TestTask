using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Triangle : Figure
    {
        protected double a;
        protected double b;
        protected double c;

        public Triangle(double a, double b, double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;

            if (!IsTriangle()) throw new InvalidTriangleExeption("Неверно заданы параметры треугольника!");
        }

        public override double CalculateArea()
        {
            double p = (a + b + c) / 2;
            return Math.Sqrt(p*(p-a)*(p-b)*(p-c));
        }

        protected bool IsTriangle()
        {
            if (a + b > c && a + c > b && b + c > a) return true;
            return false;
        }
    }
}
