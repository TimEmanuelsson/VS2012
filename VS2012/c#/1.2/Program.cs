using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Gör så att det finns 25 rader
            for (int row = 0; row < 25; row++)
            {
                //switchar var 3 rad
                switch (row % 3)
                { 
                    case 0:
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        break;
                    case 1:
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        break;
                    case 2:
                        Console.ForegroundColor = ConsoleColor.Green;
                        break;
                }
                //Kollar om row är en udda siffra
                if (row % 2 == 1)
                {
                    Console.Write(" ");
                }
                // Gör så att det finns 39 kolummer
                for (int col = 0; col < 39; col++)
                {
                    Console.Write("* ");
                }
               
                Console.WriteLine();            
            }
        }
    }
}
