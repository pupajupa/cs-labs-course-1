using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5.Models
{
    public class Ticket
    {
        private static int lastId = 0;
        public int Id { get; }
        public decimal Price { get; set; }
        public Passenger Passenger { get; set; }

        public Ticket(decimal price, Passenger passenger)
        {
            Id = ++lastId;
            this.Price = price;
            this.Passenger = passenger;
        }
    }
}
