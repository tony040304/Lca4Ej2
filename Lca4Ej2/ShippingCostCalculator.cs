using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lca4Ej2
{
    public class ShippingCostCalculator
    {
        private IStrategy _IStrategy;

        public ShippingCostCalculator(IStrategy _IStrategy)
        {
            this._IStrategy = _IStrategy;
        }

        public double CalculateShippingCost(double orderAmount)
        {
            // Utilizar la estrategia para calcular el costo de envío
            return _IStrategy.CalculateShippingCost(orderAmount);
        }
    }
}
