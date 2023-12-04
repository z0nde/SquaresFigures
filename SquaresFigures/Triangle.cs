namespace SquaresFigures
{
    public class Triangle : ICalculation
    {
        /// <summary>
        /// Высота
        /// </summary>
        private readonly double _H;
        /// <summary>
        /// Основание
        /// </summary>
        private readonly double _X;


        /// <summary>
        /// Сторона A
        /// </summary>
        private readonly double _A;
        /// <summary>
        /// Сторона B
        /// </summary>
        private readonly double _B;
        /// <summary>
        /// Сторона C
        /// </summary>
        private readonly double _C;

        /// <summary>
        /// Вспомогательтное число, в которой есть формула, при рассчёте основной формулы
        /// </summary>
        private double _P
        {
            get { return (_A + _B + _C) / 2.0; }
        }


        /// <summary>
        /// Контроллер, предназначеный для выполнения действия, в зависимости от 
        /// использованного конструктора
        /// </summary>
        private readonly uint _Cont;


        /// <summary>
        /// Конструктор принимающий в себя высоту и основание, 
        /// для дальнейшего подсчёта площади треугольника по формуле основания на высоту.
        /// </summary>
        /// <param name="h">Высота</param>
        /// <param name="x">Основание</param>
        public Triangle(double h, double x) => 
            (_H, _X, _Cont) = (h, x, 1);

        /// <summary>
        /// Конструктор принимающий в себя высоту и основание, 
        /// для дальнейшего подсчёта площади треугольника по формуле Герона
        /// </summary>
        /// <param name="a">Сторона A</param>
        /// <param name="b">Сторона B</param>
        /// <param name="c">Сторона C</param>
        public Triangle(double a, double b, double c) => 
            (_A, _B, _C, _Cont) = (a, b, c, 2);

        /// <summary>
        /// Метод для вычисления площади трегольника по двум формулам в зависимости от 
        /// использования конструктора
        /// </summary>
        /// <returns></returns>
        public double Calculate()
        {
            if (_Cont == 1)
                return (1.0/2.0 * _X) * _H;
            else
            {
                RightAngled(_A, _B, _C);
                return Math.Sqrt(_P * (_P - _A) * (_P - _B) * (_P - _C));
            }
        }
        
        public void RightAngled(double a, double b, double c)
        {
            if ((Math.Pow(_A, 2) + Math.Pow(_B, 2) == Math.Pow(_C, 2)) ||
                (Math.Pow(_A, 2) + Math.Pow(_C, 2) == Math.Pow(_B, 2)) ||
                (Math.Pow(_B, 2) + Math.Pow(_C, 2) == Math.Pow(_A, 2)))
                Console.WriteLine("Треугольник прямоугольный");
            else
                Console.WriteLine("Треугольник не прямоугольный");
        }
    }
}