using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tumakov._2
{
    internal class Circle : Point
    {
        public double r { get; set; } // Радиус окружности

        public Circle() : base()
        {
            r = 1;
        }


        public Circle(string color, bool isVisible, int x, int y, double radius) : base(color, isVisible, x, y)
        {
            r = radius;
        }

        public double Area()
        {
            return Math.PI * r * r;
        }

        // Переопределение метода PrintInfo
        public override void PrintInfo()
        {
            Console.WriteLine($"Тип фигуры: окружность, Цвет: {color}, Видимость: {(visibility ? "видимая" : "невидимая")}, Позиция: X={X}, Y={Y}, Радиус: {r}, Площадь: {Area():F2}");

        }
    }
}
