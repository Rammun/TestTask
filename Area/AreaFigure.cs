using System;

namespace Area
{
    public static class AreaFigure
    {
        public static decimal AreaRightTriangle(decimal a, decimal b, decimal c)
        {
            if (a < 0 || b < 0 || c < 0) throw new Exception("Отрицательные параметры недопустимы!");
            if (a + b < c || a + c < b || b + c < a) throw new Exception("Параметры не принадлежат треугольнику!");

            if (a * a + b * b == c * c)
                return 0.5m * a * b;

            if (a * a + c * c == b * b)
                return 0.5m * a * c;

            if (b * b + c * c == a * a)
                return 0.5m * b * c;

            throw new Exception("Параметры не прямоугольного треугольника!");
        }
    }
}
