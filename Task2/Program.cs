/*Используя Visual Studio, создайте проект по шаблону Console Application. 
Создайте статический класс с методом void Print (string stroka, int color), который выводит на экран строку заданным цветом.  Используя перечисление, создайте набор цветов, доступных пользователю. Ввод строки и выбор цвета предоставьте пользователю. 
*/
using System;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputLine;
            int colorValue = 0;

            Console.WriteLine("Строка: ");
            inputLine = Console.ReadLine();

            Console.WriteLine("\nЦвет (1 - красный, 2 - голубой, 3 - желтый, 4 - зеленый:)");
            colorValue = Int32.Parse(Console.ReadLine());

            inputLine.Print(colorValue);

            Console.ReadKey();
        }
    }
}
