using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.SokolovaAA.Sprint1.Task2.V12.Lib;
namespace Tyuiu.SokolovaAA.Sprint1.Task2.V12
{
    class Program
    {
        static void Main(string[] args)
        {

            DataService ds = new DataService();

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int a;

            Console.WriteLine("Введите значение a:");
            a = Convert.ToInt32(Console.ReadLine());

            int b;

            Console.WriteLine("Введите значение b:");
            b = Convert.ToInt32(Console.ReadLine());

            int c;

            Console.WriteLine("Введите значение c:");
            c = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine(" Объем = " + ds.CalculateParallelepipedVolume(a,b,c));

            Console.ReadKey();
        }
    }
}
