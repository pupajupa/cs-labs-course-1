using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Collections.Specialized.BitVector32;

namespace Lab5.Models
{
    public class AirportTicketOffice
    {
        private static AirportTicketOffice? instance;
        private List<Tariff> tariffs = new();
        private List<Ticket> tickets = new();
        public static AirportTicketOffice Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new AirportTicketOffice();
                }
                return instance;
            }
        }
        public void AddTariff(Destination destination, decimal price)
        {
            tariffs.Add(new Tariff { Destinations = destination, Price = price });
        }
        public void BuyTicket(Destination destination, decimal price, Passenger passenger)
        {
            Ticket ticket = new(price, passenger);
            tickets.Add(ticket);
        }
        public decimal GetPassengerTotalPrice(Passenger passenger)
        {
            decimal totalPrice = 0;
            foreach (Ticket ticket in tickets)
            {
                if (ticket.Passenger == passenger)
                {
                    totalPrice += ticket.Price;
                }
            }
            return totalPrice;
        }
        public decimal GetTotalRevenue()
        {
            decimal totalRevenue = 0;
            foreach (Ticket ticket in tickets)
            {
                totalRevenue += ticket.Price;
            }
            return totalRevenue;
        }
    }
}
