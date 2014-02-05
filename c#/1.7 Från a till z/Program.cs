using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._7_Från_a_till_z
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Från a till z och tillbaka";

            for (char ch = 'A'; ch <= 'Z'; ch++)
            {
                Console.Write("{1}{0} ", (char)(ch + 32), ch);
            }

            Console.WriteLine();

            for (char ch = 'Z'; ch >= 'A'; ch--)
            {
                Console.Write("{1}{0} ", (char)(ch + 33), ch);
            }

            Console.WriteLine();

           
               
            
 
        }
    }
}
