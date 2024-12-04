using Tyuiu.MokhamedAA.Sprint5.Task7.V8.Lib;
namespace Tyuiu.MokhamedAA.Sprint5.Task7.V8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

           
           
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            string path = $@"C:\Users\User\Desktop\DataSprint5\InPutDataFileTask7V8.txt";

            Console.WriteLine($"Данные находятся в файле: {path}");

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            string PathSaveFile = ds.LoadDataAndSave(path);
            Console.WriteLine($"Данные находятся в файле");
            Console.WriteLine(PathSaveFile);
        }
    }
}
