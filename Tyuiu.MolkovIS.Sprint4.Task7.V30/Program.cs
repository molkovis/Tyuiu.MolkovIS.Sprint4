

using Tyuiu.MolkovIS.Sprint4.Task7.V30.Lib;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("Введите кол-во строк");
        int row = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите кол-во столбцов");
        int col = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите число");
        string str = Console.ReadLine();
        DataService dataService = new DataService();
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");
        int res = dataService.Calculate(row, col, str);
        Console.WriteLine(res);
    }



}