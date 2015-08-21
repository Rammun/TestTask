using System;

namespace Area
{
    public static class AreaFigure
    {
        // До какого знака округляем
        const int delta = 1;

        public static decimal AreaRightTriangle(decimal a, decimal b, decimal c)
        {
            if (a < 0 || b < 0 || c < 0) throw new Exception("Отрицательные параметры недопустимы!");
            if (a + b < c || a + c < b || b + c < a) throw new Exception("Параметры не принадлежат треугольнику!");

            // Находим катеты. Вычичления при сравнении округляем до десятой
            if (Math.Round(a * a + b * b, delta) == Math.Round(c * c, delta))
                return 0.5m * a * b;

            if (Math.Round(a * a + c * c, delta) == Math.Round(b * b, delta))
                return 0.5m * a * c;

            if (Math.Round(b * b + c * c, delta) == Math.Round(a * a, delta))
                return 0.5m * b * c;

            throw new Exception("Параметры не прямоугольного треугольника!");
        }
    }
}
