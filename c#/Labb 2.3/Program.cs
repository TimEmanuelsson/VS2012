using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb_2._3
{
    class Program
    {

        static void Main(string[] args)
        {
           Shape shape = null;

            do
            {
                // Menyvalen 
                switch (ViewMenu())
                {

                    case 0:
                        return;

                    case 1:
                        shape = CreateShape(ShapeType.Ellipse);
                        break;

                    case 2:
                        shape = CreateShape(ShapeType.Rectangle);
                        break;
                }

                ViewShapeDetail(shape);

                Console.BackgroundColor = ConsoleColor.DarkBlue;
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("\nTryck på valfri tangent för att fortsätta eller Escape för att avsluta.");
                Console.ResetColor();

            }
            while (Console.ReadKey(true).Key != ConsoleKey.Escape);



        }

        private static Shape CreateShape(ShapeType shapeType)
        {

            // Här hämtar vi från klassen Shape för att få vet om det är en ellips eller rektangel.
            // Det du väljer kommer upp i en ny meny.

            Shape shape;

            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("\n==========================================");
            if (shapeType == ShapeType.Ellipse)
            {
                Console.WriteLine("=          Ellips                        =");
            }
            if (shapeType == ShapeType.Rectangle)
            {
                Console.WriteLine("=          Rektangel                     =");
            }

            Console.WriteLine("==========================================\n");
            Console.ResetColor();



            double width = ReadDoubleGreaterThanZero("Ange bredd: ");
            double length = ReadDoubleGreaterThanZero("Ange längd: ");

            // Kolla om det är en Ellipse eller Rectangel

            if (shapeType == ShapeType.Ellipse)
            {
                shape = new Ellipse(length, width);
            }

            else
            {
                shape = new Rectangle(length, width);
            }

            return shape;
        }

        private static double ReadDoubleGreaterThanZero(string prompt)
        {

            // Kolla om talet är mindre än 0. Om mindre än 0 visa felmeddelande.

            double checkZero = 0;
            while (true)
            {
                try
                {

                    while (checkZero <= 0)
                    {

                        Console.Write(prompt);
                        checkZero = double.Parse(Console.ReadLine());

                        if (checkZero <= 0)
                        {
                            Console.BackgroundColor = ConsoleColor.Red;
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine("FEL! Skriv in ett tal större än 0.");
                            Console.ResetColor();
                        }

                    }
                    return checkZero;
                }

                catch
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("FEL! Skriv in en siffra.");
                    Console.ResetColor();
                }
            }

        }



        private static int ViewMenu()
        {
            while (true)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.White;
                Console.BackgroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("=========================================");
                Console.WriteLine("=                                       =");
                Console.WriteLine("=          Geometriska figurer          =");
                Console.WriteLine("=                                       =");
                Console.WriteLine("=========================================\n");
                Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("\n0. Avsluta. ");
                Console.WriteLine("\n1. Ellips. ");
                Console.WriteLine("\n2. Rektangel. ");

                // Felmedelande i menyval. 

                Console.Write("\nAnge menyval 0-2: ");
                Console.ResetColor();

                int menuChoice;
                if (int.TryParse(Console.ReadLine(), out menuChoice) && menuChoice >= 0 && menuChoice <= 2)
                {
                    return menuChoice;
                }

                Console.BackgroundColor = ConsoleColor.Red;
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("FEL! Skriv in ett tal mellan 0-2");
                Console.ResetColor();
                Console.ReadKey();
            }

        }

        private static void ViewShapeDetail(Shape shape)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("\n==========================================");
            Console.WriteLine("=          Detaljer                      =");
            Console.WriteLine("==========================================\n");
            Console.ResetColor();
            Console.WriteLine(shape);
        }
    }
}