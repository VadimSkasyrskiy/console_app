using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Лабораторная работа №1. Разработка консольного приложения");
            Console.WriteLine("");
            Console.WriteLine("Выполнил Скасырский Вадим Александрович");
            Console.WriteLine("Группа: ИНС-192, Специальность: 09.03.02");
            Console.WriteLine("Дата рождения: 16.01.2002");
            Console.WriteLine("Постоянное место жительства: п. Темнореченский.");
            Console.WriteLine("Любимый предмет в школе: физическая культура");
            Console.WriteLine("Увлекаюсь футболом и программированием.");
            Console.WriteLine("");
            Console.WriteLine("Индивидуальное задание.");
            Console.WriteLine("Вариант 5.");


            double g = 2.5;
            float h = 12;
            int d = 4;
            int b = 8;
            int x = 9;
            int y = 5;

            double H = ((g * h) / (d * 17)) + ((b) / (h * 1)) - ((x + y) / (4));

            Console.WriteLine("Значение переменных: g = {0}; h = {1}; d = {2}; b = {3}; x = {4}; y = {5}.", g, h, d, b, x, y);

            Console.WriteLine("Результат: {0}.", H);

            Console.WriteLine("для завершения работы программы нажмите любую кнопку");

            Console.ReadKey();
        }
    }
}
