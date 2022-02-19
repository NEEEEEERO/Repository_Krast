using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.IO;

namespace LAB_2_ISIT_ONDER
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"\b[\w\.\-]+@[\w]+\.[a-z]+\b";
            string lab;
            string line = @"C:\Users\Krast\Desktop\reg_vir\task1.txt";
            StreamReader sr = new StreamReader(line);
            Regex regex = new Regex(pattern); //шаблон(маска/паттерн)
            string text = sr.ReadToEnd();
            MatchCollection match = regex.Matches(text);  //ищет все вхождения - "Matches"
            lab = match.Count.ToString();
            Console.WriteLine(lab);
        }
    }
}
