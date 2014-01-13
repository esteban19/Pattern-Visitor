using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitorInterface
{
    public class Liquor : IVisitable
    {
        private double price;
        public Liquor(double item) { price = item; }
        public double getPrice() { return price; }

        public double accept(IVisitor visitor)
        {
            return visitor.visit(this);//passing a ref to this Liquor
            //finds out it's a Liquor item(IVisitor)
            //and performs calculations based on that fact
            //Goes to TaxVisitor (implements IVisitor)
            //and calls the visit function corresponding to Liquor
        }
    }
}
