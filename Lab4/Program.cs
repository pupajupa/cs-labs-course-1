using Lab4.airportStation;
using System.Diagnostics;

namespace Lab4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Инициализация экземпляра
            Station container = Station.Instance;
            // Добавление билета
            Ticket ticket1 = new Ticket("Moscow",100,150,25);
            Ticket ticket2 = new Ticket("Minsk", 8, 300,60);
            container.AddTicket(ticket2);

            Console.WriteLine($"Количество мест: {container.TotalSeats()}");

            Console.WriteLine($"Количество проданных билетов: {container.TotalSales()}");

            Console.WriteLine($"Общая прибыль: {container.TotalSales()}");
        }
    }
}