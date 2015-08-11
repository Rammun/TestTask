using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class RightTriangle : Triangle
    {
        public RightTriangle(double cathetus1, double cathetus2, double hypotenuse) : 
            base (cathetus1, cathetus2, hypotenuse)
        {
            if (cathetus1 * cathetus1 + cathetus2 * cathetus2 != hypotenuse * hypotenuse)
                throw new InvalidTriangleExeption("Входные параметры не принадлежат прямоугольному треугольнику!");
        }

        public override double CalculateArea()
        {
            return 0.5 * a * b;
        }
    }
}
