using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.SpirinIS.Sprint1.Task7.V0.Lib
{
    public class DataService : ISprint1Task7V0
    {
        public double Calculate(double x, double y, double z)
        {
            double res = (y - x) * ((y - z / y - x) / (1 + Math.Pow((y - x), 2)));
            return res;
        }
    }
}
