﻿using Tyuiu.OsadetsAA.Sprint4.Task2.V26.Lib;
namespace Tyuiu.OsadetsAA.Sprint4.Task2.V26
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = ("Спринт #4 | Выполнил: Осадец А. А. | ПКТб-24-1");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Одномерные массивы (генератор случайных чисел)                    *");
            Console.WriteLine("* Задание #2                                                              *");
            Console.WriteLine("* Вариант #26                                                             *");
            Console.WriteLine("* Выполнил: Осадец Александр Александрович | ПКТб-24-1                    *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан одномерный целочисленный массив на 14 элементов заполненный         *");
            Console.WriteLine("* случайными в диапазоне от 1 до 8 подсчитать произведение нечетных       *");
            Console.WriteLine("* элементов массива.                                                      *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Random rnd = new Random();
            int len = 14;
            int[] numsArray = new int[len];
            for (int i = 0; i < len - 1; i++) { numsArray[i] = rnd.Next(1, 8); }
            int res = ds.Calculate(numsArray);

            Console.WriteLine("Массив: ");
            for (int i = 0; i < len - 1; i++) { Console.Write(numsArray[i] + "\t"); }

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine(res);
        }
    }
}
