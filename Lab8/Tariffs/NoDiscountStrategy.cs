using Lab8.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8.Tariffs;

public class NoDiscountStrategy : IDiscountStrategy
{
    public double ApplyDiscount(double price)
    {
        return price;
    }
}
