using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tumakov._2
{
    internal class Figure
    {
        public string color { get; set; }
        public bool visibility { get; set; }
        public int X { get; set; }
        public int Y { get; set; }

        public Figure()
        {
            color = "Красный";
            visibility = true;
            X = 0;
            Y = 0;
        }
        public Figure(string FigureType, string Color, bool isVisible, int x, int y)
        {
            color = Color;
            visibility = isVisible;
            X = x;
            Y = y;
        }
        
        //Изменение цвета
        public void ChangeColor(string newColor)
        {
            color = newColor;
            Console.WriteLine($"Цвет фигуры изменен на {newColor}");
        }

        //Изменение видимости
        public void ChangeVisibility(bool newVisibility)
        {
            visibility = newVisibility;
            Console.WriteLine($"Видимость фигуры изменена на {newVisibility}");
        }

        //Перемещение по горизонтали
        public void MoveHorizontal(int distance)
        {
            X += distance;
            Console.WriteLine($"Фигура перемещена по горизонтали на {distance}, новая координата X: {X}");
        }

        //Перемещение по вертикали
        public void MoveVertical(int distance)
        {
            Y += distance;
            Console.WriteLine($"Фигура перемещена по вертикали на {distance}, новая координата Y: {Y}");
        }

        //Состояние видимости
        public bool GetVisibility()
        {
            return visibility;
        }

        public virtual void PrintInfo()
        {
            Console.WriteLine($"Цвет фигуры: {color}, Видимость: {(visibility ? "видимая" : "невидимая")}, Координаты: X={X}, Y={Y}");
        }
    }
}
