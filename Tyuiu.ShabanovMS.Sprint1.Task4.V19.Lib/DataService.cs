using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.ShabanovMS.Sprint1.Task4.V19.Lib
{
    public class DataService : ISprint1Task4V19
    {
        public double Calculate(double x, double y)
        {
            double value;
            value = (x + y) / Math.Abs(x - 2);
            double res;
            res =  Math.Round(value, 3);
            return res;
        }
    }
}
