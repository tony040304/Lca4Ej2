using Lca4Ej2;

class Program
{
    static void Main(string[] args)
    {
        double orderAmount = 100.0;

        // Utilizar una estrategia de tarifa plana para el cálculo de costo de envío
        IStrategy flatRateStrategy = new FlatRateShippingStrategy();
        ShippingCostCalculator flatRateCalculator = new ShippingCostCalculator(flatRateStrategy);
        double flatRateShippingCost = flatRateCalculator.CalculateShippingCost(orderAmount);
        Console.WriteLine("Costo de envío con tarifa plana: $" + flatRateShippingCost);

        // Utilizar una estrategia de porcentaje para el cálculo de costo de envío
        IStrategy percentageBasedStrategy = new PercentageBasedShippingStrategy(2.5);
        ShippingCostCalculator percentageBasedCalculator = new ShippingCostCalculator(percentageBasedStrategy);
        double percentageBasedShippingCost = percentageBasedCalculator.CalculateShippingCost(orderAmount);
        Console.WriteLine("Costo de envío basado en porcentaje: $" + percentageBasedShippingCost);
    }
}
