using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.VoroshilovNA.Sprint1.Task5.V7.Lib
{
    public class DataService : ISprint1Task5V7
    {
        public int AngleToHoursMinutes(double f)
        {
            int x = (int)(f / 360);
            double angle = f - x * 360;
            int hours = (int)(angle / 30);

            return x * 12 + hours;
        }
    }
}
