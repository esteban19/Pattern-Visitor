using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitorInterface
{
    public class VisitorTest
    {
        public static void Main(string[] args)
        {
            TaxVisitor taxCalc = new TaxVisitor();
            TaxHolidayVisitor taxHoli = new TaxHolidayVisitor();

            Necessity milk = new Necessity(3.47);
            Liquor vodka = new Liquor(11.99);
            Tobacco cigars = new Tobacco(19.99);

            Console.WriteLine("Normal Prices:");
            Console.WriteLine(milk.accept(taxCalc));
            Console.WriteLine(vodka.accept(taxCalc));
            Console.WriteLine(cigars.accept(taxCalc));

            Console.WriteLine("Holiday Prices:");
            Console.WriteLine(milk.accept(taxHoli));
            Console.WriteLine(vodka.accept(taxHoli));
            Console.WriteLine(cigars.accept(taxHoli));

        }
    }
}
