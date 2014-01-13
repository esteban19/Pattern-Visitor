using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitorInterface
{
    public class Necessity : IVisitable
    {
        private double price;
        public Necessity(double item) { price = item; }
        public double getPrice() { return price; }

        public double accept(IVisitor visitor)
        {
            return visitor.visit(this);
        }
    }
}
