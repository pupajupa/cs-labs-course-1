using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4.airportStation
{    
    public class Ticket //containerized class
    {
        public string? NameStation { get; set; }
        public decimal TicketPrice { get; set; }
        public int TotalSeats { get; set; }
        public int SoldSeats { get; set; }
        public Ticket(string name,decimal price, int totalSeats,int soldSeats)
        {
            NameStation = name;
            SoldSeats = soldSeats;
            TotalSeats = totalSeats;
            TicketPrice = price;
        }
        public decimal TotalSales() => TicketPrice * SoldSeats;//общая стоимость

        public void IncreaseTicketPrice(decimal amount) => TicketPrice += amount;//увеличение стоимости билета

        public void DecreaseTicketPrice(decimal amount)//уменьшение стоимости билета
        {
            if (TicketPrice - amount > 0)
            {
                TicketPrice -= amount;
            }
        }
    }

    public class Station //container class
    {
        private static Station instance;
        private List<Ticket> tickets;
        private Station() => tickets = new List<Ticket>();
        public static Station Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Station();
                    //return instance;
                }
                return instance;
            }
        }
        public void AddTicket(Ticket ticket) => tickets.Add(ticket);

        public void RemoveTicket(Ticket ticket) => tickets.Remove(ticket);

        public decimal TotalSales()
        {
            decimal totalSales = 0;
            foreach (var ticket in tickets)
            {
                totalSales += ticket.TotalSales();
            }
            return totalSales;
        }
        public int TotalSeats()
        {
            int totalSeats = 0;
            foreach (var ticket in tickets)
            {
                totalSeats += ticket.TotalSeats;
            }
            return totalSeats;
        }
    }
}
