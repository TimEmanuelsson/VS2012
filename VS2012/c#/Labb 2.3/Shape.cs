using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb_2._3
{
    public abstract class Shape
    {
        private double _length;
        private double _width;

        public double Length
        {
            get
            {
                return _length;
            }

            set
            {
                if (Length < 0)
                {
                    throw new ArgumentException();
                }

                _length = value;
            }
        }

        abstract public double Area
        {
            get;
        }

        abstract public double Perimeter 
        { 
            get; 
        }
        

        public double Width
        {
            get
            {
                return _width;
            }

            set
            {
                if (Width < 0)
                {
                    throw new ArgumentException();
                }

                _width = value;
            }
        }
        //Skriver ut resultatet.
        public override string ToString()
        {
            return string.Format("Längd    :     {0:f2} \nBredd    :     {1:f2} \nOmkrets  :     {2:f2} \nArea     :     {3:f2}", Length, Width, Perimeter, Area);
        }

        protected Shape(double length, double width) 
        {
            Length = length;
            Width = width;
        }
    }

    public enum ShapeType
    {
        Ellipse,
        Rectangle,
    }

}
