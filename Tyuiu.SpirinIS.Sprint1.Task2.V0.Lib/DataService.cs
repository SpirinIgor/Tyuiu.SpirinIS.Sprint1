using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.SpirinIS.Sprint1.Task2.V0.Lib
{
    public class DataService : ISprint1Task2V0
    {
        public int Sqr(int value)
        {
            return value * value;
        }
    }
}
