using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Важно! Следует к библиотеке классов подключить файл tyuiu.cources.programming.interfaces.dll
using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.SpirinIS.Sprint1.Task0.V0.Lib
{
    public class DataService : ISprint1Task0V0
    {
        public double Calculate()
        {
            return 10 / (2 + 3);
        }
    }
}
