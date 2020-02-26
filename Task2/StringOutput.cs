using System;

namespace Task2
{
    static class StringOutput
    {
        enum ColorType 
        {
            Red = 1,
            Blue = 2,
            Yellow = 3,
            Green = 4
        }

        public static void Print(this string stroka, int color)
        {
            switch (color)
            {
                case (int)ColorType.Red:
                    Console.ForegroundColor = ConsoleColor.Red;
                    break;
                case (int)ColorType.Blue:
                    Console.ForegroundColor = ConsoleColor.Blue;
                    break;
                case (int)ColorType.Yellow:
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    break;
                case (int)ColorType.Green:
                    Console.ForegroundColor = ConsoleColor.Green;
                    break;
                default:
                    Console.WriteLine($"\nЦвета под цифрой {color} нет в нашей базе!");
                    break;
            }

            Console.WriteLine("\nВ цвете:");
            Console.WriteLine(stroka);
            Console.ResetColor();
        }
    }
}
