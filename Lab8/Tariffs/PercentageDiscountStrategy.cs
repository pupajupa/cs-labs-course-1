using Lab8.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8.Tariffs;

public class PercentageDiscountStrategy : IDiscountStrategy
{
    private double _discount;

    public PercentageDiscountStrategy(double discount)
    {
        _discount = discount;
    }

    public double ApplyDiscount(double price)
    {
        return price * (1 - _discount / 100);
    }
}

