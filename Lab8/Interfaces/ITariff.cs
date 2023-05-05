using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8.Interfaces;

public interface ITariff
{
    string Destination { get; set; }
    double Price { get; }
}

