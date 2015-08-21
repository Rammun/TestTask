using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestTask
{
    class Program
    {
        static void Main(string[] args)
        {
            while(true)
            {
                Console.WriteLine("Введите параметры прямоугольного треугольника");
                Console.Write("A: ");
                decimal a = decimal.Parse(Console.ReadLine());
                Console.Write("B: ");
                decimal b = decimal.Parse(Console.ReadLine());
                Console.Write("C: ");
                decimal c = decimal.Parse(Console.ReadLine());

                //RightTriangle rt = new RightTriangle(a, b, c);
                //Console.WriteLine("Площадь треугольника равна: {0}", rt.CalculateArea());

                Console.WriteLine("Площадь треугольника равна: {0}", Area.AreaFigure.AreaRightTriangle(a, b, c));

                Console.ReadKey();
            }
        }
    }
}
