using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.MalsagovUA.Sprint1.Task1.V1.Lib
{
    public class DataService : ISprint1Task1V1
    {
        public double Calculate(double a, double x, double y)
        {
            return x / 3 / y + 6 * a;
        }
    }
}
