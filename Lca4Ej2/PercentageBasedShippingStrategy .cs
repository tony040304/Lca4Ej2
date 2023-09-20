using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lca4Ej2
{
    internal class PercentageBasedShippingStrategy : IStrategy
    {
        private double percentage;

        public PercentageBasedShippingStrategy(double percentage)
        {
            this.percentage = percentage;
        }
        public double CalculateShippingCost(double orderAmount)
        {
            // Calcular costo de envío basado en un porcentaje del monto del pedido
            return orderAmount * (percentage / 100.0);
        }
    }
}
