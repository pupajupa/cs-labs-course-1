using Lab8.Interfaces;
using Lab8.Tariffs;
namespace Lab8;

internal class Program
{
    static void Main(string[] args)
    {
        Airport.Airport airport = new();

        airport.AddTariff(new Tariff("New York", 1000, new NoDiscountStrategy()));
        airport.AddTariff(new Tariff("London", 1000, new PercentageDiscountStrategy(10)));
        airport.AddTariff(new Tariff("Paris", 900, new PercentageDiscountStrategy(10)));

        //IDiscountStrategy noDiscount = new NoDiscountStrategy();
        //IDiscountStrategy percentageDiscount = new PercentageDiscountStrategy(10);

        string maxPriceDestination = airport.FindMaxPriceDestination();
        Console.WriteLine($"Max price destination without discount: {maxPriceDestination}");

        maxPriceDestination = airport.FindMaxPriceDestination();
        Console.WriteLine($"Max price destination with 10% discount: {maxPriceDestination}");
    }
}