namespace SquaresFigures
{
    public class Circle : ICalculation
    {
        /// <summary>
        /// Радиус
        /// </summary>
        private readonly double _Radius;

        /// <summary>
        /// Конструктор принимающий в себя радиус круга
        /// </summary>
        /// <param name="radius"></param>
        public Circle(double radius) => _Radius = radius;

        /// <summary>
        /// Метод для вычисления площади круга
        /// </summary>
        /// <returns></returns>
        public double Calculate()
        {
            return Math.Pow(_Radius, 2) * Math.PI;
        }
    }
}