using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.MalsagovUA.Sprint1.Task7.V17.Lib;
namespace Tyuiu.MalsagovUA.Sprint1.Task7.V17
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #1 | Выполнил: Мальсагов Умар Асланович | АСОиУБ-23-2";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("* Тема: Преобразование типов и класс Convert                              *");
            Console.WriteLine("* Задание #7                                                              *");
            Console.WriteLine("* Вариант #17                                                             *");
            Console.WriteLine("* Выполнил: Мальсагов Умар Асланович | АСОиУБ-23-2                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая вычисляет математическое выражение          *");
            Console.WriteLine("* по исходным значениям данных, вводимых пользователем.                   *");
            Console.WriteLine("* Ответ округлите до 3 знаков после запятой.                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*ИСХОДНЫЕ ДАННЫЕ:                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*     1 + sin√x^2+1                                                       *");
            Console.WriteLine("* z = -------------                                                       *");
            Console.WriteLine("*      cos(12y - 4)                                                       *");
            Console.WriteLine("Введите значение 'X':");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите значение 'Y':");
            double y = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"Значение 'Z', округленное до 3-х знаков после запятой: {ds.Calculate(x, y)}");
            Console.ReadKey();
        }
    }
}
