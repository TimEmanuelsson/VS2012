using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Kassakvitto.Model
{
    public class Receipt
    {
        private double _subtotal = 0;

        public double DiscountRate
        {
            get;
            private set;
        }
        public double MoneyOff
        {
            get;
            private set;
        }
        public double Subtotal
        {
            get;
            private set;
        }
        public double Total
        {
            get;
            private set;
        }
        public void Calculate(double subtotal)
        {

        }
        public Receipt(double subtotal)
        {
          
        }

    }

}
    