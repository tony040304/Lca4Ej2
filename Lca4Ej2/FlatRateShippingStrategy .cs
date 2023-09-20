using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lca4Ej2
{
    public class FlatRateShippingStrategy : IStrategy
    {
        public double CalculateShippingCost(double orderAmount)
        {
            // Tarifa plana de envío
            return 5.0;
        }
    }
}
