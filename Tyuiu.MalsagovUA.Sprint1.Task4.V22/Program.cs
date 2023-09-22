using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.MalsagovUA.Sprint1.Task4.V22.Lib;
namespace Tyuiu.MalsagovUA.Sprint1.Task4.V22
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #1 | Выполнил: Мальсагов У.А. | АСОиУб-23-2";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("* Тема: Базовые навыки работы в C#                                        *");
            Console.WriteLine("* Задание #4                                                              *");
            Console.WriteLine("* Вариант #22                                                             *");
            Console.WriteLine("* Выполнил: Мальсагов Умар Асланович | АСОиУб-23-2                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая запрашивает у пользователя исходные данные, *");
            Console.WriteLine("* вычисляет результат по формуле и печатает его на экране.                *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Введите значение переменной X:");
            double x = Convert.ToDouble(Console.ReadLine()); 
            Console.WriteLine("Введите значение переменной Y:");
            double y = Convert.ToDouble(Console.ReadLine());
            var res = (Math.Sqrt(x * y)) / (1 + (x + 2 * y) * (x + 2 * y));
            Console.WriteLine($"Результат вашего выражения: {res}");
            Console.ReadKey();
        }
    }
}
