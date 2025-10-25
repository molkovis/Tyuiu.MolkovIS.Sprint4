﻿using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.MolkovIS.Sprint4.Task3.V19.Lib
{
    public class DataService : ISprint4Task3V19
    {
        public int Calculate(int[,] array)
        {
            int result = 0;
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (array[i,j] % 2 == 0)
                    {
                        result++;
                    }
                }
            }
            return result;
        }
    }
}
