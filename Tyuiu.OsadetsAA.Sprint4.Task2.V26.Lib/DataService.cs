﻿using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.OsadetsAA.Sprint4.Task2.V26.Lib
{
    public class DataService : ISprint4Task2V26
    {
        public int Calculate(int[] array)
        {
            int s = 0;
            for (int i = 0; i <= array.Length - 1; i++) { if (array[i] % 2 != 0) { s += array[i]; } } return s;
        }
    }
}
