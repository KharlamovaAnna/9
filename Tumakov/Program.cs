using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tumakov._1;
using Tumakov._2;

namespace Tumakov
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Task1();
            Task2();
        }
        public static void Task1()
        {
            /*Создать интерфейс ICipher, который определяет методы поддержки
            шифрования строк. В интерфейсе объявляются два метода encode() и decode(), которые
            используются для шифрования и дешифрования строк, соответственно. Создать класс
            ACipher, реализующий интерфейс ICipher. Класс шифрует строку посредством сдвига
            каждого символа на одну «алфавитную» позицию выше. Например, в результате такого
            сдвига буква А становится буквой Б. Создать класс BCipher, реализующий интерфейс
            ICipher. Класс шифрует строку, выполняя замену каждой буквы, стоящей в алфавите на i-й
            позиции, на букву того же регистра, расположенную в алфавите на i-й позиции с конца
            алфавита.*/
            Console.WriteLine($"Упражнение 10.1");

            ACipher cipher = new ACipher();

            string testText = "a b c d e F g h i j k l M n o p q r s t u V w x y z 123";
            string encodedText = cipher.encode(testText);
            string decodedText = cipher.decode(encodedText);

            Console.WriteLine($"Исходный текст: {testText}");
            Console.WriteLine($"Зашифрованный текст: {encodedText}");
            Console.WriteLine($"Расшифрованный текст: {decodedText}");

            string testText2 = "а б в г д е ё ж З и й к л м н о п р С т у ф х ц ч ш щ ъ ы ь э ю я 123";
            string encodedText2 = cipher.encode(testText2);
            string decodedText2 = cipher.decode(encodedText2);

            Console.WriteLine($"\nИсходный текст: {testText2}");
            Console.WriteLine($"Зашифрованный текст: {encodedText2}");
            Console.WriteLine($"Расшифрованный текст: {decodedText2}");
            //я не понимаю, почему он обрабатывает букву ё в decode неправильно(((

            BCipher cipher2 = new BCipher();

            string encodedText3 = cipher2.encode(testText);
            string decodedText3 = cipher2.decode(encodedText3);

            Console.WriteLine($"\nИсходный текст: {testText}");
            Console.WriteLine($"Зашифрованный текст: {encodedText3}");
            Console.WriteLine($"Расшифрованный текст: {decodedText3}");

            Console.ReadLine();
        }
        public static void Task2()
        {
            /*Создать класс Figure для работы с геометрическими фигурами. В
            качестве полей класса задаются цвет фигуры, состояние «видимое/невидимое». Реализовать
            операции: передвижение геометрической фигуры по горизонтали, по вертикали, изменение
            цвета, опрос состояния (видимый/невидимый).*/
            Console.WriteLine($"Домашнее задание 10.1");

            Figure figure1 = new Figure();
            figure1.PrintInfo();

            Figure figure2 = new Figure("Зеленый", false, 5, 10);
            figure2.PrintInfo();

            figure1.MoveHorizontal(5);
            figure1.ChangeColor("Голубенький");
            figure2.ChangeVisibility(true);
            figure1.PrintInfo();
            figure2.PrintInfo();

            Console.WriteLine();
            Point point1 = new Point();
            point1.PrintInfo();

            Point point2 = new Point("Фиолетовый", true, 3, 7);
            point2.PrintInfo();

            Console.ReadLine();
        }
    }
}
