using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5.Models
{
    public class Tariff
    {
        public Destination Destinations { get; set; }
        public decimal Price { get; set; }
    }
    public enum Destination
    {
        London,
        Paris,
        NewYork,
        Tokyo,
        Minsk,
        Berlin,
        Pekin,
        Moscow
    }
}

