using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.SpirinIS.Sprint1.Task7.V0.Lib;

//Написать программу, которая вычисляет математическое выражение 
//по исходным значениям данных, вводимых пользователем.
//               y - z
//              -------
//              (y - x)
//f = (y - x)------------
//                      2
//           1 + (y - x)

namespace Tyuiu.SpirinIS.Sprint1.Task7.V0
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("                y - z");
            Console.WriteLine("               -------");
            Console.WriteLine("               (y - x)");
            Console.WriteLine("f = (y - x)----------------");
            Console.WriteLine("                      2");
            Console.WriteLine("           1 + (y - x)");

            double x, y, z;

            Console.WriteLine("Введите значение X:");
            x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите значение Y:");
            y = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите значение Z:");
            z = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine(ds.Calculate(x, y, z));
            Console.ReadKey();

            // https://github.com/SpirinIgor/Tyuiu.SpirinIS.Sprint1.git

        }
    }
}
