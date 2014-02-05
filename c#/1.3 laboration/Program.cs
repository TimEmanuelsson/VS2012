using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._3_laboration
{
    class Program
    {
        static void Main(string[] args)
        {
            int resultat;

                do
                {   
                    Console.Clear();

                    resultat = ReadInt("Ange antal löner att mata in: ");
                    Console.WriteLine();

                    if (resultat < 2)
                    {
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.WriteLine("Du måste mata in minst två löner för att kunna göra en beräkning!");
                        Console.ResetColor();
                    }
                    else
                    {
                        ProcessSalaries(resultat);
                    }

                    Console.ForegroundColor = ConsoleColor.White;
                    Console.BackgroundColor = ConsoleColor.DarkGreen;
                    Console.WriteLine("\nTryck tagent för ny beräkning - Esc avslutar.");
                    Console.ResetColor();

                } while (Console.ReadKey(true).Key != ConsoleKey.Escape);
            }
          private static int ReadInt(string prompt)
         {

             string antal = "";
             
             
              
              
              while (true)
             {
                 try
                 {

                     Console.Write(prompt);
                     antal = Console.ReadLine();
                     return int.Parse(antal);
                 }
                 catch
                 {
                     Console.BackgroundColor = ConsoleColor.Red;
                     Console.WriteLine("FEL! '{0}' Kan inte tolkas som ett heltal.",antal);
                     Console.ResetColor();
                 }
             }
        
         }
          private static void ProcessSalaries(int count)
          {
              int medianlön;
              
              

              int[] sorteradelöner = new int[count];
              int[] löner = new int[count];
              for (int i = 0; i < löner.Length; i++)
              {
                  löner[i] = ReadInt(string.Format("Ange lön nummer {0}: ",i+1));
                  sorteradelöner[i] = löner[i]; 
              }

              double medel = löner.Average();

              Array.Sort(sorteradelöner);

              medianlön = sorteradelöner.Count() / 2;

              int mitten;

              if (count % 2 == 0)
              {
                  mitten = (sorteradelöner[medianlön - 1] + sorteradelöner[medianlön]) / 2;

              }
              else
              {
                  mitten = sorteradelöner[medianlön];
              }

              int skillnad = sorteradelöner.Max() - sorteradelöner.Min();

             
              Console.WriteLine();
              Console.WriteLine("------------------------------");
              Console.WriteLine("Medianlön:           {0:c0}", mitten);
              Console.WriteLine("Medellön:            {0:c0}", medel);
              Console.WriteLine("Lönspridning:        {0:c0}", skillnad);
              Console.WriteLine("------------------------------");

              for (int i = 0; i < count; i++)
              {
                  Console.Write(" {0,5} ", löner[i]);
                  if( i % 3 == 2)
                  {
                      Console.WriteLine();
                  }
                  
              }
              Console.WriteLine();
          }
      }

}
