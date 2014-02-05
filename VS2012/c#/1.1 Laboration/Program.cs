﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._1_Laboration
{
    class Program
    {   //Beskriver hur mycket variablen är exakt
        private const int femhundra = 500;
        private const int etthundra = 100;
        private const int femtio = 50;
        private const int tjugo = 20;
        private const int tio = 10;
        private const int fem = 5;
        private const int ett = 1;

        static void Main(string[] args)
        {
            double totalsumma = 0;
            int belopp = 0;
            int tillbaka = 0;
            double avrundningsbelopp = 0;
            uint total = 0;
            int femhundralapp = 0;
            int etthundralapp = 0;
            int femtiolapp = 0;
            int tjugolapp = 0;
            int tiokr = 0;
            int femkr = 0;
            int ettkr = 0;

            
            //Läser in totala summan + fel meddelanden.
            while (true)
            {
                try
                {
                    Console.Write("Ange totalsumma     : ");
                    totalsumma = double.Parse(Console.ReadLine());
                    if (totalsumma < 1)
                    {
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.WriteLine("Totalsumman är för liten. Köpet kunde inte genomföras!");
                        Console.ResetColor();
                        return;
                       
                    }
                    break;
                }

                catch
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.WriteLine("Felaktig inmatning! Var vänlig och försök idag.");
                    Console.ResetColor();
                }
            }

            //Läser in belopp + fel meddelanden
            while (true)
            {
                try
                {
                    Console.Write("Ange erhållet belopp: ");
                    belopp = int.Parse(Console.ReadLine());

                    break;
                }
                catch
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.WriteLine("Felaktig inmatning!");
                    Console.ResetColor();
                    return;
                }
            }
            //Om man totalsumman är mindre än beloppet fel
            if (totalsumma > belopp)
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.WriteLine("Erhållet belopp är för litet! Köpet kunde inte genomföras!");
                Console.ResetColor();
                return;
            }
            

            //Kvitto
            Console.WriteLine();
            Console.WriteLine("KVITTO");
            Console.WriteLine("------------------------------");
            
            //Den totala summan skrivs ut
            Console.WriteLine("Totalt         =     {0:c}",totalsumma);
            
            //Avrundningen
            total = (uint)Math.Round(totalsumma);
            avrundningsbelopp = total - totalsumma;
            Console.WriteLine("Öresavrundning =      {0:C}", avrundningsbelopp);

            //Att betala
            Console.WriteLine("Att betala     =        {0:c0}", total);
            
            //Beloppet
            Console.WriteLine("Kontant        =      {0:c0}",belopp);
            
            //Tillbaka
            tillbaka = belopp - (int)total;
            Console.WriteLine("Tillbaka       =        {0:c0}",tillbaka);

            Console.WriteLine("------------------------------");
            Console.WriteLine();

            //Räknar ut hur många valörer man få tillbaka
            femhundralapp = tillbaka / femhundra;
            tillbaka = tillbaka % femhundra;
            etthundralapp = tillbaka / etthundra;
            tillbaka = tillbaka % etthundra;
            femtiolapp = tillbaka / femtio;
            tillbaka = tillbaka % femtio;
            tjugolapp = tillbaka / tjugo;
            tillbaka = tillbaka % tjugo;
            tiokr = tillbaka / tio;
            tillbaka = tillbaka % tio;
            femkr = tillbaka / fem;
            tillbaka = tillbaka % fem;
            ettkr = tillbaka / ett;
            tillbaka = tillbaka % ett;


            //Skriver ut hur mycket av varje valör du från tillbaka
            if (femhundralapp >= 1)
            {
                Console.WriteLine(" 500-lappar: = {0:f0}", femhundralapp);
            }

            if (etthundralapp >= 1)
            {
                Console.WriteLine(" 100-lappar: = {0:f0}", etthundralapp);
            }

            if (femtiolapp >= 1)
            {
                Console.WriteLine("  50-lappar: = {0:f0}", femtiolapp);
            }

            if (tjugolapp >= 1)
            {
                Console.WriteLine("  20-kronor: = {0:f0}", tjugolapp);
            }

            if (tiokr >= 1)
            {
                Console.WriteLine("  10-kronor: = {0:f0}", tiokr);
            }

            if (femkr >= 1)
            {
                Console.WriteLine("   5-kronor: = {0:f0}", femkr);
            }

            if (ettkr >= 1)
            {
                Console.WriteLine("   1-kronor: = {0:f0}", ettkr);
            }
           
        }
    }
}
