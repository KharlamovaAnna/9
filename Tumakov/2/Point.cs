using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tumakov._2
{
    internal class Point : Figure
    { 
        public string figureType { get; } = "точка";
        //Родительский базовый конструктор
        public Point() : base() { }

        public Point(string color, bool visibility, int x, int y) : base(color, visibility, x, y) { }

        public override void PrintInfo()
        {
            Console.WriteLine($"Тип фигуры: {figureType}, Цвет: {color}, Видимость: {(visibility ? "видимая" : "невидимая")}, Координаты: X={X}, Y={Y}");
        }
    }
}
