using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitorInterface
{
    public class TaxHolidayVisitor : IVisitor
    {
        public TaxHolidayVisitor() { }

        public double visit(Liquor liquorItem)
        {
            Console.WriteLine("Liquor item: Price with Tax");
            return Convert.ToDouble((liquorItem.getPrice() * 0.10)
                + liquorItem.getPrice());
        }

        public double visit(Tobacco tobaccoItem)
        {
            Console.WriteLine("Tobacco item: Price with Tax");
            return Convert.ToDouble((tobaccoItem.getPrice() * 0.30)
                + tobaccoItem.getPrice());
        }

        public double visit(Necessity necessityItem)
        {
            Console.WriteLine("Necessity item: Price with Tax");
            return Convert.ToDouble((necessityItem.getPrice() * 0)
                + necessityItem.getPrice());
        }
    }
}
