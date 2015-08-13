namespace ClassLibrary
{
    public class RightTriangle : Triangle
    {
        /// <summary>
        /// Создает прямоугольный треугольник по двум катетам
        /// </summary>
        /// <param name="cathetus1">Первый катет</param>
        /// <param name="cathetus2">Второй катет</param>
        public RightTriangle(decimal cathetus1, decimal cathetus2) :
            base(cathetus1, cathetus2, cathetus1 * cathetus1 + cathetus2 * cathetus2)
        {
        }

        /// <summary>
        /// Создает прямоугольник треугольник по трем сторонам, в а и b будут катеты, в с гипотенуза
        /// </summary>
        /// <param name="a">Первая сторона треугольника</param>
        /// <param name="b">Вторая сторона треугольника</param>
        /// <param name="c">Третья сторона треугольника</param>
        public RightTriangle(decimal a, decimal b, decimal c)
            : base(a, b, c)
        {
            if (a * a + b * b == c * c)
                return;

            if (a * a + c * c == b * b)
            {
                decimal tmp = b;
                b = c;
                c = tmp;
                return;
            }

            if (b * b + c * c == a * a)
            {
                decimal tmp = a;
                a = c;
                c = tmp;
                return;
            }

            throw new InvalidTriangleExeption("Параметры не прямоугольного треугольника!");
        }

        public override double CalculateArea()
        {
            return (double)(0.5m * a * b);
        }
    }
}