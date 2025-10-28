using Tyuiu.MolkovIS.Sprint4.Task5.V22.Lib;

internal class Program
{
    private static void Main(string[] args)
    {
        DataService dataService = new DataService();
        Random rand = new Random();
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("Введите кол-во строк");
        int row = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите кол-во столбцов");
        int col = Convert.ToInt32(Console.ReadLine());

        int[,] data = new int[row, col]; 

        for (int i = 0; i < row; i++)
        {
            for (int j = 0; j < col; j++)
            {
                data[i, j] = rand.Next(-8,9);
            }
        }
        Console.WriteLine("***************************************************************************");
        for (int i = 0; i < row; i++)
        {
            for (int j = 0; j < col; j++)
            {
                Console.Write($"{data[i, j]}\t");
            }
        }
        Console.WriteLine();
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine(dataService.Calculate(data));
        Console.ReadKey();
        Console.ReadKey();
    }
}