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
            Console.WriteLine("Введите параметры прямоугольного треугольника");
            Console.Write("Катет1: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Катет2: ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("Гипотенуза: ");
            double c = double.Parse(Console.ReadLine());

            RightTriangle rt = new RightTriangle(a, b, c);
            Console.WriteLine("Площадь треугольника равна: {0}", rt.CalculateArea());

            Console.ReadKey();
        }
    }
}
