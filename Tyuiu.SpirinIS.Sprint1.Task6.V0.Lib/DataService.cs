using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.SpirinIS.Sprint1.Task6.V0.Lib
{
    public class DataService : ISprint1Task6V0
    {
        public string WorkWithText(string value)
        {
            value = value.Replace(" ", "");
            value = value.Replace("*", "");
            return value;
        }
    }
}
