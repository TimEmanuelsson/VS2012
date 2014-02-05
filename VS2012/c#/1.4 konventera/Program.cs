using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._4_konventera
{
    class Program
    {
        static void Main(string[] args)
        {
            double celsius = 0;
            double fahrenheit = 0;

            Console.Write("Ange temperatur i grader Fahrenheit: ");
            fahrenheit = double.Parse(Console.ReadLine());

            celsius = (fahrenheit - 32) * 5 / 9;

            Console.Write("Temperaturen {0} F motsvara {1:f1} C", fahrenheit, celsius);

        }
    }
}
