using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb_2._3
{
    class Ellipse : Shape
    {
        double a = 0;
        double b = 0;

        //Räknar ut arean.
        public override double Area
        {
            get
            {
               
                a = Length / 2;
                b = Width / 2;

                return Math.PI * a * b;
            }

        }
        //Räknar ut omkretsen.
        public override double Perimeter
        {
            get
            {
                a = Length / 2;
                b = Width / 2;

                return Math.PI * Math.Sqrt(2 * a * a + 2 * b * b);
            }
        }

        public Ellipse(double length, double width) :base(length, width)
        {
        }

    }
}
