using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1DV402.S2.L1A
{
    public class SecretNumber
    {
        //Räknar antal gissningar
        private int _count;
        
        //Innehåller det hemliga talet
        private int _number;
        
        //Hur många gissningar användaren har gjort
        public const int MaxNumberOfGuesses = 7;

        //skapar ett objekt
        Random random = new Random();

        public void Initialize()
        {      
             //Slumpar ett tal mellan 1 och 100
             _number = random.Next(1,101);
             _count = 0;
        }

        public bool MakeGuess(int number)
        {
            if(_count < MaxNumberOfGuesses)
            {
                _count++;
            }
            

            else
            {
                string tomanyguesses = string.Format("Du har tyvärr inga fler gissningar kvar! Det rätta talet var {0}", _number);
                throw new ApplicationException(tomanyguesses);
            }

            int guessleft = (MaxNumberOfGuesses - _count);

            if (number < 1 || number > 100)
            {
                string numberoutofrange = string.Format("{0} är inte inom 1 till 100", _number);
                throw new ArgumentOutOfRangeException(numberoutofrange);
            }

            if(number == _number)
            {
                string correct = string.Format("RÄTT GISSAT! Du klarade det på {0} försök.", _count);
                Console.WriteLine(correct);
                return true;
            }

            if (number < _number)
            {
                string tolow = string.Format("{0} är för lågt. Du har {1} gissningar kvar.", number, guessleft);
                Console.WriteLine(tolow);

            }

            else
            {
                string tohigh = string.Format("{0} är för högt. Du har {1} gissningar kvar.", number, guessleft);
                Console.WriteLine(tohigh);

            }

            if(_count == 7)
            {
                Console.WriteLine("Det hemliga talet är {0}.", _number);
            }
            
            return false;
            
        }

        //Konstruktor
        public SecretNumber()
        {
            Initialize();
        }

    }
   

}
