using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.ShabanovMS.Sprint1.Task7.V11.Lib
{
    //Math.Log - логарифм
    //Math.Sin - синус
    //Math.Pow - степень 
    //Math.Abs - модуль
    //Math.Sqrt - квадратный корень
    //Math.Pow(Math.Log(Math.Sin(x)), x); - числитель
    public class DataService : ISprint1Task7V11
    {
        public double Calculate(double x, double y)
        {
            double z = Math.Round(Math.Pow(Math.Log(Math.Sin(x)), x) / Math.Log(1 + Math.Pow(x, 2)) + (y - Math.Sqrt(Math.Abs(x))),3);
            return z;
        }
    }
}
