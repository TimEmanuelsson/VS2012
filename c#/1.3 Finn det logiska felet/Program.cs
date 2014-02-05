using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._3_Finn_det_logiska_felet
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Finn det logiska felet";

            const int Rate = 25;

            double cost = 0d;
            double tax = 0d;
            double totalCost = 0d;

            Console.Write("ange varans pris exkl. moms: ");
            cost = double.Parse(Console.ReadLine());

            tax = Rate /100d * cost;

            totalCost = cost + tax;

            Console.WriteLine("varans pris inkl. moms är {0:c}.", totalCost);

   

        }
    }
}
