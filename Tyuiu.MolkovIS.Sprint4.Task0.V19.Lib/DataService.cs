﻿using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.MolkovIS.Sprint4.Task0.V19.Lib
{
    public class DataService : ISprint4Task0V19
    {
        public int GetMultOddArrEl(int[] array)
        {
            int proiz = 1;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 != 0)
                {
                    proiz = proiz * array[i];
                }
            }
            return proiz;
        }
    }
}
