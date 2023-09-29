using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.MalsagovUA.Sprint1.Task5.V1.Lib;
namespace Tyuiu.MalsagovUA.Sprint1.Task5.V1
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
            Console.WriteLine("* Задание #5                                                              *");
            Console.WriteLine("* Вариант #1                                                              *");
            Console.WriteLine("* Выполнил: Мальсагов Умар Асланович | АСОиУБ-23-2                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая находит расстояние медлу двумя точками c    *");
            Console.WriteLine("* заданными координатами (x, y).Ответ привести к целому с помощью класса  *");
            Console.WriteLine("* Convert.                                                                *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*ИСХОДНЫЕ ДАННЫЕ:                                                         *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Введите координату X1:");
            double x1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите координату Y1:");
            double y1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите координату X2:");
            double x2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите координату Y2:");
            double y2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            int res = Convert.ToInt32(ds.DistanceBetweenDots(x1, y1, x2, y2));
            Console.WriteLine("Расстояние между двумя точками с заданными координатами = " + res);

            Console.ReadKey();
        }
    }
}
