using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab8.Interfaces;
namespace Lab8.Airport;

public class Airport
{
    private List<ITariff> _tariffs = new List<ITariff>();

    public void AddTariff(ITariff tariff)
    {
        _tariffs.Add(tariff);
    }

    public string FindMaxPriceDestination()
    {
        double maxPrice = 0;
        string maxPriceDestination = "";
        foreach (ITariff tariff in _tariffs)
        {
            //double discountedPrice = discountStrategy.ApplyDiscount(tariff.Price);

            if (tariff.Price > maxPrice)
            {
                maxPrice = tariff.Price;
                maxPriceDestination = tariff.Destination;
            }
        }
        return maxPriceDestination;
    }
}
