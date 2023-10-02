using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.MalsagovUA.Sprint1.Task6.V4.Lib
{
    public class DataService : ISprint1Task6V4
    {
        public string CheckDoubleN(string value)
        {
            string str123 = Regex.Replace(value, "[!\"#$%&'()*+,-./:;<=>?@\\[\\]^_`{|}~]", string.Empty);
            string[] arr = str123.Split(' ');
            List<string> words = new List<string>();
            foreach (var letter in arr)
            {
                if (letter.Contains("нн"))
                {
                    words.Add(letter);
                }
            }
            return String.Join(", ", words);
        }
    }
}
