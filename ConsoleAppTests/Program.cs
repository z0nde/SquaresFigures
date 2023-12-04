﻿using SquaresFigures;

namespace ConsoleAppTests
{
    public class Program
    {
        public static void Main()
        {
            Menu menu = new();
            menu.Create(new ContentMenu(1, "Площадь треугольника по Герону", new Triangle(6, 8, 10)));
            menu.Create(new ContentMenu(2, "Площадь треугольника по высоте и основанию", new Triangle(5, 10)));
            menu.Create(new ContentMenu(3, "Площадь круга", new Circle(5)));
            menu.Create(new ContentMenu(4, "Площадь прямоугольника", new Rectangle(2, 4)));
            menu.Read();
            Console.Write("Введите цифру для действия: ");
            int i = Convert.ToInt32(Console.ReadLine());
            menu.CompleteItemMenu(i);
        }
    }
}