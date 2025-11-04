using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.MolkovIS.Sprint4.Task7.V30.Lib
{
    public class DataService : ISprint4Task7V30
    {
        public int Calculate(int n, int m, string value)
        {
            int res = 1;
            for (int i = 0; i < value.Length; i++)
            {
                if (int.Parse(value[i].ToString()) % 2 == 0)
                {
                    res *= int.Parse(value[i].ToString());
                }
            }
            return res;
        }
    }
}
