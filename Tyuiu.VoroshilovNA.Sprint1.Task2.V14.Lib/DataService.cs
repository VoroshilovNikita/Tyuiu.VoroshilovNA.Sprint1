using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.VoroshilovNA.Sprint1.Task2.V14.Lib
{
    public class DataService : ISprint1Task2V14
    {
        public int ConvertKelvinToCelsius(int value)
        {
            return (int)(value - 273);
        }
    }
}
