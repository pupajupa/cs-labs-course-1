using Lab5.Models;

namespace Lab5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AirportTicketOffice Airport = AirportTicketOffice.Instance;
            Passenger first = new();
            first.Name = "Tom";
            first.Surname = "Flutten";
            first.PassportNumber = "228337001D";
            Passenger second = new();
            first.Name = "Boris";
            first.Surname = "Britva";
            first.PassportNumber = "12312SDSS";
            Tariff MinskLine = new();
            MinskLine.Destinations = Destination.Minsk;
            MinskLine.Price = 160;
            Ticket ticket = new(500, first);
            Airport.AddTariff(Destination.Minsk, 150);
            Airport.AddTariff(Destination.Paris, 220);
            Airport.BuyTicket(Destination.Minsk, 150, first);
            Airport.BuyTicket(Destination.Paris, 220, first);
            Airport.BuyTicket(Destination.NewYork, 1000, second);
            Console.WriteLine($"Первый пассажир: {first.Name} {first.Surname} \nПасспортный номер: {first.PassportNumber}\n" +
                $"Стоимость купленных пассажиром билетов: {Airport.GetPassengerTotalPrice(first)}");
            Console.WriteLine($"Второй пассажир: {second.Name} {second.Surname} \nПасспортный номер: {second.PassportNumber}\n" +
                $"Стоимость купленных пассажиром билетов: {Airport.GetPassengerTotalPrice(second)}");
            Console.WriteLine($"Стоимость всех проданных билетов: {Airport.GetTotalRevenue()}");
        }
    }
}