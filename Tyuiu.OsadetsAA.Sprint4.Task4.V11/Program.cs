using Tyuiu.OsadetsAA.Sprint4.Task4.V11.Lib;
namespace Tyuiu.OsadetsAA.Sprint4.Task4.V11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = ("Спринт #4 | Выполнил: Осадец А. А. | ПКТб-24-1");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Двумерные массивы (ввод с клавиатуры)                             *");
            Console.WriteLine("* Задание #4                                                              *");
            Console.WriteLine("* Вариант #11                                                             *");
            Console.WriteLine("* Выполнил: Осадец Александр Александрович | ПКТб-24-1                    *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан двумерный целочисленный массив 5 на 5 элементов, заполненный        *");
            Console.WriteLine("* значениями с клавиатуры в диапазоне от 5 до 8. Найдите сумму нечетных   *");
            Console.WriteLine("* элементов массива.                                                      *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Введите количество строк: ");
            int rows = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите количество столбцов: ");
            int columns = Convert.ToInt32(Console.ReadLine());

            int[,] array = new int[rows, columns];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write($"Введите {i},{j} элемент массива: ");
                    array[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            Console.WriteLine("\nМассив:");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write($"{array[i, j]} \t");
                }
                Console.WriteLine();
            }

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            int res = ds.Calculate(array);
            Console.WriteLine(res);
        }
    }
}
