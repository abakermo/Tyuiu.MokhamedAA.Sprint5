using Tyuiu.MokhamedAA.Sprint5.Task1.V20.Lib;
namespace Tyuiu.MokhamedAA.Sprint5.Task1.V20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            int startValue = -5;
            int stopValue = 5;
            DataService dataService = new DataService();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("startValue = " + startValue);
            Console.WriteLine("stopValue = " + stopValue);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            string res = dataService.SaveToFileTextData(startValue, stopValue);
            Console.WriteLine("Файл: " + res);
            Console.WriteLine("Создан!");
            double d = 3;
            Console.WriteLine(d);
            Console.ReadKey();
        }
    }
}
