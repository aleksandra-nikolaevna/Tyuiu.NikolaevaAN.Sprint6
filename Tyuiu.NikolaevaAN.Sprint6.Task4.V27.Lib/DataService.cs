using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.NikolaevaAN.Sprint6.Task4.V27.Lib
{
    public class DataService : ISprint6Task4V27
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            int len = stopValue - startValue + 1;
            double[] valueArray = new double[len];
            double y;
            int count = 0;
            for (int x = startValue; x <= stopValue; x++)
            {
                if (x + 1 == 0)
                {
                    y = (-1) * Math.Cos(x) * 1.3 + (3 * x);
                }
                else
                {
                    y = (Math.Cos(x) / (x + 1)) - (Math.Cos(x) * 1.3) + (3 * x);
                }
                valueArray[count] = Math.Round(y, 2);
                count++;
            }
            return valueArray;
        }
    }
}
