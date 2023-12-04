using SquaresFigures;

namespace ConsoleAppTests
{
    public class Rectangle : ICalculation
    {
        private readonly double _A;
        private readonly double _B;

        public Rectangle(double a, double b) => (_A, _B) = (a, b);

        public double Calculate()
        {
            return _A * _B;
        }
    }
}