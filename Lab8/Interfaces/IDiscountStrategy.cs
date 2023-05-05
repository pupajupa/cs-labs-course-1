using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8.Interfaces;

public interface IDiscountStrategy
{
    double ApplyDiscount(double price);
}
