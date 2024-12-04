using Tyuiu.MokhamedAA.Sprint5.Task4.V30.Lib;
namespace Tyuiu.MokhamedAA.Sprint5.Task4.V30
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var ds = new DataService();
           
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Файл находится по пути C:\\DataSprint5\\InPutDataFileTask4V30.txt");

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine(ds.LoadFromDataFile(@"C:\DataSprint5\InPutDataFileTask4V30.txt"));

        }
    }
}