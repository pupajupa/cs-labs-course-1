using Lab8.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Lab8.Tariffs;

public class Tariff : ITariff
{
    public string Destination { get; set; }
    private double price;//{ get; set; }
    private readonly IDiscountStrategy discount;

    public Tariff(string destination, double price, IDiscountStrategy discount)
    {
        Destination = destination;
        this.discount = discount;
        this.price = price;
    }

    public double Price { get { return discount.ApplyDiscount(price); } }
}
