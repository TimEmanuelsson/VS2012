using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboration_2._2
{
    class Program
    {
        private string HorizontalLine;

        static void Main(string[] args)
        {
            ViewTestHeader("Test 1. \nTest av standardkonstruktorn.\n");
                AlarmClock test1 = new AlarmClock();
                Console.WriteLine(test1);

                    ViewTestHeader("\n═══════════════════════════════════════════════════════════════════════════════\n\nTest 2. \nTest av konstruktorn med två parametrar, <9, 42>.\n");
                AlarmClock test2 = new AlarmClock(9,42);
                Console.WriteLine(test2);

                    ViewTestHeader("\n═══════════════════════════════════════════════════════════════════════════════\n\nTest 3. \nTest av konstruktorn med fyra parametrar, <13, 24, 7, 35\n");
                AlarmClock test3 = new AlarmClock(13, 24, 7, 35);
                Console.WriteLine(test3);

                    ViewTestHeader("\n═══════════════════════════════════════════════════════════════════════════════\n\nTest 4. \nStäller befintligt AlarmClock-objekt till 23:58 och låter den gå 13 minuter.\n");
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("╔═══════════════════════════════╗");
            Console.WriteLine("║   Väckarklockan URLED <TM>    ║");         
            Console.WriteLine("║    Modellnr.: 1DV402S2L2A     ║");
            Console.WriteLine("╚═══════════════════════════════╝\n");
            Console.ResetColor();
                AlarmClock test4 = new AlarmClock(23, 58, 7, 35);
                Run(test4, 13);

                    ViewTestHeader("\n═══════════════════════════════════════════════════════════════════════════════\n\nTest 5. \nStäller befintligt AlarmClock-objekt till tiden 6:12 och alarmtiden till 6:15 \noch låter den gå 6 minuter.\n");
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("╔═══════════════════════════════╗");
            Console.WriteLine("║   Väckarklockan URLED <TM>    ║");
            Console.WriteLine("║    Modellnr.: 1DV402S2L2A     ║");
            Console.WriteLine("╚═══════════════════════════════╝\n");
            Console.ResetColor();
                AlarmClock test5 = new AlarmClock(6, 12, 6, 15);
                    Run(test5, 6);

                    ViewTestHeader("\n═══════════════════════════════════════════════════════════════════════════════\n\nTest 6. \nTestar egenskaperna så att undantag kastas då tid och alarmtid tilldelas \nfelaktiga värden\n");

            try
            {
                AlarmClock test61 = new AlarmClock();
                test61.Hour = 25;
            }
                catch
                {
                    ViewErrorMessege("Timmen är inte i intevallet 0-23.");
                }

            try
            {
                AlarmClock test61 = new AlarmClock();
                test61.Minute = 70;
            }
                catch
                {
                    ViewErrorMessege("Minuten är inte i intervallet 0-59");
                }

            try
            {
                AlarmClock test63 = new AlarmClock();
                test63.AlarmHour = 25;
            }
                catch
                {
                    ViewErrorMessege("Alarmtimmen är inte i intervallet 0-23");
                }

            try
            {
                AlarmClock test64 = new AlarmClock();
                test64.AlarmMinute = 70;
            }
                catch
                {
                    ViewErrorMessege("Alarmminuten är inte i intervallet 0-59");
                }

            ViewTestHeader("\n═══════════════════════════════════════════════════════════════════════════════\n\nTest 7. \nTestar konstruktorer så att undantag kastas då tid och alarmtid tilldelas \nfelaktiga värden.\n");

            try
            {
                AlarmClock test65 = new AlarmClock();
                test65.Hour = 25;
                test65.AlarmHour = 25;
            }
            catch
            {
                ViewErrorMessege("Timmen är inte i intevallet 0-23.");
                ViewErrorMessege("Alarmtimmen är inte i intervallet 0-23");
            }
        }

        private static void Run(AlarmClock ac, int minutes)
        {
            
            for (int i = 0; i < minutes; i++)
            {


                if (ac.TickTock())
                {
                    Console.BackgroundColor = ConsoleColor.Blue;
                    Console.WriteLine(" ♫  {0} BEEP! BEEP! BEEP! BEEP!", ac);
                    Console.ResetColor();
                }
                else
                {
                    Console.WriteLine("    {0}", ac);
                }
                
                
            }
        }

        private static void ViewErrorMessege(string message)
        {
            Console.BackgroundColor = ConsoleColor.Red;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(message);
            Console.ResetColor();
        }

        private static void ViewTestHeader(string header)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(header);
            Console.ResetColor();
            
        }

    }
}
