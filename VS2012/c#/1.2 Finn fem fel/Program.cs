using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._2_Finn_fem_fel
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Finn fem fel";

            int hours = 35;
            double hourlywages = 173.27;

            double weeklyWages = hours * hourlywages;

            Console.WriteLine("Veckolönen är {0:c}.\n", weeklyWages);

        }
    }
}
