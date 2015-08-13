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
            // ---> Находим катеты из параметров и делаем, чтоб а и b были катетами
            if (base.a * base.a + base.b * base.b == base.c * base.c)
                return;

            if (base.a * base.a + base.c * base.c == base.b * base.b)
            {
                decimal tmp = base.b;
                base.b = base.c;
                base.c = tmp;
                return;
            }

            if (base.b * base.b + base.c * base.c == base.a * base.a)
            {
                decimal tmp = base.a;
                base.a = base.c;
                base.c = tmp;
                return;
            }

            throw new InvalidTriangleExeption("Параметры не прямоугольного треугольника!");
        }

        public override decimal CalculateArea()
        {
            return 0.5m * a * b;
        }
    }
}