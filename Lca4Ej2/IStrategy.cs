using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lca4Ej2
{
    public interface IStrategy
    {
        double CalculateShippingCost(double orderAmount);
    }
}
