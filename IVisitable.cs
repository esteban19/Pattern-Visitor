using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitorInterface
{
    public interface IVisitable
    {
        double accept(IVisitor visitor);
    }
}
