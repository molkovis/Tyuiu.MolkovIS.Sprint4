using Tyuiu.MolkovIS.Sprint4.Task4.V5.Lib;

internal class Program
{
    private static void Main(string[] args)
    {
        DataService dataService = new DataService();
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");
        int[,] array = new int[5, 5];
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                array[i, j] = Convert.ToInt32(Console.ReadLine());
            }
        }


        int result = dataService.Calculate(array);
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine(result);
        Console.ReadKey();
    }
}