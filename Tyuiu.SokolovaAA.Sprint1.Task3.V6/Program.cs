using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tyuiu.SokolovaAA.Sprint1.Task3.V6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");


            Console.WriteLine("Расстояние до дачи (км)= ");
            double distance = Convert.ToDouble(Console.ReadLine()); 
            Console.WriteLine("Расход бензина на 100 км. пробега= ");
            double gasFlow = Convert.ToDouble(Console.ReadLine()); 


            Console.WriteLine("Цена литра бензина= ");
            double gasPrice = Convert.ToDouble(Console.ReadLine()); 
            double cenap;
            cenap = 2 * (((gasFlow / 100) * distance) * gasPrice);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");



            Console.WriteLine("Поездка на дачу туда и обратно обойдётся в " + Math.Round(cenap, 2), "руб");

            Console.ReadKey();
        }
    }
}
