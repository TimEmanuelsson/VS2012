using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb_2._3
{
    

       class Rectangle : Shape      
    {
        //Räknar ut arean.
        public override double Area
        {
            get
            {
                return Length * Width;
            }      
        }
        //Räknar ut omkretsen.
        public override double Perimeter
        {
            get
            {
                return Length * 2 + Width * 2;
            }
        }

        public Rectangle(double length, double width) :base(length, width)
        {
        }
    }
}

