using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "Давно пора нам поехать по заданному министром маршруту, огибая странные горы";

            string[] words = text.Split(new[] { ' ', ',', '.', ';', ':', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);

            foreach (string word in words)
            {
                if (word.Contains("нн"))
                {
                    Console.WriteLine(word);
                }
            }

            Console.ReadLine();
        }
    }
}
